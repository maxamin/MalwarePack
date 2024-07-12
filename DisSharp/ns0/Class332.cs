namespace ns0
{
    using System;

    internal abstract class Class332 : Class331
    {
        protected Class332()
        {
        }

        private void method_924(Class384 A_1, Class547.Class528 A_2)
        {
            base.method_7();
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 == 0))
            {
                base.method_909(A_2);
            }
            Class631.smethod_0(base.method_1(), A_2);
            base.method_92(A_1.enum11_0, A_1.int_1, A_1.byte_0);
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 > 0))
            {
                base.method_917(A_2.byte_0, A_1.class369_0 as Class370);
            }
            base.method_9(new Class360(A_1));
        }

        internal override void QRXW(Class384 node, Enum2 codetype, bool single)
        {
            if (!single)
            {
                base.method_46(node);
            }
            if (!single && (node.short_0 > 0))
            {
                base.method_903(node);
            }
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_924(node, class2);
            base.method_10(Class518.class337_3);
            int num = base.int_0;
            base.int_0++;
            try
            {
                if (class2.Boolean_12)
                {
                    base.method_910(node.enum34_0);
                    Class519.smethod_2(class2);
                }
                else if (node.enum34_0 == Enum34.const_2)
                {
                    base.method_10(Class613.class339_51);
                    base.method_891(class2, codetype);
                    base.method_10(Class613.class339_107);
                    base.method_891((node.class619_0[1] as Class391).class528_0, codetype);
                }
                else if (node.enum34_0 == Enum34.const_0)
                {
                    base.method_10(Class613.class339_51);
                    base.method_891(class2, codetype);
                }
                else
                {
                    base.method_10(Class613.class339_107);
                    base.method_891(class2, codetype);
                }
            }
            finally
            {
                base.int_0 = num;
                base.method_10(Class518.class337_5);
            }
            Class631.smethod_1();
        }

        internal override void QRXX(Class384 node)
        {
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_924(node, class2);
            base.method_9(Class584.class342_0);
            if (node.enum34_0 == Enum34.const_2)
            {
                base.method_9(Class613.class339_52);
                base.method_9(Class613.class339_107);
            }
            else if (node.enum34_0 == Enum34.const_0)
            {
                base.method_9(Class613.class339_51);
            }
            else
            {
                base.method_9(Class613.class339_107);
            }
            base.method_9(Class518.class337_19);
            Class519.smethod_2(class2);
            Class631.smethod_1();
        }
    }
}

