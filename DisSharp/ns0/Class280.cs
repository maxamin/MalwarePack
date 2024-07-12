namespace ns0
{
    using System;

    internal abstract class Class280 : Class279
    {
        protected Class280()
        {
        }

        internal override void QRWY(Class369 node, Class549.Class530 field)
        {
            base.method_46(node);
            if (field.short_0 > 0)
            {
                base.method_906(field);
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
                        base.method_9(Class634.class339_202);
                    }
                    if (field.Boolean_1)
                    {
                        base.method_9(Class634.class339_194);
                    }
                    if (field.Boolean_2)
                    {
                        base.method_9(Class634.class339_200);
                    }
                    if (field.Boolean_3)
                    {
                        base.method_9(Class634.class339_45);
                    }
                    if (field.Boolean_6)
                    {
                        base.method_9(Class634.class339_58);
                    }
                    else if (field.Boolean_4)
                    {
                        base.method_9(Class634.class339_56);
                    }
                    base.method_9(new Class358(node));
                    base.method_9(Class518.class337_17);
                    base.method_93(field.enum11_0, field.int_2, field.byte_0);
                    if (field.enum11_0 == Enum11.const_43)
                    {
                        base.method_181(field);
                    }
                    base.method_9(Class518.class337_19);
                    if (field.Boolean_5)
                    {
                        base.method_9(Class634.class339_211);
                        base.method_9(Class518.class337_19);
                    }
                    if (field.byte_0 > 0)
                    {
                        base.method_9(Class634.class339_256);
                        base.method_9(Class518.class337_19);
                    }
                    break;
            }
        }
    }
}

