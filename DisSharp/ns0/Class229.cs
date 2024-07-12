namespace ns0
{
    using System;

    internal abstract class Class229 : Class228
    {
        protected Class229()
        {
        }

        private void method_920(Class381 A_1, Class547.Class528 A_2)
        {
            base.method_7();
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 == 0))
            {
                base.method_909(A_2);
            }
            Class631.smethod_0(base.method_1(), A_2);
            base.method_9(Class613.class339_36);
            base.method_91(A_1.enum0_0, A_1.int_1);
            base.method_9(Class584.class342_0);
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 > 0))
            {
                base.method_917(A_2.byte_0, A_1.class369_0 as Class370);
            }
            base.method_9(new Class361(A_1));
        }

        internal override void QRWW(Class381 node, Enum2 codetype, bool single)
        {
            if (!single)
            {
                base.method_46(node);
            }
            if (!single && (node.short_0 > 0))
            {
                base.method_905(node);
            }
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_920(node, class2);
            if (class2.Boolean_12)
            {
                base.method_9(Class518.class337_19);
                Class519.smethod_2(class2);
            }
            else if (!node.bool_0 && !node.bool_1)
            {
                base.method_9(Class518.class337_19);
                Class519.smethod_2(class2);
            }
            else
            {
                base.method_10(Class518.class337_3);
                base.int_0++;
                if (node.bool_0)
                {
                    base.method_10(Class613.class339_4);
                    base.method_891(class2, codetype);
                }
                if (node.bool_1)
                {
                    base.method_10(Class613.class339_102);
                    base.method_891((node.class619_0[1] as Class391).class528_0, codetype);
                }
                base.int_0--;
                base.method_10(Class518.class337_5);
            }
            Class631.smethod_1();
        }

        internal override void QRWX(Class381 node)
        {
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_920(node, class2);
            base.method_9(Class518.class337_19);
            Class519.smethod_2(class2);
            Class631.smethod_1();
        }
    }
}

