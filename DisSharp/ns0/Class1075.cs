namespace ns0
{
    using System;
    using System.Collections.Specialized;
    using System.IO;

    internal class Class1075
    {
        private StreamReader streamReader_0;
        private string string_0;
        private StringCollection stringCollection_0;

        internal Class1075(string A_1)
        {
            this.stringCollection_0 = new StringCollection();
            this.string_0 = A_1;
        }

        internal Class1075(string A_1, bool A_2) : this(A_1)
        {
            if (A_2)
            {
                this.method_0();
            }
        }

        internal void method_0()
        {
            using (this.streamReader_0 = new StreamReader(this.string_0))
            {
                string str;
                while ((str = this.streamReader_0.ReadLine()) != null)
                {
                    this.stringCollection_0.Add(str);
                }
            }
        }

        internal void method_1(string A_1)
        {
            string str;
            this.streamReader_0 = new StreamReader(this.string_0);
            while ((str = this.streamReader_0.ReadLine()) != null)
            {
                this.stringCollection_0.Add(str);
                if (str.Trim() == A_1)
                {
                    return;
                }
            }
        }

        internal void method_2(string A_1)
        {
            string str;
            bool flag = false;
            while ((str = this.streamReader_0.ReadLine()) != null)
            {
                if (flag)
                {
                    this.stringCollection_0.Add(str);
                }
                else if (str.Trim() == A_1)
                {
                    flag = true;
                    this.stringCollection_0.Add(str);
                }
            }
            this.streamReader_0.Close();
        }

        internal void method_3()
        {
            this.stringCollection_0.Add("");
        }

        internal void method_4(string A_1)
        {
            this.stringCollection_0.Add(A_1);
        }

        internal void method_5(int A_1, string A_2)
        {
            this.stringCollection_0.Add(A_2.PadLeft(A_1 + A_2.Length, '\t'));
        }

        internal void method_6()
        {
            this.method_7(this.string_0);
        }

        internal void method_7(string A_1)
        {
            using (StreamWriter writer = new StreamWriter(A_1))
            {
                for (int i = 0; i < this.stringCollection_0.Count; i++)
                {
                    writer.WriteLine(this.stringCollection_0[i]);
                }
            }
        }
    }
}

