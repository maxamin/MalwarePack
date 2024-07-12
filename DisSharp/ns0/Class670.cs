namespace ns0
{
    using System;
    using System.Collections;

    internal class Class670 : Class669
    {
        internal void method_70()
        {
            ArrayList list = base.class684_0.class547_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class547.Class528 class2 = list[i] as Class547.Class528;
                try
                {
                    int num3 = base.class682_0.method_1(base.class685_0.int_0[i]);
                    if (num3 == -1)
                    {
                        class2.method_1(Enum5.const_0);
                    }
                    else
                    {
                        int num;
                        base.class48_0.method_3(num3);
                        byte num4 = base.class48_0.method_8();
                        if ((num4 & 3) == 2)
                        {
                            num = num4 >> 2;
                            class2.byte_2 = base.class48_0.method_19(num);
                            class2.int_7 = base.class574_0.arrayList_0.Count;
                        }
                        else
                        {
                            bool flag = (num4 & 8) != 0;
                            base.class48_0.int_0 += 3;
                            num = base.class48_0.method_11();
                            int num5 = base.class48_0.method_11() & 0xffffff;
                            class2.byte_2 = base.class48_0.method_19(num);
                            if (flag)
                            {
                                try
                                {
                                    this.method_71(class2, num);
                                }
                                catch (Exception7 exception)
                                {
                                    class2.method_1(exception.enum5_0);
                                }
                            }
                            if (num5 > 0)
                            {
                                this.method_72(class2, num5);
                            }
                        }
                        try
                        {
                            this.method_73(class2.byte_2, class2, i);
                        }
                        catch (Exception7 exception2)
                        {
                            class2.method_1(exception2.enum5_0);
                        }
                        catch
                        {
                            class2.method_1(Enum5.const_3);
                        }
                    }
                }
                catch
                {
                    class2.method_1(Enum5.const_1);
                }
            }
        }

        private void method_71(Class547.Class528 A_1, int A_2)
        {
            int num = A_2 % 4;
            if (num != 0)
            {
                for (int i = 0; i < (4 - num); i++)
                {
                    base.class48_0.method_8();
                }
            }
            bool flag = true;
            Class578 class2 = base.class684_0.class578_0;
            A_1.int_8 = class2.arrayList_0.Count;
            while (flag)
            {
                int num3;
                byte num4 = base.class48_0.method_8();
                flag = (num4 & 0x80) != 0;
                if ((num4 & 0x40) == 0)
                {
                    num3 = (base.class48_0.method_8() - 4) / 12;
                    base.class48_0.method_9();
                    while (num3 > 0)
                    {
                        ushort num5 = base.class48_0.method_10();
                        ushort num6 = base.class48_0.method_10();
                        byte num7 = base.class48_0.method_8();
                        ushort num8 = base.class48_0.method_10();
                        byte num9 = base.class48_0.method_8();
                        uint num10 = base.class48_0.method_14();
                        class2.method_0(A_1, num5, num6, num7, num8, num9, num10);
                        num3--;
                    }
                }
                else
                {
                    num3 = base.class48_0.method_8() + (base.class48_0.method_8() << 8);
                    num3 += base.class48_0.method_8() << 0x10;
                    for (num3 = (num3 - 4) / 0x18; num3 > 0; num3--)
                    {
                        uint num11 = base.class48_0.method_14();
                        int num12 = base.class48_0.method_11();
                        int num13 = base.class48_0.method_11();
                        int num14 = base.class48_0.method_11();
                        int num15 = base.class48_0.method_11();
                        uint num16 = base.class48_0.method_14();
                        class2.method_0(A_1, num11, num12, num13, num14, num15, num16);
                    }
                }
            }
            A_1.short_4 = (short) (class2.arrayList_0.Count - A_1.int_8);
        }

        private void method_72(Class547.Class528 A_1, int A_2)
        {
            Class20.Class883 class2 = base.class47_0.class20_0.arrayList_0[A_2] as Class20.Class883;
            base.class48_0.method_3(base.int_2 + class2.int_0);
            base.class48_0.method_21();
            if (base.class48_0.method_8() != 7)
            {
                throw new Exception3();
            }
            int num2 = base.class48_0.method_21();
            A_1.short_3 = (short) num2;
            A_1.int_7 = base.class574_0.arrayList_0.Count;
            for (int i = 0; i < num2; i++)
            {
                Class574.Class636 class3 = new Class574.Class636();
                base.method_7(class3);
                base.class574_0.arrayList_0.Add(class3);
            }
        }

        private void method_73(byte[] A_1, Class547.Class528 A_2, int A_3)
        {
            uint num = Class689.smethod_0(Enum0.const_6, A_3);
            ArrayList list = base.class684_0.class547_0.arrayList_0;
            int index = 0;
            int[] src = new int[1];
            int num3 = A_1.Length - 1;
            while (index < num3)
            {
                uint num4;
                Enum0 enum3;
                Enum45 enum2 = Class905.smethod_0(A_1[index]);
                index++;
                if (enum2 == Enum45.const_0)
                {
                    if (index > num3)
                    {
                        throw new Exception7(Enum5.const_2);
                    }
                    enum2 = Class905.smethod_1(A_1[index]);
                    index++;
                }
                switch (enum2)
                {
                    case Enum45.const_2:
                    case Enum45.const_3:
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
                    case Enum45.const_185:
                    case Enum45.const_188:
                    case Enum45.const_189:
                    case Enum45.const_190:
                    case Enum45.const_191:
                    case Enum45.const_192:
                    case Enum45.const_193:
                    case Enum45.const_194:
                    case Enum45.const_195:
                    case Enum45.const_204:
                    case Enum45.const_205:
                    case Enum45.const_207:
                    case Enum45.const_208:
                    case Enum45.const_210:
                    case Enum45.const_211:
                    case Enum45.const_212:
                    case Enum45.const_214:
                    case Enum45.const_218:
                    case Enum45.const_219:
                    case Enum45.const_220:
                    case Enum45.const_221:
                    case Enum45.const_222:
                    case Enum45.const_223:
                    case Enum45.const_224:
                    case Enum45.const_225:
                    case Enum45.const_227:
                    {
                        continue;
                    }
                    case Enum45.const_16:
                    case Enum45.const_17:
                    case Enum45.const_18:
                    case Enum45.const_19:
                    case Enum45.const_20:
                    case Enum45.const_21:
                    case Enum45.const_33:
                    case Enum45.const_44:
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
                    case Enum45.const_187:
                    case Enum45.const_206:
                    {
                        index++;
                        continue;
                    }
                    case Enum45.const_34:
                    case Enum45.const_36:
                    case Enum45.const_40:
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
                    case Enum45.const_113:
                    case Enum45.const_114:
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
                    case Enum45.const_186:
                    case Enum45.const_209:
                    case Enum45.const_213:
                    case Enum45.const_215:
                    case Enum45.const_216:
                    case Enum45.const_217:
                    case Enum45.const_226:
                    {
                        index += 4;
                        continue;
                    }
                    case Enum45.const_35:
                    case Enum45.const_37:
                    {
                        index += 8;
                        continue;
                    }
                    case Enum45.const_41:
                    case Enum45.const_42:
                    case Enum45.const_112:
                    case Enum45.const_116:
                    case Enum45.const_196:
                    case Enum45.const_197:
                    {
                        num4 = BitConverter.ToUInt32(A_1, index);
                        enum3 = (Enum0) ((byte) ((num4 & -16777216) >> 0x18));
                        int num6 = ((int) num4) & 0xffffff;
                        if (enum3 != Enum0.const_6)
                        {
                            goto Label_04DD;
                        }
                        A_2.class907_0.method_1(num4);
                        Class547.Class528 class2 = list[num6] as Class547.Class528;
                        class2.class907_1.method_1(num);
                        goto Label_04F0;
                    }
                    case Enum45.const_70:
                    {
                        uint num7 = BitConverter.ToUInt32(A_1, index);
                        index += (int) ((num7 + 1) * 4);
                        continue;
                    }
                    case Enum45.const_115:
                        num4 = BitConverter.ToUInt32(A_1, index);
                        if ((num4 & 0xff000000) != 0x70000000)
                        {
                            throw new Exception7(Enum5.const_2);
                        }
                        break;

                    case Enum45.const_198:
                    case Enum45.const_199:
                    case Enum45.const_200:
                    case Enum45.const_201:
                    case Enum45.const_202:
                    case Enum45.const_203:
                    {
                        index += 2;
                        continue;
                    }
                    default:
                    {
                        continue;
                    }
                }
                num4 &= 0xffffff;
                base.class48_0.method_3(base.int_1 + ((int) num4));
                int num5 = Class906.smethod_0(base.class48_0.method_21());
                src[0] = base.class581_0.method_0(base.class48_0.method_24(num5));
                Buffer.BlockCopy(src, 0, A_1, index, 4);
                index += 4;
                continue;
            Label_04DD:
                if (enum3 == Enum0.const_10)
                {
                    A_2.class907_0.method_1(num4);
                }
            Label_04F0:
                index += 4;
            }
        }
    }
}

