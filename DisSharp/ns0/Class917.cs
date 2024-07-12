namespace ns0
{
    using System;

    internal class Class917
    {
        internal const int int_0 = 0x48;
        internal int int_1;
        internal int int_10;
        internal int int_11;
        internal int int_12;
        internal int int_13;
        internal int int_14;
        internal int int_15;
        internal int int_16;
        internal int int_2;
        internal int int_3;
        internal int int_4;
        internal int int_5;
        internal int int_6;
        internal int int_7;
        internal int int_8;
        internal int int_9;
        internal short short_0;
        internal short short_1;
        internal uint uint_0;
        internal uint uint_1;

        internal Class917(int A_1)
        {
            this.int_16 = A_1;
        }

        internal void method_0(Class48 A_1)
        {
            A_1.method_3(this.int_16);
            this.int_1 = A_1.method_11();
            this.short_0 = A_1.method_9();
            this.short_1 = A_1.method_9();
            this.int_2 = A_1.method_11();
            this.int_3 = A_1.method_11();
            this.uint_0 = A_1.method_14();
            this.uint_1 = A_1.method_14();
            this.int_4 = A_1.method_11();
            this.int_5 = A_1.method_11();
            this.int_6 = A_1.method_11();
            this.int_7 = A_1.method_11();
            this.int_8 = A_1.method_11();
            this.int_9 = A_1.method_11();
            this.int_10 = A_1.method_11();
            this.int_11 = A_1.method_11();
            this.int_12 = A_1.method_11();
            this.int_13 = A_1.method_11();
            this.int_14 = A_1.method_11();
            this.int_15 = A_1.method_11();
        }

        internal bool method_1()
        {
            return ((this.uint_0 & 1) == 1);
        }

        internal bool method_2()
        {
            return ((this.uint_0 & 2) == 2);
        }

        internal bool method_3()
        {
            return ((this.uint_0 & 8) == 8);
        }

        internal bool method_4()
        {
            return ((this.uint_0 & 0x10000) == 0x10000);
        }
    }
}

