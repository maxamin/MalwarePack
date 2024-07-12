namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1090
    {
        private ArrayList arrayList_0;

        private void method_0(int A_1, int A_2)
        {while (true)
    {
        int num;
        int num2;
        int num3;
        while (true)
        {
            num = A_1;
            num2 = A_2;
            num3 = (this.arrayList_0[(A_1 + A_2) >> 1] as Class867).int_0;
            break;
        }
        while (true)
        {
            if ((this.arrayList_0[num] as Class867).int_0 < num3)
            {
                num++;
                continue;
            }
            while (true)
            {
                if ((this.arrayList_0[num2] as Class867).int_0 > num3)
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
                        this.method_0(A_1, num2);
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

        internal void method_1(ArrayList A_1)
        {
            if (A_1.Count > 1)
            {
                this.arrayList_0 = A_1;
                this.method_0(0, A_1.Count - 1);
            }
        }
    }
}

