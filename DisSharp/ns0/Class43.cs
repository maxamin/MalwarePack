namespace ns0
{
    using System;

    internal class Class43 : Class0
    {
        internal Class43(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = 14;
        }

        internal override void QQSW(Class48 data)
        {
            for (int i = 0; i < base.int_0; i++)
            {
                Class946 class2 = new Class946 {
                    uint_0 = data.method_14(),
                    uint_1 = data.method_14(),
                    uint_2 = data.method_14(),
                    short_0 = data.method_9()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_37;
            }
        }

        internal class Class946
        {
            internal short short_0;
            internal uint uint_0;
            internal uint uint_1;
            internal uint uint_2;
        }
    }
}

