namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class1088
    {
        internal static Class686.Class687 smethod_0(Class394 A_0)
        {
            Class519.smethod_0(A_0);
            Class686.Class687 class2 = new Class686.Class687(A_0);
            A_0.class687_0 = class2;
            class2.ImageIndex = A_0.QQQR;
            class2.SelectedImageIndex = A_0.QQQR;
            if (A_0.QQQT)
            {
                smethod_1(A_0, class2);
            }
            return class2;
        }

        private static void smethod_1(Class369 A_0, Class686.Class687 A_1)
        {
            Class619 class2 = A_0.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                Class369 class3 = class2[i];
                if (class3.QQQS != Enum10.const_22)
                {
                    Class686.Class687 node = new Class686.Class687(class3);
                    class3.class687_0 = node;
                    node.ImageIndex = class3.QQQR;
                    node.SelectedImageIndex = class3.QQQR;
                    A_1.Nodes.Add(node);
                    if (class3.QQQT)
                    {
                        smethod_1(class3, node);
                    }
                }
                else
                {
                    class3.class687_0 = Class686.Class687.class687_0;
                }
            }
        }

        internal static void smethod_2()
        {
            Class686.Class687 node = Class519.class394_0.class687_0;
            TreeNodeCollection nodes = Class698.class582_0.class686_0.class802_0.Nodes;
            Class686.Class687 class3 = smethod_0(Class519.class394_0);
            class3.Collapse();
            int index = nodes.IndexOf(node);
            Class645.smethod_2(Class519.class394_0);
            nodes.RemoveAt(index);
            nodes.Insert(index, class3);
            Class645.smethod_1(Class519.class394_0);
        }
    }
}

