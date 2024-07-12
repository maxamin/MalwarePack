namespace ns0
{
    using System;

    internal class Class385 : Class369
    {
        internal Class549.Class530 class530_0;

        internal override void Create(Class50 code, Enum2 codetype, bool single)
        {
            code.QRWY(this, this.class530_0);
        }

        internal override void Load(Class656 reader)
        {
            int num = reader.ReadInt32();
            this.class530_0 = Class546.class549_0.arrayList_0[num] as Class549.Class530;
            this.class530_0.class369_0 = this;
        }

        internal override bool QQRU()
        {
            Class897.smethod_2(this, Class369.TreeLine, this.class530_0);
            return true;
        }

        internal override void QQWZ(Class896 coll)
        {
            Class898.smethod_5(this, this.class530_0, coll);
        }

        internal override bool QQXR(Enum2 codetype)
        {
            return (this.class530_0.Boolean_0 || (((codetype != Enum2.const_2) && this.class530_0.Boolean_2) || ((codetype == Enum2.const_4) && this.class530_0.Boolean_3)));
        }

        internal override void Save(Class524 writer)
        {
            writer.Write(this.class530_0.int_0);
        }

        internal override string Name
        {
            get
            {
                return Class519.class581_0[this.class530_0.int_1];
            }
            set
            {
                Class519.class581_0[this.class530_0.int_1] = value;
            }
        }

        internal override int QQQR
        {
            get
            {
                return Class868.int_9;
            }
        }

        internal override Enum10 QQQS
        {
            get
            {
                return Enum10.const_12;
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

