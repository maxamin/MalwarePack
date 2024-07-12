namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class245 : Class244
    {
        protected Class245()
        {
        }

        internal override Class368 Create(Class369 curr, Enum2 codetype, bool managenodes)
        {
            base.enum2_0 = codetype;
            Class516.bool_24 = true;
            Class546.class562_0.method_3();
            Class397 class2 = new Class397(managenodes);
            base.method_0(class2);
            Class369 class3 = Class643.smethod_0(curr);
            Class642 class4 = class3.method_4(codetype);
            this.method_898(class3, class4);
            this.method_899(class3, class4);
            this.method_902(class3);
            Class516.bool_24 = false;
            return new Class368(class2, class3.Name);
        }

        private void method_898(Class369 A_1, Class642 A_2)
        {
            base.bool_3 = false;
            base.method_10(Class538.class339_208);
            Class390 class2 = A_1.class369_0 as Class390;
            if (class2 != null)
            {
                base.method_9(new Class344(class2));
            }
            base.method_9(Class518.class337_19);
            base.method_10(Class538.class339_147);
            base.method_7();
            base.method_10(Class538.class339_205);
            base.method_32();
            base.method_33(A_1.QQQS, 1, 1, true);
            this.method_900(A_2);
            base.method_34();
        }

        private void method_899(Class369 A_1, Class642 A_2)
        {
            base.bool_3 = true;
            base.int_0 = 0;
            base.method_10(Class538.class339_136);
            switch (base.enum2_0)
            {
                case Enum2.const_0:
                case Enum2.const_1:
                case Enum2.const_6:
                    base.method_32();
                    base.method_33(A_1.QQQS, 1, 1, true);
                    base.method_7();
                    this.method_901(A_2);
                    base.method_34();
                    break;
            }
            base.method_10(Class538.class339_116);
            base.method_9(Class518.class337_13);
            base.method_7();
        }

        private void method_900(Class642 A_1)
        {
            if (A_1.class369_0.QQQS == Enum10.const_22)
            {
                return;
            }
            base.int_0++;
            if (((base.Int32_0 != 1) && base.Boolean_2) && !A_1.class369_0.class369_0.QQUQ)
            {
                base.method_7();
            }
            if (base.arrayList_0 != null)
            {
                Class645.smethod_4(A_1.class369_0, base.method_1());
            }
            int num = base.int_0;
            try
            {
                switch (base.enum2_0)
                {
                    case Enum2.const_0:
                    case Enum2.const_1:
                    case Enum2.const_6:
                        A_1.class369_0.Create(this, base.enum2_0, false);
                        goto Label_00C7;

                    case Enum2.const_2:
                    case Enum2.const_3:
                    case Enum2.const_4:
                    case Enum2.const_5:
                        A_1.class369_0.QQUY(this, base.enum2_0);
                        goto Label_00C7;
                }
            }
            catch
            {
                base.int_0 = num;
            }
        Label_00C7:
            if (A_1.class369_0.QQQQ)
            {
                Class644 class2 = A_1.class644_0;
                int num2 = class2.Int32_0;
                if (num2 > 0)
                {
                    Enum10 enum2 = Enum10.const_25;
                    for (int i = 0; i < num2; i++)
                    {
                        Class642 class3 = class2[i];
                        Enum10 qQQS = class3.class369_0.QQQS;
                        base.method_33(A_1.class369_0.QQQS, i + 1, num2, qQQS != enum2);
                        this.method_900(class3);
                        base.method_34();
                        enum2 = qQQS;
                    }
                }
                switch (A_1.class369_0.QQQS)
                {
                    case Enum10.const_2:
                    case Enum10.const_3:
                    case Enum10.const_4:
                    case Enum10.const_5:
                    case Enum10.const_6:
                    case Enum10.const_7:
                    case Enum10.const_21:
                        base.method_10(Class538.class339_116);
                        base.method_9(Class518.class337_19);
                        if (A_1.class369_0.QQTY)
                        {
                            base.method_9(Class584.class342_0);
                            base.method_9(this.QRTX());
                            base.method_9(new Class338(Class538.Class539.string_48));
                            base.method_9(Class584.class342_0);
                            base.method_9(new Class338(A_1.class369_0.Name));
                        }
                        base.method_7();
                        break;

                    case Enum10.const_8:
                    case Enum10.const_9:
                        base.method_10(Class518.class337_12);
                        base.method_9(Class518.class337_19);
                        base.method_7();
                        break;
                }
            }
            if ((base.Int32_0 == base.Int32_1) && (A_1.class369_0.QQQS == Enum10.const_10))
            {
                base.method_7();
            }
            base.int_0--;
        }

        private void method_901(Class642 A_1)
        {
            bool flag;
            Enum10 qQQS = A_1.class369_0.QQQS;
            try
            {
                switch (qQQS)
                {
                    case Enum10.const_16:
                    case Enum10.const_17:
                    case Enum10.const_23:
                        break;

                    default:
                        goto Label_004C;
                }
                A_1.class369_0.Create(this, base.enum2_0, false);
                base.method_7();
            }
            catch
            {
                base.int_0 = 0;
            }
        Label_004C:
            switch (qQQS)
            {
                case Enum10.const_4:
                case Enum10.const_5:
                case Enum10.const_10:
                case Enum10.const_11:
                case Enum10.const_21:
                    flag = false;
                    break;

                default:
                    flag = true;
                    break;
            }
            if (flag)
            {
                Class644 class2 = A_1.class644_0;
                int num = class2.Int32_0;
                if (num > 0)
                {
                    Enum10 enum3 = Enum10.const_25;
                    for (int i = 0; i < num; i++)
                    {
                        Class642 class3 = class2[i];
                        Enum10 enum4 = class3.class369_0.QQQS;
                        base.method_33(A_1.class369_0.QQQS, i + 1, num, enum4 != enum3);
                        this.method_901(class3);
                        base.method_34();
                        enum3 = enum4;
                    }
                }
            }
        }

        private void method_902(Class369 A_1)
        {
            string name = A_1.class369_0.Name;
            if (Class546.class562_0.Boolean_0)
            {
                Class367 class2 = null;
                Class367 class3 = null;
                base.int_0 = 0;
                int num = 0;
                Class367 class4 = null;
                short[] numArray = Class546.class562_0.short_0;
                bool[] flagArray = Class546.class562_0.bool_0;
                ArrayList list = Class546.class562_0.arrayList_0;
                for (int i = numArray.Length - 1; i >= 0; i--)
                {
                    short index = numArray[i];
                    Class562.Class533 class5 = list[index] as Class562.Class533;
                    string str2 = Class519.class581_0[class5.int_1];
                    if ((flagArray[index] && (str2 != "")) && (str2 != name))
                    {
                        if (class4 == null)
                        {
                            class2 = base.method_5();
                            class3 = base.method_5();
                        }
                        Class367 class6 = new Class367();
                        class6.method_0(new Class341(1));
                        if (class5.bool_0)
                        {
                            class6.method_0(new Class344(class5.int_1, class5.bool_0));
                        }
                        else
                        {
                            class6.method_0(new Class336(str2));
                        }
                        base.method_4(class6);
                        num++;
                        if (class4 == null)
                        {
                            class6.method_0(Class518.class337_19);
                        }
                        else
                        {
                            class6.method_0(Class518.class337_14);
                        }
                        class4 = class6;
                    }
                }
                if (class4 != null)
                {
                    base.method_4(new Class367(Class538.class339_211));
                    num++;
                    base.method_4(class3);
                    base.method_4(class2);
                    base.int_0 = 0;
                    ArrayList list2 = base.arrayList_0;
                    if (list2 != null)
                    {
                        for (int j = 0; j < list2.Count; j++)
                        {
                            Class646 class7 = list2[j] as Class646;
                            class7.int_0 += num;
                        }
                    }
                }
            }
        }
    }
}

