namespace ns0
{
    using System;

    internal class Class353 : Class350
    {
        private Class581 class581_0;
        private int int_0;
        private string string_0;

        internal Class353(int A_1)
        {
            this.int_0 = A_1;
            this.class581_0 = Class519.class581_0;
            this.string_0 = Class846.smethod_13(this.class581_0[A_1]);
        }

        protected override void QQVX(string string_1)
        {
            this.class581_0[this.int_0] = string_1;
            this.string_0 = Class846.smethod_13(string_1);
        }

        protected override bool QQVY(string string_1)
        {
            return true;
        }

        public override string ToString()
        {
            return this.string_0;
        }

        internal override int Length
        {
            get
            {
                return this.string_0.Length;
            }
        }

        internal override int QQSX
        {
            get
            {
                return 7;
            }
        }
    }
}

