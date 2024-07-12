namespace ns0
{
    using System;

    internal class Class34 : Class0
    {
        private bool bool_3;

        internal Class34(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class15_0.method_0();
            base.int_2 = 4 + base.method_6(this.bool_3);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class15_0.method_0();
            for (int i = 0; i < base.int_0; i++)
            {
                Class916 class2 = new Class916 {
                    int_0 = data.method_11(),
                    int_1 = data.method_12(flag)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_29;
            }
        }

        internal class Class916
        {
            internal int int_0;
            internal int int_1;
        }
    }
}

