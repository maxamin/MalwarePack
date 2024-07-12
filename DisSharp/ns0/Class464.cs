namespace ns0
{
    using System;

    internal class Class464 : Class445
    {
        internal bool bool_0;
        internal Class445[] class445_0;
        internal Enum1[] enum1_0;

        internal Class464()
        {
        }

        internal Class464(Enum1[] A_1, Class445[] A_2)
        {
            this.class445_0 = A_2;
            this.enum1_0 = A_1;
        }

        internal override Class445 QQUS()
        {
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i] = Class821.smethod_9(this.class445_0[i]).QQUS();
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
            int num = data.method_10();
            this.class445_0 = new Class445[num];
            for (int i = 0; i < num; i++)
            {
                this.class445_0[i] = Class541.smethod_2(data);
            }
            this.enum1_0 = new Enum1[num - 1];
            for (int j = 0; j < (num - 1); j++)
            {
                this.enum1_0[j] = (Enum1) data.method_8();
            }
            this.bool_0 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((ushort) this.class445_0.Length);
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i].QQRW(writer);
            }
            for (int j = 0; j < this.enum1_0.Length; j++)
            {
                writer.Write((byte) this.enum1_0[j]);
            }
            writer.Write(this.bool_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_10;
            }
        }
    }
}

