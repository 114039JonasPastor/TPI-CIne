namespace CineFront.Diseño
{
    partial class FrmDetallesPelicula
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
            txtSinopsis = new TextBox();
            txtTitulo = new TextBox();
            label2 = new Label();
            lblID = new Label();
            label4 = new Label();
            label5 = new Label();
            cboClasificacion = new ComboBox();
            cboGenero = new ComboBox();
            label6 = new Label();
            cboIdioma = new ComboBox();
            label7 = new Label();
            btnVolver = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtDuracion = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 62);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(165, 144);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(299, 80);
            txtSinopsis.TabIndex = 1;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(165, 100);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(299, 23);
            txtTitulo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 103);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Título:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(177, 62);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 147);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Sinopsis:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 286);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 6;
            label5.Text = "Clasificación:";
            // 
            // cboClasificacion
            // 
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(165, 283);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(172, 23);
            cboClasificacion.TabIndex = 7;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(165, 327);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(172, 23);
            cboGenero.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 330);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 8;
            label6.Text = "Género:";
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(165, 371);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(172, 23);
            cboIdioma.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 374);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 10;
            label7.Text = "Idioma:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(413, 438);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 41);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(55, 438);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 41);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(165, 438);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 41);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDuracion
            // 
            txtDuracion.AutoSize = true;
            txtDuracion.Location = new Point(83, 245);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(58, 15);
            txtDuracion.TabIndex = 15;
            txtDuracion.Text = "Duración:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 23);
            textBox1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 245);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 17;
            label8.Text = "minutos.";
            // 
            // FrmDetallesPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoB;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(535, 515);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(txtDuracion);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnVolver);
            Controls.Add(cboIdioma);
            Controls.Add(label7);
            Controls.Add(cboGenero);
            Controls.Add(label6);
            Controls.Add(cboClasificacion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblID);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtSinopsis);
            Controls.Add(label1);
            Name = "FrmDetallesPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalles de la Pelicula";
            Load += FrmDetallesPelicula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSinopsis;
        private TextBox txtTitulo;
        private Label label2;
        private Label lblID;
        private Label label4;
        private Label label5;
        private ComboBox cboClasificacion;
        private ComboBox cboGenero;
        private Label label6;
        private ComboBox cboIdioma;
        private Label label7;
        private Button btnVolver;
        private Button btnModificar;
        private Button btnGuardar;
        private Label txtDuracion;
        private TextBox textBox1;
        private Label label8;
    }
}