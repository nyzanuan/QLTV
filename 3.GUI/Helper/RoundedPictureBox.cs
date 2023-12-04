using System.Drawing.Drawing2D;

namespace _3.GUI.Helper
{
    public class RoundedPictureBox: PictureBox
    {
        private int borderWidth = 2;

        public RoundedPictureBox()
        {
            this.BackColor = Color.Transparent;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);

                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.FillPath(Brushes.White, path);
                        graphics.DrawPath(new Pen(Color.Black, borderWidth), path);
                    }
                }

                e.Graphics.DrawImage(bitmap, 0, 0);
            }

            base.OnPaint(e);
        }

    }
}
