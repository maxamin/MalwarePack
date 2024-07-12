namespace ns0
{
    using System;

    internal abstract class Class286 : Class285
    {
        protected Class286()
        {
        }

        private void method_931(Class384 A_1, bool A_2)
        {
            Class547.Class528 class2 = (A_1.class619_0[0] as Class391).class528_0;
            Class547.Class528 class3 = null;
            if (A_1.enum34_0 == Enum34.const_2)
            {
                class3 = (A_1.class619_0[1] as Class391).class528_0;
            }
            if (!A_2)
            {
                base.method_46(A_1);
            }
            if (!A_2 && (A_1.short_0 > 0))
            {
                base.method_907(A_1);
            }
            base.method_7();
            if (!(A_1.class369_0 is Class375) && (class2.byte_0 == 0))
            {
                base.method_923(class2);
            }
            base.method_9(Class634.class339_198);
            base.method_9(new Class360(A_1));
            base.method_9(Class518.class337_17);
            base.method_93(A_1.enum11_0, A_1.int_1, A_1.byte_0);
            base.method_925(class2);
            if (class2.Boolean_12)
            {
                base.method_913(A_1.enum34_0);
            }
            else if (A_1.enum34_0 == Enum34.const_2)
            {
                base.method_9(Class634.class339_207);
                base.method_9(new Class359(class2.class369_0));
                base.method_9(Class634.class339_274);
                base.method_9(new Class359(class3.class369_0));
            }
            else if (A_1.enum34_0 == Enum34.const_0)
            {
                base.method_9(Class634.class339_207);
                base.method_9(new Class359(class2.class369_0));
            }
            else
            {
                base.method_9(Class634.class339_274);
                base.method_9(new Class359(class2.class369_0));
            }
            base.method_9(Class518.class337_19);
            if (!(A_1.class369_0 is Class375) && (class2.byte_0 > 0))
            {
                base.method_9(Class634.class339_129);
                base.method_920(class2.byte_0, A_1.class369_0 as Class370);
                base.method_9(Class518.class337_19);
            }
            if (!A_2)
            {
                base.method_921(class2.class369_0, class2);
                if (class3 != null)
                {
                    base.method_921(class3.class369_0, class3);
                }
            }
        }

        private void method_932(Class384 A_1, bool A_2)
        {
            Class547.Class528 method = (A_1.class619_0[0] as Class391).class528_0;
            Class547.Class528 class3 = null;
            if (A_1.enum34_0 == Enum34.const_2)
            {
                class3 = (A_1.class619_0[1] as Class391).class528_0;
            }
            this.QRXS(method.class369_0, method, Enum2.const_0, true);
            if (class3 != null)
            {
                base.method_7();
                this.QRXS(class3.class369_0, class3, Enum2.const_0, true);
            }
        }

        internal override void QRXW(Class384 node, Enum2 codetype, bool single)
        {
            if (single)
            {
                this.method_932(node, true);
            }
            else if (base.bool_3)
            {
                this.method_932(node, false);
            }
            else
            {
                this.method_931(node, false);
            }
        }

        internal override void QRXX(Class384 node)
        {
            this.method_931(node, true);
        }
    }
}

