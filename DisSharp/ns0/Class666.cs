namespace ns0
{
    using System;
    using System.Collections;

    internal class Class666 : Class665
    {
        private Class619 class619_8 = new Class619();
        internal Enum59[] enum59_0;

        internal void method_55()
        {
            Class25.Class903 class2 = null;
            Class25.Class903 class3 = null;
            Class547.Class528 class5 = null;
            Class391 class7 = null;
            ArrayList list = base.class47_0.class25_0.arrayList_0;
            ArrayList list2 = base.class47_0.class19_0.arrayList_0;
            ArrayList list3 = base.class47_0.class7_0.arrayList_0;
            if (list.Count > 1)
            {
                int num = list.Count - 1;
                int num2 = list3.Count - 1;
                int num3 = 1;
                Class7.Class695 class8 = list3[1] as Class7.Class695;
                for (int i = 1; i < list.Count; i++)
                {
                    int num6;
                    bool flag;
                    if (i == 1)
                    {
                        class2 = list[i] as Class25.Class903;
                    }
                    int num5 = class2.int_1;
                    if (i < num)
                    {
                        class3 = list[i + 1] as Class25.Class903;
                        num6 = class3.int_1 - num5;
                        flag = true;
                    }
                    else
                    {
                        num6 = list2.Count - num5;
                        flag = false;
                    }
                    if (flag)
                    {
                        int num7 = class3.int_1;
                        if (((class3.int_0 == 0) || (num7 < 0)) || (num7 > list2.Count))
                        {
                            continue;
                        }
                    }
                    Class369 class9 = (base.class684_0.class548_0.arrayList_0[class2.int_0] as Class548.Class529).class369_0;
                    for (int j = 0; j < num6; j++)
                    {
                        Class391 class6;
                        Class19.Class882 class10 = list2[num5 + j] as Class19.Class882;
                        Class381 class11 = new Class381 {
                            class369_0 = class9,
                            enum0_0 = class10.enum0_0,
                            int_1 = class10.int_1
                        };
                        base.struct4_1[num5 + j].class369_0 = class11;
                        string str = base.method_2(class10.int_0);
                        class11.int_0 = base.method_5(ref str);
                        while (class8.enum0_0 == Enum0.const_23)
                        {
                            num3++;
                            class8 = list3[num3] as Class7.Class695;
                        }
                        Enum36 enum2 = base.method_0(class8.ushort_0);
                        int index = class8.int_0;
                        Class547.Class528 class4 = base.class684_0.class547_0.arrayList_0[index] as Class547.Class528;
                        base.bool_0[index] = true;
                        num3++;
                        class8 = list3[num3] as Class7.Class695;
                        base.method_0(class8.ushort_0);
                        int num10 = class8.int_0;
                        class5 = base.class684_0.class547_0.arrayList_0[num10] as Class547.Class528;
                        base.bool_0[num10] = true;
                        if (num3 < num2)
                        {
                            num3++;
                            class8 = list3[num3] as Class7.Class695;
                        }
                        if (enum2 == Enum36.const_2)
                        {
                            class6 = base.method_1(class4, class11);
                            this.enum59_0[index] = Enum59.const_1;
                            class4.enum25_0 = Enum25.const_1;
                            class7 = base.method_1(class5, class11);
                            this.enum59_0[num10] = Enum59.const_2;
                            class5.enum25_0 = Enum25.const_2;
                        }
                        else
                        {
                            class6 = base.method_1(class5, class11);
                            this.enum59_0[num10] = Enum59.const_1;
                            class5.enum25_0 = Enum25.const_1;
                            class7 = base.method_1(class4, class11);
                            this.enum59_0[index] = Enum59.const_2;
                            class4.enum25_0 = Enum25.const_2;
                        }
                        class11.class619_0.method_0(class6);
                        class11.class619_0.method_0(class7);
                        this.class619_8.method_0(class11);
                        int num11 = class9.class619_0.method_5(str);
                        if (num11 != -1)
                        {
                            Class385 class12 = class9.class619_0[num11] as Class385;
                            if (class12 != null)
                            {
                                class9.class619_0[num11] = new Class389(class12);
                            }
                        }
                    }
                    this.class619_8.method_7();
                    class9.class619_0.method_1(this.class619_8);
                    this.class619_8.method_6();
                    class2 = class3;
                }
            }
        }
    }
}

