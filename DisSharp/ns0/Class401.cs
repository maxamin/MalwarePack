namespace ns0
{
    using System;

    internal class Class401 : Class398
    {
        internal Class445 class445_0;
        internal Class445 class445_1;
        internal Enum1 enum1_0;

        internal Class401()
        {
        }

        internal Class401(Class445 A_1, Class445 A_2, Enum1 A_3)
        {
            this.class445_0 = A_1;
            this.class445_1 = A_2;
            this.enum1_0 = A_3;
        }

        internal override Class398 QQUS()
        {
            this.class445_1 = this.class445_1.QQUU(Class821.smethod_0(this.class445_0));
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUT();
            this.class445_1 = this.class445_1.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.class445_1 = Class541.smethod_2(data);
            this.enum1_0 = (Enum1) data.method_8();
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            this.class445_1.QQRW(writer);
            writer.Write((byte) this.enum1_0);
        }

        internal static void smethod_0(Class397 A_0, Enum1 A_1)
        {
            switch (A_1)
            {
                case Enum1.const_0:
                    A_0.method_10(Class518.class337_75);
                    return;

                case Enum1.const_1:
                case Enum1.const_8:
                    break;

                case Enum1.const_2:
                    A_0.method_10(Class518.class337_79);
                    return;

                case Enum1.const_3:
                    A_0.method_10(Class518.class337_81);
                    return;

                case Enum1.const_4:
                    A_0.method_10(Class518.class337_80);
                    return;

                case Enum1.const_5:
                    A_0.method_10(Class518.class337_73);
                    return;

                case Enum1.const_6:
                    A_0.method_10(Class518.class337_74);
                    return;

                case Enum1.const_7:
                    A_0.method_10(Class518.class337_72);
                    return;

                case Enum1.const_9:
                    A_0.method_10(Class518.class337_77);
                    return;

                case Enum1.const_10:
                    A_0.method_10(Class518.class337_78);
                    return;

                case Enum1.const_11:
                    A_0.method_10(Class518.class337_76);
                    break;

                default:
                    return;
            }
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_2;
            }
        }
    }
}

