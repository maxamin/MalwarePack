namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class700
    {
        internal static bool smethod_0(string A_0)
        {
            return smethod_1(A_0, false);
        }

        internal static bool smethod_1(string A_0, bool A_1)
        {
            return smethod_4(A_0, A_1, false, true);
        }

        internal static void smethod_2(string A_0)
        {
            smethod_4(A_0, false, true, true);
        }

        internal static void smethod_3(string A_0)
        {
            smethod_4(A_0, false, false, false);
        }

        private static bool smethod_4(string A_0, bool A_1, bool A_2, bool A_3)
        {
            try
            {
                Class686.Class687 node = Class394.smethod_1(A_0);
                if (!A_2)
                {
                    node.Collapse();
                    Class698.class582_0.class686_0.class802_0.Nodes.Add(node);
                    Class698.class582_0.class686_0.class802_0.SelectedNode = node;
                }
                Class645.smethod_1((Class394) node.class369_0);
                Class519.smethod_0((Class394) node.class369_0);
                return true;
            }
            catch (Exception exception)
            {
                if (A_3)
                {
                    MessageBox.Show(exception.Message, Class537.string_183, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
            }
        }
    }
}

