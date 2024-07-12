namespace ns0
{
    using System;
    using System.Collections;

    internal class Class867
    {
        internal ArrayList arrayList_0;
        internal bool bool_0;
        internal bool bool_1;
        internal bool bool_2;
        internal static bool bool_3 = true;
        private static Class1090 class1090_0 = new Class1090();
        internal Enum68 enum68_0;
        internal int int_0;
        internal int int_1;
        private static int int_2 = 1;
        private static int int_3;
        internal uint uint_0;
        internal ushort ushort_0;

        internal Class867(int A_1, int A_2)
        {
            this.enum68_0 = Enum68.const_0;
            this.int_0 = A_1;
            this.int_1 = A_2;
        }

        internal Class867(Enum68 A_1, int A_2, int A_3)
        {
            this.enum68_0 = A_1;
            this.int_0 = A_2;
            this.int_1 = A_3;
        }

        internal Class867(Enum68 A_1, int A_2, int A_3, bool A_4)
        {
            this.enum68_0 = A_1;
            this.int_0 = A_2;
            this.int_1 = A_3;
            this.bool_2 = A_4;
        }

        internal Class867(Enum68 A_1, uint A_2, int A_3, int A_4)
        {
            this.enum68_0 = A_1;
            this.uint_0 = A_2;
            this.int_0 = A_3;
            this.int_1 = A_4;
        }

        internal void method_0(Class867 A_1)
        {
            if (this.arrayList_0 == null)
            {
                this.arrayList_0 = new ArrayList();
            }
            this.arrayList_0.Add(A_1);
        }

        private bool method_1()
        {
            if (bool_3)
            {
                return (this.enum68_0 != Enum68.const_0);
            }
            return true;
        }

        internal void method_2(Class867 A_1, bool A_2)
        {
            int num = A_1.int_0;
            int num2 = A_1.int_1;
            if ((num >= this.int_0) && (num2 <= this.int_1))
            {
                if (this.arrayList_0 == null)
                {
                    this.arrayList_0 = new ArrayList();
                    if (num > this.int_0)
                    {
                        this.arrayList_0.Add(new Class867(this.int_0, num - 1));
                    }
                    this.arrayList_0.Add(A_1);
                    if (num2 < this.int_1)
                    {
                        this.arrayList_0.Add(new Class867(num2 + 1, this.int_1));
                    }
                    if (A_2)
                    {
                        int_3 = int_2;
                    }
                }
                else
                {
                    Class867 class2;
                    int index = 0;
                    int num4 = 0;
                    bool flag = true;
                    bool flag2 = false;
                    bool flag3 = false;
                    bool flag4 = false;
                    for (int i = 0; i < this.arrayList_0.Count; i++)
                    {
                        class2 = this.arrayList_0[i] as Class867;
                        if ((flag && (class2.int_0 <= num)) && (num <= class2.int_1))
                        {
                            index = i;
                            flag = false;
                            flag3 = class2.int_0 == num;
                        }
                        if (num2 < class2.int_0)
                        {
                            num4 = i - 1;
                            flag2 = true;
                            flag4 = class2.int_0 == (num2 + 1);
                            break;
                        }
                    }
                    if (!flag2)
                    {
                        num4 = this.arrayList_0.Count - 1;
                        flag4 = this.int_1 == num2;
                    }
                    if (index == num4)
                    {
                        if (!flag3 || !flag4)
                        {
                            if (A_2 && this.method_1())
                            {
                                int_2++;
                                (this.arrayList_0[index] as Class867).method_2(A_1, true);
                                int_2--;
                            }
                            else if (int_2 != int_3)
                            {
                                int_2++;
                                (this.arrayList_0[index] as Class867).method_2(A_1, false);
                                int_2--;
                            }
                            else
                            {
                                class2 = this.arrayList_0[index] as Class867;
                                this.arrayList_0.RemoveAt(index);
                                if (num > class2.int_0)
                                {
                                    this.arrayList_0.Add(new Class867(class2.int_0, num - 1));
                                }
                                this.arrayList_0.Add(A_1);
                                if (num2 < class2.int_1)
                                {
                                    this.arrayList_0.Add(new Class867(num2 + 1, class2.int_1));
                                }
                                class1090_0.method_1(this.arrayList_0);
                            }
                        }
                        else
                        {
                            this.arrayList_0[index] = A_1;
                            if (A_2)
                            {
                                int_3 = int_2;
                            }
                        }
                    }
                    else
                    {
                        if (A_1.arrayList_0 == null)
                        {
                            A_1.arrayList_0 = new ArrayList();
                        }
                        if (!flag3)
                        {
                            class2 = this.arrayList_0[index] as Class867;
                            A_1.arrayList_0.Add(new Class867(num, class2.int_1));
                            class2.int_1 = num - 1;
                            index++;
                        }
                        if (!flag4)
                        {
                            class2 = this.arrayList_0[num4] as Class867;
                            A_1.arrayList_0.Add(new Class867(class2.int_0, num2));
                            class2.int_0 = num2 + 1;
                            num4--;
                        }
                        if (index < num4)
                        {
                            for (int j = index; j <= num4; j++)
                            {
                                A_1.arrayList_0.Add(this.arrayList_0[j]);
                            }
                            for (int k = 0; k <= (num4 - index); k++)
                            {
                                this.arrayList_0.RemoveAt(index);
                            }
                        }
                        this.arrayList_0.Add(A_1);
                        if (A_2)
                        {
                            int_3 = int_2;
                        }
                        class1090_0.method_1(this.arrayList_0);
                        class1090_0.method_1(A_1.arrayList_0);
                    }
                }
            }
        }

        internal void method_3(Class522.Class523 A_1)
        {
            if (this.arrayList_0 != null)
            {
                for (int i = 0; i < this.arrayList_0.Count; i++)
                {
                    Class867 class2 = this.arrayList_0[i] as Class867;
                    switch (class2.enum68_0)
                    {
                        case Enum68.const_1:
                            A_1.int_0++;
                            break;

                        case Enum68.const_2:
                            A_1.int_1++;
                            break;

                        case Enum68.const_3:
                            A_1.int_2++;
                            break;
                    }
                    class2.method_3(A_1);
                }
            }
        }
    }
}

