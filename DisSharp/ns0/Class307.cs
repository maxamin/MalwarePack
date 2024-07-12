namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class307 : Class306
    {
        protected Class307()
        {
        }

        private void method_923(Class369 A_1, Class547.Class528 A_2)
        {
            base.method_7();
            Class519.class367_0 = base.Class367_0;
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 == 0))
            {
                if (!(A_1 is Class392) || !A_2.Boolean_8)
                {
                    if (A_2.Boolean_4)
                    {
                        base.method_9(Class632.class339_215);
                    }
                    if (A_2.Boolean_5)
                    {
                        base.method_9(Class632.class339_209);
                    }
                    if (A_2.Boolean_6)
                    {
                        base.method_9(Class632.class339_213);
                    }
                    if (A_2.Boolean_7)
                    {
                        base.method_9(Class632.class339_105);
                    }
                }
                if (A_2.Boolean_8 && !A_2.Boolean_13)
                {
                    base.method_9(Class632.class339_239);
                }
                if (A_2.Boolean_13)
                {
                    base.method_9(Class632.class339_67);
                }
                if (A_2.Boolean_9 && !A_2.Boolean_13)
                {
                    base.method_9(Class632.class339_179);
                }
                if (A_2.Boolean_12)
                {
                    base.method_9(Class632.class339_159);
                }
                else if (A_2.Boolean_11)
                {
                    if (A_2.Boolean_10)
                    {
                        base.method_9(Class632.class339_203);
                    }
                    else
                    {
                        base.method_9(Class632.class339_201);
                    }
                }
                if (A_2.Boolean_15)
                {
                    base.method_9(Class632.class339_237);
                }
            }
            if (A_2.Boolean_13 && (base.string_33 != Class537.string_0))
            {
                switch (base.enum15_0)
                {
                    case Enum15.const_0:
                        base.method_9(Class632.class339_19);
                        break;

                    case Enum15.const_1:
                        base.method_9(Class632.class339_13);
                        break;

                    case Enum15.const_2:
                        base.method_9(Class632.class339_277);
                        break;
                }
            }
            if ((A_2.enum11_0 != Enum11.const_15) && !(A_1 is Class392))
            {
                base.method_9(Class632.class339_107);
            }
            else
            {
                base.method_9(Class632.class339_255);
            }
            if (A_1 is Class392)
            {
                base.method_9(Class632.class339_166);
            }
            else
            {
                base.method_9(new Class359(A_1));
            }
            if (A_2.short_0 > 0)
            {
                base.method_915(A_2);
            }
            if (A_2.Boolean_13 && (base.string_33 != Class537.string_0))
            {
                base.method_9(Class632.class339_142);
                this.QRSQ();
                base.method_9(new Class336(base.string_33));
                this.QRSQ();
                base.method_9(Class584.class342_0);
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
                base.method_93(class2.enum11_0, class2.int_1, class2.byte_4);
                if (i < num)
                {
                    base.method_9(Class518.class337_15);
                }
            }
            base.method_9(Class518.class337_12);
            if ((A_2.enum11_0 != Enum11.const_15) && !(A_1 is Class392))
            {
                base.method_9(Class632.class339_15);
                base.method_93(A_2.enum11_0, A_2.int_5, A_2.byte_1);
            }
            if (!(A_1.class369_0 is Class375) && (A_2.byte_0 > 0))
            {
                base.method_918(A_2.byte_0, A_1.class369_0 as Class370);
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
                    base.method_899(method, method.Boolean_13);
                }
                if (single && method.Boolean_13)
                {
                    base.method_900(method);
                }
                base.method_902(method);
                this.method_923(node, method);
                if (!method.Boolean_12 && !method.Boolean_13)
                {
                    base.method_891(method, codetype);
                    base.method_10(Class632.class339_87);
                    if (method.enum11_0 == Enum11.const_15)
                    {
                        base.method_9(Class632.class339_254);
                    }
                    else
                    {
                        base.method_9(Class632.class339_106);
                    }
                }
            }
        }

        internal override void QRXT(Class369 node, Class547.Class528 method)
        {
            if (!(node.class369_0 is Class371))
            {
                this.method_923(node, method);
            }
        }
    }
}

