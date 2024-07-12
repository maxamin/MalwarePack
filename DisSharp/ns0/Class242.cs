namespace ns0
{
    using System;

    internal abstract class Class242 : Class241
    {
        protected Class242()
        {
        }

        internal void method_894(Class547.Class528 A_1, Enum2 A_2)
        {
            Class639.smethod_0();
            int num = base.int_0;
            base.int_0++;
            try
            {
                if (!A_1.Boolean_20)
                {
                    base.method_13(A_1, A_2);
                }
            }
            finally
            {
                base.int_0 = num;
                Class639.smethod_2(base.method_1());
                base.method_10(Class538.class339_116);
                base.method_9(Class518.class337_19);
            }
        }
    }
}

