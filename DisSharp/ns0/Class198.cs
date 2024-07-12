namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class198 : Class197
    {
        protected Class198()
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
            this.method_895(class3);
            base.method_32();
            base.method_33(class3.QQQS, 1, 1, true);
            this.method_894(class4);
            base.method_34();
            this.method_896();
            this.method_897(class3);
            Class516.bool_24 = false;
            return new Class368(class2, class3.Name);
        }

        private void method_894(Class642 A_1)
        {
            if (A_1.class369_0.QQQS == Enum10.const_22)
            {
                return;
            }
            base.int_0++;
            if (((Class516.bool_9 || (base.Int32_0 != 1)) && ((A_1.class369_0.QQQU && base.Boolean_0) || base.Boolean_2)) && !A_1.class369_0.class369_0.QQUQ)
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
                        goto Label_00E3;

                    case Enum2.const_2:
                    case Enum2.const_3:
                    case Enum2.const_4:
                    case Enum2.const_5:
                        A_1.class369_0.QQUY(this, base.enum2_0);
                        goto Label_00E3;
                }
            }
            catch
            {
                base.int_0 = num;
            }
        Label_00E3:
            if (A_1.class369_0.QQQQ)
            {
                base.method_10(Class518.class337_3);
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
                        this.method_894(class3);
                        base.method_34();
                        enum2 = qQQS;
                    }
                }
                base.method_10(Class518.class337_5);
                if (A_1.class369_0.QQTY)
                {
                    base.method_9(Class584.class342_0);
                    base.method_9(this.QRTX());
                    base.method_9(new Class338(Class613.Class614.string_11));
                    base.method_9(Class584.class342_0);
                    base.method_9(new Class338(A_1.class369_0.Name));
                }
            }
            if ((Class516.bool_9 && (base.Int32_0 == base.Int32_1)) && !A_1.class369_0.class369_0.QQUQ)
            {
                base.method_7();
            }
            base.int_0--;
        }

        private void method_895(Class369 A_1)
        {
            base.method_7();
            base.method_9(Class613.class339_74);
            Class390 class2 = A_1.class369_0 as Class390;
            if (class2 != null)
            {
                base.method_9(new Class344(class2));
            }
            base.method_7();
            base.method_9(Class518.class337_3);
        }

        private void method_896()
        {
            base.method_10(Class518.class337_5);
            base.method_7();
        }

        private void method_897(Class369 A_1)
        {
            string name = A_1.class369_0.Name;
            bool flag = true;
            if (Class546.class562_0.Boolean_0)
            {
                int num = 0;
                short[] numArray = Class546.class562_0.short_0;
                bool[] flagArray = Class546.class562_0.bool_0;
                ArrayList list = Class546.class562_0.arrayList_0;
                for (int i = numArray.Length - 1; i >= 0; i--)
                {
                    short index = numArray[i];
                    Class562.Class533 class2 = list[index] as Class562.Class533;
                    string str2 = Class519.class581_0[class2.int_1];
                    if ((flagArray[index] && (str2 != "")) && (str2 != name))
                    {
                        if (flag)
                        {
                            base.method_4(new Class367());
                            num++;
                            flag = false;
                        }
                        Class367 class3 = new Class367();
                        class3.method_0(Class613.class339_137);
                        if (class2.bool_0)
                        {
                            class3.method_0(new Class344(class2.int_1, class2.bool_0));
                        }
                        else
                        {
                            class3.method_0(new Class336(str2));
                        }
                        class3.method_0(Class518.class337_19);
                        base.method_4(class3);
                        num++;
                    }
                }
                ArrayList list2 = base.arrayList_0;
                if (list2 != null)
                {
                    for (int j = 0; j < list2.Count; j++)
                    {
                        Class646 class4 = list2[j] as Class646;
                        class4.int_0 += num;
                    }
                }
            }
        }
    }
}

