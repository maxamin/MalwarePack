namespace ns0
{
    using System;

    internal abstract class Class59 : Class58
    {
        protected Class59()
        {
        }

        internal void method_39(Class398 A_1)
        {
            if (A_1.ushort_0 <= 0)
            {
                goto Label_00D7;
            }
            base.int_0--;
            Enum6 enum2 = Class516.enum6_0;
            if (enum2 <= Enum6.flag_3)
            {
                switch (enum2)
                {
                    case Enum6.flag_1:
                    case Enum6.flag_2:
                        goto Label_008F;

                    case Enum6.flag_3:
                        base.method_10(Class584.class340_0);
                        base.method_9(Class585.smethod_1(A_1.ushort_0));
                        base.method_9(Class518.class337_16);
                        base.method_9(Class584.class342_0);
                        base.method_9(Class518.class337_22);
                        break;
                }
                goto Label_00C9;
            }
            if (((enum2 != Enum6.flag_4) && (enum2 != Enum6.flag_5)) && (enum2 != Enum6.flag_6))
            {
                goto Label_00C9;
            }
        Label_008F:
            base.method_10(Class584.class340_0);
            base.method_9(Class585.smethod_1(A_1.ushort_0));
            base.method_9(Class518.class337_16);
            if (A_1.bool_0)
            {
                base.method_9(Class518.class337_19);
            }
        Label_00C9:
            base.int_0++;
        Label_00D7:
            if (!A_1.bool_0)
            {
                this.QRVX(A_1);
            }
        }

        internal override void QRVX(Class397 lines, Class398 statement)
        {
            base.method_0(lines);
            this.QRVX(statement);
        }
    }
}

