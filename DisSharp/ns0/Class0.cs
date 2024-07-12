namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class0
    {
        internal ArrayList arrayList_0 = new ArrayList();
        internal bool bool_0;
        internal bool bool_1;
        internal bool bool_2;
        internal Class47 class47_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal int int_3;

        internal Class0(Class47 A_1)
        {
            this.class47_0 = A_1;
            this.arrayList_0.Add(new object());
        }

        internal bool method_0()
        {
            return (this.int_0 < 0x10000);
        }

        internal bool method_1()
        {
            return (this.int_0 < 0x8000);
        }

        internal bool method_2()
        {
            return (this.int_0 < 0x4000);
        }

        internal bool method_3()
        {
            return (this.int_0 < 0x2000);
        }

        internal bool method_4()
        {
            return (this.int_0 < 0x1000);
        }

        internal bool method_5()
        {
            return (this.int_0 < 0x800);
        }

        internal int method_6(bool A_1)
        {
            if (!A_1)
            {
                return 4;
            }
            return 2;
        }

        internal void method_7(Class48 A_1)
        {
            A_1.method_3(this.int_1);
            this.QQSW(A_1);
        }

        internal abstract void QQSV();
        internal abstract void QQSW(Class48 data);
        internal virtual int QQSY(int position)
        {
            this.int_1 = position;
            this.bool_0 = this.class47_0.class954_0.method_4();
            this.bool_1 = this.class47_0.class954_0.method_6();
            this.bool_2 = this.class47_0.class954_0.method_5();
            this.QQSV();
            this.int_3 = this.int_2 * this.int_0;
            return (this.int_1 + this.int_3);
        }

        internal abstract Enum0 QQSU { get; }

        internal string String_0
        {
            get
            {
                return this.QQSU.ToString();
            }
        }
    }
}

