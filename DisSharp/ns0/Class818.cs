namespace ns0
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    internal class Class818
    {
        private Class1097 class1097_0;
        private Class397 class397_0;
        private Class810 class810_0;
        private Class811 class811_0;
        private Class812 class812_0;
        private Class815 class815_0;
        private Control0 control0_0;
        private HScrollBar hscrollBar_0;
        internal const int int_0 = 1;
        internal int int_1;
        internal int int_2;
        internal int int_3;
        internal int int_4;
        internal int int_5;
        internal int int_6;
        internal int int_7;
        internal int int_8;
        private VScrollBar vscrollBar_0;

        internal Class818(Control0 A_1, Class397 A_2)
        {
            this.class1097_0 = new Class1097(A_2);
            this.control0_0 = A_1;
            this.class397_0 = A_2;
            this.int_2 = 0;
            this.int_1 = 0;
            this.int_8 = 0;
            this.int_7 = 0;
            this.method_2();
            if (A_2.Int32_0 > 0)
            {
                Class367 class2 = A_2[A_2.Int32_0 - 1];
                if (class2.Int32_1 != 0)
                {
                    A_2.method_8();
                }
            }
            else
            {
                A_2.method_8();
            }
        }

        internal void method_0()
        {
            this.vscrollBar_0 = this.control0_0.vscrollBar_0;
            this.hscrollBar_0 = this.control0_0.hscrollBar_0;
            this.class815_0 = this.control0_0.class815_0;
            this.class811_0 = this.control0_0.class811_0;
            this.class810_0 = this.control0_0.class810_0;
            this.class812_0 = this.control0_0.class812_0;
        }

        internal Class1091 method_1(int A_1)
        {
            return this.class1097_0[A_1];
        }

        internal void method_10(int A_1)
        {
            this.int_7 = 0;
            this.int_1 = 0;
            this.int_2 = this.int_8 = A_1;
            if ((this.int_2 + this.int_4) >= this.int_6)
            {
                this.int_2 = this.int_6 - this.int_4;
            }
            if (this.int_2 < 0)
            {
                this.int_2 = 0;
            }
            this.control0_0.method_5();
            this.class810_0.method_4();
            this.control0_0.Focus();
        }

        internal Rectangle method_11(int A_1, int A_2)
        {
            return new Rectangle((int) Math.Ceiling((double) ((A_1 - this.int_1) * this.class815_0.float_0)), (A_2 - this.int_2) * this.class815_0.int_0, (int) Math.Ceiling((double) this.class815_0.float_0), this.class815_0.int_0);
        }

        internal Class1039 method_12()
        {
            return this.class1097_0.method_3(this.int_7, this.int_8 - this.int_2);
        }

        internal int method_13()
        {
            Class367 class2 = this.class397_0[this.int_8];
            int num = 0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                num += class2[i].Length;
            }
            return num;
        }

        internal int method_14(int A_1)
        {
            Class367 class2 = this.class397_0[A_1];
            int num = 0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                num += class2[i].Length;
            }
            return num;
        }

        internal void method_15(StreamWriter A_1)
        {
            this.class397_0.method_13(A_1);
        }

        internal void method_16(int A_1, int A_2, int A_3, int A_4)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                for (int i = A_2; i <= A_4; i++)
                {
                    if (i > A_2)
                    {
                        builder.Append(Environment.NewLine);
                    }
                    string str = this.class397_0[i].ToString();
                    int length = str.Length;
                    if (A_2 == A_4)
                    {
                        builder.Append(str.Substring(A_1, Math.Min((int) (A_3 - A_1), (int) (length - A_1))));
                    }
                    else if (i == A_2)
                    {
                        if (A_1 < length)
                        {
                            builder.Append(str.Substring(A_1));
                        }
                    }
                    else if (i == A_4)
                    {
                        if (A_3 < length)
                        {
                            builder.Append(str.Substring(0, A_3));
                        }
                        else
                        {
                            builder.Append(str);
                        }
                    }
                    else
                    {
                        builder.Append(str);
                    }
                }
                if (builder.Length > 0)
                {
                    Clipboard.SetDataObject(builder.ToString(), true);
                }
            }
            catch
            {
            }
        }

        internal void method_2()
        {
            int num = 0;
            for (int i = 0; i < this.class397_0.Int32_0; i++)
            {
                int num3 = this.class397_0[i].Int32_1;
                if (num3 > num)
                {
                    num = num3;
                }
            }
            int num4 = num + Class516.int_9;
            if (num4 > this.int_5)
            {
                this.int_5 = num4;
            }
            this.int_6 = this.class397_0.Int32_0;
        }

        internal void method_3()
        {
            this.class1097_0.method_2(this.int_1, this.int_2, this.int_3, this.int_4, this.class815_0.float_0);
            this.method_7();
            this.method_8();
            this.hscrollBar_0.Value = this.int_1;
            this.vscrollBar_0.Value = this.int_2;
        }

        internal void method_4()
        {
            if (!this.class811_0.bool_0)
            {
                this.int_2 = this.vscrollBar_0.Value;
                this.method_8();
                if (this.control0_0.Focused)
                {
                    this.control0_0.bool_0 = true;
                }
            }
        }

        internal void method_5()
        {
            if (!this.class811_0.bool_0)
            {
                this.int_1 = this.hscrollBar_0.Value;
                this.method_7();
                if (this.control0_0.Focused)
                {
                    this.control0_0.bool_0 = true;
                }
            }
        }

        internal void method_6()
        {
            this.method_7();
            this.method_8();
        }

        private void method_7()
        {
            if (this.int_7 < this.int_1)
            {
                this.int_7 = this.int_1;
                this.class810_0.method_4();
            }
            if (this.int_7 >= (this.int_1 + this.int_3))
            {
                this.int_7 = (this.int_1 + this.int_3) - 1;
                this.class810_0.method_4();
            }
        }

        private void method_8()
        {
            if (this.int_8 < this.int_2)
            {
                this.int_8 = this.int_2;
                this.class810_0.method_4();
            }
            if (this.int_8 >= (this.int_2 + this.int_4))
            {
                this.int_8 = (this.int_2 + this.int_4) - 1;
                this.class810_0.method_4();
            }
        }

        internal void method_9(int A_1, int A_2, bool A_3)
        {
            int num = this.int_2 + ((int) Math.Floor((double) ((A_2 - this.class815_0.rectangle_2.Top) / this.class815_0.int_0)));
            if (num >= this.int_6)
            {
                this.int_7 = this.int_1;
                this.int_8 = this.int_6 - 1;
            }
            else
            {
                this.int_7 = this.int_1 + ((int) Math.Floor((double) (((float) (A_1 - this.class815_0.rectangle_2.Left)) / this.class815_0.float_0)));
                this.int_8 = num;
            }
            this.method_6();
            if (A_3)
            {
                if (A_2 < this.class815_0.rectangle_2.Top)
                {
                    this.class812_0.method_8();
                }
                if (A_2 >= (this.class815_0.rectangle_2.Top + this.class815_0.rectangle_2.Height))
                {
                    this.class812_0.method_9();
                }
            }
        }

        internal int Int32_0
        {
            get
            {
                int num = this.int_5 - 2;
                if (num >= 0)
                {
                    return num;
                }
                return 0;
            }
        }

        internal int Int32_1
        {
            get
            {
                int num = this.int_6 - 2;
                if (num >= 0)
                {
                    return num;
                }
                return 0;
            }
        }
    }
}

