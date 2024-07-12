namespace ns0
{
    using System;

    internal class Class423 : Class398
    {
        internal Class445 class445_0;
        internal Class445 class445_1;
        internal Enum1 enum1_0;
        internal uint uint_0;

        internal Class423()
        {
        }

        internal Class423(Class445 A_1, uint A_2, Class445 A_3, Enum1 A_4)
        {
            this.class445_0 = A_1;
            this.uint_0 = A_2;
            this.class445_1 = A_3;
            this.enum1_0 = A_4;
        }

        internal override Class398 QQUS()
        {
            this.class445_1 = this.class445_1.QQUU(Class821.smethod_7(this.uint_0));
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUS();
            this.class445_1 = this.class445_1.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.uint_0 = data.method_14();
            this.class445_1 = Class541.smethod_2(data);
            this.enum1_0 = (Enum1) data.method_8();
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write(this.uint_0);
            this.class445_1.QQRW(writer);
            writer.Write((byte) this.enum1_0);
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_23;
            }
        }
    }
}

