namespace CineFront
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPelículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quienesSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.funcionesToolStripMenuItem,
            this.peliculasToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.soporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarFuncionesToolStripMenuItem,
            this.agregarFuncionToolStripMenuItem});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // consultarFuncionesToolStripMenuItem
            // 
            this.consultarFuncionesToolStripMenuItem.Name = "consultarFuncionesToolStripMenuItem";
            this.consultarFuncionesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultarFuncionesToolStripMenuItem.Text = "Consultar Funciones";
            // 
            // agregarFuncionToolStripMenuItem
            // 
            this.agregarFuncionToolStripMenuItem.Name = "agregarFuncionToolStripMenuItem";
            this.agregarFuncionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.agregarFuncionToolStripMenuItem.Text = "Agregar Funcion";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPeliculasToolStripMenuItem,
            this.nuevaPelículaToolStripMenuItem});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // consultarPeliculasToolStripMenuItem
            // 
            this.consultarPeliculasToolStripMenuItem.Name = "consultarPeliculasToolStripMenuItem";
            this.consultarPeliculasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarPeliculasToolStripMenuItem.Text = "Consultar Películas";
            this.consultarPeliculasToolStripMenuItem.Click += new System.EventHandler(this.consultarPeliculasToolStripMenuItem_Click_1);
            // 
            // nuevaPelículaToolStripMenuItem
            // 
            this.nuevaPelículaToolStripMenuItem.Name = "nuevaPelículaToolStripMenuItem";
            this.nuevaPelículaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaPelículaToolStripMenuItem.Text = "Agregar Película";
            this.nuevaPelículaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPelículaToolStripMenuItem_Click_1);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTicketToolStripMenuItem,
            this.bajaTicketToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // nuevoTicketToolStripMenuItem
            // 
            this.nuevoTicketToolStripMenuItem.Name = "nuevoTicketToolStripMenuItem";
            this.nuevoTicketToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.nuevoTicketToolStripMenuItem.Text = "Nuevo Ticket";
            // 
            // bajaTicketToolStripMenuItem
            // 
            this.bajaTicketToolStripMenuItem.Name = "bajaTicketToolStripMenuItem";
            this.bajaTicketToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.bajaTicketToolStripMenuItem.Text = "Baja Ticket";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quienesSomosToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // quienesSomosToolStripMenuItem
            // 
            this.quienesSomosToolStripMenuItem.Name = "quienesSomosToolStripMenuItem";
            this.quienesSomosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.quienesSomosToolStripMenuItem.Text = "¿Quienes somos?";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem funcionesToolStripMenuItem;
        private ToolStripMenuItem consultarFuncionesToolStripMenuItem;
        private ToolStripMenuItem agregarFuncionToolStripMenuItem;
        private ToolStripMenuItem ticketsToolStripMenuItem;
        private ToolStripMenuItem nuevoTicketToolStripMenuItem;
        private ToolStripMenuItem bajaTicketToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem quienesSomosToolStripMenuItem;
        private ToolStripMenuItem peliculasToolStripMenuItem;
        private ToolStripMenuItem consultarPeliculasToolStripMenuItem;
        private ToolStripMenuItem nuevaPelículaToolStripMenuItem;
    }
}