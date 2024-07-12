namespace ns0
{
    using System;

    internal class Class3 : Class0
    {
        internal Class3(Class47 A_1) : base(A_1)
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
                Class690 class2 = new Class690 {
                    int_0 = data.method_12(flag)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_27;
            }
        }

        internal class Class690
        {
            internal int int_0;
        }
    }
}

