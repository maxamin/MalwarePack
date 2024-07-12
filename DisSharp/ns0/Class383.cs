namespace ns0
{
    using System;

    internal class Class383 : Class369
    {
        internal Class547.Class528 class528_0;
        internal Enum4 enum4_0;

        internal override void Create(Class50 code, Enum2 codetype, bool single)
        {
            code.QRXU(this, this.class528_0, codetype, single);
        }

        internal override void Load(Class656 reader)
        {
            int num = reader.ReadInt32();
            this.class528_0 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            this.class528_0.class369_0 = this;
            this.enum4_0 = (Enum4) reader.ReadByte();
        }

        internal override bool QQRU()
        {
            Class897.smethod_5(this, Class369.TreeLine, this.class528_0);
            return true;
        }

        internal override void QQUY(Class50 code, Enum2 codetype)
        {
            code.QRXV(this, this.class528_0);
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
            writer.Write((byte) this.enum4_0);
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
                if (this.enum4_0 == Enum4.const_0)
                {
                    return Class868.int_12;
                }
                if (this.enum4_0 == Enum4.const_1)
                {
                    return Class868.int_7;
                }
                return Class868.int_17;
            }
        }

        internal override Enum10 QQQS
        {
            get
            {
                return Enum10.const_23;
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
                return true;
            }
        }

        internal override bool QQQZ
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

