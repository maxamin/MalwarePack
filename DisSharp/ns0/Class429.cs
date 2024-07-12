namespace ns0
{
    using System;

    internal class Class429 : Class398
    {
        internal Class445[] class445_0;
        internal Enum1 enum1_0;
        internal uint uint_0;

        internal Class429()
        {
        }

        internal Class429(uint A_1, Class445[] A_2, Enum1 A_3)
        {
            this.uint_0 = Class840.smethod_0(A_1);
            this.class445_0 = A_2;
            this.enum1_0 = A_3;
        }

        internal override Class398 QQUS()
        {
            Class957 class2 = Class821.smethod_5(this.uint_0);
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i] = Class821.smethod_9(this.class445_0[i].QQUU(Class821.smethod_6(class2, i))).QQUT();
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.uint_0 = data.method_14();
            if (data.method_8() == 1)
            {
                int num2 = data.method_10();
                this.class445_0 = new Class445[num2];
                for (int i = 0; i < num2; i++)
                {
                    this.class445_0[i] = Class541.smethod_2(data);
                }
            }
            this.enum1_0 = (Enum1) data.method_8();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.uint_0);
            if (this.class445_0 == null)
            {
                writer.Write((byte) 0);
            }
            else
            {
                writer.Write((byte) 1);
                writer.Write((ushort) this.class445_0.Length);
                for (int i = 0; i < this.class445_0.Length; i++)
                {
                    this.class445_0[i].QQRW(writer);
                }
            }
            writer.Write((byte) this.enum1_0);
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_29;
            }
        }
    }
}

