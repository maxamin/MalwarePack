namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1108
    {
        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0, null, false);
        }

        private static void smethod_1(ArrayList A_0, Class398 A_1, bool A_2)
        {
            Class398 class2;
            if (A_2)
            {
                class2 = A_0[A_0.Count - 1] as Class398;
            }
            else
            {
                class2 = A_1;
            }
            int count = A_0.Count;
            for (int i = 0; i < A_0.Count; i++)
            {
                ArrayList qQSQ;
                Class398 class3 = A_0[i] as Class398;
                if ((class2 != null) && (class3.Type == Enum26.const_16))
                {
                    Class417 class4 = class3 as Class417;
                    if (class4.class398_0 == class2)
                    {
                        Class408 class5 = class4.method_9();
                        class5.bool_0 = false;
                        A_0[i] = class5;
                    }
                }
                else if ((class2 != null) && (class3.Type == Enum26.const_25))
                {
                    Class425 class6 = class3 as Class425;
                    if (class6.class398_0 == class2)
                    {
                        Class408 class7 = class6.method_8();
                        class7.bool_0 = false;
                        A_0[i] = class7;
                    }
                }
                else
                {
                    qQSQ = class3.QQSQ;
                    if (qQSQ != null)
                    {
                        switch (class3.Type)
                        {
                            case Enum26.const_42:
                            case Enum26.const_43:
                            case Enum26.const_8:
                            case Enum26.const_14:
                                goto Label_00EB;
                        }
                        smethod_1(qQSQ, class2, false);
                    }
                }
                continue;
            Label_00EB:
                smethod_1(qQSQ, null, true);
            }
        }
    }
}

