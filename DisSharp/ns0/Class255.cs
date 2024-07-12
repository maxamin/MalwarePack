namespace ns0
{
    using System;

    internal abstract class Class255 : Class254
    {
        protected Class255()
        {
        }

        internal override void QRWY(Class369 node, Class549.Class530 field)
        {
            if (field.short_0 > 0)
            {
                base.method_907(field);
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
                        base.method_9(Class538.class339_48);
                    }
                    if (field.Boolean_1)
                    {
                        base.method_9(Class538.class339_54);
                        base.method_9(Class538.class339_50);
                    }
                    if (field.Boolean_2)
                    {
                        base.method_9(Class538.class339_54);
                        base.method_9(Class538.class339_52);
                    }
                    if (field.Boolean_3)
                    {
                        base.method_9(Class538.class339_48);
                        base.method_9(Class518.class337_3);
                        base.method_9(Class538.class339_55);
                        base.method_9(Class518.class337_6);
                    }
                    if (field.Boolean_6)
                    {
                        base.method_9(Class538.class339_100);
                    }
                    else
                    {
                        if (field.Boolean_4)
                        {
                            base.method_9(Class538.class339_98);
                            base.method_9(Class538.class339_214);
                        }
                        if (field.Boolean_5)
                        {
                            base.method_9(Class518.class337_3);
                            base.method_9(Class538.class339_67);
                            base.method_9(Class518.class337_6);
                        }
                    }
                    base.method_9(new Class358(node));
                    base.method_9(Class518.class337_17);
                    base.method_93(field.enum11_0, field.int_2, field.byte_0);
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

