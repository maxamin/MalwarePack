namespace ns0
{
    using System;

    internal class Class549 : Class546
    {
        internal Class549(Class684 A_1) : base(A_1)
        {
        }

        internal void method_0(Class685 A_1)
        {
            ushort[] numArray = A_1.ushort_3;
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class530 class2 = base.arrayList_0[i] as Class530;
                ushort num2 = numArray[i];
                switch ((num2 & 7))
                {
                    case 1:
                        class2.ushort_8 = (ushort) (class2.ushort_8 | 2);
                        break;

                    case 2:
                        class2.ushort_8 = (ushort) (class2.ushort_8 | 4);
                        class2.ushort_8 = (ushort) (class2.ushort_8 | 8);
                        break;

                    case 3:
                        class2.ushort_8 = (ushort) (class2.ushort_8 | 8);
                        break;

                    case 4:
                        class2.ushort_8 = (ushort) (class2.ushort_8 | 4);
                        break;

                    case 5:
                        class2.ushort_8 = (ushort) (class2.ushort_8 | 4);
                        class2.ushort_8 = (ushort) (class2.ushort_8 | 8);
                        break;

                    case 6:
                        class2.ushort_8 = (ushort) (class2.ushort_8 | 1);
                        break;
                }
                if ((num2 & 0x10) != 0)
                {
                    class2.ushort_8 = (ushort) (class2.ushort_8 | 0x10);
                }
                if ((num2 & 0x20) != 0)
                {
                    class2.ushort_8 = (ushort) (class2.ushort_8 | 0x20);
                }
                if ((num2 & 0x40) != 0)
                {
                    class2.ushort_8 = (ushort) (class2.ushort_8 | 0x40);
                }
                if ((num2 & 0x80) != 0)
                {
                    class2.ushort_8 = (ushort) (class2.ushort_8 | 0x80);
                }
            }
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class530 class2 = new Class530 {
                    int_0 = i + 1,
                    ushort_8 = reader.ReadUInt16(),
                    int_1 = reader.ReadInt32(),
                    enum11_0 = (Enum11) reader.ReadByte(),
                    int_2 = reader.ReadInt32(),
                    byte_0 = reader.ReadByte(),
                    short_0 = reader.ReadInt16(),
                    int_3 = reader.ReadInt32()
                };
                if (reader.ReadByte() == 1)
                {
                    class2.class630_0 = new Class630();
                    class2.class630_0.method_1(reader);
                }
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class530 class2 = base.arrayList_0[i] as Class530;
                writer.Write(class2.ushort_8);
                writer.Write(class2.int_1);
                writer.Write((byte) class2.enum11_0);
                writer.Write(class2.int_2);
                writer.Write(class2.byte_0);
                writer.Write(class2.short_0);
                writer.Write(class2.int_3);
                if (class2.class630_0 != null)
                {
                    writer.Write((byte) 1);
                    class2.class630_0.method_0(writer);
                }
                else
                {
                    writer.Write((byte) 0);
                }
            }
        }

        internal class Class530 : Class527
        {
            internal byte byte_0;
            internal Class630 class630_0;
            internal Enum11 enum11_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal short short_0;
            internal const ushort ushort_0 = 1;
            internal const ushort ushort_1 = 2;
            internal const ushort ushort_2 = 4;
            internal const ushort ushort_3 = 8;
            internal const ushort ushort_4 = 0x10;
            internal const ushort ushort_5 = 0x20;
            internal const ushort ushort_6 = 0x40;
            internal const ushort ushort_7 = 0x80;
            internal ushort ushort_8;

            internal void method_0(Class586 A_1, bool A_2)
            {
                A_1.method_1(new Class358(base.class369_0), Enum62.const_2);
                base.class369_0.class369_0.QQTX(A_1, A_2);
            }

            internal void method_1(Class593 A_1, bool A_2)
            {
                A_1.method_1(Class519.class581_0[this.int_1], Enum62.const_2);
                base.class369_0.class369_0.QQTX(A_1, A_2);
            }

            internal bool Boolean_0
            {
                get
                {
                    return ((this.ushort_8 & 1) != 0);
                }
            }

            internal bool Boolean_1
            {
                get
                {
                    return ((this.ushort_8 & 2) != 0);
                }
            }

            internal bool Boolean_2
            {
                get
                {
                    return ((this.ushort_8 & 4) != 0);
                }
            }

            internal bool Boolean_3
            {
                get
                {
                    return ((this.ushort_8 & 8) != 0);
                }
            }

            internal bool Boolean_4
            {
                get
                {
                    return ((this.ushort_8 & 0x10) != 0);
                }
            }

            internal bool Boolean_5
            {
                get
                {
                    return ((this.ushort_8 & 0x20) != 0);
                }
            }

            internal bool Boolean_6
            {
                get
                {
                    return ((this.ushort_8 & 0x40) != 0);
                }
            }

            internal bool Boolean_7
            {
                get
                {
                    return ((this.ushort_8 & 0x80) != 0);
                }
            }
        }
    }
}

