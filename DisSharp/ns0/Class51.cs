namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class51 : Class50
    {
        internal ArrayList arrayList_0;
        private ArrayList arrayList_1;
        internal bool bool_1;
        private Class397 class397_0;
        internal int int_0;

        internal Class51()
        {
            this.method_0(new Class397());
        }

        internal void method_0(Class397 A_1)
        {
            this.class397_0 = A_1;
            this.arrayList_1 = A_1.ArrayList_0;
            this.arrayList_0 = A_1.arrayList_0;
            this.int_0 = A_1.int_0;
            this.bool_1 = A_1.bool_0;
        }

        internal Class397 method_1()
        {
            this.class397_0.int_0 = this.int_0;
            this.class397_0.bool_0 = this.bool_1;
            return this.class397_0;
        }

        internal void method_10(Class335 A_1)
        {
            if (this.bool_1)
            {
                this.bool_1 = false;
            }
            else
            {
                this.method_2(new Class367());
                this.method_9(A_1);
            }
        }

        internal void method_11(int A_1, Class335 A_2)
        {
            if (this.bool_1)
            {
                this.bool_1 = false;
            }
            else
            {
                this.method_2(new Class367());
                this.method_6(A_1);
                this.method_9(A_2);
            }
        }

        internal void method_12()
        {
            Class335 class1 = this.class397_0.Class367_1.Class335_0;
            if (this.class397_0.Class367_1.Class335_0 == Class518.class337_16)
            {
                this.class397_0.method_10(Class518.class337_19);
            }
        }

        internal void method_2(Class367 A_1)
        {
            this.arrayList_1.Add(A_1);
        }

        internal void method_3(Class367 A_1)
        {
            for (int i = 0; i < A_1.Int32_0; i++)
            {
                this.method_9(A_1[i]);
            }
        }

        internal void method_4(Class367 A_1)
        {
            this.arrayList_1.Insert(0, A_1);
        }

        internal Class367 method_5()
        {
            object obj2 = this.arrayList_1[0];
            this.arrayList_1.RemoveAt(0);
            return (obj2 as Class367);
        }

        private void method_6(int A_1)
        {
            int num;
            int num2 = Math.DivRem(A_1, Class516.int_2, out num);
            Class367 class2 = this.arrayList_1[this.arrayList_1.Count - 1] as Class367;
            class2.method_0(new Class341(num2));
            if (num > 0)
            {
                class2.method_0(Class517.smethod_0(num));
            }
        }

        internal void method_7()
        {
            this.method_2(new Class367());
        }

        internal void method_8(int A_1)
        {
            this.method_7();
            this.method_6(A_1);
        }

        internal void method_9(Class335 A_1)
        {
            if (this.bool_1)
            {
                this.bool_1 = false;
            }
            else
            {
                Class367 class2 = this.arrayList_1[this.arrayList_1.Count - 1] as Class367;
                if ((this.int_0 > 0) && (class2.Int32_0 == 0))
                {
                    class2.method_0(new Class341(this.int_0));
                }
                class2.method_0(A_1);
            }
        }

        internal Class367 Class367_0
        {
            get
            {
                return (this.arrayList_1[this.arrayList_1.Count - 1] as Class367);
            }
        }
    }
}

