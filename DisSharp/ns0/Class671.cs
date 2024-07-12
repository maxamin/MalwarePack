namespace ns0
{
    using System;
    using System.Collections;

    internal class Class671 : Class670
    {
        internal void method_74()
        {
            ArrayList list = base.class47_0.class26_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class26.Class908 class2 = list[i] as Class26.Class908;
                if (class2.enum0_0 == Enum0.const_4)
                {
                    Enum11 enum2 = this.method_75(class2.byte_0);
                    if (enum2 != Enum11.const_0)
                    {
                        Class549.Class530 class3 = base.class684_0.class549_0.arrayList_0[class2.int_0] as Class549.Class530;
                        Class560.Class610 class4 = new Class560.Class610 {
                            enum11_0 = class3.enum11_0,
                            int_0 = class3.int_2,
                            enum11_1 = enum2
                        };
                        this.method_76(class4, enum2, class2.int_1);
                        class3.enum11_0 = Enum11.const_43;
                        class3.int_2 = base.class684_0.class560_0.arrayList_0.Count;
                        base.class684_0.class560_0.arrayList_0.Add(class4);
                    }
                }
            }
        }

        private Enum11 method_75(byte A_1)
        {
            switch (A_1)
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

                case 0x12:
                    return Enum11.const_29;
            }
            return Enum11.const_0;
        }

        private void method_76(Class560.Class610 A_1, Enum11 A_2, int A_3)
        {
            base.class48_0.method_3(base.int_2 + A_3);
            int num = base.class48_0.method_21();
            switch (A_2)
            {
                case Enum11.const_16:
                    A_1.int_1 = base.class48_0.method_8();
                    return;

                case Enum11.const_17:
                    A_1.int_1 = base.class48_0.method_10();
                    return;

                case Enum11.const_18:
                    A_1.int_1 = base.class48_0.method_7();
                    return;

                case Enum11.const_19:
                    A_1.int_1 = base.class48_0.method_8();
                    return;

                case Enum11.const_20:
                    A_1.int_1 = base.class48_0.method_9();
                    return;

                case Enum11.const_21:
                    A_1.int_1 = base.class48_0.method_10();
                    return;

                case Enum11.const_22:
                    A_1.int_1 = base.class48_0.method_11();
                    return;

                case Enum11.const_23:
                {
                    Class565.Class620 class2 = new Class565.Class620 {
                        uint_0 = base.class48_0.method_14()
                    };
                    A_1.int_1 = base.class684_0.class565_0.arrayList_0.Count;
                    base.class684_0.class565_0.arrayList_0.Add(class2);
                    return;
                }
                case Enum11.const_24:
                {
                    Class566.Class621 class3 = new Class566.Class621 {
                        long_0 = base.class48_0.method_15()
                    };
                    A_1.int_1 = base.class684_0.class566_0.arrayList_0.Count;
                    base.class684_0.class566_0.arrayList_0.Add(class3);
                    return;
                }
                case Enum11.const_25:
                {
                    Class567.Class622 class4 = new Class567.Class622 {
                        ulong_0 = base.class48_0.method_16()
                    };
                    A_1.int_1 = base.class684_0.class567_0.arrayList_0.Count;
                    base.class684_0.class567_0.arrayList_0.Add(class4);
                    return;
                }
                case Enum11.const_26:
                {
                    Class571.Class628 class5 = new Class571.Class628 {
                        float_0 = base.class48_0.method_17()
                    };
                    A_1.int_1 = base.class684_0.class571_0.arrayList_0.Count;
                    base.class684_0.class571_0.arrayList_0.Add(class5);
                    return;
                }
                case Enum11.const_27:
                {
                    Class572.Class629 class6 = new Class572.Class629 {
                        double_0 = base.class48_0.method_18()
                    };
                    A_1.int_1 = base.class684_0.class572_0.arrayList_0.Count;
                    base.class684_0.class572_0.arrayList_0.Add(class6);
                    return;
                }
                case Enum11.const_28:
                    A_1.int_1 = base.class581_0.method_0(base.class48_0.method_24(num));
                    return;

                case Enum11.const_29:
                    A_1.int_1 = 0;
                    return;
            }
        }
    }
}

