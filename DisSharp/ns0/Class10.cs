namespace ns0
{
    using System;

    internal class Class10 : Class0
    {
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;

        internal Class10(Class47 A_1) : base(A_1)
        {
        }

        internal void method_8(Class548 A_1, Class48 A_2, Class685 A_3)
        {
            A_2.method_3(base.int_1);
            A_3.uint_0 = new uint[base.int_0 + 1];
            for (int i = 0; i < base.int_0; i++)
            {
                Class548.Class529 class2 = new Class548.Class529 {
                    int_0 = i + 1
                };
                A_3.uint_0[i + 1] = A_2.method_14();
                class2.int_1 = A_2.method_12(base.bool_0);
                class2.int_2 = A_2.method_12(base.bool_0);
                int num2 = A_2.method_12(this.bool_3);
                switch ((num2 & 3))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_2;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_1;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_27;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_4 = num2 >> 2;
                class2.int_7 = A_2.method_12(this.bool_4);
                class2.int_8 = A_2.method_12(this.bool_5);
                A_1.arrayList_0.Add(class2);
            }
        }

        internal override void QQSV()
        {
            this.bool_3 = (base.class47_0.class10_0.method_2() && base.class47_0.class11_0.method_2()) && base.class47_0.class3_0.method_2();
            this.bool_4 = base.class47_0.class15_0.method_0();
            this.bool_5 = base.class47_0.class14_0.method_0();
            base.int_2 = (((4 + (base.method_6(base.bool_0) * 2)) + base.method_6(this.bool_3)) + base.method_6(this.bool_4)) + base.method_6(this.bool_5);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = (base.class47_0.class10_0.method_2() && base.class47_0.class11_0.method_2()) && base.class47_0.class3_0.method_2();
            bool flag3 = base.class47_0.class15_0.method_0();
            bool flag4 = base.class47_0.class14_0.method_0();
            for (int i = 0; i < base.int_0; i++)
            {
                Class849 class2 = new Class849 {
                    uint_0 = data.method_14(),
                    int_0 = data.method_12(flag),
                    int_1 = data.method_12(flag)
                };
                int num2 = data.method_12(flag2);
                switch ((num2 & 3))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_2;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_1;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_27;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_2 = num2 >> 2;
                class2.int_3 = data.method_12(flag3);
                class2.int_4 = data.method_12(flag4);
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_2;
            }
        }

        internal class Class849
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal int int_4;
            internal uint uint_0;
        }
    }
}

