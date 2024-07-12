namespace ns0
{
    using System;
    using System.Text;

    internal abstract class Class66 : Class65
    {
        private Class48 class48_2 = new Class48();
        private Class608 class608_1;
        private static string string_12 = Class537.string_431;
        private static string string_13 = Class537.string_465;
        private static string string_14 = Class537.string_58;
        private static string string_15 = Class617.String_0;
        private static string string_16 = Class537.string_61;
        private static string string_17 = Class537.string_217;
        private static string string_18 = Class617.String_4;
        private static string string_19 = Class537.string_529;
        private static string string_20 = Class617.String_5;
        private static string string_21 = Class537.string_502;
        private static string string_22 = Class617.String_3;
        private static string string_23 = Class617.String_1;
        private static string string_24 = Class617.String_7;
        private static string string_25 = Class537.string_389;
        private static string string_26 = Class537.string_128;
        private static string string_27 = Class537.string_125;
        private static string string_28 = Class537.string_739;
        private static string string_29 = Class537.string_32;
        private StringBuilder stringBuilder_0 = new StringBuilder();

        internal Class66()
        {
            this.class608_1 = new Class608(this.class48_2);
        }

        internal string method_131(Enum11 A_1, int A_2)
        {
            switch (A_1)
            {
                case Enum11.const_1:
                    return string_12;

                case Enum11.const_2:
                    return string_13;

                case Enum11.const_3:
                    return string_14;

                case Enum11.const_4:
                    return string_15;

                case Enum11.const_5:
                    return string_16;

                case Enum11.const_6:
                    return string_17;

                case Enum11.const_7:
                    return string_18;

                case Enum11.const_8:
                    return string_19;

                case Enum11.const_9:
                    return string_20;

                case Enum11.const_10:
                    return string_21;

                case Enum11.const_11:
                    return string_22;

                case Enum11.const_12:
                    return string_23;

                case Enum11.const_13:
                    return string_24;

                case Enum11.const_14:
                    return string_26;

                case Enum11.const_16:
                    return string_12;

                case Enum11.const_17:
                    return string_13;

                case Enum11.const_18:
                    return string_14;

                case Enum11.const_19:
                    return string_15;

                case Enum11.const_20:
                    return string_16;

                case Enum11.const_21:
                    return string_17;

                case Enum11.const_22:
                    return string_18;

                case Enum11.const_23:
                    return string_19;

                case Enum11.const_24:
                    return string_20;

                case Enum11.const_25:
                    return string_21;

                case Enum11.const_26:
                    return string_22;

                case Enum11.const_27:
                    return string_23;

                case Enum11.const_28:
                    return string_24;

                case Enum11.const_29:
                    return string_26;

                case Enum11.const_30:
                    return string_27;

                case Enum11.const_31:
                    return string_28;

                case Enum11.const_32:
                    return string_27;

                case Enum11.const_33:
                    return string_28;

                case Enum11.const_34:
                    return string_29;

                case Enum11.const_35:
                    return string_29;

                case Enum11.const_36:
                    return this.method_133(A_2);

                case Enum11.const_37:
                    return this.method_133(A_2);

                case Enum11.const_38:
                    return this.method_134(A_2);

                case Enum11.const_39:
                    return this.method_134(A_2);

                case Enum11.const_41:
                    return this.method_138(A_2);

                case Enum11.const_45:
                    return this.method_135(A_2);

                case Enum11.const_46:
                    return this.method_136(A_2);

                case Enum11.const_47:
                    return this.method_137(A_2);
            }
            return string.Empty;
        }

        internal string method_132(string A_1)
        {
            this.stringBuilder_0.Length = 0;
            int num = A_1.Length - 1;
            while (A_1[num] != '.')
            {
                num--;
                if (num <= 0)
                {
                    break;
                }
            }
            if (num > 0)
            {
                this.stringBuilder_0.Append(A_1, num + 1, (A_1.Length - num) - 1);
            }
            else
            {
                this.stringBuilder_0.Append(A_1);
            }
            char c = this.stringBuilder_0[0];
            this.stringBuilder_0[0] = char.ToLower(c);
            for (int i = 1; i < this.stringBuilder_0.Length; i++)
            {
                c = this.stringBuilder_0[i];
                if (!char.IsUpper(c))
                {
                    break;
                }
                this.stringBuilder_0[i] = char.ToLower(c);
            }
            string name = this.stringBuilder_0.ToString();
            if (this.QRUR(name))
            {
                return (name + "_");
            }
            return name;
        }

        private string method_133(int A_1)
        {
            Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_1] as Class548.Class529;
            return this.method_132(base.method_51(class2));
        }

        private string method_134(int A_1)
        {
            if (A_1 == Class519.class604_0.int_2)
            {
                return string_25;
            }
            Class553.Class531 class2 = Class546.class553_0.arrayList_0[A_1] as Class553.Class531;
            return this.method_132(base.method_55(class2));
        }

        internal string method_135(int A_1)
        {
            Class563.Class616 class2 = Class546.class563_0.arrayList_0[A_1] as Class563.Class616;
            this.class48_2.Byte_0 = class2.byte_0;
            this.class608_1.method_0();
            return this.method_131(this.class608_1.enum11_0, this.class608_1.int_0);
        }

        internal string method_136(int A_1)
        {
            return this.method_132(Class519.class529_1.class369_0.QQWV(A_1));
        }

        internal string method_137(int A_1)
        {
            Class559.Class607 class2 = Class546.class559_0.arrayList_0[Class519.class528_1.int_2 + A_1] as Class559.Class607;
            return this.method_132(Class519.class581_0[class2.int_0]);
        }

        private string method_138(int A_1)
        {
            Class558.Class606 class2 = Class546.class558_0.arrayList_0[A_1] as Class558.Class606;
            this.class48_2.Byte_0 = class2.byte_0;
            this.class48_2.method_8();
            return this.method_139();
        }

        private string method_139()
        {
            switch (this.class48_2.method_8())
            {
                case 2:
                    return string_12;

                case 3:
                    return string_13;

                case 4:
                    return string_14;

                case 5:
                    return string_15;

                case 6:
                    return string_16;

                case 7:
                    return string_17;

                case 8:
                    return string_18;

                case 9:
                    return string_19;

                case 10:
                    return string_20;

                case 11:
                    return string_21;

                case 12:
                    return string_22;

                case 13:
                    return string_23;

                case 14:
                    return string_24;

                case 0x11:
                    return this.method_140();

                case 0x12:
                    return this.method_140();

                case 20:
                    return this.method_139();

                case 0x15:
                    return this.method_142();

                case 0x16:
                    return string_29;

                case 0x18:
                    return string_27;

                case 0x19:
                    return string_28;

                case 0x1c:
                    return string_26;

                case 0x1d:
                    return this.method_139();

                case 30:
                    return this.method_141();
            }
            return string.Empty;
        }

        private string method_140()
        {
            int num = this.class48_2.method_21();
            int num2 = num & 3;
            num = num >> 2;
            if (num2 == 0)
            {
                Class548.Class529 class2 = Class546.class548_0.arrayList_0[num] as Class548.Class529;
                return this.method_132(base.method_51(class2));
            }
            if (num2 != 1)
            {
                return string.Empty;
            }
            if (num == Class519.class604_0.int_2)
            {
                return string_25;
            }
            Class553.Class531 class3 = Class546.class553_0.arrayList_0[num] as Class553.Class531;
            return this.method_132(base.method_55(class3));
        }

        private string method_141()
        {
            int num = this.class48_2.method_21();
            Class559.Class607 class2 = Class546.class559_0.arrayList_0[Class519.class528_1.int_2 + num] as Class559.Class607;
            return this.method_132(Class519.class581_0[class2.int_0]);
        }

        private string method_142()
        {
            this.class608_1.method_0();
            if (this.class608_1.enum11_0 == Enum11.const_36)
            {
                return this.method_133(this.class608_1.int_0);
            }
            if (this.class608_1.enum11_0 == Enum11.const_38)
            {
                return this.method_134(this.class608_1.int_0);
            }
            return string.Empty;
        }
    }
}

