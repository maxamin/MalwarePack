namespace ns0
{
    using System;
    using System.IO;
    using System.Text;

    internal class Class394 : Class393
    {
        internal bool bool_0;
        internal bool bool_1;
        internal bool bool_2;
        internal bool bool_3;
        internal bool bool_4;
        internal Class1068 class1068_0;
        internal Class395 class395_0 = new Class395();
        internal Class395 class395_1 = new Class395();
        internal Class395 class395_2 = new Class395();
        internal Class395 class395_3 = new Class395();
        internal Class395 class395_4 = new Class395();
        internal Class395 class395_5 = new Class395();
        internal Class395 class395_6 = new Class395();
        internal Class581 class581_0 = new Class581();
        internal Class604 class604_0 = new Class604();
        internal Class627 class627_0;
        internal Class637 class637_0;
        internal Class684 class684_0;
        internal Class803 class803_0;
        internal Class985 class985_0;
        internal int int_0;
        internal int int_1;
        internal string string_1;
        internal string string_2;

        internal Class394(string A_1, bool A_2)
        {
            this.class684_0 = new Class684(this);
            this.class803_0 = new Class803();
            this.class627_0 = new Class627(this);
            this.class985_0 = new Class985();
            this.class637_0 = new Class637();
            this.class1068_0 = new Class1068(this);
            this.string_2 = A_1;  // info: A_1 input file name
            base.string_0 = Path.GetFileNameWithoutExtension(A_1);
            this.string_1 = Path.GetExtension(A_1).ToLower();
            this.bool_0 = A_2;
            if (A_2 && (this.string_1 == Class537.string_586))
            {
                this.bool_1 = true;
                string str = base.string_0.ToLower();
                if ((str == Class537.string_261) || (str == Class537.string_845))
                {
                    this.bool_2 = true;
                }
            }
            else
            {
                this.bool_1 = false;
            }
        }

        internal void method_8()
        {
            if (!this.bool_0)
            {
                this.method_9(this.string_2);
            }
        }

        internal void method_9(string A_1)
        {
            this.string_2 = A_1;
            using (Stream0 stream = new Stream0(A_1, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Class524 class2 = new Class524(stream, Encoding.Unicode))
                {
                    this.class985_0.method_0(class2);
                    this.class1068_0.method_2(class2);
                    this.class684_0.method_0(class2);
                    base.method_0(class2);
                    class2.Write(base.string_0);
                    class2.Write(this.string_1);
                    class2.Write(this.string_2);
                    class2.Write(this.bool_1);
                    class2.Write(this.bool_2);
                    class2.Write(this.int_0);
                    class2.Write(this.int_1);
                    class2.Write(this.bool_3);
                    this.class604_0.method_5(class2);
                    this.class637_0.method_0(class2);
                    class2.Write((int) (this.class581_0.Int32_0 - 1));
                    for (int i = 1; i < this.class581_0.Int32_0; i++)
                    {
                        class2.Write(this.class581_0[i]);
                    }
                }
            }
            Class698.class582_0.class701_0.method_7(A_1);
            this.bool_0 = false;
            this.class803_0.bool_0 = false;
        }

        internal static Class686.Class687 smethod_0(string A_0)
        {
            Class394 class2 = new Class394(A_0, false);
            Class519.smethod_0(class2);
            using (Stream0 stream = new Stream0(A_0, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (Class656 class3 = new Class656(stream, Encoding.Unicode))
                {
                    class2.class985_0.method_1(class3, A_0);
                    class2.class1068_0.method_3(class3);
                    class2.class684_0.method_1(class3, class2.class985_0.short_0);
                    class2.method_1(class3, class2, class2.class985_0.short_0);
                    if (class2.class985_0.short_0 >= 2)
                    {
                        class2.string_0 = class3.ReadString();
                        class2.string_1 = class3.ReadString();
                        class2.string_2 = class3.ReadString();
                    }
                    class2.bool_1 = class3.ReadBoolean();
                    class2.bool_2 = class3.ReadBoolean();
                    class2.int_0 = class3.ReadInt32();
                    class2.int_1 = class3.ReadInt32();
                    class2.bool_3 = class3.ReadBoolean();
                    class2.class604_0.method_6(class3);
                    class2.class637_0.method_1(class3);
                    int num = class3.ReadInt32();
                    for (int i = 0; i < num; i++)
                    {
                        class2.class581_0.method_0(class3.ReadString());
                    }
                }
            }
            class2.string_2 = A_0;
            Class989.smethod_0(class2);
            Class519.smethod_0(class2);
            Class698.class582_0.class1016_0.method_0(new Class873(class2));
            return Class1088.smethod_0(class2);
        }

        internal static Class686.Class687 smethod_1(string A_0)
        {  // Info: main of decompilation, A0 = file name
            Class394 class2 = new Class394(A_0, true) {
                bool_0 = true
            };
            Class681 class3 = new Class681(A_0);
            class2.int_0 = class3.class48_0.Int32_0;
            Class519.smethod_0(class2);
            Class686.Class687 class5 = new Class680(class3, class2).method_147();
            class3.method_0();
            class2.class1068_0.method_0();
            Class989.smethod_0(class2);
            Class519.smethod_0(class2);
            if (Class516.bool_2)
            {
                Class950.smethod_0(0x2a);
            }
            if (Class516.bool_3)
            {
                Class950.smethod_0(0x37);
            }
            Class698.class582_0.class1016_0.method_0(new Class873(class2));
            return class5;
        }

        internal override Class394 QQTW
        {
            get
            {
                return this;
            }
        }
    }
}

