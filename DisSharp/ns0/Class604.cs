namespace ns0
{
    using System;
    using System.Collections;

    internal class Class604
    {
        internal Class335 class335_0;
        internal Enum11 enum11_0;
        private Hashtable hashtable_0 = new Hashtable();
        internal const int int_0 = -1;
        internal int int_1 = -1;
        internal int int_10 = -1;
        internal int int_11 = -1;
        internal int int_12 = -1;
        internal int int_13 = -1;
        internal int int_14 = -1;
        internal int int_2 = -1;
        internal int int_3 = -1;
        internal int int_4 = -1;
        internal int int_5 = -1;
        internal int int_6 = -1;
        internal int int_7 = -1;
        internal int int_8 = -1;
        internal int int_9 = -1;
        private const uint uint_0 = 0x182fda8;
        internal uint uint_1 = 0x182fda8;
        internal uint uint_2 = 0x182fda8;
        internal uint uint_3 = 0x182fda8;
        internal uint uint_4 = 0x182fda8;
        internal uint uint_5 = 0x182fda8;
        internal uint uint_6 = 0x182fda8;
        internal uint uint_7 = 0x182fda8;
        internal uint uint_8 = 0x182fda8;
        internal uint uint_9 = 0x182fda8;

        internal void method_0(byte A_1, int A_2, Enum11 A_3, Class335 A_4)
        {
            Class888 class2 = new Class888(A_1, A_2, A_3, A_4);
            this.hashtable_0.Add(A_2, class2);
        }

        private void method_1(int A_1, Class888 A_2)
        {
            this.hashtable_0.Add(A_1, A_2);
        }

        internal bool method_2(int A_1)
        {
            object key = A_1;
            if (this.hashtable_0.ContainsKey(key))
            {
                Class888 class2 = this.hashtable_0[key] as Class888;
                this.class335_0 = class2.class335_0;
                this.enum11_0 = class2.enum11_0;
                return true;
            }
            return false;
        }

        internal bool method_3(uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            if (enum2 == Enum0.const_1)
            {
                object key = ((int) A_1) & 0xffffff;
                if (this.hashtable_0.ContainsKey(key))
                {
                    Class888 class2 = this.hashtable_0[key] as Class888;
                    this.class335_0 = class2.class335_0;
                    this.enum11_0 = class2.enum11_0;
                    return true;
                }
            }
            return false;
        }

        internal Enum11 method_4(uint A_1)
        {
            foreach (object obj2 in this.hashtable_0.Keys)
            {
                Class888 class2 = this.hashtable_0[obj2] as Class888;
                if (class2.uint_0 == A_1)
                {
                    return class2.enum11_0;
                }
            }
            return Enum11.const_0;
        }

        internal void method_5(Class524 A_1)
        {
            A_1.Write(this.int_1);
            A_1.Write(this.uint_1);
            A_1.Write(this.int_2);
            A_1.Write(this.uint_2);
            A_1.Write(this.int_3);
            A_1.Write(this.int_4);
            A_1.Write(this.int_5);
            A_1.Write(this.int_6);
            A_1.Write(this.int_7);
            A_1.Write(this.int_8);
            A_1.Write(this.int_9);
            A_1.Write(this.int_10);
            A_1.Write(this.uint_3);
            A_1.Write(this.uint_4);
            A_1.Write(this.int_11);
            A_1.Write(this.uint_5);
            A_1.Write(this.uint_6);
            A_1.Write(this.int_12);
            A_1.Write(this.int_13);
            A_1.Write(this.uint_7);
            A_1.Write(this.uint_8);
            A_1.Write(this.int_14);
            A_1.Write(this.uint_9);
            A_1.Write(this.hashtable_0.Count);
            foreach (object obj2 in this.hashtable_0.Keys)
            {
                Class888 class2 = this.hashtable_0[obj2] as Class888;
                A_1.Write((int) obj2);
                A_1.Write(class2.byte_0);
                A_1.Write(class2.int_0);
                A_1.Write((byte) class2.enum11_0);
                A_1.Write(class2.class335_0.ToString());
            }
        }

        internal void method_6(Class656 A_1)
        {
            this.int_1 = A_1.ReadInt32();
            this.uint_1 = A_1.ReadUInt32();
            this.int_2 = A_1.ReadInt32();
            this.uint_2 = A_1.ReadUInt32();
            this.int_3 = A_1.ReadInt32();
            this.int_4 = A_1.ReadInt32();
            this.int_5 = A_1.ReadInt32();
            this.int_6 = A_1.ReadInt32();
            this.int_7 = A_1.ReadInt32();
            this.int_8 = A_1.ReadInt32();
            this.int_9 = A_1.ReadInt32();
            this.int_10 = A_1.ReadInt32();
            this.uint_3 = A_1.ReadUInt32();
            this.uint_4 = A_1.ReadUInt32();
            this.int_11 = A_1.ReadInt32();
            this.uint_5 = A_1.ReadUInt32();
            this.uint_6 = A_1.ReadUInt32();
            this.int_12 = A_1.ReadInt32();
            this.int_13 = A_1.ReadInt32();
            this.uint_7 = A_1.ReadUInt32();
            this.uint_8 = A_1.ReadUInt32();
            this.int_14 = A_1.ReadInt32();
            this.uint_9 = A_1.ReadUInt32();
            int num = A_1.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                int num3 = A_1.ReadInt32();
                byte num4 = A_1.ReadByte();
                int num5 = A_1.ReadInt32();
                Enum11 enum2 = (Enum11) A_1.ReadByte();
                string str = A_1.ReadString();
                Class888 class2 = new Class888(num4, num5, enum2, Class613.smethod_0(str));
                this.method_1(num3, class2);
            }
        }
    }
}

