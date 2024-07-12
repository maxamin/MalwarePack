namespace ns0
{
    using System;

    internal class Class460 : Class445
    {
        internal bool bool_0;
        internal Class445 class445_0;
        internal Class445 class445_1;

        internal Class460()
        {
        }

        internal Class460(Class445 A_1, Class445 A_2)
        {
            this.class445_0 = A_1;
            this.class445_1 = A_2;
            Class447 class2 = A_2 as Class447;
            if ((class2 != null) && (class2.int_0 == 0))
            {
                this.bool_0 = true;
            }
        }

        internal override Class445 QQUS()
        {
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUS();
            this.class445_1 = this.class445_1.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.class445_1 = Class541.smethod_2(data);
            this.bool_0 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            this.class445_1.QQRW(writer);
            writer.Write(this.bool_0);
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
                return Enum17.const_6;
            }
        }
    }
}

