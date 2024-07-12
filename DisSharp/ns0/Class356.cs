namespace ns0
{
    using System;

    internal abstract class Class356 : Class350
    {
        protected Class369 node;

        internal Class356()
        {
        }

        internal Class356(Class369 A_1)
        {
            this.node = A_1;
        }

        protected override void QQVX(string string_0)
        {
            this.node.Name = string_0;
            Class643.smethod_1(this.node);
        }

        public override string ToString()
        {
            return this.node.Name;
        }

        internal override int Length
        {
            get
            {
                return this.node.Name.Length;
            }
        }
    }
}

