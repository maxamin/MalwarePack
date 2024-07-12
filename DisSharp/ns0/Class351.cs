namespace ns0
{
    using System;

    internal class Class351 : Class350
    {
        private Class581 class581_0;
        private int int_0;

        internal Class351(int A_1)
        {
            this.int_0 = A_1;
            this.class581_0 = Class519.class581_0;
        }

        protected override void QQVX(string string_0)
        {
            this.class581_0[this.int_0] = string_0;
        }

        protected override bool QQVY(string string_0)
        {
            return true;
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

        internal override int QQSX
        {
            get
            {
                return 8;
            }
        }
    }
}

