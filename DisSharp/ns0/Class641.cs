namespace ns0
{
    using System;
    using System.Reflection;

    internal class Class641
    {
        private short[] short_0;
        internal short short_1;

        internal Class641() : this(4)
        {
        }

        internal Class641(short A_1)
        {
            this.short_0 = new short[A_1];
            this.short_1 = 0;
        }

        internal void method_0()
        {
            this.short_1 = 0;
        }

        internal void method_1(short A_1)
        {
            if (this.short_1 == this.short_0.Length)
            {
                short[] numArray = this.short_0;
                this.short_0 = new short[this.short_1 * 2];
                for (int i = 0; i < numArray.Length; i++)
                {
                    this.short_0[i] = numArray[i];
                }
            }
            this.short_0[this.short_1] = A_1;
            this.short_1 = (short) (this.short_1 + 1);
        }

        internal short this[int A_1]
        {
            get
            {
                return this.short_0[A_1];
            }
            set
            {
                this.short_0[A_1] = value;
            }
        }
    }
}

