namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1107
    {
        internal ArrayList arrayList_0 = new ArrayList();
        internal Hashtable hashtable_0 = new Hashtable();
        internal int int_0;
        internal int int_1;

        internal Class1107(int A_1, int A_2)
        {
            this.int_0 = A_1;
            this.int_1 = A_2;
        }

        internal void method_0(Class48 A_1)
        {
            A_1.method_3(this.int_0);
            int num = this.int_0 + this.int_1;
            int num2 = 0;
            int num4 = A_1.int_0;
            while (A_1.int_0 < num)
            {
                int num3;
                int num5 = A_1.int_0;
                byte num6 = A_1.method_8();
                if ((num6 & 0x80) == 0)
                {
                    num3 = num6;
                }
                else
                {
                    byte num7 = A_1.method_8();
                    if ((num6 & 0x40) == 0)
                    {
                        num6 = (byte) (num6 & 0x3f);
                        num3 = (num6 << 8) + num7;
                    }
                    else
                    {
                        byte num8 = A_1.method_8();
                        byte num9 = A_1.method_8();
                        num6 = (byte) (num6 & 0x1f);
                        num3 = (((num6 << 0x18) + (num7 << 0x10)) + (num8 << 8)) + num9;
                    }
                }
                this.arrayList_0.Add(A_1.method_19(num3));
                this.hashtable_0.Add(num5 - num4, num2);
                num2++;
            }
        }

        internal byte[] method_1(int A_1)
        {
            return (byte[]) this.arrayList_0[(int) this.hashtable_0[A_1]];
        }
    }
}

