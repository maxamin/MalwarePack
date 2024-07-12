namespace ns0
{
    using System;

    internal class Class42 : Class0
    {
        internal Class42(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = 6;
        }

        internal override void QQSW(Class48 data)
        {
            for (int i = 0; i < base.int_0; i++)
            {
                Class945 class2 = new Class945 {
                    uint_0 = data.method_14(),
                    short_0 = data.method_9()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_36;
            }
        }

        internal class Class945
        {
            internal short short_0;
            internal uint uint_0;
        }
    }
}

