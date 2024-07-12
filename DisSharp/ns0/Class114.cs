namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class114 : Class113
    {
        protected Class114()
        {
        }

        internal void method_429(Class434 A_1)
        {
            if (A_1.enum27_0 == Enum27.const_0)
            {
                int[] numArray = A_1.int_0;
                for (int j = 0; j < numArray.Length; j++)
                {
                    base.method_10(Class613.class339_12);
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                            switch (A_1.class433_0.enum0_0)
                            {
                            }
                            this.QRUW(numArray[j]);
                            goto Label_00CF;

                        case Enum28.const_1:
                            base.method_9(Class518.class337_2);
                            base.method_9(new Class353(numArray[j]));
                            base.method_9(Class518.class337_2);
                            goto Label_00CF;

                        case Enum28.const_2:
                            this.QRUU(numArray[j]);
                            goto Label_00CF;

                        default:
                            goto Label_00CF;
                    }
                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) numArray[j], A_1.class433_0.bool_1, true);
                Label_00CF:
                    base.method_9(Class518.class337_16);
                }
            }
            else
            {
                base.method_10(Class613.class339_25);
                base.method_9(Class518.class337_16);
            }
            base.int_0++;
            ArrayList qQSQ = A_1.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                base.method_39(class2);
            }
            switch (A_1.enum29_0)
            {
                case Enum29.const_0:
                {
                    base.method_10(Class613.class339_54);
                    base.method_9(Class613.class339_12);
                    Class434 class3 = A_1.class433_0.QQSQ[A_1.ushort_2] as Class434;
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                            switch (A_1.class433_0.enum0_0)
                            {
                                case Enum0.const_1:
                                case Enum0.const_2:
                                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) class3.int_0[0], A_1.class433_0.bool_1, true);
                                    goto Label_0259;
                            }
                            this.QRUW(class3.int_0[0]);
                            goto Label_0259;

                        case Enum28.const_1:
                            base.method_9(Class518.class337_2);
                            base.method_9(new Class353(class3.int_0[0]));
                            base.method_9(Class518.class337_2);
                            goto Label_0259;

                        case Enum28.const_2:
                            this.QRUU(class3.int_0[0]);
                            goto Label_0259;
                    }
                    break;
                }
                case Enum29.const_1:
                    base.method_10(Class613.class339_54);
                    base.method_9(Class613.class339_25);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_2:
                    base.method_10(Class613.class339_8);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_3:
                    base.method_10(Class613.class339_100);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_4:
                    base.method_12();
                    goto Label_02BF;

                default:
                    goto Label_02BF;
            }
        Label_0259:
            base.method_9(Class518.class337_19);
        Label_02BF:
            base.int_0--;
        }

        internal void method_430(Class434 A_1)
        {
            if (A_1.enum27_0 == Enum27.const_0)
            {
                int[] numArray = A_1.int_0;
                for (int j = 0; j < numArray.Length; j++)
                {
                    base.method_10(Class613.class339_12);
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                            switch (A_1.class433_0.enum0_0)
                            {
                            }
                            this.QRUW(numArray[j]);
                            goto Label_00CF;

                        case Enum28.const_1:
                            base.method_9(Class518.class337_2);
                            base.method_9(new Class353(numArray[j]));
                            base.method_9(Class518.class337_2);
                            goto Label_00CF;

                        case Enum28.const_2:
                            this.QRUU(numArray[j]);
                            goto Label_00CF;

                        default:
                            goto Label_00CF;
                    }
                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) numArray[j], A_1.class433_0.bool_1, true);
                Label_00CF:
                    base.method_9(Class518.class337_16);
                }
            }
            else
            {
                base.method_10(Class613.class339_25);
                base.method_9(Class518.class337_16);
            }
            base.int_0++;
            ArrayList qQSQ = A_1.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                base.method_39(class2);
            }
            switch (A_1.enum29_0)
            {
                case Enum29.const_0:
                {
                    base.method_10(Class613.class339_54);
                    base.method_9(Class613.class339_12);
                    Class434 class3 = A_1.class433_0.QQSQ[A_1.ushort_2] as Class434;
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                            switch (A_1.class433_0.enum0_0)
                            {
                                case Enum0.const_1:
                                case Enum0.const_2:
                                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) class3.int_0[0], A_1.class433_0.bool_1, true);
                                    goto Label_0259;
                            }
                            this.QRUW(class3.int_0[0]);
                            goto Label_0259;

                        case Enum28.const_1:
                            base.method_9(Class518.class337_2);
                            base.method_9(new Class353(class3.int_0[0]));
                            base.method_9(Class518.class337_2);
                            goto Label_0259;

                        case Enum28.const_2:
                            this.QRUU(class3.int_0[0]);
                            goto Label_0259;
                    }
                    break;
                }
                case Enum29.const_1:
                    base.method_10(Class613.class339_54);
                    base.method_9(Class613.class339_25);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_2:
                    base.method_10(Class613.class339_8);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_3:
                    base.method_10(Class613.class339_100);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_4:
                    base.method_12();
                    goto Label_02BF;

                default:
                    goto Label_02BF;
            }
        Label_0259:
            base.method_9(Class518.class337_19);
        Label_02BF:
            base.int_0--;
        }

        internal void method_431(Class434 A_1)
        {
            if (A_1.enum27_0 == Enum27.const_0)
            {
                int[] numArray = A_1.int_0;
                for (int j = 0; j < numArray.Length; j++)
                {
                    base.method_10(Class613.class339_12);
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                            switch (A_1.class433_0.enum0_0)
                            {
                            }
                            this.QRUW(numArray[j]);
                            goto Label_00CF;

                        case Enum28.const_1:
                            base.method_9(Class518.class337_2);
                            base.method_9(new Class353(numArray[j]));
                            base.method_9(Class518.class337_2);
                            goto Label_00CF;

                        case Enum28.const_2:
                            this.QRUU(numArray[j]);
                            goto Label_00CF;

                        default:
                            goto Label_00CF;
                    }
                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) numArray[j], A_1.class433_0.bool_1, true);
                Label_00CF:
                    base.method_9(Class518.class337_16);
                }
            }
            else
            {
                base.method_10(Class613.class339_25);
                base.method_9(Class518.class337_16);
            }
            base.int_0++;
            ArrayList qQSQ = A_1.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                base.method_39(class2);
            }
            switch (A_1.enum29_0)
            {
                case Enum29.const_0:
                {
                    base.method_10(Class613.class339_54);
                    base.method_9(Class613.class339_12);
                    Class434 class3 = A_1.class433_0.QQSQ[A_1.ushort_2] as Class434;
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                            switch (A_1.class433_0.enum0_0)
                            {
                                case Enum0.const_1:
                                case Enum0.const_2:
                                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) class3.int_0[0], A_1.class433_0.bool_1, true);
                                    goto Label_0259;
                            }
                            this.QRUW(class3.int_0[0]);
                            goto Label_0259;

                        case Enum28.const_1:
                            base.method_9(Class518.class337_2);
                            base.method_9(new Class353(class3.int_0[0]));
                            base.method_9(Class518.class337_2);
                            goto Label_0259;

                        case Enum28.const_2:
                            this.QRUU(class3.int_0[0]);
                            goto Label_0259;
                    }
                    break;
                }
                case Enum29.const_1:
                    base.method_10(Class613.class339_54);
                    base.method_9(Class613.class339_25);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_2:
                    base.method_10(Class613.class339_8);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_3:
                    base.method_10(Class613.class339_100);
                    base.method_9(Class518.class337_19);
                    goto Label_02BF;

                case Enum29.const_4:
                    base.method_12();
                    goto Label_02BF;

                default:
                    goto Label_02BF;
            }
        Label_0259:
            base.method_9(Class518.class337_19);
        Label_02BF:
            base.int_0--;
        }

        internal void method_432(Class434 A_1)
        {
            if (A_1.enum27_0 == Enum27.const_0)
            {
                base.method_10(Class632.class339_31);
                int[] numArray = A_1.int_0;
                int num = numArray.Length - 1;
                for (int j = 0; j < numArray.Length; j++)
                {
                    if ((j > 0) && (j < num))
                    {
                        base.method_9(Class518.class337_15);
                    }
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                        {
                            switch (A_1.class433_0.enum0_0)
                            {
                            }
                            this.QRUW(numArray[j]);
                            continue;
                        }
                        case Enum28.const_1:
                        {
                            base.method_9(Class518.class337_2);
                            base.method_9(new Class353(numArray[j]));
                            base.method_9(Class518.class337_2);
                            continue;
                        }
                        case Enum28.const_2:
                        {
                            this.QRUU(numArray[j]);
                            continue;
                        }
                        default:
                        {
                            continue;
                        }
                    }
                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) numArray[j], A_1.class433_0.bool_1, true);
                }
            }
            else
            {
                base.method_10(Class632.class339_31);
                base.method_9(Class632.class339_82);
            }
            base.int_0++;
            ArrayList qQSQ = A_1.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                base.method_39(class2);
            }
            base.int_0--;
        }

        internal void method_433(Class434 A_1)
        {
            bool flag = true;
            if (A_1.enum27_0 == Enum27.const_0)
            {
                int[] numArray = A_1.int_0;
                int num = numArray.Length - 1;
                for (int j = 0; j < numArray.Length; j++)
                {
                    base.method_7();
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                            switch (A_1.class433_0.enum0_0)
                            {
                            }
                            this.QRUW(numArray[j]);
                            goto Label_00E8;

                        case Enum28.const_1:
                            base.method_9(Class518.class337_3);
                            base.method_9(Class518.class337_1);
                            base.method_9(new Class353(numArray[j]));
                            base.method_9(Class518.class337_1);
                            base.method_9(Class518.class337_5);
                            goto Label_00E8;

                        case Enum28.const_2:
                            this.QRUU(numArray[j]);
                            goto Label_00E8;

                        default:
                            goto Label_00E8;
                    }
                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) numArray[j], A_1.class433_0.bool_1, true);
                Label_00E8:
                    if (j == num)
                    {
                        base.method_9(Class518.class337_16);
                    }
                    else
                    {
                        base.method_9(Class518.class337_14);
                    }
                }
            }
            else
            {
                flag = false;
            }
            if (flag)
            {
                base.int_0++;
            }
            base.method_10(Class538.class339_92);
            base.int_0++;
            ArrayList qQSQ = A_1.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                base.method_39(class2);
            }
            base.int_0--;
            switch (A_1.enum29_0)
            {
                case Enum29.const_3:
                    base.method_10(Class538.class339_38);
                    base.method_9(Class518.class337_19);
                    break;

                case Enum29.const_4:
                    base.method_12();
                    break;
            }
            base.method_10(Class538.class339_116);
            base.method_9(Class518.class337_19);
            if (flag)
            {
                base.int_0--;
            }
        }

        internal void method_434(Class434 A_1)
        {
            bool flag = true;
            if (A_1.enum27_0 == Enum27.const_0)
            {
                int[] numArray = A_1.int_0;
                int num = numArray.Length - 1;
                for (int j = 0; j < numArray.Length; j++)
                {
                    base.method_7();
                    switch (A_1.class433_0.enum28_0)
                    {
                        case Enum28.const_0:
                            switch (A_1.class433_0.enum0_0)
                            {
                            }
                            this.QRUW(numArray[j]);
                            goto Label_00E8;

                        case Enum28.const_1:
                            base.method_9(Class518.class337_3);
                            base.method_9(Class518.class337_1);
                            base.method_9(new Class353(numArray[j]));
                            base.method_9(Class518.class337_1);
                            base.method_9(Class518.class337_5);
                            goto Label_00E8;

                        case Enum28.const_2:
                            this.QRUU(numArray[j]);
                            goto Label_00E8;

                        default:
                            goto Label_00E8;
                    }
                    base.method_146(A_1.class433_0.enum0_0, A_1.class433_0.int_0, (long) numArray[j], A_1.class433_0.bool_1, true);
                Label_00E8:
                    if (j == num)
                    {
                        base.method_9(Class518.class337_16);
                    }
                    else
                    {
                        base.method_9(Class518.class337_14);
                    }
                }
            }
            else
            {
                flag = false;
            }
            if (flag)
            {
                base.int_0++;
            }
            base.method_10(Class634.class339_48);
            base.int_0++;
            ArrayList qQSQ = A_1.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class398 class2 = qQSQ[i] as Class398;
                base.method_39(class2);
            }
            base.int_0--;
            switch (A_1.enum29_0)
            {
                case Enum29.const_3:
                    base.method_10(Class634.class339_92);
                    base.method_9(Class518.class337_19);
                    break;

                case Enum29.const_4:
                    base.method_12();
                    break;
            }
            base.method_10(Class634.class339_82);
            base.method_9(Class518.class337_19);
            if (flag)
            {
                base.int_0--;
            }
        }
    }
}

