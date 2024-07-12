namespace ns0
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class EditMethodNamesDialog : Form0
    {
        private bool bool_0;
        private static bool bool_1 = true;
        private Button button_0;
        private const byte byte_0 = 2;
        private Button cancel;
        private Class369 class369_0;
        private Class547.Class528 class528_0;
        private Class951 class951_0;
        private Container container_0;
        private DataGrid grid;
        private const int int_0 = 50;
        private const int int_1 = 150;
        private const int int_2 = 150;
        private static int int_3;
        private static int int_4;
        private static int int_5;
        private static int int_6;
        private static int int_7;
        private static int int_8;
        private static int int_9;
        private Label methodLabel;
        private Panel panelTop;

        internal EditMethodNamesDialog(Class369 A_1, Class547.Class528 A_2, bool A_3)
        {
            this.InitializeComponent();
            this.class369_0 = A_1;
            this.class528_0 = A_2;
            this.bool_0 = A_3;
            this.methodLabel.Text = "Method: " + A_1.Name;
            DataGridTableStyle table = new DataGridTableStyle();
            if (A_3)
            {
                this.Text = "Edit locals";
                this.class951_0 = new Class951(this.grid);
                this.class951_0.method_0("Local", typeof(int));
                this.class951_0.method_0("Type", typeof(string));
                this.class951_0.method_0("Name", typeof(string));
                table.GridColumnStyles.Add(this.method_0("Local", 50, true));
                table.GridColumnStyles.Add(this.method_0("Type", 150, true));
                table.GridColumnStyles.Add(this.method_0("Name", 150, false));
                ArrayList list = Class546.class574_0.arrayList_0;
                for (int i = 0; i < A_2.short_3; i++)
                {
                    Class574.Class636 class2 = list[A_2.int_7 + i] as Class574.Class636;
                    string str = Class1001.smethod_0(class2.enum11_0, class2.int_1, class2.byte_0);
                    this.class951_0.method_1(new object[] { i, str, Class519.class581_0[class2.int_0] });
                }
                this.class951_0.method_2(this);
            }
            else
            {
                this.Text = "Edit parameters";
                this.class951_0 = new Class951(this.grid);
                this.class951_0.method_0("Param", typeof(int));
                this.class951_0.method_0("Type", typeof(string));
                this.class951_0.method_0("Name", typeof(string));
                table.GridColumnStyles.Add(this.method_0("Param", 50, true));
                table.GridColumnStyles.Add(this.method_0("Type", 150, true));
                table.GridColumnStyles.Add(this.method_0("Name", 150, false));
                ArrayList list2 = Class546.class568_0.arrayList_0;
                for (int j = 0; j < A_2.short_2; j++)
                {
                    Class568.Class623 class3 = list2[A_2.int_6 + j] as Class568.Class623;
                    string str2 = Class1001.smethod_0(class3.enum11_0, class3.int_1, class3.byte_4);
                    this.class951_0.method_1(new object[] { j, str2, Class519.class581_0[class3.int_0] });
                }
                this.class951_0.method_2(this);
            }
            this.grid.TableStyles.Add(table);
            this.method_1();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                ArrayList list = Class546.class574_0.arrayList_0;
                for (int i = 0; i < this.class528_0.short_3; i++)
                {
                    Class574.Class636 class2 = list[this.class528_0.int_7 + i] as Class574.Class636;
                    string str = (string) this.class951_0[2, i];
                    if (Class805.smethod_0(str))
                    {
                        Class519.class581_0[class2.int_0] = str;
                    }
                    else
                    {
                        Class805.smethod_2(str);
                    }
                }
            }
            else
            {
                ArrayList list2 = Class546.class568_0.arrayList_0;
                for (int j = 0; j < this.class528_0.short_2; j++)
                {
                    Class568.Class623 class3 = list2[this.class528_0.int_6 + j] as Class568.Class623;
                    string str2 = (string) this.class951_0[2, j];
                    if (Class805.smethod_0(str2))
                    {
                        Class519.class581_0[class3.int_0] = str2;
                    }
                    else
                    {
                        Class805.smethod_2(str2);
                    }
                }
            }
            base.DialogResult = DialogResult.OK;
            this.method_2();
            base.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            this.method_2();
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.container_0 != null))
            {
                this.container_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void EditMethodNamesDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button_0.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.cancel.PerformClick();
            }
        }

        private void InitializeComponent()
        {
            this.button_0 = new Button();
            this.cancel = new Button();
            this.panelTop = new Panel();
            this.grid = new DataGrid();
            this.methodLabel = new Label();
            this.panelTop.SuspendLayout();
            this.grid.BeginInit();
            base.SuspendLayout();
            this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.FlatStyle = FlatStyle.System;
            this.button_0.Location = new Point(0x40, 0x134);
            this.button_0.Name = "ok";
            this.button_0.Size = new Size(0x70, 0x20);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "OK";
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.cancel.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.cancel.DialogResult = DialogResult.Cancel;
            this.cancel.FlatStyle = FlatStyle.System;
            this.cancel.Location = new Point(0x110, 0x134);
            this.cancel.Name = "cancel";
            this.cancel.Size = new Size(0x70, 0x20);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new EventHandler(this.cancel_Click);
            this.panelTop.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.panelTop.Controls.Add(this.grid);
            this.panelTop.Controls.Add(this.methodLabel);
            this.panelTop.Location = new Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(0x1c0, 0x128);
            this.panelTop.TabIndex = 5;
            this.grid.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.grid.CaptionVisible = false;
            this.grid.DataMember = "";
            this.grid.HeaderForeColor = SystemColors.ControlText;
            this.grid.Location = new Point(0x10, 0x38);
            this.grid.Name = "grid";
            this.grid.Size = new Size(0x1a0, 0xe8);
            this.grid.TabIndex = 5;
            this.grid.KeyDown += new KeyEventHandler(this.EditMethodNamesDialog_KeyDown);
            this.methodLabel.FlatStyle = FlatStyle.System;
            this.methodLabel.Location = new Point(0x10, 0x10);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new Size(0x1a8, 0x17);
            this.methodLabel.TabIndex = 0;
            this.methodLabel.Text = "label1";
            this.AutoScaleBaseSize = new Size(7, 0x11);
            base.ClientSize = new Size(0x1c0, 0x166);
            base.Controls.Add(this.panelTop);
            base.Controls.Add(this.cancel);
            base.Controls.Add(this.button_0);
            this.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "EditMethodNamesDialog";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edit method names";
            base.KeyDown += new KeyEventHandler(this.EditMethodNamesDialog_KeyDown);
            this.panelTop.ResumeLayout(false);
            this.grid.EndInit();
            base.ResumeLayout(false);
        }

        private DataGridColumnStyle method_0(string A_1, int A_2, bool A_3)
        {
            return new DataGridTextBoxColumn { 
                MappingName = A_1,
                HeaderText = A_1,
                Width = A_2,
                ReadOnly = A_3
            };
        }

        private void method_1()
        {
            if (!bool_1)
            {
                base.StartPosition = FormStartPosition.Manual;
                base.Left = int_3;
                base.Top = int_4;
                base.Width = int_5;
                base.Height = int_6;
                this.grid.TableStyles[0].GridColumnStyles[0].Width = int_7;
                this.grid.TableStyles[0].GridColumnStyles[1].Width = int_8;
                this.grid.TableStyles[0].GridColumnStyles[2].Width = int_9;
            }
        }

        private void method_2()
        {
            int_3 = base.Left;
            int_4 = base.Top;
            int_5 = base.Width;
            int_6 = base.Height;
            int_7 = this.grid.TableStyles[0].GridColumnStyles[0].Width;
            int_8 = this.grid.TableStyles[0].GridColumnStyles[1].Width;
            int_9 = this.grid.TableStyles[0].GridColumnStyles[2].Width;
            bool_1 = false;
        }
    }
}

