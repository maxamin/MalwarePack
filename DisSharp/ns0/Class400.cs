namespace ns0
{
    using System;

    internal class Class400 : Class398
    {
        internal Class445[] class445_0;
        internal Class445 class445_1;

        internal Class400()
        {
        }

        internal Class400(Class445[] A_1, Class445 A_2)
        {
            this.class445_0 = A_1;
            this.class445_1 = A_2;
        }

        internal override Class398 QQUS()
        {
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i] = this.class445_0[i].QQUT();
            }
            this.class445_1 = this.class445_1.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            int num = data.method_10();
            this.class445_0 = new Class445[num];
            for (int i = 0; i < num; i++)
            {
                this.class445_0[i] = Class541.smethod_2(data);
            }
            this.class445_1 = Class541.smethod_2(data);
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((ushort) this.class445_0.Length);
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i].QQRW(writer);
            }
            this.class445_1.QQRW(writer);
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_1;
            }
        }
    }
}

