namespace ns0
{
    using System;

    internal class Class567 : Class546
    {
        internal Class567(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class622 class2 = new Class622 {
                    ulong_0 = reader.ReadUInt64()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class622 class2 = base.arrayList_0[i] as Class622;
                writer.Write(class2.ulong_0);
            }
        }

        internal class Class622
        {
            internal ulong ulong_0;
        }
    }
}

