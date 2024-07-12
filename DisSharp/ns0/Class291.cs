namespace ns0
{
    using System;

    internal abstract class Class291 : Class290
    {
        protected Class291()
        {
        }

        internal void method_891(Class547.Class528 A_1, Enum2 A_2)
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
            }
        }
    }
}

