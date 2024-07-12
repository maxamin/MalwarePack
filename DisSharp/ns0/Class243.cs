namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class243 : Class242
    {
        private static ArrayList arrayList_10 = new ArrayList();
        private static bool[] bool_9 = new bool[0];
        private int int_17;

        protected Class243()
        {
        }

        private void method_895()
        {
            this.int_17 = 0;
            this.method_896(Class536.arrayList_0);
            if (this.int_17 > 0)
            {
                base.method_10(Class538.class339_153);
                base.int_0++;
                for (int i = 0; i < this.int_17; i++)
                {
                    if (i > 0)
                    {
                        base.method_9(Class518.class337_15);
                    }
                    else
                    {
                        base.method_7();
                    }
                    base.method_9(Class584.class340_0);
                    base.method_9(Class585.smethod_1(i + 1));
                }
                base.method_9(Class518.class337_19);
                base.int_0--;
            }
            ArrayList list = Class525.ArrayList_0;
            if (list.Count > 0)
            {
                base.int_0++;
                bool flag = true;
                for (int j = 0; j < list.Count; j++)
                {
                    Class640 class2 = list[j] as Class640;
                    if (this.method_897(class2))
                    {
                        bool flag2 = false;
                        for (int k = 0; k < class2.class641_0.short_1; k++)
                        {
                            short index = class2.class641_0[k];
                            if (!Class525.bool_1[index])
                            {
                                if (flag)
                                {
                                    base.int_0--;
                                    base.method_10(Class538.class339_213);
                                    base.int_0++;
                                    flag = false;
                                }
                                if (flag2)
                                {
                                    base.method_9(Class518.class337_15);
                                }
                                else
                                {
                                    base.method_7();
                                }
                                flag2 = true;
                                base.method_9(new Class354(Class525.int_0 + index));
                            }
                        }
                        base.method_9(Class518.class337_17);
                        base.method_93(class2.enum11_0, class2.int_0, class2.byte_0);
                        base.method_9(Class518.class337_19);
                    }
                }
                base.int_0--;
            }
        }

        private void method_896(ArrayList A_1)
        {
            if (A_1 != null)
            {
                for (int i = 0; i < A_1.Count; i++)
                {
                    Class398 class2 = A_1[i] as Class398;
                    if (class2.ushort_0 > this.int_17)
                    {
                        this.int_17 = class2.ushort_0;
                    }
                    ArrayList qQSQ = class2.QQSQ;
                    if (qQSQ != null)
                    {
                        this.method_896(qQSQ);
                    }
                }
            }
        }

        private bool method_897(Class640 A_1)
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
            this.QRWS();
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
            if (num2 <= 0)
            {
                Class525.bool_1 = bool_9;
            }
            else
            {
                bool[] flagArray = new bool[num2];
                for (int j = 0; j < num2; j++)
                {
                    if (data.method_8() == 1)
                    {
                        flagArray[j] = true;
                    }
                }
                Class525.bool_1 = flagArray;
            }
            num2 = data.method_9();
            if (num2 <= 0)
            {
                Class525.ArrayList_0 = arrayList_10;
            }
            else
            {
                ArrayList list2 = new ArrayList();
                for (int k = 0; k < num2; k++)
                {
                    Class640 class3 = null;
                    Class641 class4 = new Class641(4);
                    bool flag = true;
                    short num6 = data.method_9();
                    for (int m = 0; m < num6; m++)
                    {
                        short num8 = data.method_9();
                        class4.method_1(num8);
                        if (flag)
                        {
                            Class574.Class636 class5 = list[Class525.int_0 + num8] as Class574.Class636;
                            class3 = new Class640(class5.enum11_0, class5.int_1, class5.byte_0);
                            flag = false;
                        }
                    }
                    class3.class641_0 = class4;
                    list2.Add(class3);
                }
                Class525.ArrayList_0 = list2;
            }
        }

        internal override void QRWS()
        {
            base.int_0--;
            this.method_895();
            base.method_10(Class538.class339_92);
            base.int_0++;
        }
    }
}

