namespace ns0
{
    using System;

    internal class Class565 : Class546
    {
        internal Class565(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class620 class2 = new Class620 {
                    uint_0 = reader.ReadUInt32()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class620 class2 = base.arrayList_0[i] as Class620;
                writer.Write(class2.uint_0);
            }
        }

        internal class Class620
        {
            internal uint uint_0;
        }
    }
}

