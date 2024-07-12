namespace ns0
{
    using System;

    internal class Class1025
    {
        internal static Class445 class445_0;

        internal static bool smethod_0(uint A_0, Class504 A_1, Class445[] A_2)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_0 & -16777216) >> 0x18));
            int num = ((int) A_0) & 0xffffff;
            Enum0 enum3 = enum2;
            if (enum3 != Enum0.const_6)
            {
                if (enum3 != Enum0.const_10)
                {
                    return false;
                }
                Class551.Class544 class4 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class4.enum9_0 != Enum9.const_2)
                {
                    return false;
                }
                Class552.Class545 class5 = Class546.class552_0.arrayList_0[class4.int_0] as Class552.Class545;
                if (class5.enum23_0 == Enum23.const_4)
                {
                    return Class1098.smethod_0(class5, A_2);
                }
                if (Class1024.smethod_0(class5, A_2))
                {
                    return Class1024.smethod_1(A_1, A_2);
                }
                if (!class5.Boolean_2)
                {
                    return false;
                }
                if (!Class904.smethod_1(Class519.class581_0[class5.int_1]))
                {
                    return false;
                }
                smethod_1(A_2, Class904.enum4_0, class5.enum11_0, class5.int_2, class5.byte_5);
                return true;
            }
            Class547.Class528 class2 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            Class383 class3 = class2.class369_0 as Class383;
            if (class3 == null)
            {
                return false;
            }
            smethod_1(A_2, class3.enum4_0, class2.enum11_0, class2.int_5, class2.byte_1);
            return true;
        }

        private static void smethod_1(Class445[] A_0, Enum4 A_1, Enum11 A_2, int A_3, byte A_4)
        {
            switch (A_1)
            {
                case Enum4.const_0:
                    class445_0 = A_0[0];
                    return;

                case Enum4.const_1:
                    class445_0 = new Class479(A_2, A_3, A_4, A_0[0]);
                    return;

                case Enum4.const_2:
                    class445_0 = new Class513(A_0[0], Enum32.const_0);
                    return;

                case Enum4.const_3:
                    class445_0 = new Class513(A_0[0], Enum32.const_1);
                    return;

                case Enum4.const_4:
                    class445_0 = new Class513(A_0[0], Enum32.const_2);
                    return;

                case Enum4.const_5:
                    class445_0 = new Class513(A_0[0], Enum32.const_3);
                    return;

                case Enum4.const_6:
                    class445_0 = new Class513(A_0[0], Enum32.const_4);
                    return;

                case Enum4.const_7:
                    class445_0 = new Class513(A_0[0], Enum32.const_5);
                    return;

                case Enum4.const_8:
                    class445_0 = A_0[0];
                    return;

                case Enum4.const_9:
                    class445_0 = new Class513(A_0[0], Enum32.const_2);
                    return;

                case Enum4.const_10:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_0);
                    return;

                case Enum4.const_11:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_11);
                    return;

                case Enum4.const_12:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_7);
                    return;

                case Enum4.const_13:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_5);
                    return;

                case Enum4.const_14:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_6);
                    return;

                case Enum4.const_15:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_2);
                    return;

                case Enum4.const_16:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_3);
                    return;

                case Enum4.const_17:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_4);
                    return;

                case Enum4.const_18:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_9);
                    return;

                case Enum4.const_19:
                    class445_0 = new Class463(A_0[1], A_0[0], Enum1.const_10);
                    return;

                case Enum4.const_20:
                    class445_0 = new Class470(A_0[1], A_0[0], Enum31.const_0);
                    return;

                case Enum4.const_21:
                    class445_0 = new Class470(A_0[1], A_0[0], Enum31.const_1);
                    return;

                case Enum4.const_22:
                    class445_0 = new Class470(A_0[1], A_0[0], Enum31.const_2);
                    return;

                case Enum4.const_23:
                    class445_0 = new Class470(A_0[1], A_0[0], Enum31.const_4);
                    return;

                case Enum4.const_24:
                    class445_0 = new Class470(A_0[1], A_0[0], Enum31.const_5);
                    return;

                case Enum4.const_25:
                    class445_0 = new Class470(A_0[1], A_0[0], Enum31.const_3);
                    return;
            }
        }
    }
}

