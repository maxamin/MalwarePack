namespace ns0
{
    using System;

    internal class Class344 : Class335
    {
        private bool bool_0;
        private Class581 class581_0;
        private int int_0;

        internal Class344(Class390 A_1)
        {
            this.int_0 = A_1.class533_0.int_1;
            this.bool_0 = A_1.class533_0.bool_0;
            this.class581_0 = Class519.class581_0;
        }

        internal Class344(int A_1, bool A_2)
        {
            this.int_0 = A_1;
            this.bool_0 = A_2;
            this.class581_0 = Class519.class581_0;
        }

        protected override void QQVX(string string_0)
        {
            Class643.smethod_2(Class519.class581_0[this.int_0], string_0);
            this.class581_0[this.int_0] = string_0;
        }

        protected override bool QQVY(string string_0)
        {
            return Class805.smethod_1(string_0);
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
                if (this.bool_0)
                {
                    return 8;
                }
                return 3;
            }
        }

        internal override bool QQVW
        {
            get
            {
                return this.bool_0;
            }
        }
    }
}

