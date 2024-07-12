namespace ns0
{
    using System;

    internal class Class807
    {
        internal const int int_0 = 20;
        internal int int_1;
        internal int int_2;
        internal int int_3;
        internal int int_4;
        internal short short_0;
        internal short short_1;
        internal short short_2;
        internal ushort ushort_0;

        internal Class807(int A_1)
        {
            this.int_4 = A_1;
        }

        internal void method_0(Class48 A_1)
        {
            A_1.method_3(this.int_4);
            this.short_0 = A_1.method_9();
            this.short_1 = A_1.method_9();
            this.int_1 = A_1.method_11();
            this.int_2 = A_1.method_11();
            this.int_3 = A_1.method_11();
            this.short_2 = A_1.method_9();
            this.ushort_0 = A_1.method_10();
        }

        internal bool method_1()
        {
            return !this.method_14();
        }

        internal bool method_10()
        {
            return ((this.ushort_0 & 0x200) == 0x200);
        }

        internal bool method_11()
        {
            return ((this.ushort_0 & 0x400) == 0x400);
        }

        internal bool method_12()
        {
            return ((this.ushort_0 & 0x800) == 0x800);
        }

        internal bool method_13()
        {
            return ((this.ushort_0 & 0x1000) == 0x1000);
        }

        internal bool method_14()
        {
            return ((this.ushort_0 & 0x2000) == 0x2000);
        }

        internal bool method_15()
        {
            return ((this.ushort_0 & 0x4000) == 0x4000);
        }

        internal bool method_16()
        {
            return ((this.ushort_0 & 0x8000) == 0x8000);
        }

        internal bool method_2()
        {
            return ((this.ushort_0 & 1) == 1);
        }

        internal bool method_3()
        {
            return ((this.ushort_0 & 2) == 2);
        }

        internal bool method_4()
        {
            return ((this.ushort_0 & 4) == 4);
        }

        internal bool method_5()
        {
            return ((this.ushort_0 & 8) == 8);
        }

        internal bool method_6()
        {
            return ((this.ushort_0 & 0x10) == 0x10);
        }

        internal bool method_7()
        {
            return ((this.ushort_0 & 0x20) == 0x20);
        }

        internal bool method_8()
        {
            return ((this.ushort_0 & 0x80) == 0x80);
        }

        internal bool method_9()
        {
            return ((this.ushort_0 & 0x100) == 0x100);
        }
    }
}

