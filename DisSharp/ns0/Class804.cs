namespace ns0
{
    using Crownwood.DotNetMagic.Controls;
    using System;
    using System.Text;
    using System.Windows.Forms;

    internal class Class804
    {
        private static Class369 class369_0 = null;
        private static string string_0 = Class537.string_554;
        private static StringBuilder stringBuilder_0 = new StringBuilder(100);

        internal static void smethod_0()
        {
            Class698.class582_0.statusBarControl_0.Text = "";
        }

        internal static void smethod_1(Class369 A_0)
        {
            if ((class369_0 == null) || (A_0 != class369_0))
            {
                class369_0 = A_0;
                stringBuilder_0.Length = 0;
                stringBuilder_0.Append(string_0);
                stringBuilder_0.Append(A_0.QQTW.Name);
                string str = smethod_2(A_0);
                if (str != "")
                {
                    stringBuilder_0.Append(",  ");
                    stringBuilder_0.Append(str);
                    stringBuilder_0.Append(A_0.Name);
                }
                StatusBarControl control = Class698.class582_0.statusBarControl_0;
                control.StatusPanels.Clear();
                StatusPanel panel = new StatusPanel {
                    Text = stringBuilder_0.ToString(),
                    AutoSizing = StatusBarPanelAutoSize.Contents
                };
                control.StatusPanels.Add(panel);
            }
        }

        private static string smethod_2(Class369 A_0)
        {
            switch (A_0.QQQS)
            {
                case Enum10.const_1:
                    return Class537.string_928;

                case Enum10.const_2:
                case Enum10.const_3:
                    return Class537.string_539;

                case Enum10.const_4:
                case Enum10.const_5:
                    return Class537.string_736;

                case Enum10.const_6:
                case Enum10.const_7:
                    return Class537.string_230;

                case Enum10.const_8:
                case Enum10.const_9:
                    return Class537.string_896;

                case Enum10.const_10:
                case Enum10.const_11:
                    return Class537.string_318;

                case Enum10.const_12:
                case Enum10.const_13:
                case Enum10.const_14:
                case Enum10.const_15:
                    return Class537.string_291;

                case Enum10.const_16:
                    return Class537.string_95;

                case Enum10.const_17:
                    return Class537.string_282;

                case Enum10.const_18:
                    return Class537.string_624;

                case Enum10.const_19:
                    return Class537.string_911;

                case Enum10.const_21:
                    return Class537.string_497;

                case Enum10.const_23:
                    return Class537.string_273;
            }
            return "";
        }
    }
}

