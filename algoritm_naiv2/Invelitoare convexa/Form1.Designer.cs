
namespace Invelitoare_convexa
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
            this.incercuireBT = new System.Windows.Forms.Button();
            this.stergeBT = new System.Windows.Forms.Button();
            this.nrPuncteLB = new System.Windows.Forms.Label();
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
            this.deseneazaBT.Location = new System.Drawing.Point(384, 67);
            this.deseneazaBT.Name = "deseneazaBT";
            this.deseneazaBT.Size = new System.Drawing.Size(74, 23);
            this.deseneazaBT.TabIndex = 1;
            this.deseneazaBT.Text = "Deseneaza";
            this.deseneazaBT.UseVisualStyleBackColor = true;
            this.deseneazaBT.Click += new System.EventHandler(this.deseneazaBT_Click);
            // 
            // nrPuncte
            // 
            this.nrPuncte.Location = new System.Drawing.Point(384, 41);
            this.nrPuncte.Name = "nrPuncte";
            this.nrPuncte.Size = new System.Drawing.Size(74, 20);
            this.nrPuncte.TabIndex = 2;
            // 
            // incercuireBT
            // 
            this.incercuireBT.Location = new System.Drawing.Point(384, 97);
            this.incercuireBT.Name = "incercuireBT";
            this.incercuireBT.Size = new System.Drawing.Size(75, 23);
            this.incercuireBT.TabIndex = 3;
            this.incercuireBT.Text = "Incercuire";
            this.incercuireBT.UseVisualStyleBackColor = true;
            this.incercuireBT.Click += new System.EventHandler(this.incercuireBT_Click);
            // 
            // stergeBT
            // 
            this.stergeBT.Location = new System.Drawing.Point(384, 136);
            this.stergeBT.Name = "stergeBT";
            this.stergeBT.Size = new System.Drawing.Size(76, 51);
            this.stergeBT.TabIndex = 4;
            this.stergeBT.Text = "Sterge";
            this.stergeBT.UseVisualStyleBackColor = true;
            this.stergeBT.Click += new System.EventHandler(this.stergeBT_Click);
            // 
            // nrPuncteLB
            // 
            this.nrPuncteLB.AutoSize = true;
            this.nrPuncteLB.Location = new System.Drawing.Point(394, 14);
            this.nrPuncteLB.Name = "nrPuncteLB";
            this.nrPuncteLB.Size = new System.Drawing.Size(55, 13);
            this.nrPuncteLB.TabIndex = 5;
            this.nrPuncteLB.Text = "Nr.Puncte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 382);
            this.Controls.Add(this.nrPuncteLB);
            this.Controls.Add(this.stergeBT);
            this.Controls.Add(this.incercuireBT);
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
        private System.Windows.Forms.Button incercuireBT;
        private System.Windows.Forms.Button stergeBT;
        private System.Windows.Forms.Label nrPuncteLB;
    }
}
