namespace ns0
{
    using System;

    internal class Class569 : Class546
    {
        internal Class569(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class624 class2 = new Class624 {
                    byte_1 = reader.ReadByte(),
                    enum11_0 = (Enum11) reader.ReadByte(),
                    int_0 = reader.ReadInt32(),
                    byte_2 = reader.ReadByte()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class624 class2 = base.arrayList_0[i] as Class624;
                writer.Write(class2.byte_1);
                writer.Write((byte) class2.enum11_0);
                writer.Write(class2.int_0);
                writer.Write(class2.byte_2);
            }
        }

        internal class Class624
        {
            internal const byte byte_0 = 1;
            internal byte byte_1;
            internal byte byte_2;
            internal Enum11 enum11_0;
            internal int int_0;

            internal void method_0()
            {
                this.byte_1 = (byte) (this.byte_1 | 1);
            }

            internal bool Boolean_0
            {
                get
                {
                    return ((this.byte_1 & 1) != 0);
                }
            }
        }
    }
}

