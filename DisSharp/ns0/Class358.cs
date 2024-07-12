namespace ns0
{
    using System;

    internal class Class358 : Class356
    {
        internal Class358(Class369 A_1)
        {
            base.node = A_1;
        }

        protected override void QQVX(string string_0)
        {
            if (base.node.QQQS != Enum10.const_22)
            {
                base.node.Name = string_0;
                Class643.smethod_1(base.node);
            }
            else
            {
                Class643.smethod_3(base.node, string_0);
            }
        }
    }
}

