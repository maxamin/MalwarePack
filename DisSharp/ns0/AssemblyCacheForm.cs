namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class AssemblyCacheForm : Form0
    {
        private Button buttonCancel;
        private Button buttonOk;
        private ColumnHeader columnHeader_0;
        private ColumnHeader columnHeader_1;
        private ColumnHeader columnHeader_2;
        private Container container_0;
        private ListView listview;

        internal AssemblyCacheForm()
        {
            this.InitializeComponent();
        }

        private void AssemblyCacheForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonOk.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.buttonCancel.PerformClick();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.container_0 != null))
            {
                this.container_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonOk = new Button();
            this.buttonCancel = new Button();
            this.listview = new ListView();
            this.columnHeader_0 = new ColumnHeader();
            this.columnHeader_1 = new ColumnHeader();
            this.columnHeader_2 = new ColumnHeader();
            base.SuspendLayout();
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.FlatStyle = FlatStyle.System;
            this.buttonOk.Location = new Point(80, 280);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(0x58, 0x20);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.FlatStyle = FlatStyle.System;
            this.buttonCancel.Location = new Point(0x100, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x58, 0x20);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.listview.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.listview.Columns.AddRange(new ColumnHeader[] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2 });
            this.listview.Location = new Point(0x10, 0x10);
            this.listview.Name = "listview";
            this.listview.Size = new Size(0x188, 240);
            this.listview.Sorting = SortOrder.Ascending;
            this.listview.TabIndex = 0;
            this.listview.View = View.Details;
            this.listview.KeyDown += new KeyEventHandler(this.listview_KeyDown);
            this.columnHeader_0.Text = "Assembly";
            this.columnHeader_0.Width = 280;
            this.columnHeader_1.Text = "Version";
            this.columnHeader_1.Width = 90;
            this.columnHeader_2.Text = "Location";
            this.columnHeader_2.Width = 900;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x1aa, 0x150);
            base.Controls.Add(this.listview);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOk);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "AssemblyCacheForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Load From Assembly Cache";
            base.KeyDown += new KeyEventHandler(this.AssemblyCacheForm_KeyDown);
            base.ResumeLayout(false);
        }

        private void listview_KeyDown(object sender, KeyEventArgs e)
        {
            this.AssemblyCacheForm_KeyDown(sender, e);
        }

        internal void method_0(string A_1, string A_2, string A_3)
        {
            this.listview.Items.Add(new ListViewItem(new string[] { A_1, A_2, A_3 }));
        }

        internal string[] String_0
        {
            get
            {
                int count = this.listview.SelectedItems.Count;
                string[] strArray = new string[count];
                for (int i = 0; i < count; i++)
                {
                    strArray[i] = this.listview.SelectedItems[i].SubItems[2].Text;
                }
                return strArray;
            }
        }
    }
}

