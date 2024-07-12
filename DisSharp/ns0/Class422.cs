namespace ns0
{
    using System;

    internal class Class422 : Class398
    {
        internal Class445 class445_0;
        internal Class445[] class445_1;
        internal uint uint_0;

        internal Class422()
        {
        }

        internal Class422(Class445 A_1, uint A_2, Class445[] A_3)
        {
            this.class445_0 = Class520.smethod_0(A_1, A_2);
            this.uint_0 = Class840.smethod_0(A_2);
            this.class445_1 = A_3;
        }

        internal override Class398 QQUS()
        {
            this.class445_0 = this.class445_0.QQUS();
            Class957 class2 = Class821.smethod_5(this.uint_0);
            for (int i = 0; i < this.class445_1.Length; i++)
            {
                this.class445_1[i] = Class821.smethod_9(this.class445_1[i].QQUU(Class821.smethod_6(class2, i))).QQUT();
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.uint_0 = data.method_14();
            if (data.method_8() == 1)
            {
                int num2 = data.method_10();
                this.class445_1 = new Class445[num2];
                for (int i = 0; i < num2; i++)
                {
                    this.class445_1[i] = Class541.smethod_2(data);
                }
            }
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write(this.uint_0);
            if (this.class445_1 == null)
            {
                writer.Write((byte) 0);
            }
            else
            {
                writer.Write((byte) 1);
                writer.Write((ushort) this.class445_1.Length);
                for (int i = 0; i < this.class445_1.Length; i++)
                {
                    this.class445_1[i].QQRW(writer);
                }
            }
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_22;
            }
        }
    }
}

