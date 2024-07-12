namespace ns0
{
    using System;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class EditXmlDocDialog : Form0
    {
        private Button button_0;
        private Button cancel;
        private Container container_0;
        private TextBox edit;
        private Label nameLabel;
        private Panel panelTop;

        internal EditXmlDocDialog(string A_1, StringCollection A_2)
        {
            this.InitializeComponent();
            this.nameLabel.Text = A_1;
            if (A_2 != null)
            {
                string[] strArray = new string[A_2.Count];
                for (int i = 0; i < A_2.Count; i++)
                {
                    strArray[i] = A_2[i];
                }
                this.edit.Lines = strArray;
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
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

        private void InitializeComponent()
        {
            this.button_0 = new Button();
            this.cancel = new Button();
            this.panelTop = new Panel();
            this.edit = new TextBox();
            this.nameLabel = new Label();
            this.panelTop.SuspendLayout();
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
            this.panelTop.Controls.Add(this.edit);
            this.panelTop.Controls.Add(this.nameLabel);
            this.panelTop.Location = new Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(0x1c0, 0x128);
            this.panelTop.TabIndex = 5;
            this.edit.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.edit.Location = new Point(8, 0x38);
            this.edit.Multiline = true;
            this.edit.Name = "edit";
            this.edit.Size = new Size(0x1b0, 0xe8);
            this.edit.TabIndex = 0;
            this.edit.Text = "";
            this.edit.WordWrap = false;
            this.nameLabel.FlatStyle = FlatStyle.System;
            this.nameLabel.Location = new Point(0x10, 0x10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new Size(0x1a8, 0x17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "label1";
            this.AutoScaleBaseSize = new Size(7, 0x11);
            base.ClientSize = new Size(0x1c0, 0x166);
            base.Controls.Add(this.panelTop);
            base.Controls.Add(this.cancel);
            base.Controls.Add(this.button_0);
            this.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "EditXmlDocDialog";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edit XML Documentation";
            this.panelTop.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void method_0(object sender, KeyEventArgs e)
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

        internal string[] String_0
        {
            get
            {
                return this.edit.Lines;
            }
        }
    }
}

