namespace ns0
{
    using System;
    using System.Collections;

    internal class Class677 : Class676
    {
        internal void method_115()
        {
            int num = base.class682_0.method_1(base.class681_0.class917_0.int_4);
            ArrayList list = base.class47_0.class24_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class24.Class887 class2 = list[i] as Class24.Class887;
                if (class2.int_2 == 0)
                {
                    Class579.Class535 class3 = new Class579.Class535();
                    try
                    {
                        string str = base.method_2(class2.int_1);
                        class3.int_0 = base.class581_0.method_0(str);
                        base.class48_0.method_3(num + class2.int_0);
                        int num3 = base.class48_0.method_11();
                        try
                        {
                            class3.byte_0 = base.class48_0.method_19(num3);
                        }
                        catch
                        {
                            class3.byte_0 = new byte[0];
                        }
                        base.class684_0.class579_0.arrayList_0.Add(class3);
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}

