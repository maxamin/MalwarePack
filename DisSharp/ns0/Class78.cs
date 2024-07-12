namespace ns0
{
    using System;

    internal abstract class Class78 : Class77
    {
        internal bool bool_6;
        internal bool bool_7;
        internal bool bool_8;
        internal Class369 class369_0;
        internal Enum0 enum0_0;
        internal int int_16;
        internal string string_32;

        protected Class78()
        {
        }

        internal void method_208(uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int index = ((int) A_1) & 0xffffff;
            Enum0 enum3 = enum2;
            if (enum3 > Enum0.const_10)
            {
                if (enum3 == Enum0.const_27)
                {
                    this.QRVQ(index);
                    base.method_3(base.class367_0);
                }
                else if (enum3 == Enum0.const_43)
                {
                    base.method_187(index, Enum18.const_2);
                }
            }
            else
            {
                switch (enum3)
                {
                    case Enum0.const_1:
                        if (!Class519.class604_0.method_2(index))
                        {
                            Class553.Class531 class3 = Class546.class553_0.arrayList_0[index] as Class553.Class531;
                            base.method_53(class3);
                            return;
                        }
                        base.method_9(Class519.class604_0.class335_0);
                        return;

                    case Enum0.const_2:
                    {
                        Class548.Class529 class2 = Class546.class548_0.arrayList_0[index] as Class548.Class529;
                        base.method_48(class2);
                        return;
                    }
                    case Enum0.const_3:
                    case Enum0.const_5:
                        return;

                    case Enum0.const_4:
                    {
                        Class549.Class530 class7 = Class546.class549_0.arrayList_0[index] as Class549.Class530;
                        if (!base.bool_0)
                        {
                            base.method_57(class7);
                            return;
                        }
                        base.method_154(class7);
                        return;
                    }
                    case Enum0.const_6:
                        break;

                    case Enum0.const_10:
                    {
                        Class551.Class544 class4 = Class546.class551_0.arrayList_0[index] as Class551.Class544;
                        if (class4.enum9_0 != Enum9.const_1)
                        {
                            if (class4.enum9_0 == Enum9.const_2)
                            {
                                Class552.Class545 class6 = Class546.class552_0.arrayList_0[class4.int_0] as Class552.Class545;
                                if (class4.enum21_0 < Enum21.const_5)
                                {
                                    if (base.bool_0)
                                    {
                                        base.method_157(class6);
                                        return;
                                    }
                                    base.method_67(class6);
                                    return;
                                }
                                base.method_71(class6.enum11_0, class6.int_2);
                                this.QQZZ();
                                int num2 = (class4.enum21_0 == Enum21.const_8) ? 1 : 0;
                                for (int i = 0; i < ((class6.short_0 - 1) - num2); i++)
                                {
                                    base.method_9(Class518.class337_14);
                                }
                                this.QRQQ();
                                base.method_3(base.class367_0);
                                return;
                            }
                            if (class4.enum9_0 == Enum9.const_3)
                            {
                                index = class4.int_0;
                                break;
                            }
                            if (class4.enum9_0 == Enum9.const_4)
                            {
                                if (base.bool_0)
                                {
                                    base.method_161(class4.int_0);
                                    return;
                                }
                                base.method_70(class4.int_0);
                            }
                            return;
                        }
                        Class555.Class600 class5 = Class546.class555_0.arrayList_0[class4.int_0] as Class555.Class600;
                        if (base.bool_0)
                        {
                            base.method_155(class5);
                            return;
                        }
                        base.method_60(class5);
                        return;
                    }
                    default:
                        return;
                }
                Class547.Class528 class8 = Class546.class547_0.arrayList_0[index] as Class547.Class528;
                if (base.bool_0)
                {
                    base.method_156(class8);
                }
                else
                {
                    base.method_63(class8);
                }
            }
        }

        internal void method_209(uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            if (enum2 == Enum0.const_6)
            {
                Class547.Class528 class2 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
                Class548.Class529 class3 = (class2.class369_0.class369_0 as Class370).class529_0;
                if (base.bool_0)
                {
                    base.method_160(class2, class3);
                }
                else
                {
                    base.method_48(class3);
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class359(class2.class369_0));
                }
            }
            else
            {
                this.method_208(A_1);
            }
        }

        internal void method_210(uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            switch (enum2)
            {
                case Enum0.const_4:
                {
                    Class549.Class530 class5 = Class546.class549_0.arrayList_0[num] as Class549.Class530;
                    base.method_9(new Class358(class5.class369_0));
                    if (class5.byte_0 > 0)
                    {
                        Class631.bool_0 = true;
                    }
                    if (class5.class369_0.QQQS == Enum10.const_22)
                    {
                        this.bool_6 = true;
                    }
                    break;
                }
                case Enum0.const_10:
                {
                    Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class2.enum9_0 == Enum9.const_4)
                    {
                        Class556.Class601 class3 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                        base.method_9(new Class343(class3));
                    }
                    else
                    {
                        Class555.Class600 class4 = Class546.class555_0.arrayList_0[class2.int_0] as Class555.Class600;
                        base.method_9(new Class347(class4));
                        if (class4.byte_0 > 0)
                        {
                            Class631.bool_0 = true;
                        }
                    }
                    break;
                }
            }
        }

        internal void method_211(uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            switch (enum2)
            {
                case Enum0.const_4:
                {
                    Class549.Class530 class5 = Class546.class549_0.arrayList_0[num] as Class549.Class530;
                    base.method_57(class5);
                    if (class5.byte_0 > 0)
                    {
                        Class631.bool_0 = true;
                    }
                    break;
                }
                case Enum0.const_10:
                {
                    Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class2.enum9_0 == Enum9.const_4)
                    {
                        Class556.Class601 class3 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                        base.method_9(new Class343(class3));
                    }
                    else
                    {
                        Class555.Class600 class4 = Class546.class555_0.arrayList_0[class2.int_0] as Class555.Class600;
                        base.method_60(class4);
                        if (class4.byte_0 > 0)
                        {
                            Class631.bool_0 = true;
                        }
                    }
                    break;
                }
            }
        }

        internal void method_212(uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            Enum0 enum3 = enum2;
            switch (enum3)
            {
                case Enum0.const_6:
                    break;

                case Enum0.const_10:
                {
                    Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class2.enum9_0 == Enum9.const_2)
                    {
                        Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                        base.method_9(new Class348(class3));
                        return;
                    }
                    if (class2.enum9_0 == Enum9.const_4)
                    {
                        Class556.Class601 class4 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                        base.method_9(new Class343(class4));
                        return;
                    }
                    if (class2.enum9_0 == Enum9.const_3)
                    {
                        num = class2.int_0;
                        break;
                    }
                    return;
                }
                default:
                    if (enum3 == Enum0.const_43)
                    {
                        base.method_187(num, Enum18.const_0);
                    }
                    return;
            }
            Class547.Class528 class5 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            base.method_9(new Class359(class5.class369_0));
        }

        internal void method_213(uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            Enum0 enum3 = enum2;
            switch (enum3)
            {
                case Enum0.const_6:
                    break;

                case Enum0.const_10:
                {
                    Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class2.enum9_0 == Enum9.const_2)
                    {
                        Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                        base.method_67(class3);
                        return;
                    }
                    if (class2.enum9_0 == Enum9.const_4)
                    {
                        Class556.Class601 class4 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                        base.method_9(new Class343(class4));
                        return;
                    }
                    if (class2.enum9_0 == Enum9.const_3)
                    {
                        num = class2.int_0;
                        break;
                    }
                    return;
                }
                default:
                    if (enum3 == Enum0.const_43)
                    {
                        base.method_187(num, Enum18.const_1);
                    }
                    return;
            }
            Class547.Class528 class5 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            base.method_63(class5);
        }

        internal void method_214(uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            this.bool_7 = false;
            Enum0 enum3 = enum2;
            if (enum3 != Enum0.const_6)
            {
                if (enum3 != Enum0.const_10)
                {
                    return;
                }
                Class551.Class544 class3 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class3.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class4 = Class546.class552_0.arrayList_0[class3.int_0] as Class552.Class545;
                    Class553.Class531 class5 = Class546.class553_0.arrayList_0[class4.int_0] as Class553.Class531;
                    base.method_53(class5);
                    this.bool_7 = class5.Boolean_1;
                    return;
                }
                if (class3.enum9_0 == Enum9.const_4)
                {
                    Class556.Class601 class6 = Class546.class556_0.arrayList_0[class3.int_0] as Class556.Class601;
                    this.bool_7 = this.QRUZ(class6.int_1);
                    return;
                }
                if (class3.enum9_0 != Enum9.const_3)
                {
                    return;
                }
                num = class3.int_0;
            }
            Class547.Class528 class7 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            Class370 class2 = class7.class369_0.class369_0 as Class370;
            base.method_48(class2.class529_0);
            this.bool_7 = class2.QQTZ;
        }

        internal void method_215(uint A_1)
        {
            this.bool_8 = false;
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            switch (enum2)
            {
                case Enum0.const_1:
                    if (!Class519.class604_0.method_2(num))
                    {
                        Class553.Class531 class3 = Class546.class553_0.arrayList_0[num] as Class553.Class531;
                        base.method_53(class3);
                        return;
                    }
                    base.method_9(Class519.class604_0.class335_0);
                    return;

                case Enum0.const_2:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[num] as Class548.Class529;
                    base.method_48(class2);
                    return;
                }
                case Enum0.const_27:
                    this.QRVQ(num);
                    this.bool_8 = true;
                    return;
            }
        }

        internal void method_216(uint A_1)
        {
            string str;
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            Enum0 enum3 = enum2;
            if (enum3 != Enum0.const_6)
            {
                if (enum3 != Enum0.const_10)
                {
                    return;
                }
                Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class2.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                    str = Class519.class581_0[class3.int_1];
                    if (str.Length > 4)
                    {
                        base.method_9(new Class349(class3));
                        return;
                    }
                    base.method_9(new Class336(str));
                    return;
                }
                if (class2.enum9_0 == Enum9.const_4)
                {
                    Class556.Class601 class4 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                    base.method_9(new Class343(class4));
                    return;
                }
                if (class2.enum9_0 == Enum9.const_3)
                {
                    num = class2.int_0;
                }
                else
                {
                    return;
                }
            }
            Class547.Class528 class5 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            str = Class519.class581_0[class5.int_1];
            if (str.Length > 4)
            {
                base.method_9(new Class360(class5.class369_0.class369_0));
            }
            else
            {
                base.method_9(new Class336(str));
            }
        }

        internal void method_217(uint A_1)
        {
            string str;
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            Enum0 enum3 = enum2;
            if (enum3 != Enum0.const_6)
            {
                if (enum3 != Enum0.const_10)
                {
                    return;
                }
                Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class2.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                    Class553.Class531 class4 = Class546.class553_0.arrayList_0[class3.int_0] as Class553.Class531;
                    base.method_53(class4);
                    base.method_9(Class518.class337_13);
                    str = Class519.class581_0[class3.int_1];
                    if (str.Length > 4)
                    {
                        base.method_9(new Class349(class3));
                        return;
                    }
                    base.method_9(new Class336(str));
                    return;
                }
                if (class2.enum9_0 == Enum9.const_4)
                {
                    Class556.Class601 class5 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                    base.method_9(new Class343(class5));
                    return;
                }
                if (class2.enum9_0 == Enum9.const_3)
                {
                    num = class2.int_0;
                }
                else
                {
                    return;
                }
            }
            Class547.Class528 class6 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            Class369 class7 = class6.class369_0.class369_0;
            base.method_48((class7.class369_0 as Class370).class529_0);
            base.method_9(Class518.class337_13);
            str = Class519.class581_0[class6.int_1];
            if (str.Length > 4)
            {
                base.method_9(new Class360(class7));
            }
            else
            {
                base.method_9(new Class336(str));
            }
        }

        internal Enum22 method_218(uint A_1)
        {
            this.class369_0 = null;
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            Enum0 enum3 = enum2;
            if (enum3 != Enum0.const_6)
            {
                if (enum3 != Enum0.const_10)
                {
                    return Enum22.const_0;
                }
                Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class2.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                    this.enum0_0 = Enum0.const_1;
                    this.int_16 = class3.int_0;
                    switch (class3.enum23_0)
                    {
                        case Enum23.const_1:
                            this.string_32 = Class519.class581_0[class3.int_1].Substring(4);
                            return Enum22.const_1;

                        case Enum23.const_2:
                            this.string_32 = Class519.class581_0[class3.int_1].Substring(7);
                            return Enum22.const_2;

                        case Enum23.const_3:
                            return Enum22.const_3;
                    }
                    return Enum22.const_0;
                }
                if (class2.enum9_0 == Enum9.const_3)
                {
                    num = class2.int_0;
                }
                else
                {
                    if (class2.enum9_0 == Enum9.const_4)
                    {
                        Class556.Class601 class4 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                        this.enum0_0 = class4.enum0_0;
                        this.int_16 = class4.int_0;
                        switch (class4.enum24_0)
                        {
                            case Enum24.const_1:
                                this.string_32 = Class519.class581_0[class4.int_3].Substring(4);
                                return Enum22.const_1;

                            case Enum24.const_2:
                                this.string_32 = Class519.class581_0[class4.int_3].Substring(7);
                                return Enum22.const_2;

                            case Enum24.const_3:
                                return Enum22.const_3;
                        }
                    }
                    return Enum22.const_0;
                }
            }
            Class547.Class528 class5 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            if (class5.Boolean_8)
            {
                this.enum0_0 = Enum0.const_2;
                this.int_16 = (class5.class369_0.class369_0 as Class370).class529_0.int_0;
            }
            switch (class5.enum25_0)
            {
                case Enum25.const_1:
                    this.class369_0 = class5.class369_0.class369_0;
                    return Enum22.const_1;

                case Enum25.const_2:
                    this.class369_0 = class5.class369_0.class369_0;
                    return Enum22.const_2;

                case Enum25.const_3:
                    return Enum22.const_3;
            }
            return Enum22.const_0;
        }
    }
}

