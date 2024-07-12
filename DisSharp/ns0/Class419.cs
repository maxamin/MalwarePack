namespace ns0
{
    using System;

    internal class Class419 : Class398
    {
        internal Class398 class398_0;
        internal Class445 class445_0;
        internal Enum66 enum66_0;

        internal Class419()
        {
        }

        internal Class419(Class445 A_1, Enum66 A_2)
        {
            this.class445_0 = A_1;
            this.enum66_0 = A_2;
        }

        internal override void QQSS(Class398 oldtarget, Class398 newtarget)
        {
            this.class398_0 = newtarget;
        }

        internal override void QQST(Class398 target)
        {
            this.class398_0 = target;
        }

        internal override Class398 QQUS()
        {
            this.class445_0 = this.class445_0.QQUU(Class658.class658_0);
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_0 = this.class445_0.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.enum66_0 = (Enum66) data.method_8();
            ushort num = data.method_10();
            Class398.Class444.arrayList_1.Add(this);
            Class398.Class444.class540_0.method_1(num);
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write((byte) this.enum66_0);
            writer.Write(this.class398_0.ushort_1);
        }

        internal override Class398 QQRX
        {
            get
            {
                return this.class398_0;
            }
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_19;
            }
        }
    }
}

