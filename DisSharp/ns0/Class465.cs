namespace ns0
{
    using System;

    internal class Class465 : Class445
    {
        internal bool bool_0;
        internal Class445[] class445_0;
        internal Enum1 enum1_0;

        internal Class465()
        {
        }

        internal Class465(Enum1 A_1, Class445[] A_2)
        {
            this.class445_0 = A_2;
            this.enum1_0 = A_1;
        }

        internal void method_1(Class445 A_1)
        {
            Class445[] classArray = new Class445[this.class445_0.Length + 1];
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                classArray[i] = this.class445_0[i];
            }
            classArray[this.class445_0.Length] = A_1;
            this.class445_0 = classArray;
        }

        internal void method_2(Class445 A_1, Enum1 A_2)
        {
            this.method_1(A_1);
            this.enum1_0 = A_2;
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

        internal override Class445 QQUU(Class658 type)
        {
            if ((type == Class658.class658_0) && ((this.enum1_0 == Enum1.const_1) || (this.enum1_0 == Enum1.const_8)))
            {
                for (int i = 0; i < this.class445_0.Length; i++)
                {
                    this.class445_0[i] = this.class445_0[i].QQUU(Class658.class658_0);
                }
            }
            return this;
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
            this.enum1_0 = (Enum1) data.method_8();
            this.bool_0 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((ushort) this.class445_0.Length);
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i].QQRW(writer);
            }
            writer.Write((byte) this.enum1_0);
            writer.Write(this.bool_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_11;
            }
        }
    }
}

