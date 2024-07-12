namespace ns0
{
    using System;

    internal class Class8 : Class0
    {
        internal Class8(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = (2 + base.method_6(base.bool_1)) + base.method_6(base.bool_0);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class696 class2 = new Class696 {
                    ushort_0 = data.method_10(),
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
                return Enum0.const_23;
            }
        }

        internal class Class696
        {
            internal int int_0;
            internal int int_1;
            internal ushort ushort_0;
        }
    }
}

