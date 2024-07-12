namespace ns0
{
    using System;

    internal abstract class Class214 : Class213
    {
        protected Class214()
        {
        }

        internal override void QRXY(Class370 node, Class548.Class529 type)
        {
            Class519.class529_1 = type;
            base.method_46(node);
            if (type.short_3 > 0)
            {
                base.method_898(type);
            }
            base.method_7();
            if (node is Class378)
            {
                base.method_907(type);
            }
            else
            {
                base.method_906(type);
            }
            base.method_9(Class613.class339_118);
            base.method_9(new Class357(node));
            if (type.short_0 > 0)
            {
                base.method_911(type);
            }
            if (type.short_2 > 0)
            {
                base.method_915(type, Enum35.const_1);
            }
            if (type.short_0 > 0)
            {
                base.method_912(type);
            }
        }
    }
}

