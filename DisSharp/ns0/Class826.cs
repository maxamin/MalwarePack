namespace ns0
{
    using System;

    internal class Class826 : Class822
    {
        private static Class436 class436_0 = new Class436();
        internal Class822 class822_0;
        internal int int_1;

        internal Class826(int A_1, Enum45 A_2, int A_3)
        {
            base.int_0 = A_1;
            base.enum45_0 = A_2;
            this.int_1 = A_3;
        }

        internal override void QQUX(Class397 lines)
        {
            lines.method_10(Class584.class340_0);
            lines.method_10(Class585.smethod_1(this.class822_0.short_1));
        }

        internal override void QQVZ(Class398 statement)
        {
            try
            {
                Class398 target = Class536.hashtable_1[this.class822_0] as Class398;
                statement.QQST(target);
                target.method_0(statement);
            }
            catch
            {
                statement.QQST(class436_0);
            }
        }
    }
}

