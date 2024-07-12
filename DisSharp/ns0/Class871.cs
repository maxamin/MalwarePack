namespace ns0
{
    using System;
    using System.Collections;

    internal class Class871
    {
        private static ArrayList arrayList_0 = new ArrayList();
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
                if (!flag || (num >= 0x19))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < (A_0.Count - 1); i++)
            {
                Class398 class2 = A_0[i] as Class398;
                Class399 class3 = class2 as Class399;
                if (class3 != null)
                {
                    Class452 class4 = class3.class445_0 as Class452;
                    if (class4 != null)
                    {
                        smethod_2(class4, class3, A_0, i);
                        int count = arrayList_0.Count;
                        if (count > 1)
                        {
                            Class445[] classArray = new Class445[count];
                            for (int k = 0; k < count; k++)
                            {
                                classArray[k] = arrayList_0[k] as Class445;
                            }
                            Class400 class5 = new Class400(classArray, class3.class445_1);
                            Class689.smethod_2(A_0, i, count);
                            A_0.Insert(i, class5);
                            bool_0 = true;
                            return;
                        }
                    }
                }
            }
            for (int j = 0; j < A_0.Count; j++)
            {
                ArrayList qQSQ = (A_0[j] as Class398).QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private static void smethod_2(Class452 A_0, Class399 A_1, ArrayList A_2, int A_3)
        {
            arrayList_0.Clear();
            arrayList_0.Add(A_0);
            Class445 class2 = A_1.class445_1;
            Enum11 enum2 = Class525.enum11_0[A_0.ushort_0];
            int num = Class525.int_2[A_0.ushort_0];
            for (int i = A_3 + 1; i < A_2.Count; i++)
            {
                Class399 class3 = A_2[i] as Class399;
                if (class3 == null)
                {
                    return;
                }
                Class452 class4 = class3.class445_0 as Class452;
                if (class4 == null)
                {
                    return;
                }
                if ((Class525.enum11_0[class4.ushort_0] != enum2) || (Class525.int_2[class4.ushort_0] != num))
                {
                    return;
                }
                if (!class2.method_0(class3.class445_1))
                {
                    return;
                }
                arrayList_0.Add(class4);
            }
        }
    }
}

