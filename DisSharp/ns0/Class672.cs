namespace ns0
{
    using System;
    using System.Collections;

    internal class Class672 : Class671
    {
        private ArrayList arrayList_0;
        private ArrayList arrayList_1;
        private ArrayList arrayList_2;
        private Hashtable hashtable_0;
        private short[] short_0;

        internal void method_77()
        {
            this.hashtable_0 = new Hashtable();
            this.short_0 = new short[base.class684_0.class548_0.arrayList_0.Count];
            this.method_78();
            this.method_79();
            this.method_80();
            this.method_81();
            this.method_82();
            this.method_83();
        }

        private void method_78()
        {
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class548.Class529 class2 = list[i] as Class548.Class529;
                int num2 = class2.int_1;
                string str = base.class581_0[num2];
                int index = str.IndexOf('`');
                if (index != -1)
                {
                    string s = str.Substring(index + 1);
                    try
                    {
                        this.short_0[i] = short.Parse(s);
                    }
                    catch
                    {
                        this.short_0[i] = 0;
                    }
                    base.class581_0[num2] = str.Substring(0, index);
                }
            }
        }

        private void method_79()
        {
            ArrayList list = base.class684_0.class553_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class553.Class531 class2 = list[i] as Class553.Class531;
                int num2 = class2.int_1;
                string str = base.class581_0[num2];
                int index = str.IndexOf('`');
                if (index != -1)
                {
                    string s = str.Substring(index + 1);
                    try
                    {
                        class2.short_0 = short.Parse(s);
                    }
                    catch
                    {
                        class2.short_0 = 0;
                    }
                    base.class581_0[num2] = str.Substring(0, index);
                }
            }
        }

        private void method_80()
        {
            ArrayList list = base.class47_0.class27_0.arrayList_0;
            ArrayList list2 = base.class684_0.class548_0.arrayList_0;
            ArrayList list3 = base.class684_0.class547_0.arrayList_0;
            ArrayList list4 = base.class684_0.class559_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class27.Class909 class2 = list[i] as Class27.Class909;
                if (class2.int_0 != 0)
                {
                    Class559.Class607 class3 = new Class559.Class607 {
                        int_0 = base.method_4(class2.int_1)
                    };
                    if ((class2.ushort_1 & 0x10) != 0)
                    {
                        class3.byte_1 = (byte) (class3.byte_1 | 1);
                    }
                    Enum0 enum2 = class2.enum0_0;
                    if (enum2 != Enum0.const_2)
                    {
                        if (enum2 != Enum0.const_6)
                        {
                            continue;
                        }
                        Class547.Class528 class5 = list3[class2.int_0] as Class547.Class528;
                        if (class5.short_0 == 0)
                        {
                            class5.int_2 = list4.Count;
                        }
                        class5.short_0 = (short) (class5.short_0 + 1);
                    }
                    else
                    {
                        Class548.Class529 class4 = list2[class2.int_0] as Class548.Class529;
                        if (class4.short_0 == 0)
                        {
                            class4.int_3 = list4.Count;
                        }
                        class4.short_0 = (short) (class4.short_0 + 1);
                    }
                    list4.Add(class3);
                    this.hashtable_0.Add(i, class3);
                }
            }
        }

        private void method_81()
        {
            ArrayList list = base.class47_0.class28_0.arrayList_0;
            ArrayList list2 = base.class684_0.class575_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class28.Class910 class2 = list[i] as Class28.Class910;
                Class559.Class607 class3 = this.hashtable_0[class2.int_0] as Class559.Class607;
                if (class3 != null)
                {
                    if (class3.short_0 == 0)
                    {
                        class3.int_1 = list2.Count;
                    }
                    class3.short_0 = (short) (class3.short_0 + 1);
                    Class575.Class647 class4 = new Class575.Class647 {
                        enum0_0 = class2.enum0_0,
                        int_0 = class2.int_1
                    };
                    list2.Add(class4);
                }
            }
        }

        private void method_82()
        {
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class548.Class529 class2 = list[i] as Class548.Class529;
                int num2 = class2.short_0 - this.short_0[i];
                if (num2 > 0)
                {
                    class2.short_0 = this.short_0[i];
                    class2.short_1 = (short) num2;
                    class2.int_3 += num2;
                }
            }
        }

        private void method_83()
        {
            ArrayList list = base.class684_0.class551_0.arrayList_0;
            ArrayList list2 = base.class684_0.class556_0.arrayList_0;
            ArrayList list3 = base.class684_0.class557_0.arrayList_0;
            ArrayList list4 = base.class684_0.class548_0.arrayList_0;
            this.arrayList_0 = base.class684_0.class547_0.arrayList_0;
            this.arrayList_1 = base.class684_0.class568_0.arrayList_0;
            this.arrayList_2 = base.class684_0.class569_0.arrayList_0;
            Class48 class2 = new Class48();
            Class608 class3 = new Class608(class2);
            for (int i = 1; i < list.Count; i++)
            {
                Class551.Class544 class4 = list[i] as Class551.Class544;
                if (class4.enum9_0 == Enum9.const_4)
                {
                    Class556.Class601 class5 = list2[class4.int_0] as Class556.Class601;
                    if (!class5.Boolean_2)
                    {
                        Class557.Class605 class6 = list3[class5.int_1] as Class557.Class605;
                        class2.Byte_0 = class6.byte_0;
                        if (class2.method_8() == 0x15)
                        {
                            class3.method_0();
                            if (class3.enum11_0 == Enum11.const_36)
                            {
                                Class548.Class529 class7 = list4[class3.int_0] as Class548.Class529;
                                int num3 = class7.int_8;
                                for (int j = 0; j < class7.short_5; j++)
                                {
                                    if (this.method_84(class5, num3 + j))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool method_84(Class556.Class601 A_1, int A_2)
        {
            Class547.Class528 class2 = this.arrayList_0[A_2] as Class547.Class528;
            if (base.class581_0[class2.int_1] != base.class581_0[A_1.int_3])
            {
                return false;
            }
            if (class2.short_2 != A_1.short_0)
            {
                return false;
            }
            int num = class2.int_6;
            int num2 = A_1.int_5;
            for (int i = 0; i < class2.short_2; i++)
            {
                Class568.Class623 class3 = this.arrayList_1[num + i] as Class568.Class623;
                Class569.Class624 class4 = this.arrayList_2[num2 + i] as Class569.Class624;
                if (((class3.enum11_0 != class4.enum11_0) || (class3.int_1 != class4.int_0)) || (class3.byte_4 != class4.byte_2))
                {
                    return false;
                }
            }
            A_1.int_2 = A_2;
            return true;
        }
    }
}

