namespace ns0
{
    using System;

    internal class Class1 : Class0
    {
        internal Class1(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = (4 + base.method_6(base.bool_0)) + base.method_6(base.bool_1);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class49 class2 = new Class49 {
                    uint_0 = data.method_14(),
                    int_0 = data.method_12(flag),
                    int_1 = data.method_12(flag2)
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

        internal class Class49
        {
            internal int int_0;
            internal int int_1;
            internal uint uint_0;
        }
    }
}

