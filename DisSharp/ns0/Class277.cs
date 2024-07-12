namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class277 : Class276
    {
        protected Class277()
        {
        }

        internal override void QRWU(Class370 node, Class548.Class529 type)
        {
            Class519.class529_1 = type;
            base.method_46(node);
            if (type.short_3 > 0)
            {
                base.method_902(type);
            }
            base.method_7();
            Class547.Class528 class2 = (node.class619_0[node.byte_0] as Class391).class528_0;
            Class631.smethod_0(base.method_1(), class2);
            base.method_9(new Class357(node));
            if (type.short_0 > 0)
            {
                base.method_914(type);
            }
            base.method_9(Class518.class337_30);
            if (node is Class372)
            {
                base.method_911(type);
            }
            else
            {
                base.method_910(type);
            }
            if (class2.enum11_0 == Enum11.const_15)
            {
                base.method_9(Class634.class339_196);
            }
            else
            {
                base.method_9(Class634.class339_115);
            }
            base.method_9(new Class359(class2.class369_0));
            base.method_9(Class518.class337_10);
            ArrayList list = Class546.class568_0.arrayList_0;
            int num = class2.short_2 - 1;
            int num2 = class2.int_6;
            for (int i = 0; i < class2.short_2; i++)
            {
                Class568.Class623 class3 = list[num2 + i] as Class568.Class623;
                if (class3.short_0 > 0)
                {
                    base.method_905(class3);
                }
                if (class3.Boolean_0)
                {
                    if (class3.Boolean_1)
                    {
                        base.method_9(Class634.class339_262);
                    }
                    else
                    {
                        base.method_9(Class634.class339_262);
                    }
                }
                base.method_9(new Class355(class3));
                base.method_9(Class518.class337_17);
                base.method_93(class3.enum11_0, class3.int_1, class3.byte_4);
                if (i < num)
                {
                    base.method_9(Class518.class337_15);
                }
            }
            base.method_9(Class518.class337_12);
            if (class2.enum11_0 != Enum11.const_15)
            {
                base.method_9(Class518.class337_17);
                base.method_93(class2.enum11_0, class2.int_5, class2.byte_1);
            }
            base.method_9(Class518.class337_19);
            if (class2.Boolean_14)
            {
                base.method_9(Class634.class339_255);
                base.method_9(Class518.class337_19);
            }
        }
    }
}

