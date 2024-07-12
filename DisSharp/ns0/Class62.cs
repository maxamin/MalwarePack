namespace ns0
{
    using System;
    using System.Collections.Specialized;

    internal abstract class Class62 : Class61
    {
        protected Class62()
        {
        }

        internal void method_46(Class369 A_1)
        {
            StringCollection strings = A_1.stringCollection_0;
            if (strings != null)
            {
                for (int i = 0; i < strings.Count; i++)
                {
                    base.method_10(this.QRTY());
                    base.method_9(new Class338(strings[i]));
                }
            }
        }
    }
}

