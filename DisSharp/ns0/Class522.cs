namespace ns0
{
    using System;
    using System.Collections;

    internal class Class522
    {
        internal ArrayList arrayList_0 = new ArrayList();
        private Class397 class397_0;
        private Class523 class523_0 = new Class523();
        private Class523 class523_1 = new Class523();
        private Class547.Class528 class528_0;
        internal Class867 class867_0;
        internal Hashtable hashtable_0 = new Hashtable();
        internal Hashtable hashtable_1 = new Hashtable();
        private int int_0;
        private static string string_0 = Class537.string_464;

        internal Class522(Class547.Class528 A_1)
        {
            this.class528_0 = A_1;
            Class519.class528_0 = A_1;
            try
            {
                this.method_4(A_1.byte_2);
                this.method_5();
                this.method_6();
                this.method_11();
                this.method_12();
            }
            catch (Exception7 exception)
            {
                A_1.method_1(exception.enum5_0);
            }
            catch
            {
                A_1.method_1(Enum5.const_6);
            }
        }

        internal void method_0(Class397 A_1)
        {
            this.class397_0 = A_1;
            Class519.class528_0 = this.class528_0;
            Class519.smethod_3(this.class528_0.class369_0);
            this.method_1(A_1);
            if (this.class867_0 == null)
            {
                this.method_3(0, this.arrayList_0.Count - 1);
            }
            else
            {
                this.method_2(this.class867_0);
            }
        }

        private void method_1(Class397 A_1)
        {
            if (this.class528_0.short_3 > 0)
            {
                A_1.method_11(new Class340(string_0));
                A_1.int_0++;
                ArrayList list = Class546.class574_0.arrayList_0;
                int num = this.class528_0.int_7;
                for (int i = 0; i < this.class528_0.short_3; i++)
                {
                    Class574.Class636 class2 = list[num + i] as Class574.Class636;
                    A_1.method_11(Class1004.smethod_1(i));
                    Class968.smethod_0(A_1, class2.enum11_0, class2.int_1, class2.byte_0);
                }
                A_1.int_0--;
                A_1.method_8();
            }
        }

        private void method_10(Class1005 A_1)
        {
            this.class867_0 = new Class867(0, this.arrayList_0.Count - 1);
            for (int i = 0; i < A_1.Int32_0; i++)
            {
                Class920 class2 = A_1[i];
                this.class867_0.method_2(new Class867(Enum68.const_1, class2.int_0, class2.int_1, class2.bool_0), true);
                ArrayList list = class2.arrayList_0;
                if (list != null)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        Class1006 class3 = list[j] as Class1006;
                        this.class867_0.method_2(new Class867(Enum68.const_2, class3.uint_0, class3.int_0, class3.int_1), false);
                    }
                }
                if (class2.bool_1)
                {
                    this.class867_0.method_2(new Class867(Enum68.const_3, class2.int_3, class2.int_4), false);
                }
            }
        }

        private void method_11()
        {
            int num = this.arrayList_0.Count - 1;
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class828 class2 = this.arrayList_0[i] as Class828;
                if (((class2 != null) && (class2.short_0 == 0)) && (i < num))
                {
                    Class822 class3 = (Class822) this.hashtable_0[class2.int_0 + class2.int_1];
                    if (((int) this.hashtable_1[class3]) == (i + 1))
                    {
                        class2.bool_0 = true;
                        class3.method_0(class2);
                    }
                }
            }
        }

        private void method_12()
        {
            short num = 0;
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class822 class2 = this.arrayList_0[i] as Class822;
                if (class2.Boolean_0)
                {
                    num = (short) (num + 1);
                    class2.short_1 = num;
                }
            }
        }

        private void method_2(Class867 A_1)
        {
            switch (A_1.enum68_0)
            {
                case Enum68.const_1:
                    this.class397_0.method_11(Class613.class339_125);
                    this.class397_0.method_11(Class518.class337_3);
                    this.class397_0.int_0++;
                    break;

                case Enum68.const_2:
                    this.class397_0.method_11(Class613.class339_14);
                    this.class397_0.method_10(Class518.class337_10);
                    Class968.smethod_1(this.class397_0, A_1.uint_0);
                    this.class397_0.method_10(Class518.class337_12);
                    this.class397_0.method_11(Class518.class337_3);
                    this.class397_0.int_0++;
                    break;

                case Enum68.const_3:
                    this.class397_0.method_11(Class613.class339_42);
                    this.class397_0.method_11(Class518.class337_3);
                    this.class397_0.int_0++;
                    break;
            }
            if (A_1.arrayList_0 == null)
            {
                this.method_3(A_1.int_0, A_1.int_1);
            }
            else
            {
                ArrayList list = A_1.arrayList_0;
                for (int i = 0; i < list.Count; i++)
                {
                    this.method_2(list[i] as Class867);
                }
            }
            switch (A_1.enum68_0)
            {
                case Enum68.const_1:
                case Enum68.const_2:
                case Enum68.const_3:
                    this.class397_0.int_0--;
                    this.class397_0.method_11(Class518.class337_5);
                    return;
            }
        }

        private void method_3(int A_1, int A_2)
        {
            int length;
            int num = 0;
            for (int i = A_1; i <= A_2; i++)
            {
                Class822 class2 = this.arrayList_0[i] as Class822;
                length = Class822.smethod_0(class2.enum45_0).Length;
                num = (length > num) ? length : num;
            }
            num += 2;
            for (int j = A_1; j <= A_2; j++)
            {
                Class822 class4 = this.arrayList_0[j] as Class822;
                if (class4.short_1 > 0)
                {
                    this.class397_0.int_0--;
                    this.class397_0.method_11(Class584.class340_0);
                    this.class397_0.method_10(Class585.smethod_1(class4.short_1));
                    this.class397_0.method_10(Class518.class337_16);
                    this.class397_0.int_0++;
                }
                if (class4.QQQX)
                {
                    Class335 class5 = Class822.smethod_0(class4.enum45_0);
                    this.class397_0.method_11(class5);
                    if (class4.QQQW)
                    {
                        length = class5.Length;
                        this.class397_0.method_10(Class517.smethod_0(num - length));
                        class4.QQUX(this.class397_0);
                    }
                }
            }
        }

        private void method_4(byte[] A_1)
        {
            if (A_1 != null)
            {
                int index = 0;
                int length = A_1.Length;
                while (index < length)
                {
                    int num5;
                    int num6;
                    Class830 class3;
                    int num7;
                    int num2 = index;
                    Class822 class2 = null;
                    Enum45 enum2 = Class905.smethod_0(A_1[index]);
                    index++;
                    if (enum2 == Enum45.const_0)
                    {
                        enum2 = Class905.smethod_1(A_1[index]);
                        index++;
                    }
                    switch (enum2)
                    {
                        case Enum45.const_2:
                        case Enum45.const_3:
                        case Enum45.const_185:
                        case Enum45.const_205:
                        case Enum45.const_207:
                        case Enum45.const_208:
                            class2 = new Class832(num2, enum2);
                            goto Label_05D2;

                        case Enum45.const_4:
                        case Enum45.const_5:
                        case Enum45.const_6:
                        case Enum45.const_7:
                        case Enum45.const_8:
                        case Enum45.const_9:
                        case Enum45.const_10:
                        case Enum45.const_11:
                        case Enum45.const_12:
                        case Enum45.const_13:
                        case Enum45.const_14:
                        case Enum45.const_15:
                        case Enum45.const_22:
                        case Enum45.const_23:
                        case Enum45.const_24:
                        case Enum45.const_25:
                        case Enum45.const_26:
                        case Enum45.const_27:
                        case Enum45.const_28:
                        case Enum45.const_29:
                        case Enum45.const_30:
                        case Enum45.const_31:
                        case Enum45.const_32:
                        case Enum45.const_38:
                        case Enum45.const_39:
                        case Enum45.const_43:
                        case Enum45.const_71:
                        case Enum45.const_72:
                        case Enum45.const_73:
                        case Enum45.const_74:
                        case Enum45.const_75:
                        case Enum45.const_76:
                        case Enum45.const_77:
                        case Enum45.const_78:
                        case Enum45.const_79:
                        case Enum45.const_80:
                        case Enum45.const_81:
                        case Enum45.const_82:
                        case Enum45.const_83:
                        case Enum45.const_84:
                        case Enum45.const_85:
                        case Enum45.const_86:
                        case Enum45.const_87:
                        case Enum45.const_88:
                        case Enum45.const_89:
                        case Enum45.const_90:
                        case Enum45.const_91:
                        case Enum45.const_92:
                        case Enum45.const_93:
                        case Enum45.const_94:
                        case Enum45.const_95:
                        case Enum45.const_96:
                        case Enum45.const_97:
                        case Enum45.const_98:
                        case Enum45.const_99:
                        case Enum45.const_100:
                        case Enum45.const_101:
                        case Enum45.const_102:
                        case Enum45.const_103:
                        case Enum45.const_104:
                        case Enum45.const_105:
                        case Enum45.const_106:
                        case Enum45.const_107:
                        case Enum45.const_108:
                        case Enum45.const_109:
                        case Enum45.const_110:
                        case Enum45.const_111:
                        case Enum45.const_119:
                        case Enum45.const_121:
                        case Enum45.const_129:
                        case Enum45.const_130:
                        case Enum45.const_131:
                        case Enum45.const_132:
                        case Enum45.const_133:
                        case Enum45.const_134:
                        case Enum45.const_135:
                        case Enum45.const_136:
                        case Enum45.const_137:
                        case Enum45.const_138:
                        case Enum45.const_141:
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
                        case Enum45.const_154:
                        case Enum45.const_155:
                        case Enum45.const_156:
                        case Enum45.const_157:
                        case Enum45.const_158:
                        case Enum45.const_159:
                        case Enum45.const_160:
                        case Enum45.const_161:
                        case Enum45.const_162:
                        case Enum45.const_163:
                        case Enum45.const_164:
                        case Enum45.const_165:
                        case Enum45.const_166:
                        case Enum45.const_167:
                        case Enum45.const_168:
                        case Enum45.const_169:
                        case Enum45.const_171:
                        case Enum45.const_174:
                        case Enum45.const_175:
                        case Enum45.const_176:
                        case Enum45.const_177:
                        case Enum45.const_178:
                        case Enum45.const_179:
                        case Enum45.const_180:
                        case Enum45.const_181:
                        case Enum45.const_182:
                        case Enum45.const_183:
                        case Enum45.const_184:
                        case Enum45.const_188:
                        case Enum45.const_189:
                        case Enum45.const_190:
                        case Enum45.const_191:
                        case Enum45.const_192:
                        case Enum45.const_193:
                        case Enum45.const_194:
                        case Enum45.const_195:
                        case Enum45.const_204:
                        case Enum45.const_210:
                        case Enum45.const_211:
                        case Enum45.const_212:
                        case Enum45.const_214:
                        case Enum45.const_227:
                            class2 = new Class825(num2, enum2);
                            goto Label_05D2;

                        case Enum45.const_16:
                        case Enum45.const_17:
                        case Enum45.const_18:
                            class2 = new Class833(num2, enum2, A_1[index]);
                            index++;
                            goto Label_05D2;

                        case Enum45.const_19:
                        case Enum45.const_20:
                        case Enum45.const_21:
                            class2 = new Class835(num2, enum2, A_1[index]);
                            index++;
                            goto Label_05D2;

                        case Enum45.const_33:
                            class2 = new Class824(num2, enum2, (sbyte) A_1[index]);
                            index++;
                            goto Label_05D2;

                        case Enum45.const_34:
                            class2 = new Class823(num2, enum2, BitConverter.ToInt32(A_1, index));
                            index += 4;
                            goto Label_05D2;

                        case Enum45.const_35:
                            class2 = new Class829(num2, enum2, BitConverter.ToInt64(A_1, index));
                            index += 8;
                            goto Label_05D2;

                        case Enum45.const_36:
                            class2 = new Class836(num2, enum2, BitConverter.ToSingle(A_1, index));
                            index += 4;
                            goto Label_05D2;

                        case Enum45.const_37:
                            class2 = new Class838(num2, enum2, BitConverter.ToDouble(A_1, index));
                            index += 8;
                            goto Label_05D2;

                        case Enum45.const_40:
                        case Enum45.const_41:
                        case Enum45.const_42:
                        case Enum45.const_112:
                        case Enum45.const_113:
                        case Enum45.const_114:
                        case Enum45.const_116:
                        case Enum45.const_117:
                        case Enum45.const_118:
                        case Enum45.const_120:
                        case Enum45.const_122:
                        case Enum45.const_123:
                        case Enum45.const_124:
                        case Enum45.const_125:
                        case Enum45.const_126:
                        case Enum45.const_127:
                        case Enum45.const_128:
                        case Enum45.const_139:
                        case Enum45.const_140:
                        case Enum45.const_142:
                        case Enum45.const_170:
                        case Enum45.const_172:
                        case Enum45.const_173:
                        case Enum45.const_196:
                        case Enum45.const_197:
                        case Enum45.const_209:
                        case Enum45.const_213:
                        case Enum45.const_215:
                        case Enum45.const_216:
                        case Enum45.const_217:
                        case Enum45.const_226:
                            class2 = new Class837(num2, enum2, BitConverter.ToUInt32(A_1, index));
                            index += 4;
                            goto Label_05D2;

                        case Enum45.const_44:
                            class2 = new Class828(num2, enum2, ((sbyte) A_1[index]) + 2);
                            index++;
                            goto Label_05D2;

                        case Enum45.const_45:
                        case Enum45.const_46:
                        case Enum45.const_47:
                        case Enum45.const_48:
                        case Enum45.const_49:
                        case Enum45.const_50:
                        case Enum45.const_51:
                        case Enum45.const_52:
                        case Enum45.const_53:
                        case Enum45.const_54:
                        case Enum45.const_55:
                        case Enum45.const_56:
                            class2 = new Class826(num2, enum2, ((sbyte) A_1[index]) + 2);
                            index++;
                            goto Label_05D2;

                        case Enum45.const_57:
                        case Enum45.const_58:
                        case Enum45.const_59:
                        case Enum45.const_60:
                        case Enum45.const_61:
                        case Enum45.const_62:
                        case Enum45.const_63:
                        case Enum45.const_64:
                        case Enum45.const_65:
                        case Enum45.const_66:
                        case Enum45.const_67:
                        case Enum45.const_68:
                        case Enum45.const_69:
                            class2 = new Class826(num2, enum2, BitConverter.ToInt32(A_1, index) + 5);
                            index += 4;
                            goto Label_05D2;

                        case Enum45.const_70:
                            num5 = (int) BitConverter.ToUInt32(A_1, index);
                            num6 = ((num5 + 1) * 4) + 1;
                            class3 = new Class830(num2, num5);
                            index += 4;
                            num7 = 0;
                            goto Label_050B;

                        case Enum45.const_115:
                            class2 = new Class831(num2, BitConverter.ToInt32(A_1, index));
                            index += 4;
                            goto Label_05D2;

                        case Enum45.const_186:
                            class2 = new Class827(num2, enum2, BitConverter.ToInt32(A_1, index) + 5);
                            index += 4;
                            goto Label_05D2;

                        case Enum45.const_187:
                            class2 = new Class827(num2, enum2, ((sbyte) A_1[index]) + 2);
                            index++;
                            goto Label_05D2;

                        case Enum45.const_198:
                        case Enum45.const_199:
                        case Enum45.const_200:
                            class2 = new Class833(num2, enum2, BitConverter.ToUInt16(A_1, index));
                            index += 2;
                            goto Label_05D2;

                        case Enum45.const_201:
                        case Enum45.const_202:
                        case Enum45.const_203:
                            class2 = new Class835(num2, enum2, BitConverter.ToUInt16(A_1, index));
                            index += 2;
                            goto Label_05D2;

                        case Enum45.const_206:
                            class2 = new Class834(num2, enum2, A_1[index]);
                            index++;
                            goto Label_05D2;

                        default:
                            goto Label_05D2;
                    }
                Label_04ED:
                    class3.int_1[num7] = BitConverter.ToInt32(A_1, index) + num6;
                    index += 4;
                    num7++;
                Label_050B:
                    if (num7 < num5)
                    {
                        goto Label_04ED;
                    }
                    class2 = class3;
                Label_05D2:
                    if (class2 != null)
                    {
                        int num3 = this.arrayList_0.Add(class2);
                        this.hashtable_0.Add(num2, class2);
                        this.hashtable_1.Add(class2, num3);
                        this.int_0 = num2;
                    }
                }
            }
        }

        private void method_5()
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class826 class2 = this.arrayList_0[i] as Class826;
                if (class2 != null)
                {
                    int num2 = class2.int_0 + class2.int_1;
                    Class822 class3 = (Class822) this.hashtable_0[num2];
                    class2.class822_0 = class3;
                    if (class3.arrayList_0 == null)
                    {
                        class3.arrayList_0 = new ArrayList();
                    }
                    class3.arrayList_0.Add(class2);
                    class3.short_0 = (short) (class3.short_0 + 1);
                }
                else
                {
                    Class830 class4 = this.arrayList_0[i] as Class830;
                    if (class4 != null)
                    {
                        for (int j = 0; j < class4.int_1.Length; j++)
                        {
                            int num4 = class4.int_0 + class4.int_1[j];
                            Class822 class5 = (Class822) this.hashtable_0[num4];
                            class4.arrayList_1.Add(class5);
                            if (class5.arrayList_0 == null)
                            {
                                class5.arrayList_0 = new ArrayList();
                            }
                            class5.arrayList_0.Add(class4);
                            class5.short_0 = (short) (class5.short_0 + 1);
                        }
                    }
                }
            }
        }

        private void method_6()
        {
            if (this.class528_0.short_4 > 0)
            {
                Class864 class2 = new Class864();
                this.method_7(class2);
                class2.method_4();
                class2.method_5();
                class2.method_6();
                class2.method_7();
                class2.method_8();
                this.class867_0 = new Class867(0, this.arrayList_0.Count - 1);
                class2.method_10(this.class867_0, this.arrayList_0.Count - 1);
            }
        }

        private void method_7(Class864 A_1)
        {
            int num;
            int num2;
            ArrayList list = Class546.class578_0.arrayList_0;
            int num3 = this.class528_0.int_8;
            for (int i = 0; i < this.class528_0.short_4; i++)
            {
                Class578.Class869 class2 = list[num3 + i] as Class578.Class869;
                num = (int) this.hashtable_1[this.hashtable_0[class2.int_0]];
                num2 = ((int) this.hashtable_1[this.hashtable_0[class2.int_0 + class2.int_1]]) - 1;
                A_1.method_0(num, num2, class2.int_0, class2.int_0 + class2.int_1);
                if (!class2.Boolean_1)
                {
                    if ((class2.int_2 + class2.int_3) <= this.int_0)
                    {
                        A_1.method_1(num, num2, (int) this.hashtable_1[this.hashtable_0[class2.int_2]], ((int) this.hashtable_1[this.hashtable_0[class2.int_2 + class2.int_3]]) - 1, class2.int_2, class2.int_2 + class2.int_3, class2.uint_0);
                    }
                    else
                    {
                        A_1.method_1(num, num2, (int) this.hashtable_1[this.hashtable_0[class2.int_2]], this.arrayList_0.Count - 1, class2.int_2, 0xffffff, class2.uint_0);
                    }
                }
            }
            A_1.method_3(this);
            for (int j = 0; j < this.class528_0.short_4; j++)
            {
                Class578.Class869 class3 = list[num3 + j] as Class578.Class869;
                num = (int) this.hashtable_1[this.hashtable_0[class3.int_0]];
                num2 = ((int) this.hashtable_1[this.hashtable_0[class3.int_0 + class3.int_1]]) - 1;
                A_1.method_0(num, num2, class3.int_0, class3.int_0 + class3.int_1);
                if (class3.Boolean_1)
                {
                    if ((class3.int_2 + class3.int_3) <= this.int_0)
                    {
                        A_1.method_2(this, num, num2, (int) this.hashtable_1[this.hashtable_0[class3.int_2]], ((int) this.hashtable_1[this.hashtable_0[class3.int_2 + class3.int_3]]) - 1, class3.int_2, class3.int_2 + class3.int_3);
                    }
                    else
                    {
                        A_1.method_2(this, num, num2, (int) this.hashtable_1[this.hashtable_0[class3.int_2]], this.arrayList_0.Count - 1, class3.int_2, 0xffffff);
                    }
                }
            }
        }

        private void method_8()
        {
            if (this.class528_0.short_4 > 0)
            {
                Class1005 class2 = new Class1005();
                this.method_9(class2);
                Class867.bool_3 = true;
                this.method_10(class2);
                this.class523_0.method_0();
                class2.method_6(this.class523_0);
                this.class523_1.method_0();
                this.class867_0.method_3(this.class523_1);
                if (!this.class523_0.method_1(this.class523_1))
                {
                    Class867.bool_3 = false;
                    this.method_10(class2);
                }
                class2.method_5(this.arrayList_0, this.hashtable_1);
            }
        }

        private void method_9(Class1005 A_1)
        {
            ArrayList list = Class546.class578_0.arrayList_0;
            int num = this.class528_0.int_8;
            for (int i = 0; i < this.class528_0.short_4; i++)
            {
                Class578.Class869 class2 = list[num + i] as Class578.Class869;
                if (!class2.Boolean_1)
                {
                    int num2 = (int) this.hashtable_1[this.hashtable_0[class2.int_0]];
                    int num3 = ((int) this.hashtable_1[this.hashtable_0[class2.int_0 + class2.int_1]]) - 1;
                    A_1.method_0(num2, num3, class2.Boolean_0);
                    if ((class2.int_2 + class2.int_3) <= this.int_0)
                    {
                        A_1.method_1(num2, num3, (int) this.hashtable_1[this.hashtable_0[class2.int_2]], ((int) this.hashtable_1[this.hashtable_0[class2.int_2 + class2.int_3]]) - 1, class2.uint_0);
                    }
                    else
                    {
                        A_1.method_1(num2, num3, (int) this.hashtable_1[this.hashtable_0[class2.int_2]], this.arrayList_0.Count - 1, class2.uint_0);
                    }
                }
            }
            for (int j = 0; j < this.class528_0.short_4; j++)
            {
                Class578.Class869 class3 = list[num + j] as Class578.Class869;
                if (class3.Boolean_1)
                {
                    if ((class3.int_2 + class3.int_3) <= this.int_0)
                    {
                        A_1.method_2((int) this.hashtable_1[this.hashtable_0[class3.int_0]], ((int) this.hashtable_1[this.hashtable_0[class3.int_0 + class3.int_1]]) - 1, (int) this.hashtable_1[this.hashtable_0[class3.int_2]], ((int) this.hashtable_1[this.hashtable_0[class3.int_2 + class3.int_3]]) - 1, class3.Boolean_0);
                    }
                    else
                    {
                        A_1.method_2((int) this.hashtable_1[this.hashtable_0[class3.int_0]], ((int) this.hashtable_1[this.hashtable_0[class3.int_0 + class3.int_1]]) - 1, (int) this.hashtable_1[this.hashtable_0[class3.int_2]], this.arrayList_0.Count - 1, class3.Boolean_0);
                    }
                }
            }
        }

        internal class Class523
        {
            internal int int_0;
            internal int int_1;
            internal int int_2;

            internal void method_0()
            {
                this.int_0 = 0;
                this.int_1 = 0;
                this.int_2 = 0;
            }

            internal bool method_1(Class522.Class523 A_1)
            {
                return (((this.int_0 == A_1.int_0) && (this.int_1 == A_1.int_1)) && (this.int_2 == A_1.int_2));
            }
        }
    }
}

