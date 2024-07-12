namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class275 : Class274
    {
        protected Class275()
        {
        }

        internal void method_921(Class369 A_1, Class547.Class528 A_2)
        {
            this.method_922(A_1, A_2, false);
        }

        internal void method_922(Class369 A_1, Class547.Class528 A_2, bool A_3)
        {
            base.method_7();
            Class519.class367_0 = base.Class367_0;
            if (A_2.Boolean_23)
            {
                base.method_9(Class634.class339_105);
                base.method_9(new Class359(A_2.class369_0));
                base.method_9(Class518.class337_19);
            }
            else
            {
                if (!base.bool_3 || A_3)
                {
                    this.method_923(A_2);
                }
                if (base.bool_3 || A_3)
                {
                    this.method_924(A_2);
                }
                this.method_926(A_1, A_2);
                if (!base.bool_3 || A_3)
                {
                    this.method_925(A_2);
                }
            }
        }

        internal void method_923(Class547.Class528 A_1)
        {
            if (!(A_1.class369_0 is Class392) || !A_1.Boolean_8)
            {
                if (A_1.Boolean_4)
                {
                    base.method_9(Class634.class339_202);
                }
                if (A_1.Boolean_5)
                {
                    base.method_9(Class634.class339_194);
                }
                if (A_1.Boolean_6)
                {
                    base.method_9(Class634.class339_200);
                }
                if (A_1.Boolean_7)
                {
                    base.method_9(Class634.class339_45);
                }
            }
            if (A_1.Boolean_8)
            {
                base.method_9(Class634.class339_56);
            }
        }

        private void method_924(Class547.Class528 A_1)
        {
            if (A_1.Boolean_8)
            {
                base.method_9(Class634.class339_56);
            }
        }

        internal void method_925(Class547.Class528 A_1)
        {
            if (A_1.Boolean_13)
            {
                base.method_9(Class634.class339_96);
                base.method_9(Class518.class337_19);
            }
            if (A_1.Boolean_9)
            {
                base.method_9(Class634.class339_101);
                base.method_9(Class518.class337_19);
            }
            if (A_1.Boolean_12)
            {
                base.method_9(Class634.class339_34);
                base.method_9(Class518.class337_19);
            }
            else if (A_1.Boolean_11)
            {
                if (A_1.Boolean_10)
                {
                    base.method_9(Class634.class339_186);
                    base.method_9(Class518.class337_19);
                }
                else
                {
                    base.method_9(Class634.class339_265);
                    base.method_9(Class518.class337_19);
                }
            }
            if (A_1.Boolean_14)
            {
                base.method_9(Class634.class339_256);
                base.method_9(Class518.class337_19);
            }
            if (A_1.Boolean_15)
            {
                base.method_9(Class634.class339_214);
                base.method_9(Class518.class337_19);
            }
        }

        private void method_926(Class369 A_1, Class547.Class528 A_2)
        {
            Class369 class2 = A_1.class369_0;
            if (!(class2 is Class370))
            {
                class2 = class2.class369_0;
            }
            Class370 class3 = class2 as Class370;
            if (class3 != null)
            {
                if (A_1 is Class392)
                {
                    base.method_9(Class634.class339_60);
                    if (base.bool_3)
                    {
                        base.method_49(class3.class529_0, false);
                        base.method_9(Class518.class337_13);
                    }
                    base.method_9(Class634.class339_28);
                }
                else
                {
                    if (A_2.enum11_0 == Enum11.const_15)
                    {
                        base.method_9(Class634.class339_196);
                    }
                    else
                    {
                        base.method_9(Class634.class339_115);
                    }
                    if (base.bool_3)
                    {
                        base.method_49(class3.class529_0, false);
                        base.method_9(Class518.class337_13);
                    }
                    base.method_9(new Class359(A_2.class369_0));
                    if (A_2.short_0 > 0)
                    {
                        base.method_916(A_2);
                    }
                }
                if (A_2.short_2 > 0)
                {
                    base.method_9(Class518.class337_10);
                    ArrayList list = Class546.class568_0.arrayList_0;
                    int num = A_2.short_2 - 1;
                    int num2 = A_2.int_6;
                    for (int i = 0; i < A_2.short_2; i++)
                    {
                        Class568.Class623 class4 = list[num2 + i] as Class568.Class623;
                        if (class4.short_0 > 0)
                        {
                            base.method_905(class4);
                        }
                        if (class4.Boolean_0)
                        {
                            if (class4.Boolean_1)
                            {
                                base.method_9(Class634.class339_262);
                            }
                            else
                            {
                                base.method_9(Class634.class339_262);
                            }
                        }
                        base.method_9(new Class355(class4));
                        base.method_9(Class518.class337_17);
                        base.method_93(class4.enum11_0, class4.int_1, class4.byte_4);
                        if (i < num)
                        {
                            base.method_9(Class518.class337_15);
                        }
                    }
                    base.method_9(Class518.class337_12);
                }
                if ((A_2.enum11_0 != Enum11.const_15) && !(A_1 is Class392))
                {
                    base.method_9(Class518.class337_17);
                    base.method_93(A_2.enum11_0, A_2.int_5, A_2.byte_1);
                }
                if (A_2.short_0 > 0)
                {
                    base.method_917(A_2);
                }
                base.method_9(Class518.class337_19);
                if ((!(A_1 is Class392) && !(A_1.class369_0 is Class375)) && (A_2.byte_0 > 0))
                {
                    base.method_920(A_2.byte_0, A_1.class369_0 as Class370);
                }
            }
        }
    }
}

