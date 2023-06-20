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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        int idProducto;
        private void frmProductos_Load(object sender, EventArgs e)
        {
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
            GetAllProductos();
        }


        private void AsignarUri(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7163/api/Producto/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private async void GetAllProductos()
        {
            List<ProductoDto> listaProductos = new();
            using (var client = new HttpClient())

            {

                AsignarUri(client);

                var response = await client.GetAsync("https://localhost:7163/api/Producto/GetProductos");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<ProductoDto>>(content);
                    dgvProductos.DataSource = result.ToList();
                }
                else { MessageBox.Show($"No se pudo obtener la lista de Productos:{response.StatusCode}"); }


            }

        }
        private async void AddProducto()
        {
            using (var client = new HttpClient())
            {
                RegistrarProductoDto Producto = new()
                {

                    PrecioProducto = double.Parse(txtPrecio.Text),
                    Existencias = int.Parse(txtExistencias.Text),
                    NombreProducto = txtNombreProducto.Text
                };

                AsignarUri(client);

                var response = await client.PostAsJsonAsync("AddProducto", Producto);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Producto Guardado con exito");
                    GetAllProductos();
                    Clear(this);
                }
                else { MessageBox.Show($"Error al guardar el producto:{response.Content.ReadAsStringAsync().Result}"); }


            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

     
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddProducto();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idProducto !=0) { EliminarProducto(); }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        idProducto = int.Parse(row.Cells[0].Value.ToString());
                        GetProductoById();
                    }
                }
                btnNuevo.Enabled = false;
                btnBorrar.Enabled = true;
                btnModificar.Enabled = true;
                btnClear.Enabled = true;
            
        }

        private async void UpdateProducto(int id)
        {
            ActualizarProductoDto productoDto = new()
            {
                IdProducto = int.Parse(txtIDProducto.Text),
                NombreProducto = txtNombreProducto.Text,
                Existencias = int.Parse(txtExistencias.Text),
                PrecioProducto = double.Parse(txtPrecio.Text)

            };
            using (var client = new HttpClient())
            {
                var serializedCliente = JsonConvert.SerializeObject(productoDto);
                var content = new StringContent(serializedCliente, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7163/api/Producto", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Error al actualizar el Producto: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear(this);
            GetAllProductos();
        }

        private void Clear(Form f)
        {
           foreach(Control Controls in f.Controls)
            {
                if (Controls is TextBox)
                {
                    Controls.Text = "";
                }

            }
        }

        private async void GetProductoById()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7163/api/Producto",idProducto));
                if (response.IsSuccessStatusCode)
                {
                    var Produc = await response.Content.ReadAsStringAsync();
                    ProductoDto ProductoDto = JsonConvert.DeserializeObject<ProductoDto>(Produc);
                    txtIDProducto.Text = ProductoDto.IdProducto.ToString();
                    txtNombreProducto.Text = ProductoDto.NombreProducto;

                    txtExistencias.Text =ProductoDto.Existencias.ToString();
                    txtPrecio.Text = ProductoDto.PrecioProducto.ToString();
                }
                else
                {
                    MessageBox.Show($"No se pudo obtener el Producto: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idProducto !=0)
            { 
                UpdateProducto(idProducto); 
            }
        }
        private async void EliminarProducto()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7163/api/Producto");
                var response = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7163/api/Producto", idProducto));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Producto eliminado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"No se pudo eliminar el Producto: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear(this);
            GetAllProductos();
        }

        private void txtIDProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDProducto, "Ingrese solo Números");
            else
                erpError.Clear();

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtPrecio, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombreProducto, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtIDExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtPrecio, "Ingrese solo Números");
            else
                erpError.Clear();

        }
    }
}
