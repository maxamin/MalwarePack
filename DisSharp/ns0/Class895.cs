namespace ns0
{
    using System;
    using System.Collections;

    internal class Class895
    {
        internal ArrayList arrayList_0 = new ArrayList();
        internal int int_0;
        internal int int_1;

        internal Class895(int A_1, int A_2)
        {
            this.int_0 = A_1;
            this.int_1 = A_2;
        }

        internal void method_0(Class48 A_1)
        {
            A_1.method_3(this.int_0);
            for (int i = 0; i < (this.int_1 / 0x10); i++)
            {
                this.arrayList_0.Add(new Guid(A_1.method_19(0x10)));
            }
        }

        internal Guid method_1(int A_1)
        {
            return (Guid) this.arrayList_0[A_1 - 1];
        }
    }
}

