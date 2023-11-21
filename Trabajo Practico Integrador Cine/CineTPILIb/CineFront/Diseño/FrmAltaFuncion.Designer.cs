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
            this.components = new System.ComponentModel.Container();
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