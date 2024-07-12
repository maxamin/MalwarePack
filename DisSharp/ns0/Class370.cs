namespace ns0
{
    using System;

    internal abstract class Class370 : Class369
    {
        internal byte byte_0;
        internal Class548.Class529 class529_0;

        protected Class370()
        {
        }

        internal override void Load(Class656 reader)
        {
            int num = reader.ReadInt32();
            this.class529_0 = Class546.class548_0.arrayList_0[num] as Class548.Class529;
            this.class529_0.class369_0 = this;
            this.byte_0 = reader.ReadByte();
        }

        internal override bool QQRU()
        {
            Class897.smethod_0(this, Class369.TreeLine, this.class529_0);
            return true;
        }

        internal override bool QQTX(Class586 identifier, bool full)
        {
            this.class529_0.method_0(identifier, full);
            return true;
        }

        internal override bool QQTX(Class593 identifier, bool full)
        {
            this.class529_0.method_1(identifier, full);
            return true;
        }

        internal override void QQWT()
        {
            Class519.class529_1 = this.class529_0;
        }

        internal override string QQWV(int number)
        {
            int num = this.class529_0.short_1;
            if ((this.class529_0.short_0 != 0) && (number >= num))
            {
                int num2 = number - num;
                Class559.Class607 class2 = Class546.class559_0.arrayList_0[this.class529_0.int_3 + num2] as Class559.Class607;
                return Class519.class581_0[class2.int_0];
            }
            if (base.class369_0 != null)
            {
                return base.class369_0.QQWV(number);
            }
            return "";
        }

        internal override void QQWV(Class397 lines, int number)
        {
            int num = this.class529_0.short_1;
            if ((this.class529_0.short_0 != 0) && (number >= num))
            {
                int num2 = number - num;
                Class559.Class607 class2 = Class546.class559_0.arrayList_0[this.class529_0.int_3 + num2] as Class559.Class607;
                lines.method_10(new Class351(class2.int_0));
            }
            else if (base.class369_0 != null)
            {
                base.class369_0.QQWV(lines, number);
            }
        }

        internal override Class335 QQWW(int number)
        {
            int num = this.class529_0.short_1;
            if ((this.class529_0.short_0 != 0) && (number >= num))
            {
                int num2 = number - num;
                Class559.Class607 class2 = Class546.class559_0.arrayList_0[this.class529_0.int_3 + num2] as Class559.Class607;
                return new Class351(class2.int_0);
            }
            if (base.class369_0 != null)
            {
                return base.class369_0.QQWW(number);
            }
            return Class584.class342_0;
        }

        internal override void QQWZ(Class896 coll)
        {
            Class898.smethod_4(this, this.class529_0, coll);
        }

        internal override bool QQXR(Enum2 codetype)
        {
            return (this.class529_0.Boolean_0 || (((codetype != Enum2.const_2) && this.class529_0.Boolean_2) || ((codetype == Enum2.const_4) && this.class529_0.Boolean_3)));
        }

        internal override void Save(Class524 writer)
        {
            writer.Write(this.class529_0.int_0);
            writer.Write(this.byte_0);
        }

        internal override string Name
        {
            get
            {
                return Class519.class581_0[this.class529_0.int_1];
            }
            set
            {
                Class519.class581_0[this.class529_0.int_1] = value;
            }
        }

        internal override bool QQQQ
        {
            get
            {
                return true;
            }
        }

        internal override bool QQQU
        {
            get
            {
                return true;
            }
        }

        internal override bool QQRQ
        {
            get
            {
                return true;
            }
        }

        internal override bool QQXQ
        {
            get
            {
                return true;
            }
        }
    }
}

