namespace ns0
{
    using System;

    internal class Class500 : Class445
    {
        internal int int_0;
        internal uint uint_0;

        internal Class500()
        {
        }

        internal Class500(uint A_1, int A_2)
        {
            this.uint_0 = A_1;
            this.int_0 = A_2;
        }

        internal override void QQVS(Class48 data)
        {
            this.uint_0 = data.method_14();
            this.int_0 = data.method_11();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.uint_0);
            writer.Write(this.int_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_54;
            }
        }
    }
}

