namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1113
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
                if (!flag || (num >= 250))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            if (A_0.Count >= 2)
            {
                for (int i = A_0.Count - 1; i >= 2; i--)
                {
                    Class398 class2 = A_0[i] as Class398;
                    if ((class2.Type == Enum26.const_9) && smethod_2(A_0, i, class2 as Class410))
                    {
                        return;
                    }
                    ArrayList qQSQ = class2.QQSQ;
                    if (qQSQ != null)
                    {
                        smethod_1(qQSQ);
                    }
                }
            }
        }

        private static bool smethod_2(ArrayList A_0, int A_1, Class410 A_2)
        {
            Class418 class2 = A_0[A_1 - 1] as Class418;
            if (class2 == null)
            {
                return false;
            }
            Class399 class3 = A_0[A_1 - 2] as Class399;
            if (class3 == null)
            {
                return false;
            }
            ArrayList qQSQ = A_2.QQSQ;
            if (qQSQ == null)
            {
                return false;
            }
            if (qQSQ.Count == 0)
            {
                return false;
            }
            Class398 class4 = qQSQ[0] as Class398;
            if (class4.arrayList_0 == null)
            {
                return false;
            }
            if (class4.arrayList_0.Count != 1)
            {
                return false;
            }
            Class445 class5 = class3.class445_1;
            if (Class821.smethod_0(class5).enum11_0 != Enum11.const_28)
            {
                return false;
            }
            Class492 class6 = class3.class445_0 as Class492;
            if (class6 == null)
            {
                return false;
            }
            if (class6.enum11_0 != Enum11.const_28)
            {
                return false;
            }
            Class470 class7 = class2.class445_0 as Class470;
            if (class7 == null)
            {
                return false;
            }
            if (class7.enum31_0 != Enum31.const_1)
            {
                return false;
            }
            if (!class7.class445_0.method_0(class5))
            {
                return false;
            }
            if (class7.class445_1.Type != Enum17.const_50)
            {
                return false;
            }
            ArrayList list2 = class2.QQSQ;
            if (list2 == null)
            {
                return false;
            }
            if (list2.Count < 3)
            {
                return false;
            }
            Class399 class8 = list2[0] as Class399;
            if (class8 == null)
            {
                return false;
            }
            Class452 class9 = class8.class445_0 as Class452;
            if (class9 == null)
            {
                return false;
            }
            if (class9.ushort_0 != class6.ushort_0)
            {
                return false;
            }
            if (!(class8.class445_1 is Class504))
            {
                return false;
            }
            Class418 class11 = list2[1] as Class418;
            if (class11 == null)
            {
                return false;
            }
            Class470 class12 = class11.class445_0 as Class470;
            if (class12 == null)
            {
                return false;
            }
            if (class12.enum31_0 != Enum31.const_1)
            {
                return false;
            }
            Class452 class13 = class12.class445_0 as Class452;
            if (class13 == null)
            {
                return false;
            }
            if (class13.ushort_0 != class6.ushort_0)
            {
                return false;
            }
            Class473 class14 = class12.class445_1 as Class473;
            if (class14 == null)
            {
                return false;
            }
            ArrayList list3 = class11.QQSQ;
            if (list3 == null)
            {
                return false;
            }
            if (list3.Count != 1)
            {
                return false;
            }
            Class417 class15 = list3[0] as Class417;
            if (class15 == null)
            {
                return false;
            }
            if (class15.class398_0 != class4)
            {
                return false;
            }
            class4.arrayList_0 = null;
            ArrayList list4 = new ArrayList();
            Class433 class16 = new Class433(class5, list4) {
                enum28_0 = Enum28.const_1
            };
            list2.RemoveAt(0);
            list2.RemoveAt(0);
            Class434 class17 = new Class434(class16, list2, new int[] { class14.int_0 }, Enum27.const_0, Enum29.const_2, 0);
            list4.Add(class17);
            class17 = new Class434(class16, qQSQ, new int[0], Enum27.const_1, Enum29.const_2, 0);
            list4.Add(class17);
            Class689.smethod_2(A_0, A_1 - 2, 3);
            A_0.Insert(A_1 - 2, class16);
            return true;
        }
    }
}

