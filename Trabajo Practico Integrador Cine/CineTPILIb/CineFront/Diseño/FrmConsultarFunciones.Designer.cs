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
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumeroDeFuncion = new System.Windows.Forms.Label();
            this.lblFecHasta = new System.Windows.Forms.Label();
            this.lblFecDesde = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dgvFunciones.Location = new System.Drawing.Point(12, 147);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowTemplate.Height = 25;
            this.dgvFunciones.Size = new System.Drawing.Size(844, 150);
            this.dgvFunciones.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(416, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblNumeroDeFuncion);
            this.groupBox1.Controls.Add(this.lblFecHasta);
            this.groupBox1.Controls.Add(this.lblFecDesde);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(141, 22);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(220, 23);
            this.txtNumero.TabIndex = 5;
            // 
            // lblNumeroDeFuncion
            // 
            this.lblNumeroDeFuncion.AutoSize = true;
            this.lblNumeroDeFuncion.Location = new System.Drawing.Point(6, 25);
            this.lblNumeroDeFuncion.Name = "lblNumeroDeFuncion";
            this.lblNumeroDeFuncion.Size = new System.Drawing.Size(113, 15);
            this.lblNumeroDeFuncion.TabIndex = 4;
            this.lblNumeroDeFuncion.Text = "Numero de Función";
            // 
            // lblFecHasta
            // 
            this.lblFecHasta.AutoSize = true;
            this.lblFecHasta.Location = new System.Drawing.Point(540, 57);
            this.lblFecHasta.Name = "lblFecHasta";
            this.lblFecHasta.Size = new System.Drawing.Size(37, 15);
            this.lblFecHasta.TabIndex = 3;
            this.lblFecHasta.Text = "Hasta";
            // 
            // lblFecDesde
            // 
            this.lblFecDesde.AutoSize = true;
            this.lblFecDesde.Location = new System.Drawing.Point(540, 28);
            this.lblFecDesde.Name = "lblFecDesde";
            this.lblFecDesde.Size = new System.Drawing.Size(39, 15);
            this.lblFecDesde.TabIndex = 2;
            this.lblFecDesde.Text = "Desde";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(638, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(638, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(761, 118);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 23);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
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
            // 
            // FrmConsultarFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 334);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvFunciones);
            this.Name = "FrmConsultarFunciones";
            this.Text = "ConsultarFuncionesFrm";
            this.Load += new System.EventHandler(this.FrmConsultarFunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvFunciones;
        private Button btnSalir;
        private GroupBox groupBox1;
        private TextBox txtNumero;
        private Label lblNumeroDeFuncion;
        private Label lblFecHasta;
        private Label lblFecDesde;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnConsultar;
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