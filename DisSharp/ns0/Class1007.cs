namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1007
    {
        private ArrayList arrayList_0;

private void method_0(int A_1, int A_2)
{
	int num;
	do
	{
		num = A_1;
		int num2 = A_2;
		string name = (this.arrayList_0[A_1 + A_2 >> 1] as Class369).Name;
		while (true)
		{
			if (string.Compare((this.arrayList_0[num] as Class369).Name, name) >= 0)
			{
				while (string.Compare((this.arrayList_0[num2] as Class369).Name, name) > 0)
				{
					num2--;
				}
				if (num <= num2)
				{
					object value = this.arrayList_0[num];
					this.arrayList_0[num] = this.arrayList_0[num2];
					this.arrayList_0[num2] = value;
					num++;
					num2--;
				}
				if (num > num2)
				{
					break;
				}
			}
			else
			{
				num++;
			}
		}
		if (A_1 < num2)
		{
			this.method_0(A_1, num2);
		}
		A_1 = num;
	}
	while (num < A_2);
}

        internal void method_1(ArrayList A_1)
        {
            if (A_1.Count > 1)
            {
                this.arrayList_0 = A_1;
                this.method_0(0, A_1.Count - 1);
            }
        }

        internal void method_2(ArrayList A_1, int A_2)
        {
            int count = A_1.Count;
            if ((count > 1) && (A_2 < count))
            {
                this.arrayList_0 = A_1;
                this.method_0(A_2, A_1.Count - 1);
            }
        }
    }
}

