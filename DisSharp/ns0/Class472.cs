namespace ns0
{
    using System;

    internal class Class472 : Class445
    {
        internal bool bool_0;
        internal bool bool_1;
        internal Enum0 enum0_0;
        internal int int_0;
        internal long long_0;

        internal Class472()
        {
        }

        internal Class472(Enum0 A_1, int A_2, long A_3, bool A_4)
        {
            this.enum0_0 = A_1;
            this.int_0 = A_2;
            this.long_0 = A_3;
            this.bool_0 = A_4;
        }

        internal override Class445 QQUT()
        {
            this.bool_1 = true;
            return this.QQUS();
        }

        internal override void QQUW()
        {
            this.bool_1 = false;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum0_0 = (Enum0) data.method_8();
            this.int_0 = data.method_11();
            this.long_0 = data.method_15();
            this.bool_0 = data.method_5();
            this.bool_1 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum0_0);
            writer.Write(this.int_0);
            writer.Write(this.long_0);
            writer.Write(this.bool_0);
            writer.Write(this.bool_1);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_20;
            }
        }
    }
}

