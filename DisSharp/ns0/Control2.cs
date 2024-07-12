namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Control2 : Control
    {
        internal void method_0()
        {
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 0x204)
            {
                msg.Msg = 0x201;
            }
            if (msg.Msg == 0x205)
            {
                msg.Msg = 0x202;
            }
            base.WndProc(ref msg);
        }
    }
}

