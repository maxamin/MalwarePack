namespace ns0
{
    using System;

    internal abstract class Class230 : Class229
    {
        protected Class230()
        {
        }

        internal override void QRWY(Class369 node, Class549.Class530 field)
        {
            base.method_46(node);
            if (field.short_0 > 0)
            {
                base.method_902(field);
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
                    }
                    if (base.Int32_0 < base.Int32_1)
                    {
                        base.method_9(Class518.class337_14);
                        return;
                    }
                    break;

                default:
                    if (field.Boolean_0)
                    {
                        base.method_9(Class613.class339_95);
                    }
                    if (field.Boolean_1)
                    {
                        base.method_9(Class613.class339_91);
                    }
                    if (field.Boolean_2)
                    {
                        base.method_9(Class613.class339_93);
                    }
                    if (field.Boolean_3)
                    {
                        base.method_9(Class613.class339_66);
                    }
                    if (field.Boolean_6)
                    {
                        base.method_9(Class613.class339_21);
                    }
                    else
                    {
                        if (field.Boolean_4)
                        {
                            base.method_9(Class613.class339_114);
                        }
                        if (field.Boolean_5)
                        {
                            base.method_9(Class613.class339_97);
                        }
                    }
                    if (field.byte_0 > 0)
                    {
                        base.method_9(Class613.class339_133);
                    }
                    if (base.method_201(field))
                    {
                        base.method_9(Class613.class339_143);
                    }
                    base.method_92(field.enum11_0, field.int_2, field.byte_0);
                    base.method_9(new Class358(node));
                    if (field.enum11_0 == Enum11.const_43)
                    {
                        base.method_181(field);
                    }
                    base.method_9(Class518.class337_19);
                    break;
            }
        }
    }
}

