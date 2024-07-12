namespace ns0
{
    using System;

    internal class Class40 : Class0
    {
        private bool bool_3;

        internal Class40(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class8_0.method_0();
            base.int_2 = base.method_6(this.bool_3);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class8_0.method_0();
            for (int i = 0; i < base.int_0; i++)
            {
                Class943 class2 = new Class943 {
                    int_0 = data.method_12(flag)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_22;
            }
        }

        internal class Class943
        {
            internal int int_0;
        }
    }
}

