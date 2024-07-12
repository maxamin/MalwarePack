namespace ns0
{
    using System;
    using System.Collections;

    internal class Class844
    {
        private ArrayList arrayList_0 = new ArrayList();
        private Class369 class369_0;
        private Class842 class842_0;

        internal Class844(Class842 A_1, Class369 A_2)
        {
            this.class842_0 = A_1;
            this.class369_0 = A_2;
        }

        internal void method_0(Class646 A_1)
        {
            this.arrayList_0.Add(A_1);
        }

        internal void method_1(Class646 A_1)
        {
            this.arrayList_0.Remove(A_1);
        }

        internal ArrayList ArrayList_0
        {
            get
            {
                return this.arrayList_0;
            }
        }
    }
}

