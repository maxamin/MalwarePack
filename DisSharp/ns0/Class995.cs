namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class995
    {
        private static Class862 class862_0;
        private static RichTextBoxFinds richTextBoxFinds_0 = (RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord);
        private static SearchForm searchForm_0 = new SearchForm();
        private static string string_0;
        private static string string_1 = Class537.string_509;
        private static string string_2 = Class537.string_176;
        private static string string_3 = Class537.string_103;

        internal static void smethod_0()
        {
            if (!Class645.class704_0.Boolean_0)
            {
                searchForm_0.TextToFind.Text = "";
                if (searchForm_0.ShowDialog() == DialogResult.OK)
                {
                    string_0 = searchForm_0.TextToFind.Text;
                    if (!searchForm_0.TextToFind.Items.Contains(string_0))
                    {
                        searchForm_0.TextToFind.Items.Insert(0, string_0);
                    }
                    smethod_2();
                    int selectionStart = class862_0.SelectionStart;
                    int end = class862_0.SelectionStart + class862_0.SelectionLength;
                    int num3 = 0;
                    if (searchForm_0.Global.Checked)
                    {
                        if (searchForm_0.EntireScope.Checked)
                        {
                            num3 = class862_0.Find(string_0, 0, richTextBoxFinds_0);
                        }
                        else
                        {
                            num3 = class862_0.Find(string_0, selectionStart, richTextBoxFinds_0);
                        }
                    }
                    else
                    {
                        num3 = class862_0.Find(string_0, selectionStart, end, richTextBoxFinds_0);
                    }
                    if (num3 < 0)
                    {
                        smethod_3();
                    }
                    class862_0.Focus();
                }
            }
        }

        internal static void smethod_1()
        {
            if (Class645.class704_0.Boolean_0)
            {
            }
        }

        private static void smethod_2()
        {
            richTextBoxFinds_0 = RichTextBoxFinds.None;
            if (searchForm_0.WholeWordsOnly.Checked)
            {
                richTextBoxFinds_0 |= RichTextBoxFinds.WholeWord;
            }
            if (searchForm_0.CaseSensitive.Checked)
            {
                richTextBoxFinds_0 |= RichTextBoxFinds.MatchCase;
            }
            if (searchForm_0.Backward.Checked)
            {
                richTextBoxFinds_0 |= RichTextBoxFinds.Reverse;
            }
        }

        private static void smethod_3()
        {
            MessageBox.Show(string_1 + string_0 + string_2, string_3, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

