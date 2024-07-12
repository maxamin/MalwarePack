namespace ns0
{
    using System;

    internal class Class448 : Class445
    {
        internal long long_0;

        internal Class448()
        {
        }

        internal Class448(long A_1)
        {
            this.long_0 = A_1;
        }

        internal override Class445 QQUU(Class658 type)
        {
            switch (type.enum11_0)
            {
                case Enum11.const_36:
                    if (!Class961.smethod_0(type.int_0))
                    {
                        return new Class467(this, Class689.smethod_1(2, type.int_0));
                    }
                    return new Class472(Enum0.const_2, type.int_0, this.long_0, Class961.bool_0);

                case Enum11.const_38:
                    if (Class961.smethod_1(type.int_0))
                    {
                        return new Class472(Enum0.const_1, type.int_0, this.long_0, Class961.bool_0);
                    }
                    return new Class467(this, Class689.smethod_1(1, type.int_0));

                case Enum11.const_25:
                    return new Class475(this.long_0);
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.long_0 = data.method_15();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.long_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_23;
            }
        }
    }
}

