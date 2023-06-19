using Newtonsoft.Json;
using ProyectoForm.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoForm
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            GetAllClientes();
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private async void GetAllClientes()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7163/api/Cliente/GetAllClients");
                if (response.IsSuccessStatusCode)
                {
                    var clientes = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<ClienteDto>>(clientes);
                    dgvClientes.DataSource = result.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de clientes {response.StatusCode}");
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddClienteAsync();
        }

        private async void AddClienteAsync()
        {
            RegistrarClienteDto clienteDto = new RegistrarClienteDto();
            clienteDto.Nombre = txtNombre.Text;
            clienteDto.Direccion = txtDireccion.Text;
            clienteDto.Telefono = txtTelefono.Text;

            using (var client = new HttpClient())
            {
                var cliente = JsonConvert.SerializeObject(clienteDto);
                var content = new StringContent(cliente, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:7163/api/Cliente/AddCliente", content);
                if (result.IsSuccessStatusCode)
                    MessageBox.Show("Cliente Agregado Correctamente");
                else
                    MessageBox.Show($"Error al guardar el cliente: {result.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllClientes();
        }

        private void Clear()
        {
            txtIDCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            btnNuevo.Enabled = true;
        }
        private static int id = 0;

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    GetClienteById();
                }
            }
            btnNuevo.Enabled = false;
        }

        private async void GetClienteById()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7163/api/Cliente", id));
                if (response.IsSuccessStatusCode)
                {
                    var cliente = await response.Content.ReadAsStringAsync();
                    ClienteDto clienteDto = JsonConvert.DeserializeObject<ClienteDto>(cliente);
                    txtIDCliente.Text = clienteDto.IdCliente.ToString();
                    txtNombre.Text = clienteDto.Nombre;
                    txtDireccion.Text = clienteDto.Direccion;
                    txtTelefono.Text = clienteDto.Telefono;
                }
                else
                {
                    MessageBox.Show($"No se pudo obtener el cliente: {response.StatusCode}");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateCliente(id);
        }

        private async void UpdateCliente(int id)
        {
            ModificarClienteDto clienteDto = new()
            {
                IdCliente = Convert.ToInt32(txtIDCliente.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };
            using (var client = new HttpClient())
            {
                var serializedCliente = JsonConvert.SerializeObject(clienteDto);
                var content = new StringContent(serializedCliente, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}{1}", "https://localhost:7163/api/Cliente?Id=", id), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente actualizado correctamente");
                else
                    MessageBox.Show($"Error al actualizar el cliente: {response.StatusCode}");
            }
            Clear();
            GetAllClientes();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteCliente();
        }

        private async void DeleteCliente()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7163/api/Cliente/DeleteCliente?Id=");
                var response = await client.DeleteAsync(String.Format("{0}{1}", "https://localhost:7163/api/Cliente/DeleteCliente?Id=", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el cliente: {response.StatusCode}");
            }
            Clear();
            GetAllClientes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
