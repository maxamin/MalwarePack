namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Reflection;

    internal class Class397
    {
        internal ArrayList arrayList_0;
        private ArrayList arrayList_1;
        internal bool bool_0;
        internal int int_0;

        internal Class397()
        {
            this.arrayList_1 = new ArrayList();
        }

        internal Class397(bool A_1)
        {
            this.arrayList_1 = new ArrayList();
            if (A_1)
            {
                this.arrayList_0 = new ArrayList();
            }
        }

        internal void method_0(Class367 A_1)
        {
            this.arrayList_1.Add(A_1);
        }

        internal void method_1(Class367 A_1)
        {
            for (int i = 0; i < A_1.Int32_0; i++)
            {
                this.method_10(A_1[i]);
            }
        }

        internal void method_10(Class335 A_1)
        {
            if (this.bool_0)
            {
                this.bool_0 = false;
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

        internal void method_11(Class335 A_1)
        {
            if (this.bool_0)
            {
                this.bool_0 = false;
            }
            else
            {
                this.method_0(new Class367());
                this.method_10(A_1);
            }
        }

        internal void method_12(int A_1, Class335 A_2)
        {
            if (this.bool_0)
            {
                this.bool_0 = false;
            }
            else
            {
                this.method_0(new Class367());
                this.method_7(A_1);
                this.method_10(A_2);
            }
        }

        internal void method_13(StreamWriter A_1)
        {
            for (int i = 0; i < this.arrayList_1.Count; i++)
            {
                (this.arrayList_1[i] as Class367).method_6(A_1);
                A_1.WriteLine();
            }
        }

        internal void method_14(Class862 A_1)
        {
            for (int i = 0; i < this.arrayList_1.Count; i++)
            {
                (this.arrayList_1[i] as Class367).method_7(A_1);
                A_1.AppendText("\r\n");
            }
        }

        internal void method_2(Class367 A_1)
        {
            this.arrayList_1.Insert(0, A_1);
        }

        internal void method_3(int A_1)
        {
            if ((A_1 > (this.arrayList_1.Count - 1)) || (A_1 < 0))
            {
                throw new IndexOutOfRangeException(Class537.string_190 + Class537.string_577);
            }
            this.arrayList_1.RemoveAt(A_1);
        }

        internal void method_4(Class367 A_1)
        {
            int index = this.arrayList_1.IndexOf(A_1);
            if (index != -1)
            {
                this.method_3(index);
            }
        }

        internal void method_5()
        {
            this.arrayList_1.Clear();
        }

        internal int method_6(Class367 A_1)
        {
            return this.arrayList_1.IndexOf(A_1);
        }

        private void method_7(int A_1)
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

        internal void method_8()
        {
            this.method_0(new Class367());
        }

        internal void method_9(int A_1)
        {
            this.method_8();
            this.method_7(A_1);
        }

        internal ArrayList ArrayList_0
        {
            get
            {
                return this.arrayList_1;
            }
            set
            {
                this.arrayList_1 = value;
            }
        }

        internal Class367 Class367_0
        {
            get
            {
                return (this.arrayList_1[0] as Class367);
            }
        }

        internal Class367 Class367_1
        {
            get
            {
                return (this.arrayList_1[this.arrayList_1.Count - 1] as Class367);
            }
        }

        internal int Int32_0
        {
            get
            {
                return this.arrayList_1.Count;
            }
        }

        internal Class367 this[int A_1]
        {
            get
            {
                return (this.arrayList_1[A_1] as Class367);
            }
            set
            {
                this.arrayList_1[A_1] = value;
            }
        }

        internal int this[Class367 A_1]
        {
            get
            {
                return this.arrayList_1.IndexOf(A_1);
            }
        }
    }
}

