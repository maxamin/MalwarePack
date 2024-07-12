namespace ns0
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    internal class Control4 : Control2
    {
        private PictureBox pictureBox_0;

        internal Control4()
        {
            base.method_0();
            this.pictureBox_0 = new PictureBox();
            this.pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pictureBox_0.BorderStyle = BorderStyle.None;
            this.pictureBox_0.Image = Class868.bitmap_0;
            this.pictureBox_0.Left = 2;
            this.pictureBox_0.Top = 2;
            base.Width = this.pictureBox_0.Width + 4;
            base.Height = this.pictureBox_0.Height + 4;
            base.Controls.Add(this.pictureBox_0);
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
    }
}

