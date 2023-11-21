namespace CineFront.Diseño
{
    partial class FrmAltaFuncion
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
            dgvFunciones = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColHorario = new DataGridViewTextBoxColumn();
            ColFecDesde = new DataGridViewTextBoxColumn();
            ColFecHasta = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            btnConfirmar = new Button();
            btnSalir = new Button();
            lblFecDesde = new Label();
            cboPelicula = new ComboBox();
            lblPelicula = new Label();
            dtpDesde = new DateTimePicker();
            lblFecHasta = new Label();
            cboSala = new ComboBox();
            dtpHasta = new DateTimePicker();
            lblSala = new Label();
            lblHorario = new Label();
            cboHorarios = new ComboBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            SuspendLayout();
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { ColID, ColPelicula, ColSala, ColHorario, ColFecDesde, ColFecHasta, ColPrecio, ColAccion });
            dgvFunciones.Location = new Point(6, 155);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowTemplate.Height = 25;
            dgvFunciones.Size = new Size(844, 150);
            dgvFunciones.TabIndex = 15;
            dgvFunciones.CellContentClick += dgvFunciones_CellContentClick;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Visible = false;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            ColPelicula.Width = 200;
            // 
            // ColSala
            // 
            ColSala.HeaderText = "Sala";
            ColSala.Name = "ColSala";
            ColSala.ReadOnly = true;
            // 
            // ColHorario
            // 
            ColHorario.HeaderText = "Horario";
            ColHorario.Name = "ColHorario";
            ColHorario.ReadOnly = true;
            // 
            // ColFecDesde
            // 
            ColFecDesde.HeaderText = "Fecha desde";
            ColFecDesde.Name = "ColFecDesde";
            ColFecDesde.ReadOnly = true;
            // 
            // ColFecHasta
            // 
            ColFecHasta.HeaderText = "Fecha hasta";
            ColFecHasta.Name = "ColFecHasta";
            ColFecHasta.ReadOnly = true;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // ColAccion
            // 
            ColAccion.HeaderText = "Accion";
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Text = "Quitar";
            ColAccion.UseColumnTextForButtonValue = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(733, 117);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 23);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(6, 311);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(93, 23);
            btnConfirmar.TabIndex = 17;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(755, 311);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblFecDesde
            // 
            lblFecDesde.AutoSize = true;
            lblFecDesde.Location = new Point(309, 41);
            lblFecDesde.Name = "lblFecDesde";
            lblFecDesde.Size = new Size(39, 15);
            lblFecDesde.TabIndex = 7;
            lblFecDesde.Text = "Desde";
            // 
            // cboPelicula
            // 
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(76, 6);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(774, 23);
            cboPelicula.TabIndex = 2;
            cboPelicula.SelectedIndexChanged += cboPelicula_SelectedIndexChanged;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(12, 9);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(48, 15);
            lblPelicula.TabIndex = 5;
            lblPelicula.Text = "Pelicula";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(362, 35);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(264, 23);
            dtpDesde.TabIndex = 11;
            // 
            // lblFecHasta
            // 
            lblFecHasta.AutoSize = true;
            lblFecHasta.Location = new Point(309, 71);
            lblFecHasta.Name = "lblFecHasta";
            lblFecHasta.Size = new Size(37, 15);
            lblFecHasta.TabIndex = 8;
            lblFecHasta.Text = "Hasta";
            // 
            // cboSala
            // 
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(76, 38);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(149, 23);
            cboSala.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(362, 68);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(264, 23);
            dtpHasta.TabIndex = 12;
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new Point(12, 41);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(28, 15);
            lblSala.TabIndex = 1;
            lblSala.Text = "Sala";
            lblSala.Click += lblSala_Click;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(309, 100);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(47, 15);
            lblHorario.TabIndex = 13;
            lblHorario.Text = "Horario";
            // 
            // cboHorarios
            // 
            cboHorarios.FormattingEnabled = true;
            cboHorarios.Location = new Point(362, 97);
            cboHorarios.Name = "cboHorarios";
            cboHorarios.Size = new Size(137, 23);
            cboHorarios.TabIndex = 17;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(12, 97);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(76, 97);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(149, 23);
            txtPrecio.TabIndex = 18;
            // 
            // FrmAltaFuncion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoB;
            ClientSize = new Size(870, 346);
            Controls.Add(txtPrecio);
            Controls.Add(btnSalir);
            Controls.Add(lblPrecio);
            Controls.Add(btnConfirmar);
            Controls.Add(cboHorarios);
            Controls.Add(btnAgregar);
            Controls.Add(lblHorario);
            Controls.Add(dgvFunciones);
            Controls.Add(lblSala);
            Controls.Add(dtpHasta);
            Controls.Add(lblPelicula);
            Controls.Add(cboSala);
            Controls.Add(lblFecDesde);
            Controls.Add(lblFecHasta);
            Controls.Add(cboPelicula);
            Controls.Add(dtpDesde);
            Name = "FrmAltaFuncion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva función";
            Load += FrmAltaFuncion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvFunciones;
        private Button btnAgregar;
        private Button btnConfirmar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColHorario;
        private DataGridViewTextBoxColumn ColFecDesde;
        private DataGridViewTextBoxColumn ColFecHasta;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn ColAccion;
        private Label lblFecDesde;
        private ComboBox cboPelicula;
        private Label lblPelicula;
        private DateTimePicker dtpDesde;
        private Label lblFecHasta;
        private ComboBox cboSala;
        private DateTimePicker dtpHasta;
        private Label lblSala;
        private Label lblHorario;
        private ComboBox cboHorarios;
        private Label lblPrecio;
        private TextBox txtPrecio;
    }
}