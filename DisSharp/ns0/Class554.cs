namespace ns0
{
    using System;
    using System.Text;

    internal class Class554 : Class546
    {
        private Class581 class581_0;

        internal Class554(Class684 A_1) : base(A_1)
        {
            this.class581_0 = A_1.class394_0.class581_0;
        }

        internal int method_0()
        {
            string str = Class537.string_261.ToLower();
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class532 class2 = base.arrayList_0[i] as Class532;
                if (this.class581_0[class2.int_0].ToLower() == str)
                {
                    return i;
                }
            }
            return -1;
        }

        internal override void QQUZ(Class656 reader, int exportVersion)
        {
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                Class532 class2 = new Class532 {
                    short_0 = reader.ReadInt16(),
                    short_1 = reader.ReadInt16(),
                    short_2 = reader.ReadInt16(),
                    short_3 = reader.ReadInt16(),
                    uint_0 = reader.ReadUInt32(),
                    int_0 = reader.ReadInt32(),
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
                Class532 class2 = base.arrayList_0[i] as Class532;
                writer.Write(class2.short_0);
                writer.Write(class2.short_1);
                writer.Write(class2.short_2);
                writer.Write(class2.short_3);
                writer.Write(class2.uint_0);
                writer.Write(class2.int_0);
                writer.Write(class2.bool_0);
            }
        }

        internal class Class532 : Class527
        {
            internal bool bool_0;
            internal int int_0;
            internal short short_0;
            internal short short_1;
            internal short short_2;
            internal short short_3;
            private static StringBuilder stringBuilder_0 = new StringBuilder(20);
            internal uint uint_0;

            internal string method_0()
            {
                stringBuilder_0.Length = 0;
                stringBuilder_0.Append(this.short_0.ToString());
                stringBuilder_0.Append('.');
                stringBuilder_0.Append(this.short_1.ToString());
                stringBuilder_0.Append('.');
                stringBuilder_0.Append(this.short_2.ToString());
                stringBuilder_0.Append('.');
                stringBuilder_0.Append(this.short_3.ToString());
                return stringBuilder_0.ToString();
            }
        }
    }
}

