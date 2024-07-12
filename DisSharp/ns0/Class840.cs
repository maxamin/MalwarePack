namespace ns0
{
    using System;

    internal class Class840
    {
        private static Class48 class48_0 = new Class48();

        internal static uint smethod_0(uint A_0)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_0 & -16777216) >> 0x18));
            if (enum2 != Enum0.const_27)
            {
                return A_0;
            }
            int num = ((int) A_0) & 0xffffff;
            class48_0.Byte_0 = (Class546.class557_0.arrayList_0[num] as Class557.Class605).byte_0;
            try
            {
                if (class48_0.method_8() == 0x12)
                {
                    int num3 = class48_0.method_21();
                    int num4 = num3 & 3;
                    int num5 = num3 >> 2;
                    switch (num4)
                    {
                        case 0:
                            return Class689.smethod_1(2, num5);

                        case 1:
                            return Class689.smethod_1(1, num5);

                        case 2:
                            return A_0;
                    }
                }
                return A_0;
            }
            catch
            {
                return A_0;
            }
        }
    }
}

