namespace ns0
{
    using DisSharp;
    using System;
    using System.Drawing;

    internal class Class863
    {
        private static Color color_0 = smethod_0(0);
        private static Color color_1 = smethod_0(1);
        private static Color color_2 = smethod_0(2);
        private static Color color_3 = smethod_0(3);
        private static Color color_4 = smethod_0(4);
        private static Color color_5 = smethod_0(5);
        private static Color color_6 = smethod_0(6);
        private static Color color_7 = smethod_0(7);
        private static Color color_8 = smethod_0(8);
        private static Color color_9 = smethod_0(9);
        internal const int int_0 = 10;
        internal const int int_1 = 0;
        internal const int int_10 = 9;
        internal const int int_2 = 1;
        internal const int int_3 = 2;
        internal const int int_4 = 3;
        internal const int int_5 = 4;
        internal const int int_6 = 5;
        internal const int int_7 = 6;
        internal const int int_8 = 7;
        internal const int int_9 = 8;

        internal static Color smethod_0(int A_0)
        {
            switch (A_0)
            {
                case 0:
                    return SystemColors.Window;

                case 1:
                    return SystemColors.ControlText;

                case 2:
                    return SystemColors.Window;

                case 3:
                    return Color.DimGray;

                case 4:
                    return Color.Blue;

                case 5:
                    return Color.DarkBlue;

                case 6:
                    return Color.DarkGray;

                case 7:
                    return Color.Black;

                case 8:
                    return Color.Black;

                case 9:
                    return Color.Beige;
            }
            throw new Exception10();
        }

        internal static Color smethod_1(int A_0)
        {
            switch (A_0)
            {
                case 0:
                    return color_0;

                case 1:
                    return color_1;

                case 2:
                    return color_2;

                case 3:
                    return color_3;

                case 4:
                    return color_4;

                case 5:
                    return color_5;

                case 6:
                    return color_6;

                case 7:
                    return color_7;

                case 8:
                    return color_8;

                case 9:
                    return color_9;
            }
            throw new Exception10();
        }

        internal static void smethod_2(int A_0, Color A_1)
        {
            switch (A_0)
            {
                case 0:
                    color_0 = A_1;
                    return;

                case 1:
                    color_1 = A_1;
                    return;

                case 2:
                    color_2 = A_1;
                    return;

                case 3:
                    color_3 = A_1;
                    return;

                case 4:
                    color_4 = A_1;
                    return;

                case 5:
                    color_5 = A_1;
                    return;

                case 6:
                    color_6 = A_1;
                    return;

                case 7:
                    color_7 = A_1;
                    return;

                case 8:
                    color_8 = A_1;
                    return;

                case 9:
                    color_9 = A_1;
                    return;
            }
            throw new Exception10();
        }

        internal static void smethod_3(OptionsObject A_0)
        {
            A_0.TreeBackColor = smethod_1(0);
            A_0.TreeForeColor = smethod_1(1);
            A_0.TextBackColor = smethod_1(2);
            A_0.DefaultColor = smethod_1(3);
            A_0.KeywordColor = smethod_1(4);
            A_0.LabelColor = smethod_1(5);
            A_0.CommentColor = smethod_1(6);
            A_0.StringColor = smethod_1(7);
            A_0.EditableColor = smethod_1(8);
            A_0.TextSelectionColor = smethod_1(9);
        }

        internal static void smethod_4(OptionsObject A_0)
        {
            A_0.TreeBackColor = smethod_0(0);
            A_0.TreeForeColor = smethod_0(1);
            A_0.TextBackColor = smethod_0(2);
            A_0.DefaultColor = smethod_0(3);
            A_0.KeywordColor = smethod_0(4);
            A_0.LabelColor = smethod_0(5);
            A_0.CommentColor = smethod_0(6);
            A_0.StringColor = smethod_0(7);
            A_0.EditableColor = smethod_0(8);
            A_0.TextSelectionColor = smethod_0(9);
        }

        internal static void smethod_5(OptionsObject A_0)
        {
            smethod_2(0, A_0.TreeBackColor);
            smethod_2(1, A_0.TreeForeColor);
            smethod_2(2, A_0.TextBackColor);
            smethod_2(3, A_0.DefaultColor);
            smethod_2(4, A_0.KeywordColor);
            smethod_2(5, A_0.LabelColor);
            smethod_2(6, A_0.CommentColor);
            smethod_2(7, A_0.StringColor);
            smethod_2(8, A_0.EditableColor);
            smethod_2(9, A_0.TextSelectionColor);
        }
    }
}

