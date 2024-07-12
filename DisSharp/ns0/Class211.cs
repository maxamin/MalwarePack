namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class211 : Class210
    {
        protected Class211()
        {
        }

        private void method_922(Class369 A_1, Class547.Class528 A_2)
        {
            base.method_7();
            Class519.class367_0 = base.Class367_0;
            if (A_2.Boolean_23)
            {
                base.method_9(Class518.class337_21);
                base.method_9(new Class357(A_1.class369_0));
                base.method_9(Class584.class336_6);
            }
            else
            {
                if (!(A_1.class369_0 is Class375) && (A_2.byte_0 == 0))
                {
                    if (!(A_1 is Class392) || !A_2.Boolean_8)
                    {
                        if (A_2.Boolean_4)
                        {
                            base.method_9(Class613.class339_95);
                        }
                        if (A_2.Boolean_5)
                        {
                            base.method_9(Class613.class339_91);
                        }
                        if (A_2.Boolean_6)
                        {
                            base.method_9(Class613.class339_93);
                        }
                        if (A_2.Boolean_7)
                        {
                            base.method_9(Class613.class339_66);
                        }
                    }
                    if (A_2.Boolean_8)
                    {
                        base.method_9(Class613.class339_114);
                    }
                    if (A_2.Boolean_13)
                    {
                        base.method_9(Class613.class339_40);
                    }
                    if (A_2.Boolean_9 && !A_2.Boolean_13)
                    {
                        base.method_9(Class613.class339_106);
                    }
                    if (A_2.Boolean_12)
                    {
                        base.method_9(Class613.class339_1);
                    }
                    else if (A_2.Boolean_11)
                    {
                        if (A_2.Boolean_10)
                        {
                            base.method_9(Class613.class339_85);
                        }
                        else
                        {
                            base.method_9(Class613.class339_139);
                        }
                    }
                    if (A_2.Boolean_14)
                    {
                        base.method_9(Class613.class339_133);
                    }
                    if (A_2.Boolean_15)
                    {
                        base.method_9(Class613.class339_76);
                    }
                }
                Class631.smethod_0(base.method_1(), A_2);
                if (!(A_1 is Class392))
                {
                    base.method_92(A_2.enum11_0, A_2.int_5, A_2.byte_1);
                }
                if (!(A_1.class369_0 is Class375) && (A_2.byte_0 > 0))
                {
                    base.method_917(A_2.byte_0, A_1.class369_0 as Class370);
                }
                base.method_9(new Class359(A_1));
                if (A_2.short_0 > 0)
                {
                    base.method_913(A_2);
                }
                base.method_9(Class518.class337_10);
                ArrayList list = Class546.class568_0.arrayList_0;
                int num = A_2.short_2 - 1;
                int num2 = A_2.int_6;
                for (int i = 0; i < A_2.short_2; i++)
                {
                    Class568.Class623 class2 = list[num2 + i] as Class568.Class623;
                    if (class2.short_0 > 0)
                    {
                        base.method_901(class2);
                    }
                    if (class2.Boolean_0)
                    {
                        if (class2.Boolean_1)
                        {
                            base.method_9(Class613.class339_83);
                        }
                        else
                        {
                            base.method_9(Class613.class339_99);
                        }
                    }
                    base.method_92(class2.enum11_0, class2.int_1, class2.byte_4);
                    base.method_9(new Class355(class2));
                    if (i < num)
                    {
                        base.method_9(Class518.class337_15);
                    }
                }
                base.method_9(Class518.class337_12);
                if (A_2.short_0 > 0)
                {
                    base.method_914(A_2);
                }
            }
        }

        internal override void QRXS(Class369 node, Class547.Class528 method, Enum2 codetype, bool single)
        {
            if (!(node.class369_0 is Class371))
            {
                if (!single)
                {
                    base.method_46(node);
                }
                if (!single && (method.short_1 > 0))
                {
                    base.method_899(method);
                }
                base.method_900(method);
                this.method_922(node, method);
                if (!method.Boolean_12 && !method.Boolean_13)
                {
                    base.method_891(method, codetype);
                }
                else
                {
                    base.method_9(Class518.class337_19);
                    Class519.smethod_2(method);
                }
                Class631.smethod_1();
            }
        }

        internal override void QRXT(Class369 node, Class547.Class528 method)
        {
            if (!(node.class369_0 is Class371))
            {
                this.method_922(node, method);
                base.method_9(Class518.class337_19);
                Class519.smethod_2(method);
                Class631.smethod_1();
            }
        }
    }
}

