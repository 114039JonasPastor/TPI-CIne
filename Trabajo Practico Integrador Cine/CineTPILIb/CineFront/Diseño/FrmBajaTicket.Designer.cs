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
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcción = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNumeroDeTicket = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeEmision = new System.Windows.Forms.Label();
            this.lblNumeroDeTicket = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsular
            // 
            this.btnConsular.Location = new System.Drawing.Point(432, 106);
            this.btnConsular.Name = "btnConsular";
            this.btnConsular.Size = new System.Drawing.Size(127, 23);
            this.btnConsular.TabIndex = 0;
            this.btnConsular.Text = "Consultar";
            this.btnConsular.UseVisualStyleBackColor = true;
            this.btnConsular.Click += new System.EventHandler(this.btnConsular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(484, 291);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColCliente,
            this.ColFecha,
            this.ColAcción});
            this.dgvTicket.Location = new System.Drawing.Point(12, 135);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowTemplate.Height = 25;
            this.dgvTicket.Size = new System.Drawing.Size(547, 150);
            this.dgvTicket.TabIndex = 2;
            this.dgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellContentClick);
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
            this.ColCliente.Width = 202;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha de emision";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColAcción
            // 
            this.ColAcción.HeaderText = "Acción";
            this.ColAcción.Name = "ColAcción";
            this.ColAcción.ReadOnly = true;
            this.ColAcción.Text = "Dar de baja";
            this.ColAcción.UseColumnTextForButtonValue = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(403, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClientes);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtNumeroDeTicket);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblFechaDeEmision);
            this.groupBox1.Controls.Add(this.lblNumeroDeTicket);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtClientes
            // 
            this.txtClientes.Location = new System.Drawing.Point(131, 49);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.Size = new System.Drawing.Size(410, 23);
            this.txtClientes.TabIndex = 5;
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
            this.txtNumeroDeTicket.Size = new System.Drawing.Size(170, 23);
            this.txtNumeroDeTicket.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(420, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 23);
            this.dtpFecha.TabIndex = 2;
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
            this.ClientSize = new System.Drawing.Size(571, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsular);
            this.Name = "FrmBajaTicket";
            this.Text = "FrmBajaTicket";
            this.Load += new System.EventHandler(this.FrmBajaTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConsular;
        private Button btnSalir;
        private DataGridView dgvTicket;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private TextBox txtNumeroDeTicket;
        private DateTimePicker dtpFecha;
        private Label lblFechaDeEmision;
        private Label lblNumeroDeTicket;
        private Label lblCliente;
        private TextBox txtClientes;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewButtonColumn ColAcción;
    }
}