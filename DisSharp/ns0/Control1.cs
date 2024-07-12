namespace ns0
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    internal class Control1 : Control
    {
        private Class802 class802_0;

        internal Control1(Class802 A_1)
        {
            this.method_0();
            base.ResizeRedraw = true;
            this.Dock = DockStyle.Fill;
            this.class802_0 = A_1;
            base.Controls.Add(A_1);
        }

        private void method_0()
        {
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.Opaque, false);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.Selectable, false);
            base.SetStyle(ControlStyles.UserMouse, false);
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighSpeed;
            graphics.PageUnit = GraphicsUnit.Pixel;
            ControlPaint.DrawBorder3D(graphics, this.DisplayRectangle, Border3DStyle.Sunken);
            base.OnPaint(pevent);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.class802_0.Left = base.Left + 2;
            this.class802_0.Top = base.Top + 2;
            this.class802_0.Width = base.Width - 4;
            this.class802_0.Height = base.Height - 4;
            base.Invalidate();
        }
    }
}

