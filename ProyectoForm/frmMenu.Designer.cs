namespace ProyectoForm
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            PanelMenuTop = new Panel();
            label5 = new Label();
            lblUsuario = new Label();
            lblFecha = new Label();
            label3 = new Label();
            PanelLogo = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            PanelMenu = new Panel();
            btnVentas = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnTrabajadores = new Button();
            PanelContenido = new Panel();
            lblNombreFormulario = new Label();
            PanelMenuTop.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenuTop
            // 
            PanelMenuTop.BackColor = Color.MidnightBlue;
            PanelMenuTop.Controls.Add(lblNombreFormulario);
            PanelMenuTop.Controls.Add(label5);
            PanelMenuTop.Controls.Add(lblUsuario);
            PanelMenuTop.Controls.Add(lblFecha);
            PanelMenuTop.Controls.Add(label3);
            PanelMenuTop.Location = new Point(182, 1);
            PanelMenuTop.Name = "PanelMenuTop";
            PanelMenuTop.Size = new Size(1262, 62);
            PanelMenuTop.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(883, 31);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 9;
            label5.Text = "Fecha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(931, 10);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(71, 17);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "lblUsuario";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(931, 32);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(61, 17);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "lblFecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(873, 10);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 6;
            label3.Text = "Usuario:";
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.MidnightBlue;
            PanelLogo.Controls.Add(pictureBox2);
            PanelLogo.Controls.Add(label1);
            PanelLogo.Location = new Point(2, 1);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(181, 65);
            PanelLogo.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 2);
            label1.Name = "label1";
            label1.Size = new Size(114, 62);
            label1.TabIndex = 1;
            label1.Text = "Reporte de Empresa";
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.MidnightBlue;
            PanelMenu.Controls.Add(btnVentas);
            PanelMenu.Controls.Add(btnProductos);
            PanelMenu.Controls.Add(btnClientes);
            PanelMenu.Controls.Add(btnTrabajadores);
            PanelMenu.Location = new Point(1, 64);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(182, 856);
            PanelMenu.TabIndex = 6;
            // 
            // btnVentas
            // 
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 180);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(15, 0, 0, 0);
            btnVentas.Size = new Size(182, 60);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 120);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(15, 0, 0, 0);
            btnProductos.Size = new Size(182, 60);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 60);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(15, 0, 0, 0);
            btnClientes.Size = new Size(182, 60);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnTrabajadores
            // 
            btnTrabajadores.Cursor = Cursors.Hand;
            btnTrabajadores.Dock = DockStyle.Top;
            btnTrabajadores.FlatStyle = FlatStyle.Flat;
            btnTrabajadores.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrabajadores.ForeColor = Color.White;
            btnTrabajadores.Image = (Image)resources.GetObject("btnTrabajadores.Image");
            btnTrabajadores.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrabajadores.Location = new Point(0, 0);
            btnTrabajadores.Name = "btnTrabajadores";
            btnTrabajadores.Padding = new Padding(15, 0, 0, 0);
            btnTrabajadores.Size = new Size(182, 60);
            btnTrabajadores.TabIndex = 1;
            btnTrabajadores.Text = "Trabajadores";
            btnTrabajadores.TextAlign = ContentAlignment.MiddleLeft;
            btnTrabajadores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrabajadores.UseVisualStyleBackColor = true;
            btnTrabajadores.Click += btnTrabajadores_Click;
            // 
            // PanelContenido
            // 
            PanelContenido.BackColor = Color.GhostWhite;
            PanelContenido.Location = new Point(182, 64);
            PanelContenido.Name = "PanelContenido";
            PanelContenido.Size = new Size(1243, 722);
            PanelContenido.TabIndex = 2;
            // 
            // lblNombreFormulario
            // 
            lblNombreFormulario.AutoSize = true;
            lblNombreFormulario.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreFormulario.ForeColor = Color.White;
            lblNombreFormulario.Location = new Point(23, 19);
            lblNombreFormulario.Name = "lblNombreFormulario";
            lblNombreFormulario.Size = new Size(17, 25);
            lblNombreFormulario.TabIndex = 0;
            lblNombreFormulario.Text = " ";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 722);
            Controls.Add(PanelContenido);
            Controls.Add(PanelMenu);
            Controls.Add(PanelLogo);
            Controls.Add(PanelMenuTop);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += frmMenu_Load;
            PanelMenuTop.ResumeLayout(false);
            PanelMenuTop.PerformLayout();
            PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuTop;
        private Label label5;
        private Label lblUsuario;
        private Label lblFecha;
        private Label label3;
        private Panel PanelLogo;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel PanelMenu;
        private Button btnVentas;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnTrabajadores;
        private Panel PanelContenido;
        private Label lblNombreFormulario;
    }
}