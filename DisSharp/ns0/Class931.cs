namespace ns0
{
    using System;
    using System.Collections;

    internal class Class931
    {
        private static Class445 class445_0;

        internal static Class445 smethod_0(ArrayList A_0, int A_1, int A_2)
        {
            Class419 class2;
            if (A_2 == 1)
            {
                class2 = A_0[A_1] as Class419;
                Class858.smethod_6(class2, false, true, false);
                return class2.class445_0;
            }
            Class398 class3 = null;
            Enum46 enum2 = Enum46.const_0;
            Class853.smethod_0();
            for (int i = 0; i < A_2; i++)
            {
                class2 = A_0[A_1 + i] as Class419;
                Class853.smethod_1(class2);
                switch (enum2)
                {
                    case Enum46.const_0:
                        class3 = class2.class398_0;
                        enum2 = Enum46.const_1;
                        break;

                    case Enum46.const_1:
                        if (class2.class398_0 != class3)
                        {
                            enum2 = Enum46.const_2;
                        }
                        break;

                    case Enum46.const_2:
                        enum2 = Enum46.const_3;
                        break;
                }
            }
            switch (enum2)
            {
                case Enum46.const_1:
                    smethod_1();
                    break;

                case Enum46.const_2:
                    smethod_2();
                    break;

                case Enum46.const_3:
                    smethod_3(A_0[A_1 + A_2] as Class398);
                    break;

                default:
                    throw new Exception1();
            }
            return class445_0;
        }

        private static void smethod_1()
        {
            Class445[] classArray = new Class445[Class853.int_1];
            for (int i = 0; i < Class853.int_1; i++)
            {
                Class858.smethod_6(Class853.struct5_0[i].class419_0, false, true, false);
                classArray[i] = Class853.struct5_0[i].class419_0.class445_0;
            }
            class445_0 = new Class465(Enum1.const_8, classArray);
        }

        private static void smethod_2()
        {
            Class445[] classArray = new Class445[Class853.int_1];
            for (int i = 0; i < (Class853.int_1 - 1); i++)
            {
                Class858.smethod_6(Class853.struct5_0[i].class419_0, true, false, false);
                classArray[i] = Class853.struct5_0[i].class419_0.class445_0;
            }
            Class858.smethod_6(Class853.struct5_0[Class853.int_1 - 1].class419_0, false, true, false);
            classArray[Class853.int_1 - 1] = Class853.struct5_0[Class853.int_1 - 1].class419_0.class445_0;
            class445_0 = new Class465(Enum1.const_1, classArray);
        }

        private static void smethod_3(Class398 A_0)
        {
            smethod_4(A_0);
            class445_0 = Class856.smethod_1(true);
        }

        private static void smethod_4(Class398 A_0)
        {
            for (int i = 0; i < Class853.int_1; i++)
            {
                Class398 class2 = Class853.struct5_0[i].class398_0;
                bool flag = true;
                int index = i + 1;
                while (index < Class853.int_1)
                {
                    if (class2 == Class853.struct5_0[index].class419_0)
                    {
                        goto Label_0043;
                    }
                    index++;
                }
                goto Label_0067;
            Label_0043:
                Class853.struct5_0[i].int_0 = index;
                Class853.struct5_0[i].enum47_0 = Enum47.const_0;
                flag = false;
            Label_0067:
                if (flag)
                {
                    if (class2 == A_0)
                    {
                        Class853.struct5_0[i].enum47_0 = Enum47.const_1;
                    }
                    else
                    {
                        Class853.struct5_0[i].enum47_0 = Enum47.const_2;
                    }
                }
            }
        }
    }
}

