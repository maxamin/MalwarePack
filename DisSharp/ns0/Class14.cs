namespace ns0
{
    using System;

    internal class Class14 : Class0
    {
        private bool bool_3;

        internal Class14(Class47 A_1) : base(A_1)
        {
        }

        internal void method_8(Class547 A_1, Class48 A_2, Class685 A_3)
        {
            A_2.method_3(base.int_1);
            A_3.int_0 = new int[base.int_0 + 1];
            A_3.ushort_0 = new ushort[base.int_0 + 1];
            A_3.ushort_1 = new ushort[base.int_0 + 1];
            A_3.int_1 = new int[base.int_0 + 1];
            for (int i = 0; i < base.int_0; i++)
            {
                Class547.Class528 class2 = new Class547.Class528 {
                    int_0 = i + 1
                };
                A_3.int_0[i + 1] = A_2.method_11();
                A_3.ushort_0[i + 1] = A_2.method_10();
                A_3.ushort_1[i + 1] = A_2.method_10();
                class2.int_1 = A_2.method_12(base.bool_0);
                class2.int_5 = A_2.method_12(base.bool_1);
                class2.int_6 = A_2.method_12(this.bool_3);
                A_3.int_1[i + 1] = class2.int_5;
                A_1.arrayList_0.Add(class2);
            }
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class16_0.method_0();
            base.int_2 = ((8 + base.method_6(base.bool_1)) + base.method_6(base.bool_0)) + base.method_6(this.bool_3);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class954_0.method_6();
            bool flag3 = base.class47_0.class16_0.method_0();
            for (int i = 0; i < base.int_0; i++)
            {
                Class877 class2 = new Class877 {
                    int_0 = data.method_11(),
                    ushort_0 = data.method_10(),
                    ushort_1 = data.method_10(),
                    int_1 = data.method_12(flag),
                    int_2 = data.method_12(flag2),
                    int_3 = data.method_12(flag3)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_6;
            }
        }

        internal class Class877
        {
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal ushort ushort_0;
            internal ushort ushort_1;
        }
    }
}

