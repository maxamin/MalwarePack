namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class300 : Class299
    {
        protected Class300()
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
                base.method_909(type);
            }
            else
            {
                base.method_908(type);
            }
            Class547.Class528 class2 = (node.class619_0[node.byte_0] as Class391).class528_0;
            base.method_9(Class632.class339_71);
            base.method_912(class2.enum11_0);
            base.method_9(new Class357(node));
            if (type.short_0 > 0)
            {
                base.method_913(type);
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
                    base.method_903(class3);
                }
                if (class3.Boolean_0)
                {
                    base.method_9(Class632.class339_23);
                }
                else
                {
                    base.method_9(Class632.class339_27);
                }
                base.method_9(new Class355(class3));
                base.method_9(Class632.class339_15);
                base.method_93(class3.enum11_0, class3.int_1, class3.byte_4);
                if (i < num)
                {
                    base.method_9(Class518.class337_15);
                }
            }
            base.method_9(Class518.class337_12);
            if (class2.enum11_0 != Enum11.const_15)
            {
                base.method_9(Class632.class339_15);
                base.method_93(class2.enum11_0, class2.int_5, class2.byte_1);
            }
        }
    }
}

