
namespace ProyectoSoporte2023.Grafica.SubMenu
{
    partial class panelPuntajes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nupdownPuntaje = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownPuntaje)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // nupdownPuntaje
            // 
            this.nupdownPuntaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupdownPuntaje.DecimalPlaces = 1;
            this.nupdownPuntaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupdownPuntaje.Location = new System.Drawing.Point(289, 221);
            this.nupdownPuntaje.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupdownPuntaje.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdownPuntaje.Name = "nupdownPuntaje";
            this.nupdownPuntaje.ReadOnly = true;
            this.nupdownPuntaje.Size = new System.Drawing.Size(199, 20);
            this.nupdownPuntaje.TabIndex = 3;
            this.nupdownPuntaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupdownPuntaje.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puntaje";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelPuntajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupdownPuntaje);
            this.Controls.Add(this.dataGridView1);
            this.Name = "panelPuntajes";
            this.Text = "Puntajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownPuntaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nupdownPuntaje;
        private System.Windows.Forms.Label label1;
    }
}