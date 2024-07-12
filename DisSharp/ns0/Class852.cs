namespace ns0
{
    using System;
    using System.Collections;

    internal class Class852
    {
        private static bool bool_0 = false;
        private static byte[] byte_0 = Class542.Byte_35;
        private static Class445 class445_0;
        private static int[] int_0 = new int[4];
        private static int[] int_1 = new int[4];
        private static int[] int_2 = new int[6];
        private static int int_3;
        private static Stack stack_0 = new Stack(40);

        static Class852()
        {
            int startIndex = 0;
            for (int i = 0; i < 4; i++)
            {
                int_0[i] = BitConverter.ToInt32(byte_0, startIndex);
                startIndex += 4;
                int_1[i] = BitConverter.ToInt32(byte_0, startIndex);
                startIndex += 4;
            }
            int num3 = 1;
            for (int j = 0; j < 6; j++)
            {
                int_2[j] = num3;
                num3 *= j + 3;
            }
            bool_0 = true;
        }

        internal static int smethod_0()
        {
            bool flag = false;
            if (bool_0 && (Class853.int_1 <= 6))
            {
                Class854.smethod_7();
                flag = true;
                smethod_1();
                if (smethod_3())
                {
                    Class855.smethod_0(class445_0);
                    return -1;
                }
            }
            if (!flag)
            {
                Class854.smethod_7();
            }
            class445_0 = Class856.smethod_0(false);
            if (class445_0 != null)
            {
                Class855.smethod_0(class445_0);
                return -1;
            }
            return Class853.int_1;
        }

        private static void smethod_1()
        {
            int_3 = int_0[Class853.int_1 - 3];
            for (int i = 0; i < (Class853.int_1 - 1); i++)
            {
                int num2;
                Struct5 struct2 = Class853.struct5_0[i];
                switch (struct2.enum47_0)
                {
                    case Enum47.const_0:
                        num2 = ((struct2.int_0 - i) - 1) + 2;
                        break;

                    case Enum47.const_1:
                        num2 = 0;
                        break;

                    case Enum47.const_2:
                        num2 = 1;
                        break;

                    default:
                        num2 = -1;
                        throw new Exception5();
                }
                smethod_2(int_2[(Class853.int_1 - i) - 2] * num2);
            }
        }

        private static void smethod_2(int A_0)
        {
            for (int i = 0; i < A_0; i++)
            {
                if (byte_0[int_3] != 0)
                {
                    byte num2;
                    do
                    {
                        int_3++;
                        num2 = byte_0[int_3];
                    }
                    while (num2 != 7);
                }
                int_3++;
            }
        }

        private static bool smethod_3()
        {
            if (byte_0[int_3] == 0)
    {
        return false;
    }
    Class419 class2 = null;
    Class465 class3 = new Class465();
    int index = 0;
    while (true)
    {
        byte num = byte_0[int_3];
        byte num3 = num;
        switch (num3)
        {
            case 1:
                stack_0.Push(class3);
                class3 = new Class465();
                break;

            case 2:
                smethod_4(stack_0.Pop() as Class465, class3);
                break;

            case 3:
                class3.enum1_0 = Enum1.const_8;
                break;

            case 4:
                class3.enum1_0 = Enum1.const_1;
                break;

            case 5:
                class2 = Class853.struct5_0[index].class419_0;
                Class858.smethod_5(class2, false, true);
                smethod_4(class3, class2.class445_0);
                index++;
                break;

            case 6:
                class2 = Class853.struct5_0[index].class419_0;
                Class858.smethod_5(class2, true, false);
                smethod_4(class3, class2.class445_0);
                index++;
                break;

            case 7:
                break;

            default:
                throw new Exception5();
        }
        int_3++;
        if (num == 7)
        {
            class445_0 = class3;
            return true;
        }
    }

        }

        private static void smethod_4(Class465 A_0, Class445 A_1)
        {
            Class445[] classArray = A_0.class445_0;
            if (classArray == null)
            {
                classArray = new Class445[] { A_1 };
                A_0.class445_0 = classArray;
            }
            else
            {
                Class445[] classArray2 = new Class445[classArray.Length + 1];
                for (int i = 0; i < classArray.Length; i++)
                {
                    classArray2[i] = classArray[i];
                }
                classArray2[classArray.Length] = A_1;
                A_0.class445_0 = classArray2;
            }
        }
    }
}

