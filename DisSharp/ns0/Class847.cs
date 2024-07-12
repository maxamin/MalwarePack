namespace ns0
{
    using System;
    using System.Collections;

    internal class Class847
    {
        private static Class428 class428_0;

        internal static void smethod_0()
        {
            class428_0 = Class536.arrayList_0[Class536.arrayList_0.Count - 1] as Class428;
            if ((class428_0 != null) && (class428_0.arrayList_0 != null))
            {
                try
                {
                    smethod_1(Class536.arrayList_0);
                }
                catch (Exception4)
                {
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class428 class2;
                Class398 class3 = A_0[i] as Class398;
                Class417 class4 = class3 as Class417;
                if (((class4 != null) && !class4.bool_0) && (class4.class398_0 == class428_0))
                {
                    class428_0.method_1(class4);
                    class2 = new Class428(class428_0.class445_0);
                    Class689.smethod_5(class3, class2);
                    A_0[i] = class2;
                    if (class428_0.arrayList_0 == null)
                    {
                        throw new Exception4();
                    }
                }
                else
                {
                    Class425 class5 = class3 as Class425;
                    if ((class5 != null) && (class5.class398_0 == class428_0))
                    {
                        class428_0.method_1(class5);
                        class2 = new Class428(class428_0.class445_0);
                        Class689.smethod_5(class3, class2);
                        A_0[i] = class2;
                        if (class428_0.arrayList_0 == null)
                        {
                            throw new Exception4();
                        }
                    }
                }
                ArrayList qQSQ = class3.QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private class Exception4 : Exception
        {
        }
    }
}

