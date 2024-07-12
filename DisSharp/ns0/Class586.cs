namespace ns0
{
    using System;

    internal abstract class Class586
    {
        internal int int_0;
        internal int int_1 = 20;
        internal Struct9[] struct9_0 = new Struct9[20];

        protected Class586()
        {
        }

        internal void method_0()
        {
            this.int_0 = 0;
        }

        internal void method_1(Class335 A_1, Enum62 A_2)
        {
            this.int_0++;
            if (this.int_0 >= this.int_1)
            {
                this.int_1 *= 2;
                Struct9[] structArray = this.struct9_0;
                this.struct9_0 = new Struct9[this.int_1];
                for (int i = 0; i < (this.int_0 - 1); i++)
                {
                    this.struct9_0[i] = structArray[i];
                }
            }
            int index = this.int_0 - 1;
            this.struct9_0[index].class335_0 = A_1;
            this.struct9_0[index].enum62_0 = A_2;
        }

        internal abstract void QRZT(Class397 lines);
    }
}

