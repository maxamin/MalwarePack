namespace ns0
{
    using System;

    internal class Class391 : Class369
    {
        internal Class547.Class528 class528_0;

        internal override void Create(Class50 code, Enum2 codetype, bool single)
        {
            code.QRXS(this, this.class528_0, codetype, single);
        }

        internal override void Load(Class656 reader)
        {
            int num = reader.ReadInt32();
            this.class528_0 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            this.class528_0.class369_0 = this;
        }

        internal override bool QQRU()
        {
            Class897.smethod_4(this, Class369.TreeLine, this.class528_0);
            return true;
        }

        internal override void QQUY(Class50 code, Enum2 codetype)
        {
            code.QRXT(this, this.class528_0);
        }

        internal override void QQWU()
        {
            Class519.class528_1 = this.class528_0;
        }

        internal override void QQWZ(Class896 coll)
        {
            Class898.smethod_8(this, this.class528_0, coll);
        }

        internal override bool QQXR(Enum2 codetype)
        {
            return base.method_5(this.class528_0, codetype);
        }

        internal override void Save(Class524 writer)
        {
            writer.Write(this.class528_0.int_0);
        }

        internal override string Name
        {
            get
            {
                return Class519.class581_0[this.class528_0.int_1];
            }
            set
            {
                Class519.class581_0[this.class528_0.int_1] = value;
            }
        }

        internal override int QQQR
        {
            get
            {
                if (this.class528_0.Boolean_13)
                {
                    return Class868.int_8;
                }
                if (this.class528_0.Boolean_11 || this.class528_0.Boolean_12)
                {
                    return Class868.int_34;
                }
                if (this.class528_0.Boolean_8)
                {
                    return Class868.int_26;
                }
                return Class868.int_15;
            }
        }

        internal override Enum10 QQQS
        {
            get
            {
                return Enum10.const_16;
            }
        }

        internal override bool QQQU
        {
            get
            {
                return true;
            }
        }

        internal override bool QQQY
        {
            get
            {
                if (base.class369_0 is Class375)
                {
                    return false;
                }
                return true;
            }
        }

        internal override bool QQQZ
        {
            get
            {
                return this.QQQY;
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

