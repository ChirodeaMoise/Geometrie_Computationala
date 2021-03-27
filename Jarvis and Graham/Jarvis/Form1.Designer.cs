namespace Jarvis
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		private void InitializeComponent()
		{
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnAddPoints = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 589);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(886, 102);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(192, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Sterge";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(886, 57);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(192, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Deseneaza";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnAddPoints
            // 
            this.BtnAddPoints.Location = new System.Drawing.Point(886, 144);
            this.BtnAddPoints.Name = "BtnAddPoints";
            this.BtnAddPoints.Size = new System.Drawing.Size(192, 23);
            this.BtnAddPoints.TabIndex = 3;
            this.BtnAddPoints.Text = "Adauga Puncte";
            this.BtnAddPoints.UseVisualStyleBackColor = true;
            this.BtnAddPoints.Click += new System.EventHandler(this.BtnAddPoints_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 611);
            this.Controls.Add(this.BtnAddPoints);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.Button BtnAddPoints;
    }
}
