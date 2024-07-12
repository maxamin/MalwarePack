namespace ns0
{
    using System;

    internal abstract class Class306 : Class305
    {
        protected Class306()
        {
        }

        internal override void QRXR(Class370 node, Class548.Class529 type)
        {
            Class519.class529_1 = type;
            base.method_46(node);
            if (type.short_3 > 0)
            {
                base.method_898(type);
            }
            base.method_7();
            if (node is Class376)
            {
                base.method_909(type);
            }
            else
            {
                base.method_908(type);
            }
            base.method_9(Class632.class339_133);
            base.method_9(new Class357(node));
            if (type.short_0 > 0)
            {
                base.method_913(type);
            }
            if (type.short_2 > 0)
            {
                base.method_916(type, Enum35.const_1);
            }
        }
    }
}

