namespace ns0
{
    using System;

    internal class Class608
    {
        internal bool bool_0;
        internal bool bool_1;
        internal byte byte_0;
        internal byte[] byte_1;
        private Class48 class48_0;
        internal Enum11 enum11_0;
        private Enum11 enum11_1;
        internal int int_0;
        private int int_1;

        internal Class608(Class48 A_1)
        {
            this.class48_0 = A_1;
        }

        internal void method_0()
        {
            this.bool_0 = false;
            this.bool_1 = false;
            this.enum11_0 = Enum11.const_0;
            this.int_0 = 0;
            this.byte_0 = 0;
            this.byte_1 = null;
            this.method_15();
        }

        private Enum37 method_1(byte A_1)
        {
            switch (A_1)
            {
                case 0:
                    return Enum37.const_0;

                case 1:
                    return Enum37.const_1;

                case 2:
                    return Enum37.const_2;

                case 3:
                    return Enum37.const_3;

                case 4:
                    return Enum37.const_4;

                case 5:
                    return Enum37.const_5;

                case 6:
                    return Enum37.const_6;

                case 7:
                    return Enum37.const_7;

                case 8:
                    return Enum37.const_8;

                case 9:
                    return Enum37.const_9;

                case 10:
                    return Enum37.const_10;

                case 11:
                    return Enum37.const_11;

                case 12:
                    return Enum37.const_12;

                case 13:
                    return Enum37.const_13;

                case 14:
                    return Enum37.const_14;

                case 15:
                    return Enum37.const_15;

                case 0x10:
                    return Enum37.const_16;

                case 0x11:
                    return Enum37.const_17;

                case 0x12:
                    return Enum37.const_18;

                case 0x13:
                    return Enum37.const_19;

                case 20:
                    return Enum37.const_20;

                case 0x15:
                    return Enum37.const_21;

                case 0x16:
                    return Enum37.const_22;

                case 0x18:
                    return Enum37.const_23;

                case 0x19:
                    return Enum37.const_24;

                case 0x1b:
                    return Enum37.const_25;

                case 0x1c:
                    return Enum37.const_26;

                case 0x1d:
                    return Enum37.const_27;

                case 30:
                    return Enum37.const_28;

                case 0x1f:
                    return Enum37.const_29;

                case 0x20:
                    return Enum37.const_30;

                case 0x21:
                    return Enum37.const_31;

                case 0x40:
                    return Enum37.const_32;

                case 0x41:
                    return Enum37.const_33;

                case 0x45:
                    return Enum37.const_34;
            }
            return Enum37.const_35;
        }

        private void method_10()
        {
            this.int_1++;
            this.method_12();
        }

        private void method_11()
        {
            this.int_1 += 2;
            this.method_12();
            this.class48_0.method_21();
            int num = this.class48_0.method_21();
            for (int i = 0; i < num; i++)
            {
                this.class48_0.method_21();
            }
            int num3 = this.class48_0.method_21();
            for (int j = 0; j < num3; j++)
            {
                this.class48_0.method_21();
            }
        }

        private void method_12()
        {
            switch (this.method_1(this.class48_0.method_8()))
            {
                case Enum37.const_2:
                    this.enum11_1 = Enum11.const_1;
                    return;

                case Enum37.const_3:
                    this.enum11_1 = Enum11.const_2;
                    return;

                case Enum37.const_4:
                    this.enum11_1 = Enum11.const_3;
                    return;

                case Enum37.const_5:
                    this.enum11_1 = Enum11.const_4;
                    return;

                case Enum37.const_6:
                    this.enum11_1 = Enum11.const_5;
                    return;

                case Enum37.const_7:
                    this.enum11_1 = Enum11.const_6;
                    return;

                case Enum37.const_8:
                    this.enum11_1 = Enum11.const_7;
                    return;

                case Enum37.const_9:
                    this.enum11_1 = Enum11.const_8;
                    return;

                case Enum37.const_10:
                    this.enum11_1 = Enum11.const_9;
                    return;

                case Enum37.const_11:
                    this.enum11_1 = Enum11.const_10;
                    return;

                case Enum37.const_12:
                    this.enum11_1 = Enum11.const_11;
                    return;

                case Enum37.const_13:
                    this.enum11_1 = Enum11.const_12;
                    return;

                case Enum37.const_14:
                    this.enum11_1 = Enum11.const_13;
                    return;

                case Enum37.const_15:
                case Enum37.const_16:
                case Enum37.const_25:
                    break;

                case Enum37.const_17:
                    this.method_2();
                    return;

                case Enum37.const_18:
                    this.method_2();
                    return;

                case Enum37.const_19:
                    this.method_6();
                    return;

                case Enum37.const_20:
                    this.method_11();
                    return;

                case Enum37.const_21:
                    this.method_8();
                    return;

                case Enum37.const_22:
                    this.enum11_1 = Enum11.const_35;
                    return;

                case Enum37.const_23:
                    this.enum11_1 = Enum11.const_32;
                    return;

                case Enum37.const_24:
                    this.enum11_1 = Enum11.const_33;
                    return;

                case Enum37.const_26:
                    this.enum11_1 = Enum11.const_14;
                    return;

                case Enum37.const_27:
                    this.method_10();
                    return;

                case Enum37.const_28:
                    this.method_7();
                    break;

                default:
                    return;
            }
        }

        private void method_13()
        {
            this.method_2();
            this.enum11_0 = Enum11.const_0;
            this.int_0 = 0;
            this.method_15();
        }

        private void method_14()
        {
            this.method_2();
            this.enum11_0 = Enum11.const_0;
            this.int_0 = 0;
            this.method_15();
        }

        private void method_15()
        {
            this.enum11_0 = Enum11.const_0;
            switch (this.method_1(this.class48_0.method_8()))
            {
                case Enum37.const_1:
                    this.enum11_0 = Enum11.const_15;
                    return;

                case Enum37.const_2:
                    this.enum11_0 = Enum11.const_16;
                    return;

                case Enum37.const_3:
                    this.enum11_0 = Enum11.const_17;
                    return;

                case Enum37.const_4:
                    this.enum11_0 = Enum11.const_18;
                    return;

                case Enum37.const_5:
                    this.enum11_0 = Enum11.const_19;
                    return;

                case Enum37.const_6:
                    this.enum11_0 = Enum11.const_20;
                    return;

                case Enum37.const_7:
                    this.enum11_0 = Enum11.const_21;
                    return;

                case Enum37.const_8:
                    this.enum11_0 = Enum11.const_22;
                    return;

                case Enum37.const_9:
                    this.enum11_0 = Enum11.const_23;
                    return;

                case Enum37.const_10:
                    this.enum11_0 = Enum11.const_24;
                    return;

                case Enum37.const_11:
                    this.enum11_0 = Enum11.const_25;
                    return;

                case Enum37.const_12:
                    this.enum11_0 = Enum11.const_26;
                    return;

                case Enum37.const_13:
                    this.enum11_0 = Enum11.const_27;
                    return;

                case Enum37.const_14:
                    this.enum11_0 = Enum11.const_28;
                    return;

                case Enum37.const_15:
                    this.method_3();
                    return;

                case Enum37.const_16:
                    this.method_4();
                    return;

                case Enum37.const_17:
                    this.method_2();
                    return;

                case Enum37.const_18:
                    this.method_2();
                    return;

                case Enum37.const_19:
                    this.method_6();
                    return;

                case Enum37.const_20:
                    this.method_9();
                    return;

                case Enum37.const_21:
                    this.method_8();
                    return;

                case Enum37.const_22:
                    this.enum11_0 = Enum11.const_34;
                    return;

                case Enum37.const_23:
                    this.enum11_0 = Enum11.const_30;
                    return;

                case Enum37.const_24:
                    this.enum11_0 = Enum11.const_31;
                    return;

                case Enum37.const_26:
                    this.enum11_0 = Enum11.const_29;
                    return;

                case Enum37.const_27:
                    this.method_9();
                    return;

                case Enum37.const_28:
                    this.method_7();
                    return;

                case Enum37.const_29:
                    this.method_13();
                    return;

                case Enum37.const_30:
                    this.method_14();
                    return;

                case Enum37.const_34:
                    this.method_5();
                    return;
            }
            this.enum11_0 = Enum11.const_0;
        }

        private void method_2()
        {
            int num = this.class48_0.method_21();
            int num2 = num & 3;
            num = num >> 2;
            switch (num2)
            {
                case 0:
                    this.enum11_1 = Enum11.const_37;
                    this.enum11_0 = Enum11.const_36;
                    this.int_0 = num;
                    return;

                case 1:
                    this.enum11_1 = Enum11.const_39;
                    this.enum11_0 = Enum11.const_38;
                    this.int_0 = num;
                    return;
            }
            if (num2 != 2)
            {
                throw new Exception3();
            }
            this.enum11_0 = Enum11.const_40;
            this.int_0 = num;
        }

        private void method_3()
        {
            this.byte_0 = (byte) (this.byte_0 + 1);
            this.method_15();
        }

        private void method_4()
        {
            this.bool_1 = true;
            this.method_15();
        }

        private void method_5()
        {
            this.bool_0 = true;
            this.method_15();
        }

        private void method_6()
        {
            this.enum11_0 = Enum11.const_46;
            this.int_0 = this.class48_0.method_21();
        }

        private void method_7()
        {
            this.enum11_0 = Enum11.const_47;
            this.int_0 = this.class48_0.method_21();
        }

        private void method_8()
        {
            int num = this.class48_0.int_0;
            this.method_15();
            int num2 = this.class48_0.method_21();
            for (int i = 0; i < num2; i++)
            {
                this.method_15();
            }
            this.enum11_0 = Enum11.const_45;
            this.byte_1 = this.class48_0.method_20(num, this.class48_0.int_0 - num);
        }

        private void method_9()
        {
            this.int_1 = 0;
            this.enum11_1 = Enum11.const_0;
            this.class48_0.method_4(-1);
            int num = this.class48_0.int_0;
            switch (this.class48_0.method_8())
            {
                case 20:
                    this.method_11();
                    break;

                case 0x1d:
                    this.method_10();
                    break;
            }
            if (((this.int_1 == 1) && (this.enum11_0 != Enum11.const_45)) && ((this.enum11_0 != Enum11.const_46) && (this.enum11_0 != Enum11.const_47)))
            {
                this.enum11_0 = this.enum11_1;
            }
            else
            {
                this.enum11_0 = Enum11.const_41;
                this.byte_1 = this.class48_0.method_20(num, this.class48_0.int_0 - num);
            }
        }
    }
}

