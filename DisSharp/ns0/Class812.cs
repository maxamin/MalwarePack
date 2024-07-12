namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class812
    {
        private bool bool_0;
        private bool bool_1;
        private Class810 class810_0;
        private Class811 class811_0;
        private Class817 class817_0;
        private Class818 class818_0;
        private Class819 class819_0;
        private Control0 control0_0;
        private HScrollBar hscrollBar_0;
        private VScrollBar vscrollBar_0;

        internal Class812(Control0 A_1)
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
            this.class819_0 = this.control0_0.class819_0;
        }

        internal bool method_1(Keys A_1)
        {
            if (A_1 == Keys.ControlKey)
            {
                this.bool_0 = true;
                return true;
            }
            if (A_1 == Keys.ShiftKey)
            {
                this.class817_0.method_5();
                this.bool_1 = true;
                return true;
            }
            if (this.bool_0)
            {
                return this.method_6(A_1);
            }
            if (this.bool_1)
            {
                return this.method_5(A_1);
            }
            return this.method_4(A_1);
        }

        private void method_10()
        {
            if (this.class818_0.int_7 > 0)
            {
                this.class818_0.int_7--;
                if (this.class818_0.int_7 < this.class818_0.int_1)
                {
                    this.class818_0.int_1 = this.class818_0.int_7;
                    this.control0_0.method_5();
                    this.hscrollBar_0.Value = this.class818_0.int_1;
                }
                else
                {
                    this.class810_0.method_4();
                }
            }
        }

        private void method_11()
        {
            if (this.class818_0.int_7 < (this.class818_0.int_5 - 1))
            {
                this.class818_0.int_7++;
                if (this.class818_0.int_7 >= (this.class818_0.int_1 + this.class818_0.int_3))
                {
                    this.class818_0.int_1 = (this.class818_0.int_7 - this.class818_0.int_3) + 1;
                    this.control0_0.method_5();
                    this.hscrollBar_0.Value = this.class818_0.int_1;
                }
                else
                {
                    this.class810_0.method_4();
                }
            }
        }

        private void method_12()
        {
            if (this.class818_0.int_8 > 0)
            {
                this.class818_0.int_8 = (this.class818_0.int_8 - this.class818_0.int_4) + 1;
                this.class818_0.int_2 = (this.class818_0.int_2 - this.class818_0.int_4) + 1;
                if (this.class818_0.int_8 < 0)
                {
                    this.class818_0.int_8 = 0;
                    this.class818_0.int_2 = 0;
                }
                else if (this.class818_0.int_2 < 0)
                {
                    if (this.class818_0.int_4 >= this.class818_0.int_6)
                    {
                        this.class818_0.int_8 += Math.Abs(this.class818_0.int_2);
                        if (this.class818_0.int_8 == (this.class818_0.int_4 - 1))
                        {
                            this.class818_0.int_8 = 0;
                        }
                    }
                    this.class818_0.int_2 = 0;
                }
                this.vscrollBar_0.Value = this.class818_0.int_2;
                this.control0_0.method_5();
                this.class810_0.method_4();
            }
        }

        private void method_13()
        {
            if (this.class818_0.int_8 < (this.class818_0.int_6 - 1))
            {
                this.class818_0.int_8 = (this.class818_0.int_8 + this.class818_0.int_4) - 1;
                this.class818_0.int_2 = (this.class818_0.int_2 + this.class818_0.int_4) - 1;
                if (this.class818_0.int_8 >= this.class818_0.int_6)
                {
                    this.class818_0.int_8 = this.class818_0.int_6 - 1;
                    this.class818_0.int_2 = this.class818_0.int_6 - this.class818_0.int_4;
                    if (this.class818_0.int_2 < 0)
                    {
                        this.class818_0.int_2 = 0;
                    }
                }
                else if ((this.class818_0.int_2 + this.class818_0.int_4) > this.class818_0.int_6)
                {
                    if (this.class818_0.int_4 >= this.class818_0.int_6)
                    {
                        this.class818_0.int_8 = ((this.class818_0.int_8 - this.class818_0.int_2) - this.class818_0.int_4) + this.class818_0.int_6;
                        if (this.class818_0.int_8 == (this.class818_0.int_6 - this.class818_0.int_4))
                        {
                            this.class818_0.int_8 = this.class818_0.int_6 - 1;
                        }
                    }
                    this.class818_0.int_2 = this.class818_0.int_6 - this.class818_0.int_4;
                }
                this.vscrollBar_0.Value = this.class818_0.int_2;
                this.control0_0.method_5();
                this.class810_0.method_4();
            }
        }

        private void method_14()
        {
            this.class818_0.int_1 = 0;
            this.class818_0.int_7 = 0;
            this.hscrollBar_0.Value = 0;
            this.control0_0.method_5();
            this.class810_0.method_4();
        }

        private void method_15()
        {
            this.class818_0.int_7 = this.class818_0.method_13();
            if (this.class818_0.int_7 >= this.class818_0.int_5)
            {
                this.class818_0.int_7 = this.class818_0.int_5 - 1;
            }
            if (this.class818_0.int_7 < this.class818_0.int_1)
            {
                this.class818_0.int_1 = (this.class818_0.int_7 - this.class818_0.int_3) + 1;
                if (this.class818_0.int_1 < 0)
                {
                    this.class818_0.int_1 = 0;
                }
                this.control0_0.method_5();
            }
            else if (this.class818_0.int_7 >= (this.class818_0.int_1 + this.class818_0.int_3))
            {
                this.class818_0.int_1 = (this.class818_0.int_7 - this.class818_0.int_3) + 1;
                this.control0_0.method_5();
            }
            this.hscrollBar_0.Value = this.class818_0.int_1;
            this.class810_0.method_4();
        }

        private void method_16()
        {
            this.class819_0.method_1();
        }

        private void method_17()
        {
            this.class819_0.method_5();
        }

        private void method_18()
        {
            this.class818_0.int_7 = 0;
            this.class818_0.int_1 = 0;
            this.class818_0.int_8 = 0;
            this.class818_0.int_2 = 0;
            this.control0_0.method_5();
            this.class810_0.method_4();
        }

        internal void method_19()
        {
            this.class818_0.int_7 = 0;
            this.class818_0.int_1 = 0;
            if (this.class818_0.int_6 > this.class818_0.int_4)
            {
                this.class818_0.int_2 = this.class818_0.int_6 - this.class818_0.int_4;
                this.class818_0.int_8 = this.class818_0.int_6 - 1;
            }
            else
            {
                this.class818_0.int_2 = 0;
                this.class818_0.int_8 = this.class818_0.int_6 - 1;
            }
            this.control0_0.method_5();
            this.class810_0.method_4();
        }

        internal bool method_2(Keys A_1)
        {
            if (A_1 == Keys.ControlKey)
            {
                this.bool_0 = false;
                return true;
            }
            if (A_1 == Keys.ShiftKey)
            {
                this.class817_0.method_6();
                this.bool_1 = false;
                return true;
            }
            return false;
        }

        internal void method_20()
        {
            this.class817_0.method_13();
        }

        private void method_21()
        {
            this.method_8();
            this.class817_0.method_11();
        }

        private void method_22()
        {
            this.method_9();
            this.class817_0.method_11();
        }

        private void method_23()
        {
            this.method_10();
            this.class817_0.method_11();
        }

        private void method_24()
        {
            this.method_11();
            this.class817_0.method_11();
        }

        private void method_25()
        {
            this.method_12();
            this.class817_0.method_11();
        }

        private void method_26()
        {
            this.method_13();
            this.class817_0.method_11();
        }

        private void method_27()
        {
            this.method_14();
            this.class817_0.method_11();
        }

        private void method_28()
        {
            this.method_15();
            this.class817_0.method_11();
        }

        internal void method_3()
        {
            this.bool_0 = false;
            this.bool_1 = false;
        }

        private bool method_4(Keys A_1)
        {
            switch (A_1)
            {
                case Keys.PageUp:
                    this.method_12();
                    return true;

                case Keys.Next:
                    this.method_13();
                    return true;

                case Keys.End:
                    this.method_15();
                    return true;

                case Keys.Home:
                    this.method_14();
                    return true;

                case Keys.Left:
                    this.method_10();
                    return true;

                case Keys.Up:
                    this.method_8();
                    return true;

                case Keys.Right:
                    this.method_11();
                    return true;

                case Keys.Down:
                    this.method_9();
                    return true;

                case Keys.Enter:
                    this.method_7();
                    return true;
            }
            return false;
        }

        private bool method_5(Keys A_1)
        {
            switch (A_1)
            {
                case Keys.PageUp:
                    this.method_25();
                    return true;

                case Keys.Next:
                    this.method_26();
                    return true;

                case Keys.End:
                    this.method_28();
                    return true;

                case Keys.Home:
                    this.method_27();
                    return true;

                case Keys.Left:
                    this.method_23();
                    return true;

                case Keys.Up:
                    this.method_21();
                    return true;

                case Keys.Right:
                    this.method_24();
                    return true;

                case Keys.Down:
                    this.method_22();
                    return true;
            }
            return false;
        }

        private bool method_6(Keys A_1)
        {
            switch (A_1)
            {
                case Keys.PageUp:
                    this.method_18();
                    return true;

                case Keys.Next:
                    this.method_19();
                    return true;

                case Keys.End:
                    this.method_19();
                    return true;

                case Keys.Home:
                    this.method_18();
                    return true;

                case Keys.Left:
                    this.method_16();
                    return true;

                case Keys.Right:
                    this.method_17();
                    return true;

                case Keys.Insert:
                    this.method_20();
                    return true;
            }
            return false;
        }

        private void method_7()
        {
            this.class811_0.method_2();
        }

        internal void method_8()
        {
            if (this.class818_0.int_8 > 0)
            {
                this.class818_0.int_8--;
                if (this.class818_0.int_8 < this.class818_0.int_2)
                {
                    this.class818_0.int_2 = this.class818_0.int_8;
                    this.control0_0.method_5();
                    this.vscrollBar_0.Value = this.class818_0.int_2;
                }
                else
                {
                    this.class810_0.method_4();
                }
            }
        }

        internal void method_9()
        {
            if (this.class818_0.int_8 < (this.class818_0.int_6 - 1))
            {
                this.class818_0.int_8++;
                if (this.class818_0.int_8 >= (this.class818_0.int_2 + this.class818_0.int_4))
                {
                    this.class818_0.int_2 = (this.class818_0.int_8 - this.class818_0.int_4) + 1;
                    this.control0_0.method_5();
                    this.vscrollBar_0.Value = this.class818_0.int_2;
                }
                else
                {
                    this.class810_0.method_4();
                }
            }
        }
    }
}

