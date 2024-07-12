namespace ns0
{
    using System;

    internal class Class954 : Class953
    {
        internal byte byte_0;
        internal byte byte_1;
        internal byte byte_2;
        internal byte byte_3;
        internal Class47 class47_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal ulong ulong_0;
        internal ulong ulong_1;

        internal Class954(int A_1, int A_2, Class681 A_3)
        {
            this.int_1 = A_1;
            this.int_2 = A_2;
            this.class47_0 = A_3.class47_0;
        }

        internal void method_1()
        {
            this.class47_0 = null;
        }

        internal void method_2(Class48 A_1)
        {
            A_1.method_3(this.int_1);
            this.int_0 = A_1.method_11();
            this.byte_0 = A_1.method_8();
            this.byte_1 = A_1.method_8();
            this.byte_2 = A_1.method_8();
            this.byte_3 = A_1.method_8();
            this.ulong_0 = A_1.method_16();
            this.ulong_1 = A_1.method_16();
            this.class47_0.method_1(A_1);
        }

        internal int method_3()
        {
            int num = 0;
            for (int i = 0; i < 0x40; i++)
            {
                num += ((int) (this.ulong_0 >> i)) & 1;
            }
            return num;
        }

        internal bool method_4()
        {
            return ((this.byte_2 & 1) == 0);
        }

        internal bool method_5()
        {
            return ((this.byte_2 & 2) == 0);
        }

        internal bool method_6()
        {
            return ((this.byte_2 & 4) == 0);
        }
    }
}

