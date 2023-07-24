
namespace ProyectoSoporte2023.Grafica
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.panlateral = new System.Windows.Forms.GroupBox();
            this.sbayuda = new System.Windows.Forms.Panel();
            this.btncontacto = new System.Windows.Forms.Button();
            this.btnayuda = new System.Windows.Forms.Button();
            this.sbparticipante = new System.Windows.Forms.Panel();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnparticipante = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBottom.SuspendLayout();
            this.panlateral.SuspendLayout();
            this.sbayuda.SuspendLayout();
            this.sbparticipante.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelBottom.Controls.Add(this.lblcopyright);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 433);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(800, 20);
            this.PanelBottom.TabIndex = 5;
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Location = new System.Drawing.Point(3, 0);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(61, 13);
            this.lblcopyright.TabIndex = 11;
            this.lblcopyright.Text = "Groupaul ®";
            // 
            // panlateral
            // 
            this.panlateral.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panlateral.Controls.Add(this.sbayuda);
            this.panlateral.Controls.Add(this.btnayuda);
            this.panlateral.Controls.Add(this.sbparticipante);
            this.panlateral.Controls.Add(this.btnparticipante);
            this.panlateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panlateral.Location = new System.Drawing.Point(0, 0);
            this.panlateral.Name = "panlateral";
            this.panlateral.Size = new System.Drawing.Size(167, 433);
            this.panlateral.TabIndex = 5;
            this.panlateral.TabStop = false;
            // 
            // sbayuda
            // 
            this.sbayuda.Controls.Add(this.btncontacto);
            this.sbayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbayuda.Location = new System.Drawing.Point(3, 156);
            this.sbayuda.Name = "sbayuda";
            this.sbayuda.Size = new System.Drawing.Size(161, 23);
            this.sbayuda.TabIndex = 4;
            // 
            // btncontacto
            // 
            this.btncontacto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncontacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncontacto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncontacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontacto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncontacto.Location = new System.Drawing.Point(0, 0);
            this.btncontacto.Name = "btncontacto";
            this.btncontacto.Size = new System.Drawing.Size(161, 22);
            this.btncontacto.TabIndex = 5;
            this.btncontacto.Text = "Contacto";
            this.btncontacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncontacto.UseVisualStyleBackColor = false;
            this.btncontacto.Click += new System.EventHandler(this.btncontacto_Click);
            // 
            // btnayuda
            // 
            this.btnayuda.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnayuda.Location = new System.Drawing.Point(3, 114);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(161, 42);
            this.btnayuda.TabIndex = 3;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = false;
            this.btnayuda.Click += new System.EventHandler(this.btnayuda_Click);
            // 
            // sbparticipante
            // 
            this.sbparticipante.Controls.Add(this.btnCategorias);
            this.sbparticipante.Controls.Add(this.btningresar);
            this.sbparticipante.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbparticipante.Location = new System.Drawing.Point(3, 59);
            this.sbparticipante.Name = "sbparticipante";
            this.sbparticipante.Size = new System.Drawing.Size(161, 55);
            this.sbparticipante.TabIndex = 1;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategorias.Location = new System.Drawing.Point(0, 24);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(161, 24);
            this.btnCategorias.TabIndex = 5;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnPuntaje_Click);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btningresar.Location = new System.Drawing.Point(0, 0);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(161, 24);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnparticipante
            // 
            this.btnparticipante.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnparticipante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnparticipante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnparticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparticipante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnparticipante.Location = new System.Drawing.Point(3, 16);
            this.btnparticipante.Name = "btnparticipante";
            this.btnparticipante.Size = new System.Drawing.Size(161, 43);
            this.btnparticipante.TabIndex = 0;
            this.btnparticipante.Text = "Participante";
            this.btnparticipante.UseVisualStyleBackColor = false;
            this.btnparticipante.Click += new System.EventHandler(this.btnparticipante_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Location = new System.Drawing.Point(164, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(636, 430);
            this.panelContenedor.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoSoporte2023.Properties.Resources.Logo_Cuk;
            this.pictureBox1.Location = new System.Drawing.Point(243, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panlateral);
            this.Controls.Add(this.PanelBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.panlateral.ResumeLayout(false);
            this.sbayuda.ResumeLayout(false);
            this.sbparticipante.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel PanelBottom;
        private System.Windows.Forms.Label lblcopyright;
        private System.Windows.Forms.GroupBox panlateral;
        private System.Windows.Forms.Panel sbparticipante;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnparticipante;
        private System.Windows.Forms.Panel sbayuda;
        private System.Windows.Forms.Button btncontacto;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCategorias;
    }
}