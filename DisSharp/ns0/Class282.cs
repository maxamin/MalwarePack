namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class282 : Class281
    {
        protected Class282()
        {
        }

        private void method_929(Class382 A_1, bool A_2)
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
                base.method_908(A_1);
            }
            base.method_7();
            if (!(A_1.class369_0 is Class375) && (class2.byte_0 == 0))
            {
                base.method_923(class2);
            }
            base.method_9(Class634.class339_198);
            base.method_9(new Class362(A_1));
            base.method_9(Class518.class337_7);
            Struct3[] structArray = A_1.struct3_0;
            int num = structArray.Length - 1;
            ArrayList list = Class546.class568_0.arrayList_0;
            int num2 = class2.int_6;
            for (int i = 0; i < structArray.Length; i++)
            {
                Class568.Class623 class4 = list[num2 + i] as Class568.Class623;
                base.method_9(new Class355(class4));
                base.method_9(Class518.class337_17);
                base.method_93(structArray[i].enum11_0, structArray[i].int_0, structArray[i].byte_0);
                if (i < num)
                {
                    base.method_9(Class518.class337_15);
                }
            }
            base.method_9(Class518.class337_8);
            base.method_9(Class518.class337_17);
            base.method_93(A_1.enum11_0, A_1.int_1, A_1.byte_0);
            base.method_9(Class634.class339_65);
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

        private void method_930(Class382 A_1, bool A_2)
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

        internal override void QRWZ(Class382 node, Enum2 codetype, bool single)
        {
            if (single)
            {
                this.method_930(node, true);
            }
            else if (base.bool_3)
            {
                this.method_930(node, false);
            }
            else
            {
                this.method_929(node, false);
            }
        }

        internal override void QRXQ(Class382 node)
        {
            this.method_929(node, true);
        }
    }
}

