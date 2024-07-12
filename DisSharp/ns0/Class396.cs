namespace ns0
{
    using System;

    internal class Class396 : Class369
    {
        internal byte byte_0;
        internal Enum11 enum11_0;
        internal Enum34 enum34_0;
        internal int int_0;
        internal int int_1;
        internal short short_0;
        private static string string_0 = Class613.Class614.string_67;
        internal Struct16[] struct16_0;

        internal override void Create(Class50 code, Enum2 codetype, bool single)
        {
        }

        internal override void Load(Class656 reader)
        {
            this.enum34_0 = (Enum34) reader.ReadByte();
            this.enum11_0 = (Enum11) reader.ReadByte();
            this.int_0 = reader.ReadInt32();
            this.byte_0 = reader.ReadByte();
            int num = reader.ReadInt32();
            if (num > 0)
            {
                this.struct16_0 = new Struct16[num];
                for (int i = 0; i < num; i++)
                {
                    this.struct16_0[i].enum11_0 = (Enum11) reader.ReadByte();
                    this.struct16_0[i].int_0 = reader.ReadInt32();
                    this.struct16_0[i].byte_0 = reader.ReadByte();
                }
            }
            this.short_0 = reader.ReadInt16();
            this.int_1 = reader.ReadInt32();
        }

        internal override bool QQRU()
        {
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
        }

        internal override void QQWZ(Class896 coll)
        {
        }

        internal override bool QQXR(Enum2 codetype)
        {
            return base.method_6(codetype);
        }

        internal override void Save(Class524 writer)
        {
            writer.Write((byte) this.enum34_0);
            writer.Write((byte) this.enum11_0);
            writer.Write(this.int_0);
            writer.Write(this.byte_0);
            if (this.struct16_0 != null)
            {
                writer.Write(this.struct16_0.Length);
                for (int i = 0; i < this.struct16_0.Length; i++)
                {
                    writer.Write((byte) this.struct16_0[i].enum11_0);
                    writer.Write(this.struct16_0[i].int_0);
                    writer.Write(this.struct16_0[i].byte_0);
                }
            }
            else
            {
                writer.Write(0);
            }
            writer.Write(this.short_0);
            writer.Write(this.int_1);
        }

        internal override string Name
        {
            get
            {
                return string_0;
            }
            set
            {
            }
        }

        internal override int QQQR
        {
            get
            {
                return Class868.int_13;
            }
        }

        internal override Enum10 QQQS
        {
            get
            {
                return Enum10.const_20;
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

        internal override bool QQTV
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

