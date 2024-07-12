namespace ns0
{
    using System;
    using System.Collections;

    internal class Class965
    {
        private ArrayList arrayList_0;

        private int method_0(Class369 A_1, Class369 A_2)
        {
            Enum10 qQQS = A_1.QQQS;
            Enum10 enum3 = A_2.QQQS;
            if (qQQS == Enum10.const_9)
            {
                if (enum3 == Enum10.const_9)
                {
                    return string.Compare(A_1.Name, A_2.Name);
                }
                return -1;
            }
            if (enum3 == Enum10.const_9)
            {
                return 1;
            }
            if (qQQS == Enum10.const_11)
            {
                if (enum3 == Enum10.const_11)
                {
                    return string.Compare(A_1.Name, A_2.Name);
                }
                return -1;
            }
            if (enum3 == Enum10.const_11)
            {
                return 1;
            }
            if (qQQS == Enum10.const_5)
            {
                if (enum3 == Enum10.const_5)
                {
                    return string.Compare(A_1.Name, A_2.Name);
                }
                return -1;
            }
            if (enum3 == Enum10.const_5)
            {
                return 1;
            }
            if (qQQS == Enum10.const_7)
            {
                if (enum3 == Enum10.const_7)
                {
                    return string.Compare(A_1.Name, A_2.Name);
                }
                return -1;
            }
            if (enum3 == Enum10.const_7)
            {
                return 1;
            }
            return string.Compare(A_1.Name, A_2.Name);
        }

        private void method_1(int A_1, int A_2)
        {
        while (true)
    {
        int num;
        int num2;
        Class369 class2;
        while (true)
        {
            num = A_1;
            num2 = A_2;
            class2 = this.arrayList_0[(A_1 + A_2) >> 1] as Class369;
            break;
        }
        while (true)
        {
            if (this.method_0(this.arrayList_0[num] as Class369, class2) < 0)
            {
                num++;
                continue;
            }
            while (true)
            {
                if (this.method_0(this.arrayList_0[num2] as Class369, class2) > 0)
                {
                    num2--;
                    continue;
                }
                if (num <= num2)
                {
                    this.arrayList_0[num] = this.arrayList_0[num2];
                    this.arrayList_0[num2] = this.arrayList_0[num];
                    num++;
                    num2--;
                }
                if (num > num2)
                {
                    if (A_1 < num2)
                    {
                        this.method_1(A_1, num2);
                    }
                    A_1 = num;
                    if (num >= A_2)
                    {
                        return;
                    }
                }
                else
                {
                    continue;
                }
                break;
            }
            break;
        }
    }

        }

        internal void method_2(ArrayList A_1)
        {
            if (A_1.Count > 1)
            {
                this.arrayList_0 = A_1;
                this.method_1(0, A_1.Count - 1);
            }
        }

        internal void method_3(ArrayList A_1, int A_2)
        {
            int count = A_1.Count;
            if ((count > 1) && (A_2 < count))
            {
                this.arrayList_0 = A_1;
                this.method_1(A_2, A_1.Count - 1);
            }
        }
    }
}

