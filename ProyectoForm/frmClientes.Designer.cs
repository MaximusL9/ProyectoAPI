﻿namespace ProyectoForm
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            statusStrip1 = new StatusStrip();
            slblFecha = new ToolStripStatusLabel();
            slblHora = new ToolStripStatusLabel();
            label4 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnModificar = new Button();
            btnBorrar = new Button();
            dgvClientes = new DataGridView();
            btnClear = new Button();
            btnNuevo = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtIDCliente = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtIDVenta = new TextBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.Top;
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { slblFecha, slblHora });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1048, 25);
            statusStrip1.TabIndex = 88;
            statusStrip1.Text = "statusStrip1";
            // 
            // slblFecha
            // 
            slblFecha.Name = "slblFecha";
            slblFecha.Size = new Size(50, 20);
            slblFecha.Text = "Fecha:";
            // 
            // slblHora
            // 
            slblHora.Name = "slblHora";
            slblHora.Size = new Size(45, 20);
            slblHora.Text = "Hora:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(451, 129);
            label4.Name = "label4";
            label4.Size = new Size(20, 13);
            label4.TabIndex = 144;
            label4.Text = "(*)";
            // 
            // label13
            // 
            label13.Location = new Point(404, 129);
            label13.Name = "label13";
            label13.Size = new Size(53, 13);
            label13.TabIndex = 140;
            label13.Text = "Telefono:";
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(454, 81);
            label14.Name = "label14";
            label14.Size = new Size(20, 13);
            label14.TabIndex = 142;
            label14.Text = "(*)";
            // 
            // label15
            // 
            label15.Location = new Point(404, 81);
            label15.Name = "label15";
            label15.Size = new Size(55, 13);
            label15.TabIndex = 139;
            label15.Text = "Dirección:";
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(761, 81);
            label11.Name = "label11";
            label11.Size = new Size(20, 13);
            label11.TabIndex = 135;
            label11.Text = "(*)";
            // 
            // label12
            // 
            label12.Location = new Point(714, 81);
            label12.Name = "label12";
            label12.Size = new Size(52, 13);
            label12.TabIndex = 133;
            label12.Text = "ID Venta:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 20);
            txtNombre.TabIndex = 131;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(189, 129);
            label5.Name = "label5";
            label5.Size = new Size(20, 13);
            label5.TabIndex = 132;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.Location = new Point(88, 129);
            label6.Name = "label6";
            label6.Size = new Size(105, 13);
            label6.TabIndex = 128;
            label6.Text = "Nombres y Apellidos:";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(141, 81);
            label7.Name = "label7";
            label7.Size = new Size(20, 13);
            label7.TabIndex = 130;
            label7.Text = "(*)";
            // 
            // label8
            // 
            label8.Location = new Point(88, 81);
            label8.Name = "label8";
            label8.Size = new Size(56, 13);
            label8.TabIndex = 127;
            label8.Text = "ID Cliente:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.Location = new Point(870, 196);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(37, 21);
            btnModificar.TabIndex = 125;
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.WhiteSmoke;
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
            btnBorrar.Location = new Point(913, 196);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(37, 21);
            btnBorrar.TabIndex = 126;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeight = 30;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.DimGray;
            dgvClientes.Location = new Point(40, 235);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(965, 365);
            dgvClientes.TabIndex = 121;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(956, 196);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(37, 21);
            btnClear.TabIndex = 124;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.MediumSeaGreen;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(59, 196);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(116, 29);
            btnNuevo.TabIndex = 120;
            btnNuevo.Text = "Agregar";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(21, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 1);
            panel1.TabIndex = 122;
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 123;
            label1.Text = "Lista de Clientes";
            // 
            // label3
            // 
            label3.BackColor = Color.MidnightBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 27);
            label3.Name = "label3";
            label3.Size = new Size(1004, 40);
            label3.TabIndex = 119;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(1004, 550);
            label2.TabIndex = 118;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(91, 97);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(233, 20);
            txtIDCliente.TabIndex = 145;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(404, 97);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(233, 20);
            txtDireccion.TabIndex = 146;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(404, 145);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(233, 20);
            txtTelefono.TabIndex = 147;
            // 
            // txtIDVenta
            // 
            txtIDVenta.Location = new Point(714, 97);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(233, 20);
            txtIDVenta.TabIndex = 148;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1048, 549);
            ControlBox = false;
            Controls.Add(txtIDVenta);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtIDCliente);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(dgvClientes);
            Controls.Add(btnClear);
            Controls.Add(btnNuevo);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmClientes";
            Text = "Lista de Clientes";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblFecha;
        private ToolStripStatusLabel slblHora;
        private TextBox txtSalario;
        private Label label17;
        private Label label16;
        private TextBox txtFecha;
        private Label label4;
        private Label label13;
        private TextBox txtCargo;
        private Label label14;
        private Label label15;
        private TextBox txtCiudad;
        private Label label9;
        private Label label10;
        private TextBox txtPais;
        private Label label11;
        private Label label12;
        private TextBox txtNombre;
        private Label label5;
        private Label label6;
        private TextBox txtNumeroINSS;
        private Label label7;
        private Label label8;
        private Button btnModificar;
        private Button btnBorrar;
        private DataGridView dgvClientes;
        private Button btnClear;
        private Button btnNuevo;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtIDCliente;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtIDVenta;
    }
}