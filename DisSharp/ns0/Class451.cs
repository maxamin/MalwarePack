namespace ns0
{
    using System;

    internal class Class451 : Class445
    {
        internal bool bool_0;

        internal Class451()
        {
        }

        internal Class451(bool A_1)
        {
            this.bool_0 = A_1;
        }

        internal override void QQVS(Class48 data)
        {
            this.bool_0 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.bool_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_17;
            }
        }
    }
}

