namespace ns0
{
    using System;

    internal class Class494 : Class445
    {
        internal Class445 class445_0;
        internal Class445 class445_1;
        internal Enum11 enum11_0;
        internal int int_0;

        internal Class494()
        {
        }

        internal Class494(Enum11 A_1, int A_2, Class445 A_3, Class445 A_4)
        {
            this.enum11_0 = A_1;
            this.int_0 = A_2;
            this.class445_0 = A_3;
            this.class445_1 = A_4;
        }

        internal override Class445 QQUS()
        {
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUS();
            this.class445_1 = this.class445_1.QQUS();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum11_0 = (Enum11) data.method_8();
            this.int_0 = data.method_11();
            this.class445_0 = Class541.smethod_2(data);
            this.class445_1 = Class541.smethod_2(data);
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum11_0);
            writer.Write(this.int_0);
            this.class445_0.QQRW(writer);
            this.class445_1.QQRW(writer);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_48;
            }
        }
    }
}

