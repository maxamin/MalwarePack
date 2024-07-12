namespace ns0
{
    using System;

    internal class Class41 : Class0
    {
        internal Class41(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = 4;
        }

        internal override void QQSW(Class48 data)
        {
            for (int i = 0; i < base.int_0; i++)
            {
                Class944 class2 = new Class944 {
                    uint_0 = data.method_14()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_33;
            }
        }

        internal class Class944
        {
            internal uint uint_0;
        }
    }
}

