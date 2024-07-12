namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class76 : Class75
    {
        protected Class76()
        {
        }

        internal void method_203(uint A_1, Class445[] A_2)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            Enum0 enum3 = enum2;
            switch (enum3)
            {
                case Enum0.const_6:
                    break;

                case Enum0.const_10:
                {
                    Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class2.enum9_0 == Enum9.const_2)
                    {
                        Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                        this.method_205(class3.int_3, Class546.class569_0.arrayList_0, A_2);
                        return;
                    }
                    if (class2.enum9_0 == Enum9.const_4)
                    {
                        Class556.Class601 class4 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                        this.method_206(class4.int_5, Class546.class569_0.arrayList_0, A_2);
                        return;
                    }
                    if (class2.enum9_0 == Enum9.const_3)
                    {
                        num = class2.int_0;
                        break;
                    }
                    return;
                }
                default:
                    if (enum3 == Enum0.const_43)
                    {
                        Class573.Class534 class6 = Class546.class573_0.arrayList_0[num] as Class573.Class534;
                        Enum0 enum4 = class6.enum0_0;
                        if (enum4 != Enum0.const_6)
                        {
                            if (enum4 == Enum0.const_10)
                            {
                                Class551.Class544 class8 = Class546.class551_0.arrayList_0[class6.int_0] as Class551.Class544;
                                if (class8.enum9_0 == Enum9.const_4)
                                {
                                    Class556.Class601 class9 = Class546.class556_0.arrayList_0[class8.int_0] as Class556.Class601;
                                    this.method_206(class9.int_5, Class546.class569_0.arrayList_0, A_2);
                                    return;
                                }
                                if (class8.enum9_0 == Enum9.const_2)
                                {
                                    Class552.Class545 class10 = Class546.class552_0.arrayList_0[class8.int_0] as Class552.Class545;
                                    this.method_205(class10.int_3, Class546.class569_0.arrayList_0, A_2);
                                }
                            }
                            return;
                        }
                        Class547.Class528 class7 = Class546.class547_0.arrayList_0[class6.int_0] as Class547.Class528;
                        this.method_204(class7.int_6, Class546.class568_0.arrayList_0, A_2);
                    }
                    return;
            }
            Class547.Class528 class5 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            this.method_204(class5.int_6, Class546.class568_0.arrayList_0, A_2);
        }

        internal void method_204(int A_1, ArrayList A_2, Class445[] A_3)
        {
            for (int i = 0; i < A_3.Length; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_15);
                }
                Class568.Class623 class2 = A_2[A_1 + i] as Class568.Class623;
                if (class2.Boolean_0)
                {
                    if (class2.Boolean_1)
                    {
                        this.QRRZ();
                    }
                    else
                    {
                        this.QRRY();
                    }
                }
                this.QRVY(A_3[i]);
            }
        }

        internal void method_205(int A_1, ArrayList A_2, Class445[] A_3)
        {
            for (int i = 0; i < A_3.Length; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_15);
                }
                Class569.Class624 class2 = A_2[A_1 + i] as Class569.Class624;
                if (class2.Boolean_0)
                {
                    this.QRRY();
                }
                this.QRVY(A_3[i]);
            }
        }

        internal void method_206(int A_1, ArrayList A_2, Class445[] A_3)
        {
            for (int i = 0; i < A_3.Length; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_15);
                }
                Class569.Class624 class2 = A_2[A_1 + i] as Class569.Class624;
                if (class2.Boolean_0)
                {
                    this.QRRY();
                }
                this.QRVY(A_3[i]);
            }
        }
    }
}

