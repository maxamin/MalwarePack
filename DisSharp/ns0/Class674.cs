namespace ns0
{
    using System;
    using System.Collections;

    internal class Class674 : Class673
    {
        private ArrayList[] arrayList_10;
        private ArrayList[] arrayList_11;
        private ArrayList[] arrayList_12;
        private ArrayList[] arrayList_13;
        private ArrayList arrayList_5;
        private ArrayList arrayList_6;
        private ArrayList arrayList_7;
        private ArrayList arrayList_8;
        private ArrayList arrayList_9;
        private bool[] bool_5;

        private void method_100()
        {
            ushort[] numArray = base.class685_0.ushort_2;
            ArrayList list = base.class684_0.class568_0.arrayList_0;
            for (int i = 1; i < numArray.Length; i++)
            {
                ushort num2 = numArray[i];
                if ((num2 & 1) != 0)
                {
                    Class550.Class514 class2 = new Class550.Class514 {
                        enum7_0 = Enum7.const_4
                    };
                    if (this.arrayList_13[i] == null)
                    {
                        this.arrayList_13[i] = new ArrayList();
                    }
                    this.arrayList_13[i].Add(class2);
                }
                if ((num2 & 2) != 0)
                {
                    Class568.Class623 class3 = list[i] as Class568.Class623;
                    if (class3.Boolean_0)
                    {
                        class3.byte_3 = (byte) (class3.byte_3 | 2);
                    }
                    else
                    {
                        Class550.Class514 class4 = new Class550.Class514 {
                            enum7_0 = Enum7.const_5
                        };
                        if (this.arrayList_13[i] == null)
                        {
                            this.arrayList_13[i] = new ArrayList();
                        }
                        this.arrayList_13[i].Add(class4);
                    }
                }
            }
        }

        private Enum15 method_101(uint A_1)
        {
            switch (((uint) ((A_1 & 0x30000) >> 0x10)))
            {
                case 1:
                    return Enum15.const_2;

                case 2:
                    return Enum15.const_0;
            }
            return Enum15.const_1;
        }

        private Class550.Class514 method_102()
        {
            return new Class550.Class514 { 
                enum7_0 = Enum7.const_2,
                int_0 = base.class684_0.class570_0.arrayList_0.Count
            };
        }

        private void method_103()
        {
            uint[] numArray = base.class685_0.uint_0;
            ArrayList list = base.class47_0.class30_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class30.Class912 class2 = list[i] as Class30.Class912;
                Class570.Class625 class3 = new Class570.Class625 {
                    enum12_0 = Enum12.const_0,
                    int_0 = class2.int_0,
                    int_1 = class2.short_0
                };
                int index = class2.int_1;
                this.bool_5[index] = true;
                uint num3 = numArray[index];
                if ((num3 & 8) != 0)
                {
                    class3.enum13_0 = Enum13.const_2;
                }
                else if ((num3 & 0x10) != 0)
                {
                    class3.enum13_0 = Enum13.const_1;
                }
                else
                {
                    class3.enum13_0 = Enum13.const_0;
                }
                class3.enum15_0 = this.method_101(num3);
                Class550.Class514 class4 = this.method_102();
                if (this.arrayList_10[index] == null)
                {
                    this.arrayList_10[index] = new ArrayList();
                }
                this.arrayList_10[index].Add(class4);
                base.class684_0.class570_0.arrayList_0.Add(class3);
            }
        }

        private void method_104()
        {
            uint[] numArray = base.class685_0.uint_0;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (!this.bool_5[i])
                {
                    uint num2 = numArray[i];
                    Enum13 enum2 = Enum13.const_0;
                    if ((num2 & 8) != 0)
                    {
                        enum2 = Enum13.const_2;
                    }
                    else if ((num2 & 0x10) != 0)
                    {
                        enum2 = Enum13.const_1;
                    }
                    Enum15 enum3 = this.method_101(num2);
                    if (((enum2 != Enum13.const_2) || (enum3 != Enum15.const_1)) && ((enum2 != Enum13.const_0) || (enum3 != Enum15.const_1)))
                    {
                        Class570.Class625 class2 = new Class570.Class625 {
                            enum12_0 = Enum12.const_0,
                            enum13_0 = enum2,
                            enum15_0 = enum3
                        };
                        Class550.Class514 class3 = this.method_102();
                        if (this.arrayList_10[i] == null)
                        {
                            this.arrayList_10[i] = new ArrayList();
                        }
                        this.arrayList_10[i].Add(class3);
                        base.class684_0.class570_0.arrayList_0.Add(class2);
                    }
                }
            }
        }

        private void method_105()
        {
            ArrayList list = base.class47_0.class31_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class31.Class913 class2 = list[i] as Class31.Class913;
                Class570.Class625 class3 = new Class570.Class625 {
                    enum12_0 = Enum12.const_1,
                    int_0 = class2.int_0
                };
                Class550.Class514 class4 = this.method_102();
                int index = class2.int_1;
                if (this.arrayList_12[index] == null)
                {
                    this.arrayList_12[index] = new ArrayList();
                }
                this.arrayList_12[index].Add(class4);
                base.class684_0.class570_0.arrayList_0.Add(class3);
            }
        }

        private void method_106()
        {
            ArrayList list = base.class47_0.class32_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class32.Class914 class2 = list[i] as Class32.Class914;
                base.class48_0.method_3(base.int_2 + class2.int_1);
                int num2 = base.class48_0.method_21();
                byte num3 = base.class48_0.method_8();
                int num4 = 0;
                if (num2 > 1)
                {
                    try
                    {
                        num4 = base.class48_0.method_21();
                    }
                    catch
                    {
                    }
                }
                Class570.Class625 class3 = new Class570.Class625 {
                    enum12_0 = Enum12.const_2,
                    byte_0 = num3,
                    int_0 = num4
                };
                Class550.Class514 class4 = this.method_102();
                int index = class2.int_0;
                if (class2.enum0_0 != Enum0.const_4)
                {
                    if (this.arrayList_13[index] == null)
                    {
                        this.arrayList_13[index] = new ArrayList();
                    }
                    this.arrayList_13[index].Add(class4);
                }
                else
                {
                    if (this.arrayList_12[index] == null)
                    {
                        this.arrayList_12[index] = new ArrayList();
                    }
                    this.arrayList_12[index].Add(class4);
                }
                base.class684_0.class570_0.arrayList_0.Add(class3);
            }
        }

        private void method_107()
        {
            ArrayList list = base.class47_0.class33_0.arrayList_0;
            ArrayList list2 = base.class47_0.class21_0.arrayList_0;
            ArrayList list3 = base.class684_0.class547_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class33.Class915 class2 = list[i] as Class33.Class915;
                Class570.Class625 class3 = new Class570.Class625 {
                    enum12_0 = Enum12.const_3
                };
                Class21.Class884 class4 = list2[class2.int_2] as Class21.Class884;
                class3.int_0 = base.method_4(class4.int_0);
                string str = base.method_2(class2.int_1);
                int index = class2.int_0;
                Class547.Class528 class5 = list3[index] as Class547.Class528;
                if (base.class581_0[class5.int_1] != str)
                {
                    class3.int_1 = base.class581_0.method_0(str);
                }
                ushort num3 = class2.ushort_0;
                switch ((num3 & 6))
                {
                    case 2:
                        class3.enum15_0 = Enum15.const_1;
                        break;

                    case 4:
                        class3.enum15_0 = Enum15.const_2;
                        break;

                    case 6:
                        class3.enum15_0 = Enum15.const_0;
                        break;

                    default:
                        class3.enum15_0 = Enum15.const_1;
                        break;
                }
                if ((num3 & 0x40) != 0)
                {
                    class3.bool_0 = true;
                }
                else
                {
                    class3.bool_0 = false;
                }
                switch (((num3 & 0x700) >> 8))
                {
                    case 1:
                        class3.enum14_0 = Enum14.const_4;
                        break;

                    case 2:
                        class3.enum14_0 = Enum14.const_0;
                        break;

                    case 3:
                        class3.enum14_0 = Enum14.const_2;
                        break;

                    case 4:
                        class3.enum14_0 = Enum14.const_3;
                        break;

                    case 5:
                        class3.enum14_0 = Enum14.const_1;
                        break;

                    default:
                        class3.enum14_0 = Enum14.const_0;
                        break;
                }
                Class550.Class514 class6 = this.method_102();
                if (this.arrayList_11[index] == null)
                {
                    this.arrayList_11[index] = new ArrayList();
                }
                this.arrayList_11[index].Add(class6);
                base.class684_0.class570_0.arrayList_0.Add(class3);
            }
        }

        internal void method_90()
        {
            this.arrayList_5 = base.class684_0.class550_0.arrayList_0;
            this.arrayList_6 = base.class684_0.class548_0.arrayList_0;
            this.arrayList_7 = base.class684_0.class547_0.arrayList_0;
            this.arrayList_8 = base.class684_0.class549_0.arrayList_0;
            this.arrayList_9 = base.class684_0.class568_0.arrayList_0;
            this.arrayList_10 = new ArrayList[this.arrayList_6.Count];
            this.arrayList_11 = new ArrayList[this.arrayList_7.Count];
            this.arrayList_12 = new ArrayList[this.arrayList_8.Count];
            this.arrayList_13 = new ArrayList[this.arrayList_9.Count];
            this.method_91();
            this.method_94();
            this.method_99();
            this.method_93();
            this.method_98();
        }

        private void method_91()
        {
            ArrayList list = base.class47_0.class12_0.arrayList_0;
            if (list.Count > 1)
            {
                Class12.Class861 class2 = list[1] as Class12.Class861;
                Class637 class3 = base.class394_0.class637_0;
                class3.ushort_0 = class2.ushort_0;
                class3.ushort_1 = class2.ushort_1;
                class3.ushort_2 = class2.ushort_2;
                class3.ushort_3 = class2.ushort_3;
                class3.int_0 = base.method_4(class2.int_2);
            }
        }

        private Class550.Class514 method_92(Class13.Class876 A_1)
        {
            Class550.Class514 class2 = new Class550.Class514();
            Enum0 enum2 = A_1.enum0_1;
            if (enum2 != Enum0.const_6)
            {
                if (enum2 != Enum0.const_10)
                {
                    class2.enum7_0 = Enum7.const_10;
                }
                else
                {
                    class2.enum7_0 = Enum7.const_1;
                }
            }
            else
            {
                class2.enum7_0 = Enum7.const_0;
            }
            class2.int_0 = A_1.int_1;
            base.class48_0.method_3(base.int_2 + A_1.int_2);
            int num = base.class48_0.method_21() - 2;
            base.class48_0.int_0 += 2;
            class2.byte_0 = base.class48_0.method_19(num);
            return class2;
        }

        private void method_93()
        {
            ArrayList list = base.class47_0.class13_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class13.Class876 class2 = list[i] as Class13.Class876;
                int index = class2.int_0;
                switch (class2.enum0_0)
                {
                    case Enum0.const_0:
                    {
                        Class550.Class514 class4 = this.method_92(class2);
                        class4.enum8_0 = Enum8.const_1;
                        this.arrayList_5.Add(class4);
                        break;
                    }
                    case Enum0.const_2:
                        if (this.arrayList_10[index] == null)
                        {
                            this.arrayList_10[index] = new ArrayList();
                        }
                        this.arrayList_10[index].Add(this.method_92(class2));
                        break;

                    case Enum0.const_4:
                        if (this.arrayList_12[index] == null)
                        {
                            this.arrayList_12[index] = new ArrayList();
                        }
                        this.arrayList_12[index].Add(this.method_92(class2));
                        break;

                    case Enum0.const_6:
                        if (this.arrayList_11[index] == null)
                        {
                            this.arrayList_11[index] = new ArrayList();
                        }
                        this.arrayList_11[index].Add(this.method_92(class2));
                        break;

                    case Enum0.const_8:
                        if (this.arrayList_13[index] == null)
                        {
                            this.arrayList_13[index] = new ArrayList();
                        }
                        this.arrayList_13[index].Add(this.method_92(class2));
                        break;

                    case Enum0.const_20:
                        if (base.struct4_1[index].class369_0 != null)
                        {
                            if (base.struct4_1[index].arrayList_0 == null)
                            {
                                base.struct4_1[index].arrayList_0 = new ArrayList();
                            }
                            base.struct4_1[index].arrayList_0.Add(this.method_92(class2));
                        }
                        break;

                    case Enum0.const_23:
                        if (base.struct4_0[index].class369_0 != null)
                        {
                            if (base.struct4_0[index].arrayList_0 == null)
                            {
                                base.struct4_0[index].arrayList_0 = new ArrayList();
                            }
                            base.struct4_0[index].arrayList_0.Add(this.method_92(class2));
                        }
                        break;

                    case Enum0.const_32:
                    {
                        Class550.Class514 class3 = this.method_92(class2);
                        class3.enum8_0 = Enum8.const_2;
                        this.arrayList_5.Add(class3);
                        break;
                    }
                }
            }
        }

        private void method_94()
        {
            this.method_95();
            this.method_96();
            this.method_97();
        }

        private void method_95()
        {
            ArrayList list = base.class684_0.class547_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class547.Class528 class2 = list[i] as Class547.Class528;
                if (class2.Boolean_20)
                {
                    Class550.Class514 class3 = new Class550.Class514 {
                        enum7_0 = Enum7.const_6
                    };
                    if (this.arrayList_11[i] == null)
                    {
                        this.arrayList_11[i] = new ArrayList();
                    }
                    this.arrayList_11[i].Add(class3);
                }
                if (class2.Boolean_21)
                {
                    Class550.Class514 class4 = new Class550.Class514 {
                        enum7_0 = Enum7.const_7
                    };
                    if (this.arrayList_11[i] == null)
                    {
                        this.arrayList_11[i] = new ArrayList();
                    }
                    this.arrayList_11[i].Add(class4);
                }
            }
        }

        private void method_96()
        {
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class548.Class529 class2 = list[i] as Class548.Class529;
                if (class2.Boolean_8)
                {
                    Class550.Class514 class3 = new Class550.Class514 {
                        enum7_0 = Enum7.const_8
                    };
                    if (this.arrayList_10[i] == null)
                    {
                        this.arrayList_10[i] = new ArrayList();
                    }
                    this.arrayList_10[i].Add(class3);
                }
                if (class2.Boolean_9)
                {
                    Class550.Class514 class4 = new Class550.Class514 {
                        enum7_0 = Enum7.const_3
                    };
                    if (this.arrayList_10[i] == null)
                    {
                        this.arrayList_10[i] = new ArrayList();
                    }
                    this.arrayList_10[i].Add(class4);
                }
            }
        }

        private void method_97()
        {
            ArrayList list = base.class684_0.class549_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class549.Class530 class2 = list[i] as Class549.Class530;
                if (class2.Boolean_7)
                {
                    Class550.Class514 class3 = new Class550.Class514 {
                        enum7_0 = Enum7.const_9
                    };
                    if (this.arrayList_12[i] == null)
                    {
                        this.arrayList_12[i] = new ArrayList();
                    }
                    this.arrayList_12[i].Add(class3);
                }
            }
        }

        private void method_98()
        {
            for (int i = 1; i < this.arrayList_6.Count; i++)
            {
                if (this.arrayList_10[i] != null)
                {
                    Class548.Class529 class2 = this.arrayList_6[i] as Class548.Class529;
                    ArrayList list = this.arrayList_10[i];
                    class2.int_6 = this.arrayList_5.Count;
                    class2.short_3 = (short) list.Count;
                    for (int num2 = 0; num2 < list.Count; num2++)
                    {
                        this.arrayList_5.Add(list[num2]);
                    }
                }
            }
            for (int j = 1; j < this.arrayList_7.Count; j++)
            {
                if (this.arrayList_11[j] != null)
                {
                    Class547.Class528 class3 = this.arrayList_7[j] as Class547.Class528;
                    ArrayList list2 = this.arrayList_11[j];
                    class3.int_3 = this.arrayList_5.Count;
                    class3.short_1 = (short) list2.Count;
                    for (int num4 = 0; num4 < list2.Count; num4++)
                    {
                        this.arrayList_5.Add(list2[num4]);
                    }
                }
            }
            for (int k = 1; k < this.arrayList_8.Count; k++)
            {
                if (this.arrayList_12[k] != null)
                {
                    Class549.Class530 class4 = this.arrayList_8[k] as Class549.Class530;
                    ArrayList list3 = this.arrayList_12[k];
                    class4.int_3 = this.arrayList_5.Count;
                    class4.short_0 = (short) list3.Count;
                    for (int num6 = 0; num6 < list3.Count; num6++)
                    {
                        this.arrayList_5.Add(list3[num6]);
                    }
                }
            }
            for (int m = 1; m < this.arrayList_9.Count; m++)
            {
                if (this.arrayList_13[m] != null)
                {
                    Class568.Class623 class5 = this.arrayList_9[m] as Class568.Class623;
                    ArrayList list4 = this.arrayList_13[m];
                    class5.int_2 = this.arrayList_5.Count;
                    class5.short_0 = (short) list4.Count;
                    for (int num8 = 0; num8 < list4.Count; num8++)
                    {
                        this.arrayList_5.Add(list4[num8]);
                    }
                }
            }
            for (int n = 1; n < base.struct4_0.Length; n++)
            {
                if ((base.struct4_0[n].class369_0 != null) && (base.struct4_0[n].arrayList_0 != null))
                {
                    ArrayList list5 = base.struct4_0[n].arrayList_0;
                    if (base.struct4_0[n].enum39_0 == Enum39.const_1)
                    {
                        Class384 class6 = base.struct4_0[n].class369_0 as Class384;
                        class6.int_2 = this.arrayList_5.Count;
                        class6.short_0 = (short) list5.Count;
                        for (int num10 = 0; num10 < list5.Count; num10++)
                        {
                            this.arrayList_5.Add(list5[num10]);
                        }
                    }
                    if (base.struct4_0[n].enum39_0 == Enum39.const_2)
                    {
                        Class382 class7 = base.struct4_0[n].class369_0 as Class382;
                        class7.int_2 = this.arrayList_5.Count;
                        class7.short_0 = (short) list5.Count;
                        for (int num11 = 0; num11 < list5.Count; num11++)
                        {
                            this.arrayList_5.Add(list5[num11]);
                        }
                    }
                }
            }
            for (int num12 = 1; num12 < base.struct4_1.Length; num12++)
            {
                if ((base.struct4_1[num12].class369_0 != null) && (base.struct4_1[num12].arrayList_0 != null))
                {
                    Class381 class8 = base.struct4_1[num12].class369_0 as Class381;
                    ArrayList list6 = base.struct4_1[num12].arrayList_0;
                    class8.int_2 = this.arrayList_5.Count;
                    class8.short_0 = (short) list6.Count;
                    for (int num13 = 0; num13 < list6.Count; num13++)
                    {
                        this.arrayList_5.Add(list6[num13]);
                    }
                }
            }
        }

        private void method_99()
        {
            this.bool_5 = new bool[base.class684_0.class548_0.arrayList_0.Count];
            this.method_100();
            this.method_103();
            this.method_104();
            this.method_105();
            this.method_106();
            this.method_107();
        }
    }
}

