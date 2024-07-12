namespace ns0
{
    using System;
    using System.Collections;

    internal class Class932
    {
        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            int count = A_0.Count;
            for (int i = 0; i < A_0.Count; i++)
            {
                ArrayList list2;
                Class398 class2 = A_0[i] as Class398;
                if (class2.Type == Enum26.const_35)
                {
                    Class434 class3 = class2 as Class434;
                    ArrayList qQSQ = class3.QQSQ;
                    if ((qQSQ != null) && (qQSQ.Count > 0))
                    {
                        Class398 class4 = qQSQ[qQSQ.Count - 1] as Class398;
                        Enum26 type = class4.Type;
                        if (class3.enum29_0 == Enum29.const_4)
                        {
                            switch (type)
                            {
                                case Enum26.const_7:
                                case Enum26.const_28:
                                case Enum26.const_37:
                                    goto Label_00B5;
                            }
                            if (Class519.class528_0.enum11_0 == Enum11.const_15)
                            {
                                class3.enum29_0 = Enum29.const_3;
                            }
                            else
                            {
                                class3.enum29_0 = Enum29.const_2;
                            }
                        }
                        else
                        {
                            switch (type)
                            {
                                case Enum26.const_28:
                                case Enum26.const_37:
                                    class3.enum29_0 = Enum29.const_4;
                                    break;
                            }
                        }
                    }
                }
            Label_00B5:
                list2 = class2.QQSQ;
                if (list2 != null)
                {
                    smethod_1(list2);
                }
            }
        }
    }
}

