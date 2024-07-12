namespace ns0
{
    using Crownwood.DotNetMagic.Controls;
    using System;
    using System.Windows.Forms;

    internal class Class582
    {
        private Class1015 class1015_0 = new Class1015();
        internal Class1016 class1016_0 = new Class1016();
        internal Class1017 class1017_0 = new Class1017();
        internal Class686 class686_0 = new Class686();
        internal Class701 class701_0;
        internal Class891 class891_0 = new Class891();
        internal Class921 class921_0;
        internal Class936 class936_0 = new Class936();
        internal Class937 class937_0 = new Class937();
        internal Class984 class984_0;
        internal Class990 class990_0;
        internal MainForm mainForm_0 = new MainForm();
        internal StatusBarControl statusBarControl_0;

        internal Class582()
        {
            this.statusBarControl_0 = this.mainForm_0.statusBar;
            this.class701_0 = new Class701();
            this.class990_0 = new Class990();
            this.class921_0 = new Class921();
            this.class984_0 = new Class984();
        }

        internal void method_0()
        {
            Class868.smethod_1(this.mainForm_0.imageList_0.Images);
            this.class1015_0.method_0(this);
            this.class936_0.method_0(this);
            this.class1017_0.method_0(this);
            this.class937_0.method_0(this);
            this.class686_0.method_0(this);
            this.class891_0.method_0(this);
            this.class990_0.method_0(this);
            this.class701_0.method_0(this);
            this.class984_0.method_0(this);
            this.mainForm_0.panelLeft.Controls.Add(new Control1(this.class686_0.class802_0));
            this.mainForm_0.panelRight.Controls.Add(this.class891_0.tabControl_0);
            this.class891_0.tabControl_0.ContextMenuStrip = this.class1017_0.contextMenuStrip_2;
            Class645.smethod_0();
            Class705.smethod_1();
        }

        internal static void smethod_0()
        {
            Application.DoEvents();
        }

        internal static Class394 Class394_0
        {
            get
            {
                if (Class698.class582_0.class686_0.class802_0.Nodes.Count != 0)
                {
                    Class686.Class687 selectedNode = Class698.class582_0.class686_0.class802_0.SelectedNode as Class686.Class687;
                    if (selectedNode != null)
                    {
                        return selectedNode.class369_0.QQTW;
                    }
                }
                return null;
            }
        }
    }
}

