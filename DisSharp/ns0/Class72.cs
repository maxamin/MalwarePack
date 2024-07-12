namespace ns0
{
    using System;

    internal abstract class Class72 : Class71
    {
        private bool bool_5;
        private Class48 class48_5 = new Class48();
        private Class608 class608_2;
        private int int_10;
        private int int_11 = 20;
        private int int_12;
        private int int_13 = 10;
        private int int_14;
        private int int_15 = 10;
        private Struct0[] struct0_1 = new Struct0[20];
        private Struct2[] struct2_0 = new Struct2[10];
        private Struct2[] struct2_1 = new Struct2[10];

        internal Class72()
        {
            this.class48_5 = new Class48();
            this.class608_2 = new Class608(this.class48_5);
        }

        internal void method_187(int A_1, Enum18 A_2)
        {
            Class573.Class534 class2 = Class546.class573_0.arrayList_0[A_1] as Class573.Class534;
            this.class48_5.Byte_0 = class2.byte_0;
            Enum0 enum2 = class2.enum0_0;
            if (enum2 != Enum0.const_6)
            {
                if (enum2 != Enum0.const_10)
                {
                    throw new Exception1();
                }
                Class551.Class544 class4 = Class546.class551_0.arrayList_0[class2.int_0] as Class551.Class544;
                if (class4.enum9_0 == Enum9.const_4)
                {
                    Class556.Class601 class5 = Class546.class556_0.arrayList_0[class4.int_0] as Class556.Class601;
                    if (class5.int_2 == 0)
                    {
                        base.method_9(new Class343(class5));
                    }
                    else
                    {
                        Class547.Class528 class6 = Class546.class547_0.arrayList_0[class5.int_2] as Class547.Class528;
                        base.method_9(new Class359(class6.class369_0));
                    }
                }
                else
                {
                    if (class4.enum9_0 != Enum9.const_2)
                    {
                        throw new Exception1();
                    }
                    Class552.Class545 class7 = Class546.class552_0.arrayList_0[class4.int_0] as Class552.Class545;
                    if (base.bool_0)
                    {
                        base.method_158(class7);
                        base.method_67(class7);
                        this.method_188();
                        base.method_159(class7);
                        return;
                    }
                    base.method_67(class7);
                }
            }
            else
            {
                Class547.Class528 class3 = Class546.class547_0.arrayList_0[class2.int_0] as Class547.Class528;
                switch (A_2)
                {
                    case Enum18.const_0:
                        base.method_9(new Class359(class3.class369_0));
                        break;

                    case Enum18.const_1:
                    case Enum18.const_2:
                        base.method_63(class3);
                        break;
                }
            }
            this.method_188();
        }

        private void method_188()
        {
            if (this.class48_5.method_8() == 10)
            {
                this.QRVS();
                int num2 = this.class48_5.method_21();
                for (int i = 0; i < num2; i++)
                {
                    if (i > 0)
                    {
                        base.method_9(Class518.class337_14);
                    }
                    this.class608_2.method_0();
                    base.method_93(this.class608_2.enum11_0, this.class608_2.int_0, this.class608_2.byte_0);
                }
                this.QRVT();
            }
        }

        private void method_189(Class548.Class529 A_1, int A_2)
        {
            if ((A_1.short_0 != 0) && (A_2 >= A_1.short_1))
            {
                int num = A_2 - A_1.short_1;
                Class559.Class607 class3 = Class546.class559_0.arrayList_0[A_1.int_3 + num] as Class559.Class607;
                base.method_9(new Class351(class3.int_0));
            }
            else
            {
                Class370 class2 = A_1.class369_0.class369_0 as Class370;
                if (class2 != null)
                {
                    this.method_189(class2.class529_0, A_2);
                }
            }
        }

        private void method_190()
        {
            this.class608_2.method_0();
            Enum11 enum2 = this.class608_2.enum11_0;
            int num = this.class608_2.int_0;
            this.method_193();
            int num2 = this.class48_5.method_21();
            for (int i = 0; i < num2; i++)
            {
                this.class608_2.method_0();
                this.method_194(this.class608_2.enum11_0, this.class608_2.int_0, this.class608_2.byte_0, this.class608_2.byte_1);
            }
            this.method_191(enum2, num, this.int_10, 0);
        }

        private void method_191(Enum11 A_1, int A_2, int A_3, int A_4)
        {
            if (A_1 == Enum11.const_36)
            {
                Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_2] as Class548.Class529;
                Class370 class3 = class2.class369_0.class369_0 as Class370;
                if (class3 != null)
                {
                    this.method_191(Enum11.const_36, class3.class529_0.int_0, A_3 - class2.short_0, A_4 + 1);
                }
                else
                {
                    Class562 class4 = Class546.class562_0;
                    if (Class516.Boolean_0)
                    {
                        Class562.Class533 class5 = class4.arrayList_0[class2.int_2] as Class562.Class533;
                        if (class4.bool_1 && (class2.int_2 == class4.int_0))
                        {
                            base.method_9(new Class352(class5.int_1, class4));
                        }
                        else
                        {
                            base.method_9(new Class344(class5.int_1, class5.bool_0));
                        }
                        base.method_9(Class518.class337_13);
                    }
                    if (Class516.bool_24)
                    {
                        class4.bool_0[class2.int_2] = true;
                    }
                }
                base.method_9(new Class357(class2.class369_0));
                if (class2.short_0 > 0)
                {
                    this.QRVS();
                    int num = A_3 - class2.short_0;
                    for (int i = 0; i < class2.short_0; i++)
                    {
                        if (i > 0)
                        {
                            base.method_9(Class518.class337_14);
                        }
                        Struct0 struct2 = this.struct0_1[num + i];
                        this.method_192(struct2.enum11_0, struct2.int_0, struct2.byte_0, struct2.byte_1);
                    }
                    this.QRVT();
                }
                if (A_4 > 0)
                {
                    base.method_9(Class518.class337_13);
                }
                this.bool_5 = class2.class369_0.QQTZ;
            }
            else if (A_1 == Enum11.const_38)
            {
                Class553.Class531 class6 = Class546.class553_0.arrayList_0[A_2] as Class553.Class531;
                if ((class6.enum0_0 == Enum0.const_1) && (class6.int_0 > 0))
                {
                    this.method_191(Enum11.const_38, class6.int_0, A_3 - class6.short_0, A_4 + 1);
                }
                else
                {
                    Class562 class7 = Class546.class562_0;
                    if (Class516.Boolean_0)
                    {
                        Class562.Class533 class8 = class7.arrayList_0[class6.int_2] as Class562.Class533;
                        base.method_9(new Class344(class8.int_1, class8.bool_0));
                        base.method_9(Class518.class337_13);
                    }
                    if (Class516.bool_24)
                    {
                        class7.bool_0[class6.int_2] = true;
                    }
                }
                base.method_9(new Class345(class6));
                if (class6.short_0 > 0)
                {
                    this.QRVS();
                    int num3 = A_3 - class6.short_0;
                    for (int j = 0; j < class6.short_0; j++)
                    {
                        if (j > 0)
                        {
                            base.method_9(Class518.class337_14);
                        }
                        Struct0 struct3 = this.struct0_1[num3 + j];
                        this.method_192(struct3.enum11_0, struct3.int_0, struct3.byte_0, struct3.byte_1);
                    }
                    this.QRVT();
                }
                if (A_4 > 0)
                {
                    base.method_9(Class518.class337_13);
                }
                this.bool_5 = class6.Boolean_1;
            }
        }

        private void method_192(Enum11 A_1, int A_2, byte A_3, byte[] A_4)
        {
            if (A_1 != Enum11.const_45)
            {
                base.method_93(A_1, A_2, A_3);
            }
            else
            {
                this.method_196();
                Struct2 struct2 = this.method_198();
                this.struct0_1 = struct2.struct0_0;
                this.int_10 = struct2.int_0;
                this.int_11 = struct2.int_1;
                this.class48_5 = struct2.class48_0;
                this.class608_2 = struct2.class608_0;
                this.class48_5.Byte_0 = A_4;
                this.method_190();
                this.method_197();
            }
        }

        private void method_193()
        {
            this.int_10 = 0;
        }

        private void method_194(Enum11 A_1, int A_2, byte A_3, byte[] A_4)
        {
            this.int_10++;
            if (this.int_10 >= this.int_11)
            {
                this.int_11 *= 2;
                Struct0[] structArray = this.struct0_1;
                this.struct0_1 = new Struct0[this.int_11];
                for (int i = 0; i < (this.int_10 - 1); i++)
                {
                    this.struct0_1[i] = structArray[i];
                }
            }
            int index = this.int_10 - 1;
            this.struct0_1[index].enum11_0 = A_1;
            this.struct0_1[index].int_0 = A_2;
            this.struct0_1[index].byte_0 = A_3;
            this.struct0_1[index].byte_1 = A_4;
        }

        private void method_195()
        {
            this.int_12 = 0;
            this.int_14 = 0;
        }

        private void method_196()
        {
            this.int_12++;
            if (this.int_12 >= this.int_13)
            {
                this.int_13 *= 2;
                Struct2[] structArray = this.struct2_0;
                this.struct2_0 = new Struct2[this.int_13];
                for (int i = 0; i < (this.int_12 - 1); i++)
                {
                    this.struct2_0[i] = structArray[i];
                }
            }
            int index = this.int_12 - 1;
            this.struct2_0[index].struct0_0 = this.struct0_1;
            this.struct2_0[index].int_0 = this.int_10;
            this.struct2_0[index].int_1 = this.int_11;
            this.struct2_0[index].class48_0 = this.class48_5;
            this.struct2_0[index].class608_0 = this.class608_2;
        }

        private void method_197()
        {
            int index = this.int_12 - 1;
            this.struct0_1 = this.struct2_0[index].struct0_0;
            this.int_10 = this.struct2_0[index].int_0;
            this.int_11 = this.struct2_0[index].int_1;
            this.class48_5 = this.struct2_0[index].class48_0;
            this.class608_2 = this.struct2_0[index].class608_0;
            this.int_12--;
        }

        private Struct2 method_198()
        {
            this.int_14++;
            if (this.int_14 >= this.int_15)
            {
                this.int_15 *= 2;
                Struct2[] structArray = this.struct2_1;
                this.struct2_1 = new Struct2[this.int_15];
                for (int i = 0; i < (this.int_14 - 1); i++)
                {
                    this.struct2_1[i] = structArray[i];
                }
            }
            int index = this.int_14 - 1;
            if (this.struct2_1[index].struct0_0 == null)
            {
                this.struct2_1[index].struct0_0 = new Struct0[20];
                this.struct2_1[index].int_0 = 0;
                this.struct2_1[index].int_1 = 20;
                this.struct2_1[index].class48_0 = new Class48();
                this.struct2_1[index].class608_0 = new Class608(this.struct2_1[index].class48_0);
            }
            return this.struct2_1[index];
        }

        internal override void QRUY(int index)
        {
            Class563.Class616 class2 = Class546.class563_0.arrayList_0[index] as Class563.Class616;
            this.class48_5.Byte_0 = class2.byte_0;
            this.method_195();
            this.method_190();
        }

        internal override bool QRUZ(int index)
        {
            Class557.Class605 class2 = Class546.class557_0.arrayList_0[index] as Class557.Class605;
            this.class48_5.Byte_0 = class2.byte_0;
            if (this.class48_5.method_8() != 0x15)
            {
                return false;
            }
            this.bool_5 = false;
            this.method_190();
            return this.bool_5;
        }

        internal override void QRVQ(int index)
        {
            int num2;
            Class370 class4;
            Class557.Class605 class2 = Class546.class557_0.arrayList_0[index] as Class557.Class605;
            this.class48_5.Byte_0 = class2.byte_0;
            switch (this.class48_5.method_8())
            {
                case 0x13:
                {
                    num2 = this.class48_5.method_21();
                    Class547.Class528 class3 = Class519.class528_0;
                    class4 = class3.class369_0.class369_0 as Class370;
                    if (class4 != null)
                    {
                        break;
                    }
                    class4 = class3.class369_0.class369_0.class369_0 as Class370;
                    if (class4 != null)
                    {
                        break;
                    }
                    return;
                }
                case 0x15:
                    this.QRUZ(index);
                    return;

                case 30:
                {
                    int num3 = this.class48_5.method_21();
                    Class547.Class528 class5 = Class519.class528_0;
                    Class559.Class607 class6 = Class546.class559_0.arrayList_0[class5.int_2 + num3] as Class559.Class607;
                    base.method_9(new Class351(class6.int_0));
                    return;
                }
                default:
                    base.method_83(index);
                    return;
            }
            this.method_189(class4.class529_0, num2);
        }

        internal override void QRVS()
        {
            base.method_9(Class518.class337_39);
        }

        internal override void QRVT()
        {
            base.method_9(Class518.class337_43);
        }

        internal override Class367 QRVU()
        {
            Class367 class2 = new Class367();
            class2.method_0(Class518.class337_39);
            return class2;
        }

        internal override Class335 QRVV()
        {
            return Class518.class337_43;
        }
    }
}

