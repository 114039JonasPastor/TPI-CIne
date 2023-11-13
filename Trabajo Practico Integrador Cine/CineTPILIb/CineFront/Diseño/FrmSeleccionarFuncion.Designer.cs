namespace CineFront.Diseño
{
    partial class FrmSeleccionarFuncion
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
            cboPelicula = new ComboBox();
            lblPelicula = new Label();
            lblIdioma = new Label();
            cboIdioma = new ComboBox();
            lblHorario = new Label();
            cboHorario = new ComboBox();
            lblFecha = new Label();
            btnComprar = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // cboPelicula
            // 
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(66, 9);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(283, 23);
            cboPelicula.TabIndex = 0;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(12, 9);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(48, 15);
            lblPelicula.TabIndex = 1;
            lblPelicula.Text = "Pelicula";
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(12, 70);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(44, 15);
            lblIdioma.TabIndex = 2;
            lblIdioma.Text = "Idioma";
            lblIdioma.Click += lblIdioma_Click;
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(66, 67);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(190, 23);
            cboIdioma.TabIndex = 3;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(13, 99);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(47, 15);
            lblHorario.TabIndex = 4;
            lblHorario.Text = "Horario";
            // 
            // cboHorario
            // 
            cboHorario.FormattingEnabled = true;
            cboHorario.Location = new Point(66, 96);
            cboHorario.Name = "cboHorario";
            cboHorario.Size = new Size(190, 23);
            cboHorario.TabIndex = 5;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 41);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(118, 141);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(126, 23);
            btnComprar.TabIndex = 7;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(66, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // FrmSeleccionarFuncion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 181);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnComprar);
            Controls.Add(lblFecha);
            Controls.Add(cboHorario);
            Controls.Add(lblHorario);
            Controls.Add(cboIdioma);
            Controls.Add(lblIdioma);
            Controls.Add(lblPelicula);
            Controls.Add(cboPelicula);
            Name = "FrmSeleccionarFuncion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSeleccionarFuncion";
            Load += FrmSeleccionarFuncion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPelicula;
        private Label lblPelicula;
        private Label lblIdioma;
        private ComboBox cboIdioma;
        private Label lblHorario;
        private ComboBox cboHorario;
        private Label lblFecha;
        private Button btnComprar;
        private DateTimePicker dateTimePicker1;
    }
}