namespace ns0
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;

    internal class Class1121
    {
        internal Hashtable hashtable_0 = new Hashtable();
        internal int int_0;
        internal int int_1;
        internal StringCollection stringCollection_0 = new StringCollection();

        internal Class1121(int A_1, int A_2)
        {
            this.int_0 = A_1;
            this.int_1 = A_2;
        }

        internal void method_0(Class48 A_1)
        {
            A_1.method_3(this.int_0);
            int num = this.int_0 + this.int_1;
            int num2 = 0;
            int num3 = A_1.int_0;
            while (A_1.int_0 < num)
            {
                int num4 = A_1.int_0;
                string str = A_1.method_22();
                if ((num2 == 0) || (str != string.Empty))
                {
                    this.stringCollection_0.Add(str);
                    this.hashtable_0.Add(num4 - num3, num2);
                    num2++;
                }
            }
        }

        internal string method_1(int A_1)
        {
            return this.stringCollection_0[(int) this.hashtable_0[A_1]];
        }
    }
}

