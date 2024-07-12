namespace ns0
{
    using System;
    using System.Collections.Specialized;
    using System.IO;

    internal class Class515
    {
        internal string string_0;
        internal string string_1;
        internal StringCollection stringCollection_0 = new StringCollection();
        internal StringCollection stringCollection_1 = new StringCollection();
        internal StringCollection stringCollection_2 = new StringCollection();

        internal string method_0(string A_1, Enum64 A_2)
        {
            switch (A_2)
            {
                case Enum64.const_0:
                    return this.method_1(this.stringCollection_0, A_1);

                case Enum64.const_1:
                    return this.method_1(this.stringCollection_1, A_1);

                case Enum64.const_2:
                    return this.method_1(this.stringCollection_2, A_1);

                case Enum64.const_3:
                    this.string_0 = A_1;
                    return this.string_0;
            }
            return string.Empty;
        }

        private string method_1(StringCollection A_1, string A_2)
        {
            if (this.method_2(A_1, A_2))
            {
                A_1.Add(A_2);
                return A_2;
            }
            string extension = Path.GetExtension(A_2);
            A_2 = A_2.Substring(0, A_2.Length - extension.Length);
            int num = 1;
        Label_003F:
            num++;
            string str2 = A_2 + num.ToString() + extension;
            if (!this.method_2(A_1, str2))
            {
                if (num == 0x2710)
                {
                    return A_2;
                }
                goto Label_003F;
            }
            A_1.Add(str2);
            return str2;
        }

        private bool method_2(StringCollection A_1, string A_2)
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                if (A_1[i] == A_2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

