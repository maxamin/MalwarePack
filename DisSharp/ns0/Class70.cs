namespace ns0
{
    using System;

    internal abstract class Class70 : Class69
    {
        protected Class70()
        {
        }

        internal void method_181(Class549.Class530 A_1)
        {
            Class560.Class610 class2 = Class546.class560_0.arrayList_0[A_1.int_2] as Class560.Class610;
            base.method_9(Class518.class337_30);
            if (((class2.enum11_0 == Enum11.const_36) && (base.Enum10_0 != Enum10.const_8)) && (base.Enum10_0 != Enum10.const_9))
            {
                base.method_143(class2.int_0, this.method_182(class2.enum11_1, class2.int_1));
            }
            else if (((class2.enum11_0 == Enum11.const_38) && (base.Enum10_0 != Enum10.const_8)) && (base.Enum10_0 != Enum10.const_9))
            {
                base.method_144(class2.int_0, this.method_182(class2.enum11_1, class2.int_1));
            }
            else
            {
                switch (class2.enum11_1)
                {
                    case Enum11.const_16:
                        if (class2.int_1 != 1)
                        {
                            this.QQYZ();
                            return;
                        }
                        this.QQYY();
                        return;

                    case Enum11.const_17:
                        this.QRUU((char) class2.int_1);
                        return;

                    case Enum11.const_18:
                    case Enum11.const_19:
                    case Enum11.const_20:
                    case Enum11.const_21:
                    case Enum11.const_22:
                        this.QRUW(class2.int_1);
                        return;

                    case Enum11.const_23:
                    {
                        uint num = (Class546.class565_0.arrayList_0[class2.int_1] as Class565.Class620).uint_0;
                        this.QRUW(num);
                        return;
                    }
                    case Enum11.const_24:
                    {
                        long num2 = (Class546.class566_0.arrayList_0[class2.int_1] as Class566.Class621).long_0;
                        this.QRUW(num2);
                        return;
                    }
                    case Enum11.const_25:
                    {
                        ulong num3 = (Class546.class567_0.arrayList_0[class2.int_1] as Class567.Class622).ulong_0;
                        this.QRUW(num3);
                        return;
                    }
                    case Enum11.const_26:
                        this.QRUW((Class546.class571_0.arrayList_0[class2.int_1] as Class571.Class628).float_0);
                        base.method_9(Class584.class336_19);
                        return;

                    case Enum11.const_27:
                        this.QRUW((Class546.class572_0.arrayList_0[class2.int_1] as Class572.Class629).double_0);
                        return;

                    case Enum11.const_28:
                        this.QRSQ();
                        base.method_9(new Class353(class2.int_1));
                        this.QRSQ();
                        return;

                    case Enum11.const_29:
                        this.QQZQ();
                        return;
                }
            }
        }

        private long method_182(Enum11 A_1, int A_2)
        {
            switch (A_1)
            {
                case Enum11.const_18:
                case Enum11.const_19:
                case Enum11.const_20:
                case Enum11.const_21:
                case Enum11.const_22:
                    return (long) A_2;

                case Enum11.const_23:
                    return (long) (Class546.class565_0.arrayList_0[A_2] as Class565.Class620).uint_0;

                case Enum11.const_24:
                    return (Class546.class566_0.arrayList_0[A_2] as Class566.Class621).long_0;

                case Enum11.const_25:
                    return (long) (Class546.class567_0.arrayList_0[A_2] as Class567.Class622).ulong_0;
            }
            return 0L;
        }
    }
}

