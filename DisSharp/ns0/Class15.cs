namespace ns0
{
    using System;

    internal class Class15 : Class0
    {
        internal Class15(Class47 A_1) : base(A_1)
        {
        }

        internal void method_8(Class549 A_1, Class48 A_2, Class685 A_3)
        {
            A_2.method_3(base.int_1);
            A_3.ushort_3 = new ushort[base.int_0 + 1];
            for (int i = 0; i < base.int_0; i++)
            {
                Class549.Class530 class2 = new Class549.Class530 {
                    int_0 = i + 1
                };
                A_3.ushort_3[i + 1] = A_2.method_10();
                class2.int_1 = A_2.method_12(base.bool_0);
                class2.int_2 = A_2.method_12(base.bool_1);
                A_1.arrayList_0.Add(class2);
            }
        }

        internal override void QQSV()
        {
            base.int_2 = (2 + base.method_6(base.bool_0)) + base.method_6(base.bool_1);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class878 class2 = new Class878 {
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
                return Enum0.const_4;
            }
        }

        internal class Class878
        {
            internal int int_0;
            internal int int_1;
            internal ushort ushort_0;
        }
    }
}

