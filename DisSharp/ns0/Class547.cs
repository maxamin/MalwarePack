namespace ns0
{
    using System;

    internal class Class547 : Class546
    {
        private static bool bool_0 = false;
        private static bool bool_1 = true;

        internal Class547(Class684 A_1) : base(A_1)
        {
        }

        internal void method_0(Class685 A_1)
        {
            ushort[] numArray = A_1.ushort_0;
            ushort[] numArray2 = A_1.ushort_1;
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                bool flag;
                bool flag2;
                bool flag3;
                bool flag4;
                Class528 class2 = base.arrayList_0[i] as Class528;
                ushort num2 = numArray2[i];
                int num3 = num2 & 7;
                if (num3 == 1)
                {
                    class2.uint_25 |= 2;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                switch (num3)
                {
                    case 2:
                        class2.uint_25 |= 4;
                        class2.uint_25 |= 8;
                        break;

                    case 3:
                        class2.uint_25 |= 8;
                        break;

                    case 4:
                        class2.uint_25 |= 4;
                        break;

                    case 5:
                        class2.uint_25 |= 4;
                        class2.uint_25 |= 8;
                        break;

                    case 6:
                        class2.uint_25 |= 1;
                        break;
                }
                if ((num2 & 0x10) != 0)
                {
                    class2.uint_25 |= 0x10;
                }
                if ((num2 & 0x20) != 0)
                {
                    flag2 = true;
                }
                else
                {
                    flag2 = false;
                }
                if ((num2 & 0x40) != 0)
                {
                    flag3 = true;
                }
                else
                {
                    flag3 = false;
                }
                if ((num2 & 0x100) != 0)
                {
                    flag4 = true;
                }
                else
                {
                    flag4 = false;
                }
                if (!flag4 && flag2)
                {
                    class2.uint_25 |= 0x20;
                }
                if (!flag && flag3)
                {
                    if ((num2 & 0x400) != 0)
                    {
                        class2.uint_25 |= 0x100;
                    }
                    else if (flag4 && !flag2)
                    {
                        class2.uint_25 |= 0x40;
                    }
                    if (!flag4)
                    {
                        class2.uint_25 |= 0x40;
                        class2.uint_25 |= 0x80;
                    }
                }
                if ((num2 & 0x2000) != 0)
                {
                    class2.uint_25 |= 0x200;
                }
                ushort num4 = numArray[i];
                if ((num4 & 3) == 3)
                {
                    class2.uint_25 |= 0x40000;
                }
                if ((num4 & 0x1000) != 0)
                {
                    class2.uint_25 |= 0x80000;
                }
                if ((num4 & 0x80) != 0)
                {
                    class2.uint_25 |= 0x400000;
                }
            }
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            if (!bool_0)
            {
                bool_1 = true;
                try
                {
                    Class950.smethod_0(0x27);
                }
                catch (Exception)
                {
                    bool_1 = false;
                }
                bool_0 = true;
            }
            if (bool_1)
            {
                int num = reader.ReadInt32();
                for (int i = 0; i < num; i++)
                {
                    Class528 class2 = new Class528 {
                        int_0 = i + 1,
                        uint_25 = reader.ReadUInt32(),
                        enum25_0 = (Enum25) reader.ReadByte(),
                        int_1 = reader.ReadInt32(),
                        byte_0 = reader.ReadByte(),
                        short_0 = reader.ReadInt16(),
                        int_2 = reader.ReadInt32(),
                        short_1 = reader.ReadInt16(),
                        int_3 = reader.ReadInt32(),
                        int_4 = reader.ReadInt32(),
                        enum11_0 = (Enum11) reader.ReadByte(),
                        int_5 = reader.ReadInt32(),
                        byte_1 = reader.ReadByte(),
                        short_2 = reader.ReadInt16(),
                        int_6 = reader.ReadInt32(),
                        short_3 = reader.ReadInt16(),
                        int_7 = reader.ReadInt32(),
                        short_4 = reader.ReadInt16(),
                        int_8 = reader.ReadInt32()
                    };
                    int count = reader.ReadInt32();
                    if (count > 0)
                    {
                        class2.byte_2 = reader.ReadBytes(count);
                    }
                    class2.enum5_0 = (Enum5) reader.ReadByte();
                    class2.class907_0.method_3(reader);
                    class2.class907_1.method_3(reader);
                    base.arrayList_0.Add(class2);
                }
            }
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class528 class2 = base.arrayList_0[i] as Class528;
                uint num2 = class2.uint_25 & 0xfffccfff;
                writer.Write(num2);
                writer.Write((byte) class2.enum25_0);
                writer.Write(class2.int_1);
                writer.Write(class2.byte_0);
                writer.Write(class2.short_0);
                writer.Write(class2.int_2);
                writer.Write(class2.short_1);
                writer.Write(class2.int_3);
                writer.Write(class2.int_4);
                writer.Write((byte) class2.enum11_0);
                writer.Write(class2.int_5);
                writer.Write(class2.byte_1);
                writer.Write(class2.short_2);
                writer.Write(class2.int_6);
                writer.Write(class2.short_3);
                writer.Write(class2.int_7);
                writer.Write(class2.short_4);
                writer.Write(class2.int_8);
                if (class2.byte_2 != null)
                {
                    writer.Write(class2.byte_2.Length);
                    writer.Write(class2.byte_2);
                }
                else
                {
                    writer.Write(0);
                }
                writer.Write((byte) class2.enum5_0);
                class2.class907_0.method_2(writer);
                class2.class907_1.method_2(writer);
            }
        }

        internal static void smethod_1(Class528 A_0, byte A_1)
        {
            if ((A_1 & 0x20) != 0)
            {
                A_0.uint_25 |= 0x10000000;
            }
        }

        internal class Class528 : Class527
        {
            internal byte byte_0;
            internal byte byte_1;
            internal byte[] byte_2;
            internal byte[] byte_3;
            private Class1059 class1059_0 = new Class1059();
            internal Class907 class907_0 = new Class907();
            internal Class907 class907_1 = new Class907();
            internal Enum11 enum11_0;
            internal Enum25 enum25_0;
            internal Enum33 enum33_0;
            internal Enum5 enum5_0;
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
            internal const uint uint_0 = 1;
            internal const uint uint_1 = 2;
            internal const uint uint_10 = 0x400;
            internal const uint uint_11 = 0x1000000;
            internal const uint uint_12 = 0x10000000;
            private const uint uint_13 = 0x800;
            internal const uint uint_14 = 0x1000;
            internal const uint uint_15 = 0x2000;
            private const uint uint_16 = 0x4000;
            private const uint uint_17 = 0x8000;
            internal const uint uint_18 = 0x10000;
            internal const uint uint_19 = 0x20000;
            internal const uint uint_2 = 4;
            internal const uint uint_20 = 0x40000;
            internal const uint uint_21 = 0x80000;
            internal const uint uint_22 = 0x400000;
            internal const uint uint_23 = 0x100000;
            internal const uint uint_24 = 0x200000;
            internal uint uint_25;
            internal const uint uint_3 = 8;
            internal const uint uint_4 = 0x10;
            internal const uint uint_5 = 0x20;
            internal const uint uint_6 = 0x40;
            internal const uint uint_7 = 0x80;
            internal const uint uint_8 = 0x100;
            internal const uint uint_9 = 0x200;

            internal void method_0()
            {
                this.class1059_0.method_0();
                this.uint_25 &= 0xfffcefff;
            }

            internal void method_1(Enum5 A_1)
            {
                this.uint_25 |= 0x1000;
                this.enum5_0 = A_1;
            }

            internal void method_2()
            {
                this.uint_25 |= 0x8000;
            }

            internal void method_3()
            {
                this.uint_25 &= 0xfffff7ff;
            }

            internal void method_4()
            {
                this.uint_25 &= 0xfffffffd;
                this.uint_25 &= 0xfffffffb;
                this.uint_25 &= 0xfffffff7;
                this.uint_25 |= 1;
            }

            internal void method_5(Class586 A_1, bool A_2)
            {
                A_1.method_1(new Class359(base.class369_0), Enum62.const_1);
                Class369 class2 = base.class369_0.class369_0;
                if (class2.QQVU)
                {
                    class2.class369_0.QQTX(A_1, A_2);
                }
                else
                {
                    class2.QQTX(A_1, A_2);
                }
            }

            internal void method_6(Class593 A_1, bool A_2)
            {
                A_1.method_1(Class519.class581_0[this.int_1], Enum62.const_1);
                Class369 class2 = base.class369_0.class369_0;
                if (class2.QQVU)
                {
                    class2.class369_0.QQTX(A_1, A_2);
                }
                else
                {
                    class2.QQTX(A_1, A_2);
                }
            }

            internal bool Boolean_0
            {
                get
                {
                    return this.class1059_0.Boolean_0;
                }
            }

            internal bool Boolean_1
            {
                get
                {
                    return ((this.uint_25 & 0x1000) != 0);
                }
            }

            internal bool Boolean_10
            {
                get
                {
                    return ((this.uint_25 & 0x80) != 0);
                }
            }

            internal bool Boolean_11
            {
                get
                {
                    return ((this.uint_25 & 0x40) != 0);
                }
            }

            internal bool Boolean_12
            {
                get
                {
                    return ((this.uint_25 & 0x100) != 0);
                }
            }

            internal bool Boolean_13
            {
                get
                {
                    return ((this.uint_25 & 0x200) != 0);
                }
            }

            internal bool Boolean_14
            {
                get
                {
                    return ((this.uint_25 & 0x400) != 0);
                }
            }

            internal bool Boolean_15
            {
                get
                {
                    return ((this.uint_25 & 0x1000000) != 0);
                }
            }

            internal bool Boolean_16
            {
                get
                {
                    return ((this.uint_25 & 0x10000000) != 0);
                }
            }

            internal bool Boolean_17
            {
                get
                {
                    return ((this.uint_25 & 0x800) != 0);
                }
            }

            internal bool Boolean_18
            {
                get
                {
                    return ((this.uint_25 & 0x8000) != 0);
                }
            }

            internal bool Boolean_19
            {
                get
                {
                    return ((this.uint_25 & 0x40000) != 0);
                }
            }

            internal bool Boolean_2
            {
                get
                {
                    return ((this.uint_25 & 0x10000) != 0);
                }
            }

            internal bool Boolean_20
            {
                get
                {
                    return ((this.uint_25 & 0x80000) != 0);
                }
            }

            internal bool Boolean_21
            {
                get
                {
                    return ((this.uint_25 & 0x400000) != 0);
                }
            }

            internal bool Boolean_22
            {
                get
                {
                    return ((this.uint_25 & 0x100000) != 0);
                }
            }

            internal bool Boolean_23
            {
                get
                {
                    return ((this.uint_25 & 0x200000) != 0);
                }
            }

            internal bool Boolean_24
            {
                get
                {
                    return ((this.uint_25 & 0x4000) != 0);
                }
                set
                {
                    if (value)
                    {
                        this.uint_25 |= 0x4000;
                    }
                    else
                    {
                        this.uint_25 &= 0xffffbfff;
                    }
                }
            }

            internal bool Boolean_3
            {
                get
                {
                    return ((this.uint_25 & 0x20000) != 0);
                }
            }

            internal bool Boolean_4
            {
                get
                {
                    return ((this.uint_25 & 1) != 0);
                }
            }

            internal bool Boolean_5
            {
                get
                {
                    return ((this.uint_25 & 2) != 0);
                }
            }

            internal bool Boolean_6
            {
                get
                {
                    return ((this.uint_25 & 4) != 0);
                }
            }

            internal bool Boolean_7
            {
                get
                {
                    return ((this.uint_25 & 8) != 0);
                }
            }

            internal bool Boolean_8
            {
                get
                {
                    return ((this.uint_25 & 0x10) != 0);
                }
            }

            internal bool Boolean_9
            {
                get
                {
                    return ((this.uint_25 & 0x20) != 0);
                }
            }

            internal byte[] Byte_0
            {
                get
                {
                    return this.class1059_0.Byte_0;
                }
                set
                {
                    this.class1059_0.Byte_0 = value;
                }
            }
        }
    }
}

