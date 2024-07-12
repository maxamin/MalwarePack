namespace ns0
{
    using System;

    internal class Class384 : Class369
    {
        internal byte byte_0;
        internal Enum11 enum11_0;
        internal Enum34 enum34_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal short short_0;

        internal override void Create(Class50 code, Enum2 codetype, bool single)
        {
            code.QRXW(this, codetype, single);
        }

        internal override void Load(Class656 reader)
        {
            this.int_0 = reader.ReadInt32();
            this.enum11_0 = (Enum11) reader.ReadByte();
            this.int_1 = reader.ReadInt32();
            this.byte_0 = reader.ReadByte();
            this.enum34_0 = (Enum34) reader.ReadByte();
            this.short_0 = reader.ReadInt16();
            this.int_2 = reader.ReadInt32();
        }

        internal override bool QQRU()
        {
            Class897.smethod_6(this, Class369.TreeLine);
            return true;
        }

        internal override bool QQRV(Class369 node)
        {
            switch (this.enum34_0)
            {
                case Enum34.const_0:
                    return true;

                case Enum34.const_1:
                    return false;

                case Enum34.const_2:
                    if (base.class619_0[0] != node)
                    {
                        return false;
                    }
                    return true;
            }
            return true;
        }

        internal override void QQUY(Class50 code, Enum2 codetype)
        {
            code.QRXX(this);
        }

        internal override void QQWZ(Class896 coll)
        {
            Class898.smethod_7(this, coll);
        }

        internal override bool QQXR(Enum2 codetype)
        {
            return base.method_6(codetype);
        }

        internal override void Save(Class524 writer)
        {
            writer.Write(this.int_0);
            writer.Write((byte) this.enum11_0);
            writer.Write(this.int_1);
            writer.Write(this.byte_0);
            writer.Write((byte) this.enum34_0);
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
                Class643.smethod_4(this, value);
            }
        }

        internal override int QQQR
        {
            get
            {
                Class547.Class528 class2 = (base.class619_0[0] as Class391).class528_0;
                switch (this.enum34_0)
                {
                    case Enum34.const_0:
                        if (class2.Boolean_11 || class2.Boolean_12)
                        {
                            return Class868.int_31;
                        }
                        if (!class2.Boolean_8)
                        {
                            return Class868.int_19;
                        }
                        return Class868.int_27;

                    case Enum34.const_1:
                        if (class2.Boolean_11 || class2.Boolean_12)
                        {
                            return Class868.int_33;
                        }
                        if (!class2.Boolean_8)
                        {
                            return Class868.int_21;
                        }
                        return Class868.int_29;

                    case Enum34.const_2:
                        if (class2.Boolean_11 || class2.Boolean_12)
                        {
                            return Class868.int_32;
                        }
                        if (!class2.Boolean_8)
                        {
                            return Class868.int_20;
                        }
                        return Class868.int_28;
                }
                return Class868.int_20;
            }
        }

        internal override Enum10 QQQS
        {
            get
            {
                return Enum10.const_18;
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

        internal override bool QQRR
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

