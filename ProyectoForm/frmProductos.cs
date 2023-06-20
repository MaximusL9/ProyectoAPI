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

                var response = await client.GetAsync("https://localhost:7163/api/Producto");

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
                }
                else { MessageBox.Show($"Error al guardar el producto:{response.Content.ReadAsStringAsync().Result}"); }


            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

     
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int Fila = e.RowIndex;

            if (Fila != -1)
            {
                txtExistencias.Text = dgvProductos.Rows[Fila].Cells[3].Value.ToString();
                txtPrecio.Text = dgvProductos.Rows[Fila].Cells[2].Value.ToString();
                txtNombreProducto.Text = dgvProductos.Rows[Fila].Cells[1].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddProducto();
        }
    }
}
