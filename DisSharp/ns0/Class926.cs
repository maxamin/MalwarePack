namespace ns0
{
    using System;
    using System.Collections;

    internal class Class926
    {
        internal static void smethod_0()
        {
            if (Class519.class528_0.Boolean_23)
            {
                smethod_1();
            }
        }

        private static void smethod_1()
        {
            ArrayList list = Class536.arrayList_0;
            if (list.Count >= 2)
            {
                Class438 class2 = list[0] as Class438;
                if (class2 != null)
                {
                    Class412 class3 = list[1] as Class412;
                    if ((class3 != null) && (class3.QQSQ.Count == 1))
                    {
                        Class443 class4 = class3.QQSQ[0] as Class443;
                        if ((class4 != null) && (class4.class445_0 is Class487))
                        {
                            list.RemoveAt(0);
                            list.RemoveAt(0);
                            if (class2.QQSQ != null)
                            {
                                for (int i = 0; i < class2.QQSQ.Count; i++)
                                {
                                    list.Insert(0, class2.QQSQ[i]);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

