namespace ns0
{
    using System;
    using System.Collections.Specialized;
    using System.Windows.Forms;

    internal class Class894
    {
        internal static void smethod_0()
        {
            if (!Class645.Boolean_0)
            {
                Class369 class2 = Class519.class369_0;
                if ((class2.QQQS != Enum10.const_23) && (class2.QQQS != Enum10.const_19))
                {
                    EditNameDialog dialog = new EditNameDialog(class2);
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    {
                        Class519.class394_0.class803_0.bool_0 = true;
                        Class643.smethod_1(class2);
                        Control0 control = Class645.class704_0.Control0_0;
                        if (control != null)
                        {
                            control.method_4();
                        }
                    }
                }
            }
        }

        internal static void smethod_1()
        {
            if (!Class645.Boolean_0)
            {
                Class369 class2 = Class519.class369_0;
                if (class2.QQXQ)
                {
                    EditXmlDocDialog dialog = new EditXmlDocDialog(class2.Name, class2.stringCollection_0);
                    dialog.ShowDialog();
                    if (dialog.DialogResult == DialogResult.OK)
                    {
                        string[] strArray = dialog.String_0;
                        if (class2.stringCollection_0 == null)
                        {
                            class2.stringCollection_0 = new StringCollection();
                        }
                        class2.stringCollection_0.Clear();
                        for (int i = 0; i < strArray.Length; i++)
                        {
                            class2.stringCollection_0.Add(strArray[i]);
                        }
                        Class519.class394_0.class803_0.bool_0 = true;
                    }
                }
            }
        }

        private static Class547.Class528 smethod_10(Class369 A_0)
        {
            if (A_0.QQQS == Enum10.const_18)
            {
                Class384 class2 = A_0 as Class384;
                if ((class2.enum34_0 == Enum34.const_0) || (class2.enum34_0 == Enum34.const_2))
                {
                    Class391 class3 = class2.class619_0[0] as Class391;
                    return class3.class528_0;
                }
            }
            if (A_0.QQQS == Enum10.const_19)
            {
                Class382 class4 = A_0 as Class382;
                if ((class4.enum34_0 == Enum34.const_0) || (class4.enum34_0 == Enum34.const_2))
                {
                    Class391 class5 = class4.class619_0[0] as Class391;
                    return class5.class528_0;
                }
            }
            if (A_0.QQQS == Enum10.const_21)
            {
                Class381 class6 = A_0 as Class381;
                if (class6.bool_1)
                {
                    Class391 class7 = class6.class619_0[1] as Class391;
                    return class7.class528_0;
                }
            }
            return null;
        }

        private static Class547.Class528 smethod_11(Class369 A_0)
        {
            if (A_0.QQQS == Enum10.const_18)
            {
                Class384 class2 = A_0 as Class384;
                if (class2.enum34_0 == Enum34.const_1)
                {
                    Class391 class3 = class2.class619_0[0] as Class391;
                    return class3.class528_0;
                }
                if (class2.enum34_0 == Enum34.const_2)
                {
                    Class391 class4 = class2.class619_0[1] as Class391;
                    return class4.class528_0;
                }
            }
            if (A_0.QQQS == Enum10.const_19)
            {
                Class382 class5 = A_0 as Class382;
                if (class5.enum34_0 == Enum34.const_1)
                {
                    Class391 class6 = class5.class619_0[0] as Class391;
                    return class6.class528_0;
                }
                if (class5.enum34_0 == Enum34.const_2)
                {
                    Class391 class7 = class5.class619_0[1] as Class391;
                    return class7.class528_0;
                }
            }
            if (A_0.QQQS == Enum10.const_21)
            {
                Class381 class8 = A_0 as Class381;
                if (class8.bool_0)
                {
                    Class391 class9 = class8.class619_0[0] as Class391;
                    return class9.class528_0;
                }
            }
            return null;
        }

        private static void smethod_12(Class547.Class528 A_0)
        {
            if (!A_0.Boolean_0)
            {
                Class846.smethod_8(A_0);
            }
        }

        internal static void smethod_2()
        {
            smethod_8(Enum56.const_0, Enum55.const_1);
        }

        internal static void smethod_3()
        {
            smethod_8(Enum56.const_1, Enum55.const_1);
        }

        internal static void smethod_4()
        {
            smethod_8(Enum56.const_2, Enum55.const_1);
        }

        internal static void smethod_5()
        {
            smethod_8(Enum56.const_0, Enum55.const_0);
        }

        internal static void smethod_6()
        {
            smethod_8(Enum56.const_1, Enum55.const_0);
        }

        internal static void smethod_7()
        {
            smethod_8(Enum56.const_2, Enum55.const_0);
        }

        private static void smethod_8(Enum56 A_0, Enum55 A_1)
        {
            if (!Class645.Boolean_0)
            {
                Class547.Class528 class2 = null;
                Class369 class3 = Class519.class369_0;
                switch (A_0)
                {
                    case Enum56.const_0:
                        class2 = smethod_9(class3);
                        break;

                    case Enum56.const_1:
                        if (A_1 != Enum55.const_0)
                        {
                            class2 = smethod_10(class3);
                            break;
                        }
                        if (class3.QQQS == Enum10.const_19)
                        {
                            class2 = smethod_10(class3);
                        }
                        break;

                    case Enum56.const_2:
                        if (A_1 != Enum55.const_0)
                        {
                            class2 = smethod_11(class3);
                            break;
                        }
                        if (class3.QQQS == Enum10.const_19)
                        {
                            class2 = smethod_11(class3);
                        }
                        break;
                }
                if (class2 != null)
                {
                    smethod_12(class2);
                    EditMethodNamesDialog dialog = new EditMethodNamesDialog(class3, class2, A_1 == Enum55.const_1);
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Class519.class394_0.class803_0.bool_0 = true;
                        Class643.smethod_1(class3);
                        Control0 control = Class645.class704_0.Control0_0;
                        if (control != null)
                        {
                            control.method_4();
                        }
                    }
                }
            }
        }

        private static Class547.Class528 smethod_9(Class369 A_0)
        {
            switch (A_0.QQQS)
            {
                case Enum10.const_16:
                case Enum10.const_17:
                {
                    Class391 class2 = A_0 as Class391;
                    return class2.class528_0;
                }
                case Enum10.const_23:
                {
                    Class383 class3 = A_0 as Class383;
                    return class3.class528_0;
                }
            }
            return null;
        }
    }
}

