namespace ns0
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    internal class Class697
    {
        internal static void smethod_0()
        {
            Class698.class582_0.mainForm_0.Close();
        }

        internal static void smethod_1()
        {
            Class699 class2 = new Class699(Enum40.const_0);
            if ((class2.method_0(Enum41.const_1) == DialogResult.OK) && Class700.smethod_0(class2.String_0))
            {
                Class698.class582_0.class701_0.method_6(class2.String_0);
            }
        }

        internal static void smethod_2()
        {
            Class699 class2 = new Class699(Enum40.const_1);
            if ((class2.method_0(Enum41.const_1) == DialogResult.OK) && Class702.smethod_0(class2.String_0))
            {
                Class698.class582_0.class701_0.method_7(class2.String_0);
            }
        }

        internal static void smethod_3()
        {
            if (!Class645.class704_0.Boolean_1)
            {
                Class703 class2 = new Class703(Enum42.const_1);
                if (class2.method_0(Enum41.const_0) == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = File.CreateText(class2.String_0))
                        {
                            Class645.class704_0.Control0_0.method_9(writer);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, Class537.string_266, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        internal static void smethod_4()
        {
            if (!Class645.Boolean_0)
            {
                if (Class519.class394_0.bool_0)
                {
                    Class705.class705_6.method_0();
                }
                else
                {
                    try
                    {
                        Class519.class394_0.method_8();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, Class537.string_379, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        internal static void smethod_5()
        {
            if (!Class645.Boolean_0)
            {
                Class703 class2 = new Class703(Enum42.const_0);
                if (class2.method_0(Enum41.const_1) == DialogResult.OK)
                {
                    try
                    {
                        Class519.class394_0.method_9(class2.String_0);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, Class537.string_379, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        internal static void smethod_6()
        {
            if (!Class645.Boolean_0)
            {
                TreeNodeCollection nodes = Class698.class582_0.class686_0.class802_0.Nodes;
                if (nodes.Count > 0)
                {
                    Class394 class2 = Class519.class394_0;
                    if (!class2.class803_0.bool_0 || !Class645.smethod_11(class2))
                    {
                        int index = nodes.IndexOf(class2.class687_0);
                        int num2 = nodes.Count - 1;
                        if (num2 == 0)
                        {
                            Class804.smethod_0();
                        }
                        else
                        {
                            TreeNode node;
                            if (index < num2)
                            {
                                node = nodes[index + 1];
                            }
                            else
                            {
                                node = nodes[index - 1];
                            }
                            Class698.class582_0.class686_0.class802_0.SelectedNode = node;
                            Class686.Class687 class3 = node as Class686.Class687;
                            Class394 class4 = class3.class369_0 as Class394;
                            Class519.smethod_0(class4);
                        }
                        nodes.Remove(class2.class687_0);
                        Class645.smethod_2(class2);
                    }
                }
            }
        }
    }
}

