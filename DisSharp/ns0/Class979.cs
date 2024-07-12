namespace ns0
{
    using System;
    using System.Runtime.InteropServices;

    internal class Class979
    {
        internal static bool bool_0;
        private static int[] int_0 = new int[40];
        private static int[] int_1 = new int[40];
        private static int int_2 = 40;
        private static int int_3;
        private static int int_4;
        private static int int_5 = 100;
        private static Struct11[] struct11_0 = new Struct11[100];

        internal static void smethod_0()
        {
            smethod_4();
            int_3 = 0;
            int_4 = 1;
        }

        internal static void smethod_1()
        {
            if (int_3 == int_2)
            {
                int num = int_2 * 2;
                int[] numArray = new int[num];
                int[] numArray2 = new int[num];
                for (int i = 0; i < int_3; i++)
                {
                    numArray[i] = int_1[i];
                    numArray2[i] = int_0[i];
                }
                int_1 = numArray;
                int_0 = numArray2;
                int_2 = num;
            }
            int_1[int_3] = int_4;
            int_3++;
            int_4++;
        }

        internal static int smethod_10(int A_0)
        {
            return struct11_0[A_0].int_2;
        }

        internal static void smethod_11()
        {
            if (Class981.bool_6)
            {
                for (int i = 0; i < Class525.int_1; i++)
                {
                    switch (struct11_0[i].enum63_0)
                    {
                        case Enum63.const_1:
                        case Enum63.const_2:
                        {
                            Class525.bool_1[i] = true;
                            Class492 class2 = new Class492(Class525.enum11_0[i], Class525.int_2[i], Class525.byte_0[i], (ushort) i);
                            Class399 class3 = struct11_0[i].class399_0;
                            if (class3 != null)
                            {
                                class3.class445_0 = class2;
                            }
                            else
                            {
                                struct11_0[i].class462_0.class445_0 = class2;
                            }
                            break;
                        }
                    }
                }
            }
        }

        internal static void smethod_2()
        {
            int_3--;
        }

        internal static void smethod_3(int A_0)
        {
            int_0[int_3 - 1] = A_0;
        }

        private static void smethod_4()
        {
            int num = Class525.int_1;
            if (num > int_5)
            {
                struct11_0 = new Struct11[num];
                int_5 = num;
            }
            for (int i = 0; i < num; i++)
            {
                struct11_0[i].enum63_0 = Enum63.const_0;
                struct11_0[i].int_2 = 0;
            }
        }

        internal static void smethod_5(Class399 A_0, Class452 A_1)
        {
            int index = A_1.ushort_0;
            A_1.bool_0 = false;
            switch (struct11_0[index].enum63_0)
            {
                case Enum63.const_0:
                    struct11_0[index].enum63_0 = Enum63.const_1;
                    struct11_0[index].class399_0 = A_0;
                    struct11_0[index].class462_0 = null;
                    struct11_0[index].int_0 = int_1[int_3 - 1];
                    struct11_0[index].int_1 = Class1021.int_0;
                    return;

                case Enum63.const_1:
                    smethod_8(index);
                    return;

                case Enum63.const_2:
                    smethod_9(index);
                    break;

                case Enum63.const_3:
                    break;

                default:
                    return;
            }
        }

        internal static void smethod_6(Class462 A_0, Class452 A_1)
        {
            int index = A_1.ushort_0;
            A_1.bool_0 = false;
            switch (struct11_0[index].enum63_0)
            {
                case Enum63.const_0:
                    struct11_0[index].enum63_0 = Enum63.const_2;
                    struct11_0[index].class399_0 = null;
                    struct11_0[index].class462_0 = A_0;
                    struct11_0[index].int_0 = int_1[int_3 - 1];
                    struct11_0[index].int_1 = Class1021.int_0;
                    return;

                case Enum63.const_1:
                    smethod_8(index);
                    return;

                case Enum63.const_2:
                    smethod_9(index);
                    break;

                case Enum63.const_3:
                    break;

                default:
                    return;
            }
        }

        internal static void smethod_7(int A_0)
        {
            struct11_0[A_0].int_2++;
            switch (struct11_0[A_0].enum63_0)
            {
                case Enum63.const_0:
                    struct11_0[A_0].enum63_0 = Enum63.const_3;
                    return;

                case Enum63.const_1:
                    smethod_8(A_0);
                    return;

                case Enum63.const_2:
                    smethod_9(A_0);
                    break;

                case Enum63.const_3:
                    break;

                default:
                    return;
            }
        }

        private static void smethod_8(int A_0)
        {
            int num = struct11_0[A_0].int_0;
            for (int i = 0; i < int_3; i++)
            {
                if ((int_1[i] == num) && (struct11_0[A_0].int_1 <= int_0[i]))
                {
                    return;
                }
            }
            struct11_0[A_0].enum63_0 = Enum63.const_3;
        }

        private static void smethod_9(int A_0)
        {
            int num = struct11_0[A_0].int_0;
            for (int i = 0; i < int_3; i++)
            {
                if ((int_1[i] == num) && (struct11_0[A_0].int_1 == int_0[i]))
                {
                    return;
                }
            }
            struct11_0[A_0].enum63_0 = Enum63.const_3;
        }

        private enum Enum63
        {
            const_0,
            const_1,
            const_2,
            const_3
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct11
        {
            internal Class979.Enum63 enum63_0;
            internal Class399 class399_0;
            internal Class462 class462_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
        }
    }
}

