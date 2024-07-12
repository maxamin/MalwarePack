namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class297 : Class296
    {
        protected Class297()
        {
        }

        internal void method_913(Class548.Class529 A_1)
        {
            Class519.class529_1 = A_1;
            this.QRVS();
            ArrayList list = Class546.class559_0.arrayList_0;
            int num = A_1.int_3;
            for (int i = 0; i < A_1.short_0; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_15);
                }
                Class559.Class607 class2 = list[num + i] as Class559.Class607;
                base.method_9(new Class351(class2.int_0));
                this.method_914(class2);
            }
            this.QRVT();
        }

        private void method_914(Class559.Class607 A_1)
        {
            int num = A_1.short_0;
            if (A_1.Boolean_0)
            {
                num++;
            }
            if (num != 0)
            {
                base.method_9(Class632.class339_15);
                if (num > 1)
                {
                    base.method_9(Class518.class337_3);
                }
                ArrayList list = Class546.class575_0.arrayList_0;
                int num2 = A_1.int_1;
                bool flag = false;
                for (int i = 0; i < A_1.short_0; i++)
                {
                    if (flag)
                    {
                        base.method_9(Class518.class337_15);
                    }
                    flag = true;
                    Class575.Class647 class2 = list[num2 + i] as Class575.Class647;
                    if (class2.enum0_0 != Enum0.const_27)
                    {
                        base.method_91(class2.enum0_0, class2.int_0);
                    }
                    else
                    {
                        this.QRUZ(class2.int_0);
                    }
                }
                if (A_1.Boolean_0)
                {
                    if (flag)
                    {
                        base.method_9(Class518.class337_15);
                    }
                    base.method_9(Class632.class339_166);
                }
                if (num > 1)
                {
                    base.method_9(Class518.class337_5);
                }
            }
        }

        internal void method_915(Class547.Class528 A_1)
        {
            A_1.class369_0.QQWT();
            A_1.class369_0.QQWU();
            this.QRVS();
            ArrayList list = Class546.class559_0.arrayList_0;
            int num = A_1.int_2;
            for (int i = 0; i < A_1.short_0; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_15);
                }
                Class559.Class607 class2 = list[num + i] as Class559.Class607;
                base.method_9(new Class351(class2.int_0));
                this.method_914(class2);
            }
            this.QRVT();
        }
    }
}

