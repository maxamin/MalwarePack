namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class57 : Class56
    {
        private ArrayList arrayList_8 = new ArrayList();
        private Class583 class583_0;
        private int int_1;
        private int int_2;

        protected Class57()
        {
        }

        internal void method_32()
        {
            this.arrayList_8.Clear();
            this.int_1 = 0;
            this.int_2 = 0;
        }

        internal void method_33(Enum10 A_1, int A_2, int A_3, bool A_4)
        {
            if (this.int_1 == this.int_2)
            {
                this.class583_0 = new Class583();
                this.arrayList_8.Add(this.class583_0);
                this.int_2++;
                this.int_1++;
            }
            else
            {
                this.int_1++;
                this.class583_0 = this.arrayList_8[this.int_1 - 1] as Class583;
            }
            this.class583_0.enum10_0 = A_1;
            this.class583_0.int_0 = A_2;
            this.class583_0.int_1 = A_3;
            this.class583_0.bool_0 = A_4;
        }

        internal void method_34()
        {
            this.int_1--;
            if (this.int_1 > 0)
            {
                this.class583_0 = this.arrayList_8[this.int_1 - 1] as Class583;
            }
        }

        internal bool Boolean_2
        {
            get
            {
                return this.class583_0.bool_0;
            }
        }

        internal Enum10 Enum10_0
        {
            get
            {
                return this.class583_0.enum10_0;
            }
        }

        internal int Int32_0
        {
            get
            {
                return this.class583_0.int_0;
            }
        }

        internal int Int32_1
        {
            get
            {
                return this.class583_0.int_1;
            }
        }

        private class Class583
        {
            internal bool bool_0;
            internal Enum10 enum10_0;
            internal int int_0;
            internal int int_1;
        }
    }
}

