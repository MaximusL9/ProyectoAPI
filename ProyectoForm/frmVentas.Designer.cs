﻿namespace ProyectoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.txtDinRecib = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtCantProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCalcular = new System.Windows.Forms.Button();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblFecha,
            this.slblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1048, 25);
            this.statusStrip1.TabIndex = 89;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblFecha
            // 
            this.slblFecha.Name = "slblFecha";
            this.slblFecha.Size = new System.Drawing.Size(50, 20);
            this.slblFecha.Text = "Fecha:";
            // 
            // slblHora
            // 
            this.slblHora.Name = "slblHora";
            this.slblHora.Size = new System.Drawing.Size(45, 20);
            this.slblHora.Text = "Hora:";
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Location = new System.Drawing.Point(91, 98);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(233, 20);
            this.txtIDProducto.TabIndex = 170;
            this.txtIDProducto.TextChanged += new System.EventHandler(this.txtIDProduct_TextChanged);
            this.txtIDProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProducto_KeyPress);
            // 
            // txtDinRecib
            // 
            this.txtDinRecib.Location = new System.Drawing.Point(419, 98);
            this.txtDinRecib.Name = "txtDinRecib";
            this.txtDinRecib.Size = new System.Drawing.Size(233, 20);
            this.txtDinRecib.TabIndex = 168;
            this.txtDinRecib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinRecib_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(467, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 167;
            this.label4.Text = "(*)";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(88, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 165;
            this.label13.Text = "ID Producto:";
            // 
            // lblCambio
            // 
            this.lblCambio.BackColor = System.Drawing.Color.White;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCambio.Location = new System.Drawing.Point(809, 138);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(184, 45);
            this.lblCambio.TabIndex = 164;
            this.lblCambio.Text = "Cambio:";
            // 
            // txtCantProduct
            // 
            this.txtCantProduct.Location = new System.Drawing.Point(91, 146);
            this.txtCantProduct.Name = "txtCantProduct";
            this.txtCantProduct.Size = new System.Drawing.Size(233, 20);
            this.txtCantProduct.TabIndex = 160;
            this.txtCantProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantProduct_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(183, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 161;
            this.label5.Text = "(*)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(88, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 158;
            this.label6.Text = "Cantidad Producto:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(155, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 159;
            this.label7.Text = "(*)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(419, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 157;
            this.label8.Text = "Recibido:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(870, 197);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(37, 21);
            this.btnModificar.TabIndex = 155;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(913, 197);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(37, 21);
            this.btnBorrar.TabIndex = 156;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.DimGray;
            this.dgvVentas.Location = new System.Drawing.Point(40, 236);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.RowTemplate.Height = 25;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(965, 365);
            this.dgvVentas.TabIndex = 152;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(956, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(37, 21);
            this.btnClear.TabIndex = 154;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(59, 197);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 29);
            this.btnNuevo.TabIndex = 151;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(21, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 1);
            this.panel1.TabIndex = 153;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1004, 40);
            this.label3.TabIndex = 150;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1004, 550);
            this.label2.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 172;
            this.label1.Text = "Lista de Ventas";
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(217, 197);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(116, 29);
            this.btnVentas.TabIndex = 173;
            this.btnVentas.Text = "Realizar Venta";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(536, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 174;
            this.button1.Text = "Ver Registros";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(766, 86);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(227, 34);
            this.lblTotal.TabIndex = 175;
            this.lblTotal.Text = "Total De Venta:";
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(419, 150);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(233, 20);
            this.txtIDcliente.TabIndex = 176;
            this.txtIDcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDcliente_KeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(419, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 177;
            this.label9.Text = "IdCliente:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(467, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 178;
            this.label10.Text = "(*)";
            // 
            // txtCalcular
            // 
            this.txtCalcular.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCalcular.ForeColor = System.Drawing.Color.White;
            this.txtCalcular.Image = ((System.Drawing.Image)(resources.GetObject("txtCalcular.Image")));
            this.txtCalcular.Location = new System.Drawing.Point(371, 197);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(116, 29);
            this.txtCalcular.TabIndex = 179;
            this.txtCalcular.Text = "Calcular";
            this.txtCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtCalcular.UseVisualStyleBackColor = false;
            this.txtCalcular.Click += new System.EventHandler(this.txtCalcular_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1048, 549);
            this.ControlBox = false;
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.txtDinRecib);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.txtCantProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmVentas";
            this.Text = "Lista de Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblFecha;
        private ToolStripStatusLabel slblHora;
        private TextBox txtIDProducto;
        private TextBox txtDinRecib;
        private Label label4;
        private Label label13;
        private Label lblCambio;
        private TextBox txtCantProduct;
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
        private Button btnVentas;
        private Button button1;
        private Label lblTotal;
        private TextBox txtIDcliente;
        private Label label9;
        private Label label10;
        private Button txtCalcular;
        private ErrorProvider erpError;
    }
}