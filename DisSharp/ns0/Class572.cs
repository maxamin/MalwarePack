namespace ns0
{
    using System;

    internal class Class572 : Class546
    {
        internal Class572(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class629 class2 = new Class629 {
                    double_0 = reader.ReadDouble()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class629 class2 = base.arrayList_0[i] as Class629;
                writer.Write(class2.double_0);
            }
        }

        internal class Class629
        {
            internal double double_0;
        }
    }
}

