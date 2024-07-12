namespace ns0
{
    using System;

    internal abstract class Class225 : Class224
    {
        protected Class225()
        {
        }

        internal void method_915(Class548.Class529 A_1, Enum35 A_2)
        {
            this.method_916(A_1, A_2, false);
        }

        internal void method_916(Class548.Class529 A_1, Enum35 A_2, bool A_3)
        {
            if ((A_2 == Enum35.const_1) || !A_3)
            {
                base.method_9(Class518.class337_18);
            }
            int num = A_1.short_2;
            int num2 = A_1.int_5;
            bool flag = false;
            for (int i = 0; i < num; i++)
            {
                Class576.Class648 class2 = Class546.class576_0.arrayList_0[num2 + i] as Class576.Class648;
                if (!class2.Boolean_0)
                {
                    if (flag)
                    {
                        base.method_9(Class518.class337_15);
                    }
                    else if ((A_2 == Enum35.const_0) && A_3)
                    {
                        base.method_9(Class518.class337_15);
                    }
                    flag = true;
                    if (class2.enum0_0 == Enum0.const_2)
                    {
                        base.method_48(Class546.class548_0.arrayList_0[class2.int_0] as Class548.Class529);
                    }
                    if (class2.enum0_0 == Enum0.const_1)
                    {
                        base.method_53(Class546.class553_0.arrayList_0[class2.int_0] as Class553.Class531);
                    }
                    if (class2.short_0 > 0)
                    {
                        int num4 = class2.int_1;
                        base.method_9(Class518.class337_39);
                        for (int j = 0; j < class2.short_0; j++)
                        {
                            Class577.Class649 class3 = Class546.class577_0.arrayList_0[num4 + j] as Class577.Class649;
                            if (j > 0)
                            {
                                base.method_9(Class518.class337_14);
                            }
                            base.method_93(class3.enum11_0, class3.int_0, class3.byte_0);
                        }
                        base.method_9(Class518.class337_43);
                    }
                }
            }
        }

        internal void method_917(byte A_1, Class370 A_2)
        {
            Class548.Class529 class2 = A_2.class529_0;
            Class576.Class648 class3 = Class546.class576_0.arrayList_0[(class2.int_5 + A_1) - 1] as Class576.Class648;
            switch (class3.enum0_0)
            {
                case Enum0.const_1:
                    base.method_54(class3.int_0);
                    break;

                case Enum0.const_2:
                    base.method_50(class3.int_0);
                    break;

                default:
                    return;
            }
            base.method_9(Class518.class337_13);
        }
    }
}

