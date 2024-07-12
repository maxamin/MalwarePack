namespace ns0
{
    using System;

    internal class Class346 : Class335
    {
        private Class581 class581_0;
        private int int_0;

        internal Class346(Class564.Class618 A_1)
        {
            this.int_0 = A_1.int_0;
            this.class581_0 = Class519.class581_0;
        }

        public override string ToString()
        {
            return this.class581_0[this.int_0];
        }

        internal override int Length
        {
            get
            {
                return this.class581_0[this.int_0].Length;
            }
        }
    }
}

