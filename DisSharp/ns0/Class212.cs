namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class212 : Class211
    {
        protected Class212()
        {
        }

        private void method_923(Class383 A_1, Class547.Class528 A_2)
        {
            ArrayList list = Class546.class568_0.arrayList_0;
            Class568.Class623 class2 = list[A_2.int_6] as Class568.Class623;
            base.method_10(Class613.class339_95);
            base.method_9(Class613.class339_114);
            if (A_2.Boolean_14)
            {
                base.method_9(Class613.class339_133);
            }
            Class631.smethod_0(base.method_1(), A_2);
            Enum4 enum2 = A_1.enum4_0;
            if (enum2 <= Enum4.const_1)
            {
                if (enum2 == Enum4.const_0)
                {
                    base.method_9(Class613.class339_58);
                }
                else
                {
                    base.method_9(Class613.class339_38);
                }
                base.method_9(Class613.class339_81);
                base.method_93(A_2.enum11_0, A_2.int_5, A_2.byte_1);
                base.method_9(Class518.class337_10);
                base.method_92(class2.enum11_0, class2.int_1, class2.byte_4);
                base.method_9(new Class355(class2));
                base.method_9(Class518.class337_12);
            }
            else
            {
                base.method_92(A_2.enum11_0, A_2.int_5, A_2.byte_1);
                base.method_9(Class613.class339_81);
                base.method_9(this.QRYQ(enum2));
                base.method_9(Class518.class337_10);
                base.method_92(class2.enum11_0, class2.int_1, class2.byte_4);
                base.method_9(new Class355(class2));
                if (enum2 >= Enum4.const_10)
                {
                    base.method_9(Class518.class337_15);
                    class2 = list[A_2.int_6 + 1] as Class568.Class623;
                    base.method_92(class2.enum11_0, class2.int_1, class2.byte_4);
                    base.method_9(new Class355(class2));
                }
                base.method_9(Class518.class337_12);
            }
        }

        internal override void QRXU(Class383 node, Class547.Class528 method, Enum2 codetype, bool single)
        {
            if (!single)
            {
                base.method_46(node);
            }
            if (!single && (method.short_1 > 0))
            {
                base.method_899(method);
            }
            base.method_900(method);
            this.method_923(node, method);
            base.method_891(method, codetype);
            Class631.smethod_1();
        }

        internal override void QRXV(Class383 node, Class547.Class528 method)
        {
            this.method_923(node, method);
            base.method_9(Class518.class337_19);
            Class631.smethod_1();
        }

        internal override Class336 QRYQ(Enum4 enum4_0)
        {
            switch (enum4_0)
            {
                case Enum4.const_2:
                    return Class518.class337_23;

                case Enum4.const_3:
                    return Class518.class337_25;

                case Enum4.const_4:
                    return Class518.class337_27;

                case Enum4.const_5:
                    return Class518.class337_21;

                case Enum4.const_6:
                    return Class518.class337_66;

                case Enum4.const_7:
                    return Class518.class337_67;

                case Enum4.const_8:
                    return Class613.class339_124;

                case Enum4.const_9:
                    return Class613.class339_41;

                case Enum4.const_10:
                    return Class518.class337_23;

                case Enum4.const_11:
                    return Class518.class337_25;

                case Enum4.const_12:
                    return Class518.class337_56;

                case Enum4.const_13:
                    return Class518.class337_60;

                case Enum4.const_14:
                    return Class518.class337_58;

                case Enum4.const_15:
                    return Class518.class337_52;

                case Enum4.const_16:
                    return Class518.class337_54;

                case Enum4.const_17:
                    return Class518.class337_62;

                case Enum4.const_18:
                    return Class518.class337_68;

                case Enum4.const_19:
                    return Class518.class337_70;

                case Enum4.const_20:
                    return Class518.class337_33;

                case Enum4.const_21:
                    return Class518.class337_35;

                case Enum4.const_22:
                    return Class518.class337_39;

                case Enum4.const_23:
                    return Class518.class337_43;

                case Enum4.const_24:
                    return Class518.class337_46;

                case Enum4.const_25:
                    return Class518.class337_41;
            }
            return Class584.class336_0;
        }
    }
}

