namespace ns0
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Text;

    internal class Class896
    {
        private Hashtable hashtable_0 = new Hashtable();
        private static StringBuilder stringBuilder_0 = new StringBuilder(250);

        internal void method_0(string A_1, Class369 A_2)
        {
            if (!this.hashtable_0.ContainsKey(A_1))
            {
                this.hashtable_0.Add(A_1, A_2);
            }
        }

        internal void method_1(string A_1, string A_2)
        {
            object obj2 = this.hashtable_0[A_1];
            if (obj2 != null)
            {
                Class369 class2 = obj2 as Class369;
                class2.stringCollection_0 = this.method_2(A_2);
            }
        }

        private StringCollection method_2(string A_1)
        {
            StringCollection strings = new StringCollection();
            stringBuilder_0.Length = 0;
            int length = A_1.Length;
            for (int i = 0; i < length; i++)
            {
                char ch = A_1[i];
                if ((ch != '\n') && (ch != '\r'))
                {
                    stringBuilder_0.Append(ch);
                }
                else
                {
                    if (i < length)
                    {
                        switch (A_1[i + 1])
                        {
                            case '\n':
                            case '\r':
                                i++;
                                break;
                        }
                    }
                    string str = stringBuilder_0.ToString().Trim();
                    if (str.Length > 0)
                    {
                        strings.Add(str);
                    }
                    stringBuilder_0.Length = 0;
                }
            }
            string str2 = stringBuilder_0.ToString().Trim();
            if (str2.Length > 0)
            {
                strings.Add(str2);
            }
            return strings;
        }
    }
}

