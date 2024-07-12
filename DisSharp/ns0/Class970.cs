namespace ns0
{
    using System;

    internal class Class970
    {
        private Class681 class681_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal int int_3;
        internal int int_4;
        internal int int_5;
        internal int int_6;
        internal int int_7;
        internal int int_8;
        internal long long_0;
        internal long long_1;
        internal long long_2;
        internal long long_3;
        internal long long_4;
        internal short short_0;
        internal short short_1;
        internal short short_2;
        internal short short_3;
        internal short short_4;
        internal short short_5;
        internal short short_6;
        internal short short_7;

        internal Class970(Class681 A_1, int A_2)
        {
            this.class681_0 = A_1;
            this.int_8 = A_2;
        }

        internal void method_0(Class48 A_1)
        {
            A_1.method_3(this.int_8);
            if (this.class681_0.class971_0.Boolean_0)
            {
                this.long_0 = A_1.method_11();
            }
            else
            {
                this.long_0 = A_1.method_15();
            }
            this.int_0 = A_1.method_11();
            this.int_1 = A_1.method_11();
            this.short_0 = A_1.method_9();
            this.short_1 = A_1.method_9();
            this.short_2 = A_1.method_9();
            this.short_3 = A_1.method_9();
            this.short_4 = A_1.method_9();
            this.short_5 = A_1.method_9();
            this.int_2 = A_1.method_11();
            this.int_3 = A_1.method_11();
            this.int_4 = A_1.method_11();
            this.int_5 = A_1.method_11();
            this.short_6 = A_1.method_9();
            this.short_7 = A_1.method_9();
            if (this.class681_0.class971_0.Boolean_0)
            {
                this.long_1 = A_1.method_11();
                this.long_2 = A_1.method_11();
                this.long_3 = A_1.method_11();
                this.long_4 = A_1.method_11();
            }
            else
            {
                this.long_1 = A_1.method_15();
                this.long_2 = A_1.method_15();
                this.long_3 = A_1.method_15();
                this.long_4 = A_1.method_15();
            }
            this.int_6 = A_1.method_11();
            this.int_7 = A_1.method_11();
        }

        internal int Int32_0
        {
            get
            {
                if (this.class681_0.class971_0.Boolean_0)
                {
                    return 0x44;
                }
                return 0x58;
            }
        }
    }
}

