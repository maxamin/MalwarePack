namespace ns0
{
    using System;

    internal class Class513 : Class445
    {
        internal Class445 class445_0;
        internal Enum32 enum32_0;

        internal Class513()
        {
        }

        internal Class513(Class445 A_1, Enum32 A_2)
        {
            this.class445_0 = A_1;
            this.enum32_0 = A_2;
        }

        internal override Class445 QQUS()
        {
            this.class445_0 = this.class445_0.QQUS();
            if (this.enum32_0 == Enum32.const_2)
            {
                Class470 class2 = this.class445_0 as Class470;
                if (class2 != null)
                {
                    Class858.smethod_3(class2);
                    Class1021.bool_0 = true;
                    return class2;
                }
                Class513 class3 = this.class445_0 as Class513;
                if ((class3 != null) && (class3.enum32_0 == Enum32.const_2))
                {
                    return class3.class445_0;
                }
                Class490 class4 = this.class445_0 as Class490;
                if ((class4 != null) && !class4.bool_1)
                {
                    class4.bool_1 = true;
                    class4.bool_0 = true;
                    return class4;
                }
            }
            return this;
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type == Class658.class658_0)
            {
                switch (this.enum32_0)
                {
                    case Enum32.const_0:
                    case Enum32.const_1:
                    case Enum32.const_3:
                        return new Class470(new Class447(0), this, Enum31.const_0);
                }
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum32_0 = (Enum32) data.method_8();
            this.class445_0 = Class541.smethod_2(data);
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum32_0);
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
                return Enum17.const_66;
            }
        }
    }
}

