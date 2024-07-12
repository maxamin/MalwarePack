namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1083
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
                if (!flag || (num >= 250))
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
                Class493 class3 = null;
                int num2 = 0;
                Class445 class4 = null;
                Class399 class5 = class2 as Class399;
                if (class5 != null)
                {
                    class3 = class5.class445_1 as Class493;
                    if (class3 != null)
                    {
                        Class447 class6 = class3.class445_0 as Class447;
                        if (class6 != null)
                        {
                            num2 = class6.int_0;
                            switch (class5.class445_0.Type)
                            {
                                case Enum17.const_36:
                                {
                                    Class484 class8 = class5.class445_0 as Class484;
                                    if (smethod_3(A_0, i + 1, class8.uint_0, num2))
                                    {
                                        class4 = class8;
                                    }
                                    break;
                                }
                                case Enum17.const_44:
                                {
                                    Class452 class7 = class5.class445_0 as Class452;
                                    if (smethod_2(A_0, i + 1, class7.ushort_0, num2))
                                    {
                                        class4 = class7;
                                    }
                                    break;
                                }
                                case Enum17.const_55:
                                {
                                    Class501 class9 = class5.class445_0 as Class501;
                                    if (smethod_4(A_0, i + 1, class9.uint_0, num2))
                                    {
                                        class4 = class9;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                if (class4 != null)
                {
                    Class445[] classArray = new Class445[num2];
                    for (int k = 0; k < num2; k++)
                    {
                        classArray[k] = arrayList_0[k] as Class445;
                    }
                    Class482 class10 = new Class482(class3.uint_0, classArray);
                    class5.class445_1 = class10;
                    Class689.smethod_2(A_0, i + 1, num2);
                    bool_0 = true;
                    return;
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

        private static bool smethod_2(ArrayList A_0, int A_1, int A_2, int A_3)
        {
            if (((A_1 + A_3) - 1) > A_0.Count)
            {
                return false;
            }
            arrayList_0.Clear();
            for (int i = 0; i < A_3; i++)
            {
                Class399 class2 = A_0[A_1 + i] as Class399;
                if (class2 == null)
                {
                    return false;
                }
                Class458 class3 = class2.class445_0 as Class458;
                if (class3 == null)
                {
                    return false;
                }
                Class452 class4 = class3.class445_0 as Class452;
                if (class4 == null)
                {
                    return false;
                }
                if (class4.ushort_0 != A_2)
                {
                    return false;
                }
                Class447 class5 = class3.class445_1 as Class447;
                if (class5 == null)
                {
                    return false;
                }
                if (class5.int_0 != i)
                {
                    return false;
                }
                arrayList_0.Add(class2.class445_1);
            }
            return true;
        }

        private static bool smethod_3(ArrayList A_0, int A_1, uint A_2, int A_3)
        {
            if (((A_1 + A_3) - 1) > A_0.Count)
            {
                return false;
            }
            arrayList_0.Clear();
            for (int i = 0; i < A_3; i++)
            {
                Class399 class2 = A_0[A_1 + i] as Class399;
                if (class2 == null)
                {
                    return false;
                }
                Class458 class3 = class2.class445_0 as Class458;
                if (class3 == null)
                {
                    return false;
                }
                Class484 class4 = class3.class445_0 as Class484;
                if (class4 == null)
                {
                    return false;
                }
                if (class4.uint_0 != A_2)
                {
                    return false;
                }
                Class447 class5 = class3.class445_1 as Class447;
                if (class5 == null)
                {
                    return false;
                }
                if (class5.int_0 != i)
                {
                    return false;
                }
                arrayList_0.Add(class2.class445_1);
            }
            return true;
        }

        private static bool smethod_4(ArrayList A_0, int A_1, uint A_2, int A_3)
        {
            if (((A_1 + A_3) - 1) > A_0.Count)
            {
                return false;
            }
            arrayList_0.Clear();
            for (int i = 0; i < A_3; i++)
            {
                Class399 class2 = A_0[A_1 + i] as Class399;
                if (class2 == null)
                {
                    return false;
                }
                Class458 class3 = class2.class445_0 as Class458;
                if (class3 == null)
                {
                    return false;
                }
                Class501 class4 = class3.class445_0 as Class501;
                if (class4 == null)
                {
                    return false;
                }
                if (class4.uint_0 != A_2)
                {
                    return false;
                }
                Class447 class5 = class3.class445_1 as Class447;
                if (class5 == null)
                {
                    return false;
                }
                if (class5.int_0 != i)
                {
                    return false;
                }
                arrayList_0.Add(class2.class445_1);
            }
            return true;
        }
    }
}

