namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Reflection;
    using System.Text;

    internal class Class367
    {
        private ArrayList arrayList_0;
        private static StringBuilder stringBuilder_0 = new StringBuilder(120);

        internal Class367()
        {
            this.arrayList_0 = new ArrayList();
        }

        internal Class367(Class335 A_1)
        {
            this.arrayList_0 = new ArrayList();
            this.method_0(A_1);
        }

        internal void method_0(Class335 A_1)
        {
            this.arrayList_0.Add(A_1);
        }

        internal void method_1(Class367 A_1)
        {
            for (int i = 0; i < A_1.Int32_0; i++)
            {
                this.arrayList_0.Add(A_1[i]);
            }
        }

        internal void method_2(int A_1, Class335 A_2)
        {
            this.arrayList_0.Insert(A_1, A_2);
        }

        internal void method_3(int A_1)
        {
            if ((A_1 > (this.arrayList_0.Count - 1)) || (A_1 < 0))
            {
                throw new IndexOutOfRangeException(Class537.string_203 + Class537.string_577);
            }
            this.arrayList_0.RemoveAt(A_1);
        }

        internal void method_4(Class335 A_1)
        {
            int index = this.arrayList_0.IndexOf(A_1);
            if (index != -1)
            {
                this.arrayList_0.RemoveAt(index);
            }
        }

        internal void method_5()
        {
            this.arrayList_0.Clear();
        }

        internal void method_6(StreamWriter A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                A_1.Write((this.arrayList_0[i] as Class335).ToString());
            }
        }

        internal void method_7(Class862 A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class335 class2 = this.arrayList_0[i] as Class335;
                A_1.SelectionColor = Class863.smethod_1(class2.QQSX);
                A_1.AppendText(class2.ToString());
            }
        }

        public override string ToString()
        {
            stringBuilder_0.Length = 0;
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                stringBuilder_0.Append((this.arrayList_0[i] as Class335).ToString());
            }
            return stringBuilder_0.ToString();
        }

        internal Class335 Class335_0
        {
            get
            {
                if (this.arrayList_0.Count > 0)
                {
                    return (this.arrayList_0[this.arrayList_0.Count - 1] as Class335);
                }
                return null;
            }
        }

        internal int Int32_0
        {
            get
            {
                return this.arrayList_0.Count;
            }
        }

        internal int Int32_1
        {
            get
            {
                int num = 0;
                for (int i = 0; i < this.arrayList_0.Count; i++)
                {
                    num += (this.arrayList_0[i] as Class335).Length;
                }
                return num;
            }
        }

        internal Class335 this[int A_1]
        {
            get
            {
                return (this.arrayList_0[A_1] as Class335);
            }
            set
            {
                this.arrayList_0[A_1] = value;
            }
        }

        internal int this[Class335 A_1]
        {
            get
            {
                return this.arrayList_0.IndexOf(A_1);
            }
        }
    }
}

