namespace ns0
{
    using System;

    internal class Class556 : Class546
    {
        internal Class556(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class601 class2 = new Class601 {
                    byte_3 = reader.ReadByte(),
                    enum24_0 = (Enum24) reader.ReadByte(),
                    enum0_0 = (Enum0) reader.ReadByte(),
                    int_0 = reader.ReadInt32(),
                    int_1 = reader.ReadInt32(),
                    int_2 = reader.ReadInt32(),
                    int_3 = reader.ReadInt32(),
                    enum11_0 = (Enum11) reader.ReadByte(),
                    int_4 = reader.ReadInt32(),
                    byte_4 = reader.ReadByte(),
                    short_0 = reader.ReadInt16(),
                    int_5 = reader.ReadInt32()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class601 class2 = base.arrayList_0[i] as Class601;
                writer.Write(class2.byte_3);
                writer.Write((byte) class2.enum24_0);
                writer.Write((byte) class2.enum0_0);
                writer.Write(class2.int_0);
                writer.Write(class2.int_1);
                writer.Write(class2.int_2);
                writer.Write(class2.int_3);
                writer.Write((byte) class2.enum11_0);
                writer.Write(class2.int_4);
                writer.Write(class2.byte_4);
                writer.Write(class2.short_0);
                writer.Write(class2.int_5);
            }
        }

        internal class Class601
        {
            internal const byte byte_0 = 1;
            internal const byte byte_1 = 2;
            internal const byte byte_2 = 4;
            internal byte byte_3;
            internal byte byte_4;
            internal Enum0 enum0_0;
            internal Enum11 enum11_0;
            internal Enum24 enum24_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal int int_4;
            internal int int_5;
            internal short short_0;

            internal void method_0()
            {
                this.byte_3 = (byte) (this.byte_3 | 1);
            }

            internal void method_1()
            {
                this.byte_3 = (byte) (this.byte_3 | 4);
            }

            internal bool Boolean_0
            {
                get
                {
                    return ((this.byte_3 & 1) != 0);
                }
            }

            internal bool Boolean_1
            {
                get
                {
                    return ((this.byte_3 & 2) != 0);
                }
            }

            internal bool Boolean_2
            {
                get
                {
                    return ((this.byte_3 & 4) != 0);
                }
            }
        }
    }
}

