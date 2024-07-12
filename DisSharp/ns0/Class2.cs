namespace ns0
{
    using System;

    internal class Class2 : Class0
    {
        internal Class2(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            base.int_2 = (2 + base.method_6(base.bool_0)) + (base.method_6(base.bool_2) * 3);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class954_0.method_5();
            for (int i = 0; i < base.int_0; i++)
            {
                Class657 class2 = new Class657 {
                    short_0 = data.method_9(),
                    int_0 = data.method_12(flag),
                    int_1 = data.method_12(flag2),
                    int_2 = data.method_12(flag2),
                    int_3 = data.method_12(flag2)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_0;
            }
        }

        internal class Class657
        {
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal short short_0;
        }
    }
}

