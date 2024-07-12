namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class1091
    {
        private ArrayList arrayList_0 = new ArrayList();
        private Class367 class367_0;
        private float float_0;
        internal int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;

        internal void method_0(Class1039 A_1)
        {
            this.arrayList_0.Add(A_1);
        }

        internal void method_1(Class367 A_1, int A_2, int A_3, float A_4)
        {
            if (A_1 == null)
            {
                this.int_4 = 0;
                this.method_3().method_1(0, 0, Class517.smethod_0(A_3), Enum70.const_1);
                this.int_0 = 1;
            }
            else
            {
                this.class367_0 = A_1;
                this.float_0 = A_4;
                this.int_1 = 0;
                this.int_2 = A_2;
                this.int_3 = (A_2 + A_3) - 1;
                this.int_4 = 0;
                for (int i = 0; i < A_1.Int32_0; i++)
                {
                    if (this.int_1 > this.int_3)
                    {
                        this.int_0 = this.int_4;
                        return;
                    }
                    Class335 class3 = A_1[i];
                    this.method_4(class3);
                    this.int_1 += class3.Length;
                }
                if (this.int_1 <= this.int_3)
                {
                    this.method_3().method_1(this.method_2(), this.int_1, Class517.smethod_0((this.int_3 - this.int_1) + 1), Enum70.const_1);
                }
                this.int_0 = this.int_4;
            }
        }

        private int method_2()
        {
            return (int) Math.Ceiling((double) ((this.int_1 - this.int_2) * this.float_0));
        }

        private Class1039 method_3()
        {
            Class1039 class2;
            if (this.arrayList_0.Count > this.int_4)
            {
                class2 = this.arrayList_0[this.int_4] as Class1039;
            }
            else
            {
                class2 = new Class1039();
                this.method_0(class2);
            }
            this.int_4++;
            return class2;
        }

        private void method_4(Class335 A_1)
        {
            int num = (this.int_1 + A_1.Length) - 1;
            if (num >= this.int_2)
            {
                Class1039 class2 = this.method_3();
                if (this.int_1 >= this.int_2)
                {
                    if (num <= this.int_3)
                    {
                        class2.method_1(this.method_2(), this.int_1, A_1, Enum70.const_0);
                    }
                    else
                    {
                        class2.method_2(this.method_2(), this.int_1, A_1, A_1.ToString().Substring(0, (this.int_3 - this.int_1) + 1), Enum70.const_0);
                    }
                }
                else
                {
                    string str = A_1.ToString();
                    int startIndex = this.int_2 - this.int_1;
                    if (num <= this.int_3)
                    {
                        class2.method_2(0, this.int_1, A_1, str.Substring(startIndex, str.Length - startIndex), Enum70.const_0);
                    }
                    else
                    {
                        class2.method_2(0, this.int_1, A_1, str.Substring(startIndex, ((this.int_3 - this.int_1) + 1) - startIndex), Enum70.const_0);
                    }
                }
            }
        }

        internal Class1039 method_5(int A_1)
        {
            for (int i = 0; i < this.int_0; i++)
            {
                Class1039 class2 = this.arrayList_0[i] as Class1039;
                if (A_1 < (class2.int_1 + class2.class335_0.Length))
                {
                    return class2;
                }
            }
            throw new Exception14();
        }

        internal Class1039 this[int A_1]
        {
            get
            {
                return (this.arrayList_0[A_1] as Class1039);
            }
            set
            {
                this.arrayList_0[A_1] = value;
            }
        }

        internal int this[Class1039 A_1]
        {
            get
            {
                return this.arrayList_0.IndexOf(A_1);
            }
        }
    }
}

