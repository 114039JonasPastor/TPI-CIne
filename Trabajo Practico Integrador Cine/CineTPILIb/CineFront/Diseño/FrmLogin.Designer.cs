namespace CineFront.Diseño
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            chkContraseña = new CheckBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 23);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(264, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(12, 52);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(264, 23);
            txtContraseña.TabIndex = 1;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(201, 92);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(75, 23);
            btnAcceder.TabIndex = 2;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // chkContraseña
            // 
            chkContraseña.AutoSize = true;
            chkContraseña.Location = new Point(12, 92);
            chkContraseña.Name = "chkContraseña";
            chkContraseña.Size = new Size(142, 19);
            chkContraseña.TabIndex = 3;
            chkContraseña.Text = "Mostrar tu contraseña";
            chkContraseña.UseVisualStyleBackColor = true;
            chkContraseña.CheckedChanged += chkContraseña_CheckedChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(112, 119);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 154);
            Controls.Add(btnSalir);
            Controls.Add(chkContraseña);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAcceder;
        private CheckBox chkContraseña;
        private Button btnSalir;
    }
}