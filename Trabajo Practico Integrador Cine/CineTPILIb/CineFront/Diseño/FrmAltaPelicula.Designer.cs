namespace CineFront.Diseño
{
    partial class FrmAltaPelicula
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTitulo = new TextBox();
            cboClasif = new ComboBox();
            cboIdioma = new ComboBox();
            cboGenero = new ComboBox();
            txtDuracion = new TextBox();
            txtSinopsis = new TextBox();
            dgvAltaPelicula = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            colId = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colDuracion = new DataGridViewTextBoxColumn();
            colClasificacion = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colIdioma = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAltaPelicula).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "PELICULAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 97);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "minutos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 61);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Clasificacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 97);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 6;
            label5.Text = "Género:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 97);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Duracion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 133);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 4;
            label7.Text = "Sinopsis:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(427, 133);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 7;
            label8.Text = "Idioma:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(90, 58);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(279, 23);
            txtTitulo.TabIndex = 8;
            // 
            // cboClasif
            // 
            cboClasif.FormattingEnabled = true;
            cboClasif.Location = new Point(480, 58);
            cboClasif.Name = "cboClasif";
            cboClasif.Size = new Size(199, 23);
            cboClasif.TabIndex = 9;
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(480, 128);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(199, 23);
            cboIdioma.TabIndex = 10;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(480, 94);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(199, 23);
            cboGenero.TabIndex = 11;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(90, 94);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(105, 23);
            txtDuracion.TabIndex = 12;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(90, 133);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(279, 55);
            txtSinopsis.TabIndex = 13;
            // 
            // dgvAltaPelicula
            // 
            dgvAltaPelicula.AllowUserToAddRows = false;
            dgvAltaPelicula.AllowUserToDeleteRows = false;
            dgvAltaPelicula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAltaPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAltaPelicula.Columns.AddRange(new DataGridViewColumn[] { colId, colTitulo, colDuracion, colClasificacion, colGenero, colIdioma });
            dgvAltaPelicula.Location = new Point(26, 208);
            dgvAltaPelicula.Name = "dgvAltaPelicula";
            dgvAltaPelicula.ReadOnly = true;
            dgvAltaPelicula.RowTemplate.Height = 25;
            dgvAltaPelicula.Size = new Size(653, 190);
            dgvAltaPelicula.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(604, 165);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(26, 415);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(604, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
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
            // FrmAltaPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cine;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvAltaPelicula);
            Controls.Add(txtSinopsis);
            Controls.Add(txtDuracion);
            Controls.Add(cboGenero);
            Controls.Add(cboIdioma);
            Controls.Add(cboClasif);
            Controls.Add(txtTitulo);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAltaPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta Pelicula";
            Load += FrmAltaPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAltaPelicula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTitulo;
        private ComboBox cboClasif;
        private ComboBox cboIdioma;
        private ComboBox cboGenero;
        private TextBox txtDuracion;
        private TextBox txtSinopsis;
        private DataGridView dgvAltaPelicula;
        private Button btnAgregar;
        private Button btnModificar;
        private Button button3;
        private Button btnSalir;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colDuracion;
        private DataGridViewTextBoxColumn colClasificacion;
        private DataGridViewTextBoxColumn colGenero;
        private DataGridViewTextBoxColumn colIdioma;
    }
}