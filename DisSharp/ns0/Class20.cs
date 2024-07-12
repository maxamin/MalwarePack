namespace ns0
{
    using System;

    internal class Class20 : Class0
    {
        internal Class20(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = base.method_6(base.bool_1);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class883 class2 = new Class883 {
                    int_0 = data.method_12(flag)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_17;
            }
        }

        internal class Class883
        {
            internal int int_0;
        }
    }
}

