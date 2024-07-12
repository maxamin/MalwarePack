namespace ns0
{
    using System;

    internal class Class447 : Class445
    {
        internal int int_0;

        internal Class447()
        {
        }

        internal Class447(int A_1)
        {
            this.int_0 = A_1;
        }

        internal override Class445 QQUU(Class658 type)
        {
            switch (type.enum11_0)
            {
                case Enum11.const_1:
                case Enum11.const_16:
                    switch (this.int_0)
                    {
                        case 0:
                            return new Class451(false);

                        case 1:
                            return new Class451(true);
                    }
                    break;

                case Enum11.const_2:
                case Enum11.const_17:
                    return new Class471(this.int_0);

                case Enum11.const_36:
                case Enum11.const_37:
                    if (!Class961.smethod_0(type.int_0))
                    {
                        return new Class467(this, Class689.smethod_1(2, type.int_0));
                    }
                    return new Class472(Enum0.const_2, type.int_0, (long) this.int_0, Class961.bool_0);

                case Enum11.const_38:
                case Enum11.const_39:
                    if (!Class961.smethod_1(type.int_0))
                    {
                        return new Class467(this, Class689.smethod_1(1, type.int_0));
                    }
                    return new Class472(Enum0.const_1, type.int_0, (long) this.int_0, Class961.bool_0);

                case Enum11.const_41:
                    switch (Class546.class558_0.method_1(type.int_0))
                    {
                        case Enum11.const_16:
                            switch (this.int_0)
                            {
                                case 0:
                                    return new Class451(false);

                                case 1:
                                    return new Class451(true);
                            }
                            goto Label_01C4;

                        case Enum11.const_17:
                            return new Class471(this.int_0);

                        case Enum11.const_36:
                            if (Class961.smethod_0(type.int_0))
                            {
                                return new Class472(Enum0.const_2, Class546.class558_0.int_0, (long) this.int_0, Class961.bool_0);
                            }
                            return new Class467(this, Class689.smethod_1(2, Class546.class558_0.int_0));

                        case Enum11.const_38:
                            if (Class961.smethod_1(type.int_0))
                            {
                                return new Class472(Enum0.const_1, Class546.class558_0.int_0, (long) this.int_0, Class961.bool_0);
                            }
                            return new Class467(this, Class689.smethod_1(1, Class546.class558_0.int_0));
                    }
                    break;
            }
        Label_01C4:
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.int_0 = data.method_11();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.int_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_22;
            }
        }
    }
}

