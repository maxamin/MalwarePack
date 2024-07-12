namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class644
    {
        private ArrayList arrayList_0 = new ArrayList();

        internal void method_0(Class642 A_1)
        {
            this.arrayList_0.Add(A_1);
        }

        internal void method_1(Class644 A_1)
        {
            for (int i = 0; i < A_1.Int32_0; i++)
            {
                this.arrayList_0.Add(A_1[i]);
            }
        }

        internal void method_2(int A_1)
        {
            if ((A_1 > (this.arrayList_0.Count - 1)) || (A_1 < 0))
            {
                throw new IndexOutOfRangeException(Class537.string_414 + Class537.string_577);
            }
            this.arrayList_0.RemoveAt(A_1);
        }

        internal void method_3(Class642 A_1)
        {
            int index = this.arrayList_0.IndexOf(A_1);
            if (index != -1)
            {
                this.arrayList_0.RemoveAt(index);
            }
        }

        internal void method_4(string A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                if ((this.arrayList_0[i] as Class642).class369_0.Name == A_1)
                {
                    this.method_2(i);
                    return;
                }
            }
        }

        internal int method_5(string A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                if ((this.arrayList_0[i] as Class642).class369_0.Name == A_1)
                {
                    return i;
                }
            }
            return -1;
        }

        internal void method_6()
        {
            this.arrayList_0.Clear();
        }

        internal int Int32_0
        {
            get
            {
                return this.arrayList_0.Count;
            }
        }

        internal Class642 this[int A_1]
        {
            get
            {
                return (this.arrayList_0[A_1] as Class642);
            }
            set
            {
                this.arrayList_0[A_1] = value;
            }
        }

        internal int this[Class642 A_1]
        {
            get
            {
                return this.arrayList_0.IndexOf(A_1);
            }
        }
    }
}

