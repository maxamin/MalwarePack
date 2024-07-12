namespace ns0
{
    using System;

    internal class Class576 : Class546
    {
        internal Class576(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class648 class2 = new Class648 {
                    byte_1 = reader.ReadByte(),
                    enum0_0 = (Enum0) reader.ReadByte(),
                    int_0 = reader.ReadInt32(),
                    short_0 = reader.ReadInt16(),
                    int_1 = reader.ReadInt32()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class648 class2 = base.arrayList_0[i] as Class648;
                writer.Write(class2.byte_1);
                writer.Write((byte) class2.enum0_0);
                writer.Write(class2.int_0);
                writer.Write(class2.short_0);
                writer.Write(class2.int_1);
            }
        }

        internal class Class648
        {
            internal const byte byte_0 = 1;
            internal byte byte_1;
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal short short_0;

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

