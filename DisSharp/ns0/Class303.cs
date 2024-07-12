namespace ns0
{
    using System;

    internal abstract class Class303 : Class302
    {
        protected Class303()
        {
        }

        internal override void QRWY(Class369 node, Class549.Class530 field)
        {
            base.method_46(node);
            if (field.short_0 > 0)
            {
                base.method_904(field);
            }
            base.method_7();
            switch (base.Enum10_0)
            {
                case Enum10.const_8:
                case Enum10.const_9:
                    base.method_9(new Class358(node));
                    if ((field.enum11_0 == Enum11.const_43) && (((node.class369_0 as Class370).byte_0 & 1) == 0))
                    {
                        base.method_181(field);
                        return;
                    }
                    break;

                default:
                    if (field.Boolean_0)
                    {
                        base.method_9(Class632.class339_215);
                    }
                    if (field.Boolean_1)
                    {
                        base.method_9(Class632.class339_209);
                    }
                    if (field.Boolean_2)
                    {
                        base.method_9(Class632.class339_213);
                    }
                    if (field.Boolean_3)
                    {
                        base.method_9(Class632.class339_105);
                    }
                    if (field.Boolean_6)
                    {
                        base.method_9(Class632.class339_48);
                    }
                    else
                    {
                        if (field.Boolean_4)
                        {
                            base.method_9(Class632.class339_239);
                        }
                        if (field.Boolean_5)
                        {
                            base.method_9(Class632.class339_219);
                        }
                    }
                    base.method_9(new Class358(node));
                    base.method_9(Class632.class339_15);
                    base.method_92(field.enum11_0, field.int_2, field.byte_0);
                    if (field.enum11_0 == Enum11.const_43)
                    {
                        base.method_181(field);
                    }
                    break;
            }
        }
    }
}

