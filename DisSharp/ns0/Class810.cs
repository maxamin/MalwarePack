namespace ns0
{
    using System;
    using System.Runtime.InteropServices;

    internal class Class810
    {
        private static bool bool_0;
        private bool bool_1 = true;
        private Class815 class815_0;
        private Class816 class816_0;
        private Class818 class818_0;
        private Control0 control0_0;
        private IntPtr intptr_0;

        internal Class810(Control0 A_1)
        {
            this.control0_0 = A_1;
            this.intptr_0 = A_1.Handle;
        }

        [DllImport("User32.dll")]
        private static extern bool CreateCaret(IntPtr hWnd, int hBitmap, int nWidth, int nHeight);
        [DllImport("User32.dll")]
        private static extern bool DestroyCaret();
        [DllImport("User32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        internal void method_0()
        {
            this.class816_0 = this.control0_0.class816_0;
            this.class815_0 = this.control0_0.class815_0;
            this.class818_0 = this.control0_0.class818_0;
        }

        internal void method_1()
        {
            if (!bool_0)
            {
                this.class816_0.method_2(this.control0_0.CreateGraphics());
                bool_0 = CreateCaret(this.intptr_0, 0, (int) Math.Round((double) this.class815_0.float_0), 2);
                this.method_6();
            }
        }

        internal void method_2()
        {
            this.method_1();
            if (!this.bool_1)
            {
                this.method_4();
            }
            this.bool_1 = false;
        }

        internal void method_3()
        {
            if (bool_0)
            {
                bool_0 = false;
                HideCaret(this.intptr_0);
                DestroyCaret();
            }
        }

        internal void method_4()
        {
            this.method_5(this.class818_0.int_7, this.class818_0.int_8);
        }

        internal void method_5(int A_1, int A_2)
        {
            try
            {
                if (!bool_0)
                {
                    this.method_1();
                }
                if (bool_0)
                {
                    int num = A_1 - this.class818_0.int_1;
                    int num2 = A_2 - this.class818_0.int_2;
                    int num3 = ((this.class815_0.rectangle_2.Left + ((int) Math.Round((double) (num * this.class815_0.float_0)))) + 5) - 1;
                    int num4 = (this.class815_0.rectangle_2.Top + ((num2 + 1) * this.class815_0.int_0)) - 2;
                    if (!SetCaretPos(num3, num4))
                    {
                        DestroyCaret();
                        bool_0 = false;
                    }
                }
            }
            catch
            {
            }
        }

        internal void method_6()
        {
            ShowCaret(this.intptr_0);
        }

        internal void method_7()
        {
            HideCaret(this.intptr_0);
        }

        [DllImport("User32.dll")]
        private static extern bool SetCaretPos(int int_0, int int_1);
        [DllImport("User32.dll")]
        private static extern bool ShowCaret(IntPtr hWnd);
    }
}

