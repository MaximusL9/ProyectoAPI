namespace ProyectoForm
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            statusStrip1 = new StatusStrip();
            slblFecha = new ToolStripStatusLabel();
            slblHora = new ToolStripStatusLabel();
            txtPrecioProducto = new TextBox();
            txtIDProducto = new TextBox();
            txtCambio = new TextBox();
            txtIDVenta = new TextBox();
            label4 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtTotalVenta = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnModificar = new Button();
            btnBorrar = new Button();
            dgvVentas = new DataGridView();
            btnClear = new Button();
            btnNuevo = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
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
            statusStrip1.TabIndex = 89;
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
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(714, 98);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(233, 20);
            txtPrecioProducto.TabIndex = 171;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(404, 146);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(233, 20);
            txtIDProducto.TabIndex = 170;
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(404, 98);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(233, 20);
            txtCambio.TabIndex = 169;
            // 
            // txtIDVenta
            // 
            txtIDVenta.Location = new Point(91, 98);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(233, 20);
            txtIDVenta.TabIndex = 168;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(469, 130);
            label4.Name = "label4";
            label4.Size = new Size(20, 13);
            label4.TabIndex = 167;
            label4.Text = "(*)";
            // 
            // label13
            // 
            label13.Location = new Point(404, 130);
            label13.Name = "label13";
            label13.Size = new Size(67, 13);
            label13.TabIndex = 165;
            label13.Text = "ID Producto:";
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(446, 82);
            label14.Name = "label14";
            label14.Size = new Size(20, 13);
            label14.TabIndex = 166;
            label14.Text = "(*)";
            // 
            // label15
            // 
            label15.Location = new Point(404, 82);
            label15.Name = "label15";
            label15.Size = new Size(45, 13);
            label15.TabIndex = 164;
            label15.Text = "Cambio:";
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(815, 82);
            label11.Name = "label11";
            label11.Size = new Size(20, 13);
            label11.TabIndex = 163;
            label11.Text = "(*)";
            // 
            // label12
            // 
            label12.Location = new Point(714, 82);
            label12.Name = "label12";
            label12.Size = new Size(103, 13);
            label12.TabIndex = 162;
            label12.Text = "Precio del Producto:";
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.Location = new Point(91, 146);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.Size = new Size(233, 20);
            txtTotalVenta.TabIndex = 160;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(150, 130);
            label5.Name = "label5";
            label5.Size = new Size(20, 13);
            label5.TabIndex = 161;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.Location = new Point(88, 130);
            label6.Name = "label6";
            label6.Size = new Size(65, 13);
            label6.TabIndex = 158;
            label6.Text = "Total Venta:";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(137, 82);
            label7.Name = "label7";
            label7.Size = new Size(20, 13);
            label7.TabIndex = 159;
            label7.Text = "(*)";
            // 
            // label8
            // 
            label8.Location = new Point(88, 82);
            label8.Name = "label8";
            label8.Size = new Size(52, 13);
            label8.TabIndex = 157;
            label8.Text = "ID Venta:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.Location = new Point(870, 197);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(37, 21);
            btnModificar.TabIndex = 155;
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
            btnBorrar.Location = new Point(913, 197);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(37, 21);
            btnBorrar.TabIndex = 156;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // dgvVentas
            // 
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVentas.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.ColumnHeadersHeight = 30;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.DimGray;
            dgvVentas.Location = new Point(40, 236);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(965, 365);
            dgvVentas.TabIndex = 152;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(956, 197);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(37, 21);
            btnClear.TabIndex = 154;
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
            btnNuevo.Location = new Point(59, 197);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(116, 29);
            btnNuevo.TabIndex = 151;
            btnNuevo.Text = "Agregar";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(21, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 1);
            panel1.TabIndex = 153;
            // 
            // label3
            // 
            label3.BackColor = Color.MidnightBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 28);
            label3.Name = "label3";
            label3.Size = new Size(1004, 40);
            label3.TabIndex = 150;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(1004, 550);
            label2.TabIndex = 149;
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 172;
            label1.Text = "Lista de Ventas";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1048, 549);
            Controls.Add(label1);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtIDProducto);
            Controls.Add(txtCambio);
            Controls.Add(txtIDVenta);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtTotalVenta);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(dgvVentas);
            Controls.Add(btnClear);
            Controls.Add(btnNuevo);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmVentas";
            Text = "Lista de Ventas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblFecha;
        private ToolStripStatusLabel slblHora;
        private TextBox txtPrecioProducto;
        private TextBox txtIDProducto;
        private TextBox txtCambio;
        private TextBox txtIDVenta;
        private Label label4;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label11;
        private Label label12;
        private TextBox txtTotalVenta;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnModificar;
        private Button btnBorrar;
        private DataGridView dgvVentas;
        private Button btnClear;
        private Button btnNuevo;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}