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
    public partial class frmTrabajadores : Form
    {
        public frmTrabajadores()
        {
            InitializeComponent();
        }

        private void frmTrabajadores_Load(object sender, EventArgs e)
        {
            GetAllEmpleados();
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private async void GetAllEmpleados()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7163/api/Trabajador");
                if (response.IsSuccessStatusCode)
                {
                    var students = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<EmployeeDto>>(students);
                    dgvTrabajadores.DataSource = result.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de estudiantes {response.StatusCode}");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddEmpleado();
        }

        private async void AddEmpleado()
        {
            EmployeeCreateDto employeeDto = new EmployeeCreateDto();
            employeeDto.NumeroInss = Convert.ToInt32(txtNumeroINSS.Text);
            employeeDto.Nombre = txtNombre.Text;
            employeeDto.Cargo = txtCargo.Text;
            employeeDto.DateofBirth = dtpFecha.Value.ToShortDateString();
            employeeDto.Pais = txtPais.Text;
            employeeDto.Ciudad = txtCiudad.Text;
            employeeDto.Salario = Convert.ToInt32(txtSalario.Text);

            using (var client = new HttpClient())
            {
                var empleado = JsonConvert.SerializeObject(employeeDto);
                var content = new StringContent(empleado, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:7163/api/Trabajador", content);
                if (result.IsSuccessStatusCode)
                    MessageBox.Show("Empleado Agregado Correctamente");
                else
                    MessageBox.Show($"Error al guardar el empleado: {result.Content.ReadAsStringAsync().Result}");
            }
            Clear();
            GetAllEmpleados();
        }

        private void Clear()
        {
            txtNumeroINSS.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCargo.Text = string.Empty;
            dtpFecha.Text = string.Empty;
            txtPais.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtNumeroINSS.Enabled = true;
            btnAgregar.Enabled = true;
        }
        private static int inss = 0;

        private void dgvTrabajadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTrabajadores.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    inss = int.Parse(row.Cells[0].Value.ToString());
                    GetEmpladoByInss();
                }
            }
            txtNumeroINSS.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private async void GetEmpladoByInss()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7163/api/Trabajador", inss));
                if (response.IsSuccessStatusCode)
                {
                    var empleado = await response.Content.ReadAsStringAsync();
                    EmployeeDto employeeDto = JsonConvert.DeserializeObject<EmployeeDto>(empleado);
                    txtNumeroINSS.Text = employeeDto.NumeroInss.ToString();
                    txtNombre.Text = employeeDto.Nombre;
                    txtCargo.Text = employeeDto.Cargo;
                    dtpFecha.Value = Convert.ToDateTime(employeeDto.DateofBirth.ToString());
                    txtPais.Text = employeeDto.Pais;
                    txtCiudad.Text = employeeDto.Ciudad;
                    txtSalario.Text = employeeDto.Salario.ToString();
                }
                else
                {
                    MessageBox.Show($"No se pudo obtener el empleado: {response.StatusCode}");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (inss != 0)
                UpdateEmpleado(inss);
        }

        private async void UpdateEmpleado(int inss)
        {
            EmployeeUpdateDto employeeDto = new()
            {
                NumeroInss = inss,
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text,
                DateofBirth = dtpFecha.Value.ToString(),
                Pais = txtPais.Text,
                Ciudad = txtCiudad.Text,
                Salario = Convert.ToInt32(txtSalario.Text)
            };
            using (var client = new HttpClient())
            {
                var serializedEmpleado = JsonConvert.SerializeObject(employeeDto);
                var content = new StringContent(serializedEmpleado, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(String.Format("{0}/{1}", "https://localhost:7163/api/Trabajador", inss), content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Empleado actualizado correctamente");
                else
                    MessageBox.Show($"Error al actualizar el empleado: {response.StatusCode}");
            }
            Clear();
            GetAllEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (inss != 0)
                DeleteEmpleado();
        }

        private async void DeleteEmpleado()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7163/api/Trabajador");
                var response = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7163/api/Trabajador", inss));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Empleado eliminado con éxito");
                else
                    MessageBox.Show($"No se pudo eliminar el empleado: {response.StatusCode}");
            }
            Clear();
            GetAllEmpleados();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
