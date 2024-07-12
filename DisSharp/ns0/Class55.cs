namespace ns0
{
    using System;

    internal abstract class Class55 : Class54
    {
        internal bool bool_3;
        internal Enum2 enum2_0;

        protected Class55()
        {
        }

        internal override Class397 QRVW(Class397 lines, Class369 node, Enum2 codetype)
        {
            Class519.smethod_3(node);
            base.method_0(lines);
            node.Create(this, codetype, true);
            return base.method_1();
        }

        internal bool Boolean_0
        {
            get
            {
                switch (this.enum2_0)
                {
                    case Enum2.const_0:
                    case Enum2.const_1:
                    case Enum2.const_6:
                        return true;
                }
                return false;
            }
        }

        internal bool Boolean_1
        {
            get
            {
                switch (this.enum2_0)
                {
                    case Enum2.const_0:
                    case Enum2.const_1:
                    case Enum2.const_6:
                        return false;
                }
                return true;
            }
        }
    }
}

