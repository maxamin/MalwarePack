namespace ns0
{
    using System;

    internal class Class955 : Class953
    {
        internal byte[] byte_0;
        internal byte[][] byte_1;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal int[] int_3;
        internal int[] int_4;
        internal int[] int_5;
        internal int int_6;
        internal short short_0;
        internal short short_1;
        internal short short_2;
        internal ushort ushort_0;

        internal Class955(int A_1)
        {
            this.int_6 = A_1;
            this.byte_1 = new byte[5][];
            this.int_5 = new int[5];
        }

        internal void method_1(Class48 A_1)
        {
            A_1.method_3(this.int_6);
            int num = A_1.int_0 % 4;
            this.int_0 = A_1.method_11();
            this.short_0 = A_1.method_9();
            this.short_1 = A_1.method_9();
            this.int_1 = A_1.method_11();
            this.int_2 = A_1.method_11();
            this.byte_0 = A_1.method_19(this.int_2);
            this.ushort_0 = A_1.method_10();
            this.short_2 = A_1.method_9();
            this.int_3 = new int[this.short_2];
            this.int_4 = new int[this.short_2];
            for (int i = 0; i < this.short_2; i++)
            {
                byte num4;
                this.int_3[i] = A_1.method_11();
                this.int_4[i] = A_1.method_11();
                this.byte_1[i] = new byte[10];
                int index = 0;
                goto Label_00E2;
            Label_00D3:
                this.byte_1[i][index] = num4;
                index++;
            Label_00E2:
                num4 = A_1.method_8();
                if (num4 != 0)
                {
                    goto Label_00D3;
                }
                this.byte_1[i][index] = num4;
                this.int_5[i] = index;
                goto Label_010C;
            Label_0102:
                if (A_1.method_8() != 0)
                {
                    goto Label_0119;
                }
            Label_010C:
                if ((A_1.int_0 % 4) == num)
                {
                    continue;
                }
                goto Label_0102;
            Label_0119:
                A_1.method_4(-1);
            }
        }

        private int method_2(int A_1)
        {
            for (int i = 0; i < this.short_2; i++)
            {
                if (this.byte_1[i][1] == A_1)
                {
                    return i;
                }
            }
            return -1;
        }

        private int method_3(char A_1)
        {
            int index = this.method_2(A_1);
            if (index != -1)
            {
                return (this.int_6 + this.int_3[index]);
            }
            return 0;
        }

        private int method_4(char A_1)
        {
            int index = this.method_2(A_1);
            if (index != -1)
            {
                return this.int_4[index];
            }
            return 0;
        }

        internal int Int32_0
        {
            get
            {
                return this.method_3('S');
            }
        }

        internal int Int32_1
        {
            get
            {
                return this.method_4('S');
            }
        }

        internal int Int32_2
        {
            get
            {
                return this.method_3('U');
            }
        }

        internal int Int32_3
        {
            get
            {
                return this.method_4('U');
            }
        }

        internal int Int32_4
        {
            get
            {
                return this.method_3('B');
            }
        }

        internal int Int32_5
        {
            get
            {
                return this.method_4('B');
            }
        }

        internal int Int32_6
        {
            get
            {
                return this.method_3('G');
            }
        }

        internal int Int32_7
        {
            get
            {
                return this.method_4('G');
            }
        }

        internal int Int32_8
        {
            get
            {
                int num = this.method_3('~');
                if (num > 0)
                {
                    return num;
                }
                return this.method_3('-');
            }
        }

        internal int Int32_9
        {
            get
            {
                int num = this.method_4('~');
                if (num > 0)
                {
                    return num;
                }
                return this.method_4('-');
            }
        }
    }
}

