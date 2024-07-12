namespace ns0
{
    using System;

    internal class Class28 : Class0
    {
        private bool bool_3;
        private bool bool_4;

        internal Class28(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class27_0.method_1();
            this.bool_4 = (base.class47_0.class10_0.method_2() && base.class47_0.class11_0.method_2()) && base.class47_0.class3_0.method_2();
            base.int_2 = base.method_6(this.bool_3) + base.method_6(this.bool_4);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class27_0.method_1();
            bool flag2 = (base.class47_0.class10_0.method_2() && base.class47_0.class11_0.method_2()) && base.class47_0.class3_0.method_2();
            for (int i = 0; i < base.int_0; i++)
            {
                Class910 class2 = new Class910 {
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
                return Enum0.const_44;
            }
        }

        internal class Class910
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
        }
    }
}

