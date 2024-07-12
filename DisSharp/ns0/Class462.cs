namespace ns0
{
    using System;

    internal class Class462 : Class445
    {
        internal Class445 class445_0;
        internal Class445 class445_1;

        internal Class462()
        {
        }

        internal Class462(Class445 A_1, Class445 A_2)
        {
            this.class445_0 = A_1;
            this.class445_1 = A_2;
        }

        internal override Class445 QQUS()
        {
            if (this.class445_1.Type == Enum17.const_9)
            {
                Class463 class2 = this.class445_1 as Class463;
                Class445 class3 = class2.class445_0;
                if (this.class445_0.method_0(class3))
                {
                    Class445 class4 = class2.class445_1;
                    if (class4.Type == Enum17.const_22)
                    {
                        Class447 class5 = class4 as Class447;
                        if (class5.int_0 == 1)
                        {
                            switch (class2.enum1_0)
                            {
                                case Enum1.const_0:
                                    return new Class480(this.class445_0);

                                case Enum1.const_11:
                                    return new Class477(this.class445_0);
                            }
                        }
                    }
                }
            }
            if (Class979.bool_0 && (this.class445_0.Type == Enum17.const_44))
            {
                Class979.smethod_6(this, this.class445_0 as Class452);
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

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_8;
            }
        }
    }
}

