namespace ns0
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;

    internal class Class1116
    {
        private Class1010[] class1010_0;
        private IntPtr intptr_0;
        private string string_0 = string.Empty;

        internal unsafe Class1116(Class1011 A_1, IntPtr A_2)
        {
            this.intptr_0 = A_2;
            IntPtr ptr = A_1.method_2(this.intptr_0, Class1012.intptr_1);
            IntPtr ptr2 = A_1.method_3(ptr);
            A_1.method_4(ptr);
            Struct21* structPtr = (Struct21*) Class1011.smethod_0(ptr2);
            this.class1010_0 = new Class1010[structPtr->ushort_2];
            for (ushort i = 0; i < structPtr->ushort_2; i = (ushort) (i + 1))
            {
                Struct20* structPtr2 = smethod_0(structPtr, i);
                this.class1010_0[i] = new Class1010(A_1, new IntPtr(structPtr2->ushort_2));
            }
        }

        internal void method_0(string A_1)
        {
            Stream output = new FileStream(A_1, FileMode.Create, FileAccess.Write, FileShare.None);
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                this.method_2(writer);
                this.method_3(writer);
                this.method_4(writer);
            }
        }

        internal byte[] method_1()
        {
            byte[] buffer = null;
            MemoryStream output = null;
            try
            {
                output = new MemoryStream();
                using (BinaryWriter writer = new BinaryWriter(output))
                {
                    this.method_2(writer);
                    this.method_3(writer);
                    this.method_4(writer);
                }
                buffer = output.ToArray();
            }
            catch
            {
            }
            return buffer;
        }

        private void method_2(BinaryWriter A_1)
        {
            ushort length = 0;
            A_1.Write((ushort) 0);
            length = 1;
            A_1.Write((ushort) 1);
            length = (ushort) this.class1010_0.Length;
            A_1.Write(length);
        }

        private void method_3(BinaryWriter A_1)
        {
            for (int i = 0; i < this.class1010_0.Length; i++)
            {
                this.class1010_0[i].method_0(A_1, (uint) this.method_5(i));
            }
        }

        private void method_4(BinaryWriter A_1)
        {
            for (int i = 0; i < this.class1010_0.Length; i++)
            {
                this.class1010_0[i].method_1(A_1);
            }
        }

        private int method_5(int A_1)
        {
            int num = 3 * Marshal.SizeOf(typeof(ushort));
            num += this.class1010_0.Length * Marshal.SizeOf(typeof(Struct15));
            for (int i = 0; i < A_1; i++)
            {
                Class1010 class2 = this.class1010_0[i];
                num += class2.Int32_0;
            }
            return num;
        }

        private static unsafe Struct20* smethod_0(Struct21* A_0, ushort A_1)
        {
		Struct20* ptr = &A_0->struct20_0;
		return ptr + A_1;
        }

        internal string String_0
        {
            get
            {
                if (this.string_0.Length == 0)
                {
                    if (Class1012.smethod_1(this.intptr_0))
                    {
                        this.string_0 = this.intptr_0.ToString();
                    }
                    else
                    {
                        this.string_0 = Marshal.PtrToStringAuto(this.intptr_0);
                    }
                }
                return this.string_0;
            }
        }
    }
}

