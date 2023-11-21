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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            consultarFuncionesToolStripMenuItem = new ToolStripMenuItem();
            agregarFuncionToolStripMenuItem = new ToolStripMenuItem();
            peliculasToolStripMenuItem = new ToolStripMenuItem();
            consultarPeliculasToolStripMenuItem = new ToolStripMenuItem();
            nuevaPelículaToolStripMenuItem = new ToolStripMenuItem();
            ticketsToolStripMenuItem = new ToolStripMenuItem();
            nuevoTicketToolStripMenuItem = new ToolStripMenuItem();
            bajaTicketToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            quienesSomosToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, funcionesToolStripMenuItem, peliculasToolStripMenuItem, ticketsToolStripMenuItem, reportesToolStripMenuItem, soporteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(715, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem, salirToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(143, 22);
            salirToolStripMenuItem.Text = "Cerrar Sesion";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click_1;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(143, 22);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem_Click;
            // 
            // funcionesToolStripMenuItem
            // 
            funcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarFuncionesToolStripMenuItem, agregarFuncionToolStripMenuItem });
            funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            funcionesToolStripMenuItem.Size = new Size(73, 20);
            funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // consultarFuncionesToolStripMenuItem
            // 
            consultarFuncionesToolStripMenuItem.Name = "consultarFuncionesToolStripMenuItem";
            consultarFuncionesToolStripMenuItem.Size = new Size(182, 22);
            consultarFuncionesToolStripMenuItem.Text = "Consultar Funciones";
            consultarFuncionesToolStripMenuItem.Click += consultarFuncionesToolStripMenuItem_Click;
            // 
            // agregarFuncionToolStripMenuItem
            // 
            agregarFuncionToolStripMenuItem.Name = "agregarFuncionToolStripMenuItem";
            agregarFuncionToolStripMenuItem.Size = new Size(182, 22);
            agregarFuncionToolStripMenuItem.Text = "Agregar Funcion";
            agregarFuncionToolStripMenuItem.Click += agregarFuncionToolStripMenuItem_Click;
            // 
            // peliculasToolStripMenuItem
            // 
            peliculasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarPeliculasToolStripMenuItem, nuevaPelículaToolStripMenuItem });
            peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            peliculasToolStripMenuItem.Size = new Size(65, 20);
            peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // consultarPeliculasToolStripMenuItem
            // 
            consultarPeliculasToolStripMenuItem.Name = "consultarPeliculasToolStripMenuItem";
            consultarPeliculasToolStripMenuItem.Size = new Size(174, 22);
            consultarPeliculasToolStripMenuItem.Text = "Consultar Películas";
            consultarPeliculasToolStripMenuItem.Click += consultarPeliculasToolStripMenuItem_Click_1;
            // 
            // nuevaPelículaToolStripMenuItem
            // 
            nuevaPelículaToolStripMenuItem.Name = "nuevaPelículaToolStripMenuItem";
            nuevaPelículaToolStripMenuItem.Size = new Size(174, 22);
            nuevaPelículaToolStripMenuItem.Text = "Agregar Película";
            nuevaPelículaToolStripMenuItem.Click += nuevaPelículaToolStripMenuItem_Click_1;
            // 
            // ticketsToolStripMenuItem
            // 
            ticketsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoTicketToolStripMenuItem, bajaTicketToolStripMenuItem });
            ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            ticketsToolStripMenuItem.Size = new Size(55, 20);
            ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // nuevoTicketToolStripMenuItem
            // 
            nuevoTicketToolStripMenuItem.Name = "nuevoTicketToolStripMenuItem";
            nuevoTicketToolStripMenuItem.Size = new Size(143, 22);
            nuevoTicketToolStripMenuItem.Text = "Nuevo Ticket";
            nuevoTicketToolStripMenuItem.Click += nuevoTicketToolStripMenuItem_Click;
            // 
            // bajaTicketToolStripMenuItem
            // 
            bajaTicketToolStripMenuItem.Name = "bajaTicketToolStripMenuItem";
            bajaTicketToolStripMenuItem.Size = new Size(143, 22);
            bajaTicketToolStripMenuItem.Text = "Baja Ticket";
            bajaTicketToolStripMenuItem.Click += bajaTicketToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quienesSomosToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // quienesSomosToolStripMenuItem
            // 
            quienesSomosToolStripMenuItem.Name = "quienesSomosToolStripMenuItem";
            quienesSomosToolStripMenuItem.Size = new Size(165, 22);
            quienesSomosToolStripMenuItem.Text = "¿Quienes somos?";
            quienesSomosToolStripMenuItem.Click += quienesSomosToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(548, 394);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 1;
            label1.Text = "TPI Programación II";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cine1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(715, 426);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de Cine";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
    }
}