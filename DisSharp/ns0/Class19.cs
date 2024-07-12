namespace ns0
{
    using System;

    internal class Class19 : Class0
    {
        private bool bool_3;

        internal Class19(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = (base.class47_0.class10_0.method_2() && base.class47_0.class11_0.method_2()) && base.class47_0.class3_0.method_2();
            base.int_2 = (2 + base.method_6(base.bool_0)) + base.method_6(this.bool_3);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = (base.class47_0.class10_0.method_2() && base.class47_0.class11_0.method_2()) && base.class47_0.class3_0.method_2();
            for (int i = 0; i < base.int_0; i++)
            {
                Class882 class2 = new Class882 {
                    ushort_0 = data.method_10(),
                    int_0 = data.method_12(flag)
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
                class2.int_1 = num2 >> 2;
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_20;
            }
        }

        internal class Class882
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal ushort ushort_0;
        }

        internal enum Enum52
        {
            const_0,
            const_1,
            const_2,
            const_3
        }
    }
}

