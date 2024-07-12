namespace ns0
{
    using System;

    internal class Class37 : Class0
    {
        private bool bool_3;

        internal Class37(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class14_0.method_0();
            base.int_2 = base.method_6(this.bool_3);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class14_0.method_0();
            for (int i = 0; i < base.int_0; i++)
            {
                Class940 class2 = new Class940 {
                    int_0 = data.method_12(flag)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_5;
            }
        }

        internal class Class940
        {
            internal int int_0;
        }
    }
}

