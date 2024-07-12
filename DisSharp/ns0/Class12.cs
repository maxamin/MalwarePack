namespace ns0
{
    using System;

    internal class Class12 : Class0
    {
        internal Class12(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = (0x10 + base.method_6(base.bool_1)) + (base.method_6(base.bool_0) * 2);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class861 class2 = new Class861 {
                    int_0 = data.method_11(),
                    ushort_0 = data.method_10(),
                    ushort_1 = data.method_10(),
                    ushort_2 = data.method_10(),
                    ushort_3 = data.method_10(),
                    uint_0 = data.method_14(),
                    int_1 = data.method_12(flag2),
                    int_2 = data.method_12(flag),
                    int_3 = data.method_12(flag)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_32;
            }
        }

        internal class Class861
        {
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal uint uint_0;
            internal ushort ushort_0;
            internal ushort ushort_1;
            internal ushort ushort_2;
            internal ushort ushort_3;
        }
    }
}

