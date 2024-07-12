namespace ns0
{
    using System;

    internal class Class570 : Class546
    {
        internal Class570(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class625 class2 = new Class625 {
                    enum12_0 = (Enum12) reader.ReadByte(),
                    enum13_0 = (Enum13) reader.ReadByte(),
                    enum15_0 = (Enum15) reader.ReadByte(),
                    enum14_0 = (Enum14) reader.ReadByte(),
                    byte_0 = reader.ReadByte(),
                    int_0 = reader.ReadInt32(),
                    int_1 = reader.ReadInt32(),
                    bool_0 = reader.ReadBoolean()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class625 class2 = base.arrayList_0[i] as Class625;
                writer.Write((byte) class2.enum12_0);
                writer.Write((byte) class2.enum13_0);
                writer.Write((byte) class2.enum15_0);
                writer.Write((byte) class2.enum14_0);
                writer.Write(class2.byte_0);
                writer.Write(class2.int_0);
                writer.Write(class2.int_1);
                writer.Write(class2.bool_0);
            }
        }

        internal class Class625
        {
            internal bool bool_0;
            internal byte byte_0;
            internal Enum12 enum12_0;
            internal Enum13 enum13_0;
            internal Enum14 enum14_0;
            internal Enum15 enum15_0;
            internal int int_0;
            internal int int_1;
        }
    }
}

