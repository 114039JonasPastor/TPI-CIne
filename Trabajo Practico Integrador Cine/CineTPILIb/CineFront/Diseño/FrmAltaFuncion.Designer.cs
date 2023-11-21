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
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFecDesde = new System.Windows.Forms.Label();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecHasta = new System.Windows.Forms.Label();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cboHorarios = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColPelicula,
            this.ColSala,
            this.ColHorario,
            this.ColFecDesde,
            this.ColFecHasta,
            this.ColPrecio,
            this.ColAccion});
            this.dgvFunciones.Location = new System.Drawing.Point(6, 155);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowTemplate.Height = 25;
            this.dgvFunciones.Size = new System.Drawing.Size(844, 150);
            this.dgvFunciones.TabIndex = 15;
            this.dgvFunciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciones_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColPelicula
            // 
            this.ColPelicula.HeaderText = "Pelicula";
            this.ColPelicula.Name = "ColPelicula";
            this.ColPelicula.ReadOnly = true;
            this.ColPelicula.Width = 200;
            // 
            // ColSala
            // 
            this.ColSala.HeaderText = "Sala";
            this.ColSala.Name = "ColSala";
            this.ColSala.ReadOnly = true;
            // 
            // ColHorario
            // 
            this.ColHorario.HeaderText = "Horario";
            this.ColHorario.Name = "ColHorario";
            this.ColHorario.ReadOnly = true;
            // 
            // ColFecDesde
            // 
            this.ColFecDesde.HeaderText = "Fecha desde";
            this.ColFecDesde.Name = "ColFecDesde";
            this.ColFecDesde.ReadOnly = true;
            // 
            // ColFecHasta
            // 
            this.ColFecHasta.HeaderText = "Fecha hasta";
            this.ColFecHasta.Name = "ColFecHasta";
            this.ColFecHasta.ReadOnly = true;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Accion";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Text = "Quitar";
            this.ColAccion.UseColumnTextForButtonValue = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(733, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(6, 311);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 23);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(755, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblFecDesde
            // 
            this.lblFecDesde.AutoSize = true;
            this.lblFecDesde.Location = new System.Drawing.Point(568, 41);
            this.lblFecDesde.Name = "lblFecDesde";
            this.lblFecDesde.Size = new System.Drawing.Size(39, 15);
            this.lblFecDesde.TabIndex = 7;
            this.lblFecDesde.Text = "Desde";
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(76, 6);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(774, 23);
            this.cboPelicula.TabIndex = 2;
            this.cboPelicula.SelectedIndexChanged += new System.EventHandler(this.cboPelicula_SelectedIndexChanged);
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(12, 9);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(48, 15);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Pelicula";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(621, 35);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(229, 23);
            this.dtpDesde.TabIndex = 11;
            // 
            // lblFecHasta
            // 
            this.lblFecHasta.AutoSize = true;
            this.lblFecHasta.Location = new System.Drawing.Point(568, 71);
            this.lblFecHasta.Name = "lblFecHasta";
            this.lblFecHasta.Size = new System.Drawing.Size(37, 15);
            this.lblFecHasta.TabIndex = 8;
            this.lblFecHasta.Text = "Hasta";
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(76, 38);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(149, 23);
            this.cboSala.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(621, 68);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(229, 23);
            this.dtpHasta.TabIndex = 12;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(12, 41);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(28, 15);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala";
            this.lblSala.Click += new System.EventHandler(this.lblSala_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(568, 100);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(47, 15);
            this.lblHorario.TabIndex = 13;
            this.lblHorario.Text = "Horario";
            // 
            // cboHorarios
            // 
            this.cboHorarios.FormattingEnabled = true;
            this.cboHorarios.Location = new System.Drawing.Point(621, 97);
            this.cboHorarios.Name = "cboHorarios";
            this.cboHorarios.Size = new System.Drawing.Size(137, 23);
            this.cboHorarios.TabIndex = 17;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 97);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(76, 97);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(149, 23);
            this.txtPrecio.TabIndex = 18;
            // 
            // FrmAltaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineFront.Properties.Resources.fondoB;
            this.ClientSize = new System.Drawing.Size(870, 346);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cboHorarios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.lblFecDesde);
            this.Controls.Add(this.lblFecHasta);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.dtpDesde);
            this.Name = "FrmAltaFuncion";
            this.Text = "NuevaFuncionFrm";
            this.Load += new System.EventHandler(this.FrmAltaFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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