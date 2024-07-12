namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class602
    {
        private ArrayList arrayList_0 = new ArrayList();
        private int int_0;

        internal void method_0()
        {
            this.int_0 = -1;
        }

        internal int method_1()
        {
            this.int_0++;
            if (this.int_0 > (this.arrayList_0.Count - 1))
            {
                this.arrayList_0.Add(new Class367());
            }
            (this.arrayList_0[this.int_0] as Class367).method_5();
            return this.int_0;
        }

        internal void method_2(int A_1, Class335 A_2)
        {
            (this.arrayList_0[A_1] as Class367).method_0(A_2);
        }

        internal void method_3(int A_1, Class367 A_2)
        {
            Class367 class2 = this.arrayList_0[A_1] as Class367;
            for (int i = 0; i < A_2.Int32_0; i++)
            {
                class2.method_0(A_2[i]);
            }
        }

        internal int Int32_0
        {
            get
            {
                return (this.int_0 + 1);
            }
        }

        internal Class367 this[int A_1]
        {
            get
            {
                return (this.arrayList_0[A_1] as Class367);
            }
        }
    }
}

