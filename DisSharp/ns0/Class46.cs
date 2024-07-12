namespace ns0
{
    using System;

    internal class Class46 : Class0
    {
        private bool bool_3;

        internal Class46(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class1_0.method_2() && base.class47_0.class22_0.method_2();
            base.class47_0.class23_0.method_2();
            base.int_2 = (8 + base.method_6(base.bool_0)) + base.method_6(this.bool_3);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class1_0.method_2() && base.class47_0.class22_0.method_2();
            base.class47_0.class23_0.method_2();
            for (int i = 0; i < base.int_0; i++)
            {
                Class949 class2 = new Class949 {
                    int_0 = data.method_11(),
                    uint_0 = data.method_14(),
                    int_1 = data.method_12(flag)
                };
                int num2 = data.method_12(flag2);
                switch ((num2 & 3))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_38;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_35;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_39;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_2 = num2 >> 2;
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_47;
            }
        }

        internal class Class949
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal uint uint_0;
        }
    }
}

