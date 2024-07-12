namespace ns0
{
    using System;

    internal class Class490 : Class445
    {
        internal bool bool_0;
        internal bool bool_1;
        internal Class445 class445_0;
        internal uint uint_0;

        internal Class490()
        {
        }

        internal Class490(Class445 A_1, uint A_2)
        {
            this.class445_0 = A_1;
            this.uint_0 = Class840.smethod_0(A_2);
        }

        internal override Class445 QQUS()
        {
            this.class445_0 = this.class445_0.QQUS();
            return this;
        }

        internal override Class445 QQUT()
        {
            this.bool_0 = true;
            return this.QQUS();
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type == Class658.class658_0)
            {
                this.bool_1 = true;
            }
            return this;
        }

        internal override void QQUW()
        {
            this.bool_0 = false;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.uint_0 = data.method_14();
            this.bool_0 = data.method_5();
            this.bool_1 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write(this.uint_0);
            writer.Write(this.bool_0);
            writer.Write(this.bool_1);
        }

        internal override bool QQVV
        {
            get
            {
                return true;
            }
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_42;
            }
        }
    }
}

