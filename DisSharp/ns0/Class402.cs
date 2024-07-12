namespace ns0
{
    using System;

    internal class Class402 : Class398
    {
        internal byte byte_0;
        internal Class445[] class445_0;
        internal Enum11 enum11_0;
        internal int int_0;
        internal ushort[] ushort_2;

        internal Class402()
        {
        }

        internal Class402(Enum11 A_1, int A_2, byte A_3, ushort[] A_4, Class445[] A_5)
        {
            this.enum11_0 = A_1;
            this.int_0 = A_2;
            this.byte_0 = A_3;
            this.ushort_2 = A_4;
            this.class445_0 = A_5;
        }

        internal override Class398 QQUS()
        {
            Class658 type = Class658.smethod_2(this.enum11_0, this.int_0, this.byte_0);
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i] = this.class445_0[i].QQUU(type);
                this.class445_0[i] = this.class445_0[i].QQUT();
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum11_0 = (Enum11) data.method_8();
            this.int_0 = data.method_11();
            this.byte_0 = data.method_8();
            int num = data.method_10();
            this.ushort_2 = new ushort[num];
            for (int i = 0; i < num; i++)
            {
                this.ushort_2[i] = data.method_10();
            }
            num = data.method_10();
            this.class445_0 = new Class445[num];
            for (int j = 0; j < num; j++)
            {
                this.class445_0[j] = Class541.smethod_2(data);
            }
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum11_0);
            writer.Write(this.int_0);
            writer.Write(this.byte_0);
            writer.Write((ushort) this.ushort_2.Length);
            for (int i = 0; i < this.ushort_2.Length; i++)
            {
                writer.Write(this.ushort_2[i]);
            }
            writer.Write((ushort) this.class445_0.Length);
            for (int j = 0; j < this.class445_0.Length; j++)
            {
                this.class445_0[j].QQRW(writer);
            }
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_3;
            }
        }
    }
}

