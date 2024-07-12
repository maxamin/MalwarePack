namespace ns0
{
    using System;

    internal class Class29 : Class0
    {
        private bool bool_3;
        private bool bool_4;

        internal Class29(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class10_0.method_0();
            this.bool_4 = base.class47_0.class14_0.method_1() && base.class47_0.class17_0.method_1();
            base.int_2 = base.method_6(this.bool_3) + (base.method_6(this.bool_4) * 2);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class10_0.method_0();
            bool flag2 = base.class47_0.class14_0.method_1() && base.class47_0.class17_0.method_1();
            for (int i = 0; i < base.int_0; i++)
            {
                Class911 class2 = new Class911 {
                    int_0 = data.method_12(flag)
                };
                int num2 = data.method_12(flag2);
                switch ((num2 & 1))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_6;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_10;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_1 = num2 >> 1;
                num2 = data.method_12(flag2);
                switch ((num2 & 1))
                {
                    case 0:
                        class2.enum0_1 = Enum0.const_6;
                        break;

                    case 1:
                        class2.enum0_1 = Enum0.const_10;
                        break;

                    default:
                        class2.enum0_1 = Enum0.const_52;
                        break;
                }
                class2.int_2 = num2 >> 1;
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_25;
            }
        }

        internal class Class911
        {
            internal Enum0 enum0_0;
            internal Enum0 enum0_1;
            internal int int_0;
            internal int int_1;
            internal int int_2;
        }
    }
}

