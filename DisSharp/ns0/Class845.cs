namespace ns0
{
    using Crownwood.DotNetMagic.Controls;
    using System;
    using System.Collections;

    internal class Class845 : TabPage
    {
        private ArrayList arrayList_0 = new ArrayList();
        private Class369 class369_0;
        private Enum54 enum54_0;

        internal Class845(Class369 A_1, Enum54 A_2)
        {
            this.class369_0 = A_1;
            this.enum54_0 = A_2;
        }

        internal void method_0(Class646 A_1)
        {
            this.arrayList_0.Add(A_1);
        }

        internal void method_1()
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class646 class2 = this.arrayList_0[i] as Class646;
                class2.class844_0.method_1(class2);
            }
            this.arrayList_0.Clear();
        }

        internal Enum54 Enum54_0
        {
            get
            {
                return this.enum54_0;
            }
        }
    }
}

