namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1055
    {
        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                Class399 class3 = class2 as Class399;
                if (class3 != null)
                {
                    if (class3.class445_1.Type == Enum17.const_9)
                    {
                        Class463 class4 = class3.class445_1 as Class463;
                        Class445 class5 = class4.class445_0;
                        if (class3.class445_0.method_0(class5))
                        {
                            Class445 class6 = class4.class445_1;
                            if (class6.Type == Enum17.const_22)
                            {
                                Class447 class7 = class6 as Class447;
                                if (class7.int_0 == 1)
                                {
                                    Class398 class8 = null;
                                    switch (class4.enum1_0)
                                    {
                                        case Enum1.const_0:
                                            class8 = new Class443(new Class480(class3.class445_0));
                                            Class689.smethod_5(class3, class8);
                                            break;

                                        case Enum1.const_11:
                                            class8 = new Class443(new Class477(class3.class445_0));
                                            Class689.smethod_5(class3, class8);
                                            break;
                                    }
                                    if (class8 != null)
                                    {
                                        A_0[i] = class8;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    ArrayList qQSQ = class2.QQSQ;
                    if (qQSQ != null)
                    {
                        smethod_1(qQSQ);
                    }
                }
            }
        }
    }
}

