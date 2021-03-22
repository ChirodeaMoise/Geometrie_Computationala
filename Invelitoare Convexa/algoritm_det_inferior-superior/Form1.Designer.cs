namespace algoritm_det_inferior_superior
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deseneazaBT = new System.Windows.Forms.Button();
            this.nrPuncte = new System.Windows.Forms.TextBox();
            this.superiorBT = new System.Windows.Forms.Button();
            this.inferiorBT = new System.Windows.Forms.Button();
            this.nrPuncteLB = new System.Windows.Forms.Label();
            this.stergeBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 356);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // deseneazaBT
            // 
            this.deseneazaBT.Location = new System.Drawing.Point(384, 62);
            this.deseneazaBT.Name = "deseneazaBT";
            this.deseneazaBT.Size = new System.Drawing.Size(74, 23);
            this.deseneazaBT.TabIndex = 1;
            this.deseneazaBT.Text = "Deseneaza";
            this.deseneazaBT.UseVisualStyleBackColor = true;
            this.deseneazaBT.Click += new System.EventHandler(this.deseneazaBT_Click);
            // 
            // nrPuncte
            // 
            this.nrPuncte.Location = new System.Drawing.Point(384, 36);
            this.nrPuncte.Name = "nrPuncte";
            this.nrPuncte.Size = new System.Drawing.Size(74, 20);
            this.nrPuncte.TabIndex = 2;
            // 
            // superiorBT
            // 
            this.superiorBT.Location = new System.Drawing.Point(384, 91);
            this.superiorBT.Name = "superiorBT";
            this.superiorBT.Size = new System.Drawing.Size(75, 23);
            this.superiorBT.TabIndex = 4;
            this.superiorBT.Text = "Superior";
            this.superiorBT.UseVisualStyleBackColor = true;
            this.superiorBT.Click += new System.EventHandler(this.superiorBT_Click);
            // 
            // inferiorBT
            // 
            this.inferiorBT.Location = new System.Drawing.Point(384, 120);
            this.inferiorBT.Name = "inferiorBT";
            this.inferiorBT.Size = new System.Drawing.Size(75, 23);
            this.inferiorBT.TabIndex = 6;
            this.inferiorBT.Text = "Inferior";
            this.inferiorBT.UseVisualStyleBackColor = true;
            this.inferiorBT.Click += new System.EventHandler(this.inferiorBT_Click);
            // 
            // nrPuncteLB
            // 
            this.nrPuncteLB.AutoSize = true;
            this.nrPuncteLB.Location = new System.Drawing.Point(392, 11);
            this.nrPuncteLB.Name = "nrPuncteLB";
            this.nrPuncteLB.Size = new System.Drawing.Size(55, 13);
            this.nrPuncteLB.TabIndex = 7;
            this.nrPuncteLB.Text = "Nr.Puncte";
            // 
            // stergeBT
            // 
            this.stergeBT.Location = new System.Drawing.Point(384, 172);
            this.stergeBT.Name = "stergeBT";
            this.stergeBT.Size = new System.Drawing.Size(74, 51);
            this.stergeBT.TabIndex = 8;
            this.stergeBT.Text = "Sterge";
            this.stergeBT.UseVisualStyleBackColor = true;
            this.stergeBT.Click += new System.EventHandler(this.stergeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 382);
            this.Controls.Add(this.stergeBT);
            this.Controls.Add(this.nrPuncteLB);
            this.Controls.Add(this.inferiorBT);
            this.Controls.Add(this.superiorBT);
            this.Controls.Add(this.nrPuncte);
            this.Controls.Add(this.deseneazaBT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deseneazaBT;
        private System.Windows.Forms.TextBox nrPuncte;
        private System.Windows.Forms.Button superiorBT;
        private System.Windows.Forms.Button inferiorBT;
        private System.Windows.Forms.Label nrPuncteLB;
        private System.Windows.Forms.Button stergeBT;
    }
}