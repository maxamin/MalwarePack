namespace ns0
{
    using System;
    using System.Reflection;

    internal class Class907
    {
        internal int int_0;
        private uint[] uint_0;

        internal Class907() : this(10)
        {
        }

        internal Class907(int A_1)
        {
            this.uint_0 = new uint[A_1];
            this.int_0 = 0;
        }

        internal void method_0()
        {
            this.int_0 = 0;
        }

        internal void method_1(uint A_1)
        {
            if (this.int_0 == this.uint_0.Length)
            {
                uint[] numArray = this.uint_0;
                this.uint_0 = new uint[this.int_0 * 2];
                for (int i = 0; i < numArray.Length; i++)
                {
                    this.uint_0[i] = numArray[i];
                }
            }
            this.uint_0[this.int_0] = A_1;
            this.int_0++;
        }

        internal void method_2(Class524 A_1)
        {
            A_1.Write(this.int_0);
            for (int i = 0; i < this.int_0; i++)
            {
                A_1.Write(this.uint_0[i]);
            }
        }

        internal void method_3(Class656 A_1)
        {
            int num = A_1.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                this.method_1(A_1.ReadUInt32());
            }
        }

        internal uint this[int A_1]
        {
            get
            {
                return this.uint_0[A_1];
            }
            set
            {
                this.uint_0[A_1] = value;
            }
        }
    }
}

