namespace CineFront.Diseño
{
    partial class FrmNuevoTicket
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblMedio_vendido = new System.Windows.Forms.Label();
            this.cboMedioDeVenta = new System.Windows.Forms.ComboBox();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.cboPromocion = new System.Windows.Forms.ComboBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.cboFormaDePago = new System.Windows.Forms.ComboBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblButaca = new System.Windows.Forms.Label();
            this.cboButaca = new System.Windows.Forms.ComboBox();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
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
            this.dgvTicket.Location = new System.Drawing.Point(12, 186);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowTemplate.Height = 25;
            this.dgvTicket.Size = new System.Drawing.Size(1128, 150);
            this.dgvTicket.TabIndex = 10;
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1019, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(12, 9);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(105, 15);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Numero de ticket: ";
            // 
            // lblMedio_vendido
            // 
            this.lblMedio_vendido.AutoSize = true;
            this.lblMedio_vendido.Location = new System.Drawing.Point(699, 50);
            this.lblMedio_vendido.Name = "lblMedio_vendido";
            this.lblMedio_vendido.Size = new System.Drawing.Size(89, 15);
            this.lblMedio_vendido.TabIndex = 13;
            this.lblMedio_vendido.Text = "Medio de venta";
            // 
            // cboMedioDeVenta
            // 
            this.cboMedioDeVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioDeVenta.FormattingEnabled = true;
            this.cboMedioDeVenta.Location = new System.Drawing.Point(814, 45);
            this.cboMedioDeVenta.Name = "cboMedioDeVenta";
            this.cboMedioDeVenta.Size = new System.Drawing.Size(121, 23);
            this.cboMedioDeVenta.TabIndex = 10;
            this.cboMedioDeVenta.Click += new System.EventHandler(this.LoadMediosDeVenta);
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Location = new System.Drawing.Point(955, 107);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(66, 15);
            this.lblPromocion.TabIndex = 19;
            this.lblPromocion.Text = "Promocion";
            // 
            // cboPromocion
            // 
            this.cboPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPromocion.FormattingEnabled = true;
            this.cboPromocion.Location = new System.Drawing.Point(1049, 104);
            this.cboPromocion.Name = "cboPromocion";
            this.cboPromocion.Size = new System.Drawing.Size(90, 23);
            this.cboPromocion.TabIndex = 20;
            this.cboPromocion.Click += new System.EventHandler(this.LoadPromociones);
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Location = new System.Drawing.Point(701, 107);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(87, 15);
            this.lblFormaDePago.TabIndex = 11;
            this.lblFormaDePago.Text = "Forma de pago";
            // 
            // cboFormaDePago
            // 
            this.cboFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaDePago.FormattingEnabled = true;
            this.cboFormaDePago.Location = new System.Drawing.Point(814, 104);
            this.cboFormaDePago.Name = "cboFormaDePago";
            this.cboFormaDePago.Size = new System.Drawing.Size(121, 23);
            this.cboFormaDePago.TabIndex = 12;
            this.cboFormaDePago.Click += new System.EventHandler(this.LoadFormasDePago);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(955, 48);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(88, 15);
            this.lblPrecioVenta.TabIndex = 27;
            this.lblPrecioVenta.Text = "Precio de Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(1049, 45);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(90, 23);
            this.txtPrecioVenta.TabIndex = 28;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1065, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(941, 342);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(367, 110);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(430, 104);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 23);
            this.dtpFecha.TabIndex = 8;
            // 
            // lblButaca
            // 
            this.lblButaca.AutoSize = true;
            this.lblButaca.Location = new System.Drawing.Point(12, 133);
            this.lblButaca.Name = "lblButaca";
            this.lblButaca.Size = new System.Drawing.Size(43, 15);
            this.lblButaca.TabIndex = 5;
            this.lblButaca.Text = "Butaca";
            // 
            // cboButaca
            // 
            this.cboButaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboButaca.FormattingEnabled = true;
            this.cboButaca.Location = new System.Drawing.Point(113, 130);
            this.cboButaca.Name = "cboButaca";
            this.cboButaca.Size = new System.Drawing.Size(121, 23);
            this.cboButaca.TabIndex = 6;
            this.cboButaca.Click += new System.EventHandler(this.LoadButacas);
            // 
            // cboFuncion
            // 
            this.cboFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Location = new System.Drawing.Point(113, 101);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(121, 23);
            this.cboFuncion.TabIndex = 4;
            this.cboFuncion.SelectedValueChanged += new System.EventHandler(this.LoadTxtPrecioVenta);
            this.cboFuncion.Click += new System.EventHandler(this.LoadFuncion);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(113, 42);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(438, 23);
            this.cboCliente.TabIndex = 2;
            this.cboCliente.Click += new System.EventHandler(this.LoadClientes);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(12, 104);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(50, 15);
            this.lblFuncion.TabIndex = 3;
            this.lblFuncion.Text = "Funcion";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 45);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // FrmNuevoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineFront.Properties.Resources.cine1;
            this.ClientSize = new System.Drawing.Size(1163, 380);
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
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTicket);
            this.Name = "FrmNuevoTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Ticket";
            this.Load += new System.EventHandler(this.FrmNuevoTicket_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvTicket;
        private Button btnAgregar;
        private Label lblTicket;
        private Label lblMedio_vendido;
        private ComboBox cboMedioDeVenta;
        private Label lblPromocion;
        private ComboBox cboPromocion;
        private Label lblFormaDePago;
        private ComboBox cboFormaDePago;
        private Label lblPrecioVenta;
        private TextBox txtPrecioVenta;
        private Button btnSalir;
        private Button btnConfirmar;
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
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblButaca;
        private ComboBox cboButaca;
        private ComboBox cboFuncion;
        private ComboBox cboCliente;
        private Label lblFuncion;
        private Label lblCliente;
    }
}