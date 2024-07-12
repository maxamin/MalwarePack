namespace ns0
{
    using System;
    using System.Collections.Specialized;
    using System.IO;

    internal class Class921
    {
        private StringCollection stringCollection_0 = new StringCollection();

        internal void method_0()
        {
            try
            {
                string str = Class537.string_542;
                for (int i = 0; i < this.stringCollection_0.Count; i++)
                {
                    string path = this.stringCollection_0[i];
                    if (Path.GetExtension(path).ToLower() == str)
                    {
                        Class702.smethod_1(path);
                    }
                    else
                    {
                        Class700.smethod_3(path);
                    }
                }
            }
            finally
            {
                Class922.smethod_0();
            }
        }

        internal StringCollection StringCollection_0
        {
            get
            {
                return this.stringCollection_0;
            }
        }
    }
}

