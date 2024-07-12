namespace ns0
{
    using System;

    internal class Class352 : Class350
    {
        private Class562 class562_0;
        private Class581 class581_0;
        private int int_0;
        private static int int_1 = string_0.Length;
        private static string string_0 = Class537.string_89;

        internal Class352(int A_1, Class562 A_2)
        {
            this.int_0 = A_1;
            this.class562_0 = A_2;
            this.class581_0 = Class519.class581_0;
        }

        protected override void QQVX(string string_1)
        {
            Class643.smethod_2(this.class581_0[this.int_0], string_1);
            this.class581_0[this.int_0] = string_1;
            this.class562_0.bool_1 = false;
        }

        protected override bool QQVY(string string_1)
        {
            return Class805.smethod_1(string_1);
        }

        public override string ToString()
        {
            if (this.class562_0.bool_1)
            {
                return string_0;
            }
            return this.class581_0[this.int_0];
        }

        internal override int Length
        {
            get
            {
                if (this.class562_0.bool_1)
                {
                    return int_1;
                }
                return this.class581_0[this.int_0].Length;
            }
        }
    }
}

