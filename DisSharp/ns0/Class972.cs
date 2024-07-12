namespace ns0
{
    using System;

    internal class Class972
    {
        private static bool bool_0;
        private static Enum46 enum46_0;

        internal static int smethod_0(int A_0, Class398 A_1)
        {
            Class973.int_0 = A_0;
            smethod_1(A_0, A_1);
            Class853.smethod_3();
            if (Class974.smethod_3())
            {
                return Class853.int_1;
            }
            if (Class853.int_1 == 1)
            {
                Class975.smethod_0();
                return -1;
            }
            Class854.smethod_5();
            if (bool_0)
            {
                return Class976.smethod_0();
            }
            return smethod_2();
        }

        private static void smethod_1(int A_0, Class398 A_1)
        {
            Class398 class2 = A_1;
            Class398 class3 = null;
            int num = Class973.int_0;
            enum46_0 = Enum46.const_0;
            Class853.smethod_0();
            bool_0 = false;
            while (class2.Type == Enum26.const_19)
            {
                Class419 class4 = class2 as Class419;
                Class853.smethod_1(class4);
                bool_0 = bool_0 || !Class858.smethod_7(class4.class398_0);
                switch (enum46_0)
                {
                    case Enum46.const_0:
                        class3 = class4.class398_0;
                        enum46_0 = Enum46.const_1;
                        goto Label_009C;

                    case Enum46.const_1:
                        if (class4.class398_0 != class3)
                        {
                            if (!Class858.smethod_7(class3))
                            {
                                break;
                            }
                            enum46_0 = Enum46.const_2;
                        }
                        goto Label_009C;

                    case Enum46.const_2:
                        enum46_0 = Enum46.const_3;
                        goto Label_009C;

                    default:
                        goto Label_009C;
                }
                enum46_0 = Enum46.const_3;
            Label_009C:
                num++;
                class2 = Class973.arrayList_0[num] as Class398;
            }
            Class973.class398_0 = class2;
        }

        private static int smethod_2()
        {
            if (Class854.int_0 != 2)
            {
                return Class978.smethod_0();
            }
            switch (enum46_0)
            {
                case Enum46.const_1:
                    Class977.smethod_0();
                    return -1;

                case Enum46.const_2:
                    Class977.smethod_1();
                    return -1;

                case Enum46.const_3:
                    return Class852.smethod_0();
            }
            throw new Exception1();
        }
    }
}

