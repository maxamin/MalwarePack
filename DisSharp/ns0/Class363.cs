namespace ns0
{
    using System;

    internal abstract class Class363 : Class350
    {
        private Class581 class581_0;
        protected int index;

        internal Class363(int A_1)
        {
            this.index = A_1;
            this.class581_0 = Class519.class581_0;
        }

        protected override void QQVX(string string_0)
        {
            this.class581_0[this.index] = string_0;
        }

        public override string ToString()
        {
            return this.class581_0[this.index];
        }

        internal override int Length
        {
            get
            {
                return this.class581_0[this.index].Length;
            }
        }
    }
}

