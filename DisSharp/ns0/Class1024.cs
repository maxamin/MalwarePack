namespace ns0
{
    using System;

    internal class Class1024
    {
        private static Class445[] class445_0;

        internal static bool smethod_0(Class552.Class545 A_0, Class445[] A_1)
        {
            if ((A_0.enum23_0 != Enum23.const_5) && (A_0.enum23_0 != Enum23.const_6))
            {
                return false;
            }
            if (A_1.Length < 2)
            {
                return false;
            }
            if (Class821.smethod_0(A_1[0]).enum11_0 != Enum11.const_28)
            {
                return false;
            }
            return true;
        }

        internal static bool smethod_1(Class504 A_0, Class445[] A_1)
        {
            int length = A_1.Length;
            if ((length == 2) && (Class821.smethod_0(A_1[1]).enum11_0 == Enum11.const_14))
            {
                return smethod_3(A_0, A_1);
            }
            switch (length)
            {
                case 2:
                    return smethod_2(A_0, 2, A_1);

                case 3:
                    return smethod_2(A_0, 3, A_1);

                case 4:
                    return smethod_2(A_0, 4, A_1);
            }
            return false;
        }

        private static bool smethod_2(Class504 A_0, int A_1, Class445[] A_2)
        {
            for (int i = 1; i < A_1; i++)
            {
                A_2[i] = smethod_5(A_2[i]);
            }
            Class1025.class445_0 = new Class505(A_0.uint_0, A_2);
            return true;
        }

        private static bool smethod_3(Class504 A_0, Class445[] A_1)
        {
            Class452 class2 = A_1[1] as Class452;
            if (class2 == null)
            {
                return false;
            }
            if (Class525.enum11_0[class2.ushort_0] != Enum11.const_14)
            {
                return false;
            }
            bool flag = false;
            for (int i = Class1021.int_0 - 1; i >= 0; i--)
            {
                if (smethod_4(i, class2.ushort_0))
                {
                    Class1021.arrayList_1.Add(Class1021.arrayList_0[i]);
                    Class525.bool_1[class2.ushort_0] = true;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                return false;
            }
            Class445[] classArray = new Class445[class445_0.Length + 1];
            classArray[0] = A_1[0];
            for (int j = 0; j < class445_0.Length; j++)
            {
                classArray[j + 1] = smethod_5(class445_0[j]);
            }
            Class1025.class445_0 = new Class505(A_0.uint_0, classArray);
            return true;
        }

        private static bool smethod_4(int A_0, int A_1)
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

        private static Class445 smethod_5(Class445 A_0)
        {
            Class466 class2 = A_0 as Class466;
            if (class2 == null)
            {
                return A_0;
            }
            return class2.class445_0;
        }
    }
}

