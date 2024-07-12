namespace ns0
{
    using System;

    internal class Class468 : Class445
    {
        internal bool bool_0;
        internal Class445 class445_0;
        internal Class445 class445_1;
        internal Enum1 enum1_0;

        internal Class468()
        {
        }

        internal Class468(Class445 A_1, Class445 A_2, Enum1 A_3)
        {
            this.class445_0 = A_2;
            this.class445_1 = A_1;
            this.enum1_0 = A_3;
        }

        internal override Class445 QQUS()
        {
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUS();
            this.class445_1 = this.class445_1.QQUS();
            return this;
        }

        internal override Class445 QQUT()
        {
            this.bool_0 = true;
            return this.QQUS();
        }

        internal override void QQUW()
        {
            this.bool_0 = false;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum1_0 = (Enum1) data.method_8();
            this.class445_0 = Class541.smethod_2(data);
            this.class445_1 = Class541.smethod_2(data);
            this.bool_0 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum1_0);
            this.class445_0.QQRW(writer);
            this.class445_1.QQRW(writer);
            writer.Write(this.bool_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_14;
            }
        }
    }
}

