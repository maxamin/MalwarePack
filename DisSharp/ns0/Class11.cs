namespace ns0
{
    using System;

    internal class Class11 : Class0
    {
        private bool bool_3;

        internal Class11(Class47 A_1) : base(A_1)
        {
        }

        internal void method_8(Class553 A_1, Class48 A_2)
        {
            A_2.method_3(base.int_1);
            for (int i = 0; i < base.int_0; i++)
            {
                Class553.Class531 class2 = new Class553.Class531();
                int num2 = A_2.method_12(this.bool_3);
                switch ((num2 & 3))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_0;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_26;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_35;
                        break;

                    case 3:
                        class2.enum0_0 = Enum0.const_1;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_0 = num2 >> 2;
                class2.int_1 = A_2.method_12(base.bool_0);
                class2.int_2 = A_2.method_12(base.bool_0);
                A_1.arrayList_0.Add(class2);
            }
        }

        internal override void QQSV()
        {
            this.bool_3 = ((base.class47_0.class11_0.method_2() && base.class47_0.class2_0.method_2()) && base.class47_0.class22_0.method_2()) && base.class47_0.class21_0.method_2();
            base.int_2 = base.method_6(this.bool_3) + (base.method_6(base.bool_0) * 2);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = ((base.class47_0.class11_0.method_2() && base.class47_0.class2_0.method_2()) && base.class47_0.class22_0.method_2()) && base.class47_0.class21_0.method_2();
            for (int i = 0; i < base.int_0; i++)
            {
                Class850 class2 = new Class850();
                int num2 = data.method_12(flag2);
                switch ((num2 & 3))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_0;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_26;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_35;
                        break;

                    case 3:
                        class2.enum0_0 = Enum0.const_1;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_0 = num2 >> 2;
                class2.int_1 = data.method_12(flag);
                class2.int_2 = data.method_12(flag);
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_1;
            }
        }

        internal class Class850
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
        }
    }
}

