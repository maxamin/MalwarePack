namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class97 : Class96
    {
        protected Class97()
        {
        }

        internal void method_327(Class406 A_1)
        {
        }

        internal void method_328(Class406 A_1)
        {
        }

        internal void method_329(Class406 A_1)
        {
        }

        internal void method_330(Class406 A_1)
        {
            ArrayList qQSQ = A_1.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                ArrayList list2 = null;
                Enum26 type = class2.Type;
                switch (type)
                {
                    case Enum26.const_9:
                    {
                        Class410 class5 = class2 as Class410;
                        base.method_10(Class632.class339_83);
                        list2 = class5.QQSQ;
                        break;
                    }
                    case Enum26.const_10:
                    {
                        Class411 class4 = class2 as Class411;
                        base.method_10(Class632.class339_85);
                        this.QRVY(class4.class445_0);
                        base.method_9(Class584.class342_0);
                        base.method_9(Class632.class339_258);
                        list2 = class4.QQSQ;
                        break;
                    }
                    default:
                        if (type == Enum26.const_17)
                        {
                            Class418 class3 = class2 as Class418;
                            base.method_10(Class632.class339_120);
                            this.QRVY(class3.class445_0);
                            base.method_9(Class584.class342_0);
                            base.method_9(Class632.class339_258);
                            list2 = class3.QQSQ;
                        }
                        break;
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
            base.method_9(Class632.class339_119);
        }

        internal void method_331(Class406 A_1)
        {
        }

        internal void method_332(Class406 A_1)
        {
        }
    }
}

