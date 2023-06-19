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
    public partial class frmMenu : Form
    {
        private static Button botonmenuactivo = null;
        private static Form formularioactivo = null;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Administrador";
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            PanelMenuTop.BackColor = Color.FromArgb(20, 20, 95);
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmTrabajadores());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmClientes());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmProductos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmVentas());
        }
        private void AbrirFormulario(Form FormularioHijo)
        {
            if (formularioactivo != null)
            {
                formularioactivo.Close();
            }
            formularioactivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            FormularioHijo.BackColor = Color.GhostWhite;
            PanelContenido.Controls.Add(FormularioHijo);
            PanelContenido.Tag = FormularioHijo;
            FormularioHijo.Show();
            lblNombreFormulario.Text = FormularioHijo.Text;
        }
        private void BotonActivo(Button BotonSeleccionado)
        {
            if (botonmenuactivo != null)
            {
                botonmenuactivo.BackColor = Color.MidnightBlue;
            }
            botonmenuactivo = BotonSeleccionado;
            BotonSeleccionado.BackColor = Color.FromArgb(92, 92, 197);
        }
    }
}
