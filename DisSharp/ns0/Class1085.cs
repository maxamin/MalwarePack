namespace ns0
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Text;

    internal class Class1085
    {
        private Class397 class397_0;

        internal Class1085(Class397 A_1)
        {
            this.class397_0 = A_1;
        }

        internal void method_0(string A_1, string A_2)
        {
            using (Stream0 stream = new Stream0(A_1, FileMode.Create, FileAccess.Write, FileShare.None, 0x8fff))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.Default))
                {
                    writer.WriteLine(Class537.string_413);
                    writer.WriteLine(Class537.string_375);
                    writer.WriteLine(Class537.string_521 + A_2 + Class537.string_687);
                    writer.WriteLine(Class537.string_710);
                    writer.WriteLine(Class537.string_448);
                    writer.WriteLine(Class537.string_742);
                    writer.WriteLine(Class537.string_931);
                    this.method_1(writer);
                    writer.WriteLine(Class537.string_24);
                    writer.WriteLine(Class537.string_893);
                    writer.WriteLine(Class537.string_342);
                    writer.WriteLine(Class537.string_361);
                }
            }
        }

        private void method_1(StreamWriter A_1)
        {
            for (int i = 0; i < this.class397_0.Int32_0; i++)
            {
                Class367 class2 = this.class397_0[i];
                for (int j = 0; j < class2.Int32_0; j++)
                {
                    A_1.Write(class2[j].ToString());
                }
                A_1.WriteLine();
            }
        }

        private string method_2(Color A_1)
        {
            string str = A_1.R.ToString("X2");
            string str2 = A_1.G.ToString("X2");
            string str3 = A_1.B.ToString("X2");
            return ("#" + str + str2 + str3);
        }
    }
}

