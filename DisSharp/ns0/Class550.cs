namespace ns0
{
    using System;

    internal class Class550 : Class546
    {
        internal Class550(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class514 class2 = new Class514 {
                    enum8_0 = (Enum8) reader.ReadByte(),
                    enum7_0 = (Enum7) reader.ReadByte(),
                    int_0 = reader.ReadInt32()
                };
                int count = reader.ReadUInt16();
                if (count > 0)
                {
                    class2.byte_0 = reader.ReadBytes(count);
                }
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class514 class2 = base.arrayList_0[i] as Class514;
                writer.Write((byte) class2.enum8_0);
                writer.Write((byte) class2.enum7_0);
                writer.Write(class2.int_0);
                if (class2.byte_0 != null)
                {
                    writer.Write((ushort) class2.byte_0.Length);
                    writer.Write(class2.byte_0);
                }
                else
                {
                    writer.Write((ushort) 0);
                }
            }
        }

        internal class Class514
        {
            internal byte[] byte_0;
            internal Enum7 enum7_0;
            internal Enum8 enum8_0;
            internal int int_0;
        }
    }
}

