namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class562 : Class546
    {
        internal bool[] bool_0;
        internal bool bool_1;
        private Class581 class581_0;
        private Hashtable hashtable_0;
        internal int int_0;
        internal short[] short_0;
        private string string_0;

        internal Class562(Class684 A_1) : base(A_1)
        {
            this.hashtable_0 = new Hashtable();
            this.string_0 = Class537.string_0;
            this.class581_0 = A_1.class394_0.class581_0;
        }

        internal int method_0(string A_1, bool A_2)
        {
            if (this.hashtable_0.ContainsKey(A_1))
            {
                return (int) this.hashtable_0[A_1];
            }
            Class533 class2 = new Class533 {
                int_0 = base.arrayList_0.Count,
                int_1 = this.class581_0.method_0(A_1),
                bool_0 = A_2
            };
            base.arrayList_0.Add(class2);
            int num = base.arrayList_0.Count - 1;
            this.hashtable_0.Add(A_1, num);
            if (A_1 == this.string_0)
            {
                this.int_0 = num;
                this.bool_1 = true;
                class2.bool_0 = true;
            }
            return num;
        }

        internal void method_1()
        {
            this.short_0 = new short[base.arrayList_0.Count - 1];
            for (int i = 0; i < this.short_0.Length; i++)
            {
                this.short_0[i] = (short) (i + 1);
            }
            Class1100.smethod_0(base.arrayList_0, this.short_0, this.class581_0);
        }

        internal void method_2()
        {
            this.bool_0 = new bool[base.arrayList_0.Count];
        }

        internal void method_3()
        {
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                this.bool_0[i] = false;
            }
        }

        internal int method_4()
        {
            string str = Class537.string_833;
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class533 class2 = base.arrayList_0[i] as Class533;
                if (this.class581_0[class2.int_1] == str)
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
                Class533 class2 = new Class533 {
                    int_0 = i + 1,
                    int_1 = reader.ReadInt32(),
                    bool_0 = reader.ReadBoolean()
                };
                base.arrayList_0.Add(class2);
            }
            num = reader.ReadInt32();
            this.short_0 = new short[num];
            for (int j = 0; j < num; j++)
            {
                this.short_0[j] = reader.ReadInt16();
            }
            this.int_0 = reader.ReadInt32();
            this.bool_1 = reader.ReadBoolean();
            this.method_2();
        }

        internal override void QQVQ(Class524 writer)
        {
            writer.Write((int) (base.arrayList_0.Count - 1));
            for (int i = 1; i < base.arrayList_0.Count; i++)
            {
                Class533 class2 = base.arrayList_0[i] as Class533;
                writer.Write(class2.int_1);
                writer.Write(class2.bool_0);
            }
            writer.Write(this.short_0.Length);
            for (int j = 0; j < this.short_0.Length; j++)
            {
                writer.Write(this.short_0[j]);
            }
            writer.Write(this.int_0);
            writer.Write(this.bool_1);
        }

        internal bool Boolean_0
        {
            get
            {
                for (int i = 1; i < base.arrayList_0.Count; i++)
                {
                    if (this.bool_0[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        internal string this[int A_1]
        {
            get
            {
                return this.class581_0[(base.arrayList_0[A_1] as Class533).int_1];
            }
        }

        internal class Class533 : Class527
        {
            internal bool bool_0;
            internal int int_0;
            internal int int_1;
        }
    }
}

