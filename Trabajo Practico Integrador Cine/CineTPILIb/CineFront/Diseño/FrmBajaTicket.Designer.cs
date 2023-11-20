namespace CineFront.Diseño
{
    partial class FrmBajaTicket
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
            this.btnConsular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBaja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNumeroDeTicket = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeEmision = new System.Windows.Forms.Label();
            this.lblNumeroDeTicket = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsular
            // 
            this.btnConsular.Location = new System.Drawing.Point(432, 118);
            this.btnConsular.Name = "btnConsular";
            this.btnConsular.Size = new System.Drawing.Size(127, 23);
            this.btnConsular.TabIndex = 0;
            this.btnConsular.Text = "Consultar";
            this.btnConsular.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(484, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColCliente,
            this.ColVendedor,
            this.ColFecha,
            this.ColBaja});
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Numero de Ticket";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            // 
            // ColVendedor
            // 
            this.ColVendedor.HeaderText = "Vendedor";
            this.ColVendedor.Name = "ColVendedor";
            this.ColVendedor.ReadOnly = true;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha de emision";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColBaja
            // 
            this.ColBaja.HeaderText = "Dar de baja";
            this.ColBaja.Name = "ColBaja";
            this.ColBaja.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(403, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVendedor);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtNumeroDeTicket);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblFechaDeEmision);
            this.groupBox1.Controls.Add(this.lblNumeroDeTicket);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(307, 51);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(57, 15);
            this.lblVendedor.TabIndex = 7;
            this.lblVendedor.Text = "Vendedor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(131, 49);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 23);
            this.cboCliente.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 52);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // txtNumeroDeTicket
            // 
            this.txtNumeroDeTicket.Location = new System.Drawing.Point(131, 16);
            this.txtNumeroDeTicket.Name = "txtNumeroDeTicket";
            this.txtNumeroDeTicket.Size = new System.Drawing.Size(121, 23);
            this.txtNumeroDeTicket.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblFechaDeEmision
            // 
            this.lblFechaDeEmision.AutoSize = true;
            this.lblFechaDeEmision.Location = new System.Drawing.Point(307, 19);
            this.lblFechaDeEmision.Name = "lblFechaDeEmision";
            this.lblFechaDeEmision.Size = new System.Drawing.Size(99, 15);
            this.lblFechaDeEmision.TabIndex = 1;
            this.lblFechaDeEmision.Text = "Fecha de emisión";
            // 
            // lblNumeroDeTicket
            // 
            this.lblNumeroDeTicket.AutoSize = true;
            this.lblNumeroDeTicket.Location = new System.Drawing.Point(6, 19);
            this.lblNumeroDeTicket.Name = "lblNumeroDeTicket";
            this.lblNumeroDeTicket.Size = new System.Drawing.Size(101, 15);
            this.lblNumeroDeTicket.TabIndex = 0;
            this.lblNumeroDeTicket.Text = "Numero de Ticket";
            // 
            // FrmBajaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsular);
            this.Name = "FrmBajaTicket";
            this.Text = "Baja Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConsular;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox txtNumeroDeTicket;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaDeEmision;
        private Label lblNumeroDeTicket;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColVendedor;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewButtonColumn ColBaja;
        private Label lblVendedor;
        private ComboBox comboBox1;
        private ComboBox cboCliente;
        private Label lblCliente;
    }
}