namespace ns0
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    internal class Control0 : Control
    {
        internal bool bool_0 = true;
        private Class394 class394_0;
        private Class394 class394_1;
        internal Class810 class810_0;
        internal Class811 class811_0;
        internal Class812 class812_0;
        internal Class813 class813_0;
        internal Class814 class814_0;
        internal Class815 class815_0;
        internal Class816 class816_0;
        internal Class817 class817_0;
        internal Class818 class818_0;
        internal Class819 class819_0;
        internal HScrollBar hscrollBar_0;
        private const int int_0 = 0x100;
        private const int int_1 = 0x101;
        internal int int_2 = -1;
        private Timer timer_0;
        internal VScrollBar vscrollBar_0;

        internal Control0(Class394 A_1, Class397 A_2, Enum43 A_3)
        {
            this.class394_0 = A_1;
            this.method_0();
            this.Dock = DockStyle.Fill;
            base.ResizeRedraw = true;
            base.Visible = true;
            base.Enabled = true;
            this.vscrollBar_0 = new VScrollBar();
            this.hscrollBar_0 = new HScrollBar();
            this.vscrollBar_0.Visible = false;
            this.hscrollBar_0.Visible = false;
            base.Controls.AddRange(new Control[] { this.vscrollBar_0, this.hscrollBar_0 });
            this.vscrollBar_0.ValueChanged += new EventHandler(this.vscrollBar_0_ValueChanged);
            this.hscrollBar_0.ValueChanged += new EventHandler(this.hscrollBar_0_ValueChanged);
            this.class810_0 = new Class810(this);
            this.class811_0 = new Class811(A_1, this, A_3);
            this.class812_0 = new Class812(this);
            this.class813_0 = new Class813(this);
            this.class814_0 = new Class814(this);
            this.class815_0 = new Class815(this);
            this.class816_0 = new Class816(this);
            this.class817_0 = new Class817(this, A_2);
            this.class818_0 = new Class818(this, A_2);
            this.class819_0 = new Class819(this, A_2);
            this.class810_0.method_0();
            this.class811_0.method_0();
            this.class812_0.method_0();
            this.class813_0.method_0();
            this.class814_0.method_0();
            this.class815_0.method_0();
            this.class816_0.method_0();
            this.class817_0.method_0();
            this.class818_0.method_0();
            this.class819_0.method_0();
            this.method_3();
            this.timer_0 = new Timer();
            this.timer_0.Interval = 10;
            this.timer_0.Enabled = true;
            this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
        }

        private void hscrollBar_0_ValueChanged(object sender, EventArgs e)
        {
            this.method_1();
            this.class818_0.method_5();
            this.method_5();
            this.method_2();
        }

        private void method_0()
        {
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.Opaque, false);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.Selectable, true);
            base.SetStyle(ControlStyles.UserMouse, true);
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void method_1()
        {
            this.class394_1 = Class519.class394_0;
            Class519.smethod_0(this.class394_0);
        }

        internal void method_10(int A_1)
        {
            this.method_1();
            this.class818_0.method_10(A_1);
            this.method_2();
        }

        private void method_2()
        {
            Class519.smethod_0(this.class394_1);
        }

        internal void method_3()
        {
            this.Font = new Font(Class516.string_1, Class516.float_1);
            this.class811_0.method_1(this.Font);
        }

        internal void method_4()
        {
            this.class818_0.method_2();
            this.method_5();
        }

        internal void method_5()
        {
            this.class816_0.enum44_0 = Enum44.const_0;
            this.bool_0 = true;
            base.Invalidate();
        }

        internal void method_6(int A_1, int A_2)
        {
            this.class816_0.enum44_0 = Enum44.const_0;
            base.Invalidate(this.class818_0.method_11(A_1, A_2));
        }

        internal void method_7()
        {
            this.method_1();
            this.class817_0.method_13();
            this.method_2();
        }

        internal void method_8()
        {
            this.method_1();
            this.class817_0.method_10();
            this.method_2();
        }

        internal void method_9(StreamWriter A_1)
        {
            this.method_1();
            this.class818_0.method_15(A_1);
            this.method_2();
        }

        protected override void OnDoubleClick(EventArgs eventArgs_0)
        {
            this.method_1();
            base.OnDoubleClick(eventArgs_0);
            this.class813_0.method_5();
            this.method_2();
        }

        protected override void OnGotFocus(EventArgs eventArgs_0)
        {
            base.OnGotFocus(eventArgs_0);
            this.class810_0.method_1();
            this.class812_0.method_3();
            this.class813_0.method_1();
            this.method_5();
        }

        protected override void OnLostFocus(EventArgs eventArgs_0)
        {
            base.OnLostFocus(eventArgs_0);
            this.class810_0.method_3();
            this.class812_0.method_3();
            this.class813_0.method_1();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            this.method_1();
            base.OnMouseDown(mevent);
            this.class813_0.method_2(mevent);
            this.method_2();
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            this.method_1();
            base.OnMouseMove(mevent);
            this.class813_0.method_4(mevent);
            this.method_2();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            this.method_1();
            base.OnMouseUp(mevent);
            this.class813_0.method_3(mevent);
            this.method_2();
        }

        protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
        {
            this.method_1();
            base.OnMouseWheel(mouseEventArgs_0);
            this.class813_0.method_6(mouseEventArgs_0);
            this.method_2();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.method_1();
            base.OnPaint(pevent);
            this.class814_0.method_1(pevent);
            if (this.bool_0)
            {
                this.class810_0.method_4();
                this.bool_0 = false;
            }
            this.method_2();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.class816_0.enum44_0 = Enum44.const_0;
            base.Invalidate();
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            this.method_1();
            if (msg.Msg == 0x100)
            {
                if (this.class812_0.method_1((Keys) ((int) msg.WParam)))
                {
                    return true;
                }
            }
            else if ((msg.Msg == 0x101) && this.class812_0.method_2((Keys) ((int) msg.WParam)))
            {
                return true;
            }
            this.method_2();
            return base.PreProcessMessage(ref msg);
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.timer_0.Stop();
            if (this.int_2 != -1)
            {
                this.method_10(this.int_2);
            }
        }

        private void vscrollBar_0_ValueChanged(object sender, EventArgs e)
        {
            this.method_1();
            this.class818_0.method_4();
            this.method_5();
            this.method_2();
        }

        internal bool Boolean_0
        {
            get
            {
                return this.class817_0.Boolean_0;
            }
        }
    }
}

