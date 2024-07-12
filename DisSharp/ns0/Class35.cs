namespace ns0
{
    using System;

    internal class Class35 : Class0
    {
        internal Class35(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = 12;
        }

        internal override void QQSW(Class48 data)
        {
            for (int i = 0; i < base.int_0; i++)
            {
                Class938 class2 = new Class938 {
                    uint_0 = data.method_14(),
                    uint_1 = data.method_14(),
                    uint_2 = data.method_14()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_34;
            }
        }

        internal class Class938
        {
            internal uint uint_0;
            internal uint uint_1;
            internal uint uint_2;
        }
    }
}

