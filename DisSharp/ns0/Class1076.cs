namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1076
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
                if (class2.Type == Enum26.const_19)
                {
                    Class419 class3 = class2 as Class419;
                    Class428 class4 = class3.class398_0 as Class428;
                    if ((class4 != null) && (class4.class445_0 == null))
                    {
                        Class858.smethod_5(class3, false, true);
                        class4.method_1(class3);
                        Class418 class5 = new Class418(class3.class445_0);
                        class5.QQSR(new Class428());
                        A_0[i] = class5;
                        continue;
                    }
                }
                ArrayList qQSQ = class2.QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }
    }
}

