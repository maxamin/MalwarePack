namespace ns0
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Windows.Forms;

    internal class Class1019
    {
        private static StringCollection stringCollection_0 = new StringCollection();

        internal static void smethod_0()
        {
            try
            {
                Class384 class6;
                int num;
                Class382 class8;
                int num2;
                Class396 class10;
                int num3;
                Class397 class2 = new Class397();
                switch (Class519.class369_0.QQQS)
                {
                    case Enum10.const_16:
                    {
                        Class391 class3 = Class519.class369_0 as Class391;
                        smethod_1(class2, class3.class528_0, class3);
                        goto Label_019E;
                    }
                    case Enum10.const_17:
                    {
                        Class392 class4 = Class519.class369_0 as Class392;
                        smethod_1(class2, class4.class528_0, class4);
                        goto Label_019E;
                    }
                    case Enum10.const_18:
                        class6 = Class519.class369_0 as Class384;
                        num = 0;
                        goto Label_00C1;

                    case Enum10.const_19:
                        class8 = Class519.class369_0 as Class382;
                        num2 = 0;
                        goto Label_011C;

                    case Enum10.const_20:
                        class10 = Class519.class369_0 as Class396;
                        num3 = 0;
                        goto Label_0174;

                    case Enum10.const_23:
                    {
                        Class383 class5 = Class519.class369_0 as Class383;
                        smethod_1(class2, class5.class528_0, class5);
                        goto Label_019E;
                    }
                    default:
                        goto Label_019E;
                }
            Label_008C:
                if (num > 0)
                {
                    class2.method_8();
                }
                Class391 class7 = class6.class619_0[num] as Class391;
                smethod_1(class2, class7.class528_0, class6);
                num++;
            Label_00C1:
                if (num < class6.class619_0.Int32_0)
                {
                    goto Label_008C;
                }
                goto Label_019E;
            Label_00E7:
                if (num2 > 0)
                {
                    class2.method_8();
                }
                Class391 class9 = class8.class619_0[num2] as Class391;
                smethod_1(class2, class9.class528_0, class8);
                num2++;
            Label_011C:
                if (num2 < class8.class619_0.Int32_0)
                {
                    goto Label_00E7;
                }
                goto Label_019E;
            Label_013F:
                if (num3 > 0)
                {
                    class2.method_8();
                }
                Class391 class11 = class10.class619_0[num3] as Class391;
                smethod_1(class2, class11.class528_0, class10);
                num3++;
            Label_0174:
                if (num3 < class10.class619_0.Int32_0)
                {
                    goto Label_013F;
                }
            Label_019E:
                class2.method_8();
                Class645.smethod_5(class2, Class519.class394_0.class395_5, Class519.class369_0.Name, Enum43.const_1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Class537.string_402, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private static void smethod_1(Class397 A_0, Class547.Class528 A_1, Class369 A_2)
        {
            Class516.Boolean_0 = true;
            try
            {
                bool flag;
                ArrayList list = Class546.class547_0.arrayList_0;
                ArrayList list2 = Class546.class551_0.arrayList_0;
                ArrayList list3 = Class546.class552_0.arrayList_0;
                A_0.method_11(new Class336(Class537.string_111));
                Class612.smethod_15(A_0, A_1);
                stringCollection_0.Clear();
                A_0.method_11(new Class336(Class537.string_286));
                for (int i = 0; i < A_1.class907_0.int_0; i++)
                {
                    uint num2 = A_1.class907_0[i];
                    Enum0 enum2 = (Enum0) ((byte) ((num2 & -16777216) >> 0x18));
                    int num3 = ((int) num2) & 0xffffff;
                    switch (enum2)
                    {
                        case Enum0.const_6:
                        {
                            Class547.Class528 class2 = list[num3] as Class547.Class528;
                            stringCollection_0.Add(Class612.smethod_16(class2));
                            break;
                        }
                        case Enum0.const_10:
                        {
                            Class551.Class544 class3 = list2[num3] as Class551.Class544;
                            if (class3.enum9_0 == Enum9.const_2)
                            {
                                Class552.Class545 class4 = list3[class3.int_0] as Class552.Class545;
                                stringCollection_0.Add(Class612.smethod_19(class4));
                            }
                            break;
                        }
                    }
                }
                Class809.smethod_1(stringCollection_0, false);
                smethod_2(stringCollection_0);
                smethod_3(stringCollection_0);
                for (int j = 0; j < stringCollection_0.Count; j++)
                {
                    A_0.method_11(new Class336(stringCollection_0[j]));
                }
                stringCollection_0.Clear();
                A_0.method_11(new Class336(Class537.string_781));
                for (int k = 0; k < A_1.class907_1.int_0; k++)
                {
                    uint num6 = A_1.class907_1[k];
                    Enum0 enum3 = (Enum0) ((byte) ((num6 & -16777216) >> 0x18));
                    int num7 = ((int) num6) & 0xffffff;
                    if (enum3 == Enum0.const_6)
                    {
                        Class547.Class528 class5 = list[num7] as Class547.Class528;
                        stringCollection_0.Add(Class612.smethod_16(class5));
                    }
                }
                Class809.smethod_1(stringCollection_0, false);
                smethod_2(stringCollection_0);
                smethod_3(stringCollection_0);
                int count = stringCollection_0.Count;
                if (flag = Class521.Boolean_0)
                {
                    int num9;
                    int num10 = Math.DivRem(count, 2, out num9);
                    if (num10 > 2)
                    {
                        if (Class519.class394_0.bool_4)
                        {
                            flag = false;
                        }
                        else
                        {
                            count = num10;
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
                for (int m = 0; m < count; m++)
                {
                    A_0.method_11(new Class336(stringCollection_0[m]));
                }
                if (flag)
                {
                    A_0.method_11(new Class336(Class537.string_197));
                }
            }
            finally
            {
                Class516.smethod_0();
            }
        }

        private static void smethod_2(StringCollection A_0)
        {
            if (A_0.Count != 0)
            {
                bool flag;
                do
                {
                    flag = false;
                    string str = A_0[0];
                    for (int i = 1; i < A_0.Count; i++)
                    {
                        string str2 = A_0[i];
                        if (str == str2)
                        {
                            A_0.RemoveAt(i);
                            flag = true;
                            break;
                        }
                        str = str2;
                    }
                }
                while (flag);
            }
        }

        private static void smethod_3(StringCollection A_0)
        {
            if (A_0.Count != 0)
            {
                bool flag;
                do
                {
                    flag = false;
                    for (int i = 0; i < A_0.Count; i++)
                    {
                        string str = A_0[i];
                        if (((str == Class537.string_630) || (str == Class537.string_606)) || ((str == Class537.string_488) || (str == Class537.string_947)))
                        {
                            A_0.RemoveAt(i);
                            flag = true;
                            break;
                        }
                    }
                }
                while (flag);
            }
        }

        internal static bool Boolean_0
        {
            get
            {
                if (!Class645.Boolean_0)
                {
                    switch (Class519.class369_0.QQQS)
                    {
                        case Enum10.const_16:
                        case Enum10.const_17:
                        case Enum10.const_18:
                        case Enum10.const_19:
                        case Enum10.const_20:
                        case Enum10.const_23:
                            return true;
                    }
                }
                return false;
            }
        }
    }
}

