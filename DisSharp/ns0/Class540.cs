namespace ns0
{
    using System;
    using System.Reflection;

    internal class Class540
    {
        private ushort[] ushort_0;
        internal ushort ushort_1;

        internal Class540() : this(4)
        {
        }

        internal Class540(short A_1)
        {
            this.ushort_0 = new ushort[A_1];
            this.ushort_1 = 0;
        }

        internal void method_0()
        {
            this.ushort_1 = 0;
        }

        internal void method_1(ushort A_1)
        {
            if (this.ushort_1 == this.ushort_0.Length)
            {
                ushort[] numArray = this.ushort_0;
                this.ushort_0 = new ushort[this.ushort_1 * 2];
                for (int i = 0; i < numArray.Length; i++)
                {
                    this.ushort_0[i] = numArray[i];
                }
            }
            this.ushort_0[this.ushort_1] = A_1;
            this.ushort_1 = (ushort) (this.ushort_1 + 1);
        }

        internal void method_2(Class524 A_1)
        {
            A_1.Write(this.ushort_1);
            for (int i = 0; i < this.ushort_1; i++)
            {
                A_1.Write(this.ushort_0[i]);
            }
        }

        internal void method_3(Class48 A_1)
        {
            this.method_0();
            ushort num = A_1.method_10();
            for (int i = 0; i < num; i++)
            {
                this.method_1(A_1.method_10());
            }
        }

        internal ushort this[int A_1]
        {
            get
            {
                return this.ushort_0[A_1];
            }
            set
            {
                this.ushort_0[A_1] = value;
            }
        }
    }
}

