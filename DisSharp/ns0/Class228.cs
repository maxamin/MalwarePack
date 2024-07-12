namespace ns0
{
    using System;

    internal abstract class Class228 : Class227
    {
        protected Class228()
        {
        }

        private void method_919(byte A_1)
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
                base.method_9(Class518.class337_18);
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
                base.method_907(type);
            }
            else
            {
                base.method_906(type);
            }
            base.method_9(Class613.class339_34);
            base.method_9(new Class357(node));
            this.method_919(node.byte_0);
        }
    }
}

