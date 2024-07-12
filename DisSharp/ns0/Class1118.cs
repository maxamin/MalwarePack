namespace ns0
{
    using System;

    internal class Class1118
    {
        private static Class48 class48_0 = new Class48();
        private static int int_0;

        internal static Class658 smethod_0(int A_0)
        {
            Class658 class2 = Class658.smethod_1();
            Class558.Class606 class3 = Class546.class558_0.arrayList_0[A_0] as Class558.Class606;
            class48_0.Byte_0 = class3.byte_0;
            switch (class48_0.method_8())
            {
                case 20:
                    class2.enum11_0 = smethod_2();
                    class2.int_0 = int_0;
                    return class2;

                case 0x1d:
                    class2.enum11_0 = smethod_1();
                    class2.int_0 = int_0;
                    return class2;
            }
            class2.enum11_0 = Enum11.const_15;
            return class2;
        }

        private static Enum11 smethod_1()
        {
            return smethod_3();
        }

        private static Enum11 smethod_2()
        {
            Enum11 enum2 = smethod_3();
            class48_0.method_21();
            int num = class48_0.method_21();
            for (int i = 0; i < num; i++)
            {
                class48_0.method_21();
            }
            int num3 = class48_0.method_21();
            for (int j = 0; j < num3; j++)
            {
                class48_0.method_21();
            }
            return enum2;
        }

        private static Enum11 smethod_3()
        {
            switch (class48_0.method_8())
            {
                case 2:
                    return Enum11.const_16;

                case 3:
                    return Enum11.const_17;

                case 4:
                    return Enum11.const_18;

                case 5:
                    return Enum11.const_19;

                case 6:
                    return Enum11.const_20;

                case 7:
                    return Enum11.const_21;

                case 8:
                    return Enum11.const_22;

                case 9:
                    return Enum11.const_23;

                case 10:
                    return Enum11.const_24;

                case 11:
                    return Enum11.const_25;

                case 12:
                    return Enum11.const_26;

                case 13:
                    return Enum11.const_27;

                case 14:
                    return Enum11.const_28;

                case 0x11:
                    return smethod_4();

                case 0x12:
                    return smethod_4();

                case 20:
                    return smethod_2();

                case 0x16:
                    return Enum11.const_34;

                case 0x18:
                    return Enum11.const_30;

                case 0x19:
                    return Enum11.const_31;

                case 0x1c:
                    return Enum11.const_29;

                case 0x1d:
                    return smethod_1();
            }
            return Enum11.const_15;
        }

        private static Enum11 smethod_4()
        {
            int num = class48_0.method_21();
            int num2 = num & 3;
            num = num >> 2;
            switch (num2)
            {
                case 0:
                    int_0 = num;
                    return Enum11.const_36;

                case 1:
                    int_0 = num;
                    return Enum11.const_38;
            }
            return Enum11.const_15;
        }
    }
}

