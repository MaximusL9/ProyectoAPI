using Newtonsoft.Json;
using ProyectoForm.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoForm
{
    public partial class frmVentas : Form
    {
        private List<ProductoDgv> Pdgv = new ();
        
        double Total = 0;
        double Impuestos = 0;
        
        public frmVentas()
        {
            InitializeComponent();
        }

        private async void frmVentas_Load(object sender, EventArgs e)
        {
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
            btnVentas.Enabled = false;
            txtDinRecib.Enabled = false;
            txtIDcliente.Enabled = false;
            
        }




        private void AsignarUri(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7163/api/Producto/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        private async Task<List<ProductoDto>> GetAllProductos()
        {

            using (var client = new HttpClient())

            {

                AsignarUri(client);

                var response = await client.GetAsync("https://localhost:7163/api/Producto/");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    List<ProductoDto> result = JsonConvert.DeserializeObject<List<ProductoDto>>(content);
                    return result;
                }

                return null;

            }


        }

        private async void GetIdProducts(int id, int Cantidad)
        {
            ProductoDto result;
            ProductoDgv ProductoVenta;
            using (var client = new HttpClient())

            {

                AsignarUri(client);

                var response = await client.GetAsync($"{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<ProductoDto>(content);

                    ProductoVenta = new ProductoDgv()
                    {
                        IdProducto = result.IdProducto,
                        PrecioProducto = result.PrecioProducto,
                        NombreProducto = result.NombreProducto,
                        cantidad = Cantidad
                    };
                    Pdgv.Add(ProductoVenta);
                    dgvVentas.DataSource = null;
                    dgvVentas.DataSource = Pdgv;

                }
                else
                {
                    MessageBox.Show("Error , El id proporcionado no corresponde a algun producto existente");
                }

               
            }

        }

     
        private async void GetAllVentas()
        {
            using (var client = new HttpClient())

            {

                var response = await client.GetAsync("https://localhost:7163/api/Venta/GetAllVentas");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    List<VentaDto> result = JsonConvert.DeserializeObject<List<VentaDto>>(content);
                    dgvVentas.DataSource = result;
                }

            }

        }

       
        private void AsignarUriVentas(HttpClient client)
        {

            client.BaseAddress = new Uri("https://localhost:7163/api/Venta/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
       
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            if (txtIDProducto.Text!="" && txtCantProduct.Text != "")
            {
                GetIdProducts(int.Parse(txtIDProducto.Text), int.Parse(txtCantProduct.Text)); 
            }
        
        }
        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        
        private  void btnVentas_Click(object sender, EventArgs e)
        {

                agregarVentas(Total, Impuestos);
                
        }

        private async void agregarVentas(double total, double impuestos)
        {
           using(var client = new HttpClient())
            {
                if (txtDinRecib.Text != "" )
                {
                    if (txtIDcliente.Text == "" && double.Parse(txtDinRecib.Text) > (Total + Impuestos))
                    {
                        DateTime fecha = DateTime.Now;
                        RegistrarVentaDto Venta = new()
                        {

                            Iva = impuestos,
                            TotalVenta = total,
                            Cambio = double.Parse(txtDinRecib.Text) - (total+Impuestos),

                            Fecha = fecha

                        };
                        lblCambio.Text = Venta.Cambio.ToString();

                        AsignarUriVentas(client);

                        var response = await client.PostAsJsonAsync("AddVenta", Venta);

                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Error al guardar la venta: {response.StatusCode}");
                        }
                        else { btnNuevo.Enabled = true;  btnVentas.Enabled = true; }
                    }
                    else
                    {
                        if (txtIDcliente.Text=="" &&double.Parse(txtDinRecib.Text) > (Total + Impuestos))
                        {
                            DateTime fecha = DateTime.Now;
                            RegistrarVentaDto Venta = new()
                            {

                                Iva = impuestos,
                                TotalVenta = total,
                                Cambio = double.Parse(txtDinRecib.Text) - total,
                                IdCliente = int.Parse(txtIDcliente.Text),
                                Fecha = fecha

                            };
                            lblCambio.Text = Venta.Cambio.ToString();

                            AsignarUriVentas(client);

                            var response = await client.PostAsJsonAsync("AddVenta", Venta);

                            if (!response.IsSuccessStatusCode)
                            {
                                MessageBox.Show($"Error al guardar la venta: {response.StatusCode}");
                            }
                            else
                            {
                                lblCambio.Text = (double.Parse(txtDinRecib.Text) - total).ToString();
                                btnVentas.Enabled = false;
                                btnNuevo.Enabled = true;
                            }
                        }
                        else { MessageBox.Show("pago insuficiente"); }
                    }
                }
                else { MessageBox.Show("Pago insuficiente"); }
               
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            GetAllVentas();
        }

        private async void TotalPagar () {
           
            if (dgvVentas != null)
            {


                foreach (DataGridViewRow Item in dgvVentas.Rows)
                {
                    double Precio =   double.Parse(Item.Cells[2].Value.ToString());
                    double Cantidad = int.Parse(Item.Cells[3].Value.ToString());

                    Total = Total + (Precio * Cantidad);
                    
                }

                Impuestos = Total * 0.15;
                lblTotal.Text = (Total + Impuestos).ToString();
               
                btnNuevo.Enabled = false;
              }
            
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            txtDinRecib.Enabled = true;
            txtIDcliente.Enabled = true;
            TotalPagar();
            btnVentas.Enabled = true;
        }

        private void txtIDProduct_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDinRecib_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtDinRecib, "Ingrese solo Números");
            else
                erpError.Clear();

        }

        private void txtIDcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDcliente, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtCantProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtCantProduct, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtIDProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDProducto, "Ingrese solo Números");
            else
                erpError.Clear();
        }
    }
}
