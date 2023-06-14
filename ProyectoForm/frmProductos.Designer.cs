namespace ProyectoForm
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            statusStrip1 = new StatusStrip();
            slblFecha = new ToolStripStatusLabel();
            slblHora = new ToolStripStatusLabel();
            txtExistencias = new TextBox();
            label4 = new Label();
            label13 = new Label();
            txtPrecio = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtNombreProducto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtIDProducto = new TextBox();
            label8 = new Label();
            btnModificar = new Button();
            btnBorrar = new Button();
            dgvProductos = new DataGridView();
            btnClear = new Button();
            btnNuevo = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
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
            // txtExistencias
            // 
            txtExistencias.Location = new Point(581, 147);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(253, 20);
            txtExistencias.TabIndex = 166;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(637, 131);
            label4.Name = "label4";
            label4.Size = new Size(20, 13);
            label4.TabIndex = 167;
            label4.Text = "(*)";
            // 
            // label13
            // 
            label13.Location = new Point(578, 131);
            label13.Name = "label13";
            label13.Size = new Size(63, 13);
            label13.TabIndex = 163;
            label13.Text = "Existencias:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(581, 99);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(253, 20);
            txtPrecio.TabIndex = 164;
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(615, 83);
            label14.Name = "label14";
            label14.Size = new Size(20, 13);
            label14.TabIndex = 165;
            label14.Text = "(*)";
            // 
            // label15
            // 
            label15.Location = new Point(578, 83);
            label15.Name = "label15";
            label15.Size = new Size(40, 13);
            label15.TabIndex = 162;
            label15.Text = "Precio:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(204, 147);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(253, 20);
            txtNombreProducto.TabIndex = 157;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(308, 131);
            label5.Name = "label5";
            label5.Size = new Size(20, 13);
            label5.TabIndex = 158;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.Location = new Point(201, 131);
            label6.Name = "label6";
            label6.Size = new Size(115, 13);
            label6.TabIndex = 155;
            label6.Text = "Nombre del Producto:";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(204, 99);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(253, 20);
            txtIDProducto.TabIndex = 156;
            // 
            // label8
            // 
            label8.Location = new Point(201, 83);
            label8.Name = "label8";
            label8.Size = new Size(67, 13);
            label8.TabIndex = 154;
            label8.Text = "ID Producto:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.Location = new Point(870, 198);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(37, 21);
            btnModificar.TabIndex = 152;
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
            btnBorrar.Location = new Point(913, 198);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(37, 21);
            btnBorrar.TabIndex = 153;
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.DimGray;
            dgvProductos.Location = new Point(40, 237);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(965, 365);
            dgvProductos.TabIndex = 148;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(956, 198);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(37, 21);
            btnClear.TabIndex = 151;
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
            btnNuevo.Location = new Point(59, 198);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(116, 29);
            btnNuevo.TabIndex = 147;
            btnNuevo.Text = "Agregar";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(21, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 1);
            panel1.TabIndex = 149;
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 150;
            label1.Text = "Lista de Productos";
            // 
            // label3
            // 
            label3.BackColor = Color.MidnightBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 29);
            label3.Name = "label3";
            label3.Size = new Size(1004, 40);
            label3.TabIndex = 146;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(1004, 550);
            label2.TabIndex = 145;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(265, 83);
            label7.Name = "label7";
            label7.Size = new Size(20, 13);
            label7.TabIndex = 168;
            label7.Text = "(*)";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1048, 549);
            Controls.Add(label7);
            Controls.Add(txtExistencias);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(txtPrecio);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txtNombreProducto);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtIDProducto);
            Controls.Add(label8);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(dgvProductos);
            Controls.Add(btnClear);
            Controls.Add(btnNuevo);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmProductos";
            Text = "Lista de Productos";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblFecha;
        private ToolStripStatusLabel slblHora;
        private TextBox txtExistencias;
        private Label label4;
        private Label label13;
        private TextBox txtPrecio;
        private Label label14;
        private Label label15;
        private TextBox txtNombreProducto;
        private Label label5;
        private Label label6;
        private TextBox txtIDProducto;
        private Label label8;
        private Button btnModificar;
        private Button btnBorrar;
        private DataGridView dgvProductos;
        private Button btnClear;
        private Button btnNuevo;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label7;
    }
}