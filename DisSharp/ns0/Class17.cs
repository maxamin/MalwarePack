namespace ns0
{
    using System;

    internal class Class17 : Class0
    {
        private bool bool_3;

        internal Class17(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = ((base.class47_0.class10_0.method_3() && base.class47_0.class11_0.method_3()) && (base.class47_0.class14_0.method_3() && base.class47_0.class3_0.method_3())) && base.class47_0.class21_0.method_3();
            base.int_2 = (base.method_6(this.bool_3) + base.method_6(base.bool_0)) + base.method_6(base.bool_1);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = ((base.class47_0.class10_0.method_3() && base.class47_0.class11_0.method_3()) && (base.class47_0.class14_0.method_3() && base.class47_0.class3_0.method_3())) && base.class47_0.class21_0.method_3();
            bool flag2 = base.class47_0.class954_0.method_4();
            bool flag3 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class880 class2 = new Class880();
                int num2 = data.method_12(flag);
                switch ((num2 & 7))
                {
                    case 0:
                        class2.enum0_0 = Enum0.const_2;
                        break;

                    case 1:
                        class2.enum0_0 = Enum0.const_1;
                        break;

                    case 2:
                        class2.enum0_0 = Enum0.const_26;
                        break;

                    case 3:
                        class2.enum0_0 = Enum0.const_6;
                        break;

                    case 4:
                        class2.enum0_0 = Enum0.const_27;
                        break;

                    default:
                        class2.enum0_0 = Enum0.const_52;
                        break;
                }
                class2.int_0 = num2 >> 3;
                class2.int_1 = data.method_12(flag2);
                class2.int_2 = data.method_12(flag3);
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_10;
            }
        }

        internal class Class880
        {
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
        }
    }
}

