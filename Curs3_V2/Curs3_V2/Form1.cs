using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linii_triunghi
{
    public partial class Form1 : Form
    {
        PointF[] t = new PointF[3];


        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp);
            PointF[] t = new PointF[3];
            Pen p = new Pen(Color.Black, 5);

            t[0].X = float.Parse(xa.Text);
            t[0].Y = float.Parse(ya.Text);
            t[1].X = float.Parse(xb.Text);
            t[1].Y = float.Parse(yb.Text);
            t[2].X = float.Parse(xc.Text);
            t[2].Y = float.Parse(yc.Text);


            float mab = (t[1].Y - t[0].Y) / (t[1].X - t[0].X);
            float mac = (t[2].Y - t[0].Y) / (t[2].X - t[0].X);
            float mbc = (t[2].Y - t[1].Y) / (t[2].X - t[1].X);
            float xmab = (t[0].X + t[1].X) / 2;
            float ymab = (t[0].Y + t[1].Y) / 2;
            float xmac = (t[0].X + t[2].X) / 2;
            float ymac = (t[0].Y + t[2].Y) / 2;
            float xmbc = (t[2].X + t[1].X) / 2;
            float ymbc = (t[2].Y + t[1].Y) / 2;
            Pen m = new Pen(Color.Red, 5);
            Pen md = new Pen(Color.Green, 5);
            Pen b = new Pen(Color.Yellow, 5);
            Pen i = new Pen(Color.Orange, 5);
            grp.DrawPolygon(p, t);

            pB.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.Black, 5);
            PointF[] t = new PointF[3];
            t[0].X = float.Parse(xa.Text);
            t[0].Y = float.Parse(ya.Text);
            t[1].X = float.Parse(xb.Text);
            t[1].Y = float.Parse(yb.Text);
            t[2].X = float.Parse(xc.Text);
            t[2].Y = float.Parse(yc.Text);


            float mab = (t[1].Y - t[0].Y) / (t[1].X - t[0].X);
            float mac = (t[2].Y - t[0].Y) / (t[2].X - t[0].X);
            float mbc = (t[2].Y - t[1].Y) / (t[2].X - t[1].X);
            float xmab = (t[0].X + t[1].X) / 2;
            float ymab = (t[0].Y + t[1].Y) / 2;
            float xmac = (t[0].X + t[2].X) / 2;
            float ymac = (t[0].Y + t[2].Y) / 2;
            float xmbc = (t[2].X + t[1].X) / 2;
            float ymbc = (t[2].Y + t[1].Y) / 2;
            Pen m = new Pen(Color.Red, 5);
            Pen md = new Pen(Color.Green, 5);
            Pen b = new Pen(Color.Yellow, 5);
            Pen i = new Pen(Color.Orange, 5);
            grp.DrawPolygon(p, t);
            grp.DrawLine(m, t[0].X, t[0].Y, (t[1].X + t[2].X) / 2, (t[1].Y + t[2].Y) / 2);
            grp.DrawLine(m, t[1].X, t[1].Y, (t[0].X + t[2].X) / 2, (t[0].Y + t[2].Y) / 2);
            grp.DrawLine(m, t[2].X, t[2].Y, (t[1].X + t[0].X) / 2, (t[1].Y + t[0].Y) / 2);
            grp.DrawEllipse(p, (t[0].X + t[1].X + t[2].X) / 3, (t[0].Y + t[1].Y + t[2].Y) / 3, 5, 5);
            grp.DrawPolygon(p, t);
            pB.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp); Random r = new Random();
            Pen p = new Pen(Color.Black, 5);
            PointF[] t = new PointF[3];
            t[0].X = float.Parse(xa.Text);
            t[0].Y = float.Parse(ya.Text);
            t[1].X = float.Parse(xb.Text);
            t[1].Y = float.Parse(yb.Text);
            t[2].X = float.Parse(xc.Text);
            t[2].Y = float.Parse(yc.Text);

            float ab = (float)Math.Sqrt((t[1].X - t[0].X) * (t[1].X - t[0].X) + (t[1].Y - t[0].Y) * (t[1].Y - t[0].Y));
            float ac = (float)Math.Sqrt((t[2].X - t[0].X) * (t[2].X - t[0].X) + (t[2].Y - t[0].Y) * (t[2].Y - t[0].Y));
            float bc = (float)Math.Sqrt((t[1].X - t[2].X) * (t[1].X - t[2].X) + (t[1].Y - t[2].Y) * (t[1].Y - t[2].Y));
            float mab = (t[1].Y - t[0].Y) / (t[1].X - t[0].X);
            float mac = (t[2].Y - t[0].Y) / (t[2].X - t[0].X);
            float mbc = (t[2].Y - t[1].Y) / (t[2].X - t[1].X);
            float xmab = (t[0].X + t[1].X) / 2;
            float ymab = (t[0].Y + t[1].Y) / 2;
            float xmac = (t[0].X + t[2].X) / 2;
            float ymac = (t[0].Y + t[2].Y) / 2;
            float xmbc = (t[2].X + t[1].X) / 2;
            float ymbc = (t[2].Y + t[1].Y) / 2;
            Pen m = new Pen(Color.Red, 5);
            Pen md = new Pen(Color.Green, 5);
            Pen b = new Pen(Color.Yellow, 5);
            Pen i = new Pen(Color.Orange, 5);
            grp.DrawPolygon(p, t);
            grp.DrawLine(md, (bc * t[0].X + ac * t[1].X + ab * t[2].X) / (ab + ac + bc), (bc * t[0].Y + ac * t[1].Y + ab * t[2].Y) / (ab + ac + bc), xmab, ymab);
            grp.DrawLine(md, (bc * t[0].X + ac * t[1].X + ab * t[2].X) / (ab + ac + bc), (bc * t[0].Y + ac * t[1].Y + ab * t[2].Y) / (ab + ac + bc), xmac, ymac);
            grp.DrawLine(md, (bc * t[0].X + ac * t[1].X + ab * t[2].X) / (ab + ac + bc), (bc * t[0].Y + ac * t[1].Y + ab * t[2].Y) / (ab + ac + bc), xmbc, ymbc);
            grp.DrawEllipse(p, (bc * t[0].X + ac * t[1].X + ab * t[2].X) / (ab + ac + bc), (bc * t[0].Y + ac * t[1].Y + ab * t[2].Y) / (ab + ac + bc), 5, 5);
            grp.DrawPolygon(p, t);
            pB.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pB.Update();
            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.Black, 5);
            PointF[] t = new PointF[3];
            t[0].X = float.Parse(xa.Text);
            t[0].Y = float.Parse(ya.Text);
            t[1].X = float.Parse(xb.Text);
            t[1].Y = float.Parse(yb.Text);
            t[2].X = float.Parse(xc.Text);
            t[2].Y = float.Parse(yc.Text);
            float mab = (t[1].Y - t[0].Y) / (t[1].X - t[0].X);
            float mac = (t[2].Y - t[0].Y) / (t[2].X - t[0].X);
            float mbc = (t[2].Y - t[1].Y) / (t[2].X - t[1].X);
            float xmab = (t[0].X + t[1].X) / 2;
            float ymab = (t[0].Y + t[1].Y) / 2;
            float xmac = (t[0].X + t[2].X) / 2;
            float ymac = (t[0].Y + t[2].Y) / 2;
            float xmbc = (t[2].X + t[1].X) / 2;
            float ymbc = (t[2].Y + t[1].Y) / 2;
            Pen m = new Pen(Color.Red, 5);
            Pen md = new Pen(Color.Green, 5);
            Pen b = new Pen(Color.Yellow, 5);
            Pen i = new Pen(Color.Orange, 5);
            grp.DrawPolygon(p, t);
            grp.DrawLine(i, t[0].X, t[0].Y, (mbc * t[1].X - t[1].Y + t[0].Y + (1 / mbc) * t[0].X) / (mbc + (1 / mbc)), mbc * ((mbc * t[1].X - t[1].Y + t[0].Y + (1 / mbc) * t[0].X) / (mbc + (1 / mbc)) - t[1].X) + t[1].Y);
            grp.DrawLine(i, t[1].X, t[1].Y, (mac * t[2].X - t[2].Y + t[1].Y + (1 / mac) * t[1].X) / (mac + (1 / mac)), mac * ((mac * t[2].X - t[2].Y + t[1].Y + (1 / mac) * t[1].X) / (mac + (1 / mac)) - t[2].X) + t[2].Y);
            grp.DrawLine(i, t[2].X, t[2].Y, (mab * t[0].X - t[0].Y + t[2].Y + (1 / mab) * t[2].X) / (mab + (1 / mab)), mab * ((mab * t[0].X - t[0].Y + t[2].Y + (1 / mab) * t[2].X) / (mab + (1 / mab)) - t[0].X) + t[0].Y);
            grp.DrawPolygon(p, t);

            pB.Image = bmp;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pB.Update();
            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp); Random r = new Random();
            Pen p = new Pen(Color.Black, 5);
            PointF[] t = new PointF[3];
            t[0].X = float.Parse(xa.Text);
            t[0].Y = float.Parse(ya.Text);
            t[1].X = float.Parse(xb.Text);
            t[1].Y = float.Parse(yb.Text);
            t[2].X = float.Parse(xc.Text);
            t[2].Y = float.Parse(yc.Text);
            float mab = (t[1].Y - t[0].Y) / (t[1].X - t[0].X);
            float mac = (t[2].Y - t[0].Y) / (t[2].X - t[0].X);
            float mbc = (t[2].Y - t[1].Y) / (t[2].X - t[1].X);
            float xmab = (t[0].X + t[1].X) / 2;
            float ymab = (t[0].Y + t[1].Y) / 2;
            float xmac = (t[0].X + t[2].X) / 2;
            float ymac = (t[0].Y + t[2].Y) / 2;
            float xmbc = (t[2].X + t[1].X) / 2;
            float ymbc = (t[2].Y + t[1].Y) / 2;
            Pen m = new Pen(Color.Red, 5);
            Pen md = new Pen(Color.Green, 5);
            Pen b = new Pen(Color.Purple, 5);
            Pen i = new Pen(Color.Orange, 5);
            grp.DrawPolygon(p, t);
            grp.DrawLine(b, t[0].X, t[0].Y, xmbc + 10, ymbc + 10);
            grp.DrawLine(b, t[1].X, t[1].Y, xmac + 10, ymac + 10);
            grp.DrawLine(b, t[2].X, t[2].Y, xmab + 10, ymab + 10);
            grp.DrawPolygon(p, t);
            pB.Image = bmp;
        }
    }
}
