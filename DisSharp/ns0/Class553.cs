namespace ns0
{
    using System;

    internal class Class553 : Class546
    {
        internal Class553(Class684 A_1) : base(A_1)
        {
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class531 class2 = new Class531 {
                    byte_3 = reader.ReadByte(),
                    enum0_0 = (Enum0) reader.ReadByte(),
                    int_0 = reader.ReadInt32(),
                    int_1 = reader.ReadInt32(),
                    int_2 = reader.ReadInt32(),
                    short_0 = reader.ReadInt16(),
                    short_1 = reader.ReadInt16(),
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
                Class531 class2 = base.arrayList_0[i] as Class531;
                writer.Write(class2.byte_3);
                writer.Write((byte) class2.enum0_0);
                writer.Write(class2.int_0);
                writer.Write(class2.int_1);
                writer.Write(class2.int_2);
                writer.Write(class2.short_0);
                writer.Write(class2.short_1);
                writer.Write(class2.int_3);
            }
        }

        internal class Class531 : Class527
        {
            internal const byte byte_0 = 1;
            internal const byte byte_1 = 2;
            internal const byte byte_2 = 4;
            internal byte byte_3;
            internal Enum0 enum0_0;
            internal int int_0;
            internal int int_1;
            internal int int_2;
            internal int int_3;
            internal short short_0;
            internal short short_1;

            internal void method_0(Class586 A_1, bool A_2)
            {
                A_1.method_1(new Class345(this), Enum62.const_0);
                if (this.enum0_0 == Enum0.const_1)
                {
                    (Class546.class553_0.arrayList_0[this.int_0] as Class553.Class531).method_0(A_1, A_2);
                }
                else
                {
                    Class562 class2 = Class546.class562_0;
                    if (A_2)
                    {
                        Class562.Class533 class3 = class2.arrayList_0[this.int_2] as Class562.Class533;
                        A_1.method_1(new Class344(class3.int_1, class3.bool_0), Enum62.const_3);
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
                if (this.enum0_0 == Enum0.const_1)
                {
                    (Class546.class553_0.arrayList_0[this.int_0] as Class553.Class531).method_1(A_1, A_2);
                }
                else
                {
                    Class562 class2 = Class546.class562_0;
                    if (A_2)
                    {
                        A_1.method_1(class2[this.int_2], Enum62.const_3);
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

