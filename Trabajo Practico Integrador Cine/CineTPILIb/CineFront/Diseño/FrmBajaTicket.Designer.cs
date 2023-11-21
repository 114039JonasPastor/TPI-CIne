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
            btnConsular = new Button();
            btnSalir = new Button();
            dgvTicket = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColAcción = new DataGridViewButtonColumn();
            txtClientes = new TextBox();
            lblCliente = new Label();
            txtNumeroDeTicket = new TextBox();
            dtpFecha = new DateTimePicker();
            lblFechaDeEmision = new Label();
            lblNumeroDeTicket = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            SuspendLayout();
            // 
            // btnConsular
            // 
            btnConsular.Location = new Point(426, 68);
            btnConsular.Name = "btnConsular";
            btnConsular.Size = new Size(127, 23);
            btnConsular.TabIndex = 0;
            btnConsular.Text = "Consultar";
            btnConsular.UseVisualStyleBackColor = true;
            btnConsular.Click += btnConsular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(478, 253);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvTicket
            // 
            dgvTicket.AllowUserToAddRows = false;
            dgvTicket.AllowUserToDeleteRows = false;
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Columns.AddRange(new DataGridViewColumn[] { ColID, ColCliente, ColFecha, ColAcción });
            dgvTicket.Location = new Point(6, 97);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.ReadOnly = true;
            dgvTicket.RowTemplate.Height = 25;
            dgvTicket.Size = new Size(547, 150);
            dgvTicket.TabIndex = 2;
            dgvTicket.CellContentClick += dgvTicket_CellContentClick;
            // 
            // ColID
            // 
            ColID.HeaderText = "Numero de Ticket";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 202;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha de emision";
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            // 
            // ColAcción
            // 
            ColAcción.HeaderText = "Acción";
            ColAcción.Name = "ColAcción";
            ColAcción.ReadOnly = true;
            ColAcción.Text = "Dar de baja";
            ColAcción.UseColumnTextForButtonValue = true;
            // 
            // txtClientes
            // 
            txtClientes.Location = new Point(137, 39);
            txtClientes.Name = "txtClientes";
            txtClientes.Size = new Size(410, 23);
            txtClientes.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 42);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente";
            // 
            // txtNumeroDeTicket
            // 
            txtNumeroDeTicket.Location = new Point(137, 6);
            txtNumeroDeTicket.Name = "txtNumeroDeTicket";
            txtNumeroDeTicket.Size = new Size(170, 23);
            txtNumeroDeTicket.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(426, 9);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(121, 23);
            dtpFecha.TabIndex = 2;
            // 
            // lblFechaDeEmision
            // 
            lblFechaDeEmision.AutoSize = true;
            lblFechaDeEmision.Location = new Point(313, 9);
            lblFechaDeEmision.Name = "lblFechaDeEmision";
            lblFechaDeEmision.Size = new Size(99, 15);
            lblFechaDeEmision.TabIndex = 1;
            lblFechaDeEmision.Text = "Fecha de emisión";
            // 
            // lblNumeroDeTicket
            // 
            lblNumeroDeTicket.AutoSize = true;
            lblNumeroDeTicket.Location = new Point(12, 9);
            lblNumeroDeTicket.Name = "lblNumeroDeTicket";
            lblNumeroDeTicket.Size = new Size(101, 15);
            lblNumeroDeTicket.TabIndex = 0;
            lblNumeroDeTicket.Text = "Numero de Ticket";
            // 
            // FrmBajaTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_big_screen_movie_background_picture_image_809169;
            ClientSize = new Size(571, 291);
            Controls.Add(txtClientes);
            Controls.Add(lblCliente);
            Controls.Add(dgvTicket);
            Controls.Add(txtNumeroDeTicket);
            Controls.Add(btnSalir);
            Controls.Add(dtpFecha);
            Controls.Add(btnConsular);
            Controls.Add(lblFechaDeEmision);
            Controls.Add(lblNumeroDeTicket);
            Name = "FrmBajaTicket";
            Text = "FrmBajaTicket";
            Load += FrmBajaTicket_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsular;
        private Button btnSalir;
        private DataGridView dgvTicket;
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