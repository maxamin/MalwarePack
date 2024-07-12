namespace ns0
{
    using System;
    using System.Collections;

    internal class Class47
    {
        private ArrayList arrayList_0 = new ArrayList();
        internal Class1 class1_0;
        internal Class10 class10_0;
        internal Class11 class11_0;
        internal Class12 class12_0;
        internal Class13 class13_0;
        internal Class14 class14_0;
        internal Class15 class15_0;
        internal Class16 class16_0;
        internal Class17 class17_0;
        internal Class18 class18_0;
        internal Class19 class19_0;
        internal Class2 class2_0;
        internal Class20 class20_0;
        internal Class21 class21_0;
        internal Class22 class22_0;
        internal Class23 class23_0;
        internal Class24 class24_0;
        internal Class25 class25_0;
        internal Class26 class26_0;
        internal Class27 class27_0;
        internal Class28 class28_0;
        internal Class29 class29_0;
        internal Class3 class3_0;
        internal Class30 class30_0;
        internal Class31 class31_0;
        internal Class32 class32_0;
        internal Class33 class33_0;
        internal Class34 class34_0;
        internal Class35 class35_0;
        internal Class36 class36_0;
        internal Class37 class37_0;
        internal Class38 class38_0;
        internal Class39 class39_0;
        internal Class4 class4_0;
        internal Class40 class40_0;
        internal Class41 class41_0;
        internal Class42 class42_0;
        internal Class43 class43_0;
        internal Class44 class44_0;
        internal Class45 class45_0;
        internal Class46 class46_0;
        internal Class48 class48_0;
        internal Class5 class5_0;
        internal Class6 class6_0;
        internal Class681 class681_0;
        internal Class682 class682_0;
        internal Class7 class7_0;
        internal Class8 class8_0;
        internal Class807 class807_0;
        internal Class9 class9_0;
        internal Class954 class954_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private int int_5;
        private int int_6;
        private int int_7;

        internal Class47(Class681 A_1)
        {
            this.class681_0 = A_1;
            this.class807_0 = A_1.class807_0;
            this.class682_0 = A_1.class682_0;
            this.class48_0 = A_1.class48_0;
            this.int_0 = A_1.class955_0.Int32_0;
            this.int_1 = A_1.class955_0.Int32_1;
            this.int_2 = A_1.class955_0.Int32_2;
            this.int_3 = A_1.class955_0.Int32_3;
            this.int_4 = A_1.class955_0.Int32_4;
            this.int_5 = A_1.class955_0.Int32_5;
            this.int_6 = A_1.class955_0.Int32_6;
            this.int_7 = A_1.class955_0.Int32_7;
            this.class2_0 = new Class2(this);
            this.class11_0 = new Class11(this);
            this.class10_0 = new Class10(this);
            this.class36_0 = new Class36(this);
            this.class15_0 = new Class15(this);
            this.class37_0 = new Class37(this);
            this.class14_0 = new Class14(this);
            this.class38_0 = new Class38(this);
            this.class16_0 = new Class16(this);
            this.class9_0 = new Class9(this);
            this.class17_0 = new Class17(this);
            this.class26_0 = new Class26(this);
            this.class13_0 = new Class13(this);
            this.class32_0 = new Class32(this);
            this.class18_0 = new Class18(this);
            this.class30_0 = new Class30(this);
            this.class31_0 = new Class31(this);
            this.class20_0 = new Class20(this);
            this.class25_0 = new Class25(this);
            this.class39_0 = new Class39(this);
            this.class19_0 = new Class19(this);
            this.class6_0 = new Class6(this);
            this.class40_0 = new Class40(this);
            this.class8_0 = new Class8(this);
            this.class7_0 = new Class7(this);
            this.class29_0 = new Class29(this);
            this.class21_0 = new Class21(this);
            this.class3_0 = new Class3(this);
            this.class33_0 = new Class33(this);
            this.class34_0 = new Class34(this);
            this.class12_0 = new Class12(this);
            this.class41_0 = new Class41(this);
            this.class35_0 = new Class35(this);
            this.class22_0 = new Class22(this);
            this.class42_0 = new Class42(this);
            this.class43_0 = new Class43(this);
            this.class1_0 = new Class1(this);
            this.class23_0 = new Class23(this);
            this.class24_0 = new Class24(this);
            this.class5_0 = new Class5(this);
            this.class27_0 = new Class27(this);
            this.class4_0 = new Class4(this);
            this.class28_0 = new Class28(this);
            this.class44_0 = new Class44(this);
            this.class45_0 = new Class45(this);
            this.class46_0 = new Class46(this);
        }

        internal void method_0()
        {
            this.class681_0 = null;
            this.class807_0 = null;
            this.class954_0 = null;
            this.class682_0 = null;
            this.class48_0 = null;
        }

        internal void method_1(Class48 A_1)
        {
            this.class954_0 = this.class681_0.class954_0;
            ulong num = this.class681_0.class954_0.ulong_0;
            for (int i = 0; i < 0x40; i++)
            {
                int num3 = ((int) (num >> i)) & 1;
                if (num3 == 1)
                {
                    int num4 = A_1.method_11();
                    this.method_2(i, num4);
                }
            }
            int position = A_1.int_0;
            for (int j = 0; j < this.arrayList_0.Count; j++)
            {
                position = (this.arrayList_0[j] as Class0).QQSY(position);
            }
        }

        private void method_2(int A_1, int A_2)
        {
            switch (((Enum0) ((byte) A_1)))
            {
                case Enum0.const_0:
                    this.class2_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class2_0);
                    return;

                case Enum0.const_1:
                    this.class11_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class11_0);
                    return;

                case Enum0.const_2:
                    this.class10_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class10_0);
                    return;

                case Enum0.const_3:
                    this.class36_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class36_0);
                    return;

                case Enum0.const_4:
                    this.class15_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class15_0);
                    return;

                case Enum0.const_5:
                    this.class37_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class37_0);
                    return;

                case Enum0.const_6:
                    this.class14_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class14_0);
                    return;

                case Enum0.const_7:
                    this.class38_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class38_0);
                    return;

                case Enum0.const_8:
                    this.class16_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class16_0);
                    return;

                case Enum0.const_9:
                    this.class9_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class9_0);
                    return;

                case Enum0.const_10:
                    this.class17_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class17_0);
                    return;

                case Enum0.const_11:
                    this.class26_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class26_0);
                    return;

                case Enum0.const_12:
                    this.class13_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class13_0);
                    return;

                case Enum0.const_13:
                    this.class32_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class32_0);
                    return;

                case Enum0.const_14:
                    this.class18_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class18_0);
                    return;

                case Enum0.const_15:
                    this.class30_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class30_0);
                    return;

                case Enum0.const_16:
                    this.class31_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class31_0);
                    return;

                case Enum0.const_17:
                    this.class20_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class20_0);
                    return;

                case Enum0.const_18:
                    this.class25_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class25_0);
                    return;

                case Enum0.const_19:
                    this.class39_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class39_0);
                    return;

                case Enum0.const_20:
                    this.class19_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class19_0);
                    return;

                case Enum0.const_21:
                    this.class6_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class6_0);
                    return;

                case Enum0.const_22:
                    this.class40_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class40_0);
                    return;

                case Enum0.const_23:
                    this.class8_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class8_0);
                    return;

                case Enum0.const_24:
                    this.class7_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class7_0);
                    return;

                case Enum0.const_25:
                    this.class29_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class29_0);
                    return;

                case Enum0.const_26:
                    this.class21_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class21_0);
                    return;

                case Enum0.const_27:
                    this.class3_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class3_0);
                    return;

                case Enum0.const_28:
                    this.class33_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class33_0);
                    return;

                case Enum0.const_29:
                    this.class34_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class34_0);
                    return;

                case Enum0.const_32:
                    this.class12_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class12_0);
                    return;

                case Enum0.const_33:
                    this.class41_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class41_0);
                    return;

                case Enum0.const_34:
                    this.class35_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class35_0);
                    return;

                case Enum0.const_35:
                    this.class22_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class22_0);
                    return;

                case Enum0.const_36:
                    this.class42_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class42_0);
                    return;

                case Enum0.const_37:
                    this.class43_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class43_0);
                    return;

                case Enum0.const_38:
                    this.class1_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class1_0);
                    return;

                case Enum0.const_39:
                    this.class23_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class23_0);
                    return;

                case Enum0.const_40:
                    this.class24_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class24_0);
                    return;

                case Enum0.const_41:
                    this.class5_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class5_0);
                    return;

                case Enum0.const_42:
                    this.class27_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class27_0);
                    return;

                case Enum0.const_43:
                    this.class4_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class4_0);
                    return;

                case Enum0.const_44:
                    this.class28_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class28_0);
                    return;

                case Enum0.const_45:
                    this.class44_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class44_0);
                    return;

                case Enum0.const_46:
                    this.class45_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class45_0);
                    return;

                case Enum0.const_47:
                    this.class46_0.int_0 = A_2;
                    this.arrayList_0.Add(this.class46_0);
                    return;
            }
            throw new Exception(Class537.string_915 + A_1.ToString());
        }
    }
}

