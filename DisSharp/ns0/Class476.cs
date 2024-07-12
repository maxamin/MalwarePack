namespace ns0
{
    using System;

    internal class Class476 : Class445
    {
        internal Class445 class445_0;
        internal Enum3 enum3_0;

        internal Class476()
        {
        }

        internal Class476(Class445 A_1, Enum3 A_2)
        {
            this.class445_0 = A_1;
            this.enum3_0 = A_2;
        }

        private bool method_1(Class658 A_1)
        {
            switch (A_1.enum11_0)
            {
                case Enum11.const_16:
                    return (this.enum3_0 == Enum3.const_0);

                case Enum11.const_17:
                    return (this.enum3_0 == Enum3.const_1);

                case Enum11.const_18:
                    return (this.enum3_0 == Enum3.const_2);

                case Enum11.const_19:
                    return (this.enum3_0 == Enum3.const_3);

                case Enum11.const_20:
                    return (this.enum3_0 == Enum3.const_4);

                case Enum11.const_21:
                    return (this.enum3_0 == Enum3.const_5);

                case Enum11.const_22:
                    return (this.enum3_0 == Enum3.const_6);

                case Enum11.const_23:
                    return (this.enum3_0 == Enum3.const_7);

                case Enum11.const_24:
                    return (this.enum3_0 == Enum3.const_8);

                case Enum11.const_25:
                    return (this.enum3_0 == Enum3.const_9);

                case Enum11.const_26:
                    return (this.enum3_0 == Enum3.const_10);

                case Enum11.const_27:
                    return (this.enum3_0 == Enum3.const_11);

                case Enum11.const_28:
                    return (this.enum3_0 == Enum3.const_12);

                case Enum11.const_29:
                    return (this.enum3_0 == Enum3.const_13);
            }
            return false;
        }

        internal override Class445 QQUS()
        {
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_0 = this.class445_0.QQUS();
            Class658 class2 = Class821.smethod_0(this.class445_0);
            if (this.method_1(class2))
            {
                return this.class445_0;
            }
            return Class996.smethod_3(this, this.class445_0, this.enum3_0);
        }

        internal override Class445 QQUU(Class658 type)
        {
            Class996.smethod_0(this, type.enum11_0);
            if ((type == Class658.class658_0) && (this.enum3_0 < Enum3.const_10))
            {
                return new Class470(new Class447(0), this, Enum31.const_0);
            }
            return Class860.smethod_0(this, type);
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
                return Enum17.const_28;
            }
        }
    }
}

