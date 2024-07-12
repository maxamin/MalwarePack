namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class1097
    {
        private ArrayList arrayList_0 = new ArrayList();
        private Class397 class397_0;
        internal int int_0;

        internal Class1097(Class397 A_1)
        {
            this.class397_0 = A_1;
        }

        internal void method_0(Class1091 A_1)
        {
            this.arrayList_0.Add(A_1);
        }

        private void method_1(int A_1)
        {
            if (this.arrayList_0.Count < A_1)
            {
                for (int i = this.arrayList_0.Count; i < A_1; i++)
                {
                    this.method_0(new Class1091());
                }
            }
        }

        internal void method_2(int A_1, int A_2, int A_3, int A_4, float A_5)
        {
            this.method_1(A_4);
            for (int i = 0; i < A_4; i++)
            {
                Class367 class2 = ((A_2 + i) < this.class397_0.Int32_0) ? this.class397_0[A_2 + i] : null;
                (this.arrayList_0[i] as Class1091).method_1(class2, A_1, A_3, A_5);
            }
            this.int_0 = A_4;
        }

        internal Class1039 method_3(int A_1, int A_2)
        {
            Class1091 class2 = this.arrayList_0[A_2] as Class1091;
            return class2.method_5(A_1);
        }

        internal Class1091 this[int A_1]
        {
            get
            {
                return (this.arrayList_0[A_1] as Class1091);
            }
            set
            {
                this.arrayList_0[A_1] = value;
            }
        }

        internal int this[Class1091 A_1]
        {
            get
            {
                return this.arrayList_0.IndexOf(A_1);
            }
        }
    }
}

