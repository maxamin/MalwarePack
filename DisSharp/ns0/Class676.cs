namespace ns0
{
    using System;
    using System.Collections;

    internal class Class676 : Class675
    {
        private Class48 class48_1;
        private Class558.Class606 class606_0;
        private Class608 class608_0;

        internal void method_109()
        {
            this.class48_1 = new Class48();
            this.class608_0 = new Class608(this.class48_1);
            ArrayList list = base.class558_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                this.class606_0 = list[i] as Class558.Class606;
                try
                {
                    this.class48_1.Byte_0 = this.class606_0.byte_0;
                    this.method_110();
                }
                catch
                {
                }
            }
        }

        private void method_110()
        {
            switch (this.class48_1.method_8())
            {
                case 20:
                    this.method_112();
                    return;

                case 0x1d:
                    this.method_111();
                    break;
            }
        }

        private void method_111()
        {
            this.method_113();
        }

        private void method_112()
        {
            this.method_113();
        }

        private void method_113()
        {
            switch (this.class48_1.method_8())
            {
                case 2:
                    this.class606_0.enum11_0 = Enum11.const_16;
                    return;

                case 3:
                    this.class606_0.enum11_0 = Enum11.const_17;
                    return;

                case 4:
                    this.class606_0.enum11_0 = Enum11.const_18;
                    return;

                case 5:
                    this.class606_0.enum11_0 = Enum11.const_19;
                    return;

                case 6:
                    this.class606_0.enum11_0 = Enum11.const_20;
                    return;

                case 7:
                    this.class606_0.enum11_0 = Enum11.const_21;
                    return;

                case 8:
                    this.class606_0.enum11_0 = Enum11.const_22;
                    return;

                case 9:
                    this.class606_0.enum11_0 = Enum11.const_23;
                    return;

                case 10:
                    this.class606_0.enum11_0 = Enum11.const_24;
                    return;

                case 11:
                    this.class606_0.enum11_0 = Enum11.const_25;
                    return;

                case 12:
                    this.class606_0.enum11_0 = Enum11.const_26;
                    return;

                case 13:
                    this.class606_0.enum11_0 = Enum11.const_27;
                    return;

                case 14:
                    this.class606_0.enum11_0 = Enum11.const_28;
                    return;

                case 15:
                case 0x10:
                case 0x17:
                case 0x1a:
                case 0x1b:
                    break;

                case 0x11:
                    this.method_114();
                    return;

                case 0x12:
                    this.method_114();
                    return;

                case 0x13:
                    this.class606_0.enum11_0 = Enum11.const_46;
                    return;

                case 20:
                    this.method_112();
                    return;

                case 0x15:
                    this.class606_0.enum11_0 = Enum11.const_45;
                    return;

                case 0x16:
                    this.class606_0.enum11_0 = Enum11.const_34;
                    return;

                case 0x18:
                    this.class606_0.enum11_0 = Enum11.const_30;
                    return;

                case 0x19:
                    this.class606_0.enum11_0 = Enum11.const_31;
                    return;

                case 0x1c:
                    this.class606_0.enum11_0 = Enum11.const_29;
                    return;

                case 0x1d:
                    this.method_111();
                    return;

                case 30:
                    this.class606_0.enum11_0 = Enum11.const_47;
                    break;

                default:
                    return;
            }
        }

        private void method_114()
        {
            int num = this.class48_1.method_21();
            int num2 = num & 3;
            num = num >> 2;
            switch (num2)
            {
                case 0:
                    this.class606_0.enum11_0 = Enum11.const_36;
                    this.class606_0.int_0 = num;
                    return;

                case 1:
                    this.class606_0.enum11_0 = Enum11.const_38;
                    this.class606_0.int_0 = num;
                    break;
            }
        }
    }
}

