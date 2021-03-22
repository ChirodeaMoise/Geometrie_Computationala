using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace algoritm_det_inferior_superior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random r;
        Bitmap bitmap;
        Graphics graphics;

        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();
            bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height, PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(bitmap);
            this.pictureBox1.Image = bitmap;

           
        }


        private List<Point> pointList = new List<Point>();

        private void stergeBT_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            pictureBox1.Image = bitmap;
        }
        private void deseneazaBT_Click(object sender, EventArgs e)
        {
            var w = new Point(172, 264);
            var x = new Point(70, 164);
            var y = new Point(172, 70);
            var z = new Point(279, 168);

            pointList.Add(w);
            pointList.Add(x);
            pointList.Add(y);
            pointList.Add(z);

            graphics.FillRectangle(new SolidBrush(Color.Red), w.X, w.Y, 6, 6);
            pointList.Add(w);
            graphics.FillRectangle(new SolidBrush(Color.Red), x.X, x.Y, 6, 6);
            pointList.Add(x);
            graphics.FillRectangle(new SolidBrush(Color.Red), y.X, y.Y, 6, 6);
            pointList.Add(y);
            graphics.FillRectangle(new SolidBrush(Color.Red), z.X, z.Y, 6, 6);
            pointList.Add(z);


            if (int.TryParse(nrPuncte.Text, out var k))
            {
                for (int i = 0; i < k; i++)
                {
 
                    var p = new Point(r.Next(120, 219), r.Next(120, 214));
                    pointList.Add(p);


                    graphics.FillRectangle(new SolidBrush(Color.Red), p.X, p.Y, 6, 6);

                    pointList.Add(p);

                }
                this.pictureBox1.Image = bitmap;

            }
            else
            {
                MessageBox.Show("Completati cu un numar.");
            }
        }

 
        private void superiorBT_Click(object sender, EventArgs e)
        {
          
            // Create pens.
            Pen greenPen = new Pen(Color.Green, 3);

            // Create points that define curve.
            Point[] points = {
                new Point(70, 164),
                new Point(172, 70),
                new Point(279, 168)};


            //
            // Draw curve to screen.
            graphics.DrawCurve(greenPen, points);
            
            this.pictureBox1.Image = bitmap;

        }

        private void inferiorBT_Click(object sender, EventArgs e)
        {       // Create pens.
            Pen greenPen = new Pen(Color.Purple, 3);

            // Create points that define curve.
            Point[] points = {
                new Point(70, 164),
                new Point(172, 264),
                new Point(279, 168)};


            //169, 288
            // Draw curve to screen.
            graphics.DrawCurve(greenPen, points);
            this.pictureBox1.Image = bitmap;

        }
        
    }
}