namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class219 : Class218
    {
        protected Class219()
        {
        }

        private bool method_892(Class640 A_1)
        {
            for (int i = 0; i < A_1.class641_0.short_1; i++)
            {
                if (!Class525.bool_1[A_1.class641_0[i]])
                {
                    return true;
                }
            }
            return false;
        }

        internal override void QRVZ()
        {
            ArrayList list = Class525.ArrayList_0;
            if (list.Count > 0)
            {
                bool flag = false;
                for (int i = 0; i < list.Count; i++)
                {
                    Class640 class2 = list[i] as Class640;
                    if (this.method_892(class2))
                    {
                        flag = true;
                        base.method_7();
                        base.method_92(class2.enum11_0, class2.int_0, class2.byte_0);
                        bool flag2 = false;
                        for (int j = 0; j < class2.class641_0.short_1; j++)
                        {
                            short index = class2.class641_0[j];
                            if (!Class525.bool_1[index])
                            {
                                if (flag2)
                                {
                                    base.method_9(Class518.class337_15);
                                }
                                flag2 = true;
                                base.method_9(new Class354(Class525.int_0 + index));
                            }
                        }
                        base.method_9(Class518.class337_19);
                    }
                }
                if (flag)
                {
                    base.method_7();
                }
            }
        }

        internal override void QRWQ(Class48 data, Class547.Class528 method)
        {
            Class525.string_0 = new string[method.short_3];
            ArrayList list = Class546.class574_0.arrayList_0;
            Class525.int_0 = method.int_7;
            for (int i = 0; i < method.short_3; i++)
            {
                Class574.Class636 class2 = list[Class525.int_0 + i] as Class574.Class636;
                Class525.string_0[i] = Class519.class581_0[class2.int_0];
            }
            short num2 = data.method_9();
            bool[] flagArray = new bool[num2];
            for (int j = 0; j < num2; j++)
            {
                if (data.method_8() == 1)
                {
                    flagArray[j] = true;
                }
            }
            num2 = data.method_9();
            if (num2 > 0)
            {
                bool flag = false;
                for (int k = 0; k < num2; k++)
                {
                    bool flag2 = false;
                    bool flag3 = true;
                    short num6 = data.method_9();
                    for (int m = 0; m < num6; m++)
                    {
                        int index = data.method_9();
                        if (!flagArray[index])
                        {
                            Class574.Class636 class3 = Class546.class574_0.arrayList_0[Class525.int_0 + index] as Class574.Class636;
                            if (flag3)
                            {
                                flag = true;
                                base.method_7();
                                base.method_92(class3.enum11_0, class3.int_1, class3.byte_0);
                                flag3 = false;
                            }
                            else
                            {
                                base.method_9(Class518.class337_15);
                            }
                            flag2 = true;
                            base.method_9(new Class354(Class525.int_0 + index));
                        }
                    }
                    if (flag2)
                    {
                        base.method_9(Class518.class337_19);
                    }
                }
                if (flag)
                {
                    base.method_7();
                }
            }
        }
    }
}

