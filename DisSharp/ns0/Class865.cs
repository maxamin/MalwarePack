namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class865
    {
        private ArrayList arrayList_0 = new ArrayList();
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal int int_3;
        internal int int_4;
        internal int int_5;
        internal int int_6;
        internal int int_7;
        internal int int_8;
        internal int int_9 = -1;

        internal Class865(int A_1, int A_2, int A_3, int A_4)
        {
            this.arrayList_0.Add(new Class927(Enum61.const_0, A_1, A_2, A_3, A_4, 0));
            this.int_4 = A_1;
            this.int_5 = A_2;
            this.int_6 = A_3;
            this.int_7 = A_4;
        }

        internal void method_0(int A_1, int A_2, int A_3, int A_4, uint A_5)
        {
            this.arrayList_0.Add(new Class927(Enum61.const_1, A_1, A_2, A_3, A_4, A_5));
        }

        internal void method_1(Class522 A_1, int A_2, int A_3, int A_4, int A_5)
        {
            this.arrayList_0.Add(new Class927(Enum61.const_2, A_2, A_3, A_4, A_5, 0));
            if (this.arrayList_0.Count == 2)
            {
                (this.arrayList_0[0] as Class927).method_0(A_1, A_3 + 1);
            }
            else
            {
                Class827 class3 = A_1.arrayList_0[A_2 - 1] as Class827;
                if (class3 != null)
                {
                    int num = (int) A_1.hashtable_1[class3.class822_0];
                    if (num == (A_3 + 1))
                    {
                        class3.bool_0 = true;
                        (A_1.arrayList_0[num] as Class822).method_0(class3);
                    }
                }
            }
        }

        internal void method_2()
        {
            Class927 class2 = this.arrayList_0[0] as Class927;
            this.int_0 = class2.int_0;
            this.int_1 = class2.int_1;
            this.int_2 = class2.int_2;
            this.int_3 = class2.int_3;
            for (int i = 1; i < this.arrayList_0.Count; i++)
            {
                class2 = this.arrayList_0[i] as Class927;
                if (class2.int_1 > this.int_1)
                {
                    this.int_1 = class2.int_1;
                    this.int_3 = class2.int_3;
                }
            }
        }

        internal void method_3(Class522 A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                (this.arrayList_0[i] as Class927).method_0(A_1, this.int_1 + 1);
            }
        }

        internal void method_4()
        {
            Class928.smethod_1(this.arrayList_0);
        }

        internal void method_5(Class865 A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class927 class2 = this.arrayList_0[i] as Class927;
                if (class2.method_1(A_1))
                {
                    return;
                }
            }
        }

        internal void method_6(Class867 A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                (this.arrayList_0[i] as Class927).method_2(A_1);
            }
        }

        internal int Int32_0
        {
            get
            {
                return this.arrayList_0.Count;
            }
        }

        internal Class927 this[int A_1]
        {
            get
            {
                return (this.arrayList_0[A_1] as Class927);
            }
        }
    }
}

