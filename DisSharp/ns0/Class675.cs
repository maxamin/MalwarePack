namespace ns0
{
    using System;
    using System.Collections;

    internal class Class675 : Class674
    {
        internal void method_108()
        {
            ArrayList list = base.class47_0.class34_0.arrayList_0;
            ArrayList list2 = base.class684_0.class549_0.arrayList_0;
            ArrayList list3 = base.class684_0.class561_0.arrayList_0;
            ArrayList list4 = base.class684_0.class548_0.arrayList_0;
            ArrayList list5 = base.class684_0.class550_0.arrayList_0;
            ArrayList list6 = base.class684_0.class570_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class34.Class916 class2 = list[i] as Class34.Class916;
                Class549.Class530 class3 = list2[class2.int_1] as Class549.Class530;
                if (class3.enum11_0 != Enum11.const_36)
                {
                    try
                    {
                        Class561.Class611 class8 = new Class561.Class611 {
                            enum11_0 = class3.enum11_0,
                            int_0 = class3.int_2,
                            byte_0 = null
                        };
                        class3.enum11_0 = Enum11.const_42;
                        class3.int_2 = list3.Count;
                        list3.Add(class8);
                    }
                    catch
                    {
                    }
                }
                else
                {
                    Class548.Class529 class4 = list4[class3.int_2] as Class548.Class529;
                    for (int j = 0; j < class4.short_3; j++)
                    {
                        Class550.Class514 class5 = list5[class4.int_6] as Class550.Class514;
                        if (class5.enum7_0 == Enum7.const_2)
                        {
                            Class570.Class625 class6 = list6[class5.int_0] as Class570.Class625;
                            int num3 = base.class682_0.method_1(class2.int_0);
                            if (num3 != -1)
                            {
                                base.class48_0.method_3(num3);
                                try
                                {
                                    Class561.Class611 class7 = new Class561.Class611 {
                                        enum11_0 = class3.enum11_0,
                                        int_0 = class3.int_2,
                                        byte_0 = base.class48_0.method_19(class6.int_0)
                                    };
                                    class3.enum11_0 = Enum11.const_42;
                                    class3.int_2 = list3.Count;
                                    list3.Add(class7);
                                }
                                catch
                                {
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}

