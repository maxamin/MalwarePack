namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    internal class Class1017
    {
        internal ContextMenuStrip contextMenuStrip_0;
        internal ContextMenuStrip contextMenuStrip_1;
        internal ContextMenuStrip contextMenuStrip_2;
        internal ContextMenuStrip contextMenuStrip_3;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripMenuItem toolStripMenuItem_5;
        private ToolStripMenuItem toolStripMenuItem_6;
        private ToolStripMenuItem toolStripMenuItem_7;

        private void contextMenuStrip_2_Opening(object sender, CancelEventArgs e)
        {
            if (Class645.class704_0.Boolean_0)
            {
                e.Cancel = true;
            }
        }

        internal void method_0(Class582 A_1)
        {
            ImageList list = A_1.mainForm_0.imageList_0;
            this.contextMenuStrip_1 = new ContextMenuStrip();
            this.contextMenuStrip_1.ImageList = list;
            this.toolStripMenuItem_0 = this.method_3(Class537.string_254, Class868.int_39, new EventHandler(this.method_5));
            this.toolStripMenuItem_1 = this.method_3(Class537.string_589, Class868.int_67, new EventHandler(this.method_6));
            this.toolStripMenuItem_2 = this.method_3(Class537.string_470, Class868.int_64, new EventHandler(this.method_7));
            this.contextMenuStrip_1.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.method_4(), this.toolStripMenuItem_2 });
            this.contextMenuStrip_0 = new ContextMenuStrip();
            this.contextMenuStrip_0.ImageList = list;
            this.toolStripMenuItem_3 = this.method_3(Class537.string_891, Class868.int_1, new EventHandler(this.method_9));
            this.toolStripMenuItem_4 = this.method_3(Class537.string_180, Class868.int_15, new EventHandler(this.method_10));
            this.toolStripMenuItem_5 = this.method_3(Class537.string_404, Class868.int_37, new EventHandler(this.method_11));
            this.toolStripMenuItem_6 = this.method_3(Class537.string_439, Class868.int_62, new EventHandler(this.method_12));
            this.toolStripMenuItem_7 = this.method_3(Class537.string_794, Class868.int_70, new EventHandler(this.method_13));
            this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem_3, this.toolStripMenuItem_4, this.toolStripMenuItem_5, this.method_4(), this.toolStripMenuItem_6, this.toolStripMenuItem_7 });
            this.contextMenuStrip_2 = new ContextMenuStrip();
            this.contextMenuStrip_2.Opening += new CancelEventHandler(this.contextMenuStrip_2_Opening);
            this.contextMenuStrip_2.ImageList = list;
            this.contextMenuStrip_2.Items.AddRange(new ToolStripItem[] { this.method_2(this.method_1(Class537.string_685), new EventHandler(this.method_14)), this.method_2(this.method_1(Class537.string_730), new EventHandler(this.method_15)), this.method_2(this.method_1(Class537.string_47), new EventHandler(this.method_16)) });
            this.contextMenuStrip_3 = new ContextMenuStrip();
            this.contextMenuStrip_3.ImageList = list;
            this.contextMenuStrip_3.Items.AddRange(new ToolStripItem[] { this.method_3(this.method_1(Class537.string_538), Class868.int_74, new EventHandler(this.method_18)), this.method_3(this.method_1(Class537.string_899), Class868.int_76, new EventHandler(this.method_19)), this.method_3(this.method_1(Class537.string_474), Class868.int_75, new EventHandler(this.method_20)), this.method_3(this.method_1(Class537.string_437), Class868.int_73, new EventHandler(this.method_21)) });
        }

        private string method_1(string A_1)
        {
            return Class543.smethod_1(A_1);
        }

        private void method_10(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_52);
        }

        private void method_11(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_54);
        }

        private void method_12(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_5);
        }

        private void method_13(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_2);
        }

        private void method_14(object sender, EventArgs e)
        {
            Class645.class704_0.method_6();
        }

        private void method_15(object sender, EventArgs e)
        {
            Class645.class704_0.method_7();
        }

        private void method_16(object sender, EventArgs e)
        {
            Class645.class704_0.method_8();
        }

        private void method_17(object sender, EventArgs e)
        {
        }

        private void method_18(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_28);
        }

        private void method_19(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_31);
        }

        private ToolStripMenuItem method_2(string A_1, EventHandler A_2)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(A_1);
            item.Click += A_2;
            return item;
        }

        private void method_20(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_32);
        }

        private void method_21(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_33);
        }

        internal void method_22(bool A_1)
        {
            if (Class645.Boolean_0)
            {
                this.toolStripMenuItem_3.Enabled = false;
                this.toolStripMenuItem_4.Enabled = false;
                this.toolStripMenuItem_5.Enabled = false;
                this.toolStripMenuItem_6.Enabled = false;
                this.toolStripMenuItem_7.Enabled = false;
            }
            else
            {
                if (A_1)
                {
                    this.toolStripMenuItem_3.Enabled = Class519.class369_0.QQRQ;
                    this.toolStripMenuItem_4.Enabled = Class519.class369_0.QQQZ;
                    this.toolStripMenuItem_5.Enabled = Class519.class369_0.QQQZ;
                }
                else
                {
                    this.toolStripMenuItem_3.Enabled = false;
                    this.toolStripMenuItem_4.Enabled = false;
                    this.toolStripMenuItem_5.Enabled = false;
                }
                this.toolStripMenuItem_6.Enabled = true;
                this.toolStripMenuItem_7.Enabled = true;
            }
        }

        private ToolStripMenuItem method_3(string A_1, int A_2, EventHandler A_3)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(A_1) {
                ImageIndex = A_2
            };
            item.Click += A_3;
            return item;
        }

        private ToolStripItem method_4()
        {
            return new ToolStripSeparator();
        }

        private void method_5(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_8);
        }

        private void method_6(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_9);
        }

        private void method_7(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_3);
        }

        internal void method_8(bool A_1)
        {
            if (A_1)
            {
                this.toolStripMenuItem_0.Enabled = true;
            }
            else
            {
                this.toolStripMenuItem_0.Enabled = false;
            }
        }

        private void method_9(object sender, EventArgs e)
        {
            Class925.smethod_0(Class705.class705_45);
        }
    }
}

