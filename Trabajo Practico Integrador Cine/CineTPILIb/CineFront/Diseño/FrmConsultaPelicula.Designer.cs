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
            chkConsulta = new CheckBox();
            btnConsultar = new Button();
            cboGenero = new ComboBox();
            cboIdioma = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            txtSinopsis = new TextBox();
            txtTitulo = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvPelicula = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colSinopsis = new DataGridViewTextBoxColumn();
            colClasificacion = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colIdioma = new DataGridViewTextBoxColumn();
            colAccion = new DataGridViewButtonColumn();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(chkConsulta);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(cboGenero);
            groupBox1.Controls.Add(cboIdioma);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSinopsis);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // chkConsulta
            // 
            chkConsulta.AutoSize = true;
            chkConsulta.Location = new Point(670, 32);
            chkConsulta.Name = "chkConsulta";
            chkConsulta.Size = new Size(75, 19);
            chkConsulta.TabIndex = 23;
            chkConsulta.Text = "Sin filtros";
            chkConsulta.UseVisualStyleBackColor = true;
            chkConsulta.CheckedChanged += chkConsulta_CheckedChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(670, 62);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 22;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.Enabled = false;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(439, 28);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(199, 23);
            cboGenero.TabIndex = 21;
            cboGenero.SelectedIndexChanged += cboGenero_SelectedIndexChanged;
            // 
            // cboIdioma
            // 
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.Enabled = false;
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(439, 62);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(199, 23);
            cboIdioma.TabIndex = 20;
            cboIdioma.SelectedIndexChanged += cboIdioma_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(386, 67);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 19;
            label8.Text = "Idioma:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 31);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 18;
            label5.Text = "Género:";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(72, 62);
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(294, 23);
            txtSinopsis.TabIndex = 16;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(72, 28);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(294, 23);
            txtTitulo.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 65);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 14;
            label6.Text = "Sinopsis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 31);
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
            // dgvPelicula
            // 
            dgvPelicula.AllowUserToAddRows = false;
            dgvPelicula.AllowUserToDeleteRows = false;
            dgvPelicula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPelicula.BackgroundColor = SystemColors.Control;
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { colId, colTitulo, colSinopsis, colClasificacion, colGenero, colIdioma, colAccion });
            dgvPelicula.Location = new Point(33, 187);
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.ReadOnly = true;
            dgvPelicula.RowTemplate.Height = 25;
            dgvPelicula.Size = new Size(771, 199);
            dgvPelicula.TabIndex = 15;
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
            // colSinopsis
            // 
            colSinopsis.HeaderText = "Sinopsis";
            colSinopsis.Name = "colSinopsis";
            colSinopsis.ReadOnly = true;
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
            // colAccion
            // 
            colAccion.HeaderText = "Acción";
            colAccion.Name = "colAccion";
            colAccion.ReadOnly = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(729, 391);
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
            BackgroundImage = Properties.Resources.cine;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(841, 426);
            Controls.Add(btnSalir);
            Controls.Add(dgvPelicula);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmConsultaPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaPelicula";
            Load += FrmConsultaPelicula_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtSinopsis;
        private TextBox txtTitulo;
        private Label label6;
        private Label label2;
        private ComboBox cboGenero;
        private ComboBox cboIdioma;
        private Label label8;
        private Label label5;
        private DataGridView dgvPelicula;
        private Button btnConsultar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colSinopsis;
        private DataGridViewTextBoxColumn colClasificacion;
        private DataGridViewTextBoxColumn colGenero;
        private DataGridViewTextBoxColumn colIdioma;
        private DataGridViewButtonColumn colAccion;
        private CheckBox chkConsulta;
    }
}