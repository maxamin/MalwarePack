namespace ns0
{
    using System;

    internal class Class971
    {
        internal byte byte_0;
        internal byte byte_1;
        private Class681 class681_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal int int_3;
        internal int int_4;
        internal int int_5;
        internal int int_6;
        internal short short_0;

        internal Class971(Class681 A_1, int A_2)
        {
            this.class681_0 = A_1;
            this.int_6 = A_2;
        }

        internal void method_0(Class48 A_1)
        {
            A_1.method_3(this.int_6);
            this.short_0 = A_1.method_9();
            this.byte_0 = A_1.method_8();
            this.byte_1 = A_1.method_8();
            this.int_0 = A_1.method_11();
            this.int_1 = A_1.method_11();
            this.int_2 = A_1.method_11();
            this.int_3 = A_1.method_11();
            this.int_4 = A_1.method_11();
            if (this.Boolean_0)
            {
                this.int_5 = A_1.method_11();
            }
        }

        internal bool Boolean_0
        {
            get
            {
                return (this.short_0 == 0x10b);
            }
        }

        internal bool Boolean_1
        {
            get
            {
                return (this.short_0 == 0x20b);
            }
        }

        internal int Int32_0
        {
            get
            {
                if (this.Boolean_0)
                {
                    return 0x1c;
                }
                return 0x18;
            }
        }
    }
}

