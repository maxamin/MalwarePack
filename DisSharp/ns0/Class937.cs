namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class937
    {
        private Class582 class582_0;
        private ImageList imageList_0;
        private ToolStrip toolStrip_0;
        internal ToolStripSplitButton toolStripSplitButton_0;
        internal ToolStripSplitButton toolStripSplitButton_1;
        internal ToolStripSplitButton toolStripSplitButton_2;

        internal void method_0(Class582 A_1)
        {
            this.class582_0 = A_1;
            this.toolStrip_0 = this.class582_0.mainForm_0.toolBar;
            this.imageList_0 = this.class582_0.mainForm_0.imageList_0;
            this.method_7();
        }

        private void method_1(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (item != null)
            {
                Class705 tag = item.Tag as Class705;
                Class925.smethod_0(tag);
            }
        }

        private ToolStripButton method_2(string A_1, int A_2, Class705 A_3)
        {
            ToolStripButton button = new ToolStripButton {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                ImageIndex = A_2,
                Tag = A_3,
                ToolTipText = A_1
            };
            button.Click += new EventHandler(this.method_1);
            this.toolStrip_0.Items.Add(button);
            A_3.toolStripButton_0 = button;
            A_3.QQTR();
            return button;
        }

        private ToolStripButton method_3(string A_1, Class705 A_2)
        {
            return this.method_2(A_1, -1, A_2);
        }

        private ToolStripSplitButton method_4(string A_1, int A_2, Class705 A_3)
        {
            ToolStripSplitButton button = new ToolStripSplitButton {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                ImageIndex = A_2,
                Tag = A_3,
                ToolTipText = A_1
            };
            button.ButtonClick += new EventHandler(this.method_1);
            this.toolStrip_0.Items.Add(button);
            A_3.toolStripSplitButton_0 = button;
            A_3.QQTR();
            return button;
        }

        private void method_5()
        {
            ToolStripSeparator separator = new ToolStripSeparator();
            this.toolStrip_0.Items.Add(separator);
        }

        private void method_6(ToolStripSplitButton A_1)
        {
            int count = this.class582_0.class1017_0.contextMenuStrip_3.Items.Count;
            for (int i = 0; i < count; i++)
            {
                ToolStripItem item = this.class582_0.class1017_0.contextMenuStrip_3.Items[0];
                A_1.DropDownItems.Add(item);
            }
        }

        private void method_7()
        {
            this.toolStripSplitButton_0 = this.method_4(Class537.string_479, Class868.int_18, Class705.class705_0);
            this.method_2(Class537.string_486, Class868.int_70, Class705.class705_2);
            this.method_5();
            this.toolStripSplitButton_1 = this.method_4(Class537.string_3, Class868.int_56, Class705.class705_4);
            this.method_2(Class537.string_36, Class868.int_62, Class705.class705_5);
            this.method_5();
            this.method_2(Class537.string_100, Class868.int_58, Class705.class705_10);
            this.method_2(Class537.string_392, Class868.int_50, Class705.class705_11);
            this.method_2(Class537.string_728, Class868.int_52, Class705.class705_12);
            this.method_5();
            this.toolStripSplitButton_2 = this.method_4(Class537.string_233, Class868.int_74, Class705.class705_27);
            this.method_6(this.toolStripSplitButton_2);
            this.method_2(Class537.string_690, Class868.int_68, Class705.class705_34);
            this.method_2(Class537.string_621, Class868.int_1, Class705.class705_45);
            this.method_2(Class537.string_725, Class868.int_15, Class705.class705_52);
            this.method_2(Class537.string_293, Class868.int_37, Class705.class705_54);
            this.method_5();
            this.method_2(Class537.string_306, Class868.int_41, Class705.class705_19);
            this.method_2(Class537.string_370, Class868.int_42, Class705.class705_20);
            this.method_2(Class537.string_574, Class868.int_43, Class705.class705_21);
            this.method_2(Class537.string_721, Class868.int_44, Class705.class705_22);
            this.method_2(Class537.string_667, Class868.int_45, Class705.class705_23);
            this.method_2(Class537.string_672, Class868.int_46, Class705.class705_24);
            this.method_2(Class537.string_71, Class868.int_47, Class705.class705_25);
            this.method_2(Class537.string_363, Class868.int_72, Class705.class705_26);
            this.method_5();
            this.method_2(Class537.string_555, Class868.int_49, Class705.class705_36);
            this.method_2(Class537.string_671, Class868.int_24, Class705.class705_42);
            this.method_2(Class537.string_478, Class868.int_61, Class705.class705_43);
            this.method_2(Class537.string_803, Class868.int_48, Class705.class705_37);
            this.method_5();
            this.method_2(Class537.string_174, Class868.int_38, Class705.class705_55);
            this.method_2(Class537.string_938, Class868.int_40, Class705.class705_71);
            this.method_2(Class537.string_688, Class868.int_57, Class705.class705_74);
            this.method_5();
            this.method_2(Class537.string_451, Class868.int_51, Class705.class705_75);
        }
    }
}

