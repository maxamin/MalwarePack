namespace ns0
{
    using System;

    internal class Class18 : Class0
    {
        private bool bool_3;

        internal Class18(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = (base.class47_0.class10_0.method_2() && base.class47_0.class14_0.method_2()) && base.class47_0.class12_0.method_2();
            base.int_2 = (2 + base.method_6(this.bool_3)) + base.method_6(base.bool_1);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = (base.class47_0.class10_0.method_2() && base.class47_0.class14_0.method_2()) && base.class47_0.class12_0.method_2();
            bool flag2 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class881 class2 = new Class881 {
                    ushort_0 = data.method_10()
                };
                int num2 = data.method_12(flag);
                switch ((num2 & 3))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_2;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_6;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_32;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_0 = num2 >> 2;
                class2.int_1 = data.method_12(flag2);
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_14;
            }
        }

        internal class Class881
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal ushort ushort_0;
        }
    }
}

