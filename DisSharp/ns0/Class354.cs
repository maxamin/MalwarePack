namespace ns0
{
    using System;

    internal class Class354 : Class350
    {
        private Class581 class581_0;
        private Class574.Class636 class636_0;

        internal Class354(Class574.Class636 A_1)
        {
            this.class636_0 = A_1;
            this.class581_0 = Class519.class581_0;
        }

        internal Class354(int A_1)
        {
            this.class636_0 = Class546.class574_0.arrayList_0[A_1] as Class574.Class636;
            this.class581_0 = Class519.class581_0;
        }

        protected override void QQVX(string string_0)
        {
            this.class581_0[this.class636_0.int_0] = string_0;
        }

        public override string ToString()
        {
            return this.class581_0[this.class636_0.int_0];
        }

        internal override int Length
        {
            get
            {
                return this.class581_0[this.class636_0.int_0].Length;
            }
        }
    }
}

