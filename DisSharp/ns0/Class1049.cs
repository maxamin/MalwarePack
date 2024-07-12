namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1049
    {
        private static ArrayList arrayList_0 = new ArrayList(250);
        private static ArrayList arrayList_1;
        private static bool bool_0;
        private static bool bool_1;
        private static Class445 class445_0;
        private static Class822 class822_0;
        private static Class822 class822_1;
        private static Class822 class822_2;
        private static Hashtable hashtable_0 = new Hashtable(100);
        private static int int_0;
        private static int int_1;
        private static Stack stack_0 = new Stack(0x40);
        private static Stack stack_1 = new Stack(0x40);
        private static Stack stack_2 = new Stack(0x40);

        private static void smethod_0(Class445 A_0)
        {
            Class822 class2;
            stack_0.Push(A_0);
            if (class445_0 == null)
            {
                stack_1.Push(A_0);
                class2 = class822_0;
            }
            else
            {
                stack_1.Push(class445_0);
                class2 = hashtable_0[class445_0] as Class822;
            }
            class445_0 = null;
            hashtable_0[A_0] = class2;
            if (!bool_0)
            {
                class822_1 = class822_0;
            }
            bool_0 = true;
            bool_1 = true;
        }

        private static Class445 smethod_1()
        {
            stack_1.Pop();
            class445_0 = stack_0.Pop() as Class445;
            return class445_0;
        }

        internal static void smethod_10(Class522 A_0)
        {
            arrayList_1 = A_0.arrayList_0;
            stack_0.Clear();
            stack_1.Clear();
            stack_2.Clear();
            hashtable_0.Clear();
            arrayList_0.Clear();
            Class1033.smethod_0();
            int_1 = arrayList_1.Count;
            class445_0 = null;
            bool_0 = false;
            class822_2 = null;
            bool_1 = false;
            int_0 = 0;
            while (int_0 < int_1)
            {
                Class445 class7;
                class822_0 = arrayList_1[int_0] as Class822;
                if (class822_0.enum45_0 != Enum45.const_1)
                {
                    if (!class822_0.QQQX)
                    {
                        if (class822_0.Boolean_0 && (class822_0.enum45_0 != Enum45.const_44))
                        {
                            smethod_3(new Class436());
                        }
                        if (class822_0.enum45_0 == Enum45.const_44)
                        {
                            Class417 class2 = new Class417 {
                                bool_0 = true
                            };
                            smethod_3(class2);
                        }
                    }
                    else
                    {
                        if (class822_0 == class822_2)
                        {
                            smethod_0(new Class509(Class1033.smethod_5(), Class1033.class445_0, smethod_1()));
                            class822_2 = Class1033.smethod_3();
                        }
                        switch (class822_0.enum45_0)
                        {
                            case Enum45.const_4:
                                smethod_0(new Class456(0));
                                break;

                            case Enum45.const_5:
                                smethod_0(new Class456(1));
                                break;

                            case Enum45.const_6:
                                smethod_0(new Class456(2));
                                break;

                            case Enum45.const_7:
                                smethod_0(new Class456(3));
                                break;

                            case Enum45.const_8:
                                smethod_0(new Class452(0));
                                break;

                            case Enum45.const_9:
                                smethod_0(new Class452(1));
                                break;

                            case Enum45.const_10:
                                smethod_0(new Class452(2));
                                break;

                            case Enum45.const_11:
                                smethod_0(new Class452(3));
                                break;

                            case Enum45.const_12:
                                if (smethod_13(true, 0))
                                {
                                    smethod_15(new Class452(0), smethod_1());
                                }
                                break;

                            case Enum45.const_13:
                                if (smethod_13(true, 1))
                                {
                                    smethod_15(new Class452(1), smethod_1());
                                }
                                break;

                            case Enum45.const_14:
                                if (smethod_13(true, 2))
                                {
                                    smethod_15(new Class452(2), smethod_1());
                                }
                                break;

                            case Enum45.const_15:
                                if (smethod_13(true, 3))
                                {
                                    smethod_15(new Class452(3), smethod_1());
                                }
                                break;

                            case Enum45.const_16:
                            case Enum45.const_198:
                                smethod_0(new Class456((class822_0 as Class833).ushort_0));
                                break;

                            case Enum45.const_17:
                            case Enum45.const_199:
                                smethod_0(new Class457((class822_0 as Class833).ushort_0));
                                break;

                            case Enum45.const_18:
                            case Enum45.const_200:
                                if (smethod_13(false, 0))
                                {
                                    smethod_15(new Class456((class822_0 as Class833).ushort_0), smethod_1());
                                }
                                break;

                            case Enum45.const_19:
                            case Enum45.const_201:
                                smethod_0(new Class452((class822_0 as Class835).ushort_0));
                                break;

                            case Enum45.const_20:
                            case Enum45.const_202:
                                smethod_0(new Class453((class822_0 as Class835).ushort_0));
                                break;

                            case Enum45.const_21:
                            {
                                ushort num3 = (class822_0 as Class835).ushort_0;
                                if (smethod_13(true, num3))
                                {
                                    smethod_15(new Class452(num3), smethod_1());
                                }
                                break;
                            }
                            case Enum45.const_22:
                                smethod_0(new Class496());
                                break;

                            case Enum45.const_23:
                                smethod_0(new Class447(-1));
                                break;

                            case Enum45.const_24:
                                smethod_0(new Class447(0));
                                break;

                            case Enum45.const_25:
                                smethod_0(new Class447(1));
                                break;

                            case Enum45.const_26:
                                smethod_0(new Class447(2));
                                break;

                            case Enum45.const_27:
                                smethod_0(new Class447(3));
                                break;

                            case Enum45.const_28:
                                smethod_0(new Class447(4));
                                break;

                            case Enum45.const_29:
                                smethod_0(new Class447(5));
                                break;

                            case Enum45.const_30:
                                smethod_0(new Class447(6));
                                break;

                            case Enum45.const_31:
                                smethod_0(new Class447(7));
                                break;

                            case Enum45.const_32:
                                smethod_0(new Class447(8));
                                break;

                            case Enum45.const_33:
                                smethod_0(new Class447((class822_0 as Class824).sbyte_0));
                                break;

                            case Enum45.const_34:
                                smethod_0(new Class447((class822_0 as Class823).int_1));
                                break;

                            case Enum45.const_35:
                                smethod_0(new Class448((class822_0 as Class829).long_0));
                                break;

                            case Enum45.const_36:
                                smethod_0(new Class449((class822_0 as Class836).float_0));
                                break;

                            case Enum45.const_37:
                                smethod_0(new Class450((class822_0 as Class838).double_0));
                                break;

                            case Enum45.const_38:
                                smethod_0(smethod_2());
                                break;

                            case Enum45.const_39:
                                smethod_17();
                                break;

                            case Enum45.const_40:
                                throw new Exception1();

                            case Enum45.const_41:
                            case Enum45.const_112:
                                smethod_11();
                                break;

                            case Enum45.const_43:
                                if (stack_0.Count <= 0)
                                {
                                    goto Label_077E;
                                }
                                smethod_3(new Class428(smethod_1()));
                                break;

                            case Enum45.const_44:
                            case Enum45.const_57:
                                if ((stack_0.Count <= 0) || !bool_1)
                                {
                                    goto Label_07AB;
                                }
                                smethod_8();
                                break;

                            case Enum45.const_45:
                            case Enum45.const_58:
                                smethod_3(new Class419(smethod_1(), Enum66.const_2));
                                break;

                            case Enum45.const_46:
                            case Enum45.const_59:
                                smethod_3(new Class419(smethod_1(), Enum66.const_1));
                                break;

                            case Enum45.const_47:
                            case Enum45.const_60:
                                smethod_3(new Class419(new Class470(smethod_1(), smethod_1(), Enum31.const_0), Enum66.const_0));
                                break;

                            case Enum45.const_48:
                            case Enum45.const_53:
                            case Enum45.const_61:
                            case Enum45.const_66:
                                smethod_3(new Class419(new Class470(smethod_1(), smethod_1(), Enum31.const_5), Enum66.const_0));
                                break;

                            case Enum45.const_49:
                            case Enum45.const_54:
                            case Enum45.const_62:
                            case Enum45.const_67:
                                smethod_3(new Class419(new Class470(smethod_1(), smethod_1(), Enum31.const_4), Enum66.const_0));
                                break;

                            case Enum45.const_50:
                            case Enum45.const_55:
                            case Enum45.const_63:
                            case Enum45.const_68:
                                smethod_3(new Class419(new Class470(smethod_1(), smethod_1(), Enum31.const_3), Enum66.const_0));
                                break;

                            case Enum45.const_51:
                            case Enum45.const_56:
                            case Enum45.const_64:
                            case Enum45.const_69:
                                smethod_3(new Class419(new Class470(smethod_1(), smethod_1(), Enum31.const_2), Enum66.const_0));
                                break;

                            case Enum45.const_52:
                            case Enum45.const_65:
                                smethod_3(new Class419(new Class470(smethod_1(), smethod_1(), Enum31.const_1), Enum66.const_0));
                                break;

                            case Enum45.const_70:
                                smethod_3(new Class435(smethod_1()));
                                break;

                            case Enum45.const_82:
                            case Enum45.const_83:
                            case Enum45.const_84:
                            case Enum45.const_85:
                            case Enum45.const_86:
                            case Enum45.const_87:
                            case Enum45.const_88:
                            case Enum45.const_188:
                            {
                                Class445 class14 = smethod_1();
                                smethod_15(smethod_1(), class14);
                                break;
                            }
                            case Enum45.const_89:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_0));
                                break;

                            case Enum45.const_90:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_11));
                                break;

                            case Enum45.const_91:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_7));
                                break;

                            case Enum45.const_92:
                            case Enum45.const_93:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_5));
                                break;

                            case Enum45.const_94:
                            case Enum45.const_95:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_6));
                                break;

                            case Enum45.const_96:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_2));
                                break;

                            case Enum45.const_97:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_3));
                                break;

                            case Enum45.const_98:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_4));
                                break;

                            case Enum45.const_99:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_9));
                                break;

                            case Enum45.const_100:
                            case Enum45.const_101:
                                smethod_0(new Class463(smethod_1(), smethod_1(), Enum1.const_10));
                                break;

                            case Enum45.const_102:
                                smethod_0(new Class513(smethod_1(), Enum32.const_1));
                                break;

                            case Enum45.const_103:
                                smethod_0(new Class513(smethod_1(), Enum32.const_3));
                                break;

                            case Enum45.const_104:
                                smethod_0(new Class476(smethod_1(), Enum3.const_2));
                                break;

                            case Enum45.const_105:
                                smethod_0(new Class476(smethod_1(), Enum3.const_4));
                                break;

                            case Enum45.const_106:
                                smethod_0(new Class476(smethod_1(), Enum3.const_6));
                                break;

                            case Enum45.const_107:
                                smethod_0(new Class476(smethod_1(), Enum3.const_8));
                                break;

                            case Enum45.const_108:
                            case Enum45.const_119:
                                smethod_0(new Class476(smethod_1(), Enum3.const_10));
                                break;

                            case Enum45.const_109:
                                smethod_0(new Class476(smethod_1(), Enum3.const_11));
                                break;

                            case Enum45.const_110:
                                smethod_0(new Class476(smethod_1(), Enum3.const_7));
                                break;

                            case Enum45.const_111:
                                smethod_0(new Class476(smethod_1(), Enum3.const_9));
                                break;

                            case Enum45.const_113:
                                throw new Exception1();

                            case Enum45.const_115:
                                smethod_0(new Class473((class822_0 as Class831).int_1));
                                break;

                            case Enum45.const_116:
                                smethod_12();
                                break;

                            case Enum45.const_117:
                                smethod_0(new Class467(smethod_1(), (class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_118:
                                smethod_0(new Class490(smethod_1(), (class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_120:
                            case Enum45.const_217:
                                smethod_0(new Class512(smethod_1(), (class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_121:
                                smethod_3(new Class437(smethod_1()));
                                break;

                            case Enum45.const_122:
                                smethod_0(new Class484(smethod_1(), (class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_123:
                                smethod_0(new Class485(smethod_1(), (class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_124:
                            {
                                uint num = (class822_0 as Class837).uint_0;
                                Class445 class12 = smethod_1();
                                smethod_15(new Class484(smethod_1(), num), class12);
                                break;
                            }
                            case Enum45.const_125:
                                smethod_0(new Class501((class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_126:
                                smethod_0(new Class502((class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_127:
                                if (smethod_13(false, 0))
                                {
                                    smethod_15(new Class501((class822_0 as Class837).uint_0), smethod_1());
                                }
                                break;

                            case Enum45.const_128:
                            {
                                Class445 class16 = smethod_1();
                                smethod_15(smethod_1(), class16);
                                break;
                            }
                            case Enum45.const_129:
                            case Enum45.const_162:
                                smethod_0(new Class469(smethod_1(), Enum3.const_2));
                                break;

                            case Enum45.const_130:
                            case Enum45.const_164:
                                smethod_0(new Class469(smethod_1(), Enum3.const_4));
                                break;

                            case Enum45.const_131:
                            case Enum45.const_166:
                                smethod_0(new Class469(smethod_1(), Enum3.const_6));
                                break;

                            case Enum45.const_132:
                            case Enum45.const_168:
                                smethod_0(new Class469(smethod_1(), Enum3.const_8));
                                break;

                            case Enum45.const_133:
                            case Enum45.const_163:
                                smethod_0(new Class469(smethod_1(), Enum3.const_3));
                                break;

                            case Enum45.const_134:
                            case Enum45.const_165:
                                smethod_0(new Class469(smethod_1(), Enum3.const_5));
                                break;

                            case Enum45.const_135:
                            case Enum45.const_167:
                                smethod_0(new Class469(smethod_1(), Enum3.const_7));
                                break;

                            case Enum45.const_136:
                            case Enum45.const_169:
                                smethod_0(new Class469(smethod_1(), Enum3.const_9));
                                break;

                            case Enum45.const_139:
                                smethod_0(new Class466(smethod_1(), (class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_140:
                                smethod_0(new Class493((class822_0 as Class837).uint_0, smethod_1()));
                                break;

                            case Enum45.const_141:
                                smethod_0(new Class491(smethod_1()));
                                break;

                            case Enum45.const_142:
                            {
                                Class445 class5 = smethod_1();
                                smethod_0(new Class460(smethod_1(), class5));
                                break;
                            }
                            case Enum45.const_143:
                            case Enum45.const_144:
                            case Enum45.const_145:
                            case Enum45.const_146:
                            case Enum45.const_147:
                            case Enum45.const_148:
                            case Enum45.const_149:
                            case Enum45.const_150:
                            case Enum45.const_151:
                            case Enum45.const_152:
                            case Enum45.const_153:
                            case Enum45.const_215:
                            {
                                Class445 class3 = smethod_1();
                                smethod_0(new Class458(smethod_1(), class3));
                                break;
                            }
                            case Enum45.const_154:
                            case Enum45.const_155:
                            case Enum45.const_156:
                            case Enum45.const_157:
                            case Enum45.const_158:
                            case Enum45.const_159:
                            case Enum45.const_160:
                            case Enum45.const_161:
                            case Enum45.const_216:
                            {
                                Class445 class9 = smethod_1();
                                Class445 class10 = smethod_1();
                                smethod_15(new Class458(smethod_1(), class10), class9);
                                break;
                            }
                            case Enum45.const_171:
                                throw new Exception1();

                            case Enum45.const_173:
                                smethod_14();
                                break;

                            case Enum45.const_174:
                                smethod_0(new Class476(smethod_1(), Enum3.const_5));
                                break;

                            case Enum45.const_175:
                                smethod_0(new Class476(smethod_1(), Enum3.const_3));
                                break;

                            case Enum45.const_179:
                            case Enum45.const_180:
                                smethod_0(new Class468(smethod_1(), smethod_1(), Enum1.const_0));
                                break;

                            case Enum45.const_181:
                            case Enum45.const_182:
                                smethod_0(new Class468(smethod_1(), smethod_1(), Enum1.const_7));
                                break;

                            case Enum45.const_183:
                            case Enum45.const_184:
                                smethod_0(new Class468(smethod_1(), smethod_1(), Enum1.const_11));
                                break;

                            case Enum45.const_186:
                            case Enum45.const_187:
                                smethod_3(new Class425());
                                break;

                            case Enum45.const_190:
                                smethod_16();
                                break;

                            case Enum45.const_191:
                                smethod_0(new Class470(smethod_1(), smethod_1(), Enum31.const_0));
                                break;

                            case Enum45.const_192:
                            case Enum45.const_193:
                                smethod_0(new Class470(smethod_1(), smethod_1(), Enum31.const_4));
                                break;

                            case Enum45.const_194:
                            case Enum45.const_195:
                                smethod_0(new Class470(smethod_1(), smethod_1(), Enum31.const_2));
                                break;

                            case Enum45.const_196:
                                class7 = smethod_2();
                                if (class7.Type != Enum17.const_50)
                                {
                                    goto Label_0E75;
                                }
                                smethod_0(new Class506((class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_197:
                                smethod_0(new Class488(smethod_1(), (class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_203:
                            {
                                ushort num2 = (class822_0 as Class835).ushort_0;
                                if (smethod_13(true, num2))
                                {
                                    smethod_15(new Class452(num2), smethod_1());
                                }
                                break;
                            }
                            case Enum45.const_206:
                                throw new Exception1();

                            case Enum45.const_207:
                                throw new Exception1();

                            case Enum45.const_208:
                                throw new Exception1();

                            case Enum45.const_209:
                                smethod_3(new Class420(smethod_1(), (class822_0 as Class837).uint_0));
                                break;

                            case Enum45.const_210:
                                throw new Exception1();

                            case Enum45.const_211:
                                throw new Exception1();

                            case Enum45.const_212:
                                smethod_3(new Class427());
                                break;

                            case Enum45.const_213:
                                smethod_0(new Class498((class822_0 as Class837).uint_0));
                                break;
                        }
                    }
                }
                goto Label_1040;
            Label_077E:
                smethod_3(new Class428());
                goto Label_1040;
            Label_07AB:
                smethod_3(new Class417());
                goto Label_1040;
            Label_0E75:
                smethod_0(new Class488(class7, (class822_0 as Class837).uint_0));
            Label_1040:
                int_0++;
            }
        }

        private static void smethod_11()
        {
            Class445[] classArray;
            Class547.Class528 class17;
            Class445[] classArray5;
            uint num = (class822_0 as Class837).uint_0;
            Enum0 enum2 = (Enum0) ((byte) ((num & -16777216) >> 0x18));
            int num2 = ((int) num) & 0xffffff;
            int num3 = 0;
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            Enum0 enum3 = enum2;
            switch (enum3)
            {
                case Enum0.const_6:
                    goto Label_04BB;

                case Enum0.const_10:
                {
                    Class551.Class544 class2 = Class546.class551_0.arrayList_0[num2] as Class551.Class544;
                    if (class2.enum9_0 != Enum9.const_3)
                    {
                        if (class2.enum9_0 != Enum9.const_4)
                        {
                            Class552.Class545 class4 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                            num3 = class4.short_0;
                            flag = (class4.enum11_0 == Enum11.const_15) && (class4.byte_5 == 0);
                            flag2 = class4.Boolean_0;
                            flag3 = class4.Boolean_1;
                            switch (class2.enum21_0)
                            {
                                case Enum21.const_0:
                                    goto Label_063F;

                                case Enum21.const_1:
                                    if (!flag3)
                                    {
                                        smethod_0(new Class489(smethod_1(), num));
                                        return;
                                    }
                                    smethod_0(new Class507(num));
                                    return;

                                case Enum21.const_2:
                                {
                                    Class445 class5 = smethod_1();
                                    if (!flag3)
                                    {
                                        smethod_3(new Class424(smethod_1(), num, class5));
                                        return;
                                    }
                                    smethod_3(new Class432(num, class5));
                                    return;
                                }
                                case Enum21.const_3:
                                    classArray = null;
                                    if (num3 > 0)
                                    {
                                        classArray = new Class445[num3];
                                        for (int i = 0; i < num3; i++)
                                        {
                                            classArray[(num3 - 1) - i] = smethod_1();
                                        }
                                    }
                                    goto Label_0355;

                                case Enum21.const_4:
                                {
                                    Class445[] classArray2 = null;
                                    if (num3 > 0)
                                    {
                                        classArray2 = new Class445[num3];
                                        for (int j = 0; j < num3; j++)
                                        {
                                            classArray2[(num3 - 1) - j] = smethod_1();
                                        }
                                    }
                                    if (flag3)
                                    {
                                        smethod_3(new Class430(num, classArray2));
                                        return;
                                    }
                                    smethod_3(new Class422(smethod_1(), num, classArray2));
                                    return;
                                }
                                case Enum21.const_6:
                                    flag2 = true;
                                    goto Label_063F;

                                case Enum21.const_7:
                                case Enum21.const_9:
                                {
                                    if (num3 != 2)
                                    {
                                        Class461 class9 = new Class461();
                                        for (int k = 0; k < num3; k++)
                                        {
                                            class9.method_1(smethod_1());
                                        }
                                        Class445 class10 = smethod_1();
                                        class9.class445_0 = class10;
                                        smethod_0(class9);
                                        return;
                                    }
                                    Class445 class6 = smethod_1();
                                    Class445 class7 = smethod_1();
                                    smethod_0(new Class459(smethod_1(), class7, class6));
                                    return;
                                }
                                case Enum21.const_8:
                                {
                                    Class445 class11 = smethod_1();
                                    if (num3 == 3)
                                    {
                                        Class445 class12 = smethod_1();
                                        Class445 class13 = smethod_1();
                                        smethod_3(new Class399(new Class459(smethod_1(), class13, class12), class11));
                                        return;
                                    }
                                    Class461 class15 = new Class461();
                                    for (int m = 0; m < (num3 - 1); m++)
                                    {
                                        class15.method_1(smethod_1());
                                    }
                                    Class445 class16 = smethod_1();
                                    class15.class445_0 = class16;
                                    smethod_3(new Class399(class15, class11));
                                    return;
                                }
                            }
                            throw new Exception1();
                        }
                        Class556.Class601 class3 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                        num3 = class3.short_0;
                        flag = (class3.enum11_0 == Enum11.const_15) && (class3.byte_4 == 0);
                        flag2 = class3.Boolean_0;
                        flag3 = class3.Boolean_1;
                        goto Label_063F;
                    }
                    num2 = class2.int_0;
                    num = Class689.smethod_1(6, num2);
                    goto Label_04BB;
                }
                default:
                    if (enum3 == Enum0.const_43)
                    {
                        Class573.Class534 class20 = Class546.class573_0.arrayList_0[num2] as Class573.Class534;
                        switch (class20.enum0_0)
                        {
                            case Enum0.const_6:
                            {
                                Class547.Class528 class21 = Class546.class547_0.arrayList_0[class20.int_0] as Class547.Class528;
                                num3 = class21.short_2;
                                flag = (class21.enum11_0 == Enum11.const_15) && (class21.byte_1 == 0);
                                flag2 = class21.Boolean_18;
                                flag3 = class21.Boolean_8;
                                break;
                            }
                            case Enum0.const_10:
                            {
                                Class551.Class544 class22 = Class546.class551_0.arrayList_0[class20.int_0] as Class551.Class544;
                                if (class22.enum9_0 == Enum9.const_4)
                                {
                                    Class556.Class601 class23 = Class546.class556_0.arrayList_0[class22.int_0] as Class556.Class601;
                                    num3 = class23.short_0;
                                    flag = (class23.enum11_0 == Enum11.const_15) && (class23.byte_4 == 0);
                                    flag2 = class23.Boolean_0;
                                    flag3 = class23.Boolean_1;
                                }
                                else if (class22.enum9_0 == Enum9.const_2)
                                {
                                    Class552.Class545 class24 = Class546.class552_0.arrayList_0[class22.int_0] as Class552.Class545;
                                    num3 = class24.short_0;
                                    flag = (class24.enum11_0 == Enum11.const_15) && (class24.byte_5 == 0);
                                    flag2 = class24.Boolean_0;
                                    flag3 = class24.Boolean_1;
                                }
                                break;
                            }
                        }
                    }
                    goto Label_063F;
            }
        Label_0355:
            if (flag3)
            {
                smethod_0(new Class503(num, classArray));
                return;
            }
            smethod_0(new Class486(smethod_1(), num, classArray));
            return;
        Label_04BB:
            class17 = Class546.class547_0.arrayList_0[num2] as Class547.Class528;
            num3 = class17.short_2;
            flag = (class17.enum11_0 == Enum11.const_15) && (class17.byte_1 == 0);
            flag2 = class17.Boolean_18;
            flag3 = class17.Boolean_8;
            Class369 node = class17.class369_0;
            if (node.class369_0.QQRR)
            {
                if (node.class369_0.QQRV(node))
                {
                    if (flag3)
                    {
                        smethod_0(new Class507(num));
                        return;
                    }
                    smethod_0(new Class489(smethod_1(), num));
                    return;
                }
                Class445 class19 = smethod_1();
                if (flag3)
                {
                    smethod_3(new Class432(num, class19));
                    return;
                }
                smethod_3(new Class424(smethod_1(), num, class19));
                return;
            }
            if (node.class369_0.QQTV)
            {
                if (node.class369_0.QQRV(node))
                {
                    Class445[] classArray3 = null;
                    if (num3 > 0)
                    {
                        classArray3 = new Class445[num3];
                        for (int n = 0; n < num3; n++)
                        {
                            classArray3[(num3 - 1) - n] = smethod_1();
                        }
                    }
                    if (flag3)
                    {
                        smethod_0(new Class503(num, classArray3));
                        return;
                    }
                    smethod_0(new Class486(smethod_1(), num, classArray3));
                    return;
                }
                Class445[] classArray4 = null;
                if (num3 > 0)
                {
                    classArray4 = new Class445[num3];
                    for (int num9 = 0; num9 < num3; num9++)
                    {
                        classArray4[(num3 - 1) - num9] = smethod_1();
                    }
                }
                if (flag3)
                {
                    smethod_3(new Class430(num, classArray4));
                    return;
                }
                smethod_3(new Class422(smethod_1(), num, classArray4));
                return;
            }
        Label_063F:
            classArray5 = null;
            if (num3 > 0)
            {
                classArray5 = new Class445[num3];
                for (int num10 = 0; num10 < num3; num10++)
                {
                    classArray5[(num3 - 1) - num10] = smethod_1();
                }
            }
            Class445 class25 = null;
            if (!flag3)
            {
                class25 = smethod_1();
            }
            if (flag2)
            {
                smethod_3(new Class399(class25, new Class446(num, classArray5)));
            }
            else if (flag)
            {
                if (stack_0.Count == 1)
                {
                    if (stack_0.Peek() is Class446)
                    {
                        if (flag3)
                        {
                            smethod_4(new Class443(new Class504(num, classArray5)));
                        }
                        else
                        {
                            smethod_4(new Class443(new Class487(class25, num, classArray5)));
                        }
                    }
                    else if (flag3)
                    {
                        smethod_3(new Class443(new Class504(num, classArray5)));
                    }
                    else
                    {
                        smethod_3(new Class443(new Class487(class25, num, classArray5)));
                    }
                }
                else if (flag3)
                {
                    smethod_3(new Class443(new Class504(num, classArray5)));
                }
                else
                {
                    smethod_3(new Class443(new Class487(class25, num, classArray5)));
                }
            }
            else if (flag3)
            {
                smethod_0(new Class504(num, classArray5));
            }
            else
            {
                smethod_0(new Class487(class25, num, classArray5));
            }
        }

        private static void smethod_12()
        {
            Class445[] classArray;
            uint num = (class822_0 as Class837).uint_0;
            Enum0 enum2 = (Enum0) ((byte) ((num & -16777216) >> 0x18));
            int num2 = ((int) num) & 0xffffff;
            int num3 = 0;
            Enum0 enum3 = enum2;
            if (enum3 != Enum0.const_6)
            {
                if (enum3 == Enum0.const_10)
                {
                    Class551.Class544 class2 = Class546.class551_0.arrayList_0[num2] as Class551.Class544;
                    if (class2.enum9_0 != Enum9.const_3)
                    {
                        if (class2.enum9_0 != Enum9.const_4)
                        {
                            Class552.Class545 class4 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                            num3 = class4.short_0;
                            if (class2.enum21_0 != Enum21.const_0)
                            {
                                if (class2.enum21_0 != Enum21.const_6)
                                {
                                    throw new Exception1();
                                }
                                if (num3 == 2)
                                {
                                    Class445 class5 = smethod_1();
                                    Class445 class6 = smethod_1();
                                    smethod_0(new Class494(class4.enum11_0, class4.int_2, class6, class5));
                                    return;
                                }
                                Class495 class7 = new Class495(class4.enum11_0, class4.int_2);
                                for (int i = 0; i < num3; i++)
                                {
                                    class7.method_1(smethod_1());
                                }
                                smethod_0(class7);
                                return;
                            }
                        }
                        else
                        {
                            Class556.Class601 class3 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                            num3 = class3.short_0;
                        }
                        goto Label_0164;
                    }
                    num2 = class2.int_0;
                }
                else
                {
                    goto Label_0164;
                }
            }
            Class547.Class528 class8 = Class546.class547_0.arrayList_0[num2] as Class547.Class528;
            num3 = class8.short_2;
        Label_0164:
            classArray = null;
            if (num3 > 0)
            {
                classArray = new Class445[num3];
                for (int j = 0; j < num3; j++)
                {
                    classArray[(num3 - 1) - j] = smethod_1();
                }
            }
            smethod_0(new Class446(num, classArray));
        }

        private static bool smethod_13(bool A_0, ushort A_1)
        {
            if ((stack_0.Count > 1) && (int_0 > 3))
            {
                Class822 class2 = arrayList_1[int_0 - 1] as Class822;
                if (class2.enum45_0 == Enum45.const_89)
                {
                    if (((arrayList_1[int_0 - 2] as Class822).enum45_0 == Enum45.const_25) && ((arrayList_1[int_0 - 3] as Class822).enum45_0 == Enum45.const_38))
                    {
                        smethod_1();
                        smethod_0(new Class480(smethod_1()));
                        return false;
                    }
                }
                else if (class2.enum45_0 == Enum45.const_90)
                {
                    if (((arrayList_1[int_0 - 2] as Class822).enum45_0 == Enum45.const_25) && ((arrayList_1[int_0 - 3] as Class822).enum45_0 == Enum45.const_38))
                    {
                        smethod_1();
                        smethod_0(new Class477(smethod_1()));
                        return false;
                    }
                }
                else if (class2.enum45_0 == Enum45.const_38)
                {
                    Class822 class3 = arrayList_1[int_0 - 3] as Class822;
                    Class822 class4 = arrayList_1[int_0 - 2] as Class822;
                    if ((class4.enum45_0 == Enum45.const_89) && (class3.enum45_0 == Enum45.const_25))
                    {
                        if (A_0)
                        {
                            Class835 class5 = arrayList_1[int_0 - 3] as Class835;
                            if ((class5 == null) || (class5.ushort_0 != A_1))
                            {
                                return true;
                            }
                        }
                        smethod_1();
                        smethod_0(new Class481((smethod_1() as Class463).class445_0));
                        if (A_0 && ((int_0 + 2) < int_1))
                        {
                            Class822 class8 = arrayList_1[int_0 + 1] as Class822;
                            if (class8.enum45_0 == Enum45.const_124)
                            {
                                int_0 += 2;
                            }
                        }
                        return false;
                    }
                    if ((class4.enum45_0 == Enum45.const_90) && (class3.enum45_0 == Enum45.const_25))
                    {
                        if (A_0)
                        {
                            Class835 class9 = arrayList_1[int_0 - 3] as Class835;
                            if ((class9 == null) || (class9.ushort_0 != A_1))
                            {
                                return true;
                            }
                        }
                        smethod_1();
                        smethod_0(new Class478((smethod_1() as Class463).class445_0));
                        if (A_0 && ((int_0 + 2) < int_1))
                        {
                            Class822 class12 = arrayList_1[int_0 + 1] as Class822;
                            if (class12.enum45_0 == Enum45.const_124)
                            {
                                int_0 += 2;
                            }
                        }
                        return false;
                    }
                    if (((class4.enum45_0 == Enum45.const_122) && (class3.enum45_0 == Enum45.const_38)) && A_0)
                    {
                        Class835 class13 = arrayList_1[int_0 - 3] as Class835;
                        if ((class13 == null) || (class13.ushort_0 != A_1))
                        {
                            return true;
                        }
                        if ((int_0 + 4) < int_1)
                        {
                            Class822 class14 = arrayList_1[int_0 + 1] as Class822;
                            Class822 class15 = arrayList_1[int_0 + 2] as Class822;
                            Class822 class16 = arrayList_1[int_0 + 3] as Class822;
                            if (((class14.enum45_0 == Enum45.const_25) && (class15.enum45_0 == Enum45.const_89)) && (class16.enum45_0 == Enum45.const_124))
                            {
                                int_0 += 4;
                                smethod_1();
                                smethod_0(new Class480(smethod_1()));
                                return false;
                            }
                            if (((class14.enum45_0 == Enum45.const_25) && (class15.enum45_0 == Enum45.const_90)) && (class16.enum45_0 == Enum45.const_124))
                            {
                                int_0 += 4;
                                smethod_1();
                                smethod_0(new Class477(smethod_1()));
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        private static void smethod_14()
        {
            uint num = (class822_0 as Class837).uint_0;
            int_0++;
            Class837 class2 = arrayList_1[int_0] as Class837;
            if (class2 == null)
            {
                throw new Exception1();
            }
            uint num2 = class2.uint_0;
            if (num2 == Class519.class604_0.uint_8)
            {
                smethod_0(new Class511(num));
            }
            else
            {
                if (num2 != Class519.class604_0.uint_7)
                {
                    throw new Exception1();
                }
                Class445 class3 = smethod_1();
                Class445 class4 = smethod_1();
                if (!class4.method_0(class3))
                {
                    smethod_0(class4);
                }
                smethod_0(Class899.smethod_0(class3, num));
            }
        }

        private static void smethod_15(Class445 A_0, Class445 A_1)
        {
            smethod_3(new Class399(A_0, A_1));
        }

        private static void smethod_16()
        {
            int_0++;
            Class837 class2 = arrayList_1[int_0] as Class837;
            if (class2 == null)
            {
                throw new Exception1();
            }
            Class445 class3 = smethod_1();
            Class445[] classArray = new Class445[] { new Class455() };
            Class445 class4 = new Class446(class2.uint_0, classArray);
            smethod_3(new Class399(class3, class4));
        }

        private static void smethod_17()
        {
            Class445 class2 = smethod_1();
            switch (class2.Type)
            {
                case Enum17.const_38:
                case Enum17.const_39:
                case Enum17.const_40:
                case Enum17.const_41:
                case Enum17.const_57:
                case Enum17.const_58:
                case Enum17.const_59:
                case Enum17.const_60:
                    smethod_3(new Class443(class2));
                    return;
            }
            Class822 class3 = hashtable_0[class2] as Class822;
            if ((class3 != null) && (class3.short_0 != 0))
            {
                bool_0 = true;
                class822_1 = class3;
                smethod_3(new Class436());
            }
        }

        private static Class445 smethod_2()
        {
            return (stack_0.Peek() as Class445);
        }

        private static void smethod_3(Class398 A_0)
        {
            if (arrayList_0.Count > 0)
            {
                A_0 = smethod_7(A_0);
                arrayList_0.Clear();
            }
            class822_1 = bool_0 ? class822_1 : class822_0;
            Class536.arrayList_0.Add(A_0);
            Class536.hashtable_0.Add(A_0, class822_0);
            Class536.hashtable_1[class822_1] = A_0;
            Class536.hashtable_2[A_0] = class822_1;
            bool_0 = false;
            class445_0 = null;
            bool_1 = false;
        }

        private static void smethod_4(Class398 A_0)
        {
            arrayList_0.Add(A_0);
            bool_0 = false;
        }

        private static object smethod_5()
        {
            return Class536.arrayList_0[Class536.arrayList_0.Count - 1];
        }

        private static void smethod_6()
        {
            Class536.arrayList_0.RemoveAt(Class536.arrayList_0.Count - 1);
        }

        private static Class398 smethod_7(Class398 A_0)
        {
            if (stack_0.Count == 0)
            {
                Class399 class2 = A_0 as Class399;
                if (class2 != null)
                {
                    Class446 class3 = class2.class445_1 as Class446;
                    if (class3 != null)
                    {
                        int num = Class890.smethod_2(class3.uint_0);
                        Class399 class4 = new Class399(new Class500(class3.uint_0, num), class3);
                        Class536.arrayList_0.Add(class4);
                        for (int j = 0; j < arrayList_0.Count; j++)
                        {
                            Class443 class5 = arrayList_0[j] as Class443;
                            if (class5 == null)
                            {
                                Class536.arrayList_0.Add(arrayList_0[j]);
                            }
                            else
                            {
                                Class445 class6 = class5.class445_0;
                                if (class6.Type == Enum17.const_39)
                                {
                                    Class487 class7 = class6 as Class487;
                                    class7.class445_0 = new Class499(num);
                                }
                                Class536.arrayList_0.Add(class5);
                            }
                        }
                        class2.class445_1 = new Class499(num);
                        return class2;
                    }
                }
            }
            for (int i = 0; i < arrayList_0.Count; i++)
            {
                Class536.arrayList_0.Add(arrayList_0[i]);
            }
            return A_0;
        }

        private static void smethod_8()
        {
            Class826 class2 = class822_0 as Class826;
            Class445 class3 = smethod_1();
            int index = int_0;
            Class822 class4 = class822_1;
            bool flag = bool_0;
            int num2 = stack_1.Count - 1;
            if (num2 >= 0)
            {
                for (int i = 0; i < num2; i++)
                {
                    stack_2.Push(stack_1.Pop());
                }
                Class445 class5 = stack_1.Peek() as Class445;
                class822_1 = hashtable_0[class5] as Class822;
                bool_0 = true;
                for (int j = 0; j < num2; j++)
                {
                    stack_1.Push(stack_2.Pop());
                }
            }
            Class822 class6 = arrayList_1[++index] as Class822;
            if ((class6.enum45_0 == Enum45.const_24) || (class6.enum45_0 == Enum45.const_25))
            {
                bool flag2 = true;
                if (class6.enum45_0 == Enum45.const_24)
                {
                    flag2 = false;
                }
                Class822 class7 = arrayList_1[++index] as Class822;
                if (class7 == class2.class822_0)
                {
                    if ((class7.enum45_0 != Enum45.const_57) && (class7.enum45_0 != Enum45.const_44))
                    {
                        smethod_9(class3, flag2, class6, null, class6.enum45_0 == Enum45.const_25);
                        index--;
                    }
                    else
                    {
                        Class822 class8 = arrayList_1[++index] as Class822;
                        smethod_9(class3, flag2, class6, class8, false);
                    }
                    int_0 = index;
                    return;
                }
            }
            Class822 class9 = class822_2;
            Class822 class10 = arrayList_1[int_0 + 1] as Class822;
            class822_2 = class2.class822_0;
            Class1033.smethod_1(class3, class822_2, class10, arrayList_1);
            int num5 = 0;
            while (Class536.arrayList_0.Count > 0)
            {
                index = Class536.arrayList_0.Count - 1;
                if (!Class1033.smethod_4(Class536.arrayList_0[index] as Class419))
                {
                    break;
                }
                Class536.arrayList_0.RemoveAt(index);
                class822_1 = Class1033.class822_0;
                bool_0 = true;
                num5++;
            }
            if (num5 == 0)
            {
                class822_2 = class9;
                Class1033.smethod_3();
                smethod_0(class3);
                class822_1 = class4;
                bool_0 = flag;
            }
        }

        private static void smethod_9(Class445 A_0, bool A_1, Class822 A_2, Class822 A_3, bool A_4)
        {
            Class1036.smethod_0(A_0, A_1, A_2, A_3);
            while (Class536.arrayList_0.Count > 0)
            {
                int index = Class536.arrayList_0.Count - 1;
                if (!Class1036.smethod_1(Class536.arrayList_0[index] as Class419))
                {
                    break;
                }
                Class536.arrayList_0.RemoveAt(index);
                class822_1 = Class1036.class822_0;
                bool_0 = true;
            }
            if ((A_3 == null) && (Class821.smethod_0(A_0).enum11_0 == Enum11.const_22))
            {
                smethod_0(Class1036.smethod_4(A_4));
            }
            else
            {
                smethod_0(Class1036.smethod_3());
            }
        }
    }
}

