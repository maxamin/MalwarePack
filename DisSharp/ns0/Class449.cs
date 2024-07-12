namespace ns0
{
    using System;

    internal class Class449 : Class445
    {
        internal float float_0;

        internal Class449()
        {
        }

        internal Class449(float A_1)
        {
            this.float_0 = A_1;
        }

        internal override void QQVS(Class48 data)
        {
            this.float_0 = data.method_17();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.float_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_21;
            }
        }
    }
}

