namespace ns0
{
    using System;
    using System.Collections;
    using System.ComponentModel.Design;
    using System.Data;
    using System.IO;
    using System.Text;
    using System.Web;
    using System.Windows.Forms;

    internal class Class990
    {
        private ArrayList arrayList_0 = new ArrayList();
        private ArrayList arrayList_1 = new ArrayList();
        private ArrayList arrayList_2 = new ArrayList();
        internal DisplayMode displayMode_0;
        internal Enum65 enum65_0;
        internal const int int_0 = 0xdb7cf;
        internal ProcessStatus processStatus_0;
        internal SchemaType schemaType_0;
        private string string_0;
        internal UriPartial uriPartial_0;

        internal void method_0(Class582 A_1)
        {
            this.uriPartial_0 = UriPartial.Scheme;
            this.schemaType_0 = SchemaType.Mapped;
            this.displayMode_0 = DisplayMode.Ansi;
            this.processStatus_0 = ProcessStatus.Alive;
            this.method_11();
            StringBuilder builder = new StringBuilder(100);
            ToolStripMenuItem item = A_1.class936_0.toolStripMenuItem_0;
            this.method_1(builder, item, 1, Class537.string_261, new EventHandler(this.method_2));
            this.method_1(builder, item, 2, Class537.string_833, new EventHandler(this.method_3));
            this.method_1(builder, item, 3, Class537.string_155, new EventHandler(this.method_4));
            this.method_1(builder, item, 4, Class537.string_770, new EventHandler(this.method_5));
            this.method_1(builder, item, 5, Class537.string_70, new EventHandler(this.method_6));
            this.method_1(builder, item, 6, Class537.string_888, new EventHandler(this.method_7));
            this.method_1(builder, item, 7, Class537.string_341, new EventHandler(this.method_8));
            item.Visible = true;
        }

        private void method_1(StringBuilder A_1, ToolStripMenuItem A_2, int A_3, string A_4, EventHandler A_5)
        {
            A_1.Length = 0;
            A_1.Append('&');
            A_1.Append(A_3);
            A_1.Append(' ');
            A_1.Append(A_4 + Class537.string_586);
            ToolStripMenuItem item = new ToolStripMenuItem(A_1.ToString());
            item.Click += A_5;
            A_2.DropDownItems.Add(item);
        }

        private void method_10()
        {
            if (this.string_0 == null)
            {
                if (this.arrayList_0.Count == 1)
                {
                    this.string_0 = ((string) this.arrayList_0[0]) + @"\";
                }
                else
                {
                    Class993.listForm_0.method_0(this.arrayList_2, Class537.string_480);
                    Class993.listForm_0.ShowDialog();
                    Class582.smethod_0();
                    int selectedIndex = Class993.listForm_0.ListBox.SelectedIndex;
                    string str = (string) this.arrayList_2[selectedIndex];
                    int num2 = 0;
                    for (int i = 0; i < this.arrayList_1.Count; i++)
                    {
                        if (((string) this.arrayList_1[i]) == str)
                        {
                            num2 = i;
                            break;
                        }
                    }
                    this.string_0 = ((string) this.arrayList_0[num2]) + @"\";
                }
            }
        }

        private void method_11()
        {
            string path = Environment.ExpandEnvironmentVariables(Class537.string_942);
            string[] directories = Directory.GetDirectories(path, Class537.string_745);
            string[] strArray2 = new string[directories.Length];
            int length = path.Length;
            for (int i = 0; i < directories.Length; i++)
            {
                strArray2[i] = directories[i].Substring(length);
            }
            for (int j = 0; j < directories.Length; j++)
            {
                if ((strArray2[j][0] == 'v') && File.Exists(directories[j] + @"\" + Class537.string_261 + Class537.string_586))
                {
                    this.arrayList_0.Add(directories[j]);
                    this.arrayList_1.Add(strArray2[j]);
                    this.arrayList_2.Add(strArray2[j]);
                }
            }
            Class808.smethod_1(this.arrayList_2);
        }

        private void method_2(object sender, EventArgs e)
        {
            this.method_9(Enum65.const_1, Class537.string_261);
        }

        private void method_3(object sender, EventArgs e)
        {
            this.method_9(Enum65.const_2, Class537.string_833);
        }

        private void method_4(object sender, EventArgs e)
        {
            this.method_9(Enum65.const_3, Class537.string_155);
        }

        private void method_5(object sender, EventArgs e)
        {
            this.method_9(Enum65.const_4, Class537.string_770);
        }

        private void method_6(object sender, EventArgs e)
        {
            this.method_9(Enum65.const_5, Class537.string_70);
        }

        private void method_7(object sender, EventArgs e)
        {
            this.method_9(Enum65.const_6, Class537.string_888);
        }

        private void method_8(object sender, EventArgs e)
        {
            this.method_9(Enum65.const_7, Class537.string_341);
        }

        private void method_9(Enum65 A_1, string A_2)
        {
            this.method_10();
            try
            {
                this.enum65_0 = A_1;
                Class700.smethod_0(this.string_0 + A_2 + Class537.string_586);
                Class519.class394_0.bool_4 = true;
            }
            finally
            {
                this.enum65_0 = Enum65.const_0;
            }
        }

        internal bool Boolean_0
        {
            get
            {
                return ((this.enum65_0 != Enum65.const_0) && (Class519.class394_0.int_0 > 0xdb7cf));
            }
        }
    }
}

