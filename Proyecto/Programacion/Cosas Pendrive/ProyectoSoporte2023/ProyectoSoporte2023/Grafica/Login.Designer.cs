
namespace ProyectoSoporte2023
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnCalEventos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelBottom.Controls.Add(this.lblcopyright);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 427);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(804, 24);
            this.PanelBottom.TabIndex = 1;
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Location = new System.Drawing.Point(3, 0);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(61, 13);
            this.lblcopyright.TabIndex = 11;
            this.lblcopyright.Text = "Groupaul ®";
            this.lblcopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(275, 354);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbluser
            // 
            this.lbluser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.lbluser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbluser.Location = new System.Drawing.Point(271, 217);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(71, 20);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "Usuario";
            // 
            // tbuser
            // 
            this.tbuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbuser.Location = new System.Drawing.Point(275, 240);
            this.tbuser.Name = "tbuser";
            this.tbuser.ShortcutsEnabled = false;
            this.tbuser.Size = new System.Drawing.Size(270, 20);
            this.tbuser.TabIndex = 1;
            // 
            // tbpassword
            // 
            this.tbpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbpassword.Location = new System.Drawing.Point(275, 302);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.ShortcutsEnabled = false;
            this.tbpassword.Size = new System.Drawing.Size(270, 20);
            this.tbpassword.TabIndex = 2;
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpassword.Location = new System.Drawing.Point(271, 279);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(102, 20);
            this.lblpassword.TabIndex = 8;
            this.lblpassword.Text = "Contraseña";
            // 
            // btnCalEventos
            // 
            this.btnCalEventos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCalEventos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalEventos.Location = new System.Drawing.Point(664, 12);
            this.btnCalEventos.Name = "btnCalEventos";
            this.btnCalEventos.Size = new System.Drawing.Size(128, 29);
            this.btnCalEventos.TabIndex = 11;
            this.btnCalEventos.Text = "Calendario Eventos";
            this.btnCalEventos.UseVisualStyleBackColor = false;
            this.btnCalEventos.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::ProyectoSoporte2023.Properties.Resources.Logo_Cuk;
            this.pictureBox3.Location = new System.Drawing.Point(335, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCalEventos);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.PanelBottom);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel PanelBottom;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblcopyright;
        private System.Windows.Forms.Button btnCalEventos;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

