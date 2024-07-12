namespace ns0
{
    using System;

    internal abstract class Class287 : Class286
    {
        protected Class287()
        {
        }

        internal override void QRXY(Class370 node, Class548.Class529 type)
        {
            Class519.class529_1 = type;
            base.method_46(node);
            if (type.short_3 > 0)
            {
                base.method_902(type);
            }
            base.method_7();
            base.method_9(new Class357(node));
            if (type.short_0 > 0)
            {
                base.method_914(type);
            }
            base.method_9(Class518.class337_30);
            if (node is Class378)
            {
                base.method_911(type);
            }
            else
            {
                base.method_910(type);
            }
            base.method_9(Class634.class339_215);
            if (type.short_2 > 0)
            {
                base.method_918(type, Enum35.const_1);
                base.method_9(Class518.class337_12);
            }
            if (type.short_0 > 0)
            {
                base.method_915(type);
            }
        }
    }
}

