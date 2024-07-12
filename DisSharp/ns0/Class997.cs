namespace ns0
{
    using System;
    using System.Collections;

    internal class Class997
    {
        private static ushort ushort_0;

        internal static void smethod_0()
        {
            ushort_0 = 0;
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            int num = A_0.Count - 1;
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (class2.bool_0 && (i < num))
                {
                    Class417 class3 = class2 as Class417;
                    if (class3 != null)
                    {
                        Class398 class4 = A_0[i + 1] as Class398;
                        if (class3.class398_0 == class4)
                        {
                            class4.method_1(class3);
                        }
                    }
                }
                if ((class2.arrayList_0 != null) && smethod_2(class2.arrayList_0))
                {
                    ushort_0 = (ushort) (ushort_0 + 1);
                    class2.ushort_0 = ushort_0;
                }
                ArrayList qQSQ = class2.QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private static bool smethod_2(ArrayList A_0)
        {
            if (A_0.Count > 0)
            {
                for (int i = 0; i < A_0.Count; i++)
                {
                    Class398 class2 = A_0[i] as Class398;
                    if (!class2.bool_0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

