using System;
using System.Collections.Generic;

using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Triangularea_unui_poligon_monoton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int PT_RAD = 2;
        const int PT_WID = PT_RAD * 2 + 1;

        private List<PointF> m_Points = new List<PointF>();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the lines.
            if (m_Points.Count >= 3)
            {
                // Draw the polygon.
                e.Graphics.DrawPolygon(Pens.Blue, m_Points.ToArray());
            }
            else if (m_Points.Count == 2)
            {
                // Draw the line.
                e.Graphics.DrawLines(Pens.Blue, m_Points.ToArray());
            }

            // Draw the points.
            if (m_Points.Count > 0)
            {
                foreach (PointF pt in m_Points)
                {
                    e.Graphics.FillRectangle(Brushes.White, pt.X - PT_RAD, pt.Y - PT_RAD, PT_WID, PT_WID);
                    e.Graphics.DrawRectangle(Pens.Black, pt.X - PT_RAD, pt.Y - PT_RAD, PT_WID, PT_WID);
                }
            }


        }





        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            m_Points.Add(new PointF(e.X, e.Y));

            // Redraw.
            this.Invalidate();
        }



        private void partitionare_Click(object sender, EventArgs e)
        {
            // Make a Polygon.
            Polygon pgon = new Polygon(m_Points.ToArray());

            // Triangulate.
            List<Triangle> triangles = pgon.Triangulate();

            // Draw the triangles.
            using (Graphics gr = this.CreateGraphics())
            {
                foreach (Triangle tri in triangles)
                {
                    gr.DrawPolygon(Pens.Red, tri.Points);
                }

                // Redraw the polygon.
                if (m_Points.Count >= 3)
                {
                    // Draw the polygon.
                    gr.DrawPolygon(Pens.Blue, m_Points.ToArray());
                }
            }

        }

        private void sterge_Click(object sender, EventArgs e)
        {
            m_Points = new List<PointF>();

            this.Invalidate();
        }
    }
}
  
