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
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblFecDesde = new System.Windows.Forms.Label();
            this.lblFecHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboHorarios = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(64, 48);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(100, 23);
            this.cboSala.TabIndex = 0;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(0, 51);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(28, 15);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala";
            this.lblSala.Click += new System.EventHandler(this.lblSala_Click);
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(64, 16);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(672, 23);
            this.cboPelicula.TabIndex = 2;
            this.cboPelicula.SelectedIndexChanged += new System.EventHandler(this.cboPelicula_SelectedIndexChanged);
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(0, 19);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(48, 15);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Pelicula";
            // 
            // lblFecDesde
            // 
            this.lblFecDesde.AutoSize = true;
            this.lblFecDesde.Location = new System.Drawing.Point(454, 51);
            this.lblFecDesde.Name = "lblFecDesde";
            this.lblFecDesde.Size = new System.Drawing.Size(39, 15);
            this.lblFecDesde.TabIndex = 7;
            this.lblFecDesde.Text = "Desde";
            // 
            // lblFecHasta
            // 
            this.lblFecHasta.AutoSize = true;
            this.lblFecHasta.Location = new System.Drawing.Point(454, 81);
            this.lblFecHasta.Name = "lblFecHasta";
            this.lblFecHasta.Size = new System.Drawing.Size(37, 15);
            this.lblFecHasta.TabIndex = 8;
            this.lblFecHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(507, 45);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(229, 23);
            this.dtpDesde.TabIndex = 11;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(507, 78);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(229, 23);
            this.dtpHasta.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.cboHorarios);
            this.groupBox1.Controls.Add(this.lblHorario);
            this.groupBox1.Controls.Add(this.lblSala);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.cboSala);
            this.groupBox1.Controls.Add(this.lblFecHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.lblPelicula);
            this.groupBox1.Controls.Add(this.cboPelicula);
            this.groupBox1.Controls.Add(this.lblFecDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 158);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(64, 110);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 18;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(0, 113);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            // 
            // cboHorarios
            // 
            this.cboHorarios.FormattingEnabled = true;
            this.cboHorarios.Location = new System.Drawing.Point(507, 107);
            this.cboHorarios.Name = "cboHorarios";
            this.cboHorarios.Size = new System.Drawing.Size(137, 23);
            this.cboHorarios.TabIndex = 17;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(454, 110);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(47, 15);
            this.lblHorario.TabIndex = 13;
            this.lblHorario.Text = "Horario";
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
            this.dgvFunciones.Location = new System.Drawing.Point(12, 205);
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
            this.btnAgregar.Location = new System.Drawing.Point(739, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 361);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 23);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(761, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAltaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 401);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAltaFuncion";
            this.Text = "NuevaFuncionFrm";
            this.Load += new System.EventHandler(this.FrmAltaFuncion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cboSala;
        private Label lblSala;
        private ComboBox cboPelicula;
        private Label lblPelicula;
        private Label lblFecDesde;
        private Label lblFecHasta;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private GroupBox groupBox1;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private ComboBox cboHorarios;
        private Label lblHorario;
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
    }
}