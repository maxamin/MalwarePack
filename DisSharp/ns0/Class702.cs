namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class702
    {
        private static string string_0 = Class537.string_528;

        internal static bool smethod_0(string A_0)
        {
            return smethod_2(A_0, true);
        }

        internal static void smethod_1(string A_0)
        {
            smethod_2(A_0, false);
        }

        internal static bool smethod_2(string A_0, bool A_1)
        {
            try
            {
                Class686.Class687 node = Class394.smethod_0(A_0);
                node.Collapse();
                Class698.class582_0.class686_0.class802_0.Nodes.Add(node);
                Class698.class582_0.class686_0.class802_0.SelectedNode = node;
                Class645.smethod_1((Class394) node.class369_0);
                Class519.smethod_0((Class394) node.class369_0);
                return true;
            }
            catch (Exception exception)
            {
                if (A_1)
                {
                    MessageBox.Show(exception.Message, string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
            }
        }
    }
}

