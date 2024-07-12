namespace ns0
{
    using System;

    internal class Class817
    {
        internal bool bool_0;
        private bool bool_1;
        private Class397 class397_0;
        private Class812 class812_0;
        private Class815 class815_0;
        private Class818 class818_0;
        private Control0 control0_0;
        private Enum73 enum73_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        internal Struct22[] struct22_0 = new Struct22[0];

        internal Class817(Control0 A_1, Class397 A_2)
        {
            this.control0_0 = A_1;
            this.class397_0 = A_2;
        }

        internal void method_0()
        {
            this.class812_0 = this.control0_0.class812_0;
            this.class815_0 = this.control0_0.class815_0;
            this.class818_0 = this.control0_0.class818_0;
        }

        internal void method_1()
        {
            bool flag = this.Boolean_0;
            this.bool_0 = false;
            this.enum73_0 = Enum73.const_0;
            if (flag)
            {
                Class705.smethod_1();
                this.control0_0.method_5();
            }
        }

        internal void method_10()
        {
            this.int_0 = 0;
            this.int_1 = 0;
            this.int_2 = 0;
            this.int_3 = this.class397_0.Int32_0 - 1;
            this.enum73_0 = Enum73.const_2;
            this.class812_0.method_19();
            this.method_11();
        }

        internal void method_11()
        {
            this.int_2 = this.class818_0.int_7;
            this.int_3 = this.class818_0.int_8;
            this.method_12();
            this.control0_0.method_5();
            Class705.smethod_1();
        }

        internal void method_12()
        {
            if (this.bool_1)
            {
                this.bool_0 = false;
                this.bool_1 = false;
            }
            else
            {
                if (this.enum73_0 == Enum73.const_2)
                {
                    this.method_4();
                }
                if (this.enum73_0 == Enum73.const_0)
                {
                    this.bool_0 = false;
                }
                else
                {
                    Class1114 class2 = new Class1114(this.int_0, this.int_1);
                    Class1114 class3 = new Class1114(this.int_2, this.int_3);
                    if (Class1114.smethod_3(class2, class3))
                    {
                        Class1114.smethod_4(class2, class3);
                    }
                    this.bool_0 = true;
                    if (Class1114.smethod_0(class2, class3))
                    {
                        this.bool_0 = false;
                    }
                    Class1114 class4 = new Class1114(this.class818_0.int_1, this.class818_0.int_2);
                    Class1114 class5 = new Class1114((this.class818_0.int_1 + this.class818_0.int_3) - 1, (this.class818_0.int_2 + this.class818_0.int_4) - 1);
                    if (Class1114.smethod_2(class3, class4))
                    {
                        this.bool_0 = false;
                    }
                    if (Class1114.smethod_3(class2, class5))
                    {
                        this.bool_0 = false;
                    }
                    if (this.bool_0)
                    {
                        if (this.struct22_0.Length != this.class818_0.int_4)
                        {
                            this.struct22_0 = new Struct22[this.class818_0.int_4];
                        }
                        for (int i = 0; i < this.class818_0.int_4; i++)
                        {
                            this.struct22_0[i].bool_0 = false;
                        }
                        bool flag = false;
                        for (int j = 0; j < this.class818_0.int_4; j++)
                        {
                            int num3 = this.class818_0.int_2 + j;
                            if (num3 < this.class397_0.Int32_0)
                            {
                                int num4 = this.class818_0.int_2 + j;
                                Class1114 class6 = new Class1114(this.class818_0.int_1, num4);
                                Class1114 class7 = new Class1114((this.class818_0.int_1 + this.class818_0.int_3) - 1, num4);
                                if (!Class1114.smethod_2(class3, class6) && !Class1114.smethod_3(class2, class7))
                                {
                                    int num5 = Class1114.smethod_2(class2, class6) ? this.class818_0.int_1 : class2.int_0;
                                    int num6 = Class1114.smethod_3(class3, class7) ? ((this.class818_0.int_1 + this.class818_0.int_3) - 1) : class3.int_0;
                                    int num7 = this.class397_0[num3].Int32_1;
                                    if (num6 > (num7 - 1))
                                    {
                                        num6 = num7 - 1;
                                    }
                                    if ((num4 == this.class818_0.int_8) && ((num4 != class2.int_1) || ((class2.int_1 == class3.int_1) && (class3.int_0 < this.class818_0.method_14(num4)))))
                                    {
                                        num6--;
                                    }
                                    if (num6 >= 0)
                                    {
                                        this.struct22_0[j].bool_0 = true;
                                        this.struct22_0[j].int_0 = num5;
                                        this.struct22_0[j].int_1 = num6;
                                        flag = true;
                                    }
                                }
                            }
                        }
                        this.bool_0 = flag;
                    }
                }
            }
        }

        internal void method_13()
        {
            if (this.Boolean_0)
            {
                Class1114 class2 = new Class1114(this.int_0, this.int_1);
                Class1114 class3 = new Class1114(this.int_2, this.int_3);
                if (Class1114.smethod_2(class2, class3))
                {
                    this.class818_0.method_16(this.int_0, this.int_1, this.int_2, this.int_3);
                }
                else
                {
                    this.class818_0.method_16(this.int_2, this.int_3, this.int_0, this.int_1);
                }
            }
        }

        private void method_2()
        {
            if (this.enum73_0 != Enum73.const_0)
            {
                this.bool_1 = true;
            }
            this.method_1();
            this.enum73_0 = Enum73.const_1;
            this.int_0 = this.int_2 = this.class818_0.int_7;
            this.int_1 = this.int_2 = this.class818_0.int_8;
        }

        private void method_3()
        {
            this.method_4();
            if (this.enum73_0 != Enum73.const_0)
            {
                this.enum73_0 = Enum73.const_2;
            }
            this.method_11();
        }

        private void method_4()
        {
            if ((this.int_0 == this.int_2) && (this.int_1 == this.int_3))
            {
                this.enum73_0 = Enum73.const_0;
            }
        }

        internal void method_5()
        {
            this.method_2();
        }

        internal void method_6()
        {
            this.method_3();
        }

        internal void method_7()
        {
            this.method_2();
        }

        internal void method_8()
        {
            this.method_3();
        }

        internal void method_9()
        {
            this.method_11();
        }

        internal bool Boolean_0
        {
            get
            {
                if (this.enum73_0 == Enum73.const_0)
                {
                    return false;
                }
                if ((this.int_0 == this.int_2) && (this.int_1 == this.int_3))
                {
                    return false;
                }
                return true;
            }
        }
    }
}

