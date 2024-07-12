namespace ns0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class Class686
    {
        internal Class802 class802_0;

        private void class802_0_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Class369 class2 = (e.Node as Class687).class369_0;
            Class519.smethod_1(class2);
            if (Class516.bool_6)
            {
                bool flag = Class516.bool_5;
                Class516.bool_5 = true;
                if (class2.QQQZ)
                {
                    Class925.smethod_0(Class705.class705_52);
                }
                Class516.bool_5 = flag;
            }
        }

        private void class802_0_DoubleClick(object sender, EventArgs e)
        {
            Class645.smethod_9();
        }

        internal void method_0(Class582 A_1)
        {
            this.class802_0 = new Class802();
            this.class802_0.TabIndex = 0;
            this.class802_0.BorderStyle = BorderStyle.None;
            this.class802_0.HotTracking = true;
            this.class802_0.ImageIndex = -1;
            this.class802_0.SelectedImageIndex = -1;
            this.class802_0.Location = new Point(0, 0);
            this.class802_0.Size = new Size(0x110, 0x13d);
            this.class802_0.ImageList = A_1.mainForm_0.imageList_0;
            this.class802_0.AfterSelect += new TreeViewEventHandler(this.class802_0_AfterSelect);
            this.class802_0.Event_0 += new Delegate0(this.method_2);
            this.class802_0.DoubleClick += new EventHandler(this.class802_0_DoubleClick);
        }

        private void method_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Class645.smethod_9();
                e.Handled = true;
            }
        }

        private void method_2(object A_1, Keys A_2)
        {
            Class645.smethod_9();
        }

        internal class Class687 : TreeNode
        {
            internal Class369 class369_0;
            internal static Class686.Class687 class687_0 = new Class686.Class687(new Class395());

            internal Class687(Class369 A_1)
            {
                this.class369_0 = A_1;
                A_1.QQWT();
                base.Text = A_1.String_0;
            }
        }
    }
}

