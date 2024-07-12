namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class250 : Class249
    {
        protected Class250()
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

        internal void method_923(Class547.Class528 A_1)
        {
            if (!(A_1.class369_0 is Class392) || !A_1.Boolean_8)
            {
                if (A_1.Boolean_4)
                {
                    base.method_9(Class538.class339_48);
                }
                if (A_1.Boolean_5)
                {
                    base.method_9(Class538.class339_54);
                    base.method_9(Class538.class339_50);
                }
                if (A_1.Boolean_6)
                {
                    base.method_9(Class538.class339_54);
                    base.method_9(Class538.class339_52);
                }
                if (A_1.Boolean_7)
                {
                    base.method_9(Class538.class339_48);
                    base.method_9(Class518.class337_3);
                    base.method_9(Class538.class339_55);
                    base.method_9(Class518.class337_6);
                }
            }
            if (A_1.Boolean_8)
            {
                base.method_9(Class538.class339_98);
            }
        }

        private void method_924(Class547.Class528 A_1)
        {
            if (A_1.Boolean_8)
            {
                base.method_9(Class538.class339_98);
            }
        }

        internal void method_925(Class547.Class528 A_1)
        {
            if (A_1.Boolean_13)
            {
                base.method_9(Class584.class342_0);
                base.method_9(Class538.class339_69);
                base.method_9(Class518.class337_19);
            }
            if (A_1.Boolean_9)
            {
                base.method_9(Class584.class342_0);
                base.method_9(Class538.class339_57);
                base.method_9(Class518.class337_19);
            }
            if (A_1.Boolean_12)
            {
                base.method_9(Class584.class342_0);
                base.method_9(Class538.class339_59);
                base.method_9(Class518.class337_19);
            }
            else if (A_1.Boolean_11)
            {
                if (A_1.Boolean_10)
                {
                    base.method_9(Class584.class342_0);
                    base.method_9(Class538.class339_63);
                    base.method_9(Class518.class337_19);
                }
                else
                {
                    base.method_9(Class584.class342_0);
                    base.method_9(Class538.class339_61);
                    base.method_9(Class518.class337_19);
                }
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
                    base.method_9(Class538.class339_102);
                    if (base.bool_3)
                    {
                        base.method_49(class3.class529_0, false);
                        base.method_9(Class518.class337_13);
                    }
                    base.method_9(Class538.class339_32);
                }
                else
                {
                    if (A_2.enum11_0 == Enum11.const_15)
                    {
                        base.method_9(Class538.class339_176);
                    }
                    else
                    {
                        base.method_9(Class538.class339_131);
                    }
                    if (base.bool_3)
                    {
                        base.method_49(class3.class529_0, false);
                        base.method_9(Class518.class337_13);
                    }
                    base.method_9(new Class359(A_2.class369_0));
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
                            base.method_906(class4);
                        }
                        if (class4.Boolean_0)
                        {
                            if (class4.Boolean_1)
                            {
                                base.method_9(Class538.class339_214);
                            }
                            else
                            {
                                base.method_9(Class538.class339_214);
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
                base.method_9(Class518.class337_19);
            }
        }
    }
}

