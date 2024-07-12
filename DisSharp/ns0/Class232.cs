namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class232 : Class231
    {
        protected Class232()
        {
        }

        private void method_921(Class382 A_1, Class547.Class528 A_2)
        {
            base.method_7();
            if (!(A_1.class369_0 is Class375))
            {
                base.method_909(A_2);
            }
            Class631.smethod_0(base.method_1(), A_2);
            base.method_92(A_1.enum11_0, A_1.int_1, A_1.byte_0);
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 > 0))
            {
                base.method_917(A_2.byte_0, A_1.class369_0 as Class370);
            }
            ArrayList list = Class546.class568_0.arrayList_0;
            int num = A_2.int_6;
            base.method_9(Class613.class339_121);
            base.method_9(Class518.class337_7);
            Struct3[] structArray = A_1.struct3_0;
            int num2 = structArray.Length - 1;
            for (int i = 0; i < structArray.Length; i++)
            {
                base.method_92(structArray[i].enum11_0, structArray[i].int_0, structArray[i].byte_0);
                Class568.Class623 class2 = list[num + i] as Class568.Class623;
                base.method_9(new Class355(class2));
                if (i < num2)
                {
                    base.method_9(Class518.class337_15);
                }
            }
            base.method_9(Class518.class337_8);
        }

        internal override void QRWZ(Class382 node, Enum2 codetype, bool single)
        {
            if (!single)
            {
                base.method_46(node);
            }
            if (!single && (node.short_0 > 0))
            {
                base.method_904(node);
            }
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_921(node, class2);
            base.method_10(Class518.class337_3);
            base.int_0++;
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
            base.int_0--;
            base.method_10(Class518.class337_5);
            Class631.smethod_1();
        }

        internal override void QRXQ(Class382 node)
        {
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_921(node, class2);
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

