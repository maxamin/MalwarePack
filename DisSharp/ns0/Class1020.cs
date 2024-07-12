namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1020
    {
        private static bool bool_0;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1(Class536.arrayList_0);
                if (!bool_0)
                {
                    flag = false;
                }
                num++;
                if (!flag || (num >= 100))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                ArrayList list4;
                Class410 class2 = A_0[i] as Class410;
                if (class2 != null)
                {
                    ArrayList qQSQ = class2.QQSQ;
                    if (qQSQ.Count == 1)
                    {
                        Class418 class3 = qQSQ[0] as Class418;
                        if (class3 == null)
                        {
                            goto Label_00D5;
                        }
                        Class411 class4 = new Class411(class3.class445_0);
                        A_0[i] = class4;
                        ArrayList list2 = class3.QQSQ;
                        if ((list2 != null) && (list2.Count > 0))
                        {
                            for (int j = 0; j < list2.Count; j++)
                            {
                                class4.QQSR(list2[j] as Class398);
                            }
                            smethod_1(class4.QQSQ);
                        }
                        continue;
                    }
                    if (qQSQ.Count == 2)
                    {
                        Class418 class5 = qQSQ[0] as Class418;
                        Class410 class6 = qQSQ[1] as Class410;
                        if ((class5 != null) && (class6 != null))
                        {
                            Class411 class7 = new Class411(class5.class445_0);
                            A_0[i] = class7;
                            ArrayList list3 = class5.QQSQ;
                            if ((list3 != null) && (list3.Count > 0))
                            {
                                for (int k = 0; k < list3.Count; k++)
                                {
                                    class7.QQSR(list3[k] as Class398);
                                }
                            }
                            A_0.Insert(i + 1, class6);
                            bool_0 = true;
                            return;
                        }
                    }
                }
            Label_00D5:
                list4 = (A_0[i] as Class398).QQSQ;
                if (list4 != null)
                {
                    smethod_1(list4);
                }
            }
        }
    }
}

