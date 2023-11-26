namespace CineFront.Diseño
{
    partial class FrmAcercaDe
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnVolver = new Button();
            lm = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 25.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 31);
            label1.Name = "label1";
            label1.Size = new Size(379, 41);
            label1.TabIndex = 0;
            label1.Text = "DEVELOPMENT TEAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(209, 112);
            label2.Name = "label2";
            label2.Size = new Size(153, 27);
            label2.TabIndex = 1;
            label2.Text = "Alexis Chaname";
            lm.SetToolTip(label2, "LinkedIn");
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(195, 422);
            label3.Name = "label3";
            label3.Size = new Size(181, 27);
            label3.TabIndex = 2;
            label3.Text = "Luciano Rodriguez";
            lm.SetToolTip(label3, "GitHub");
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(168, 298);
            label4.Name = "label4";
            label4.Size = new Size(234, 27);
            label4.TabIndex = 3;
            label4.Text = "Leandro Gómez Aparicio";
            lm.SetToolTip(label4, "LinkedIn");
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(222, 236);
            label5.Name = "label5";
            label5.Size = new Size(126, 27);
            label5.TabIndex = 4;
            label5.Text = "Jonás Pastor";
            lm.SetToolTip(label5, "GitHub");
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(193, 360);
            label6.Name = "label6";
            label6.Size = new Size(185, 27);
            label6.TabIndex = 5;
            label6.Text = "Luciano Manzanelli";
            lm.SetToolTip(label6, "LinkedIn");
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(194, 174);
            label7.Name = "label7";
            label7.Size = new Size(183, 27);
            label7.TabIndex = 6;
            label7.Text = "Franco Domínguez";
            lm.SetToolTip(label7, "LinkedIn");
            label7.Click += label7_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Control;
            btnVolver.ForeColor = SystemColors.ControlText;
            btnVolver.Location = new Point(244, 475);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 30);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.acerca;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(581, 535);
            Controls.Add(btnVolver);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAcercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipo de desarrollo";
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
        private Button btnVolver;
        private ToolTip lm;
    }
}