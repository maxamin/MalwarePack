namespace ns0
{
    using System;

    internal abstract class Class259 : Class258
    {
        protected Class259()
        {
        }

        internal override void QRXS(Class369 node, Class547.Class528 method, Enum2 codetype, bool single)
        {
            if (!(node.class369_0 is Class371))
            {
                if (single)
                {
                    base.bool_3 = true;
                }
                if (!single && (method.short_1 > 0))
                {
                    base.method_904(method);
                }
                base.method_905(method);
                base.method_922(node, method, single);
                if ((!method.Boolean_12 && !method.Boolean_13) && (base.bool_3 || single))
                {
                    base.method_894(method, codetype);
                }
            }
        }

        internal override void QRXT(Class369 node, Class547.Class528 method)
        {
            if (!(node.class369_0 is Class371))
            {
                base.method_921(node, method);
            }
        }
    }
}

