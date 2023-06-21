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
        //Mandar a llamar todos los clientes
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
                    MessageBox.Show($"No se puede obtener la lista de clientes {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AddClienteAsync();
        }
        //Mandar a llamar todos los clientes
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
                    MessageBox.Show("Cliente Agregado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Error al guardar el cliente: {result.Content.ReadAsStringAsync().Result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            GetAllClientes();
        }
        //Limpiar todos los textbox
        private void Clear()
        {
            txtIDCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            btnNuevo.Enabled = false;
        }
        private static int id = 0;
        //Rellenar las celdas al tocar una celda del datagridview
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
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
            btnLimpiar.Enabled = true;
        }
        //Conseguir un cliente con el id
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
                    MessageBox.Show($"No se pudo obtener el cliente: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                UpdateCliente(id);
        }
        //Modificar cliente con el metodo put
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
                    MessageBox.Show("Cliente actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Error al actualizar el cliente: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            GetAllClientes();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (id != 0)
                DeleteCliente();
        }
        //Metodo para borrar clientes
        private async void DeleteCliente()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7163/api/Cliente/DeleteCliente?Id=");
                var response = await client.DeleteAsync(String.Format("{0}{1}", "https://localhost:7163/api/Cliente/DeleteCliente?Id=", id));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Cliente eliminado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"No se pudo eliminar el cliente: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            GetAllClientes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //Validaciones para los textbox solo entren letras o numeros
        private void txtIDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDCliente, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombre, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumerosYGuion(e);
            if (!valida)
                erpError.SetError(txtTelefono, "Ingrese solo Números");
            else
                erpError.Clear();
        }
        //Validar que los campos de los textbox no esten vacios
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtTelefono.Text);
            btnNuevo.Enabled = vr;
            btnBorrar.Enabled = vr;
            btnModificar.Enabled = vr;
            btnLimpiar.Enabled = vr;
        }

        private void txtIDCliente_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNombre_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtDireccion_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtTelefono_TextChanged(object sender, EventArgs e) { ValidarCampo(); }
    }
}
