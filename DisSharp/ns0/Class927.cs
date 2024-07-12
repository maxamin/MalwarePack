namespace ns0
{
    using System;
    using System.Collections;

    internal class Class927
    {
        private ArrayList arrayList_0;
        internal Enum61 enum61_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal int int_3;
        internal uint uint_0;

        internal Class927(Enum61 A_1, int A_2, int A_3, int A_4, int A_5, uint A_6)
        {
            this.enum61_0 = A_1;
            this.int_0 = A_2;
            this.int_1 = A_3;
            this.int_2 = A_4;
            this.int_3 = A_5;
            this.uint_0 = A_6;
        }

        internal void method_0(Class522 A_1, int A_2)
        {
            Class827 class2 = A_1.arrayList_0[this.int_1] as Class827;
            if (class2 != null)
            {
                int num = (int) A_1.hashtable_1[class2.class822_0];
                if (num == A_2)
                {
                    class2.bool_0 = true;
                    (A_1.arrayList_0[num] as Class822).method_0(class2);
                }
            }
        }

        internal bool method_1(Class865 A_1)
        {
            if ((A_1.int_0 < this.int_0) || (A_1.int_1 > this.int_1))
            {
                return false;
            }
            if (this.arrayList_0 == null)
            {
                this.arrayList_0 = new ArrayList();
            }
            this.arrayList_0.Add(A_1);
            return true;
        }

        internal void method_2(Class867 A_1)
        {
            Class867 class2 = this.method_3();
            A_1.method_0(class2);
            if (this.arrayList_0 != null)
            {
                int num = this.int_0;
                int num2 = 0;
                for (int i = 0; i < this.arrayList_0.Count; i++)
                {
                    Class865 class3 = this.arrayList_0[i] as Class865;
                    if (num < class3.int_0)
                    {
                        class2.method_0(new Class867(num, class3.int_0 - 1));
                    }
                    class3.method_6(class2);
                    num = class3.int_1 + 1;
                    num2 = class3.int_1;
                }
                if (num2 < this.int_1)
                {
                    class2.method_0(new Class867(num2 + 1, this.int_1));
                }
            }
        }

        private Class867 method_3()
        {
            switch (this.enum61_0)
            {
                case Enum61.const_0:
                    return new Class867(Enum68.const_1, this.int_0, this.int_1);

                case Enum61.const_1:
                    return new Class867(Enum68.const_2, this.uint_0, this.int_0, this.int_1);

                case Enum61.const_2:
                    return new Class867(Enum68.const_3, this.int_0, this.int_1);
            }
            return null;
        }
    }
}

