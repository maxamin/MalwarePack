namespace ns0
{
    using System;

    internal class Class366 : Class335
    {
        private string string_0;

        internal Class366(Class552.Class545 A_1)
        {
            this.string_0 = Class519.class581_0[A_1.int_1].Substring(4);
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
    }
}

