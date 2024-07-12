namespace ns0
{
    using System;

    internal class Class474 : Class445
    {
        internal uint uint_0;

        internal Class474()
        {
        }

        internal Class474(int A_1)
        {
            this.uint_0 = (uint) A_1;
        }

        internal override void QQVS(Class48 data)
        {
            this.uint_0 = data.method_14();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.uint_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_26;
            }
        }
    }
}

