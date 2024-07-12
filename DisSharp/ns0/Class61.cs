namespace ns0
{
    using System;

    internal abstract class Class61 : Class60
    {
        protected Class61()
        {
        }

        internal void method_45(Class445 A_1)
        {
            Class446 class2 = A_1 as Class446;
            if (class2 != null)
            {
                if ((class2.class445_0 != null) && (class2.class445_0.Length == 2))
                {
                    this.QRVY(class2.class445_0[1]);
                }
                else
                {
                    this.QRVY(A_1);
                }
            }
            else
            {
                this.QRVY(A_1);
            }
        }
    }
}

