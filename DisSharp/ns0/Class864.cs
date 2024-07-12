namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class864
    {
        private ArrayList arrayList_0 = new ArrayList();
        private static ArrayList arrayList_1 = new ArrayList();

        internal void method_0(int A_1, int A_2, int A_3, int A_4)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class865 class2 = this.arrayList_0[i] as Class865;
                if ((class2.int_4 == A_1) && (class2.int_5 == A_2))
                {
                    return;
                }
            }
            this.arrayList_0.Add(new Class865(A_1, A_2, A_3, A_4));
        }

        internal void method_1(int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, uint A_7)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class865 class2 = this.arrayList_0[i] as Class865;
                if ((class2.int_4 == A_1) && (class2.int_5 == A_2))
                {
                    class2.method_0(A_3, A_4, A_5, A_6, A_7);
                    return;
                }
            }
        }

        internal void method_10(Class867 A_1, int A_2)
        {
            int num = 0;
            int num2 = 0;
            for (int i = 0; i < arrayList_1.Count; i++)
            {
                Class865 class2 = arrayList_1[i] as Class865;
                if (num < class2.int_0)
                {
                    A_1.method_0(new Class867(num, class2.int_0 - 1));
                }
                class2.method_6(A_1);
                num = class2.int_1 + 1;
                num2 = class2.int_1;
            }
            if (num2 < A_2)
            {
                A_1.method_0(new Class867(num2 + 1, A_2));
            }
        }

        internal void method_2(Class522 A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class865 class2 = this.arrayList_0[i] as Class865;
                int num2 = A_3;
                if (class2.Int32_0 > 1)
                {
                    num2--;
                }
                if ((class2.int_0 == A_2) && (class2.int_1 == num2))
                {
                    class2.method_1(A_1, A_4, A_5, A_6, A_7);
                    return;
                }
            }
        }

        internal void method_3(Class522 A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class865 class2 = this.arrayList_0[i] as Class865;
                class2.method_2();
                class2.method_3(A_1);
            }
        }

        internal void method_4()
        {
            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < this.arrayList_0.Count; i++)
                {
                    Class865 class2 = this.arrayList_0[i] as Class865;
                    if (class2.Int32_0 == 1)
                    {
                        this.arrayList_0.Remove(class2);
                        flag = true;
                        break;
                    }
                }
            }
            while (flag);
        }

        internal void method_5()
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                (this.arrayList_0[i] as Class865).method_2();
            }
        }

        internal void method_6()
        {
            Class866.smethod_2(this.arrayList_0);
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                (this.arrayList_0[i] as Class865).method_4();
            }
        }

        internal void method_7()
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class865 class2 = this.arrayList_0[i] as Class865;
                class2.int_8 = i;
            }
            for (int j = 1; j < this.arrayList_0.Count; j++)
            {
                Class865 class3 = this.arrayList_0[j] as Class865;
                int num3 = -1;
                for (int k = 0; k < j; k++)
                {
                    Class865 class4 = this.arrayList_0[k] as Class865;
                    if ((class3.int_0 >= class4.int_0) && (class3.int_1 <= class4.int_1))
                    {
                        num3 = k;
                    }
                }
                class3.int_9 = num3;
            }
        }

        internal void method_8()
        {
            arrayList_1.Clear();
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class865 class2 = this.arrayList_0[i] as Class865;
                if (class2.int_9 == -1)
                {
                    arrayList_1.Add(class2);
                    this.method_9(class2, i);
                }
            }
        }

        private void method_9(Class865 A_1, int A_2)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class865 class2 = this.arrayList_0[i] as Class865;
                if (class2.int_9 == A_2)
                {
                    A_1.method_5(class2);
                    this.method_9(class2, i);
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

        internal Class865 this[int A_1]
        {
            get
            {
                return (this.arrayList_0[A_1] as Class865);
            }
        }
    }
}

