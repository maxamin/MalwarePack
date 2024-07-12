namespace ns0
{
    using System;

    internal class Class842
    {
        private Class394 class394_0;
        internal Class843 class843_0 = new Class843();

        internal Class842(Class394 A_1)
        {
            this.class394_0 = A_1;
        }

        internal Class844 method_0(Class369 A_1)
        {
            if (this.class843_0.method_0(A_1))
            {
                return this.class843_0[A_1];
            }
            Class844 class2 = new Class844(this, A_1);
            this.class843_0.method_1(A_1, class2);
            return class2;
        }
    }
}

