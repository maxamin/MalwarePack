namespace ns0
{
    using System;

    internal class Class23 : Class0
    {
        internal Class23(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = 10 + (2 * base.method_6(base.bool_0));
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class886 class2 = new Class886 {
                    uint_0 = data.method_14(),
                    int_0 = data.method_11(),
                    int_1 = data.method_12(flag),
                    int_2 = data.method_12(flag),
                    short_0 = data.method_9()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_38;
            }
        }

        internal class Class886
        {
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal short short_0;
            internal uint uint_0;
        }
    }
}

