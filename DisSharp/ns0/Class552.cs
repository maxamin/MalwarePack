namespace ns0
{
    using System;

    internal class Class552 : Class546
    {
        internal Class552(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class545 class2 = new Class545 {
                    byte_4 = reader.ReadByte(),
                    enum23_0 = (Enum23) reader.ReadByte(),
                    int_0 = reader.ReadInt32(),
                    int_1 = reader.ReadInt32(),
                    enum11_0 = (Enum11) reader.ReadByte(),
                    int_2 = reader.ReadInt32(),
                    byte_5 = reader.ReadByte(),
                    short_0 = reader.ReadInt16(),
                    int_3 = reader.ReadInt32()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class545 class2 = base.arrayList_0[i] as Class545;
                writer.Write(class2.byte_4);
                writer.Write((byte) class2.enum23_0);
                writer.Write(class2.int_0);
                writer.Write(class2.int_1);
                writer.Write((byte) class2.enum11_0);
                writer.Write(class2.int_2);
                writer.Write(class2.byte_5);
                writer.Write(class2.short_0);
                writer.Write(class2.int_3);
            }
        }

        internal class Class545
        {
            internal const byte byte_0 = 1;
            internal const byte byte_1 = 2;
            internal const byte byte_2 = 4;
            internal const byte byte_3 = 8;
            internal byte byte_4;
            internal byte byte_5;
            internal Enum11 enum11_0;
            internal Enum23 enum23_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal short short_0;

            internal void method_0()
            {
                this.byte_4 = (byte) (this.byte_4 | 1);
            }

            internal void method_1(Class586 A_1, bool A_2)
            {
                A_1.method_1(new Class348(this), Enum62.const_1);
                Class553.Class531 class2 = Class546.class553_0.arrayList_0[this.int_0] as Class553.Class531;
                if (class2 != null)
                {
                    class2.method_0(A_1, A_2);
                }
            }

            internal void method_2(Class593 A_1, bool A_2)
            {
                A_1.method_1(Class519.class581_0[this.int_1], Enum62.const_1);
                Class553.Class531 class2 = Class546.class553_0.arrayList_0[this.int_0] as Class553.Class531;
                if (class2 != null)
                {
                    class2.method_1(A_1, A_2);
                }
            }

            internal bool Boolean_0
            {
                get
                {
                    return ((this.byte_4 & 1) != 0);
                }
            }

            internal bool Boolean_1
            {
                get
                {
                    return ((this.byte_4 & 2) != 0);
                }
            }

            internal bool Boolean_2
            {
                get
                {
                    return ((this.byte_4 & 4) != 0);
                }
            }

            internal bool Boolean_3
            {
                get
                {
                    return ((this.byte_4 & 8) != 0);
                }
            }
        }
    }
}

