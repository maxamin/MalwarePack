namespace ns0
{
    using System;
    using System.IO;
    using System.Text;

    internal class Class1068
    {
        private byte[] byte_0;
        private Class394 class394_0;

        internal Class1068(Class394 A_1)
        {
            this.class394_0 = A_1;
        }

        internal void method_0()
        {
            if (!this.class394_0.bool_1)
            {
                this.byte_0 = Class1115.smethod_0(this.class394_0.string_2);
            }
        }

        internal void method_1(Class515 A_1, string A_2)
        {
            if (this.byte_0 != null)
            {
                string str = Class537.string_553;
                A_1.string_1 = str;
                string str2 = A_2 + str;
                A_1.method_0(str2, Enum64.const_1);
                using (Stream0 stream = new Stream0(str2, FileMode.Create, FileAccess.Write, FileShare.None, 0x8fff))
                {
                    using (Class524 class2 = new Class524(stream, Encoding.Default))
                    {
                        class2.Write(this.byte_0);
                    }
                }
            }
        }

        internal void method_2(Class524 A_1)
        {
            if (this.byte_0 != null)
            {
                A_1.Write(this.byte_0.Length);
                A_1.Write(this.byte_0);
            }
            else
            {
                A_1.Write(0);
            }
        }

        internal void method_3(Class656 A_1)
        {
            int count = A_1.ReadInt32();
            if (count > 0)
            {
                this.byte_0 = A_1.ReadBytes(count);
            }
        }

        internal byte[] Byte_0
        {
            get
            {
                return this.byte_0;
            }
        }
    }
}

