namespace CineFront.Diseño
{
    partial class FrmConsultarFunciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarFunciones));
            dgvFunciones = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColTipoDeSala = new DataGridViewTextBoxColumn();
            ColHorario = new DataGridViewTextBoxColumn();
            ColFecDesde = new DataGridViewTextBoxColumn();
            ColFecHasta = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            txtNumero = new TextBox();
            lblNumeroDeFuncion = new Label();
            lblFecHasta = new Label();
            lblFecDesde = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            btnConsultar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { ColID, ColPelicula, ColSala, ColTipoDeSala, ColHorario, ColFecDesde, ColFecHasta, ColPrecio, ColAccion });
            dgvFunciones.Location = new Point(12, 147);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowTemplate.Height = 25;
            dgvFunciones.Size = new Size(844, 150);
            dgvFunciones.TabIndex = 16;
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
            // 
            // ColSala
            // 
            ColSala.HeaderText = "Sala";
            ColSala.Name = "ColSala";
            ColSala.ReadOnly = true;
            // 
            // ColTipoDeSala
            // 
            ColTipoDeSala.HeaderText = "Tipo de sala";
            ColTipoDeSala.Name = "ColTipoDeSala";
            ColTipoDeSala.ReadOnly = true;
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
            ColAccion.Text = "Dar de baja";
            ColAccion.UseColumnTextForButtonValue = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(755, 303);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 23);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(lblNumeroDeFuncion);
            groupBox1.Controls.Add(lblFecHasta);
            groupBox1.Controls.Add(lblFecDesde);
            groupBox1.Controls.Add(dtpHasta);
            groupBox1.Controls.Add(dtpDesde);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 100);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(141, 22);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(220, 23);
            txtNumero.TabIndex = 5;
            // 
            // lblNumeroDeFuncion
            // 
            lblNumeroDeFuncion.AutoSize = true;
            lblNumeroDeFuncion.Location = new Point(6, 25);
            lblNumeroDeFuncion.Name = "lblNumeroDeFuncion";
            lblNumeroDeFuncion.Size = new Size(113, 15);
            lblNumeroDeFuncion.TabIndex = 4;
            lblNumeroDeFuncion.Text = "Numero de Función";
            // 
            // lblFecHasta
            // 
            lblFecHasta.AutoSize = true;
            lblFecHasta.Location = new Point(444, 54);
            lblFecHasta.Name = "lblFecHasta";
            lblFecHasta.Size = new Size(37, 15);
            lblFecHasta.TabIndex = 3;
            lblFecHasta.Text = "Hasta";
            // 
            // lblFecDesde
            // 
            lblFecDesde.AutoSize = true;
            lblFecDesde.Location = new Point(444, 25);
            lblFecDesde.Name = "lblFecDesde";
            lblFecDesde.Size = new Size(39, 15);
            lblFecDesde.TabIndex = 2;
            lblFecDesde.Text = "Desde";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(508, 48);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(266, 23);
            dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(508, 19);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(266, 23);
            dtpDesde.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(761, 118);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(95, 23);
            btnConsultar.TabIndex = 22;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 303);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmConsultarFunciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(870, 334);
            Controls.Add(btnModificar);
            Controls.Add(btnConsultar);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(dgvFunciones);
            Name = "FrmConsultarFunciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar funciones";
            Load += FrmConsultarFunciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFunciones;
        private Button btnSalir;
        private GroupBox groupBox1;
        private TextBox txtNumero;
        private Label lblNumeroDeFuncion;
        private Label lblFecHasta;
        private Label lblFecDesde;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColTipoDeSala;
        private DataGridViewTextBoxColumn ColHorario;
        private DataGridViewTextBoxColumn ColFecDesde;
        private DataGridViewTextBoxColumn ColFecHasta;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn ColAccion;
        private Button btnModificar;
    }
}