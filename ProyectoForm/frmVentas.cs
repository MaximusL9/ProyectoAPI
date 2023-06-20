using Newtonsoft.Json;
using ProyectoForm.Dto;
using System;
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
        public frmVentas()
        {
            InitializeComponent();
        }

        private async void frmVentas_Load(object sender, EventArgs e)
        {
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();

            var productos = await GetAllProductos();
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

        private async void agregarVentas(RegistrarVentaDto Venta)
        {
            using (var client = new HttpClient())
            {


                AsignarUriVentas(client);

                var response = await client.PostAsJsonAsync("AddVenta", Venta);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Venta guardad con exito");
                    GetAllVentas();
                }
                else { MessageBox.Show($"Error al guardar la venta:{response.Content.ReadAsStringAsync().Result}"); }


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
            GetIdProducts(int.Parse(txtIDProducto.Text), int.Parse(txtCantProduct.Text));
        }
    }
}
