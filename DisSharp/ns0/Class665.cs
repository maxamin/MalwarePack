namespace ns0
{
    using System;
    using System.Collections;

    internal class Class665 : Class664
    {
        private Class619 class619_4 = new Class619();
        private Class619 class619_5 = new Class619();
        private Class619 class619_6 = new Class619();
        private Class619 class619_7 = new Class619();
        private static string string_43 = Class537.string_78;

        internal void method_53()
        {
            Class6.Class694 class2 = null;
            Class6.Class694 class3 = null;
            Class547.Class528 class5 = null;
            Class391 class7 = null;
            ArrayList list = base.class47_0.class6_0.arrayList_0;
            ArrayList list2 = base.class47_0.class8_0.arrayList_0;
            ArrayList list3 = base.class47_0.class7_0.arrayList_0;
            if ((list.Count > 1) && (list3.Count > 1))
            {
                int num = list.Count - 1;
                int num2 = list3.Count - 1;
                int num3 = 1;
                Class7.Class695 class8 = list3[1] as Class7.Class695;
                for (int i = 1; i < list.Count; i++)
                {
                    int num6;
                    bool flag;
                    if (i == 1)
                    {
                        class2 = list[i] as Class6.Class694;
                    }
                    int num5 = class2.int_1;
                    if (i < num)
                    {
                        class3 = list[i + 1] as Class6.Class694;
                        num6 = class3.int_1 - num5;
                        flag = true;
                    }
                    else
                    {
                        num6 = list2.Count - num5;
                        flag = false;
                    }
                    if (flag)
                    {
                        int num7 = class3.int_1;
                        if (((class3.int_0 == 0) || (num7 < 0)) || (num7 > list2.Count))
                        {
                            continue;
                        }
                    }
                    Class548.Class529 class9 = base.class684_0.class548_0.arrayList_0[class2.int_0] as Class548.Class529;
                    Class369 class10 = class9.class369_0;
                    for (int j = 0; j < num6; j++)
                    {
                        Class547.Class528 class4;
                        Enum36 enum2;
                        Class391 class6;
                        Class8.Class696 class11 = list2[num5 + j] as Class8.Class696;
                        string str = base.method_2(class11.int_0);
                        int num9 = base.method_5(ref str);
                        base.class48_0.method_3(base.int_2 + class11.int_1);
                        base.class48_0.method_21();
                        base.class48_0.method_8();
                        int num10 = base.class48_0.method_21();
                        if (num10 == 0)
                        {
                            Class384 class12 = new Class384 {
                                class369_0 = class10,
                                int_0 = num9
                            };
                            this.method_54(num5 + j, class12, Enum39.const_1);
                            base.method_15(class12);
                            while (class8.enum0_0 == Enum0.const_20)
                            {
                                num3++;
                                class8 = list3[num3] as Class7.Class695;
                            }
                            int num11 = class8.int_1;
                            int num12 = 1;
                            enum2 = base.method_0(class8.ushort_0);
                            class4 = base.class684_0.class547_0.arrayList_0[class8.int_0] as Class547.Class528;
                            base.bool_0[class8.int_0] = true;
                            if (num3 < num2)
                            {
                                num3++;
                                class8 = list3[num3] as Class7.Class695;
                                if ((class8.enum0_0 == Enum0.const_23) && (class8.int_1 == num11))
                                {
                                    num12++;
                                    base.method_0(class8.ushort_0);
                                    class5 = base.class684_0.class547_0.arrayList_0[class8.int_0] as Class547.Class528;
                                    base.bool_0[class8.int_0] = true;
                                    if (num3 < num2)
                                    {
                                        num3++;
                                        class8 = list3[num3] as Class7.Class695;
                                    }
                                }
                            }
                            if (num12 == 2)
                            {
                                class12.enum34_0 = Enum34.const_2;
                                if (enum2 == Enum36.const_0)
                                {
                                    class6 = base.method_1(class4, class12);
                                    class7 = base.method_1(class5, class12);
                                }
                                else
                                {
                                    class6 = base.method_1(class5, class12);
                                    class7 = base.method_1(class4, class12);
                                }
                            }
                            else
                            {
                                if (enum2 == Enum36.const_0)
                                {
                                    class12.enum34_0 = Enum34.const_0;
                                }
                                else
                                {
                                    class12.enum34_0 = Enum34.const_1;
                                }
                                class6 = base.method_1(class4, class12);
                            }
                            class12.class619_0.method_0(class6);
                            if (num12 > 1)
                            {
                                class12.class619_0.method_0(class7);
                            }
                            if (class4.Boolean_8)
                            {
                                this.class619_5.method_0(class12);
                            }
                            else if (class4.Boolean_11)
                            {
                                this.class619_6.method_0(class12);
                            }
                            else
                            {
                                this.class619_4.method_0(class12);
                            }
                        }
                        else
                        {
                            if (str != string_43)
                            {
                                goto Label_068A;
                            }
                            Class382 class13 = new Class382 {
                                class369_0 = class10,
                                int_0 = num9
                            };
                            this.method_54(num5 + j, class13, Enum39.const_2);
                            base.method_16(class13);
                            class13.struct3_0 = new Struct3[num10];
                            for (int k = 0; k < num10; k++)
                            {
                                base.method_32();
                                class13.struct3_0[k].enum11_0 = base.class688_0.enum11_0;
                                class13.struct3_0[k].byte_0 = base.class688_0.byte_0;
                                Enum11 enum3 = base.class688_0.enum11_0;
                                if (enum3 != Enum11.const_41)
                                {
                                    if (enum3 != Enum11.const_45)
                                    {
                                        class13.struct3_0[k].int_0 = base.class688_0.int_0;
                                    }
                                    else
                                    {
                                        class13.struct3_0[k].int_0 = base.class563_0.method_0(base.class688_0.byte_1);
                                    }
                                }
                                else
                                {
                                    class13.struct3_0[k].int_0 = base.class558_0.method_0(base.class688_0.byte_1);
                                }
                            }
                            while (class8.enum0_0 == Enum0.const_20)
                            {
                                num3++;
                                class8 = list3[num3] as Class7.Class695;
                            }
                            int num14 = class8.int_1;
                            int num15 = 1;
                            enum2 = base.method_0(class8.ushort_0);
                            class4 = base.class684_0.class547_0.arrayList_0[class8.int_0] as Class547.Class528;
                            base.bool_0[class8.int_0] = true;
                            if (num3 < num2)
                            {
                                num3++;
                                class8 = list3[num3] as Class7.Class695;
                                if ((class8.enum0_0 == Enum0.const_23) && (class8.int_1 == num14))
                                {
                                    num15++;
                                    base.method_0(class8.ushort_0);
                                    class5 = base.class684_0.class547_0.arrayList_0[class8.int_0] as Class547.Class528;
                                    base.bool_0[class8.int_0] = true;
                                    if (num3 < num2)
                                    {
                                        num3++;
                                        class8 = list3[num3] as Class7.Class695;
                                    }
                                }
                            }
                            if (num15 == 2)
                            {
                                class13.enum34_0 = Enum34.const_2;
                                if (enum2 == Enum36.const_0)
                                {
                                    class6 = base.method_1(class4, class13);
                                    class7 = base.method_1(class5, class13);
                                }
                                else
                                {
                                    class6 = base.method_1(class5, class13);
                                    class7 = base.method_1(class4, class13);
                                }
                            }
                            else
                            {
                                if (enum2 == Enum36.const_0)
                                {
                                    class13.enum34_0 = Enum34.const_0;
                                }
                                else
                                {
                                    class13.enum34_0 = Enum34.const_1;
                                }
                                class6 = base.method_1(class4, class13);
                            }
                            class13.class619_0.method_0(class6);
                            if (num15 > 1)
                            {
                                class13.class619_0.method_0(class7);
                            }
                            this.class619_7.method_0(class13);
                        }
                        continue;
                    Label_0674:
                        num3++;
                        class8 = list3[num3] as Class7.Class695;
                    Label_068A:
                        if (class8.enum0_0 == Enum0.const_20)
                        {
                            goto Label_0674;
                        }
                        int num16 = class8.int_1;
                        if (num3 < num2)
                        {
                            num3++;
                            class8 = list3[num3] as Class7.Class695;
                            if (((class8.enum0_0 == Enum0.const_23) && (class8.int_1 == num16)) && (num3 < num2))
                            {
                                num3++;
                                class8 = list3[num3] as Class7.Class695;
                            }
                        }
                    }
                    if (this.class619_7.Int32_0 > 0)
                    {
                        class9.ushort_17 = (ushort) (class9.ushort_17 | 0x8000);
                        class10.class619_0.method_1(this.class619_7);
                        this.class619_7.method_6();
                    }
                    if (this.class619_4.Int32_0 > 0)
                    {
                        this.class619_4.method_7();
                        class10.class619_0.method_1(this.class619_4);
                        this.class619_4.method_6();
                    }
                    if (this.class619_6.Int32_0 > 0)
                    {
                        this.class619_6.method_7();
                        class10.class619_0.method_1(this.class619_6);
                        this.class619_6.method_6();
                    }
                    if (this.class619_5.Int32_0 > 0)
                    {
                        this.class619_5.method_7();
                        class10.class619_0.method_1(this.class619_5);
                        this.class619_5.method_6();
                    }
                    class2 = class3;
                }
            }
        }

        private void method_54(int A_1, Class369 A_2, Enum39 A_3)
        {
            base.struct4_0[A_1].class369_0 = A_2;
            base.struct4_0[A_1].enum39_0 = A_3;
        }
    }
}

