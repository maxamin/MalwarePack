namespace ns0
{
    using System;

    internal class Class482 : Class445
    {
        internal Class445[] class445_0;
        internal uint uint_0;

        internal Class482()
        {
        }

        internal Class482(uint A_1, Class445[] A_2)
        {
            this.uint_0 = Class840.smethod_0(A_1);
            this.class445_0 = A_2;
        }

        internal override Class445 QQUS()
        {
            Class658 type = Class821.smethod_3(this.uint_0);
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i] = Class821.smethod_9(this.class445_0[i].QQUU(type)).QQUT();
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.uint_0 = data.method_14();
            int num = data.method_10();
            this.class445_0 = new Class445[num];
            for (int i = 0; i < num; i++)
            {
                this.class445_0[i] = Class541.smethod_2(data);
            }
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.uint_0);
            writer.Write((ushort) this.class445_0.Length);
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i].QQRW(writer);
            }
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_34;
            }
        }
    }
}

