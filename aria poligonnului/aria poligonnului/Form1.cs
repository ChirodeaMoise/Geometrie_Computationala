using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aria_poligonnului
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.rezx = pictureBox1.Width;
            Engine.rezy = pictureBox1.Height;
            Engine.InitGraph(pictureBox1);
           // Engine.InitGraph(pictureBox1);
            Engine.RefreshGraph();
        }
        private void aria_Click(object sender, EventArgs e)
        {
            Engine.ClearGraph();
          
            Point[] points = new Point[7];
            points[0] = new Point(50, 0);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[0].X + 2, points[0].Y + 8);
            points[1] = new Point(100, 100);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[1].X - 5, points[1].Y - 15);
            points[2] = new Point(0, 350);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[2].X - 7, points[2].Y - 20);
            points[3] = new Point(200, 450);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[3].X - 5, points[3].Y - 15);
            points[4] = new Point(350, 350);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[4].X + 5, points[4].Y + 8);
            points[5] = new Point(550, 200);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[5].X, points[5].Y + 8);
            points[6] = new Point(400, 100);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[6].X, points[6].Y + 8);

            Engine.grp.DrawPolygon(new Pen(Engine.getRNDColor(), 3), points);

           
            textBox1.Text = ($"Aria poligonului este: {Area(points) }");
            Engine.RefreshGraph();

        }


        private void aria2_Click(object sender, EventArgs e)
        {
            Engine.ClearGraph();
            Point[] points = new Point[7];
            points[0] = new Point(40 ,40);
            Engine.grp.DrawString("P1", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[0].X + 2, points[0].Y + 8);
            points[1] = new Point(40,400);
            Engine.grp.DrawString("P2", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[1].X , points[1].Y );
            points[2] = new Point(50,60);
            Engine.grp.DrawString("P3", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[2].X + 6, points[2].Y - 20);
            points[3] = new Point(60,40);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[3].X - 5, points[3].Y - 15);
            points[4] = new Point(90,60);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[4].X + 170, points[4].Y - 150);
            points[5] = new Point(110,60);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[5].X  - 175, points[5].Y - 100);
            points[6] = new Point(300, 20);
            Engine.grp.DrawString("", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[6].X, points[6].Y + 8);

           
            /*points[7] = new Point(76 , 20 );
             Engine.grp.DrawString("P8", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[7].X, points[7].Y + 8);
            points[8] = new Point(80 , 40 );
             Engine.grp.DrawString("P9", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[8].X, points[8].Y + 8);
             points[9] = new Point(110 , 80 );
             Engine.grp.DrawString("P10", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[9].X, points[9].Y + 8);
             points[10] = new Point(130 , 60);
             Engine.grp.DrawString("P11", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[10].X, points[10].Y + 8);
             points[11] = new Point(-30 , 20 );
             Engine.grp.DrawString("P12", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[11].X, points[11].Y + 8);*/

            Engine.grp.DrawPolygon(new Pen(Engine.getRNDColor(), 3), points);



            textBox2.Text = ($"Aria poligonului este: {Area(points) }");
            Engine.RefreshGraph();
        }





        public static double Area(Point[] point)
        {
            int n = point.Count();
            double area = 0.0;
            int j = n - 1;
            for (int i = 0; i < n; i++)
            {
                area += (point[j].X + point[i].X) * (point[j].Y - point[i].Y);
                j = i;
            }
            return (Math.Abs(area / 2.0));
        }
       
        public bool PolygonIsMonotone(PointF[] Points)
        {

            bool got_negative = false;
            bool got_positive = false;
            int num_points = Points.Length;
            int B, C;
            for (int A = 0; A < num_points; A++)
            {
                B = (A + 1) % num_points;
                C = (B + 1) % num_points;

                float cross_product =
                    CrossProductLength(
                        Points[A].X, Points[A].Y,
                        Points[B].X, Points[B].Y,
                        Points[C].X, Points[C].Y);
                if (cross_product < 0)
                {
                    got_negative = true;
                }
                else if (cross_product > 0)
                {
                    got_positive = true;
                }
                if (got_negative && got_positive) return false;
            }


            return true;
        }
        public static float CrossProductLength(float Ax, float Ay, float Bx, float By, float Cx, float Cy)
        {

            float BAx = Ax - Bx;
            float BAy = Ay - By;
            float BCx = Cx - Bx;
            float BCy = Cy - By;


            return (BAx * BCy - BAy * BCx);
        }
        List<Point> pf = new List<Point>();
       
        private void Triunghiulare(List<Point> t)
        {
            if (t.Count <= 3)
                return;
            int i = 0;
            while (i < t.Count - 3 && !digvalid(t[i], t[i + 2], i))
                i++;
            Engine.grp.DrawLine(new Pen(Color.Aquamarine), t[i], t[i + 2]);
            t.Remove(t[i + 1]);
            Triunghiulare(t);
        }

        private int Orientare(Point A, Point B, Point C)
        {
            double temp = (B.Y - A.Y) * (C.X - A.X) - (C.Y - A.Y) * (B.X - A.X);
            if (temp == 0) return 0;
            return (temp > 0) ? 1 : 2;
        }

        bool SeIntersecteaza(Point p1, Point q1, Point p2, Point q2)
        {

            int o1 = Orientare(p1, q1, p2);
            int o2 = Orientare(p1, q1, q2);
            int o3 = Orientare(p2, q2, p1);
            int o4 = Orientare(p2, q2, q1);


            if (o1 != o2 && o3 != o4)
                return true;


            if (o1 == 0 && onSegment(p1, p2, q1)) return true;


            if (o2 == 0 && onSegment(p1, q2, q1)) return true;


            if (o3 == 0 && onSegment(p2, p1, q2)) return true;


            if (o4 == 0 && onSegment(p2, q1, q2)) return true;

            return false;
        }
        private bool digvalid(Point point1, Point point2, int index)
        {

            Point M = new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2);
            if (index == pf.Count - 1)
                index = 0;
            for (int i = 0; i < pf.Count - 1; i++)


            {

                if (SeIntersecteaza(point1, point2, pf[i], pf[i + 1]) && !isInside(pf, M))
                    return false;
            }


            return true;


        }
        #region In poligon
        bool onSegment(Point p, Point q, Point r)
        {
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                    q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                return true;
            return false;
        }
        bool isInside(List<Point> t, Point p)
        {
            if (t.Count < 3)
                return false;
            Point extreme = new Point(3000, p.Y);
            int count = 0, i = 0;
            do
            {
                int next = (i + 1) % t.Count;


                if (SeIntersecteaza(t[i], t[next], p, extreme))
                {

                    if (Orientare(t[i], p, t[next]) == 0)
                        return onSegment(t[i], p, t[next]);

                    count++;
                }
                i = next;
            } while (i != 0);

            return (count % 2 == 1);
        }

        #endregion

      

        private void triangularea_Click(object sender, EventArgs e)
        {
            Engine.ClearGraph();
            
       
          
             Point P1 = new Point();
            Point P2 = new Point(50 * 2, 10 * 2);
            Point P3 = new Point(80 * 2, 20 * 2);
            Point P4 = new Point(110 * 2, 65 * 2);
            Point P5 = new Point(100 * 2, 90 * 2);
            Point P6 = new Point(90 * 2, 70 * 2);
            Point P7 = new Point(60 * 2, 120 * 2);
            Point P8 = new Point(40 * 2, 110 * 2);
            Point P9 = new Point(30 * 2, 65 * 2);
            Point P10 = new Point(20 * 2, 110 * 2);

            Engine.grp.DrawEllipse(new Pen(Color.Black), P1.X - 1, P1.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P2.X - 1, P2.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P3.X - 1, P3.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P4.X - 1, P4.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P5.X - 1, P5.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P6.X - 1, P6.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P7.X - 1, P7.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P8.X - 1, P8.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P9.X - 1, P9.Y - 1, 3, 4);
            Engine.grp.DrawEllipse(new Pen(Color.Black), P10.X - 1, P10.Y - 1, 3, 4);
            Engine.grp.DrawString("P1", new Font("Tahoma", 10), Brushes.Black, P1.X - 20, P1.Y - 5);
            Engine.grp.DrawString("P2", new Font("Tahoma", 10), Brushes.Black, P2.X - 10, P2.Y - 20);
            Engine.grp.DrawString("P3", new Font("Tahoma", 10), Brushes.Black, P3.X + 1, P3.Y + 3);
            Engine.grp.DrawString("P4", new Font("Tahoma", 10), Brushes.Black, P4.X + 1, P4.Y + 3);

            Engine.grp.DrawString("P5", new Font("Tahoma", 10), Brushes.Black, P5.X + 1, P5.Y + 3);
            Engine.grp.DrawString("P6", new Font("Tahoma", 10), Brushes.Black, P6.X + 3, P6.Y + 7);
            Engine.grp.DrawString("P7", new Font("Tahoma", 10), Brushes.Black, P7.X + 1, P7.Y + 3);
            Engine.grp.DrawString("P8", new Font("Tahoma", 10), Brushes.Black, P8.X + 1, P8.Y + 3);

            Engine.grp.DrawString("P9", new Font("Tahoma", 10), Brushes.Black, P9.X + 1, P9.Y + 3);
            Engine.grp.DrawString("P10", new Font("Tahoma", 10), Brushes.Black, P10.X + 1, P10.Y + 3);



            Point[] points = new Point[10];
            points[0] = P1;
            points[1] = P2;
            points[2] = P3;
            points[3] = P4;
            points[4] = P5;
            points[5] = P6;
            points[6] = P7;
            points[7] = P8;
            points[8] = P9;
            points[9] = P10;

            for (int i = 0; i < points.Length; i++)
            {
                pf.Add(points[i]);
            }
            Triunghiulare(pf);

            Engine.grp.DrawPolygon(new Pen(Engine.getRNDColor(), 3), points);
            Engine.grp.DrawLine(new Pen(Color.Black), points[0], points[8]);
            Engine.grp.DrawLine(new Pen(Color.Black), points[1], points[8]);
            Engine.grp.DrawLine(new Pen(Color.Black), points[1], points[5]);
            Engine.grp.DrawLine(new Pen(Color.Black), points[2], points[5]);
            Engine.grp.DrawLine(new Pen(Color.Black), points[5], points[3]);
            Engine.grp.DrawLine(new Pen(Color.Black), points[8], points[6]);
            Engine.grp.DrawLine(new Pen(Color.Black), points[8], points[5]);
            Engine.RefreshGraph();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
