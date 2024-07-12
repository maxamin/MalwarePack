namespace ns0
{
    using System;

    internal class Class682
    {
        private Class683[] class683_0 = new Class683[20];
        internal int int_0;
        internal int int_1;

        internal Class682(int A_1, int A_2)
        {
            this.int_0 = A_1;
            this.int_1 = A_2;
        }

        internal void method_0(Class48 A_1)
        {
            A_1.method_3(this.int_0);
            for (int i = 0; i < this.int_1; i++)
            {
                Class683 class2 = new Class683 {
                    byte_0 = A_1.method_19(8),
                    int_1 = A_1.method_11(),
                    int_2 = A_1.method_11(),
                    int_3 = A_1.method_11()
                };
                class2.int_4 = class2.int_2 + class2.int_3;
                class2.int_5 = A_1.method_11();
                class2.int_6 = A_1.method_11();
                class2.int_7 = A_1.method_11();
                class2.short_0 = A_1.method_9();
                class2.short_1 = A_1.method_9();
                class2.uint_0 = A_1.method_14();
                this.class683_0[i] = class2;
            }
        }

        internal int method_1(int A_1)
        {
            if (A_1 > 0)
            {
                for (int i = 0; i < this.int_1; i++)
                {
                    Class683 class2 = this.class683_0[i];
                    if ((A_1 >= class2.int_2) && (A_1 < class2.int_4))
                    {
                        return ((A_1 - class2.int_2) + class2.int_5);
                    }
                }
            }
            return -1;
        }

        internal class Class683
        {
            internal byte[] byte_0 = new byte[8];
            internal const int int_0 = 40;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal int int_4;
            internal int int_5;
            internal int int_6;
            internal int int_7;
            internal short short_0;
            internal short short_1;
            internal uint uint_0;
        }
    }
}

