namespace ns0
{
    using System;

    internal class Class16 : Class0
    {
        internal Class16(Class47 A_1) : base(A_1)
        {
        }

        internal void method_8(Class568 A_1, Class48 A_2, Class685 A_3)
        {
            A_2.method_3(base.int_1);
            A_3.ushort_2 = new ushort[base.int_0 + 1];
            A_3.short_0 = new short[base.int_0 + 1];
            for (int i = 0; i < base.int_0; i++)
            {
                Class568.Class623 class2 = new Class568.Class623();
                A_3.ushort_2[i + 1] = A_2.method_10();
                A_3.short_0[i + 1] = A_2.method_9();
                class2.int_0 = A_2.method_12(base.bool_0);
                A_1.arrayList_0.Add(class2);
            }
        }

        internal override void QQSV()
        {
            base.int_2 = 4 + base.method_6(base.bool_0);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            for (int i = 0; i < base.int_0; i++)
            {
                Class879 class2 = new Class879 {
                    ushort_0 = data.method_10(),
                    short_0 = data.method_9(),
                    int_0 = data.method_12(flag)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_8;
            }
        }

        internal class Class879
        {
            internal int int_0;
            internal short short_0;
            internal ushort ushort_0;
        }
    }
}

