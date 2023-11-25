namespace CineFront.Testeo
{
    partial class TestTicket
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.cboButaca = new System.Windows.Forms.ComboBox();
            this.lblMedio_vendido = new System.Windows.Forms.Label();
            this.lblButaca = new System.Windows.Forms.Label();
            this.cboMedioDeVenta = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboFormaDePago = new System.Windows.Forms.ComboBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cboPromocion = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioDeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedioDeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(-5, 67);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 35;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(-5, 126);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(50, 15);
            this.lblFuncion.TabIndex = 43;
            this.lblFuncion.Text = "Funcion";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(96, 64);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(438, 23);
            this.cboCliente.TabIndex = 36;
            // 
            // cboFuncion
            // 
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Location = new System.Drawing.Point(96, 123);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(121, 23);
            this.cboFuncion.TabIndex = 44;
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Location = new System.Drawing.Point(938, 129);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(66, 15);
            this.lblPromocion.TabIndex = 39;
            this.lblPromocion.Text = "Promocion";
            // 
            // cboButaca
            // 
            this.cboButaca.FormattingEnabled = true;
            this.cboButaca.Location = new System.Drawing.Point(96, 152);
            this.cboButaca.Name = "cboButaca";
            this.cboButaca.Size = new System.Drawing.Size(121, 23);
            this.cboButaca.TabIndex = 46;
            // 
            // lblMedio_vendido
            // 
            this.lblMedio_vendido.AutoSize = true;
            this.lblMedio_vendido.Location = new System.Drawing.Point(682, 72);
            this.lblMedio_vendido.Name = "lblMedio_vendido";
            this.lblMedio_vendido.Size = new System.Drawing.Size(89, 15);
            this.lblMedio_vendido.TabIndex = 37;
            this.lblMedio_vendido.Text = "Medio de venta";
            // 
            // lblButaca
            // 
            this.lblButaca.AutoSize = true;
            this.lblButaca.Location = new System.Drawing.Point(-5, 155);
            this.lblButaca.Name = "lblButaca";
            this.lblButaca.Size = new System.Drawing.Size(43, 15);
            this.lblButaca.TabIndex = 45;
            this.lblButaca.Text = "Butaca";
            // 
            // cboMedioDeVenta
            // 
            this.cboMedioDeVenta.FormattingEnabled = true;
            this.cboMedioDeVenta.Location = new System.Drawing.Point(797, 67);
            this.cboMedioDeVenta.Name = "cboMedioDeVenta";
            this.cboMedioDeVenta.Size = new System.Drawing.Size(121, 23);
            this.cboMedioDeVenta.TabIndex = 38;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(413, 126);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 23);
            this.dtpFecha.TabIndex = 50;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(350, 132);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 49;
            this.lblFecha.Text = "Fecha";
            // 
            // cboFormaDePago
            // 
            this.cboFormaDePago.FormattingEnabled = true;
            this.cboFormaDePago.Location = new System.Drawing.Point(797, 126);
            this.cboFormaDePago.Name = "cboFormaDePago";
            this.cboFormaDePago.Size = new System.Drawing.Size(121, 23);
            this.cboFormaDePago.TabIndex = 42;
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Location = new System.Drawing.Point(684, 129);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(87, 15);
            this.lblFormaDePago.TabIndex = 41;
            this.lblFormaDePago.Text = "Forma de pago";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(1032, 67);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(90, 23);
            this.txtPrecioVenta.TabIndex = 48;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(924, 364);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 52;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cboPromocion
            // 
            this.cboPromocion.FormattingEnabled = true;
            this.cboPromocion.Location = new System.Drawing.Point(1032, 126);
            this.cboPromocion.Name = "cboPromocion";
            this.cboPromocion.Size = new System.Drawing.Size(90, 23);
            this.cboPromocion.TabIndex = 40;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1048, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(938, 70);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(88, 15);
            this.lblPrecioVenta.TabIndex = 47;
            this.lblPrecioVenta.Text = "Precio de Venta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1002, 179);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCliente,
            this.ColFuncion,
            this.ColFecha,
            this.ColButaca,
            this.ColPrecioDeVenta,
            this.ColMedioDeVenta,
            this.ColFormaDePago,
            this.ColDescuento,
            this.ColSubtotal,
            this.ColAccion});
            this.dgvTicket.Location = new System.Drawing.Point(-5, 208);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowTemplate.Height = 25;
            this.dgvTicket.Size = new System.Drawing.Size(1128, 150);
            this.dgvTicket.TabIndex = 33;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 200;
            // 
            // ColFuncion
            // 
            this.ColFuncion.HeaderText = "Numero de función";
            this.ColFuncion.Name = "ColFuncion";
            this.ColFuncion.ReadOnly = true;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColButaca
            // 
            this.ColButaca.HeaderText = "Butaca";
            this.ColButaca.Name = "ColButaca";
            this.ColButaca.ReadOnly = true;
            this.ColButaca.Width = 50;
            // 
            // ColPrecioDeVenta
            // 
            this.ColPrecioDeVenta.HeaderText = "Precio de venta";
            this.ColPrecioDeVenta.Name = "ColPrecioDeVenta";
            this.ColPrecioDeVenta.ReadOnly = true;
            this.ColPrecioDeVenta.Width = 75;
            // 
            // ColMedioDeVenta
            // 
            this.ColMedioDeVenta.HeaderText = "Medio de venta";
            this.ColMedioDeVenta.Name = "ColMedioDeVenta";
            this.ColMedioDeVenta.ReadOnly = true;
            this.ColMedioDeVenta.Width = 150;
            // 
            // ColFormaDePago
            // 
            this.ColFormaDePago.HeaderText = "Forma de pago";
            this.ColFormaDePago.Name = "ColFormaDePago";
            this.ColFormaDePago.ReadOnly = true;
            // 
            // ColDescuento
            // 
            this.ColDescuento.HeaderText = "Descuento";
            this.ColDescuento.Name = "ColDescuento";
            this.ColDescuento.ReadOnly = true;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.ReadOnly = true;
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Accion";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Text = "Quitar";
            this.ColAccion.UseColumnTextForButtonValue = true;
            this.ColAccion.Width = 107;
            // 
            // TestTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 409);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboFuncion);
            this.Controls.Add(this.lblPromocion);
            this.Controls.Add(this.cboButaca);
            this.Controls.Add(this.lblMedio_vendido);
            this.Controls.Add(this.lblButaca);
            this.Controls.Add(this.cboMedioDeVenta);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboFormaDePago);
            this.Controls.Add(this.lblFormaDePago);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cboPromocion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTicket);
            this.Name = "TestTicket";
            this.Text = "TestTicket";
            this.Load += new System.EventHandler(this.TestTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCliente;
        private Label lblFuncion;
        private ComboBox cboCliente;
        private ComboBox cboFuncion;
        private Label lblPromocion;
        private ComboBox cboButaca;
        private Label lblMedio_vendido;
        private Label lblButaca;
        private ComboBox cboMedioDeVenta;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private ComboBox cboFormaDePago;
        private Label lblFormaDePago;
        private TextBox txtPrecioVenta;
        private Button btnConfirmar;
        private ComboBox cboPromocion;
        private Button btnSalir;
        private Label lblPrecioVenta;
        private Button btnAgregar;
        private DataGridView dgvTicket;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFuncion;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColButaca;
        private DataGridViewTextBoxColumn ColPrecioDeVenta;
        private DataGridViewTextBoxColumn ColMedioDeVenta;
        private DataGridViewTextBoxColumn ColFormaDePago;
        private DataGridViewTextBoxColumn ColDescuento;
        private DataGridViewTextBoxColumn ColSubtotal;
        private DataGridViewButtonColumn ColAccion;
    }
}