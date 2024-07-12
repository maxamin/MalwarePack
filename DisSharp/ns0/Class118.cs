namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class118 : Class117
    {
        protected Class118()
        {
        }

        internal void method_453(Class407 A_1)
        {
        }

        internal void method_454(Class407 A_1)
        {
        }

        internal void method_455(Class407 A_1)
        {
        }

        internal void method_456(Class407 A_1)
        {
            ArrayList qQSQ = A_1.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                ArrayList list2 = null;
                switch (class2.Type)
                {
                    case Enum26.const_5:
                    {
                        Class404 class4 = class2 as Class404;
                        base.method_10(Class632.class339_33);
                        if (class4.uint_0 != Class519.class604_0.uint_1)
                        {
                            if (class4.bool_1)
                            {
                                base.method_9(new Class354(Class525.int_0 + class4.ushort_2));
                            }
                            else
                            {
                                base.method_9(Class584.class336_24);
                            }
                            base.method_9(Class632.class339_15);
                            base.method_208(class4.uint_0);
                        }
                        list2 = class4.QQSQ;
                        break;
                    }
                    case Enum26.const_11:
                    {
                        Class412 class5 = class2 as Class412;
                        base.method_10(Class632.class339_100);
                        list2 = class5.QQSQ;
                        break;
                    }
                    case Enum26.const_38:
                    {
                        Class438 class3 = class2 as Class438;
                        base.method_10(Class632.class339_266);
                        list2 = class3.QQSQ;
                        break;
                    }
                }
                if (list2 != null)
                {
                    base.int_0++;
                    for (int j = 0; j < list2.Count; j++)
                    {
                        base.method_39(list2[j] as Class398);
                    }
                    base.int_0--;
                }
            }
            base.method_10(Class632.class339_87);
            base.method_9(Class632.class339_266);
        }

        internal void method_457(Class407 A_1)
        {
            ArrayList qQSQ = A_1.QQSQ;
            bool flag = false;
            bool flag2 = false;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                ArrayList list2 = null;
                flag2 = false;
                switch (class2.Type)
                {
                    case Enum26.const_5:
                    {
                        if (!flag)
                        {
                            base.method_10(Class538.class339_118);
                            flag = true;
                        }
                        flag2 = true;
                        base.int_0++;
                        base.method_10(Class538.class339_168);
                        Class404 class4 = class2 as Class404;
                        if (class4.bool_1)
                        {
                            base.method_9(new Class354(Class525.int_0 + class4.ushort_2));
                        }
                        else
                        {
                            base.method_9(Class584.class336_24);
                        }
                        base.method_9(Class518.class337_17);
                        base.method_208(class4.uint_0);
                        base.method_9(Class538.class339_111);
                        base.method_10(Class538.class339_92);
                        list2 = class4.QQSQ;
                        break;
                    }
                    case Enum26.const_11:
                    {
                        Class412 class5 = class2 as Class412;
                        base.method_10(Class538.class339_126);
                        list2 = class5.QQSQ;
                        break;
                    }
                    case Enum26.const_38:
                    {
                        Class438 class3 = class2 as Class438;
                        base.method_10(Class538.class339_203);
                        list2 = class3.QQSQ;
                        break;
                    }
                }
                if (list2 != null)
                {
                    base.int_0++;
                    for (int j = 0; j < list2.Count; j++)
                    {
                        base.method_39(list2[j] as Class398);
                    }
                    base.int_0--;
                }
                if (flag2)
                {
                    base.method_10(Class538.class339_116);
                    base.method_9(Class518.class337_19);
                    base.int_0--;
                }
            }
            base.method_10(Class538.class339_116);
            base.method_9(Class518.class337_19);
        }

        internal void method_458(Class407 A_1)
        {
            ArrayList qQSQ = A_1.QQSQ;
            bool flag = false;
            bool flag2 = false;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                ArrayList list2 = null;
                flag2 = false;
                switch (class2.Type)
                {
                    case Enum26.const_5:
                    {
                        if (!flag)
                        {
                            base.method_10(Class634.class339_90);
                            flag = true;
                        }
                        flag2 = true;
                        base.int_0++;
                        base.method_10(Class634.class339_179);
                        Class404 class4 = class2 as Class404;
                        if (class4.bool_1)
                        {
                            base.method_9(new Class354(Class525.int_0 + class4.ushort_2));
                        }
                        else
                        {
                            base.method_9(Class584.class336_24);
                        }
                        base.method_9(Class518.class337_17);
                        base.method_208(class4.uint_0);
                        base.method_9(Class634.class339_73);
                        base.method_10(Class634.class339_48);
                        list2 = class4.QQSQ;
                        break;
                    }
                    case Enum26.const_11:
                    {
                        Class412 class5 = class2 as Class412;
                        base.method_10(Class634.class339_106);
                        list2 = class5.QQSQ;
                        break;
                    }
                    case Enum26.const_38:
                    {
                        Class438 class3 = class2 as Class438;
                        base.method_10(Class634.class339_245);
                        list2 = class3.QQSQ;
                        break;
                    }
                }
                if (list2 != null)
                {
                    base.int_0++;
                    for (int j = 0; j < list2.Count; j++)
                    {
                        base.method_39(list2[j] as Class398);
                    }
                    base.int_0--;
                }
                if (flag2)
                {
                    base.method_10(Class634.class339_82);
                    base.method_9(Class518.class337_19);
                    base.int_0--;
                }
            }
            base.method_10(Class634.class339_82);
            base.method_9(Class518.class337_19);
        }
    }
}

