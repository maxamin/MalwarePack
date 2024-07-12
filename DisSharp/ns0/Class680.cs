namespace ns0
{
    using System;

    internal class Class680 : Class679
    {
        internal Class680(Class681 A_1, Class394 A_2)
        {
            base.class681_0 = A_1;
            base.class47_0 = A_1.class47_0;
            base.class48_0 = A_1.class48_0;
            base.class682_0 = A_1.class682_0;
            base.class394_0 = A_2;
            base.class581_0 = A_2.class581_0;
            base.class604_0 = A_2.class604_0;
            base.class684_0 = A_2.class684_0;
            base.class558_0 = base.class684_0.class558_0;
            base.class574_0 = base.class684_0.class574_0;
            base.class563_0 = base.class684_0.class563_0;
            base.class685_0 = new Class685();
            base.int_0 = A_1.class955_0.Int32_0;
            base.int_1 = A_1.class955_0.Int32_2;
            base.int_2 = A_1.class955_0.Int32_4;
            base.int_3 = A_1.class955_0.Int32_6;
        }

        internal Class686.Class687 method_147()
        {
            this.method_148();
            base.method_34();
            this.method_149();
            base.method_42();
            base.method_45();
            base.method_52();
            base.method_55();
            base.method_53();
            base.method_56();
            base.method_59();
            base.method_64();
            base.method_70();
            base.method_77();
            base.method_85();
            base.method_74();
            base.method_90();
            base.method_108();
            base.method_109();
            base.method_115();
            base.class687_0 = Class1088.smethod_0(base.class394_0);
            base.method_116();
            base.method_142();
            this.method_150();
            return base.class687_0;
        }

        private void method_148()
        {
            base.class47_0.class10_0.method_8(base.class684_0.class548_0, base.class48_0, base.class685_0);
            base.class47_0.class11_0.method_8(base.class684_0.class553_0, base.class48_0);
            base.class47_0.class15_0.method_8(base.class684_0.class549_0, base.class48_0, base.class685_0);
            base.class47_0.class14_0.method_8(base.class684_0.class547_0, base.class48_0, base.class685_0);
            base.class47_0.class16_0.method_8(base.class684_0.class568_0, base.class48_0, base.class685_0);
            base.class47_0.class22_0.method_8(base.class684_0.class554_0, base.class48_0);
            base.class47_0.class5_0.method_7(base.class48_0);
            base.class47_0.class20_0.method_7(base.class48_0);
            base.class47_0.class26_0.method_7(base.class48_0);
            base.class47_0.class17_0.method_7(base.class48_0);
            base.class47_0.class3_0.method_7(base.class48_0);
            base.class47_0.class9_0.method_7(base.class48_0);
            base.class47_0.class29_0.method_7(base.class48_0);
            base.class47_0.class6_0.method_7(base.class48_0);
            base.class47_0.class8_0.method_7(base.class48_0);
            base.class47_0.class25_0.method_7(base.class48_0);
            base.class47_0.class19_0.method_7(base.class48_0);
            base.class47_0.class7_0.method_7(base.class48_0);
            base.class47_0.class13_0.method_7(base.class48_0);
            base.class47_0.class32_0.method_7(base.class48_0);
            base.class47_0.class30_0.method_7(base.class48_0);
            base.class47_0.class31_0.method_7(base.class48_0);
            base.class47_0.class33_0.method_7(base.class48_0);
            base.class47_0.class21_0.method_7(base.class48_0);
            base.class47_0.class24_0.method_7(base.class48_0);
            base.class47_0.class12_0.method_7(base.class48_0);
            base.class47_0.class34_0.method_7(base.class48_0);
            base.class47_0.class27_0.method_7(base.class48_0);
            base.class47_0.class28_0.method_7(base.class48_0);
            base.class47_0.class4_0.method_7(base.class48_0);
            base.bool_0 = new bool[base.class684_0.class547_0.arrayList_0.Count];
            base.bool_1 = new bool[base.class684_0.class547_0.arrayList_0.Count];
            base.enum59_0 = new Enum59[base.class684_0.class547_0.arrayList_0.Count];
            base.struct4_0 = new Struct4[base.class47_0.class8_0.arrayList_0.Count];
            base.struct4_1 = new Struct4[base.class47_0.class19_0.arrayList_0.Count];
        }

        private void method_149()
        {
            base.class684_0.class547_0.method_0(base.class685_0);
            base.class684_0.class549_0.method_0(base.class685_0);
            base.class684_0.class548_0.method_0(base.class685_0);
        }

        private void method_150()
        {
            uint num = base.class681_0.class917_0.uint_1;
            Enum0 enum2 = (Enum0) ((byte) ((num & -16777216) >> 0x18));
            int num2 = ((int) num) & 0xffffff;
            if (enum2 == Enum0.const_6)
            {
                base.class394_0.int_1 = num2;
                this.method_151(num2);
            }
        }

        private void method_151(int A_1)
        {
            Class547.Class528 class2 = base.class684_0.class547_0.arrayList_0[A_1] as Class547.Class528;
            if (class2 != null)
            {
                class2.method_4();
            }
        }
    }
}

