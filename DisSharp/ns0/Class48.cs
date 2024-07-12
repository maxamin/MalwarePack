namespace ns0
{
    using System;
    using System.IO;
    using System.Text;

    internal class Class48
    {
        private byte[] byte_0;
        private Encoding encoding_0;
        internal int int_0;
        private string string_0;
        private UnicodeEncoding unicodeEncoding_0;

        internal Class48()
        {
            this.encoding_0 = Encoding.UTF8;
            this.unicodeEncoding_0 = new UnicodeEncoding();
        }

        internal Class48(byte[] A_1)
        {
            this.encoding_0 = Encoding.UTF8;
            this.unicodeEncoding_0 = new UnicodeEncoding();
            this.byte_0 = A_1;
            this.int_0 = 0;
        }

        internal Class48(string A_1)
        {
            this.encoding_0 = Encoding.UTF8;
            this.unicodeEncoding_0 = new UnicodeEncoding();
            this.string_0 = A_1;
            this.int_0 = 0;
        }

        internal void method_0()
        {
            using (Stream0 stream = new Stream0(this.string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 0x8fff))
            {
                int length = (int) stream.Length;
                this.byte_0 = new byte[length];
                stream.Read(this.byte_0, 0, length);
                stream.Flush();
                stream.Close();
            }
        }

        internal void method_1(string A_1)
        {
            using (Stream0 stream = (Stream0) File.Create(A_1, 0x8fff))
            {
                stream.Write(this.byte_0, 0, this.byte_0.Length);
            }
        }

        internal ushort method_10()
        {
            ushort num = BitConverter.ToUInt16(this.byte_0, this.int_0);
            this.int_0 += 2;
            return num;
        }

        internal int method_11()
        {
            int num = BitConverter.ToInt32(this.byte_0, this.int_0);
            this.int_0 += 4;
            return num;
        }

        internal int method_12(bool A_1)
        {
            int num;
            if (A_1)
            {
                num = BitConverter.ToUInt16(this.byte_0, this.int_0);
                this.int_0 += 2;
                return num;
            }
            num = BitConverter.ToInt32(this.byte_0, this.int_0);
            this.int_0 += 4;
            return num;
        }

        internal int method_13(int A_1)
        {
            return BitConverter.ToInt32(this.byte_0, A_1);
        }

        internal uint method_14()
        {
            uint num = BitConverter.ToUInt32(this.byte_0, this.int_0);
            this.int_0 += 4;
            return num;
        }

        internal long method_15()
        {
            long num = BitConverter.ToInt64(this.byte_0, this.int_0);
            this.int_0 += 8;
            return num;
        }

        internal ulong method_16()
        {
            ulong num = BitConverter.ToUInt64(this.byte_0, this.int_0);
            this.int_0 += 8;
            return num;
        }

        internal float method_17()
        {
            float num = BitConverter.ToSingle(this.byte_0, this.int_0);
            this.int_0 += 4;
            return num;
        }

        internal double method_18()
        {
            double num = BitConverter.ToDouble(this.byte_0, this.int_0);
            this.int_0 += 8;
            return num;
        }

        internal byte[] method_19(int A_1)
        {
            byte[] dst = new byte[A_1];
            Buffer.BlockCopy(this.byte_0, this.int_0, dst, 0, A_1);
            this.int_0 += A_1;
            return dst;
        }

        internal void method_2(string A_1, int A_2, int A_3)
        {
        }

        internal byte[] method_20(int A_1, int A_2)
        {
            byte[] dst = new byte[A_2];
            Buffer.BlockCopy(this.byte_0, A_1, dst, 0, A_2);
            return dst;
        }

        internal int method_21()
        {
            byte num2 = this.byte_0[this.int_0];
            this.int_0++;
            if ((num2 & 0x80) == 0)
            {
                return num2;
            }
            byte num3 = this.byte_0[this.int_0];
            this.int_0++;
            if ((num2 & 0x40) == 0)
            {
                num2 = (byte) (num2 & 0x3f);
                return ((num2 << 8) + num3);
            }
            byte num4 = this.byte_0[this.int_0];
            this.int_0++;
            byte num5 = this.byte_0[this.int_0];
            this.int_0++;
            num2 = (byte) (num2 & 0x1f);
            return ((((num2 << 0x18) + (num3 << 0x10)) + (num4 << 8)) + num5);
        }

        internal string method_22()
        {
            int index = this.int_0;
            while (this.byte_0[index] != 0)
            {
                index++;
            }
            string str = this.encoding_0.GetString(this.byte_0, this.int_0, index - this.int_0);
            index++;
            this.int_0 = index;
            return str;
        }

        internal string method_23(int A_1)
        {
            string str = this.encoding_0.GetString(this.byte_0, this.int_0, A_1);
            this.int_0 += A_1;
            return str;
        }

        internal string method_24(int A_1)
        {
            string str = this.unicodeEncoding_0.GetString(this.byte_0, this.int_0, A_1);
            this.int_0 += A_1;
            return str;
        }

        internal void method_3(int A_1)
        {
            this.int_0 = A_1;
        }

        internal void method_4(int A_1)
        {
            this.int_0 += A_1;
        }

        internal bool method_5()
        {
            bool flag = BitConverter.ToBoolean(this.byte_0, this.int_0);
            this.int_0++;
            return flag;
        }

        internal char method_6()
        {
            char ch = BitConverter.ToChar(this.byte_0, this.int_0);
            this.int_0 += 2;
            return ch;
        }

        internal sbyte method_7()
        {
            sbyte num = (sbyte) this.byte_0[this.int_0];
            this.int_0++;
            return num;
        }

        internal byte method_8()
        {
            byte num = this.byte_0[this.int_0];
            this.int_0++;
            return num;
        }

        internal short method_9()
        {
            short num = BitConverter.ToInt16(this.byte_0, this.int_0);
            this.int_0 += 2;
            return num;
        }

        internal bool Boolean_0
        {
            get
            {
                return (this.int_0 < (this.byte_0.Length - 1));
            }
        }

        internal byte[] Byte_0
        {
            get
            {
                return this.byte_0;
            }
            set
            {
                this.byte_0 = value;
                this.int_0 = 0;
            }
        }

        internal int Int32_0
        {
            get
            {
                return this.byte_0.Length;
            }
        }
    }
}

