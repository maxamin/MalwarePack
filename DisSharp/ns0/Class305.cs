namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class305 : Class304
    {
        protected Class305()
        {
        }

        private void method_922(Class382 A_1, Class547.Class528 A_2)
        {
            base.method_7();
            if (!(A_1.class369_0 is Class375))
            {
                base.method_911(A_2);
            }
            if (A_1.enum34_0 == Enum34.const_0)
            {
                base.method_9(Class632.class339_219);
            }
            if (A_1.enum34_0 == Enum34.const_1)
            {
                base.method_9(Class632.class339_297);
            }
            base.method_9(Class632.class339_69);
            base.method_9(Class632.class339_211);
            base.method_9(new Class362(A_1));
            ArrayList list = Class546.class568_0.arrayList_0;
            int num = A_2.int_6;
            base.method_9(Class518.class337_10);
            Struct3[] structArray = A_1.struct3_0;
            int num2 = structArray.Length - 1;
            for (int i = 0; i < structArray.Length; i++)
            {
                Class568.Class623 class2 = list[num + i] as Class568.Class623;
                if (class2.short_0 > 0)
                {
                    base.method_903(class2);
                }
                if (class2.Boolean_0)
                {
                    base.method_9(Class632.class339_23);
                }
                else
                {
                    base.method_9(Class632.class339_27);
                }
                base.method_9(new Class355(class2));
                base.method_9(Class632.class339_15);
                base.method_93(structArray[i].enum11_0, structArray[i].int_0, structArray[i].byte_0);
                if (i < num2)
                {
                    base.method_9(Class518.class337_15);
                }
            }
            base.method_9(Class518.class337_12);
            base.method_9(Class632.class339_15);
            base.method_93(A_1.enum11_0, A_1.int_1, A_1.byte_0);
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 > 0))
            {
                base.method_918(A_2.byte_0, A_1.class369_0 as Class370);
            }
        }

        internal override void QRWZ(Class382 node, Enum2 codetype, bool single)
        {
            if (!single)
            {
                base.method_46(node);
            }
            if (!single && (node.short_0 > 0))
            {
                base.method_906(node);
            }
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_922(node, class2);
            if (!class2.Boolean_12)
            {
                base.int_0++;
                if (node.enum34_0 == Enum34.const_2)
                {
                    base.method_10(Class632.class339_108);
                    base.method_891(class2, codetype);
                    base.method_10(Class632.class339_87);
                    base.method_9(Class632.class339_108);
                    base.method_10(Class632.class339_234);
                    base.method_891((node.class619_0[1] as Class391).class528_0, codetype);
                    base.method_10(Class632.class339_87);
                    base.method_9(Class632.class339_234);
                }
                else if (node.enum34_0 == Enum34.const_0)
                {
                    base.method_10(Class632.class339_108);
                    base.method_891(class2, codetype);
                    base.method_10(Class632.class339_87);
                    base.method_9(Class632.class339_108);
                }
                else
                {
                    base.method_10(Class632.class339_234);
                    base.method_891(class2, codetype);
                    base.method_10(Class632.class339_87);
                    base.method_9(Class632.class339_234);
                }
                base.int_0--;
                base.method_10(Class632.class339_87);
                base.method_9(Class632.class339_210);
            }
        }

        internal override void QRXQ(Class382 node)
        {
            Class547.Class528 class2 = (node.class619_0[0] as Class391).class528_0;
            this.method_922(node, class2);
            base.method_9(Class584.class342_0);
            if (node.enum34_0 == Enum34.const_2)
            {
                base.method_9(Class632.class339_109);
                base.method_9(Class632.class339_234);
            }
            else if (node.enum34_0 == Enum34.const_0)
            {
                base.method_9(Class632.class339_108);
            }
            else
            {
                base.method_9(Class632.class339_234);
            }
        }
    }
}

