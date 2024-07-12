namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class RequestActivationCode : Form0
    {
        private Button buttonCancel;
        private Button buttonOk;
        private Container container_0;
        private Label label1;
        private Label label2;
        private Label label3;
        protected internal TextBox OrgName;
        protected internal TextBox UserName;

        internal RequestActivationCode()
        {
            this.InitializeComponent();
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
            this.label1 = new Label();
            this.buttonOk = new Button();
            this.buttonCancel = new Button();
            this.UserName = new TextBox();
            this.label2 = new Label();
            this.OrgName = new TextBox();
            this.label3 = new Label();
            base.SuspendLayout();
            this.label1.FlatStyle = FlatStyle.System;
            this.label1.Location = new Point(0x10, 0x58);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x40, 0x10);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.FlatStyle = FlatStyle.System;
            this.buttonOk.Location = new Point(0x30, 0xd0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(0x58, 0x20);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.FlatStyle = FlatStyle.System;
            this.buttonCancel.Location = new Point(0xd0, 0xd0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x58, 0x20);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.UserName.Location = new Point(0x10, 0x70);
            this.UserName.Name = "UserName";
            this.UserName.Size = new Size(0x138, 20);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "";
            this.UserName.KeyDown += new KeyEventHandler(this.OrgName_KeyDown);
            this.label2.FlatStyle = FlatStyle.System;
            this.label2.Location = new Point(0x10, 0x90);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x60, 0x10);
            this.label2.TabIndex = 8;
            this.label2.Text = "Organization:";
            this.OrgName.Location = new Point(0x10, 0xa8);
            this.OrgName.Name = "OrgName";
            this.OrgName.Size = new Size(0x138, 20);
            this.OrgName.TabIndex = 1;
            this.OrgName.Text = "";
            this.OrgName.KeyDown += new KeyEventHandler(this.OrgName_KeyDown);
            this.label3.FlatStyle = FlatStyle.System;
            this.label3.Location = new Point(0x10, 0x10);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x130, 0x40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please, send file, containing code, to NETdecompiler.com (Help->Feedback)";
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x15a, 0x100);
            base.Controls.Add(this.OrgName);
            base.Controls.Add(this.UserName);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOk);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "RequestActivationCode";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Request Activation Code";
            base.KeyDown += new KeyEventHandler(this.RequestActivationCode_KeyDown);
            base.ResumeLayout(false);
        }

        private void OrgName_KeyDown(object sender, KeyEventArgs e)
        {
            this.RequestActivationCode_KeyDown(sender, e);
        }

        private void RequestActivationCode_KeyDown(object sender, KeyEventArgs e)
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
    }
}

