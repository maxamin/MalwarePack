namespace ns0
{
    using System;

    internal class Class655 : Class650
    {
        internal override void QQWX(Class524 writer)
        {
            writer.Write((short) Class516.int_1);
            writer.Write(Class923.String_0);
            writer.Write(Class923.String_1);
            writer.Write((short) this.Int32_0);
            for (int i = 1; i <= this.Int32_0; i++)
            {
                Class998 class2 = Class698.class582_0.class701_0.ArrayList_0[i - 1] as Class998;
                writer.Write(class2.string_0);
            }
            writer.Write((short) this.Int32_1);
            for (int j = 1; j <= this.Int32_1; j++)
            {
                Class998 class3 = Class698.class582_0.class701_0.ArrayList_1[j - 1] as Class998;
                writer.Write(class3.string_0);
            }
        }

        internal override void QQWY(Class656 reader, byte version)
        {
            string str;
            Class516.int_1 = reader.ReadInt16();
            Class923.String_0 = reader.ReadString();
            Class923.String_1 = reader.ReadString();
            int num = reader.ReadInt16();
            if (num > Class516.int_1)
            {
                throw new Exception2();
            }
            for (int i = 0; i < num; i++)
            {
                str = reader.ReadString();
                Class698.class582_0.class701_0.ArrayList_0.Add(new Class998(str, Enum67.const_0));
            }
            num = reader.ReadInt16();
            if (num > Class516.int_1)
            {
                throw new Exception2();
            }
            for (int j = 0; j < num; j++)
            {
                str = reader.ReadString();
                Class698.class582_0.class701_0.ArrayList_1.Add(new Class998(str, Enum67.const_1));
            }
            if (version == 1)
            {
            }
        }

        private int Int32_0
        {
            get
            {
                if (Class698.class582_0.class701_0.ArrayList_0.Count <= Class516.int_1)
                {
                    return Class698.class582_0.class701_0.ArrayList_0.Count;
                }
                return Class516.int_1;
            }
        }

        private int Int32_1
        {
            get
            {
                if (Class698.class582_0.class701_0.ArrayList_1.Count <= Class516.int_1)
                {
                    return Class698.class582_0.class701_0.ArrayList_1.Count;
                }
                return Class516.int_1;
            }
        }

        internal override byte Version
        {
            get
            {
                return 1;
            }
        }
    }
}

