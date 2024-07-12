namespace ns0
{
    using System;

    internal abstract class Class258 : Class257
    {
        protected Class258()
        {
        }

        internal override void QRXR(Class370 node, Class548.Class529 type)
        {
            Class519.class529_1 = type;
            if (type.short_3 > 0)
            {
                base.method_903(type);
            }
            base.method_7();
            if (node is Class376)
            {
                base.method_912(type);
            }
            else
            {
                base.method_911(type);
            }
            base.method_9(new Class357(node));
            base.method_9(Class518.class337_30);
            base.method_9(Class538.class339_147);
            if (type.short_2 > 0)
            {
                base.method_918(type, Enum35.const_1);
                base.method_9(Class518.class337_12);
            }
        }
    }
}

