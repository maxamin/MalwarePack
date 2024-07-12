namespace ns0
{
    using System;

    internal abstract class Class65 : Class64
    {
        private Class397 class397_1;
        private Class397 class397_2;
        private Class48 class48_1 = new Class48();
        private Class602 class602_1;
        private Class608 class608_0;
        private int int_3;
        private int int_4 = 20;
        private int int_5;
        private Struct0[] struct0_0 = new Struct0[20];

        internal Class65()
        {
            this.class608_0 = new Class608(this.class48_1);
            this.class602_1 = new Class602();
            this.method_118();
            this.method_125();
        }

        private void method_100(int A_1)
        {
            this.method_101(A_1);
            base.method_9(Class584.class342_0);
        }

        private void method_101(int A_1)
        {
            Class559.Class607 class2 = Class546.class559_0.arrayList_0[Class519.class528_1.int_2 + A_1] as Class559.Class607;
            if (class2 != null)
            {
                base.method_9(new Class351(class2.int_0));
            }
        }

        private void method_102(int A_1, bool A_2)
        {
            Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_1] as Class548.Class529;
            base.method_48(class2);
            if (A_2)
            {
                base.method_9(Class584.class342_0);
            }
        }

        private void method_103(int A_1, bool A_2)
        {
            Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_1] as Class548.Class529;
            base.method_48(class2);
            this.method_113(A_2);
        }

        private void method_104(int A_1, bool A_2)
        {
            if (A_1 == Class519.class604_0.int_2)
            {
                if (A_2)
                {
                    this.QRRW();
                }
                else
                {
                    this.QQYX();
                }
            }
            else
            {
                Class553.Class531 class2 = Class546.class553_0.arrayList_0[A_1] as Class553.Class531;
                base.method_53(class2);
                if (A_2)
                {
                    base.method_9(Class584.class342_0);
                }
            }
        }

        private void method_105(int A_1, bool A_2)
        {
            if (A_1 == Class519.class604_0.int_2)
            {
                this.QRRW();
            }
            else
            {
                Class553.Class531 class2 = Class546.class553_0.arrayList_0[A_1] as Class553.Class531;
                base.method_53(class2);
            }
            this.method_113(A_2);
        }

        private void method_106(bool A_1)
        {
            if (Class516.Boolean_0)
            {
                this.QQZU();
            }
            else
            {
                this.QQZT();
            }
            if (A_1)
            {
                base.method_9(Class584.class342_0);
            }
        }

        private void method_107(bool A_1)
        {
            if (Class516.Boolean_0)
            {
                this.QQZU();
            }
            else
            {
                this.QQZT();
            }
            this.method_113(A_1);
        }

        private void method_108(bool A_1)
        {
            if (Class516.Boolean_0)
            {
                this.QQZW();
            }
            else
            {
                this.QQZV();
            }
            if (A_1)
            {
                base.method_9(Class584.class342_0);
            }
        }

        private void method_109(bool A_1)
        {
            if (Class516.Boolean_0)
            {
                this.QQZW();
            }
            else
            {
                this.QQZV();
            }
            this.method_113(A_1);
        }

        private void method_110(bool A_1)
        {
            if (Class516.Boolean_0)
            {
                this.QQZY();
            }
            else
            {
                this.QQZX();
            }
            if (A_1)
            {
                base.method_9(Class584.class342_0);
            }
        }

        private void method_111(bool A_1)
        {
            if (Class516.Boolean_0)
            {
                this.QQZY();
            }
            else
            {
                this.QQZX();
            }
            this.method_113(A_1);
        }

        private void method_112(int A_1)
        {
            Class561.Class611 class2 = Class546.class561_0.arrayList_0[A_1] as Class561.Class611;
            this.method_92(class2.enum11_0, class2.int_0, 0);
        }

        private void method_113(bool A_1)
        {
            base.method_9(this.QRTZ());
            base.method_9(this.QRUQ());
            if (A_1)
            {
                base.method_9(Class584.class342_0);
            }
        }

        private void method_114(int A_1, bool A_2)
        {
            Class558.Class606 class2 = Class546.class558_0.arrayList_0[A_1] as Class558.Class606;
            this.class48_1.Byte_0 = class2.byte_0;
            this.class602_1.method_0();
            switch (this.class48_1.method_8())
            {
                case 20:
                    this.method_116();
                    break;

                case 0x1d:
                    this.method_115();
                    break;
            }
            int num2 = this.class602_1.Int32_0 - 1;
            base.method_3(this.class602_1[num2]);
            for (int i = 0; i < num2; i++)
            {
                base.method_3(this.class602_1[i]);
            }
            if (A_2)
            {
                base.method_9(Class584.class342_0);
            }
        }

        private void method_115()
        {
            int num = this.class602_1.method_1();
            this.method_117();
            this.class602_1.method_2(num, this.QRTZ());
            this.class602_1.method_2(num, this.QRUQ());
        }

        private void method_116()
        {
            int num = this.class602_1.method_1();
            this.method_117();
            int num2 = this.class48_1.method_21();
            int num3 = num2 - 1;
            int num4 = this.class48_1.method_21();
            for (int i = 0; i < num4; i++)
            {
                this.class48_1.method_21();
            }
            int num6 = this.class48_1.method_21();
            for (int j = 0; j < num6; j++)
            {
                this.class48_1.method_21();
            }
            this.class602_1.method_2(num, this.QRTZ());
            for (int k = 0; k < num2; k++)
            {
                if (k < num3)
                {
                    this.class602_1.method_2(num, Class518.class337_14);
                }
            }
            this.class602_1.method_2(num, this.QRUQ());
        }

        private void method_117()
        {
            int num = this.class602_1.method_1();
            switch (this.class48_1.method_8())
            {
                case 2:
                    this.class602_1.method_2(num, this.QRST());
                    return;

                case 3:
                    this.class602_1.method_2(num, this.QRSU());
                    return;

                case 4:
                    this.class602_1.method_2(num, this.QRSV());
                    return;

                case 5:
                    this.class602_1.method_2(num, this.QRSW());
                    return;

                case 6:
                    this.class602_1.method_2(num, this.QRSX());
                    return;

                case 7:
                    this.class602_1.method_2(num, this.QRSY());
                    return;

                case 8:
                    this.class602_1.method_2(num, this.QRSZ());
                    return;

                case 9:
                    this.class602_1.method_2(num, this.QRTQ());
                    return;

                case 10:
                    this.class602_1.method_2(num, this.QRTR());
                    return;

                case 11:
                    this.class602_1.method_2(num, this.QRTS());
                    return;

                case 12:
                    this.class602_1.method_2(num, this.QRTT());
                    return;

                case 13:
                    this.class602_1.method_2(num, this.QRTU());
                    return;

                case 14:
                    this.class602_1.method_2(num, this.QRTV());
                    return;

                case 15:
                case 0x10:
                case 0x17:
                case 0x1a:
                case 0x1b:
                    break;

                case 0x11:
                    this.method_119();
                    return;

                case 0x12:
                    this.method_119();
                    return;

                case 0x13:
                    this.method_123();
                    return;

                case 20:
                    this.method_116();
                    return;

                case 0x15:
                    this.method_126();
                    return;

                case 0x16:
                    this.method_122();
                    return;

                case 0x18:
                    this.method_120();
                    return;

                case 0x19:
                    this.method_121();
                    return;

                case 0x1c:
                    this.class602_1.method_2(num, this.QRTW());
                    return;

                case 0x1d:
                    this.method_115();
                    return;

                case 30:
                    this.method_124();
                    break;

                default:
                    return;
            }
        }

        internal void method_118()
        {
            this.class397_1 = new Class397();
            this.class397_1.method_8();
        }

        private void method_119()
        {
            int num = this.class602_1.method_1();
            int num2 = this.class48_1.method_21();
            int num3 = num2 & 3;
            num2 = num2 >> 2;
            switch (num3)
            {
                case 0:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[num2] as Class548.Class529;
                    this.class397_1.Class367_0.method_5();
                    Class612.smethod_0(this.class397_1, class2);
                    this.class602_1.method_3(num, this.class397_1.Class367_0);
                    return;
                }
                case 1:
                {
                    if (num2 == Class519.class604_0.int_2)
                    {
                        this.class602_1.method_2(num, Class613.class339_23);
                        return;
                    }
                    Class553.Class531 class3 = Class546.class553_0.arrayList_0[num2] as Class553.Class531;
                    this.class397_1.Class367_0.method_5();
                    Class612.smethod_5(this.class397_1, class3);
                    this.class602_1.method_3(num, this.class397_1.Class367_0);
                    break;
                }
            }
        }

        private void method_120()
        {
            int num = this.class602_1.method_1();
            if (Class516.Boolean_0)
            {
                this.class602_1.method_2(num, Class615.class336_0);
            }
            else
            {
                this.class602_1.method_2(num, Class615.class336_1);
            }
        }

        private void method_121()
        {
            int num = this.class602_1.method_1();
            if (Class516.Boolean_0)
            {
                this.class602_1.method_2(num, Class615.class336_2);
            }
            else
            {
                this.class602_1.method_2(num, Class615.class336_3);
            }
        }

        private void method_122()
        {
            int num = this.class602_1.method_1();
            if (Class516.Boolean_0)
            {
                this.class602_1.method_2(num, Class615.class336_4);
            }
            else
            {
                this.class602_1.method_2(num, Class615.class336_5);
            }
        }

        private void method_123()
        {
            int num = this.class602_1.method_1();
            int num2 = this.class48_1.method_21();
            if (base.bool_0)
            {
                this.class602_1.method_2(num, Class518.class337_27);
                this.class602_1.method_2(num, Class585.smethod_0(num2));
            }
            else
            {
                Class335 class2 = Class519.class529_1.class369_0.QQWW(num2);
                this.class602_1.method_2(num, class2);
            }
        }

        private void method_124()
        {
            int num = this.class602_1.method_1();
            int num2 = this.class48_1.method_21();
            if (base.bool_0)
            {
                this.class602_1.method_2(num, Class518.class337_28);
                this.class602_1.method_2(num, Class585.smethod_0(num2));
            }
            else
            {
                Class559.Class607 class2 = Class546.class559_0.arrayList_0[Class519.class528_1.int_2 + num2] as Class559.Class607;
                this.class602_1.method_2(num, new Class351(class2.int_0));
            }
        }

        internal void method_125()
        {
            this.class397_2 = new Class397();
            this.class397_2.method_8();
        }

        private void method_126()
        {
            this.class608_0.method_0();
            Enum11 enum2 = this.class608_0.enum11_0;
            int num = this.class608_0.int_0;
            this.method_129();
            int num2 = this.class48_1.method_21();
            for (int i = 0; i < num2; i++)
            {
                this.class608_0.method_0();
                this.method_130(this.class608_0.enum11_0, this.class608_0.int_0, this.class608_0.byte_0);
            }
            this.int_5 = this.class602_1.method_1();
            this.method_127(enum2, num, this.int_3, 0);
        }

        private void method_127(Enum11 A_1, int A_2, int A_3, int A_4)
        {
            if (A_1 == Enum11.const_36)
            {
                Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_2] as Class548.Class529;
                Class370 class3 = class2.class369_0.class369_0 as Class370;
                if (class3 != null)
                {
                    this.method_127(Enum11.const_36, class3.class529_0.int_0, A_3 - class2.short_0, A_4 + 1);
                }
                else
                {
                    Class562 class4 = Class546.class562_0;
                    if (Class516.Boolean_0)
                    {
                        Class562.Class533 class5 = class4.arrayList_0[class2.int_2] as Class562.Class533;
                        if (class4.bool_1 && (class2.int_2 == class4.int_0))
                        {
                            this.class602_1.method_2(this.int_5, new Class352(class5.int_1, class4));
                        }
                        else
                        {
                            this.class602_1.method_2(this.int_5, new Class344(class5.int_1, class5.bool_0));
                        }
                        this.class602_1.method_2(this.int_5, Class518.class337_13);
                    }
                    if (Class516.bool_24)
                    {
                        class4.bool_0[class2.int_2] = true;
                    }
                }
                this.class602_1.method_2(this.int_5, new Class357(class2.class369_0));
                if (class2.short_0 > 0)
                {
                    this.class602_1.method_3(this.int_5, this.QRVU());
                    int num = A_3 - class2.short_0;
                    for (int i = 0; i < class2.short_0; i++)
                    {
                        if (i > 0)
                        {
                            base.method_9(Class518.class337_14);
                        }
                        Struct0 struct2 = this.struct0_0[num + i];
                        this.method_128(struct2.enum11_0, struct2.int_0, struct2.byte_0);
                    }
                    this.class602_1.method_2(this.int_5, this.QRVV());
                }
                if (A_4 > 0)
                {
                    this.class602_1.method_2(this.int_5, Class518.class337_13);
                }
            }
            else if (A_1 == Enum11.const_38)
            {
                Class553.Class531 class6 = Class546.class553_0.arrayList_0[A_2] as Class553.Class531;
                if ((class6.enum0_0 == Enum0.const_1) && (class6.int_0 > 0))
                {
                    this.method_127(Enum11.const_38, class6.int_0, A_3 - class6.short_0, A_4 + 1);
                }
                else
                {
                    Class562 class7 = Class546.class562_0;
                    if (Class516.Boolean_0)
                    {
                        Class562.Class533 class8 = class7.arrayList_0[class6.int_2] as Class562.Class533;
                        this.class602_1.method_2(this.int_5, new Class344(class8.int_1, class8.bool_0));
                        this.class602_1.method_2(this.int_5, Class518.class337_13);
                    }
                    if (Class516.bool_24)
                    {
                        class7.bool_0[class6.int_2] = true;
                    }
                }
                this.class602_1.method_2(this.int_5, new Class345(class6));
                if (class6.short_0 > 0)
                {
                    this.class602_1.method_3(this.int_5, this.QRVU());
                    int num3 = A_3 - class6.short_0;
                    for (int j = 0; j < class6.short_0; j++)
                    {
                        if (j > 0)
                        {
                            base.method_9(Class518.class337_14);
                        }
                        Struct0 struct3 = this.struct0_0[num3 + j];
                        this.method_128(struct3.enum11_0, struct3.int_0, struct3.byte_0);
                    }
                    this.class602_1.method_2(this.int_5, this.QRVV());
                }
                if (A_4 > 0)
                {
                    this.class602_1.method_2(this.int_5, Class518.class337_13);
                }
            }
        }

        private void method_128(Enum11 A_1, int A_2, byte A_3)
        {
            Class397 class2 = base.method_1();
            this.class397_2.Class367_0.method_5();
            base.method_0(this.class397_2);
            this.method_93(A_1, A_2, A_3);
            this.class602_1.method_3(this.int_5, this.class397_2.Class367_0);
            base.method_0(class2);
        }

        private void method_129()
        {
            this.int_3 = 0;
        }

        private void method_130(Enum11 A_1, int A_2, byte A_3)
        {
            this.int_3++;
            if (this.int_3 >= this.int_4)
            {
                this.int_4 *= 2;
                Struct0[] structArray = this.struct0_0;
                this.struct0_0 = new Struct0[this.int_4];
                for (int i = 0; i < (this.int_3 - 1); i++)
                {
                    this.struct0_0[i] = structArray[i];
                }
            }
            int index = this.int_3 - 1;
            this.struct0_0[index].enum11_0 = A_1;
            this.struct0_0[index].int_0 = A_2;
            this.struct0_0[index].byte_0 = A_3;
        }

        internal void method_91(Enum0 A_1, int A_2)
        {
            switch (A_1)
            {
                case Enum0.const_1:
                    base.method_54(A_2);
                    return;

                case Enum0.const_2:
                    base.method_50(A_2);
                    return;
            }
        }

        internal void method_92(Enum11 A_1, int A_2, int A_3)
        {
            if (A_3 <= 0)
            {
                switch (A_1)
                {
                    case Enum11.const_1:
                        this.method_94(this.QRST(), true);
                        return;

                    case Enum11.const_2:
                        this.method_94(this.QRSU(), true);
                        return;

                    case Enum11.const_3:
                        this.method_94(this.QRSV(), true);
                        return;

                    case Enum11.const_4:
                        this.method_94(this.QRSW(), true);
                        return;

                    case Enum11.const_5:
                        this.method_94(this.QRSX(), true);
                        return;

                    case Enum11.const_6:
                        this.method_94(this.QRSY(), true);
                        return;

                    case Enum11.const_7:
                        this.method_94(this.QRSZ(), true);
                        return;

                    case Enum11.const_8:
                        this.method_94(this.QRTQ(), true);
                        return;

                    case Enum11.const_9:
                        this.method_94(this.QRTR(), true);
                        return;

                    case Enum11.const_10:
                        this.method_94(this.QRTS(), true);
                        return;

                    case Enum11.const_11:
                        this.method_94(this.QRTT(), true);
                        return;

                    case Enum11.const_12:
                        this.method_94(this.QRTU(), true);
                        return;

                    case Enum11.const_13:
                        this.method_94(this.QRTV(), true);
                        return;

                    case Enum11.const_14:
                        this.method_94(this.QRTW(), true);
                        return;

                    case Enum11.const_15:
                        this.QRQR();
                        return;

                    case Enum11.const_16:
                        this.QRQS();
                        return;

                    case Enum11.const_17:
                        this.QRQT();
                        return;

                    case Enum11.const_18:
                        this.QRQU();
                        return;

                    case Enum11.const_19:
                        this.QRQV();
                        return;

                    case Enum11.const_20:
                        this.QRQW();
                        return;

                    case Enum11.const_21:
                        this.QRQX();
                        return;

                    case Enum11.const_22:
                        this.QRQY();
                        return;

                    case Enum11.const_23:
                        this.QRQZ();
                        return;

                    case Enum11.const_24:
                        this.QRRQ();
                        return;

                    case Enum11.const_25:
                        this.QRRR();
                        return;

                    case Enum11.const_26:
                        this.QRRS();
                        return;

                    case Enum11.const_27:
                        this.QRRT();
                        return;

                    case Enum11.const_28:
                        this.QRRU();
                        return;

                    case Enum11.const_29:
                        this.QRRV();
                        return;

                    case Enum11.const_30:
                        this.method_106(true);
                        return;

                    case Enum11.const_31:
                        this.method_108(true);
                        return;

                    case Enum11.const_32:
                        this.method_107(true);
                        return;

                    case Enum11.const_33:
                        this.method_109(true);
                        return;

                    case Enum11.const_34:
                        this.method_110(true);
                        return;

                    case Enum11.const_35:
                        this.method_111(true);
                        return;

                    case Enum11.const_36:
                        this.method_102(A_2, true);
                        return;

                    case Enum11.const_37:
                        this.method_103(A_2, true);
                        return;

                    case Enum11.const_38:
                        this.method_104(A_2, true);
                        return;

                    case Enum11.const_39:
                        this.method_105(A_2, true);
                        return;

                    case Enum11.const_40:
                    case Enum11.const_44:
                        return;

                    case Enum11.const_41:
                        this.method_114(A_2, true);
                        return;

                    case Enum11.const_42:
                        this.method_112(A_2);
                        return;

                    case Enum11.const_43:
                        this.method_95(A_2);
                        return;

                    case Enum11.const_45:
                        this.method_96(A_2);
                        return;

                    case Enum11.const_46:
                        this.method_98(A_2);
                        return;

                    case Enum11.const_47:
                        this.method_100(A_2);
                        return;
                }
            }
            else
            {
                switch (A_1)
                {
                    case Enum11.const_15:
                        this.QQXS();
                        break;

                    case Enum11.const_16:
                        this.QQXT();
                        break;

                    case Enum11.const_17:
                        this.QRUU();
                        break;

                    case Enum11.const_18:
                        this.QQXV();
                        break;

                    case Enum11.const_19:
                        this.QQXW();
                        break;

                    case Enum11.const_20:
                        this.QQXX();
                        break;

                    case Enum11.const_21:
                        this.QQXY();
                        break;

                    case Enum11.const_22:
                        this.QQXZ();
                        break;

                    case Enum11.const_23:
                        this.QQYQ();
                        break;

                    case Enum11.const_24:
                        this.QQYR();
                        break;

                    case Enum11.const_25:
                        this.QQYS();
                        break;

                    case Enum11.const_26:
                        this.QQYT();
                        break;

                    case Enum11.const_27:
                        this.QQYU();
                        break;

                    case Enum11.const_28:
                        this.QRUV();
                        break;

                    case Enum11.const_29:
                        this.QQYW();
                        break;

                    case Enum11.const_30:
                        this.method_106(false);
                        break;

                    case Enum11.const_31:
                        this.method_108(false);
                        break;

                    case Enum11.const_32:
                    case Enum11.const_33:
                    case Enum11.const_35:
                    case Enum11.const_37:
                    case Enum11.const_39:
                    case Enum11.const_40:
                    case Enum11.const_42:
                    case Enum11.const_44:
                        return;

                    case Enum11.const_34:
                        this.method_110(false);
                        break;

                    case Enum11.const_36:
                        this.method_102(A_2, false);
                        break;

                    case Enum11.const_38:
                        this.method_104(A_2, false);
                        break;

                    case Enum11.const_41:
                        this.method_114(A_2, false);
                        break;

                    case Enum11.const_43:
                        this.method_95(A_2);
                        break;

                    case Enum11.const_45:
                        this.method_96(A_2);
                        break;

                    case Enum11.const_46:
                        this.method_98(A_2);
                        break;

                    case Enum11.const_47:
                        this.method_100(A_2);
                        break;

                    default:
                        return;
                }
                base.method_9(Class609.smethod_0(A_3));
                base.method_9(Class584.class342_0);
            }
        }

        internal void method_93(Enum11 A_1, int A_2, int A_3)
        {
            if (A_3 <= 0)
            {
                switch (A_1)
                {
                    case Enum11.const_1:
                        this.method_94(this.QRST(), false);
                        return;

                    case Enum11.const_2:
                        this.method_94(this.QRSU(), false);
                        return;

                    case Enum11.const_3:
                        this.method_94(this.QRSV(), false);
                        return;

                    case Enum11.const_4:
                        this.method_94(this.QRSW(), false);
                        return;

                    case Enum11.const_5:
                        this.method_94(this.QRSX(), false);
                        return;

                    case Enum11.const_6:
                        this.method_94(this.QRSY(), false);
                        return;

                    case Enum11.const_7:
                        this.method_94(this.QRSZ(), false);
                        return;

                    case Enum11.const_8:
                        this.method_94(this.QRTQ(), false);
                        return;

                    case Enum11.const_9:
                        this.method_94(this.QRTR(), false);
                        return;

                    case Enum11.const_10:
                        this.method_94(this.QRTS(), false);
                        return;

                    case Enum11.const_11:
                        this.method_94(this.QRTT(), false);
                        return;

                    case Enum11.const_12:
                        this.method_94(this.QRTU(), false);
                        return;

                    case Enum11.const_13:
                        this.method_94(this.QRTV(), false);
                        return;

                    case Enum11.const_14:
                        this.method_94(this.QRTW(), false);
                        return;

                    case Enum11.const_15:
                        this.QQXS();
                        return;

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

                    case Enum11.const_29:
                        this.QQYW();
                        return;

                    case Enum11.const_30:
                        this.method_106(false);
                        return;

                    case Enum11.const_31:
                        this.method_108(false);
                        return;

                    case Enum11.const_32:
                        this.method_107(false);
                        return;

                    case Enum11.const_33:
                        this.method_109(false);
                        return;

                    case Enum11.const_34:
                        this.method_110(false);
                        return;

                    case Enum11.const_35:
                        this.method_111(false);
                        return;

                    case Enum11.const_36:
                        this.method_102(A_2, false);
                        return;

                    case Enum11.const_37:
                        this.method_103(A_2, false);
                        return;

                    case Enum11.const_38:
                        this.method_104(A_2, false);
                        return;

                    case Enum11.const_39:
                        this.method_105(A_2, false);
                        return;

                    case Enum11.const_40:
                    case Enum11.const_44:
                        return;

                    case Enum11.const_41:
                        this.method_114(A_2, false);
                        return;

                    case Enum11.const_42:
                        this.method_112(A_2);
                        return;

                    case Enum11.const_43:
                        this.method_95(A_2);
                        return;

                    case Enum11.const_45:
                        this.method_97(A_2);
                        return;

                    case Enum11.const_46:
                        this.method_99(A_2);
                        return;

                    case Enum11.const_47:
                        this.method_101(A_2);
                        return;
                }
            }
            else
            {
                switch (A_1)
                {
                    case Enum11.const_15:
                        this.QQXS();
                        break;

                    case Enum11.const_16:
                        this.QQXT();
                        break;

                    case Enum11.const_17:
                        this.QRUU();
                        break;

                    case Enum11.const_18:
                        this.QQXV();
                        break;

                    case Enum11.const_19:
                        this.QQXW();
                        break;

                    case Enum11.const_20:
                        this.QQXX();
                        break;

                    case Enum11.const_21:
                        this.QQXY();
                        break;

                    case Enum11.const_22:
                        this.QQXZ();
                        break;

                    case Enum11.const_23:
                        this.QQYQ();
                        break;

                    case Enum11.const_24:
                        this.QQYR();
                        break;

                    case Enum11.const_25:
                        this.QQYS();
                        break;

                    case Enum11.const_26:
                        this.QQYT();
                        break;

                    case Enum11.const_27:
                        this.QQYU();
                        break;

                    case Enum11.const_28:
                        this.QRUV();
                        break;

                    case Enum11.const_29:
                        this.QQYW();
                        break;

                    case Enum11.const_30:
                        this.method_106(false);
                        break;

                    case Enum11.const_31:
                        this.method_108(false);
                        break;

                    case Enum11.const_32:
                    case Enum11.const_33:
                    case Enum11.const_35:
                    case Enum11.const_37:
                    case Enum11.const_39:
                    case Enum11.const_40:
                    case Enum11.const_42:
                    case Enum11.const_44:
                        return;

                    case Enum11.const_34:
                        this.method_110(false);
                        break;

                    case Enum11.const_36:
                        this.method_102(A_2, false);
                        break;

                    case Enum11.const_38:
                        this.method_104(A_2, false);
                        break;

                    case Enum11.const_41:
                        this.method_114(A_2, false);
                        break;

                    case Enum11.const_43:
                        this.method_95(A_2);
                        break;

                    case Enum11.const_45:
                        this.method_97(A_2);
                        break;

                    case Enum11.const_46:
                        this.method_99(A_2);
                        break;

                    case Enum11.const_47:
                        this.method_101(A_2);
                        break;

                    default:
                        return;
                }
                base.method_9(Class609.smethod_0(A_3));
            }
        }

        private void method_94(Class335 A_1, bool A_2)
        {
            base.method_9(A_1);
            this.method_113(A_2);
        }

        private void method_95(int A_1)
        {
            Class560.Class610 class2 = Class546.class560_0.arrayList_0[A_1] as Class560.Class610;
            this.method_92(class2.enum11_0, class2.int_0, 0);
        }

        private void method_96(int A_1)
        {
            this.QRUY(A_1);
            base.method_9(Class584.class342_0);
        }

        private void method_97(int A_1)
        {
            this.QRUY(A_1);
        }

        private void method_98(int A_1)
        {
            Class519.class529_1.class369_0.QQWV(base.method_1(), A_1);
            base.method_9(Class584.class342_0);
        }

        private void method_99(int A_1)
        {
            Class519.class529_1.class369_0.QQWV(base.method_1(), A_1);
        }
    }
}

