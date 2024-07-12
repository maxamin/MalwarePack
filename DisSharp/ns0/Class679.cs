namespace ns0
{
    using System;
    using System.Collections;

    internal class Class679 : Class678
    {
        private static string string_86 = Class537.string_467;

        internal void method_142()
        {
            this.method_143();
            this.method_146();
        }

        private void method_143()
        {
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class548.Class529 class2 = list[i] as Class548.Class529;
                try
                {
                    if (class2.class369_0.QQUQ)
                    {
                        class2.ushort_17 = (ushort) (class2.ushort_17 | 0x1000);
                        this.method_145(class2);
                    }
                    else if (class2.class369_0.QQTZ)
                    {
                        class2.ushort_17 = (ushort) (class2.ushort_17 | 0x2000);
                        this.method_144(class2);
                    }
                }
                catch
                {
                }
            }
        }

        private void method_144(Class548.Class529 A_1)
        {
            Class619 class2 = A_1.class369_0.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                if (class2[i].Name == string_86)
                {
                    (A_1.class369_0 as Class370).byte_0 = (byte) i;
                    (class2[i] as Class391).class528_0.enum25_0 = Enum25.const_3;
                    return;
                }
            }
        }

        private void method_145(Class548.Class529 A_1)
        {
            Class560.Class610 class2;
            Class370 class3 = A_1.class369_0 as Class370;
            Class619 class4 = A_1.class369_0.class619_0;
            bool flag = true;
            for (int i = 0; i < class4.Int32_0; i++)
            {
                Class385 class5 = class4[i] as Class385;
                if (class5.class530_0.enum11_0 == Enum11.const_43)
                {
                    class2 = base.class684_0.class560_0.arrayList_0[class5.class530_0.int_2] as Class560.Class610;
                    if (class2.int_1 != i)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag)
            {
                A_1.ushort_17 = (ushort) (A_1.ushort_17 | 0x4000);
                class3.byte_0 = (byte) (class3.byte_0 | 1);
            }
            Class549.Class530 class6 = (A_1.class369_0.class619_0[0] as Class385).class530_0;
            if (class6.enum11_0 == Enum11.const_43)
            {
                class2 = base.class684_0.class560_0.arrayList_0[class6.int_2] as Class560.Class610;
                switch (class2.enum11_1)
                {
                    case Enum11.const_18:
                        class3.byte_0 = (byte) (class3.byte_0 | 4);
                        return;

                    case Enum11.const_19:
                        class3.byte_0 = (byte) (class3.byte_0 | 2);
                        return;

                    case Enum11.const_20:
                        class3.byte_0 = (byte) (class3.byte_0 | 8);
                        return;

                    case Enum11.const_21:
                        class3.byte_0 = (byte) (class3.byte_0 | 0x10);
                        return;

                    case Enum11.const_22:
                        return;

                    case Enum11.const_23:
                        class3.byte_0 = (byte) (class3.byte_0 | 0x20);
                        return;

                    case Enum11.const_24:
                        class3.byte_0 = (byte) (class3.byte_0 | 0x40);
                        return;

                    case Enum11.const_25:
                        class3.byte_0 = (byte) (class3.byte_0 | 0x80);
                        return;
                }
            }
        }

        private void method_146()
        {
            if (base.class684_0.class548_0.arrayList_0.Count > 0x3e8)
            {
                int num = base.class394_0.int_1;
                if (num != 0)
                {
                    Class547.Class528 class2 = base.class684_0.class547_0.arrayList_0[num] as Class547.Class528;
                    Class379 class3 = class2.class369_0.class369_0 as Class379;
                    if ((class3 != null) && (class3.class619_0.Int32_0 > 1))
                    {
                        Class385 class4 = class3.class619_0[0] as Class385;
                        if ((class4.class530_0.enum11_0 == Enum11.const_9) && !(class3.class619_0[1] is Class385))
                        {
                            throw new Exception8();
                        }
                    }
                }
            }
        }
    }
}

