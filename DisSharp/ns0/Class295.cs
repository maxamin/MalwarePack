namespace ns0
{
    using System;

    internal abstract class Class295 : Class294
    {
        private Class48 class48_7 = new Class48();
        internal Enum15 enum15_0;
        internal string string_33 = Class537.string_0;
        private static string string_34 = Class537.string_66.Substring(0, Class537.string_66.Length - 1);
        private static string string_35 = Class537.string_916.Substring(0, Class537.string_916.Length - 1);

        protected Class295()
        {
        }

        internal void method_898(Class548.Class529 A_1)
        {
            bool flag = true;
            for (int i = 0; i < A_1.short_3; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1.int_6 + i] as Class550.Class514;
                if (A_1.Boolean_16 && (class2.enum7_0 == Enum7.const_1))
                {
                    Class551.Class544 class3 = Class546.class551_0.arrayList_0[class2.int_0] as Class551.Class544;
                    if (class3.enum9_0 == Enum9.const_2)
                    {
                        Class552.Class545 class4 = Class546.class552_0.arrayList_0[class3.int_0] as Class552.Class545;
                        if (class4.int_0 == Class519.class604_0.int_14)
                        {
                            continue;
                        }
                    }
                }
                if (!flag)
                {
                    base.method_9(Class584.class337_1);
                }
                base.method_7();
                if (flag)
                {
                    base.method_9(Class518.class337_39);
                    flag = false;
                }
                base.method_164(class2);
                if (!flag && (i == (A_1.short_3 - 1)))
                {
                    base.method_9(Class584.class337_0);
                }
            }
        }

        internal void method_899(Class547.Class528 A_1, bool A_2)
        {
            this.string_33 = Class537.string_0;
            bool flag = true;
            for (int i = 0; i < A_1.short_1; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1.int_3 + i] as Class550.Class514;
                if (!A_2 || !this.method_901(class2))
                {
                    if (!flag)
                    {
                        base.method_9(Class584.class337_1);
                    }
                    base.method_7();
                    if (flag)
                    {
                        base.method_9(Class518.class337_39);
                        flag = false;
                    }
                    base.method_164(class2);
                    if (!flag && (i == (A_1.short_1 - 1)))
                    {
                        base.method_9(Class584.class337_0);
                    }
                }
            }
        }

        internal void method_900(Class547.Class528 A_1)
        {
            this.string_33 = Class537.string_0;
            for (int i = 0; i < A_1.short_1; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1.int_3 + i] as Class550.Class514;
                if (this.method_901(class2))
                {
                    return;
                }
            }
        }

        private bool method_901(Class550.Class514 A_1)
        {
            try
            {
                if (A_1.enum7_0 == Enum7.const_2)
                {
                    Class570.Class625 class2 = Class546.class570_0.arrayList_0[A_1.int_0] as Class570.Class625;
                    if (class2.enum12_0 == Enum12.const_3)
                    {
                        this.string_33 = Class519.class581_0[class2.int_0];
                        this.enum15_0 = class2.enum15_0;
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        internal void method_902(Class547.Class528 A_1)
        {
            if (A_1.int_4 > 0)
            {
                Class568.Class623 class2 = Class546.class568_0.arrayList_0[A_1.int_4] as Class568.Class623;
                if (class2.short_0 == 1)
                {
                    Class550.Class514 class3 = Class546.class550_0.arrayList_0[class2.int_2] as Class550.Class514;
                    base.method_7();
                    base.method_9(Class518.class337_39);
                    base.method_9(Class584.class336_5);
                    base.method_9(Class518.class337_17);
                    base.method_164(class3);
                    base.method_9(Class584.class337_0);
                }
            }
        }

        internal void method_903(Class568.Class623 A_1)
        {
            base.method_9(Class518.class337_39);
            for (int i = 0; i < A_1.short_0; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1.int_2 + i] as Class550.Class514;
                if (i > 0)
                {
                    base.method_9(Class518.class337_15);
                }
                base.method_164(class2);
            }
            base.method_9(Class518.class337_44);
        }

        internal void method_904(Class549.Class530 A_1)
        {
            for (int i = 0; i < A_1.short_0; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1.int_3 + i] as Class550.Class514;
                if (i > 0)
                {
                    base.method_9(Class584.class337_1);
                }
                base.method_7();
                if (i == 0)
                {
                    base.method_9(Class518.class337_39);
                }
                base.method_164(class2);
                if (i == (A_1.short_0 - 1))
                {
                    base.method_9(Class584.class337_0);
                }
            }
        }

        internal void method_905(Class384 A_1)
        {
            for (int i = 0; i < A_1.short_0; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1.int_2 + i] as Class550.Class514;
                if (i > 0)
                {
                    base.method_9(Class584.class337_1);
                }
                base.method_7();
                if (i == 0)
                {
                    base.method_9(Class518.class337_39);
                }
                base.method_164(class2);
                if (i == (A_1.short_0 - 1))
                {
                    base.method_9(Class584.class337_0);
                }
            }
        }

        internal void method_906(Class382 A_1)
        {
            for (int i = 0; i < A_1.short_0; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1.int_2 + i] as Class550.Class514;
                if (i > 0)
                {
                    base.method_9(Class584.class337_1);
                }
                base.method_7();
                if (i == 0)
                {
                    base.method_9(Class518.class337_39);
                }
                base.method_164(class2);
                if (i == (A_1.short_0 - 1))
                {
                    base.method_9(Class584.class337_0);
                }
            }
        }

        internal void method_907(Class381 A_1)
        {
            for (int i = 0; i < A_1.short_0; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1.int_2 + i] as Class550.Class514;
                if (i > 0)
                {
                    base.method_9(Class584.class337_1);
                }
                base.method_7();
                if (i == 0)
                {
                    base.method_9(Class518.class337_39);
                }
                base.method_164(class2);
                if (i == (A_1.short_0 - 1))
                {
                    base.method_9(Class584.class337_0);
                }
            }
        }
    }
}

