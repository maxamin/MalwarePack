namespace ns0
{
    using System;
    using System.Collections;

    internal class Class661 : Class660
    {
        private byte byte_0;
        private static string string_10 = Class537.string_415;
        private static string string_11 = Class537.string_411;
        private static string string_12 = Class537.string_638;
        private static string string_13 = Class537.string_305;
        private static string string_14 = Class537.string_5;
        private static string string_15 = Class537.string_6;
        private static string string_16 = Class537.string_226;
        private static string string_17 = Class537.string_255;
        private static string string_18 = Class537.string_675;
        private static string string_19 = Class537.string_214;
        private static string string_20 = Class537.string_121;
        private static string string_21 = Class537.string_326;
        private static string string_22 = Class537.string_937;
        private static string string_23 = Class537.string_461;
        private static string string_24 = Class537.string_246;
        private static string string_25 = Class537.string_921;
        private static string string_26 = Class537.string_607;
        private static string string_27 = Class537.string_270;
        private static string string_28 = Class537.string_223;
        private static string string_29 = Class537.string_556;
        private static string string_3 = Class537.string_833;
        private static string string_30 = Class537.string_610;
        private static string string_31 = Class537.string_817;
        private static string string_32 = Class537.string_686;
        private static string string_33 = Class537.string_231;
        private static string string_34 = Class537.string_410;
        private static string string_35 = Class537.string_888;
        private static string string_36 = Class537.string_381;
        private static string string_37 = Class537.string_652;
        private static string string_38 = Class537.string_630;
        private static string string_4 = Class537.string_65;
        private static string string_5 = Class537.string_450;
        private static string string_6 = Class537.string_407;
        private static string string_7 = Class537.string_1;
        private static string string_8 = Class537.string_259;
        private static string string_9 = Class537.string_866;

        internal void method_34()
        {
            this.method_35();
            this.method_36();
            this.method_38();
            this.method_39();
            this.method_40();
            this.method_41();
            base.class684_0.class562_0.method_1();
            base.class684_0.class562_0.method_2();
        }

        private void method_35()
        {
            this.byte_0 = 1;
            ArrayList list = base.class684_0.class553_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class553.Class531 class2 = list[i] as Class553.Class531;
                string str = base.method_2(class2.int_1);
                string str2 = base.method_2(class2.int_2);
                this.method_37(i, str, str2);
                class2.int_1 = base.class581_0.method_0(str);
                class2.int_2 = base.class684_0.class562_0.method_0(str2, false);
            }
        }

        private void method_36()
        {
            this.byte_0 = 2;
            bool flag = base.class394_0.bool_2;
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class548.Class529 class2 = list[i] as Class548.Class529;
                string str = base.method_2(class2.int_1);
                string str2 = base.method_2(class2.int_2);
                if (flag)
                {
                    this.method_37(i, str, str2);
                }
                class2.int_1 = base.class581_0.method_0(str);
                class2.int_2 = base.class684_0.class562_0.method_0(str2, true);
            }
        }

        private void method_37(int A_1, string A_2, string A_3)
        {
            if (A_2.Length != 0)
            {
                switch (A_2[0])
                {
                    case 'B':
                        if ((A_2 != string_11) || (A_3 != string_3))
                        {
                            if ((A_2 == string_12) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_19, Class613.class339_9);
                            }
                            return;
                        }
                        base.class604_0.method_0(this.byte_0, A_1, Enum11.const_16, Class613.class339_6);
                        return;

                    case 'C':
                        if ((A_2 != string_10) || (A_3 != string_3))
                        {
                            if ((A_2 == string_13) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_17, Class613.class339_15);
                            }
                            return;
                        }
                        base.class604_0.int_12 = A_1;
                        return;

                    case 'D':
                        if ((A_2 != string_9) || (A_3 != string_3))
                        {
                            if ((A_2 == string_14) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_27, Class613.class339_29);
                                return;
                            }
                            if ((A_2 == string_15) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_44, Class613.class339_23);
                                base.class604_0.int_2 = A_1;
                                base.class604_0.uint_2 = Class689.smethod_1(this.byte_0, A_1);
                                return;
                            }
                            if ((A_2 == string_32) && (A_3 == string_31))
                            {
                                base.class604_0.int_14 = A_1;
                            }
                            return;
                        }
                        base.class604_0.int_11 = A_1;
                        return;

                    case 'E':
                        if ((A_2 == string_16) && (A_3 == string_3))
                        {
                            base.class604_0.int_5 = A_1;
                        }
                        return;

                    case 'F':
                    case 'G':
                    case 'H':
                    case 'J':
                    case 'K':
                    case 'L':
                    case 'N':
                    case 'P':
                    case 'Q':
                        return;

                    case 'I':
                        if ((A_2 != string_6) || (A_3 != string_3))
                        {
                            if ((A_2 == string_7) && (A_3 == string_4))
                            {
                                base.class604_0.int_9 = A_1;
                                return;
                            }
                            if ((A_2 == string_19) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_22, Class613.class339_61);
                                return;
                            }
                            if ((A_2 == string_18) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_20, Class613.class339_108);
                                return;
                            }
                            if ((A_2 == string_20) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_24, Class613.class339_71);
                            }
                            return;
                        }
                        base.class604_0.int_8 = A_1;
                        return;

                    case 'M':
                        if ((A_2 != string_37) || (A_3 != string_3))
                        {
                            if ((A_2 == string_8) && (A_3 == string_5))
                            {
                                base.class604_0.int_10 = A_1;
                            }
                            return;
                        }
                        base.class604_0.int_7 = A_1;
                        return;

                    case 'O':
                        if ((A_2 == string_21) && (A_3 == string_3))
                        {
                            base.class604_0.method_0(this.byte_0, A_1, Enum11.const_29, Class613.class339_78);
                            base.class604_0.int_1 = A_1;
                            base.class604_0.uint_1 = Class689.smethod_1(this.byte_0, A_1);
                        }
                        return;

                    case 'R':
                        if ((A_2 == string_30) && (A_3 == string_29))
                        {
                            base.class604_0.int_13 = A_1;
                        }
                        return;

                    case 'S':
                        if ((A_2 != string_22) || (A_3 != string_3))
                        {
                            if ((A_2 == string_23) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_26, Class613.class339_45);
                                return;
                            }
                            if ((A_2 == string_24) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_18, Class613.class339_103);
                            }
                            return;
                        }
                        base.class604_0.method_0(this.byte_0, A_1, Enum11.const_28, Class613.class339_115);
                        base.class604_0.int_3 = A_1;
                        return;

                    case 'T':
                        if ((A_2 == string_28) && (A_3 == string_3))
                        {
                            base.class604_0.int_4 = A_1;
                        }
                        return;

                    case 'U':
                        if ((A_2 != string_26) || (A_3 != string_3))
                        {
                            if ((A_2 == string_25) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_21, Class613.class339_134);
                                return;
                            }
                            if ((A_2 == string_27) && (A_3 == string_3))
                            {
                                base.class604_0.method_0(this.byte_0, A_1, Enum11.const_25, Class613.class339_129);
                            }
                            return;
                        }
                        base.class604_0.method_0(this.byte_0, A_1, Enum11.const_23, Class613.class339_127);
                        return;

                    case 'V':
                        if ((A_2 == string_17) && (A_3 == string_3))
                        {
                            base.class604_0.int_6 = A_1;
                        }
                        return;
                }
            }
        }

        private void method_38()
        {
            ArrayList list = base.class684_0.class549_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class549.Class530 class2 = list[i] as Class549.Class530;
                class2.int_1 = base.method_4(class2.int_1);
            }
        }

        private void method_39()
        {
            ArrayList list = base.class684_0.class547_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class547.Class528 class2 = list[i] as Class547.Class528;
                string str = base.method_2(class2.int_1);
                char ch = str[0];
                if ((ch == '.') && (str == string_38))
                {
                    class2.method_2();
                }
                class2.int_1 = base.method_6(ref str);
            }
        }

        private void method_40()
        {
            ArrayList list = base.class684_0.class568_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class568.Class623 class2 = list[i] as Class568.Class623;
                class2.int_0 = base.method_4(class2.int_0);
            }
        }

        private void method_41()
        {
            ArrayList list = base.class684_0.class554_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class554.Class532 class2 = list[i] as Class554.Class532;
                class2.int_0 = base.method_4(class2.int_0);
            }
        }
    }
}

