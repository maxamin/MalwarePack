namespace ns0
{
    using System;

    internal class Class26 : Class0
    {
        private bool bool_3;

        internal Class26(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = (base.class47_0.class16_0.method_2() && base.class47_0.class15_0.method_2()) && base.class47_0.class8_0.method_2();
            base.int_2 = (2 + base.method_6(this.bool_3)) + base.method_6(base.bool_1);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = (base.class47_0.class16_0.method_2() && base.class47_0.class15_0.method_2()) && base.class47_0.class8_0.method_2();
            bool flag2 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class908 class2 = new Class908 {
                    byte_0 = data.method_8()
                };
                data.method_8();
                int num2 = data.method_12(flag);
                switch ((num2 & 3))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_4;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_8;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_23;
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
                return Enum0.const_11;
            }
        }

        internal class Class908
        {
            internal byte byte_0;
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
        }
    }
}

