namespace ns0
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;

    internal class Class1010
    {
        private byte[] byte_0;
        private int int_0;
        private int int_1;
        private int int_2;

        internal unsafe Class1010(Class1011 A_1, IntPtr A_2)
        {
            IntPtr ptr = A_1.method_2(A_2, Class1012.intptr_0);
            IntPtr source = Class1011.smethod_0(A_1.method_3(ptr));
            this.byte_0 = new byte[A_1.method_4(ptr)];
            Marshal.Copy(source, this.byte_0, 0, this.byte_0.Length);
            fixed (byte* numRef = this.byte_0)
            {
                Struct13* structPtr = (Struct13*) numRef;
                this.int_0 = structPtr->struct14_0.int_1 / 2;
                this.int_1 = structPtr->struct14_0.int_0;
                this.int_2 = structPtr->struct14_0.ushort_0 * structPtr->struct14_0.ushort_1;
            }
        }

        internal unsafe void method_0(BinaryWriter A_1, uint A_2)
        {
            Struct15 struct2 = new Struct15 {
                uint_1 = A_2,
                byte_0 = (byte) this.int_1,
                byte_1 = (byte) this.int_0
            };
            fixed (byte* numRef = this.byte_0)
            {
                Struct13* structPtr = (Struct13*) numRef;
                struct2.ushort_0 = structPtr->struct14_0.ushort_0;
                struct2.ushort_1 = structPtr->struct14_0.ushort_1;
            }
            byte num = (byte) (struct2.ushort_0 * struct2.ushort_1);
            if (8 <= num)
            {
                struct2.byte_2 = 0;
            }
            else
            {
                struct2.byte_2 = (byte) (((int) 1) << num);
            }
            struct2.uint_0 = (uint) this.Int32_0;
            A_1.Write(struct2.byte_0);
            A_1.Write(struct2.byte_1);
            A_1.Write(struct2.byte_2);
            A_1.Write(struct2.byte_3);
            A_1.Write(struct2.ushort_0);
            A_1.Write(struct2.ushort_1);
            A_1.Write(struct2.uint_0);
            A_1.Write(struct2.uint_1);
        }

        internal unsafe void method_1(BinaryWriter A_1)
        {
            fixed (byte* numRef = this.byte_0)
            {
                Struct13* structPtr = (Struct13*) numRef;
                uint num = structPtr->struct14_0.uint_2;
                structPtr->struct14_0.uint_2 = 0;
                A_1.Write(this.byte_0);
                structPtr->struct14_0.uint_2 = num;
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

