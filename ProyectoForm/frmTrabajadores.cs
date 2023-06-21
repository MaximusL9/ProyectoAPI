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
        //Metodo para llamar a todos los empleados
        private async void GetAllEmpleados()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7163/api/Trabajador");
                if (response.IsSuccessStatusCode)
                {
                    var empleados = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<EmployeeDto>>(empleados);
                    dgvTrabajadores.DataSource = result.ToList();
                }
                else
                {
                    MessageBox.Show($"No se puede obtener la lista de empleados {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddEmpleado();
        }
        //Metodo para agregar nuevos empleados
        private async void AddEmpleado()
        {
            EmployeeCreateDto employeeDto = new EmployeeCreateDto();
            employeeDto.NumeroInss = int.Parse(txtNumeroINSS.Text);
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
                    MessageBox.Show("Empleado Agregado Correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Error al guardar el empleado: {result.Content.ReadAsStringAsync().Result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            GetAllEmpleados();
        }
        //Limpiar los textbox
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
        }
        private static int inss = 0;
        //Rellenar los textbox al presionar una celda del datagridview
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
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnLimpiar.Enabled = true;
        }
        //Conseguir empleados por el Inss(id)
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
                    MessageBox.Show($"No se pudo obtener el empleado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (inss != 0)
                UpdateEmpleado(inss);
        }
        //Metodo Put para modificar los empleados
        private async void UpdateEmpleado(int inss)
        {
            EmployeeUpdateDto employeeDto = new()
            {
                NumeroInss = inss,
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text,
                DateofBirth = dtpFecha.Value.ToShortDateString(),
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
                    MessageBox.Show("Empleado actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Error al actualizar el empleado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            GetAllEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (inss != 0)
                DeleteEmpleado();
        }
        //Metodo para borrar empleados existentes de la base de datos
        private async void DeleteEmpleado()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7163/api/Trabajador");
                var response = await client.DeleteAsync(String.Format("{0}/{1}", "https://localhost:7163/api/Trabajador", inss));
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Empleado eliminado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"No se pudo eliminar el empleado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
            GetAllEmpleados();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //Validaciones de los textbox para que solo entren letras o numeros
        private void txtNumeroINSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtNumeroINSS, "Ingrese solo Números");
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

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtCargo, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtPais, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtCiudad, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtSalario, "Ingrese solo Números");
            else
                erpError.Clear();
        }
        //Validar que los textbox no esten vacios 
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNumeroINSS.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtCargo.Text) && !string.IsNullOrEmpty(txtPais.Text) && !string.IsNullOrEmpty(txtCiudad.Text) && !string.IsNullOrEmpty(txtSalario.Text);
            btnAgregar.Enabled = vr;
            btnEliminar.Enabled = vr;
            btnModificar.Enabled = vr;
            btnLimpiar.Enabled = vr;
        }

        private void txtNumeroINSS_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNombre_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCargo_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtPais_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCiudad_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtSalario_TextChanged(object sender, EventArgs e) { ValidarCampo(); }
    }
}
