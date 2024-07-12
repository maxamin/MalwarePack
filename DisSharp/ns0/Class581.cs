namespace ns0
{
    using System;
    using System.Collections.Specialized;
    using System.Reflection;

    internal class Class581
    {
        private StringCollection stringCollection_0 = new StringCollection();

        internal Class581()
        {
            this.stringCollection_0.Add(string.Empty);
        }

        internal int method_0(string A_1)
        {
            this.stringCollection_0.Add(A_1);
            return (this.stringCollection_0.Count - 1);
        }

        internal int Int32_0
        {
            get
            {
                return this.stringCollection_0.Count;
            }
        }

        internal string this[int A_1]
        {
            get
            {
                return this.stringCollection_0[A_1];
            }
            set
            {
                this.stringCollection_0[A_1] = value;
            }
        }
    }
}

