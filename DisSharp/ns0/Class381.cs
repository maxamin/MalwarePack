namespace ns0
{
    using System;

    internal class Class381 : Class369
    {
        internal bool bool_0;
        internal bool bool_1;
        internal Enum0 enum0_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal short short_0;

        internal override void Create(Class50 code, Enum2 codetype, bool single)
        {
            code.QRWW(this, codetype, single);
        }

        internal override void Load(Class656 reader)
        {
            this.int_0 = reader.ReadInt32();
            this.enum0_0 = (Enum0) reader.ReadByte();
            this.int_1 = reader.ReadInt32();
            this.bool_0 = reader.ReadBoolean();
            this.bool_1 = reader.ReadBoolean();
            this.short_0 = reader.ReadInt16();
            this.int_2 = reader.ReadInt32();
        }

        internal override bool QQRU()
        {
            Class897.smethod_1(this, Class369.TreeLine);
            return true;
        }

        internal override void QQUY(Class50 code, Enum2 codetype)
        {
            code.QRWX(this);
        }

        internal override void QQWZ(Class896 coll)
        {
            Class898.smethod_6(this, coll);
        }

        internal override bool QQXR(Enum2 codetype)
        {
            return base.method_6(codetype);
        }

        internal override void Save(Class524 writer)
        {
            writer.Write(this.int_0);
            writer.Write((byte) this.enum0_0);
            writer.Write(this.int_1);
            writer.Write(this.bool_0);
            writer.Write(this.bool_1);
            writer.Write(this.short_0);
            writer.Write(this.int_2);
        }

        internal override string Name
        {
            get
            {
                return Class519.class581_0[this.int_0];
            }
            set
            {
                Class643.smethod_3(this, value);
            }
        }

        internal override int QQQR
        {
            get
            {
                return Class868.int_6;
            }
        }

        internal override Enum10 QQQS
        {
            get
            {
                return Enum10.const_21;
            }
        }

        internal override bool QQQT
        {
            get
            {
                return false;
            }
        }

        internal override bool QQQU
        {
            get
            {
                return false;
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
                if (!this.bool_0)
                {
                    return this.bool_1;
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

        internal override bool QQVU
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

