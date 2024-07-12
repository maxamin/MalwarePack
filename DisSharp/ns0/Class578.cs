namespace ns0
{
    using System;

    internal class Class578 : Class546
    {
        internal Class578(Class684 A_1) : base(A_1)
        {
        }

        internal void method_0(Class547.Class528 A_1, uint A_2, int A_3, int A_4, int A_5, int A_6, uint A_7)
        {
            Class869 class2 = new Class869 {
                int_0 = A_3,
                int_1 = A_4,
                int_2 = A_5,
                int_3 = A_6,
                uint_0 = A_7
            };
            byte num = 0;
            if ((A_2 & 1) != 0)
            {
                num = (byte) (num | 1);
            }
            if ((A_2 & 2) != 0)
            {
                num = (byte) (num | 2);
            }
            if ((A_2 & 4) != 0)
            {
                num = (byte) (num | 4);
                A_1.method_1(Enum5.const_5);
            }
            class2.byte_3 = num;
            base.arrayList_0.Add(class2);
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class869 class2 = new Class869 {
                    byte_3 = reader.ReadByte(),
                    int_0 = reader.ReadInt32(),
                    int_1 = reader.ReadInt32(),
                    int_2 = reader.ReadInt32(),
                    int_3 = reader.ReadInt32(),
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
                Class869 class2 = base.arrayList_0[i] as Class869;
                writer.Write(class2.byte_3);
                writer.Write(class2.int_0);
                writer.Write(class2.int_1);
                writer.Write(class2.int_2);
                writer.Write(class2.int_3);
                writer.Write(class2.uint_0);
            }
        }

        internal class Class869
        {
            internal const byte byte_0 = 1;
            internal const byte byte_1 = 2;
            internal const byte byte_2 = 4;
            internal byte byte_3;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal uint uint_0;

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

