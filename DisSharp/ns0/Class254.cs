namespace ns0
{
    using System;

    internal abstract class Class254 : Class253
    {
        protected Class254()
        {
        }

        private void method_928(Class381 A_1, Class547.Class528 A_2)
        {
            base.method_7();
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 == 0))
            {
                base.method_923(A_2);
            }
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 > 0))
            {
                base.method_920(A_2.byte_0, A_1.class369_0 as Class370);
            }
            base.method_9(new Class361(A_1));
            base.method_9(Class518.class337_17);
            base.method_91(A_1.enum0_0, A_1.int_1);
        }

        internal override void QRWW(Class381 node, Enum2 codetype, bool single)
        {
            if (!single && (node.short_0 > 0))
            {
                base.method_910(node);
            }
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_928(node, class2);
            base.method_9(Class518.class337_19);
        }

        internal override void QRWX(Class381 node)
        {
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_928(node, class2);
            base.method_9(Class518.class337_19);
        }
    }
}

