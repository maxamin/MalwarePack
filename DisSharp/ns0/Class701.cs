namespace ns0
{
    using System;
    using System.Collections;
    using System.Text;
    using System.Windows.Forms;

    internal class Class701
    {
        private ArrayList arrayList_0 = new ArrayList();
        private ArrayList arrayList_1 = new ArrayList();
        private Class582 class582_0;
        private StringBuilder stringBuilder_0 = new StringBuilder(100);

        internal void method_0(Class582 A_1)
        {
            this.class582_0 = A_1;
            this.class582_0.class936_0.toolStripMenuItem_1.Visible = false;
            this.class582_0.class936_0.toolStripMenuItem_2.Visible = false;
        }

        internal void method_1()
        {
            this.arrayList_0.Clear();
            this.arrayList_1.Clear();
            this.method_4();
        }

        private void method_2(ToolStripMenuItem A_1, int A_2, Class998 A_3)
        {
            this.stringBuilder_0.Length = 0;
            if (A_2 < 10)
            {
                this.stringBuilder_0.Append('&');
            }
            this.stringBuilder_0.Append(A_2);
            this.stringBuilder_0.Append(' ');
            this.stringBuilder_0.Append(A_3.string_0);
            ToolStripMenuItem item = new ToolStripMenuItem(this.stringBuilder_0.ToString());
            item.Click += new EventHandler(this.method_5);
            item.Tag = A_3;
            A_1.DropDownItems.Add(item);
        }

        private void method_3(ToolStripSplitButton A_1, Class998 A_2)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(A_2.string_0);
            item.Click += new EventHandler(this.method_5);
            item.Tag = A_2;
            A_1.DropDownItems.Add(item);
        }

        internal void method_4()
        {
            if (this.arrayList_0.Count > 0)
            {
                this.class582_0.class936_0.toolStripMenuItem_1.Visible = true;
            }
            else
            {
                this.class582_0.class936_0.toolStripMenuItem_1.Visible = false;
            }
            this.class582_0.class936_0.toolStripMenuItem_1.DropDownItems.Clear();
            this.class582_0.class937_0.toolStripSplitButton_0.DropDownItems.Clear();
            for (int i = 0; i < this.Int32_0; i++)
            {
                Class998 class2 = this.arrayList_0[i] as Class998;
                this.method_2(this.class582_0.class936_0.toolStripMenuItem_1, i + 1, class2);
                this.method_3(this.class582_0.class937_0.toolStripSplitButton_0, class2);
            }
            if (this.arrayList_1.Count > 0)
            {
                this.class582_0.class936_0.toolStripMenuItem_2.Visible = true;
            }
            else
            {
                this.class582_0.class936_0.toolStripMenuItem_2.Visible = false;
            }
            this.class582_0.class936_0.toolStripMenuItem_2.DropDownItems.Clear();
            this.class582_0.class937_0.toolStripSplitButton_1.DropDownItems.Clear();
            for (int j = 0; j < this.Int32_1; j++)
            {
                Class998 class3 = this.arrayList_1[j] as Class998;
                this.method_2(this.class582_0.class936_0.toolStripMenuItem_2, j + 1, class3);
                this.method_3(this.class582_0.class937_0.toolStripSplitButton_1, class3);
            }
        }

        private void method_5(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                Class998 tag = item.Tag as Class998;
                if (tag != null)
                {
                    if (tag.enum67_0 == Enum67.const_0)
                    {
                        if (Class700.smethod_0(tag.string_0))
                        {
                            this.method_6(tag.string_0);
                        }
                    }
                    else if (Class702.smethod_0(tag.string_0))
                    {
                        this.method_7(tag.string_0);
                    }
                }
            }
        }

        internal void method_6(string A_1)
        {
            this.method_8(this.arrayList_0, A_1);
            this.arrayList_0.Insert(0, new Class998(A_1, Enum67.const_0));
            this.method_4();
        }

        internal void method_7(string A_1)
        {
            this.method_8(this.arrayList_1, A_1);
            this.arrayList_1.Insert(0, new Class998(A_1, Enum67.const_1));
            this.method_4();
        }

        private void method_8(ArrayList A_1, string A_2)
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                Class998 class2 = A_1[i] as Class998;
                if (class2.string_0 == A_2)
                {
                    A_1.RemoveAt(i);
                    return;
                }
            }
        }

        internal ArrayList ArrayList_0
        {
            get
            {
                return this.arrayList_0;
            }
        }

        internal ArrayList ArrayList_1
        {
            get
            {
                return this.arrayList_1;
            }
        }

        private int Int32_0
        {
            get
            {
                if (this.arrayList_0.Count <= Class516.int_1)
                {
                    return this.arrayList_0.Count;
                }
                return Class516.int_1;
            }
        }

        private int Int32_1
        {
            get
            {
                if (this.arrayList_1.Count <= Class516.int_1)
                {
                    return this.arrayList_1.Count;
                }
                return Class516.int_1;
            }
        }
    }
}

