namespace ns0
{
    using System;
    using System.Collections;

    internal class Class673 : Class672
    {
        private ArrayList arrayList_3;
        private ArrayList arrayList_4;
        private int int_6 = 100;
        private int int_7;
        private int int_8;
        private Struct7[] struct7_0 = new Struct7[100];

        internal void method_85()
        {
            this.method_86();
            this.method_87();
        }

        private void method_86()
        {
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            ArrayList list2 = base.class684_0.class547_0.arrayList_0;
            ArrayList list3 = base.class684_0.class576_0.arrayList_0;
            ArrayList list4 = base.class684_0.class577_0.arrayList_0;
            ArrayList list5 = base.class47_0.class9_0.arrayList_0;
            int num = list5.Count - 1;
            int num2 = 1;
            Class9.Class848 class2 = null;
            Class9.Class848 class3 = null;
            ArrayList list6 = base.class47_0.class29_0.arrayList_0;
            int num3 = list6.Count - 1;
            int num4 = 1;
            Class29.Class911 class4 = null;
            bool flag = list6.Count > 1;
            ArrayList list7 = base.class47_0.class3_0.arrayList_0;
            if (list5.Count > 1)
            {
                class2 = list5[1] as Class9.Class848;
            }
            if (list6.Count > 1)
            {
                class4 = list6[1] as Class29.Class911;
            }
            for (int i = 1; i < list5.Count; i++)
            {
                int num14;
                bool flag2 = false;
                if (i < num)
                {
                    class3 = list5[i + 1] as Class9.Class848;
                    if (class2.int_0 != class3.int_0)
                    {
                        flag2 = true;
                    }
                }
                else
                {
                    flag2 = true;
                }
                if (!flag2)
                {
                    goto Label_076D;
                }
                int num6 = class2.int_0;
                Class548.Class529 class5 = list[num6] as Class548.Class529;
                int num7 = (i - num2) + 1;
                if (num7 > this.int_6)
                {
                    this.struct7_0 = new Struct7[num7];
                    this.int_6 = num7;
                }
                class5.short_2 = (short) num7;
                class5.int_5 = list3.Count;
                for (int j = 0; j < num7; j++)
                {
                    int num10;
                    bool flag3;
                    int num11;
                    Class577.Class649 class10;
                    Class9.Class848 class6 = list5[num2 + j] as Class9.Class848;
                    Class576.Class648 class7 = new Class576.Class648();
                    switch (class6.enum0_0)
                    {
                        case Enum0.const_1:
                            class7.enum0_0 = Enum0.const_1;
                            class7.int_0 = class6.int_1;
                            this.struct7_0[j].enum0_0 = Enum0.const_1;
                            this.struct7_0[j].int_2 = class6.int_1;
                            goto Label_047A;

                        case Enum0.const_2:
                        {
                            class7.enum0_0 = Enum0.const_2;
                            class7.int_0 = class6.int_1;
                            Class548.Class529 class8 = list[class6.int_1] as Class548.Class529;
                            this.struct7_0[j].enum0_0 = Enum0.const_2;
                            this.struct7_0[j].int_0 = class8.int_8;
                            this.struct7_0[j].int_1 = (class8.int_8 + class8.short_5) - 1;
                            goto Label_047A;
                        }
                        case Enum0.const_27:
                        {
                            Class3.Class690 class9 = list7[class6.int_1] as Class3.Class690;
                            base.class48_0.method_3(base.int_2 + class9.int_0);
                            base.class48_0.method_21();
                            if (base.class48_0.method_8() != 0x15)
                            {
                                goto Label_0395;
                            }
                            base.method_32();
                            num10 = base.class48_0.method_21();
                            flag3 = true;
                            switch (base.class688_0.enum11_0)
                            {
                                case Enum11.const_36:
                                    class7.enum0_0 = Enum0.const_2;
                                    class7.int_0 = base.class688_0.int_0;
                                    class7.short_0 = (short) num10;
                                    class7.int_1 = list4.Count;
                                    num11 = 0;
                                    goto Label_029C;

                                case Enum11.const_38:
                                    goto Label_030F;
                            }
                            goto Label_030A;
                        }
                        default:
                            goto Label_0395;
                    }
                Label_0285:
                    class10 = base.method_17();
                    list4.Add(class10);
                    num11++;
                Label_029C:
                    if (num11 < num10)
                    {
                        goto Label_0285;
                    }
                    Class548.Class529 class11 = list[class7.int_0] as Class548.Class529;
                    this.struct7_0[j].enum0_0 = Enum0.const_2;
                    this.struct7_0[j].int_0 = class11.int_8;
                    this.struct7_0[j].int_1 = (class11.int_8 + class11.short_5) - 1;
                    goto Label_038E;
                Label_030A:
                    flag3 = false;
                    goto Label_038E;
                Label_030F:
                    class7.enum0_0 = Enum0.const_1;
                    class7.int_0 = base.class688_0.int_0;
                    class7.short_0 = (short) num10;
                    class7.int_1 = list4.Count;
                    for (int m = 0; m < num10; m++)
                    {
                        Class577.Class649 class12 = base.method_17();
                        list4.Add(class12);
                    }
                    this.struct7_0[j].enum0_0 = Enum0.const_1;
                    this.struct7_0[j].int_2 = class7.int_0;
                Label_038E:
                    if (flag3)
                    {
                        goto Label_047A;
                    }
                Label_0395:
                    class7.enum0_0 = Enum0.const_52;
                    this.struct7_0[j].enum0_0 = Enum0.const_52;
                Label_047A:
                    list3.Add(class7);
                }
                if (!flag || (class4.int_0 != num6))
                {
                    goto Label_0767;
                }
                int num13 = num4 - 1;
                while (class4.int_0 == num6)
                {
                    num13++;
                    if (num13 >= num3)
                    {
                        goto Label_04DA;
                    }
                    class4 = list6[num13 + 1] as Class29.Class911;
                }
                goto Label_04DD;
            Label_04DA:
                flag = false;
            Label_04DD:
                num14 = num13 - num4;
                for (int k = 0; k <= num14; k++)
                {
                    int num16;
                    Class551.Class544 class15;
                    int num18;
                    Class556.Class601 class16;
                    int num19;
                    int num20;
                    int num21;
                    Class29.Class911 class13 = list6[num4 + k] as Class29.Class911;
                    Class547.Class528 class14 = list2[class13.int_1] as Class547.Class528;
                    switch (class13.enum0_1)
                    {
                        case Enum0.const_6:
                            num16 = 0;
                            while (num16 < num7)
                            {
                                if (((this.struct7_0[num16].enum0_0 == Enum0.const_2) && (class13.int_2 >= this.struct7_0[num16].int_0)) && (class13.int_2 <= this.struct7_0[num16].int_1))
                                {
                                    goto Label_0748;
                                }
                                num16++;
                            }
                            break;

                        case Enum0.const_10:
                        {
                            class15 = base.class684_0.class551_0.arrayList_0[class13.int_2] as Class551.Class544;
                            if (class15.enum9_0 != Enum9.const_2)
                            {
                                goto Label_05D8;
                            }
                            int num17 = (base.class684_0.class552_0.arrayList_0[class15.int_0] as Class552.Class545).int_0;
                            num18 = 0;
                            while (num18 < num7)
                            {
                                if ((this.struct7_0[num18].enum0_0 == Enum0.const_1) && (this.struct7_0[num18].int_2 == num17))
                                {
                                    goto Label_05C7;
                                }
                                num18++;
                            }
                            break;
                        }
                    }
                    continue;
                Label_05C7:
                    class14.byte_0 = (byte) (num18 + 1);
                    continue;
                Label_05D8:
                    if (class15.enum9_0 == Enum9.const_4)
                    {
                        class16 = base.class684_0.class556_0.arrayList_0[class15.int_0] as Class556.Class601;
                        num19 = class16.int_4;
                        if (class16.enum11_0 != Enum11.const_36)
                        {
                            goto Label_068E;
                        }
                        num20 = 0;
                        while (num20 < num7)
                        {
                            if (((this.struct7_0[num20].enum0_0 == Enum0.const_2) && (class13.int_2 >= this.struct7_0[num20].int_0)) && (class13.int_2 <= this.struct7_0[num20].int_1))
                            {
                                goto Label_067D;
                            }
                            num20++;
                        }
                    }
                    continue;
                Label_067D:
                    class14.byte_0 = (byte) (num20 + 1);
                    continue;
                Label_068E:
                    if (class16.enum11_0 == Enum11.const_38)
                    {
                        num21 = 0;
                        while (num21 < num7)
                        {
                            if ((this.struct7_0[num21].enum0_0 == Enum0.const_1) && (this.struct7_0[num21].int_2 == num19))
                            {
                                goto Label_06DC;
                            }
                            num21++;
                        }
                    }
                    continue;
                Label_06DC:
                    class14.byte_0 = (byte) (num21 + 1);
                    continue;
                Label_0748:
                    class14.byte_0 = (byte) (num16 + 1);
                }
                num4 = num13;
            Label_0767:
                num2 = i + 1;
            Label_076D:
                class2 = class3;
            }
        }

        private void method_87()
        {
            this.arrayList_3 = base.class684_0.class548_0.arrayList_0;
            this.arrayList_4 = base.class684_0.class576_0.arrayList_0;
            for (int i = 1; i < this.arrayList_3.Count; i++)
            {
                Class548.Class529 class2 = this.arrayList_3[i] as Class548.Class529;
                if (class2.short_2 > 0)
                {
                    int num2 = class2.int_5;
                    this.int_7 = num2;
                    this.int_8 = (num2 + class2.short_2) - 1;
                    for (int j = 0; j < class2.short_2; j++)
                    {
                        Class576.Class648 class3 = this.arrayList_4[num2 + j] as Class576.Class648;
                        if (class3.enum0_0 == Enum0.const_2)
                        {
                            this.method_88(class3);
                        }
                    }
                }
            }
        }

        private void method_88(Class576.Class648 A_1)
        {
            Class548.Class529 class2 = this.arrayList_3[A_1.int_0] as Class548.Class529;
            if (class2.short_2 > 0)
            {
                int num = class2.int_5;
                for (int i = 0; i < class2.short_2; i++)
                {
                    Class576.Class648 class3 = this.arrayList_4[num + i] as Class576.Class648;
                    if (class3.enum0_0 == Enum0.const_2)
                    {
                        this.method_89(class3);
                        this.method_88(class3);
                    }
                }
            }
        }

        private void method_89(Class576.Class648 A_1)
        {
            int num = A_1.int_0;
            for (int i = this.int_7; i <= this.int_8; i++)
            {
                Class576.Class648 class2 = this.arrayList_4[i] as Class576.Class648;
                if (class2.int_0 == num)
                {
                    class2.byte_1 = (byte) (class2.byte_1 | 1);
                }
            }
        }
    }
}

