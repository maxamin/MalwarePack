namespace ns0
{
    using System;
    using System.Collections;

    internal class Class873 : Class872
    {
        private ArrayList arrayList_0;
        private Class394 class394_0;
        private int int_0;

        internal Class873(Class394 A_1) : base(Enum51.const_2)
        {
            this.class394_0 = A_1;
            this.arrayList_0 = A_1.class684_0.class548_0.arrayList_0;
            this.int_0 = 0;
        }

        internal Class873(Class394 A_1, Enum51 A_2) : base(A_2)
        {
            this.class394_0 = A_1;
            this.arrayList_0 = A_1.class684_0.class548_0.arrayList_0;
            this.int_0 = 0;
        }

        internal override void QQSZ(DateTime expired)
        {
            Class394 class2 = Class519.class394_0;
            try
            {
                Class519.smethod_0(this.class394_0);
                bool flag = true;
            Label_0013:
                this.int_0++;
                if (this.int_0 >= this.arrayList_0.Count)
                {
                    goto Label_0076;
                }
                goto Label_0054;
            Label_0036:
                flag = false;
            Label_0038:
                if (this.int_0 >= (this.arrayList_0.Count - 1))
                {
                    flag = false;
                }
                if (flag)
                {
                    goto Label_0013;
                }
                return;
            Label_0054:
                try
                {
                    Class548.Class529 class3 = this.arrayList_0[this.int_0] as Class548.Class529;
                    Class520.smethod_3(class3);
                }
                catch
                {
                }
            Label_0076:
                if (expired >= DateTime.Now)
                {
                    goto Label_0038;
                }
                goto Label_0036;
            }
            finally
            {
                Class519.smethod_0(class2);
            }
        }

        internal override bool QQWQ
        {
            get
            {
                return (this.int_0 >= (this.arrayList_0.Count - 1));
            }
        }
    }
}

