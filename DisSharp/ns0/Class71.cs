namespace ns0
{
    using System;

    internal abstract class Class71 : Class70
    {
        private decimal decimal_0;
        private double double_0;
        private Enum16 enum16_0;
        private float float_0;
        private int int_8;
        private int int_9;
        private long long_0;

        protected Class71()
        {
        }

        internal bool method_183(uint A_1, Class445[] A_2)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            if (enum2 == Enum0.const_10)
            {
                Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class2.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                    this.int_8 = class3.short_0;
                    if (class3.int_0 == Class519.class604_0.int_2)
                    {
                        if (this.int_8 == 5)
                        {
                            return true;
                        }
                        if (this.int_8 == 1)
                        {
                            Class445 class4 = A_2[0];
                            switch (class4.Type)
                            {
                                case Enum17.const_19:
                                    this.enum16_0 = Enum16.const_3;
                                    this.double_0 = (class4 as Class450).double_0;
                                    return true;

                                case Enum17.const_21:
                                    this.enum16_0 = Enum16.const_2;
                                    this.float_0 = (class4 as Class449).float_0;
                                    return true;

                                case Enum17.const_22:
                                    this.enum16_0 = Enum16.const_0;
                                    this.int_9 = (class4 as Class447).int_0;
                                    return true;

                                case Enum17.const_23:
                                    this.enum16_0 = Enum16.const_1;
                                    this.long_0 = (class4 as Class448).long_0;
                                    return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        internal void method_184(Class445[] A_1)
        {
            if (this.int_8 == 5)
            {
                this.method_185(A_1);
            }
            if (this.int_8 == 1)
            {
                this.method_186();
            }
        }

        private void method_185(Class445[] A_1)
        {
            Class447 class2 = A_1[0] as Class447;
            if (class2 != null)
            {
                int lo = class2.int_0;
                class2 = A_1[1] as Class447;
                if (class2 != null)
                {
                    int mid = class2.int_0;
                    class2 = A_1[2] as Class447;
                    if (class2 != null)
                    {
                        int hi = class2.int_0;
                        Class451 class3 = A_1[3] as Class451;
                        if (class3 != null)
                        {
                            bool isNegative = class3.bool_0;
                            class2 = A_1[4] as Class447;
                            if (class2 != null)
                            {
                                byte scale = (byte) class2.int_0;
                                decimal num5 = new decimal(lo, mid, hi, isNegative, scale);
                                base.method_9(new Class336(Class543.smethod_0(num5.ToString())));
                                this.QRZW();
                            }
                        }
                    }
                }
            }
        }

        private void method_186()
        {
            switch (this.enum16_0)
            {
                case Enum16.const_0:
                    this.decimal_0 = new decimal(this.int_9);
                    break;

                case Enum16.const_1:
                    this.decimal_0 = new decimal(this.long_0);
                    break;

                case Enum16.const_2:
                    this.decimal_0 = new decimal(this.float_0);
                    break;

                case Enum16.const_3:
                    this.decimal_0 = new decimal(this.double_0);
                    break;
            }
            base.method_9(new Class336(Class543.smethod_0(this.decimal_0.ToString())));
            this.QRZW();
        }
    }
}

