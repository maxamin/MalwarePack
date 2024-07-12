namespace ns0
{
    using System;

    internal class Class428 : Class398
    {
        internal Class445 class445_0;

        internal Class428()
        {
        }

        internal Class428(Class445 A_1)
        {
            this.class445_0 = A_1;
        }

        internal override Class398 QQUS()
        {
            if (this.class445_0 != null)
            {
                this.class445_0 = this.class445_0.QQUV();
                this.class445_0 = Class821.smethod_9(this.class445_0);
                this.class445_0 = this.class445_0.QQUT();
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            if (data.method_8() == 1)
            {
                this.class445_0 = Class541.smethod_2(data);
            }
        }

        internal override void QQVT(Class524 writer)
        {
            if (this.class445_0 == null)
            {
                writer.Write((byte) 0);
            }
            else
            {
                writer.Write((byte) 1);
                this.class445_0.QQRW(writer);
            }
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_28;
            }
        }
    }
}

