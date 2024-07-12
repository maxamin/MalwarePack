namespace ns0
{
    using System;

    internal class Class469 : Class445
    {
        internal Class445 class445_0;
        internal Enum3 enum3_0;

        internal Class469()
        {
        }

        internal Class469(Class445 A_1, Enum3 A_2)
        {
            this.class445_0 = A_1;
            this.enum3_0 = A_2;
        }

        internal override Class445 QQUS()
        {
            if ((this.enum3_0 == Enum3.const_7) && (this.class445_0.Type == Enum17.const_28))
            {
                Class476 class2 = this.class445_0 as Class476;
                if (class2.enum3_0 == Enum3.const_6)
                {
                    return Class821.smethod_9(class2.class445_0).QQUS();
                }
            }
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_0 = this.class445_0.QQUS();
            return this;
        }

        internal override Class445 QQUU(Class658 type)
        {
            if ((type == Class658.class658_0) && (this.enum3_0 < Enum3.const_10))
            {
                return new Class470(new Class447(0), this, Enum31.const_0);
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum3_0 = (Enum3) data.method_8();
            this.class445_0 = Class541.smethod_2(data);
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum3_0);
            this.class445_0.QQRW(writer);
        }

        internal override bool QQVV
        {
            get
            {
                return true;
            }
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_15;
            }
        }
    }
}

