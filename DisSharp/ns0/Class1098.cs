namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1098
    {
        private static Class445[] class445_0;

        internal static bool smethod_0(Class552.Class545 A_0, Class445[] A_1)
        {
            if (A_0.short_0 == A_1.Length)
            {
                switch (A_0.short_0)
                {
                    case 1:
                        return smethod_2(A_0, A_1);

                    case 2:
                        return smethod_1(A_0, 2, A_1);

                    case 3:
                        return smethod_1(A_0, 3, A_1);

                    case 4:
                        return smethod_1(A_0, 4, A_1);
                }
            }
            return false;
        }

        private static bool smethod_1(Class552.Class545 A_0, int A_1, Class445[] A_2)
        {
            ArrayList list = Class546.class569_0.arrayList_0;
            int num = A_0.int_3;
            for (int i = 0; i < A_1; i++)
            {
                Class569.Class624 class2 = list[num + i] as Class569.Class624;
                if (class2.enum11_0 != Enum11.const_28)
                {
                    return false;
                }
            }
            if (A_1 == 2)
            {
                Class1025.class445_0 = new Class463(A_2[1], A_2[0], Enum1.const_0);
            }
            else
            {
                Class1025.class445_0 = new Class465(Enum1.const_0, A_2);
            }
            return true;
        }

        private static bool smethod_2(Class552.Class545 A_0, Class445[] A_1)
        {
            Class452 class2 = null;
            Class569.Class624 class3 = Class546.class569_0.arrayList_0[A_0.int_3] as Class569.Class624;
            if (class3.enum11_0 == Enum11.const_13)
            {
                class2 = A_1[0] as Class452;
                if (class2 == null)
                {
                    return false;
                }
                if (Class525.enum11_0[class2.ushort_0] != Enum11.const_13)
                {
                    return false;
                }
            }
            else
            {
                if (class3.enum11_0 != Enum11.const_14)
                {
                    return false;
                }
                class2 = A_1[0] as Class452;
                if (class2 == null)
                {
                    return false;
                }
                if (Class525.enum11_0[class2.ushort_0] != Enum11.const_14)
                {
                    return false;
                }
            }
            bool flag = false;
            for (int i = Class1021.int_0 - 1; i >= 0; i--)
            {
                if (smethod_3(i, class2.ushort_0))
                {
                    Class1021.arrayList_1.Add(Class1021.arrayList_0[i]);
                    Class525.bool_1[class2.ushort_0] = true;
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Class1025.class445_0 = new Class465(Enum1.const_0, class445_0);
                return true;
            }
            return false;
        }

        private static bool smethod_3(int A_0, int A_1)
        {
            Class399 class2 = Class1021.arrayList_0[A_0] as Class399;
            if (class2 == null)
            {
                return false;
            }
            Class452 class3 = class2.class445_0 as Class452;
            if (class3 == null)
            {
                return false;
            }
            if (class3.ushort_0 != A_1)
            {
                return false;
            }
            Class482 class4 = class2.class445_1 as Class482;
            if (class4 == null)
            {
                return false;
            }
            class445_0 = class4.class445_0;
            return true;
        }
    }
}

