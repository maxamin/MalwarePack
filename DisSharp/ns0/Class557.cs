namespace ns0
{
    using System;

    internal class Class557 : Class546
    {
        internal Class557(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class605 class2 = new Class605();
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
                Class605 class2 = base.arrayList_0[i] as Class605;
                writer.Write((ushort) class2.byte_0.Length);
                writer.Write(class2.byte_0);
            }
        }

        internal class Class605
        {
            internal byte[] byte_0;
        }
    }
}

