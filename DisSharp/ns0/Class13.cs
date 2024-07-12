namespace ns0
{
    using System;

    internal class Class13 : Class0
    {
        private bool bool_3;
        private bool bool_4;

        internal Class13(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = (((((base.class47_0.class14_0.method_5() && base.class47_0.class15_0.method_5()) && (base.class47_0.class11_0.method_5() && base.class47_0.class10_0.method_5())) && ((base.class47_0.class16_0.method_5() && base.class47_0.class9_0.method_5()) && (base.class47_0.class17_0.method_5() && base.class47_0.class2_0.method_5()))) && (((base.class47_0.class18_0.method_5() && base.class47_0.class8_0.method_5()) && (base.class47_0.class19_0.method_5() && base.class47_0.class20_0.method_5())) && ((base.class47_0.class21_0.method_5() && base.class47_0.class3_0.method_5()) && (base.class47_0.class12_0.method_5() && base.class47_0.class22_0.method_5())))) && (base.class47_0.class1_0.method_5() && base.class47_0.class23_0.method_5())) && base.class47_0.class24_0.method_5();
            this.bool_4 = ((base.class47_0.class11_0.method_3() && base.class47_0.class10_0.method_3()) && base.class47_0.class14_0.method_3()) && base.class47_0.class17_0.method_3();
            base.int_2 = (base.method_6(this.bool_3) + base.method_6(this.bool_4)) + base.method_6(base.bool_1);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = (((((base.class47_0.class14_0.method_5() && base.class47_0.class15_0.method_5()) && (base.class47_0.class11_0.method_5() && base.class47_0.class10_0.method_5())) && ((base.class47_0.class16_0.method_5() && base.class47_0.class9_0.method_5()) && (base.class47_0.class17_0.method_5() && base.class47_0.class2_0.method_5()))) && (((base.class47_0.class18_0.method_5() && base.class47_0.class8_0.method_5()) && (base.class47_0.class19_0.method_5() && base.class47_0.class20_0.method_5())) && ((base.class47_0.class21_0.method_5() && base.class47_0.class3_0.method_5()) && (base.class47_0.class12_0.method_5() && base.class47_0.class22_0.method_5())))) && (base.class47_0.class1_0.method_5() && base.class47_0.class23_0.method_5())) && base.class47_0.class24_0.method_5();
            bool flag2 = ((base.class47_0.class11_0.method_3() && base.class47_0.class10_0.method_3()) && base.class47_0.class14_0.method_3()) && base.class47_0.class17_0.method_3();
            bool flag3 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class876 class2 = new Class876();
                int num2 = data.method_12(flag);
                switch ((num2 & 0x1f))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_6;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_4;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_1;
                        break;

                    case 3:
                        class2.enum0_0 = Enum0.const_2;
                        break;

                    case 4:
                        class2.enum0_0 = Enum0.const_8;
                        break;

                    case 5:
                        class2.enum0_0 = Enum0.const_9;
                        break;

                    case 6:
                        class2.enum0_0 = Enum0.const_10;
                        break;

                    case 7:
                        class2.enum0_0 = Enum0.const_0;
                        break;

                    case 8:
                        class2.enum0_0 = Enum0.const_14;
                        break;

                    case 9:
                        class2.enum0_0 = Enum0.const_23;
                        break;

                    case 10:
                        class2.enum0_0 = Enum0.const_20;
                        break;

                    case 11:
                        class2.enum0_0 = Enum0.const_17;
                        break;

                    case 12:
                        class2.enum0_0 = Enum0.const_26;
                        break;

                    case 13:
                        class2.enum0_0 = Enum0.const_27;
                        break;

                    case 14:
                        class2.enum0_0 = Enum0.const_32;
                        break;

                    case 15:
                        class2.enum0_0 = Enum0.const_35;
                        break;

                    case 0x10:
                        class2.enum0_0 = Enum0.const_38;
                        break;

                    case 0x11:
                        class2.enum0_0 = Enum0.const_39;
                        break;

                    case 0x12:
                        class2.enum0_0 = Enum0.const_40;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_0 = num2 >> 5;
                num2 = data.method_12(flag2);
                switch ((num2 & 7))
                {
                    case 0:
                        class2.enum0_1 = Enum0.const_1;
                        break;

                    case 1:
                        class2.enum0_1 = Enum0.const_2;
                        break;

                    case 2:
                        class2.enum0_1 = Enum0.const_6;
                        break;

                    case 3:
                        class2.enum0_1 = Enum0.const_10;
                        break;

                    default:
                        class2.enum0_1 = Enum0.const_52;
                        break;
                }
                class2.int_1 = num2 >> 3;
                class2.int_2 = data.method_12(flag3);
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_12;
            }
        }

        internal class Class876
        {
            internal Enum0 enum0_0;
            internal Enum0 enum0_1;
            internal int int_0;
            internal int int_1;
            internal int int_2;
        }
    }
}

