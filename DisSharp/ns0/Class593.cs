namespace ns0
{
    using System;

    internal abstract class Class593
    {
        internal int int_0;
        internal int int_1 = 20;
        internal Struct10[] struct10_0 = new Struct10[20];

        protected Class593()
        {
        }

        internal void method_0()
        {
            this.int_0 = 0;
        }

        internal void method_1(string A_1, Enum62 A_2)
        {
            this.int_0++;
            if (this.int_0 >= this.int_1)
            {
                this.int_1 *= 2;
                Struct10[] structArray = this.struct10_0;
                this.struct10_0 = new Struct10[this.int_1];
                for (int i = 0; i < (this.int_0 - 1); i++)
                {
                    this.struct10_0[i] = structArray[i];
                }
            }
            int index = this.int_0 - 1;
            this.struct10_0[index].string_0 = A_1;
            this.struct10_0[index].enum62_0 = A_2;
        }
    }
}

