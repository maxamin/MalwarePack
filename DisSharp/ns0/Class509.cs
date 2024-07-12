namespace ns0
{
    using System;

    internal class Class509 : Class445
    {
        internal bool bool_0;
        internal Class445 class445_0;
        internal Class445 class445_1;
        internal Class445 class445_2;

        internal Class509()
        {
        }

        internal Class509(Class445 A_1, Class445 A_2, Class445 A_3)
        {
            this.class445_0 = A_1;
            this.class445_1 = A_3;
            this.class445_2 = A_2;
        }

        internal override Class445 QQUS()
        {
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_2 = Class821.smethod_9(this.class445_2);
            this.class445_0 = this.class445_0.QQUU(Class658.class658_0);
            this.class445_0 = this.class445_0.QQUT();
            if (this.class445_1.Type == Enum17.const_62)
            {
                this.class445_1 = this.class445_1.QQUS();
            }
            else
            {
                this.class445_1 = this.class445_1.QQUT();
            }
            if (this.class445_2.Type == Enum17.const_62)
            {
                this.class445_2 = this.class445_2.QQUT();
            }
            else
            {
                this.class445_2 = this.class445_2.QQUT();
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
            this.class445_1 = this.class445_1.QQUU(type);
            this.class445_2 = this.class445_2.QQUU(type);
            if (type != Class658.class658_0)
            {
                return this;
            }
            Class451 class2 = this.class445_2 as Class451;
            if (class2 != null)
            {
                if (class2.bool_0)
                {
                    Class463 class3 = new Class463(this.class445_1, this.class445_0, Enum1.const_8);
                    Class1021.bool_0 = true;
                    return class3;
                }
                if (!class2.bool_0)
                {
                    Class463 class4 = new Class463(this.class445_1, this.class445_0, Enum1.const_1);
                    Class1021.bool_0 = true;
                    return class4;
                }
            }
            class2 = this.class445_1 as Class451;
            if (class2 != null)
            {
                if (class2.bool_0)
                {
                    Class463 class5 = new Class463(this.class445_2, this.class445_0, Enum1.const_8);
                    Class1021.bool_0 = true;
                    return class5;
                }
                if (!class2.bool_0)
                {
                    Class463 class6 = new Class463(this.class445_2, this.class445_0, Enum1.const_1);
                    Class1021.bool_0 = true;
                    return class6;
                }
            }
            Class658 class7 = Class821.smethod_0(this.class445_1);
            return Class859.smethod_1(this, class7.enum11_0, class7.int_0, Enum50.const_0);
        }

        internal override void QQUW()
        {
            this.bool_0 = false;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.class445_1 = Class541.smethod_2(data);
            this.class445_2 = Class541.smethod_2(data);
            this.bool_0 = data.method_5();
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            this.class445_1.QQRW(writer);
            this.class445_2.QQRW(writer);
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
                return Enum17.const_62;
            }
        }
    }
}

