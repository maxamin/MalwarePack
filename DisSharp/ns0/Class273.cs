namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class273 : Class272
    {
        protected Class273()
        {
        }

        internal void method_914(Class548.Class529 A_1)
        {
            Class519.class529_1 = A_1;
            base.method_9(Class518.class337_39);
            ArrayList list = Class546.class559_0.arrayList_0;
            int num = A_1.int_3;
            for (int i = 0; i < A_1.short_0; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_14);
                }
                Class559.Class607 class2 = list[num + i] as Class559.Class607;
                base.method_9(new Class351(class2.int_0));
            }
            base.method_9(Class518.class337_43);
        }

        internal void method_915(Class548.Class529 A_1)
        {
            base.int_0++;
            ArrayList list = Class546.class575_0.arrayList_0;
            ArrayList list2 = Class546.class559_0.arrayList_0;
            int num = A_1.int_3;
            for (int i = 0; i < A_1.short_0; i++)
            {
                Class559.Class607 class2 = list2[num + i] as Class559.Class607;
                if ((class2.short_0 > 0) || class2.Boolean_0)
                {
                    base.method_10(Class634.class339_267);
                    bool flag = false;
                    int num3 = class2.int_1;
                    for (int j = 0; j < class2.short_0; j++)
                    {
                        if (flag)
                        {
                            base.method_9(Class518.class337_15);
                        }
                        flag = true;
                        base.method_9(new Class351(class2.int_0));
                        base.method_9(Class634.class339_144);
                        Class575.Class647 class3 = list[num3 + j] as Class575.Class647;
                        if (class3.enum0_0 != Enum0.const_27)
                        {
                            base.method_91(class3.enum0_0, class3.int_0);
                        }
                        else
                        {
                            this.QRUZ(class3.int_0);
                        }
                    }
                    if (class2.Boolean_0)
                    {
                        if (flag)
                        {
                            base.method_9(Class518.class337_15);
                        }
                        base.method_9(new Class351(class2.int_0));
                        base.method_9(Class634.class339_120);
                        base.method_9(Class634.class339_59);
                    }
                }
            }
            base.int_0--;
        }

        internal void method_916(Class547.Class528 A_1)
        {
            A_1.class369_0.QQWT();
            A_1.class369_0.QQWU();
            base.method_9(Class518.class337_39);
            ArrayList list = Class546.class559_0.arrayList_0;
            int num = A_1.int_2;
            for (int i = 0; i < A_1.short_0; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_14);
                }
                Class559.Class607 class2 = list[num + i] as Class559.Class607;
                base.method_9(new Class351(class2.int_0));
            }
            base.method_9(Class518.class337_43);
        }

        internal void method_917(Class547.Class528 A_1)
        {
            base.int_0++;
            ArrayList list = Class546.class575_0.arrayList_0;
            ArrayList list2 = Class546.class559_0.arrayList_0;
            int num = A_1.int_2;
            for (int i = 0; i < A_1.short_0; i++)
            {
                Class559.Class607 class2 = list2[num + i] as Class559.Class607;
                if ((class2.short_0 > 0) || class2.Boolean_0)
                {
                    base.method_10(Class634.class339_267);
                    bool flag = false;
                    int num3 = class2.int_1;
                    for (int j = 0; j < class2.short_0; j++)
                    {
                        if (flag)
                        {
                            base.method_9(Class518.class337_15);
                        }
                        flag = true;
                        base.method_9(new Class351(class2.int_0));
                        base.method_9(Class634.class339_144);
                        Class575.Class647 class3 = list[num3 + j] as Class575.Class647;
                        if (class3.enum0_0 != Enum0.const_27)
                        {
                            base.method_91(class3.enum0_0, class3.int_0);
                        }
                        else
                        {
                            this.QRUZ(class3.int_0);
                        }
                    }
                    if (class2.Boolean_0)
                    {
                        if (flag)
                        {
                            base.method_9(Class518.class337_15);
                        }
                        base.method_9(new Class351(class2.int_0));
                        base.method_9(Class634.class339_120);
                        base.method_9(Class634.class339_59);
                    }
                }
            }
            base.int_0--;
        }
    }
}

