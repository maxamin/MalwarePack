namespace ns0
{
    using System;
    using System.Collections;
    using System.Text;

    internal abstract class Class69 : Class68
    {
        private Class48 class48_3 = new Class48();
        private Class48 class48_4 = new Class48();
        private string string_30;
        private string string_31;
        private StringBuilder stringBuilder_1 = new StringBuilder(100);

        internal Class69()
        {
            this.stringBuilder_1.Length = 0;
            this.stringBuilder_1.Append(Class537.string_919);
            this.stringBuilder_1.Append(Class537.string_898);
            this.stringBuilder_1.Append(Class537.string_308);
            this.stringBuilder_1.Append(Class537.string_857);
            this.stringBuilder_1.Append(Class537.string_541);
            this.stringBuilder_1.Append(Class537.string_49);
            this.string_30 = this.stringBuilder_1.ToString();
            this.stringBuilder_1.Length = 0;
            this.stringBuilder_1.Append(Class537.string_556);
            this.stringBuilder_1.Append(Class537.string_857);
            this.stringBuilder_1.Append(Class537.string_919);
            this.stringBuilder_1.Append(Class537.string_898);
            this.stringBuilder_1.Append(Class537.string_556);
            this.stringBuilder_1.Append(Class537.string_857);
            this.stringBuilder_1.Append(Class537.string_308);
            this.stringBuilder_1.Append(Class537.string_857);
            this.stringBuilder_1.Append(Class537.string_541);
            this.stringBuilder_1.Append(Class537.string_49);
            this.string_31 = this.stringBuilder_1.ToString();
        }

        internal void method_164(Class550.Class514 A_1)
        {
            bool flag = Class516.Boolean_0;
            try
            {
                Class551.Class544 class4;
                switch (A_1.enum7_0)
                {
                    case Enum7.const_0:
                    {
                        Class547.Class528 class2 = Class546.class547_0.arrayList_0[A_1.int_0] as Class547.Class528;
                        Class548.Class529 class3 = (class2.class369_0.class369_0 as Class370).class529_0;
                        base.method_9(new Class336(this.method_165(base.method_51(class3))));
                        this.method_166(A_1.byte_0, class2);
                        goto Label_02A8;
                    }
                    case Enum7.const_1:
                    {
                        class4 = Class546.class551_0.arrayList_0[A_1.int_0] as Class551.Class544;
                        if (class4.enum9_0 != Enum9.const_2)
                        {
                            break;
                        }
                        Class552.Class545 class5 = Class546.class552_0.arrayList_0[class4.int_0] as Class552.Class545;
                        base.method_9(new Class336(this.method_165(base.method_56(class5.int_0))));
                        this.method_167(A_1.byte_0, class5);
                        goto Label_02A8;
                    }
                    case Enum7.const_2:
                    {
                        Class570.Class625 class8 = Class546.class570_0.arrayList_0[A_1.int_0] as Class570.Class625;
                        this.method_179(class8);
                        goto Label_02A8;
                    }
                    case Enum7.const_3:
                        if (!Class516.Boolean_0)
                        {
                            goto Label_01BF;
                        }
                        base.method_9(new Class336(Class537.string_292));
                        goto Label_02A8;

                    case Enum7.const_4:
                        base.method_9(Class626.class336_66);
                        goto Label_02A8;

                    case Enum7.const_5:
                        base.method_9(Class626.class336_67);
                        goto Label_02A8;

                    case Enum7.const_6:
                        if (!Class516.Boolean_0)
                        {
                            goto Label_0211;
                        }
                        base.method_9(new Class336(this.string_31));
                        goto Label_02A8;

                    case Enum7.const_7:
                        if (!Class516.Boolean_0)
                        {
                            goto Label_023D;
                        }
                        base.method_9(new Class336(Class537.string_68));
                        goto Label_02A8;

                    case Enum7.const_8:
                        if (!Class516.Boolean_0)
                        {
                            goto Label_0268;
                        }
                        base.method_9(new Class336(Class537.string_367));
                        goto Label_02A8;

                    case Enum7.const_9:
                        if (!Class516.Boolean_0)
                        {
                            goto Label_0293;
                        }
                        base.method_9(new Class336(Class537.string_260));
                        goto Label_02A8;

                    default:
                        goto Label_02A8;
                }
                if (class4.enum9_0 == Enum9.const_3)
                {
                    Class547.Class528 class6 = Class546.class547_0.arrayList_0[class4.int_0] as Class547.Class528;
                    Class548.Class529 class7 = (class6.class369_0.class369_0 as Class370).class529_0;
                    base.method_9(new Class336(this.method_165(base.method_51(class7))));
                    this.method_166(A_1.byte_0, class6);
                }
                goto Label_02A8;
            Label_01BF:
                base.method_9(new Class336(Class537.string_51));
                goto Label_02A8;
            Label_0211:
                base.method_9(new Class336(this.string_30));
                goto Label_02A8;
            Label_023D:
                base.method_9(new Class336(Class537.string_651));
                goto Label_02A8;
            Label_0268:
                base.method_9(new Class336(Class537.string_696));
                goto Label_02A8;
            Label_0293:
                base.method_9(new Class336(Class537.string_737));
            }
            catch
            {
            }
        Label_02A8:
            Class516.Boolean_0 = flag;
        }

        internal string method_165(string A_1)
        {
            if (A_1.EndsWith(Class537.string_658))
            {
                return A_1.Substring(0, A_1.Length - Class537.string_658.Length);
            }
            return A_1;
        }

        private void method_166(byte[] A_1, Class547.Class528 A_2)
        {
            this.class48_3.Byte_0 = A_1;
            bool flag = true;
            int num = A_2.short_2;
            if (num > 0)
            {
                ArrayList list = Class546.class568_0.arrayList_0;
                for (int j = 0; j < num; j++)
                {
                    if (flag)
                    {
                        base.method_9(Class518.class337_10);
                        flag = false;
                    }
                    if (j > 0)
                    {
                        base.method_9(Class518.class337_15);
                    }
                    Class568.Class623 class2 = list[A_2.int_6 + j] as Class568.Class623;
                    this.method_170(class2.enum11_0, class2.int_1);
                }
            }
            int num3 = this.class48_3.method_10();
            for (int i = 0; i < num3; i++)
            {
                if (flag)
                {
                    base.method_9(Class518.class337_10);
                    flag = false;
                }
                if ((i > 0) || (num > 0))
                {
                    base.method_9(Class518.class337_15);
                }
                this.class48_3.int_0++;
                Enum11 enum2 = this.method_168(this.class48_3);
                if (enum2 == Enum11.const_48)
                {
                    this.method_171();
                }
                else
                {
                    base.method_9(new Class336(this.class48_3.method_23(this.class48_3.method_21())));
                    base.method_9(Class518.class337_30);
                    this.method_170(enum2, 0);
                }
            }
            if (!flag)
            {
                base.method_9(Class518.class337_12);
            }
        }

        private void method_167(byte[] A_1, Class552.Class545 A_2)
        {
            this.class48_3.Byte_0 = A_1;
            bool flag = true;
            int num = A_2.short_0;
            if (num > 0)
            {
                ArrayList list = Class546.class569_0.arrayList_0;
                for (int j = 0; j < num; j++)
                {
                    if (flag)
                    {
                        base.method_9(Class518.class337_10);
                        flag = false;
                    }
                    if (j > 0)
                    {
                        base.method_9(Class518.class337_15);
                    }
                    Class569.Class624 class2 = list[A_2.int_3 + j] as Class569.Class624;
                    this.method_170(class2.enum11_0, class2.int_0);
                }
            }
            int num3 = this.class48_3.method_10();
            for (int i = 0; i < num3; i++)
            {
                if (flag)
                {
                    base.method_9(Class518.class337_10);
                    flag = false;
                }
                if ((i > 0) || (num > 0))
                {
                    base.method_9(Class518.class337_15);
                }
                this.class48_3.int_0++;
                Enum11 enum2 = this.method_168(this.class48_3);
                if (enum2 == Enum11.const_48)
                {
                    this.method_171();
                }
                else
                {
                    base.method_9(new Class336(this.class48_3.method_23(this.class48_3.method_21())));
                    base.method_9(Class518.class337_30);
                    this.method_170(enum2, 0);
                }
            }
            if (!flag)
            {
                base.method_9(Class518.class337_12);
            }
        }

        private Enum11 method_168(Class48 A_1)
        {
            switch (A_1.method_8())
            {
                case 2:
                    return Enum11.const_16;

                case 3:
                    return Enum11.const_17;

                case 4:
                    return Enum11.const_18;

                case 5:
                    return Enum11.const_19;

                case 6:
                    return Enum11.const_20;

                case 7:
                    return Enum11.const_21;

                case 8:
                    return Enum11.const_22;

                case 9:
                    return Enum11.const_23;

                case 10:
                    return Enum11.const_24;

                case 11:
                    return Enum11.const_25;

                case 12:
                    return Enum11.const_26;

                case 13:
                    return Enum11.const_27;

                case 14:
                    return Enum11.const_28;

                case 0x55:
                    return Enum11.const_48;
            }
            return Enum11.const_0;
        }

        private string method_169(string A_1)
        {
            int index = A_1.IndexOf(',');
            if (index == -1)
            {
                return A_1;
            }
            return A_1.Substring(0, index);
        }

        private void method_170(Enum11 A_1, int A_2)
        {
            string str;
            bool flag;
            bool flag2;
            Class548.Class529 class5;
            Class553.Class531 class6;
            int num5;
            switch (A_1)
            {
                case Enum11.const_1:
                    this.method_175(Enum11.const_16);
                    return;

                case Enum11.const_2:
                    this.method_175(Enum11.const_17);
                    return;

                case Enum11.const_3:
                    this.method_175(Enum11.const_18);
                    return;

                case Enum11.const_4:
                    this.method_175(Enum11.const_19);
                    return;

                case Enum11.const_5:
                    this.method_175(Enum11.const_20);
                    return;

                case Enum11.const_6:
                    this.method_175(Enum11.const_21);
                    return;

                case Enum11.const_7:
                    this.method_175(Enum11.const_22);
                    return;

                case Enum11.const_8:
                    this.method_175(Enum11.const_23);
                    return;

                case Enum11.const_9:
                    this.method_175(Enum11.const_24);
                    return;

                case Enum11.const_10:
                    this.method_175(Enum11.const_25);
                    return;

                case Enum11.const_11:
                    this.method_175(Enum11.const_26);
                    return;

                case Enum11.const_12:
                    this.method_175(Enum11.const_27);
                    return;

                case Enum11.const_13:
                    this.method_175(Enum11.const_28);
                    return;

                case Enum11.const_14:
                case Enum11.const_15:
                case Enum11.const_30:
                case Enum11.const_31:
                case Enum11.const_32:
                case Enum11.const_33:
                case Enum11.const_34:
                case Enum11.const_35:
                case Enum11.const_37:
                case Enum11.const_39:
                case Enum11.const_40:
                    return;

                case Enum11.const_16:
                    if (!this.class48_3.method_5())
                    {
                        this.QQYZ();
                        return;
                    }
                    this.QQYY();
                    return;

                case Enum11.const_17:
                {
                    char ch = this.class48_3.method_6();
                    this.QRUU(ch);
                    return;
                }
                case Enum11.const_18:
                    this.QRUW((int) this.class48_3.method_7());
                    return;

                case Enum11.const_19:
                    this.QRUW((int) this.class48_3.method_8());
                    return;

                case Enum11.const_20:
                    this.QRUW((int) this.class48_3.method_9());
                    return;

                case Enum11.const_21:
                    this.QRUW((int) this.class48_3.method_10());
                    return;

                case Enum11.const_22:
                    this.QRUW(this.class48_3.method_11());
                    return;

                case Enum11.const_23:
                    this.QRUW(this.class48_3.method_14());
                    return;

                case Enum11.const_24:
                    this.QRUW(this.class48_3.method_15());
                    return;

                case Enum11.const_25:
                    this.QRUW(this.class48_3.method_16());
                    return;

                case Enum11.const_26:
                    this.QRUW(this.class48_3.method_17());
                    return;

                case Enum11.const_27:
                    this.QRUW(this.class48_3.method_18());
                    return;

                case Enum11.const_28:
                    if (this.class48_3.method_8() != 0xff)
                    {
                        this.class48_3.int_0--;
                        this.QRSQ();
                        this.QRUV(this.class48_3.method_23(this.class48_3.method_21()));
                        this.QRSQ();
                        return;
                    }
                    this.QQZQ();
                    return;

                case Enum11.const_29:
                    if (this.class48_3.method_8() != 0x55)
                    {
                        this.class48_3.int_0--;
                        Enum11 enum3 = this.method_168(this.class48_3);
                        this.method_170(enum3, -1);
                        return;
                    }
                    str = this.method_172(this.class48_3.method_23(this.class48_3.method_21()));
                    flag = false;
                    flag2 = true;
                    class5 = null;
                    class6 = null;
                    num5 = 0;
                    if (!Class519.class394_0.class627_0.method_1(str, ref num5, ref class5))
                    {
                        if (Class519.class394_0.class627_0.method_2(str, ref num5, ref class6))
                        {
                            flag = true;
                            flag2 = false;
                        }
                        break;
                    }
                    flag = true;
                    break;

                case Enum11.const_36:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_2] as Class548.Class529;
                    if (!class2.Boolean_13)
                    {
                        base.method_9(Class585.smethod_0(this.class48_3.method_11()));
                        return;
                    }
                    long num2 = this.method_174(class2.class369_0 as Class373);
                    base.method_145(Enum0.const_2, A_2, num2, true);
                    return;
                }
                case Enum11.const_38:
                    if ((A_2 != Class519.class604_0.int_4) && (A_2 != Class519.class604_0.int_5))
                    {
                        if (A_2 == Class519.class604_0.int_1)
                        {
                            this.QQZQ();
                            return;
                        }
                        Class553.Class531 class3 = Class546.class553_0.arrayList_0[A_2] as Class553.Class531;
                        if (class3.Boolean_0)
                        {
                            Class564.Class618 class4 = Class546.class564_0.arrayList_0[class3.int_3] as Class564.Class618;
                            long num3 = this.method_173(class4.enum11_0);
                            base.method_145(Enum0.const_1, A_2, num3, true);
                            return;
                        }
                        base.method_9(Class585.smethod_0(this.class48_3.method_11()));
                        return;
                    }
                    this.QQZR();
                    base.method_9(Class518.class337_10);
                    base.method_9(new Class336(this.method_172(this.class48_3.method_23(this.class48_3.method_21()))));
                    base.method_9(Class518.class337_12);
                    return;

                case Enum11.const_41:
                    this.method_176(A_2);
                    return;

                default:
                    return;
            }
            if (flag)
            {
                if (flag2)
                {
                    Class373 class7 = class5.class369_0 as Class373;
                    if (class7 != null)
                    {
                        long num6 = this.method_174(class7);
                        base.method_145(Enum0.const_2, num5, num6, true);
                    }
                    else
                    {
                        long num7 = this.class48_3.method_11();
                        base.method_9(new Class336(num7.ToString()));
                    }
                }
                else if (class6.Boolean_0)
                {
                    ArrayList list = Class546.class564_0.arrayList_0;
                    Class564.Class618 class8 = list[class6.int_3] as Class564.Class618;
                    int num8 = (int) this.method_173(class8.enum11_0);
                    if (num8 != 0)
                    {
                        class8 = list[class6.int_3 + num8] as Class564.Class618;
                    }
                    base.method_9(new Class336(str));
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class336(Class519.class581_0[class8.int_0]));
                }
            }
        }

        private void method_171()
        {
            string str = this.method_172(this.class48_3.method_23(this.class48_3.method_21()));
            base.method_9(new Class336(this.class48_3.method_23(this.class48_3.method_21())));
            base.method_9(Class518.class337_30);
            bool flag = false;
            bool flag2 = true;
            Class548.Class529 class2 = null;
            Class553.Class531 class3 = null;
            int num = 0;
            if (Class519.class394_0.class627_0.method_1(str, ref num, ref class2))
            {
                flag = true;
            }
            else if (Class519.class394_0.class627_0.method_2(str, ref num, ref class3))
            {
                flag = true;
                flag2 = false;
            }
            bool flag3 = false;
            if (flag)
            {
                if (flag2)
                {
                    Class373 class4 = class2.class369_0 as Class373;
                    if (class4 != null)
                    {
                        long num2 = this.method_174(class4);
                        base.method_145(Enum0.const_2, num, num2, true);
                        flag3 = true;
                    }
                }
                else if (class3.Boolean_0)
                {
                    ArrayList list = Class546.class564_0.arrayList_0;
                    Class564.Class618 class5 = list[class3.int_3] as Class564.Class618;
                    int num3 = (int) this.method_173(class5.enum11_0);
                    if (num3 != 0)
                    {
                        class5 = list[class3.int_3 + num3] as Class564.Class618;
                    }
                    base.method_9(new Class336(str));
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class336(Class519.class581_0[class5.int_0]));
                    flag3 = true;
                }
            }
            if (!flag3)
            {
                int num4 = this.class48_3.method_11();
                base.method_9(Class518.class337_10);
                base.method_9(new Class336(str));
                base.method_9(Class518.class337_12);
                base.method_9(new Class336(num4.ToString()));
            }
        }

        private string method_172(string A_1)
        {
            this.stringBuilder_1.Length = 0;
            for (int i = 0; i < A_1.Length; i++)
            {
                if (A_1[i] == '+')
                {
                    this.stringBuilder_1.Append('.');
                }
                else
                {
                    if (A_1[i] == ',')
                    {
                        break;
                    }
                    this.stringBuilder_1.Append(A_1[i]);
                }
            }
            return this.stringBuilder_1.ToString();
        }

        private long method_173(Enum11 A_1)
        {
            switch (A_1)
            {
                case Enum11.const_18:
                    return (long) this.class48_3.method_7();

                case Enum11.const_19:
                    return (long) this.class48_3.method_8();

                case Enum11.const_20:
                    return (long) this.class48_3.method_9();

                case Enum11.const_21:
                    return (long) this.class48_3.method_10();

                case Enum11.const_22:
                    return (long) this.class48_3.method_11();

                case Enum11.const_23:
                    return (long) this.class48_3.method_14();

                case Enum11.const_24:
                    return this.class48_3.method_15();

                case Enum11.const_25:
                    return (long) this.class48_3.method_16();
            }
            throw new Exception0();
        }

        private long method_174(Class373 A_1)
        {
            byte num = A_1.byte_0;
            long num2 = 0L;
            if ((num & 0xfe) == 0)
            {
                return (long) this.class48_3.method_11();
            }
            if ((num & 2) != 0)
            {
                return (long) this.class48_3.method_8();
            }
            if ((num & 4) != 0)
            {
                return (long) this.class48_3.method_7();
            }
            if ((num & 8) != 0)
            {
                return (long) this.class48_3.method_9();
            }
            if ((num & 0x10) != 0)
            {
                return (long) this.class48_3.method_10();
            }
            if ((num & 0x20) != 0)
            {
                return (long) this.class48_3.method_14();
            }
            if ((num & 0x40) != 0)
            {
                return this.class48_3.method_15();
            }
            if ((num & 0x80) != 0)
            {
                num2 = (long) this.class48_3.method_16();
            }
            return num2;
        }

        private void method_175(Enum11 A_1)
        {
            this.QRRX();
            this.method_177(A_1);
            this.QQZZ();
            this.QRQQ();
            base.method_9(Class584.class342_0);
            base.method_9(Class518.class337_3);
            uint num = this.class48_3.method_14();
            for (int i = 0; i < num; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_15);
                }
                this.method_170(A_1, 0);
            }
            base.method_9(Class518.class337_5);
        }

        private void method_176(int A_1)
        {
            Class558.Class606 class2 = Class546.class558_0.arrayList_0[A_1] as Class558.Class606;
            this.class48_4.Byte_0 = class2.byte_0;
            this.class48_4.int_0++;
            Enum11 enum2 = this.method_168(this.class48_4);
            this.method_175(enum2);
        }

        private void method_177(Enum11 A_1)
        {
            switch (A_1)
            {
                case Enum11.const_16:
                    this.QQXT();
                    return;

                case Enum11.const_17:
                    this.QRUU();
                    return;

                case Enum11.const_18:
                    this.QQXV();
                    return;

                case Enum11.const_19:
                    this.QQXW();
                    return;

                case Enum11.const_20:
                    this.QQXX();
                    return;

                case Enum11.const_21:
                    this.QQXY();
                    return;

                case Enum11.const_22:
                    this.QQXZ();
                    return;

                case Enum11.const_23:
                    this.QQYQ();
                    return;

                case Enum11.const_24:
                    this.QQYR();
                    return;

                case Enum11.const_25:
                    this.QQYS();
                    return;

                case Enum11.const_26:
                    this.QQYT();
                    return;

                case Enum11.const_27:
                    this.QQYU();
                    return;

                case Enum11.const_28:
                    this.QRUV();
                    return;
            }
        }

        private Class336 method_178(byte A_1)
        {
            switch (A_1)
            {
                case 2:
                    return Class626.class336_0;

                case 3:
                    return Class626.class336_1;

                case 4:
                    return Class626.class336_2;

                case 5:
                    return Class626.class336_3;

                case 6:
                    return Class626.class336_4;

                case 7:
                    return Class626.class336_5;

                case 8:
                    return Class626.class336_6;

                case 9:
                    return Class626.class336_7;

                case 10:
                    return Class626.class336_8;

                case 11:
                    return Class626.class336_9;

                case 12:
                    return Class626.class336_10;

                case 15:
                    return Class626.class336_11;

                case 0x13:
                    return Class626.class336_12;

                case 20:
                    return Class626.class336_13;

                case 0x15:
                    return Class626.class336_14;

                case 0x16:
                    return Class626.class336_15;

                case 0x17:
                    return Class626.class336_16;

                case 0x19:
                    return Class626.class336_17;

                case 0x1a:
                    return Class626.class336_18;

                case 0x1b:
                    return Class626.class336_19;

                case 0x1c:
                    return Class626.class336_20;

                case 0x1d:
                    return Class626.class336_21;

                case 30:
                    return Class626.class336_22;

                case 0x1f:
                    return Class626.class336_23;

                case 0x20:
                    return Class626.class336_24;

                case 0x22:
                    return Class626.class336_25;

                case 0x23:
                    return Class626.class336_26;

                case 0x24:
                    return Class626.class336_27;

                case 0x25:
                    return Class626.class336_28;

                case 0x26:
                    return Class626.class336_29;

                case 40:
                    return Class626.class336_30;

                case 0x2a:
                    return Class626.class336_31;

                case 0x2b:
                    return Class626.class336_32;

                case 0x2c:
                    return Class626.class336_33;

                case 0x2d:
                    return Class626.class336_34;
            }
            return Class584.class336_0;
        }

        private void method_179(Class570.Class625 A_1)
        {
            switch (A_1.enum12_0)
            {
                case Enum12.const_0:
                    if (!Class516.Boolean_0)
                    {
                        base.method_9(Class626.class336_36);
                        break;
                    }
                    base.method_9(Class626.class336_35);
                    break;

                case Enum12.const_1:
                    if (!Class516.Boolean_0)
                    {
                        base.method_9(Class626.class336_43);
                    }
                    else
                    {
                        base.method_9(Class626.class336_42);
                    }
                    base.method_9(Class585.smethod_0(A_1.int_0));
                    base.method_9(Class518.class337_12);
                    return;

                case Enum12.const_2:
                    if (!Class516.Boolean_0)
                    {
                        base.method_9(Class626.class336_45);
                    }
                    else
                    {
                        base.method_9(Class626.class336_44);
                    }
                    base.method_9(this.method_178(A_1.byte_0));
                    if (A_1.int_0 > 0)
                    {
                        base.method_9(Class626.class336_46);
                        base.method_9(Class585.smethod_0(A_1.int_0));
                    }
                    base.method_9(Class518.class337_12);
                    return;

                case Enum12.const_3:
                    if (!Class516.Boolean_0)
                    {
                        base.method_9(Class626.class336_48);
                    }
                    else
                    {
                        base.method_9(Class626.class336_47);
                    }
                    this.QRSQ();
                    this.QRUV(Class519.class581_0[A_1.int_0]);
                    this.QRSQ();
                    if (A_1.int_1 > 0)
                    {
                        base.method_9(Class626.class336_49);
                        this.QRSS();
                        this.QRSQ();
                        base.method_9(new Class336(Class519.class581_0[A_1.int_1]));
                        this.QRSQ();
                    }
                    if (Class516.Boolean_0)
                    {
                        base.method_9(Class626.class336_50);
                        this.QRSS();
                        base.method_9(Class626.class336_52);
                    }
                    else
                    {
                        base.method_9(Class626.class336_51);
                        this.QRSS();
                        base.method_9(Class626.class336_53);
                    }
                    switch (A_1.enum14_0)
                    {
                        case Enum14.const_0:
                            base.method_9(Class626.class336_54);
                            break;

                        case Enum14.const_1:
                            base.method_9(Class626.class336_55);
                            break;

                        case Enum14.const_2:
                            base.method_9(Class626.class336_56);
                            break;

                        case Enum14.const_3:
                            base.method_9(Class626.class336_57);
                            break;

                        case Enum14.const_4:
                            base.method_9(Class626.class336_58);
                            break;
                    }
                    this.method_180(A_1);
                    if (A_1.bool_0)
                    {
                        base.method_9(Class626.class336_59);
                        this.QRSS();
                        this.QQYY();
                    }
                    base.method_9(Class518.class337_12);
                    return;

                default:
                    return;
            }
            switch (A_1.enum13_0)
            {
                case Enum13.const_1:
                    base.method_9(Class626.class336_38);
                    break;

                case Enum13.const_2:
                    base.method_9(Class626.class336_37);
                    break;

                default:
                    base.method_9(Class626.class336_39);
                    break;
            }
            this.method_180(A_1);
            if (A_1.int_0 > 0)
            {
                base.method_9(Class626.class336_40);
                this.QRSS();
                base.method_9(Class585.smethod_0(A_1.int_0));
            }
            if (A_1.int_1 > 0)
            {
                base.method_9(Class626.class336_41);
                this.QRSS();
                base.method_9(Class585.smethod_0(A_1.int_1));
            }
            base.method_9(Class518.class337_12);
        }

        private void method_180(Class570.Class625 A_1)
        {
            if (Class516.Boolean_0)
            {
                base.method_9(Class626.class336_60);
                this.QRSS();
                base.method_9(Class626.class336_62);
            }
            else
            {
                base.method_9(Class626.class336_61);
                this.QRSS();
                base.method_9(Class626.class336_63);
            }
            switch (A_1.enum15_0)
            {
                case Enum15.const_0:
                    base.method_9(Class626.class336_39);
                    return;

                case Enum15.const_1:
                    base.method_9(Class626.class336_64);
                    return;

                case Enum15.const_2:
                    base.method_9(Class626.class336_65);
                    return;
            }
        }
    }
}

