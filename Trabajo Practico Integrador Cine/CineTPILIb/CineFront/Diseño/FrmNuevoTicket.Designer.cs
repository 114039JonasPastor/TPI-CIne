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
            dgvTicket = new DataGridView();
            ColCliente = new DataGridViewTextBoxColumn();
            ColFuncion = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColButaca = new DataGridViewTextBoxColumn();
            ColPrecioDeVenta = new DataGridViewTextBoxColumn();
            ColMedioDeVenta = new DataGridViewTextBoxColumn();
            ColFormaDePago = new DataGridViewTextBoxColumn();
            ColDescuento = new DataGridViewTextBoxColumn();
            ColSubtotal = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            lblTicket = new Label();
            lblMedio_vendido = new Label();
            cboMedioDeVenta = new ComboBox();
            lblPromocion = new Label();
            cboPromocion = new ComboBox();
            lblFormaDePago = new Label();
            cboFormaDePago = new ComboBox();
            lblPrecioVenta = new Label();
            txtPrecioVenta = new TextBox();
            btnSalir = new Button();
            btnConfirmar = new Button();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblButaca = new Label();
            cboButaca = new ComboBox();
            cboFuncion = new ComboBox();
            cboCliente = new ComboBox();
            lblFuncion = new Label();
            lblCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            SuspendLayout();
            // 
            // dgvTicket
            // 
            dgvTicket.AllowUserToAddRows = false;
            dgvTicket.AllowUserToDeleteRows = false;
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Columns.AddRange(new DataGridViewColumn[] { ColCliente, ColFuncion, ColFecha, ColButaca, ColPrecioDeVenta, ColMedioDeVenta, ColFormaDePago, ColDescuento, ColSubtotal, ColAccion });
            dgvTicket.Location = new Point(12, 186);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.ReadOnly = true;
            dgvTicket.RowTemplate.Height = 25;
            dgvTicket.Size = new Size(1128, 150);
            dgvTicket.TabIndex = 10;
            dgvTicket.CellContentClick += dgvTicket_CellContentClick;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 200;
            // 
            // ColFuncion
            // 
            ColFuncion.HeaderText = "Numero de función";
            ColFuncion.Name = "ColFuncion";
            ColFuncion.ReadOnly = true;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            // 
            // ColButaca
            // 
            ColButaca.HeaderText = "Butaca";
            ColButaca.Name = "ColButaca";
            ColButaca.ReadOnly = true;
            ColButaca.Width = 50;
            // 
            // ColPrecioDeVenta
            // 
            ColPrecioDeVenta.HeaderText = "Precio de venta";
            ColPrecioDeVenta.Name = "ColPrecioDeVenta";
            ColPrecioDeVenta.ReadOnly = true;
            ColPrecioDeVenta.Width = 75;
            // 
            // ColMedioDeVenta
            // 
            ColMedioDeVenta.HeaderText = "Medio de venta";
            ColMedioDeVenta.Name = "ColMedioDeVenta";
            ColMedioDeVenta.ReadOnly = true;
            ColMedioDeVenta.Width = 150;
            // 
            // ColFormaDePago
            // 
            ColFormaDePago.HeaderText = "Forma de pago";
            ColFormaDePago.Name = "ColFormaDePago";
            ColFormaDePago.ReadOnly = true;
            // 
            // ColDescuento
            // 
            ColDescuento.HeaderText = "Descuento";
            ColDescuento.Name = "ColDescuento";
            ColDescuento.ReadOnly = true;
            // 
            // ColSubtotal
            // 
            ColSubtotal.HeaderText = "Subtotal";
            ColSubtotal.Name = "ColSubtotal";
            ColSubtotal.ReadOnly = true;
            // 
            // ColAccion
            // 
            ColAccion.HeaderText = "Accion";
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Text = "Quitar";
            ColAccion.UseColumnTextForButtonValue = true;
            ColAccion.Width = 107;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1019, 157);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Location = new Point(12, 9);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(105, 15);
            lblTicket.TabIndex = 14;
            lblTicket.Text = "Numero de ticket: ";
            // 
            // lblMedio_vendido
            // 
            lblMedio_vendido.AutoSize = true;
            lblMedio_vendido.Location = new Point(699, 50);
            lblMedio_vendido.Name = "lblMedio_vendido";
            lblMedio_vendido.Size = new Size(89, 15);
            lblMedio_vendido.TabIndex = 17;
            lblMedio_vendido.Text = "Medio de venta";
            // 
            // cboMedioDeVenta
            // 
            cboMedioDeVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedioDeVenta.FormattingEnabled = true;
            cboMedioDeVenta.Location = new Point(814, 45);
            cboMedioDeVenta.Name = "cboMedioDeVenta";
            cboMedioDeVenta.Size = new Size(121, 23);
            cboMedioDeVenta.TabIndex = 18;
            cboMedioDeVenta.Click += LoadMediosDeVenta;
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.Location = new Point(955, 107);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(66, 15);
            lblPromocion.TabIndex = 19;
            lblPromocion.Text = "Promocion";
            // 
            // cboPromocion
            // 
            cboPromocion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPromocion.FormattingEnabled = true;
            cboPromocion.Location = new Point(1049, 104);
            cboPromocion.Name = "cboPromocion";
            cboPromocion.Size = new Size(90, 23);
            cboPromocion.TabIndex = 20;
            cboPromocion.Click += LoadPromociones;
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.Location = new Point(701, 107);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(87, 15);
            lblFormaDePago.TabIndex = 21;
            lblFormaDePago.Text = "Forma de pago";
            // 
            // cboFormaDePago
            // 
            cboFormaDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaDePago.FormattingEnabled = true;
            cboFormaDePago.Location = new Point(814, 104);
            cboFormaDePago.Name = "cboFormaDePago";
            cboFormaDePago.Size = new Size(121, 23);
            cboFormaDePago.TabIndex = 22;
            cboFormaDePago.Click += LoadFormasDePago;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(955, 48);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(88, 15);
            lblPrecioVenta.TabIndex = 27;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(1049, 45);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(90, 23);
            txtPrecioVenta.TabIndex = 28;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1065, 342);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(941, 342);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 32;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(367, 110);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 29;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(430, 104);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(121, 23);
            dtpFecha.TabIndex = 30;
            // 
            // lblButaca
            // 
            lblButaca.AutoSize = true;
            lblButaca.Location = new Point(12, 133);
            lblButaca.Name = "lblButaca";
            lblButaca.Size = new Size(43, 15);
            lblButaca.TabIndex = 25;
            lblButaca.Text = "Butaca";
            // 
            // cboButaca
            // 
            cboButaca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboButaca.FormattingEnabled = true;
            cboButaca.Location = new Point(113, 130);
            cboButaca.Name = "cboButaca";
            cboButaca.Size = new Size(121, 23);
            cboButaca.TabIndex = 26;
            cboButaca.Click += LoadButacas;
            // 
            // cboFuncion
            // 
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncion.FormattingEnabled = true;
            cboFuncion.Location = new Point(113, 101);
            cboFuncion.Name = "cboFuncion";
            cboFuncion.Size = new Size(121, 23);
            cboFuncion.TabIndex = 24;
            cboFuncion.SelectedValueChanged += LoadTxtPrecioVenta;
            cboFuncion.Click += LoadFuncion;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(113, 42);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(438, 23);
            cboCliente.TabIndex = 13;
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Location = new Point(12, 104);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(50, 15);
            lblFuncion.TabIndex = 23;
            lblFuncion.Text = "Funcion";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 45);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 12;
            lblCliente.Text = "Cliente";
            // 
            // FrmNuevoTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cine1;
            ClientSize = new Size(1163, 380);
            Controls.Add(lblCliente);
            Controls.Add(lblFuncion);
            Controls.Add(cboCliente);
            Controls.Add(cboFuncion);
            Controls.Add(lblPromocion);
            Controls.Add(cboButaca);
            Controls.Add(lblMedio_vendido);
            Controls.Add(lblButaca);
            Controls.Add(cboMedioDeVenta);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(cboFormaDePago);
            Controls.Add(lblFormaDePago);
            Controls.Add(txtPrecioVenta);
            Controls.Add(btnConfirmar);
            Controls.Add(cboPromocion);
            Controls.Add(btnSalir);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblTicket);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTicket);
            Name = "FrmNuevoTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Ticket";
            Load += FrmNuevoTicket_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
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