namespace ns0
{
    using System;
    using System.Collections;

    internal class Class548 : Class546
    {
        internal Class548(Class684 A_1) : base(A_1)
        {
        }

        internal void method_0(Class685 A_1)
        {
            uint[] numArray = A_1.uint_0;
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class529 class2 = base.arrayList_0[i] as Class529;
                uint num2 = numArray[i];
                uint num3 = num2 & 7;
                switch (num3)
                {
                    case 0:
                        class2.ushort_17 = (ushort) (class2.ushort_17 | 8);
                        break;

                    case 1:
                        class2.ushort_17 = (ushort) (class2.ushort_17 | 1);
                        break;

                    case 2:
                        class2.ushort_17 = (ushort) (class2.ushort_17 | 1);
                        break;

                    case 3:
                        class2.ushort_17 = (ushort) (class2.ushort_17 | 2);
                        break;

                    case 4:
                        class2.ushort_17 = (ushort) (class2.ushort_17 | 4);
                        break;

                    case 5:
                        class2.ushort_17 = (ushort) (class2.ushort_17 | 8);
                        break;
                }
                if ((num3 == 6) || (num3 == 7))
                {
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 4);
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 8);
                }
                if ((num2 & 0x20) != 0)
                {
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 0x10);
                }
                if ((num2 & 0x80) != 0)
                {
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 0x20);
                }
                if ((num2 & 0x100) != 0)
                {
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 0x40);
                }
                if ((num2 & 0x1000) != 0)
                {
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 0x400);
                }
                if ((num2 & 0x2000) != 0)
                {
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 0x80);
                }
                if ((num2 & 8) != 0)
                {
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 0x100);
                }
                if ((num2 & 0x10) != 0)
                {
                    class2.ushort_17 = (ushort) (class2.ushort_17 | 0x200);
                }
            }
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class529 class2 = new Class529 {
                    int_0 = i + 1,
                    ushort_17 = reader.ReadUInt16(),
                    int_1 = reader.ReadInt32(),
                    int_2 = reader.ReadInt32(),
                    short_0 = reader.ReadInt16(),
                    short_1 = reader.ReadInt16(),
                    int_3 = reader.ReadInt32(),
                    enum0_0 = (Enum0) reader.ReadByte(),
                    int_4 = reader.ReadInt32(),
                    short_2 = reader.ReadInt16(),
                    int_5 = reader.ReadInt32(),
                    short_3 = reader.ReadInt16(),
                    int_6 = reader.ReadInt32(),
                    short_4 = reader.ReadInt16(),
                    int_7 = reader.ReadInt32(),
                    short_5 = reader.ReadInt16(),
                    int_8 = reader.ReadInt32()
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class529 class2 = base.arrayList_0[i] as Class529;
                writer.Write(class2.ushort_17);
                writer.Write(class2.int_1);
                writer.Write(class2.int_2);
                writer.Write(class2.short_0);
                writer.Write(class2.short_1);
                writer.Write(class2.int_3);
                writer.Write((byte) class2.enum0_0);
                writer.Write(class2.int_4);
                writer.Write(class2.short_2);
                writer.Write(class2.int_5);
                writer.Write(class2.short_3);
                writer.Write(class2.int_6);
                writer.Write(class2.short_4);
                writer.Write(class2.int_7);
                writer.Write(class2.short_5);
                writer.Write(class2.int_8);
            }
        }

        internal class Class529 : Class527
        {
            internal Enum0 enum0_0;
            internal Hashtable hashtable_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal int int_4;
            internal int int_5;
            internal int int_6;
            internal int int_7;
            internal int int_8;
            internal short short_0;
            internal short short_1;
            internal short short_2;
            internal short short_3;
            internal short short_4;
            internal short short_5;
            private static string string_0 = Class537.string_89;
            private static string string_1 = Class537.string_0;
            internal const ushort ushort_0 = 1;
            internal const ushort ushort_1 = 2;
            internal const ushort ushort_10 = 0;
            internal const ushort ushort_11 = 0x100;
            internal const ushort ushort_12 = 0x200;
            internal const ushort ushort_13 = 0x1000;
            internal const ushort ushort_14 = 0x2000;
            internal const ushort ushort_15 = 0x4000;
            internal const ushort ushort_16 = 0x8000;
            internal ushort ushort_17;
            internal const ushort ushort_2 = 4;
            internal const ushort ushort_3 = 8;
            internal const ushort ushort_4 = 0x10;
            internal const ushort ushort_5 = 0x20;
            internal const ushort ushort_6 = 0x40;
            internal const ushort ushort_7 = 0x80;
            internal const ushort ushort_8 = 0x400;
            internal const ushort ushort_9 = 0x300;

            internal void method_0(Class586 A_1, bool A_2)
            {
                A_1.method_1(new Class357(base.class369_0), Enum62.const_0);
                if ((base.class369_0 != null) && !base.class369_0.class369_0.QQTX(A_1, A_2))
                {
                    Class562 class2 = Class546.class562_0;
                    if (A_2)
                    {
                        Class562.Class533 class3 = class2.arrayList_0[this.int_2] as Class562.Class533;
                        if (class2.bool_1 && (this.int_2 == class2.int_0))
                        {
                            A_1.method_1(new Class352(class3.int_1, class2), Enum62.const_3);
                        }
                        else
                        {
                            A_1.method_1(new Class344(class3.int_1, class3.bool_0), Enum62.const_3);
                        }
                    }
                    if (Class516.bool_24)
                    {
                        class2.bool_0[this.int_2] = true;
                    }
                }
            }

            internal void method_1(Class593 A_1, bool A_2)
            {
                A_1.method_1(Class519.class581_0[this.int_1], Enum62.const_0);
                if ((base.class369_0 != null) && !base.class369_0.class369_0.QQTX(A_1, A_2))
                {
                    Class562 class2 = Class546.class562_0;
                    if (A_2)
                    {
                        if (class2.bool_1 && (this.int_2 == class2.int_0))
                        {
                            A_1.method_1(string_0, Enum62.const_3);
                        }
                        else
                        {
                            A_1.method_1(class2[this.int_2], Enum62.const_3);
                        }
                    }
                    if (Class516.bool_24)
                    {
                        class2.bool_0[this.int_2] = true;
                    }
                }
            }

            internal bool Boolean_0
            {
                get
                {
                    return ((this.ushort_17 & 1) != 0);
                }
            }

            internal bool Boolean_1
            {
                get
                {
                    return ((this.ushort_17 & 2) != 0);
                }
            }

            internal bool Boolean_10
            {
                get
                {
                    return ((this.ushort_17 & 0x300) == 0);
                }
            }

            internal bool Boolean_11
            {
                get
                {
                    return ((this.ushort_17 & 0x100) != 0);
                }
            }

            internal bool Boolean_12
            {
                get
                {
                    return ((this.ushort_17 & 0x200) != 0);
                }
            }

            internal bool Boolean_13
            {
                get
                {
                    return ((this.ushort_17 & 0x1000) != 0);
                }
            }

            internal bool Boolean_14
            {
                get
                {
                    return ((this.ushort_17 & 0x2000) != 0);
                }
            }

            internal bool Boolean_15
            {
                get
                {
                    return ((this.ushort_17 & 0x4000) != 0);
                }
            }

            internal bool Boolean_16
            {
                get
                {
                    return ((this.ushort_17 & 0x8000) != 0);
                }
            }

            internal bool Boolean_2
            {
                get
                {
                    return ((this.ushort_17 & 4) != 0);
                }
            }

            internal bool Boolean_3
            {
                get
                {
                    return ((this.ushort_17 & 8) != 0);
                }
            }

            internal bool Boolean_4
            {
                get
                {
                    return ((this.ushort_17 & 0x10) == 0);
                }
            }

            internal bool Boolean_5
            {
                get
                {
                    return ((this.ushort_17 & 0x10) != 0);
                }
            }

            internal bool Boolean_6
            {
                get
                {
                    return ((this.ushort_17 & 0x20) != 0);
                }
            }

            internal bool Boolean_7
            {
                get
                {
                    return ((this.ushort_17 & 0x40) != 0);
                }
            }

            internal bool Boolean_8
            {
                get
                {
                    return ((this.ushort_17 & 0x80) != 0);
                }
            }

            internal bool Boolean_9
            {
                get
                {
                    return ((this.ushort_17 & 0x400) != 0);
                }
            }
        }
    }
}

