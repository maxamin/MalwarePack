namespace ns0
{
    using System;

    internal class Class580 : Class546
    {
        internal Class580(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class870 class2 = new Class870();
                int count = reader.ReadUInt16();
                class2.byte_0 = reader.ReadBytes(count);
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class870 class2 = base.arrayList_0[i] as Class870;
                writer.Write((ushort) class2.byte_0.Length);
                writer.Write(class2.byte_0);
            }
        }

        internal class Class870
        {
            internal byte[] byte_0;
        }
    }
}

