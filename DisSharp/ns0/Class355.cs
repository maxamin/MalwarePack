namespace ns0
{
    using System;

    internal class Class355 : Class350
    {
        private Class581 class581_0;
        private Class568.Class623 class623_0;

        internal Class355(Class568.Class623 A_1)
        {
            this.class623_0 = A_1;
            this.class581_0 = Class519.class581_0;
        }

        internal Class355(int A_1)
        {
            this.class623_0 = Class546.class568_0.arrayList_0[A_1] as Class568.Class623;
            this.class581_0 = Class519.class581_0;
        }

        protected override void QQVX(string string_0)
        {
            this.class581_0[this.class623_0.int_0] = string_0;
        }

        public override string ToString()
        {
            return this.class581_0[this.class623_0.int_0];
        }

        internal override int Length
        {
            get
            {
                return this.class581_0[this.class623_0.int_0].Length;
            }
        }
    }
}

