namespace ns0
{
    using System;

    internal class Class470 : Class445
    {
        internal bool bool_0;
        internal Class445 class445_0;
        internal Class445 class445_1;
        internal Enum31 enum31_0;

        internal Class470()
        {
        }

        internal Class470(Class445 A_1, Class445 A_2, Enum31 A_3)
        {
            this.class445_0 = A_2;
            this.class445_1 = A_1;
            this.enum31_0 = A_3;
        }

        internal override Class445 QQUS()
        {
            Class476 class2 = this.class445_1 as Class476;
            if (class2 != null)
            {
                switch (Class821.smethod_0(this.class445_0).enum11_0)
                {
                    case Enum11.const_19:
                        if (class2.enum3_0 == Enum3.const_3)
                        {
                            this.class445_1 = class2.class445_0;
                        }
                        break;

                    case Enum11.const_20:
                        if (class2.enum3_0 == Enum3.const_4)
                        {
                            this.class445_1 = class2.class445_0;
                        }
                        break;

                    case Enum11.const_22:
                        if (class2.enum3_0 == Enum3.const_6)
                        {
                            this.class445_1 = class2.class445_0;
                        }
                        break;

                    case Enum11.const_24:
                        if (class2.enum3_0 == Enum3.const_8)
                        {
                            this.class445_1 = class2.class445_0;
                        }
                        break;
                }
            }
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUS();
            this.class445_1 = this.class445_1.QQUS();
            Class960.smethod_0(this);
            if (this.enum31_0 == Enum31.const_0)
            {
                Class451 class3 = this.class445_1 as Class451;
                if (class3 != null)
                {
                    if (class3.bool_0)
                    {
                        return this.class445_0;
                    }
                    if (!class3.bool_0)
                    {
                        Class1021.bool_0 = true;
                        return Class858.smethod_1(this.class445_0, true);
                    }
                }
            }
            if (this.enum31_0 == Enum31.const_1)
            {
                Class451 class4 = this.class445_1 as Class451;
                if (class4 != null)
                {
                    if (class4.bool_0)
                    {
                        Class1021.bool_0 = true;
                        return Class858.smethod_1(this.class445_0, true);
                    }
                    if (!class4.bool_0)
                    {
                        return this.class445_0;
                    }
                }
            }
            if (this.enum31_0 == Enum31.const_4)
            {
                Class490 class5 = this.class445_0 as Class490;
                if ((class5 != null) && (this.class445_1 is Class496))
                {
                    class5.bool_1 = true;
                    class5.bool_0 = this.bool_0;
                    return class5;
                }
            }
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
            this.enum31_0 = (Enum31) data.method_8();
            this.class445_0 = Class541.smethod_2(data);
            this.class445_1 = Class541.smethod_2(data);
            this.bool_0 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum31_0);
            this.class445_0.QQRW(writer);
            this.class445_1.QQRW(writer);
            writer.Write(this.bool_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_16;
            }
        }
    }
}

