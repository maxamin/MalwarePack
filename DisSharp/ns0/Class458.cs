namespace ns0
{
    using System;

    internal class Class458 : Class445
    {
        internal Class445 class445_0;
        internal Class445 class445_1;

        internal Class458()
        {
        }

        internal Class458(Class445 A_1, Class445 A_2)
        {
            this.class445_0 = A_1;
            this.class445_1 = A_2;
        }

        internal override Class445 QQUS()
        {
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUS();
            Class658 class2 = Class821.smethod_0(this.class445_0);
            this.class445_1 = Class860.smethod_0(this.class445_1, class2);
            this.class445_1 = this.class445_1.QQUT();
            return this;
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type == Class658.class658_0)
            {
                return Class859.smethod_2(this, this.class445_0);
            }
            return Class860.smethod_0(this, type);
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.class445_1 = Class541.smethod_2(data);
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            this.class445_1.QQRW(writer);
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
                return Enum17.const_4;
            }
        }
    }
}

