using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatratRotit
{
    public partial class Form1 : Form
    {
        double i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp);
            PointF[] t = new PointF[4];

            t[0].X = float.Parse(xa.Text);
            t[0].Y = float.Parse(ya.Text);
            t[1].X = float.Parse(xb.Text);
            t[1].Y = float.Parse(yb.Text);
            t[2].X = float.Parse(xc.Text);
            t[2].Y = float.Parse(yc.Text);
            t[3].X = float.Parse(xd.Text);
            t[3].Y = float.Parse(yd.Text);

            Pen p = new Pen(Color.Green, 5);
            SolidBrush sb = new SolidBrush(Color.LightGray);
            grp.FillPolygon(sb, t);
            grp.DrawPolygon(p, t);
            pB.Image = bmp;
        }

        private void Rotire_Click(object sender, EventArgs e)
        {
            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp);
            PointF[] t = new PointF[4]; 
            t[0].X = float.Parse(xa.Text);
            t[0].Y = float.Parse(ya.Text);
            t[1].X = float.Parse(xb.Text);
            t[1].Y = float.Parse(yb.Text);
            t[2].X = float.Parse(xc.Text);
            t[2].Y = float.Parse(yc.Text);
            t[3].X = float.Parse(xd.Text);
            t[3].Y = float.Parse(yd.Text);
            double xm = (t[0].X + t[2].X) / 2;
            double ym = (t[0].Y + t[2].Y) / 2;
            double x1 = xm + ((t[0].X - xm) * Math.Cos(10 * i)) - ((t[0].Y - ym) * Math.Sin(10 * i));
            double y1 = ym + ((t[0].X - xm) * Math.Sin(10 * i)) + ((t[0].Y - ym) * Math.Cos(10 * i));
            double x2 = xm + ((t[1].X - xm) * Math.Cos(10 * i)) - ((t[1].Y - ym) * Math.Sin(10 * i));
            double y2 = ym + ((t[1].X - xm) * Math.Sin(10 * i)) + ((t[1].Y - ym) * Math.Cos(10 * i));
            double x3 = xm + ((t[2].X - xm) * Math.Cos(10 * i)) - ((t[2].Y - ym) * Math.Sin(10 * i));
            double y3 = ym + ((t[2].X - xm) * Math.Sin(10 * i)) + ((t[2].Y - ym) * Math.Cos(10 * i));
            double x4 = xm + ((t[3].X - xm) * Math.Cos(10 * i)) - ((t[3].Y - ym) * Math.Sin(10 * i));
            double y4 = ym + ((t[3].X - xm) * Math.Sin(10 * i)) + ((t[3].Y - ym) * Math.Cos(10 * i));
            t[0].X = (float)x1;
            t[0].Y = (float)y1;
            t[1].X = (float)x2;
            t[1].Y = (float)y2;
            t[2].X = (float)x3;
            t[2].Y = (float)y3;
            t[3].X = (float)x4;
            t[3].Y = (float)y4;
            i++;
            Pen p = new Pen(Color.Green, 5);
            SolidBrush sb = new SolidBrush(Color.LightGray);
            grp.DrawPolygon(p, t);
            grp.FillPolygon(sb, t);

            pB.Image = bmp;
        }

        private void xa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
