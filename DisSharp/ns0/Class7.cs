namespace ns0
{
    using System;

    internal class Class7 : Class0
    {
        private bool bool_3;
        private bool bool_4;

        internal Class7(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class14_0.method_0();
            this.bool_4 = base.class47_0.class19_0.method_1() && base.class47_0.class8_0.method_1();
            base.int_2 = (2 + base.method_6(this.bool_3)) + base.method_6(this.bool_4);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class14_0.method_0();
            bool flag2 = base.class47_0.class19_0.method_1() && base.class47_0.class8_0.method_1();
            for (int i = 0; i < base.int_0; i++)
            {
                Class695 class2 = new Class695 {
                    ushort_0 = data.method_10(),
                    int_0 = data.method_12(flag)
                };
                int num2 = data.method_12(flag2);
                switch ((num2 & 1))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_20;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_23;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_1 = num2 >> 1;
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_24;
            }
        }

        internal class Class695
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal ushort ushort_0;
        }
    }
}

