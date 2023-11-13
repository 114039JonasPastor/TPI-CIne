namespace CineFront.Diseño
{
    partial class FrmConsultaPelicula
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
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            cboGenero = new ComboBox();
            cboIdioma = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtDuracion = new TextBox();
            txtTitulo = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvAltaPelicula = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colDuracion = new DataGridViewTextBoxColumn();
            colClasificacion = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colIdioma = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAltaPelicula).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(cboGenero);
            groupBox1.Controls.Add(cboIdioma);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(450, 79);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 22;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(326, 16);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(199, 23);
            cboGenero.TabIndex = 21;
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(326, 50);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(199, 23);
            cboIdioma.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(273, 55);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 19;
            label8.Text = "Idioma:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 19);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 18;
            label5.Text = "Género:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 53);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 17;
            label3.Text = "minutos";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(72, 50);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(84, 23);
            txtDuracion.TabIndex = 16;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(72, 16);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(164, 23);
            txtTitulo.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 53);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 14;
            label6.Text = "Duracion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Titulo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 1;
            label1.Text = "CONSULTA PELICULAS";
            // 
            // dgvAltaPelicula
            // 
            dgvAltaPelicula.AllowUserToAddRows = false;
            dgvAltaPelicula.AllowUserToDeleteRows = false;
            dgvAltaPelicula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAltaPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAltaPelicula.Columns.AddRange(new DataGridViewColumn[] { colId, colTitulo, colDuracion, colClasificacion, colGenero, colIdioma });
            dgvAltaPelicula.Location = new Point(33, 187);
            dgvAltaPelicula.Name = "dgvAltaPelicula";
            dgvAltaPelicula.ReadOnly = true;
            dgvAltaPelicula.RowTemplate.Height = 25;
            dgvAltaPelicula.Size = new Size(541, 199);
            dgvAltaPelicula.TabIndex = 15;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colTitulo
            // 
            colTitulo.FillWeight = 150F;
            colTitulo.HeaderText = "Título";
            colTitulo.Name = "colTitulo";
            colTitulo.ReadOnly = true;
            // 
            // colDuracion
            // 
            colDuracion.HeaderText = "Duracion";
            colDuracion.Name = "colDuracion";
            colDuracion.ReadOnly = true;
            // 
            // colClasificacion
            // 
            colClasificacion.HeaderText = "Clasificación";
            colClasificacion.Name = "colClasificacion";
            colClasificacion.ReadOnly = true;
            // 
            // colGenero
            // 
            colGenero.HeaderText = "Género";
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            // 
            // colIdioma
            // 
            colIdioma.HeaderText = "Idioma";
            colIdioma.Name = "colIdioma";
            colIdioma.ReadOnly = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(499, 392);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmConsultaPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 426);
            Controls.Add(btnSalir);
            Controls.Add(dgvAltaPelicula);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmConsultaPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaPelicula";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAltaPelicula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtDuracion;
        private TextBox txtTitulo;
        private Label label6;
        private Label label2;
        private Label label3;
        private ComboBox cboGenero;
        private ComboBox cboIdioma;
        private Label label8;
        private Label label5;
        private DataGridView dgvAltaPelicula;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colDuracion;
        private DataGridViewTextBoxColumn colClasificacion;
        private DataGridViewTextBoxColumn colGenero;
        private DataGridViewTextBoxColumn colIdioma;
        private Button btnConsultar;
        private Button btnSalir;
    }
}