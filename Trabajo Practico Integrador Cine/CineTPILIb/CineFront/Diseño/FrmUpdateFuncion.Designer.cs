namespace CineFront.Diseño
{
    partial class FrmUpdateFuncion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHorarios = new System.Windows.Forms.TextBox();
            this.txtSalas = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboHorarios = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.lblFecHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblFecDesde = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtHorarios);
            this.groupBox1.Controls.Add(this.txtSalas);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 158);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtHorarios
            // 
            this.txtHorarios.Location = new System.Drawing.Point(329, 121);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(100, 23);
            this.txtHorarios.TabIndex = 20;
            // 
            // txtSalas
            // 
            this.txtSalas.Location = new System.Drawing.Point(212, 87);
            this.txtSalas.Name = "txtSalas";
            this.txtSalas.Size = new System.Drawing.Size(100, 23);
            this.txtSalas.TabIndex = 19;
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
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(0, 51);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(28, 15);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(507, 78);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(229, 23);
            this.dtpHasta.TabIndex = 12;
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(64, 48);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(100, 23);
            this.cboSala.TabIndex = 0;
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
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(0, 19);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(48, 15);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Pelicula";
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(64, 16);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(672, 23);
            this.cboPelicula.TabIndex = 2;
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(693, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 165);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmUpdateFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineFront.Properties.Resources.fondoB;
            this.ClientSize = new System.Drawing.Size(784, 199);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUpdateFuncion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Función";
            this.Load += new System.EventHandler(this.FrmUpdateFuncion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private ComboBox cboHorarios;
        private Label lblHorario;
        private Label lblSala;
        private DateTimePicker dtpHasta;
        private ComboBox cboSala;
        private Label lblFecHasta;
        private DateTimePicker dtpDesde;
        private Label lblPelicula;
        private ComboBox cboPelicula;
        private Label lblFecDesde;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtHorarios;
        private TextBox txtSalas;
    }
}