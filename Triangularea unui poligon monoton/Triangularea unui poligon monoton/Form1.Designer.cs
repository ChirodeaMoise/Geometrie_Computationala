namespace Triangularea_unui_poligon_monoton
{
    partial class Form1
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
           
            this.partitionare = new System.Windows.Forms.Button();
            this.sterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
          
            // 
            // partitionare
            // 
            this.partitionare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partitionare.Location = new System.Drawing.Point(12, 325);
            this.partitionare.Name = "partitionare";
            this.partitionare.Size = new System.Drawing.Size(143, 77);
            this.partitionare.TabIndex = 1;
            this.partitionare.Text = "Partitionare";
            this.partitionare.UseVisualStyleBackColor = true;
            this.partitionare.Click += new System.EventHandler(this.partitionare_Click);
            // 
            // sterge
            // 
            this.sterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sterge.Location = new System.Drawing.Point(421, 325);
            this.sterge.Name = "sterge";
            this.sterge.Size = new System.Drawing.Size(143, 77);
            this.sterge.TabIndex = 2;
            this.sterge.Text = "Sterge";
            this.sterge.UseVisualStyleBackColor = true;
            this.sterge.Click += new System.EventHandler(this.sterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 414);
            this.Controls.Add(this.sterge);
            this.Controls.Add(this.partitionare);
           
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button partitionare;
        private System.Windows.Forms.Button sterge;
    }
}

