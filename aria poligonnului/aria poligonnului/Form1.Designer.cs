namespace aria_poligonnului
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
            this.aria = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.triangularea = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.aria2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 532);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aria
            // 
            this.aria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aria.Location = new System.Drawing.Point(12, 19);
            this.aria.Name = "aria";
            this.aria.Size = new System.Drawing.Size(199, 37);
            this.aria.TabIndex = 1;
            this.aria.Text = "Aria";
            this.aria.UseVisualStyleBackColor = true;
            this.aria.Click += new System.EventHandler(this.aria_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 23);
            this.textBox1.TabIndex = 2;
            // 
            // triangularea
            // 
            this.triangularea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangularea.Location = new System.Drawing.Point(558, 19);
            this.triangularea.Name = "triangularea";
            this.triangularea.Size = new System.Drawing.Size(246, 37);
            this.triangularea.TabIndex = 6;
            this.triangularea.Text = "Triangularea";
            this.triangularea.UseVisualStyleBackColor = true;
            this.triangularea.Click += new System.EventHandler(this.triangularea_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 85);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 23);
            this.textBox2.TabIndex = 7;
            // 
            // aria2
            // 
            this.aria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aria2.Location = new System.Drawing.Point(12, 74);
            this.aria2.Name = "aria2";
            this.aria2.Size = new System.Drawing.Size(199, 37);
            this.aria2.TabIndex = 8;
            this.aria2.Text = "Aria 2";
            this.aria2.UseVisualStyleBackColor = true;
            this.aria2.Click += new System.EventHandler(this.aria2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 649);
            this.Controls.Add(this.aria2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.triangularea);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aria);
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
        private System.Windows.Forms.Button aria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button triangularea;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button aria2;
    }
}

