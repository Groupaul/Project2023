
namespace ProyectoSoporte2023.Grafica.SubMenu
{
    partial class Categorias
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn1415 = new System.Windows.Forms.Button();
			this.btn1617 = new System.Windows.Forms.Button();
			this.btn18 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Categorias";
			// 
			// btn1415
			// 
			this.btn1415.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn1415.ForeColor = System.Drawing.SystemColors.Control;
			this.btn1415.Location = new System.Drawing.Point(139, 93);
			this.btn1415.Name = "btn1415";
			this.btn1415.Size = new System.Drawing.Size(148, 46);
			this.btn1415.TabIndex = 1;
			this.btn1415.Text = "14 a 15";
			this.btn1415.UseVisualStyleBackColor = false;
			this.btn1415.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn1617
			// 
			this.btn1617.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn1617.ForeColor = System.Drawing.SystemColors.Control;
			this.btn1617.Location = new System.Drawing.Point(139, 145);
			this.btn1617.Name = "btn1617";
			this.btn1617.Size = new System.Drawing.Size(148, 45);
			this.btn1617.TabIndex = 2;
			this.btn1617.Text = "16 a 17";
			this.btn1617.UseVisualStyleBackColor = false;
			this.btn1617.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn18
			// 
			this.btn18.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn18.ForeColor = System.Drawing.SystemColors.Control;
			this.btn18.Location = new System.Drawing.Point(139, 194);
			this.btn18.Name = "btn18";
			this.btn18.Size = new System.Drawing.Size(148, 46);
			this.btn18.TabIndex = 3;
			this.btn18.Text = "18 en adelante";
			this.btn18.UseVisualStyleBackColor = false;
			this.btn18.Click += new System.EventHandler(this.button3_Click);
			// 
			// Categorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn18);
			this.Controls.Add(this.btn1617);
			this.Controls.Add(this.btn1415);
			this.Controls.Add(this.label1);
			this.Name = "Categorias";
			this.Text = "Categorias";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1415;
        private System.Windows.Forms.Button btn1617;
        private System.Windows.Forms.Button btn18;
    }
}