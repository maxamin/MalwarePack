namespace ns0
{
    using System;

    internal abstract class Class293 : Class292
    {
        private static Class311 class311_0;

        protected Class293()
        {
        }

        private void method_893(Class398 A_1)
        {
            if (class311_0 == null)
            {
                class311_0 = new Class311();
                class311_0.method_7();
            }
            Class399 class2 = A_1 as Class399;
            if (class2 != null)
            {
                Class446 class3 = class2.class445_1 as Class446;
                if ((class3 != null) && (class3.class445_0 != null))
                {
                    class311_0.Class367_0.method_5();
                    class311_0.method_9(Class518.class337_18);
                    if (Class519.class528_0.enum33_0 == Enum33.const_1)
                    {
                        class311_0.method_9(Class613.class339_5);
                    }
                    else
                    {
                        class311_0.method_9(Class613.class339_121);
                    }
                    class311_0.method_9(Class518.class337_10);
                    for (int i = 0; i < class3.class445_0.Length; i++)
                    {
                        if (i > 0)
                        {
                            class311_0.method_9(Class518.class337_15);
                        }
                        class311_0.QRVY(class3.class445_0[i]);
                    }
                    class311_0.method_9(Class518.class337_12);
                    Class519.class367_0.method_1(class311_0.Class367_0);
                }
            }
        }

        internal override void QRWR()
        {
            if ((!Class519.class528_0.Boolean_18 || Class519.class528_0.Boolean_8) || ((Class519.class528_0.enum33_0 != Enum33.const_1) && (Class519.class528_0.enum33_0 == Enum33.const_2)))
            {
            }
            for (int i = 0; i < Class536.arrayList_0.Count; i++)
            {
                Class398 class2 = Class536.arrayList_0[i] as Class398;
                base.method_39(class2);
            }
        }
    }
}

