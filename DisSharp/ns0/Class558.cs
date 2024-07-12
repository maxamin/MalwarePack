namespace ns0
{
    using System;

    internal class Class558 : Class546
    {
        internal int int_0;

        internal Class558(Class684 A_1) : base(A_1)
        {
        }

        internal int method_0(byte[] A_1)
        {
            Class606 class2 = new Class606 {
                byte_0 = A_1
            };
            base.arrayList_0.Add(class2);
            return (base.arrayList_0.Count - 1);
        }

        internal Enum11 method_1(int A_1)
        {
            Class606 class2 = base.arrayList_0[A_1] as Class606;
            this.int_0 = class2.int_0;
            return class2.enum11_0;
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class606 class2 = new Class606();
                int count = reader.ReadUInt16();
                class2.byte_0 = reader.ReadBytes(count);
                class2.enum11_0 = (Enum11) reader.ReadByte();
                class2.int_0 = reader.ReadInt32();
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class606 class2 = base.arrayList_0[i] as Class606;
                writer.Write((ushort) class2.byte_0.Length);
                writer.Write(class2.byte_0);
                writer.Write((byte) class2.enum11_0);
                writer.Write(class2.int_0);
            }
        }

        internal class Class606
        {
            internal byte[] byte_0;
            internal Enum11 enum11_0;
            internal int int_0;
        }
    }
}

