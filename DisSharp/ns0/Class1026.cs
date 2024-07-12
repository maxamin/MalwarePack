namespace ns0
{
    using System;

    internal class Class1026
    {
        private static Class48 class48_0 = new Class48();
        private static Enum11 enum11_0;

        internal static Enum11 smethod_0(Enum11 A_0, int A_1)
        {
            switch (enum11_0)
            {
                case Enum11.const_1:
                    return Enum11.const_16;

                case Enum11.const_2:
                    return Enum11.const_17;

                case Enum11.const_3:
                    return Enum11.const_18;

                case Enum11.const_4:
                    return Enum11.const_19;

                case Enum11.const_5:
                    return Enum11.const_20;

                case Enum11.const_6:
                    return Enum11.const_21;

                case Enum11.const_7:
                    return Enum11.const_22;

                case Enum11.const_8:
                    return Enum11.const_23;

                case Enum11.const_9:
                    return Enum11.const_24;

                case Enum11.const_10:
                    return Enum11.const_25;

                case Enum11.const_11:
                    return Enum11.const_26;

                case Enum11.const_12:
                    return Enum11.const_27;

                case Enum11.const_13:
                    return Enum11.const_28;

                case Enum11.const_14:
                    return Enum11.const_29;

                case Enum11.const_41:
                    return smethod_1(A_1);
            }
            return Enum11.const_0;
        }

        private static Enum11 smethod_1(int A_0)
        {
            enum11_0 = Enum11.const_0;
            Class558.Class606 class2 = Class546.class558_0.arrayList_0[A_0] as Class558.Class606;
            class48_0.Byte_0 = class2.byte_0;
            switch (class48_0.method_8())
            {
                case 20:
                    smethod_3();
                    break;

                case 0x1d:
                    smethod_2();
                    break;
            }
            return enum11_0;
        }

        private static void smethod_2()
        {
            smethod_4();
        }

        private static void smethod_3()
        {
            smethod_4();
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
        }

        private static void smethod_4()
        {
            switch (class48_0.method_8())
            {
                case 2:
                    enum11_0 = Enum11.const_16;
                    return;

                case 3:
                    enum11_0 = Enum11.const_17;
                    return;

                case 4:
                    enum11_0 = Enum11.const_18;
                    return;

                case 5:
                    enum11_0 = Enum11.const_19;
                    return;

                case 6:
                    enum11_0 = Enum11.const_20;
                    return;

                case 7:
                    enum11_0 = Enum11.const_21;
                    return;

                case 8:
                    enum11_0 = Enum11.const_22;
                    return;

                case 9:
                    enum11_0 = Enum11.const_23;
                    return;

                case 10:
                    enum11_0 = Enum11.const_24;
                    return;

                case 11:
                    enum11_0 = Enum11.const_25;
                    return;

                case 12:
                    enum11_0 = Enum11.const_26;
                    return;

                case 13:
                    enum11_0 = Enum11.const_27;
                    return;

                case 14:
                    enum11_0 = Enum11.const_28;
                    return;

                case 15:
                case 0x10:
                case 0x13:
                case 0x15:
                case 0x17:
                case 0x1a:
                case 0x1b:
                    break;

                case 0x11:
                    smethod_5();
                    return;

                case 0x12:
                    smethod_5();
                    return;

                case 20:
                    smethod_3();
                    return;

                case 0x16:
                    enum11_0 = Enum11.const_34;
                    return;

                case 0x18:
                    enum11_0 = Enum11.const_30;
                    return;

                case 0x19:
                    enum11_0 = Enum11.const_31;
                    return;

                case 0x1c:
                    enum11_0 = Enum11.const_29;
                    return;

                case 0x1d:
                    smethod_2();
                    break;

                default:
                    return;
            }
        }

        private static void smethod_5()
        {
            int num = class48_0.method_21();
            int num2 = num & 3;
            num = num >> 2;
            switch (num2)
            {
                case 0:
                    enum11_0 = Enum11.const_36;
                    return;

                case 1:
                    enum11_0 = Enum11.const_38;
                    break;
            }
        }
    }
}

