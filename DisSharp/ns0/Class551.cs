namespace ns0
{
    using System;

    internal class Class551 : Class546
    {
        internal Class551(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class544 class2 = new Class544 {
                    enum21_0 = (Enum21) reader.ReadByte(),
                    enum9_0 = (Enum9) reader.ReadByte(),
                    int_0 = reader.ReadInt32()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class544 class2 = base.arrayList_0[i] as Class544;
                writer.Write((byte) class2.enum21_0);
                writer.Write((byte) class2.enum9_0);
                writer.Write(class2.int_0);
            }
        }

        internal class Class544
        {
            internal Enum21 enum21_0;
            internal Enum9 enum9_0;
            internal int int_0;
        }
    }
}

