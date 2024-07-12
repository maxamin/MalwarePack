namespace ns0
{
    using System;

    internal class Class827 : Class826
    {
        internal bool bool_0;
        private static Class436 class436_1 = new Class436();

        internal Class827(int A_1, Enum45 A_2, int A_3) : base(A_1, A_2, A_3)
        {
        }

        internal override void QQVZ(Class398 statement)
        {
            try
            {
                if (!this.bool_0)
                {
                    Class398 target = Class536.hashtable_1[base.class822_0] as Class398;
                    statement.QQST(target);
                    target.method_0(statement);
                }
            }
            catch
            {
                statement.QQST(class436_1);
            }
        }

        internal override bool QQQX
        {
            get
            {
                return !this.bool_0;
            }
        }
    }
}

