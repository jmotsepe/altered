using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Altered
{
    public partial class SpinnerCircles : Form
    {
        int increment = 1;
        int radius = 4;
        int n = 8;
        int next = 0;
        Timer timer;

        public SpinnerCircles()
        {
            InitializeComponent();

            timer = new Timer();
            Size = new Size(150, 150);
            timer.Tick += (s, e) => Invalidate();
            if (!DesignMode)
                timer.Enabled = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint |
                     ControlStyles.SupportsTransparentBackColor, true);
        }

        private void SpinnerCircles_Load(object sender, EventArgs e)
        {
            //Timer timer = new Timer();
            //timer.Interval = 5000;
            //timer.Tick += new EventHandler(Timer_Tick);
            //timer.Start();

            //Set the forms background color to transparent
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            Update();
        }

        //void Timer_Tick(object sender, EventArgs e)
        //{
        //    Close();
        //}


        protected override void OnPaint(PaintEventArgs e)
        {
            if (Parent != null && BackColor == Color.Transparent)
            {
                using (var bmp = new Bitmap(Parent.Width, Parent.Height))
                {
                    Parent.Controls.Cast<Control>()
                          .Where(c => Parent.Controls.GetChildIndex(c) > Parent.Controls.GetChildIndex(this))
                          .Where(c => c.Bounds.IntersectsWith(Bounds))
                          .OrderByDescending(c => Parent.Controls.GetChildIndex(c))
                          .ToList()
                          .ForEach(c => c.DrawToBitmap(bmp, c.Bounds));

                    e.Graphics.DrawImage(bmp, -Left, -Top);
                }
            }
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            int length = Math.Min(Width, Height);
            PointF center = new PointF(length / 2, length / 2);
            int bigRadius = length / 2 - radius - (n - 1) * increment;
            float unitAngle = 360 / n;
            if (!DesignMode)
                next++;
            next = next >= n ? 0 : next;
            int a = 0;
            for (int i = next; i < next + n; i++)
            {
                int factor = i % n;
                float c1X = center.X + (float)(bigRadius * Math.Cos(unitAngle * factor * Math.PI / 180));
                float c1Y = center.Y + (float)(bigRadius * Math.Sin(unitAngle * factor * Math.PI / 180));
                int currRad = radius + a * increment;
                PointF c1 = new PointF(c1X - currRad, c1Y - currRad);
                e.Graphics.FillEllipse(Brushes.Blue, c1.X, c1.Y, 2 * currRad, 2 * currRad);
                using (Pen pen = new Pen(Color.White, 2))
                    e.Graphics.DrawEllipse(pen, c1.X, c1.Y, 2 * currRad, 2 * currRad);
                a++;
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            timer.Enabled = Visible;
            base.OnVisibleChanged(e);
        }
    }
}
