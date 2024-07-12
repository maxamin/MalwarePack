namespace ns0
{
    using System;

    internal abstract class Class301 : Class300
    {
        protected Class301()
        {
        }

        private void method_920(byte A_1)
        {
            Class335 class2 = null;
            if ((A_1 & 0xfe) != 0)
            {
                if ((A_1 & 2) != 0)
                {
                    class2 = this.QRSW();
                }
                else if ((A_1 & 4) != 0)
                {
                    class2 = this.QRSV();
                }
                else if ((A_1 & 8) != 0)
                {
                    class2 = this.QRSX();
                }
                else if ((A_1 & 0x10) != 0)
                {
                    class2 = this.QRSY();
                }
                else if ((A_1 & 0x20) != 0)
                {
                    class2 = this.QRTQ();
                }
                else if ((A_1 & 0x40) != 0)
                {
                    class2 = this.QRTR();
                }
                else if ((A_1 & 0x80) != 0)
                {
                    class2 = this.QRTS();
                }
            }
            if (class2 != null)
            {
                base.method_9(Class632.class339_15);
                base.method_9(class2);
            }
        }

        internal override void QRWV(Class370 node, Class548.Class529 type)
        {
            base.method_46(node);
            if (type.short_3 > 0)
            {
                base.method_898(type);
            }
            base.method_7();
            if (node is Class374)
            {
                base.method_909(type);
            }
            else
            {
                base.method_908(type);
            }
            base.method_9(Class632.class339_89);
            base.method_9(new Class357(node));
            this.method_920(node.byte_0);
        }
    }
}

