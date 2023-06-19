namespace ProyectoForm
{
    partial class frmTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrabajadores));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            statusStrip1 = new StatusStrip();
            slblFecha = new ToolStripStatusLabel();
            slblHora = new ToolStripStatusLabel();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvTrabajadores = new DataGridView();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCiudad = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtPais = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtNumeroINSS = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label13 = new Label();
            txtCargo = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtSalario = new TextBox();
            dtpFecha = new DateTimePicker();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajadores).BeginInit();
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
            statusStrip1.TabIndex = 87;
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
            // btnModificar
            // 
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.Location = new Point(871, 198);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(37, 21);
            btnModificar.TabIndex = 95;
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(914, 198);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(37, 21);
            btnEliminar.TabIndex = 96;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTrabajadores
            // 
            dgvTrabajadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrabajadores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTrabajadores.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTrabajadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTrabajadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajadores.EnableHeadersVisualStyles = false;
            dgvTrabajadores.GridColor = Color.DimGray;
            dgvTrabajadores.Location = new Point(41, 237);
            dgvTrabajadores.MultiSelect = false;
            dgvTrabajadores.Name = "dgvTrabajadores";
            dgvTrabajadores.ReadOnly = true;
            dgvTrabajadores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTrabajadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTrabajadores.RowTemplate.Height = 25;
            dgvTrabajadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrabajadores.Size = new Size(965, 365);
            dgvTrabajadores.TabIndex = 32;
            dgvTrabajadores.CellClick += dgvTrabajadores_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.WhiteSmoke;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(957, 198);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(37, 21);
            btnLimpiar.TabIndex = 93;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumSeaGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(60, 198);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 29);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(22, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 1);
            panel1.TabIndex = 40;
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 88;
            label1.Text = "Lista de Trabajadores";
            // 
            // label3
            // 
            label3.BackColor = Color.MidnightBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 29);
            label3.Name = "label3";
            label3.Size = new Size(1004, 40);
            label3.TabIndex = 28;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 68);
            label2.Name = "label2";
            label2.Size = new Size(1004, 550);
            label2.TabIndex = 27;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(547, 147);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(203, 20);
            txtCiudad.TabIndex = 107;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(582, 131);
            label9.Name = "label9";
            label9.Size = new Size(20, 13);
            label9.TabIndex = 108;
            label9.Text = "(*)";
            // 
            // label10
            // 
            label10.Location = new Point(544, 131);
            label10.Name = "label10";
            label10.Size = new Size(43, 13);
            label10.TabIndex = 106;
            label10.Text = "Ciudad:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(547, 97);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(203, 20);
            txtPais.TabIndex = 104;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(573, 81);
            label11.Name = "label11";
            label11.Size = new Size(20, 13);
            label11.TabIndex = 105;
            label11.Text = "(*)";
            // 
            // label12
            // 
            label12.Location = new Point(544, 81);
            label12.Name = "label12";
            label12.Size = new Size(32, 13);
            label12.TabIndex = 103;
            label12.Text = "País:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(50, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 20);
            txtNombre.TabIndex = 101;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(148, 131);
            label5.Name = "label5";
            label5.Size = new Size(20, 13);
            label5.TabIndex = 102;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.Location = new Point(47, 131);
            label6.Name = "label6";
            label6.Size = new Size(105, 13);
            label6.TabIndex = 98;
            label6.Text = "Nombres y Apellidos:";
            // 
            // txtNumeroINSS
            // 
            txtNumeroINSS.Location = new Point(50, 99);
            txtNumeroINSS.Name = "txtNumeroINSS";
            txtNumeroINSS.Size = new Size(203, 20);
            txtNumeroINSS.TabIndex = 99;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(135, 83);
            label7.Name = "label7";
            label7.Size = new Size(20, 13);
            label7.TabIndex = 100;
            label7.Text = "(*)";
            // 
            // label8
            // 
            label8.Location = new Point(47, 83);
            label8.Name = "label8";
            label8.Size = new Size(95, 13);
            label8.TabIndex = 97;
            label8.Text = "Número del INSS:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(401, 131);
            label4.Name = "label4";
            label4.Size = new Size(20, 13);
            label4.TabIndex = 114;
            label4.Text = "(*)";
            // 
            // label13
            // 
            label13.Location = new Point(294, 131);
            label13.Name = "label13";
            label13.Size = new Size(112, 13);
            label13.TabIndex = 110;
            label13.Text = "Fecha de Nacimiento:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(297, 99);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(203, 20);
            txtCargo.TabIndex = 111;
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(328, 83);
            label14.Name = "label14";
            label14.Size = new Size(20, 13);
            label14.TabIndex = 112;
            label14.Text = "(*)";
            // 
            // label15
            // 
            label15.Location = new Point(294, 83);
            label15.Name = "label15";
            label15.Size = new Size(38, 13);
            label15.TabIndex = 109;
            label15.Text = "Cargo:";
            // 
            // label16
            // 
            label16.Location = new Point(791, 83);
            label16.Name = "label16";
            label16.Size = new Size(43, 13);
            label16.TabIndex = 115;
            label16.Text = "Salario:";
            // 
            // label17
            // 
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(830, 83);
            label17.Name = "label17";
            label17.Size = new Size(20, 13);
            label17.TabIndex = 116;
            label17.Text = "(*)";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(791, 99);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(203, 20);
            txtSalario.TabIndex = 117;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(297, 147);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(203, 22);
            dtpFecha.TabIndex = 118;
            // 
            // frmTrabajadores
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1048, 549);
            ControlBox = false;
            Controls.Add(dtpFecha);
            Controls.Add(txtSalario);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(txtCargo);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txtCiudad);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtPais);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtNumeroINSS);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvTrabajadores);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmTrabajadores";
            Text = "Lista de Trabajadores";
            Load += frmTrabajadores_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblFecha;
        private ToolStripStatusLabel slblHora;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvTrabajadores;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
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
        private Label label4;
        private Label label13;
        private TextBox txtCargo;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtSalario;
        private DateTimePicker dtpFecha;
    }
}