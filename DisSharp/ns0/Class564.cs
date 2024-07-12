namespace ns0
{
    using System;

    internal class Class564 : Class546
    {
        internal Class564(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class618 class2 = new Class618 {
                    int_0 = reader.ReadInt32(),
                    enum11_0 = (Enum11) reader.ReadByte(),
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
                Class618 class2 = base.arrayList_0[i] as Class618;
                writer.Write(class2.int_0);
                writer.Write((byte) class2.enum11_0);
                writer.Write(class2.int_1);
            }
        }

        internal class Class618
        {
            internal Enum11 enum11_0;
            internal int int_0;
            internal int int_1;
        }
    }
}

