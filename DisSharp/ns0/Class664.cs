namespace ns0
{
    using System;
    using System.Collections;

    internal class Class664 : Class663
    {
        internal Class619 class619_0 = new Class619();
        internal Class619 class619_1 = new Class619();
        internal Class619 class619_2 = new Class619();
        internal Class619 class619_3 = new Class619();

        internal void method_52()
        {
            Class548.Class529 class2 = null;
            Class548.Class529 class3 = null;
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            ArrayList list2 = base.class684_0.class549_0.arrayList_0;
            int num = list.Count - 1;
            for (int i = 1; i < list.Count; i++)
            {
                int num4;
                if (i == 1)
                {
                    class2 = list[i] as Class548.Class529;
                }
                int num3 = class2.int_7;
                if (i < num)
                {
                    class3 = list[i + 1] as Class548.Class529;
                    num4 = class3.int_7 - num3;
                }
                else
                {
                    num4 = list2.Count - num3;
                }
                if (num4 > 0)
                {
                    Class369 class4 = class2.class369_0;
                    Class619 class5 = class4.class619_0;
                    for (int j = 0; j < num4; j++)
                    {
                        Class385 class7;
                        Class549.Class530 class6 = list2[num3 + j] as Class549.Class530;
                        if (class6.Boolean_6)
                        {
                            class7 = new Class386();
                            this.class619_0.method_0(class7);
                        }
                        else if (class6.Boolean_5)
                        {
                            class7 = new Class387();
                            this.class619_1.method_0(class7);
                        }
                        else if (class6.Boolean_4)
                        {
                            class7 = new Class388();
                            this.class619_2.method_0(class7);
                        }
                        else
                        {
                            class7 = new Class385();
                            this.class619_3.method_0(class7);
                        }
                        class7.class530_0 = class6;
                        class7.class369_0 = class4;
                        class6.class369_0 = class7;
                    }
                    if (this.class619_0.Int32_0 > 0)
                    {
                        if (!class4.QQUQ)
                        {
                            this.class619_0.method_7();
                        }
                        class5.method_1(this.class619_0);
                        this.class619_0.method_6();
                    }
                    if (this.class619_1.Int32_0 > 0)
                    {
                        this.class619_1.method_7();
                        class5.method_1(this.class619_1);
                        this.class619_1.method_6();
                    }
                    if (this.class619_3.Int32_0 > 0)
                    {
                        this.class619_3.method_7();
                        class5.method_1(this.class619_3);
                        this.class619_3.method_6();
                    }
                    if (this.class619_2.Int32_0 > 0)
                    {
                        this.class619_2.method_7();
                        class5.method_1(this.class619_2);
                        this.class619_2.method_6();
                    }
                }
                class2.short_4 = (short) num4;
                class2 = class3;
            }
        }
    }
}

