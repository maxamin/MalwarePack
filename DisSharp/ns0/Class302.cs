namespace ns0
{
    using System;

    internal abstract class Class302 : Class301
    {
        protected Class302()
        {
        }

        private void method_921(Class381 A_1, Class547.Class528 A_2)
        {
            base.method_7();
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 == 0))
            {
                base.method_911(A_2);
            }
            base.method_9(Class632.class339_95);
            base.method_9(new Class361(A_1));
            base.method_9(Class632.class339_15);
            base.method_91(A_1.enum0_0, A_1.int_1);
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 > 0))
            {
                base.method_918(A_2.byte_0, A_1.class369_0 as Class370);
            }
        }

        internal override void QRWW(Class381 node, Enum2 codetype, bool single)
        {
            if (!single)
            {
                base.method_46(node);
            }
            if (!single && (node.short_0 > 0))
            {
                base.method_907(node);
            }
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_921(node, class2);
        }

        internal override void QRWX(Class381 node)
        {
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_921(node, class2);
        }
    }
}

