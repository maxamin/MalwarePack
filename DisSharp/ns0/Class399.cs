namespace ns0
{
    using System;

    internal class Class399 : Class398
    {
        internal Class445 class445_0;
        internal Class445 class445_1;

        internal Class399()
        {
        }

        internal Class399(Class445 A_1, Class445 A_2)
        {
            this.class445_0 = A_1;
            this.class445_1 = A_2;
        }

        internal Class462 method_8()
        {
            return new Class462(this.class445_0, this.class445_1);
        }

        internal override Class398 QQUS()
        {
            if (Class979.bool_0 && ((this.class445_0.Type == Enum17.const_44) || (this.class445_0.Type == Enum17.const_45)))
            {
                Class979.smethod_5(this, this.class445_0 as Class452);
            }
            if ((Class519.class528_0.Boolean_8 || (this.class445_0.Type != Enum17.const_2)) || ((this.class445_0 as Class456).ushort_0 != 0))
            {
                this.class445_1 = this.class445_1.QQUU(Class821.smethod_0(this.class445_0));
            }
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUT();
            this.class445_1 = this.class445_1.QQUT();
            return this;
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

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_0;
            }
        }
    }
}

