namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class323 : Class322
    {
        protected Class323()
        {
        }

        internal override void QRWU(Class370 node, Class548.Class529 type)
        {
            Class519.class529_1 = type;
            base.method_46(node);
            if (type.short_3 > 0)
            {
                base.method_898(type);
            }
            base.method_7();
            if (node is Class372)
            {
                base.method_907(type);
            }
            else
            {
                base.method_906(type);
            }
            Class547.Class528 class2 = (node.class619_0[node.byte_0] as Class391).class528_0;
            if (class2.Boolean_14)
            {
                base.method_9(Class613.class339_133);
            }
            Class631.smethod_0(base.method_1(), class2);
            base.method_9(Class613.class339_27);
            base.method_92(class2.enum11_0, class2.int_5, class2.byte_1);
            base.method_9(new Class357(node));
            if (type.short_0 > 0)
            {
                base.method_911(type);
            }
            base.method_9(Class518.class337_10);
            ArrayList list = Class546.class568_0.arrayList_0;
            int num = class2.short_2 - 1;
            int num2 = class2.int_6;
            for (int i = 0; i < class2.short_2; i++)
            {
                Class568.Class623 class3 = list[num2 + i] as Class568.Class623;
                if (class3.short_0 > 0)
                {
                    base.method_901(class3);
                }
                if (class3.Boolean_0)
                {
                    if (class3.Boolean_1)
                    {
                        base.method_9(Class613.class339_83);
                    }
                    else
                    {
                        base.method_9(Class613.class339_99);
                    }
                }
                base.method_92(class3.enum11_0, class3.int_1, class3.byte_4);
                base.method_9(new Class355(class3));
                if (i < num)
                {
                    base.method_9(Class518.class337_15);
                }
            }
            base.method_9(Class518.class337_12);
            base.method_9(Class518.class337_19);
            Class631.smethod_1();
        }
    }
}

