namespace ns0
{
    using System;

    internal class Class555 : Class546
    {
        internal Class555(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class600 class2 = new Class600 {
                    int_0 = reader.ReadInt32(),
                    int_1 = reader.ReadInt32(),
                    enum11_0 = (Enum11) reader.ReadByte(),
                    int_2 = reader.ReadInt32(),
                    byte_0 = reader.ReadByte()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class600 class2 = base.arrayList_0[i] as Class600;
                writer.Write(class2.int_0);
                writer.Write(class2.int_1);
                writer.Write((byte) class2.enum11_0);
                writer.Write(class2.int_2);
                writer.Write(class2.byte_0);
            }
        }

        internal class Class600
        {
            internal byte byte_0;
            internal Enum11 enum11_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;

            internal void method_0(Class586 A_1, bool A_2)
            {
                A_1.method_1(new Class347(this), Enum62.const_2);
                (Class546.class553_0.arrayList_0[this.int_0] as Class553.Class531).method_0(A_1, A_2);
            }

            internal void method_1(Class593 A_1, bool A_2)
            {
                A_1.method_1(Class519.class581_0[this.int_1], Enum62.const_2);
                (Class546.class553_0.arrayList_0[this.int_0] as Class553.Class531).method_1(A_1, A_2);
            }
        }
    }
}

