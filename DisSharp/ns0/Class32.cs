namespace ns0
{
    using System;

    internal class Class32 : Class0
    {
        private bool bool_3;

        internal Class32(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class15_0.method_1() && base.class47_0.class16_0.method_1();
            base.int_2 = base.method_6(this.bool_3) + base.method_6(base.bool_1);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class15_0.method_1() && base.class47_0.class16_0.method_1();
            bool flag2 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class914 class2 = new Class914();
                int num2 = data.method_12(flag);
                switch ((num2 & 1))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_4;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_8;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_0 = num2 >> 1;
                class2.int_1 = data.method_12(flag2);
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_13;
            }
        }

        internal class Class914
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
        }
    }
}

