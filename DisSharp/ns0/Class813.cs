namespace ns0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class Class813
    {
        private bool bool_0;
        private Class810 class810_0;
        private Class811 class811_0;
        private Class817 class817_0;
        private Class818 class818_0;
        private Control0 control0_0;
        private HScrollBar hscrollBar_0;
        private VScrollBar vscrollBar_0;

        internal Class813(Control0 A_1)
        {
            this.control0_0 = A_1;
        }

        internal void method_0()
        {
            this.vscrollBar_0 = this.control0_0.vscrollBar_0;
            this.hscrollBar_0 = this.control0_0.hscrollBar_0;
            this.class818_0 = this.control0_0.class818_0;
            this.class810_0 = this.control0_0.class810_0;
            this.class811_0 = this.control0_0.class811_0;
            this.class817_0 = this.control0_0.class817_0;
        }

        internal void method_1()
        {
            this.bool_0 = false;
        }

        internal void method_2(MouseEventArgs A_1)
        {
            if (A_1.Button == MouseButtons.Left)
            {
                this.bool_0 = true;
                this.class818_0.method_9(A_1.X, A_1.Y, false);
                this.class817_0.method_7();
                this.class810_0.method_4();
            }
        }

        internal void method_3(MouseEventArgs A_1)
        {
            if (A_1.Button == MouseButtons.Left)
            {
                this.bool_0 = false;
                this.class817_0.method_8();
            }
            else if (A_1.Button == MouseButtons.Right)
            {
                Point p = new Point(A_1.X, A_1.Y);
                Class698.class582_0.class1017_0.method_8(this.class817_0.Boolean_0);
                Class698.class582_0.class1017_0.contextMenuStrip_1.Show(this.control0_0.PointToScreen(p));
            }
        }

        internal void method_4(MouseEventArgs A_1)
        {
            if ((A_1.Button == MouseButtons.Left) && this.bool_0)
            {
                this.class818_0.method_9(A_1.X, A_1.Y, true);
                this.class817_0.method_9();
                this.class810_0.method_4();
            }
        }

        internal void method_5()
        {
            this.class811_0.method_2();
        }

        internal void method_6(MouseEventArgs A_1)
        {
            int num = this.vscrollBar_0.Value - ((SystemInformation.MouseWheelScrollLines * Math.Sign(A_1.Delta)) * (Math.Abs(A_1.Delta) / 120));
            this.vscrollBar_0.Value = Math.Max(0, Math.Min(this.class818_0.int_6 - this.class818_0.int_4, num));
            this.class818_0.method_4();
            this.control0_0.method_5();
        }
    }
}

