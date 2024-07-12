namespace ns0
{
    using System;

    internal class Class22 : Class0
    {
        internal Class22(Class47 A_1) : base(A_1)
        {
        }

        internal void method_8(Class554 A_1, Class48 A_2)
        {
            A_2.method_3(base.int_1);
            for (int i = 0; i < base.int_0; i++)
            {
                Class554.Class532 class2 = new Class554.Class532 {
                    short_0 = A_2.method_9(),
                    short_1 = A_2.method_9(),
                    short_2 = A_2.method_9(),
                    short_3 = A_2.method_9(),
                    uint_0 = A_2.method_14()
                };
                A_2.method_12(base.bool_1);
                class2.int_0 = A_2.method_12(base.bool_0);
                A_2.method_12(base.bool_0);
                A_2.method_12(base.bool_1);
                A_1.arrayList_0.Add(class2);
            }
        }

        internal override void QQSV()
        {
            base.int_2 = (12 + (base.method_6(base.bool_1) * 2)) + (base.method_6(base.bool_0) * 2);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class954_0.method_4();
            bool flag2 = base.class47_0.class954_0.method_6();
            for (int i = 0; i < base.int_0; i++)
            {
                Class885 class2 = new Class885 {
                    short_0 = data.method_9(),
                    short_1 = data.method_9(),
                    short_2 = data.method_9(),
                    short_3 = data.method_9(),
                    uint_0 = data.method_14(),
                    int_0 = data.method_12(flag2),
                    int_1 = data.method_12(flag),
                    int_2 = data.method_12(flag),
                    int_3 = data.method_12(flag2)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_35;
            }
        }

        internal class Class885
        {
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal short short_0;
            internal short short_1;
            internal short short_2;
            internal short short_3;
            internal uint uint_0;
        }
    }
}

