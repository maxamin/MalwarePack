namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class1005
    {
        private ArrayList arrayList_0 = new ArrayList();
        private ArrayList arrayList_1;
        private Hashtable hashtable_0;

        internal void method_0(int A_1, int A_2, bool A_3)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class920 class2 = this.arrayList_0[i] as Class920;
                if ((class2.int_0 == A_1) && (class2.int_1 == A_2))
                {
                    return;
                }
            }
            this.arrayList_0.Add(new Class920(A_1, A_2, A_3));
        }

        internal void method_1(int A_1, int A_2, int A_3, int A_4, uint A_5)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class920 class2 = this.arrayList_0[i] as Class920;
                if ((class2.int_0 == A_1) && (class2.int_1 == A_2))
                {
                    Class1006 class3 = new Class1006(A_3, A_4, A_5);
                    if (class2.arrayList_0 == null)
                    {
                        class2.arrayList_0 = new ArrayList();
                    }
                    class2.arrayList_0.Add(class3);
                    class2.method_0(A_4);
                    return;
                }
            }
        }

        internal void method_2(int A_1, int A_2, int A_3, int A_4, bool A_5)
        {
            Class920 class2;
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                class2 = this.arrayList_0[i] as Class920;
                if (((class2.arrayList_0 != null) && (class2.int_0 == A_1)) && (class2.int_2 == (A_2 - 1)))
                {
                    class2.method_1(A_3, A_4);
                    return;
                }
            }
            class2 = new Class920(A_1, A_2, A_5);
            class2.method_1(A_3, A_4);
            this.arrayList_0.Add(class2);
        }

        internal void method_3()
        {
            Class919.smethod_1(this.arrayList_0);
        }

        private void method_4(int A_1, int A_2)
        {
            Class827 class2 = this.arrayList_1[A_1] as Class827;
            if (class2 != null)
            {
                int num = (int) this.hashtable_0[class2.class822_0];
                if (num == (A_2 + 1))
                {
                    class2.bool_0 = true;
                    (this.arrayList_1[num] as Class822).method_0(class2);
                }
            }
        }

        internal void method_5(ArrayList A_1, Hashtable A_2)
        {
            this.hashtable_0 = A_2;
            this.arrayList_1 = A_1;
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class920 class2 = this.arrayList_0[i] as Class920;
                if (class2.arrayList_0 == null)
                {
                    this.method_4(class2.int_1, class2.int_4);
                }
                else
                {
                    this.method_4(class2.int_1, class2.int_2);
                    ArrayList list = class2.arrayList_0;
                    for (int j = 0; j < list.Count; j++)
                    {
                        this.method_4((list[j] as Class1006).int_1, class2.int_2);
                    }
                    if (class2.bool_1)
                    {
                        this.method_4(class2.int_2 + 1, class2.int_4);
                    }
                }
            }
        }

        internal void method_6(Class522.Class523 A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class920 class2 = this.arrayList_0[i] as Class920;
                A_1.int_0++;
                if (class2.arrayList_0 != null)
                {
                    A_1.int_1 += class2.arrayList_0.Count;
                }
                if (class2.bool_1)
                {
                    A_1.int_2++;
                }
            }
        }

        internal int Int32_0
        {
            get
            {
                return this.arrayList_0.Count;
            }
        }

        internal Class920 this[int A_1]
        {
            get
            {
                return (this.arrayList_0[A_1] as Class920);
            }
        }
    }
}

