namespace ns0
{
    using System;

    internal class Class575 : Class546
    {
        internal Class575(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class647 class2 = new Class647 {
                    enum0_0 = (Enum0) reader.ReadByte(),
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
                Class647 class2 = base.arrayList_0[i] as Class647;
                writer.Write((byte) class2.enum0_0);
                writer.Write(class2.int_0);
            }
        }

        internal class Class647
        {
            internal Enum0 enum0_0;
            internal int int_0;
        }
    }
}

