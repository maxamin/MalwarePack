namespace ns0
{
    using System;
    using System.Reflection;

    internal class Class893
    {
        private int[] int_0;
        internal int int_1;

        internal Class893() : this(10)
        {
        }

        internal Class893(int A_1)
        {
            this.int_0 = new int[A_1];
            this.int_1 = 0;
        }

        internal void method_0()
        {
            this.int_1 = 0;
        }

        internal void method_1(int A_1)
        {
            if (this.int_1 == this.int_0.Length)
            {
                int[] numArray = this.int_0;
                this.int_0 = new int[this.int_1 * 2];
                for (int i = 0; i < numArray.Length; i++)
                {
                    this.int_0[i] = numArray[i];
                }
            }
            this.int_0[this.int_1] = A_1;
            this.int_1++;
        }

        internal int[] method_2()
        {
            int[] numArray = new int[this.int_1];
            for (int i = 0; i < this.int_1; i++)
            {
                numArray[i] = this.int_0[i];
            }
            return numArray;
        }

        internal int this[int A_1]
        {
            get
            {
                return this.int_0[A_1];
            }
            set
            {
                this.int_0[A_1] = value;
            }
        }
    }
}

