namespace ns0
{
    using System;

    internal class Class33 : Class0
    {
        private bool bool_3;
        private bool bool_4;

        internal Class33(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class15_0.method_1() && base.class47_0.class14_0.method_1();
            this.bool_4 = base.class47_0.class21_0.method_0();
            base.int_2 = ((2 + base.method_6(this.bool_3)) + base.method_6(base.bool_0)) + base.method_6(this.bool_4);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class15_0.method_1() && base.class47_0.class14_0.method_1();
            bool flag3 = base.class47_0.class21_0.method_0();
            for (int i = 0; i < base.int_0; i++)
            {
                Class915 class2 = new Class915 {
                    ushort_0 = data.method_10()
                };
                int num2 = data.method_12(flag2);
                switch ((num2 & 1))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_4;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_6;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_0 = num2 >> 1;
                class2.int_1 = data.method_12(flag);
                class2.int_2 = data.method_12(flag3);
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_28;
            }
        }

        internal class Class915
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal ushort ushort_0;
        }
    }
}

