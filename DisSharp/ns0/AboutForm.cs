namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    internal class AboutForm : Form0
    {
        private Button buttonOk;
        private Container container_0;
        private Control4 control4_0;
        private Label Copyright;
        private Label LicensedLabel;
        internal Label OrgName;
        internal Label UserName;
        private Label Version;

        internal AboutForm()
        {
            this.InitializeComponent();
            this.control4_0 = new Control4();
            this.control4_0.Location = new Point(0x38, 8);
            base.Controls.Add(this.control4_0);
        }

        private void AboutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonOk.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.Version.Text = "Version " + this.method_1();
            this.Copyright.Text = "\x00a9 " + Class537.string_338 + ", 2004-2007. All Rights Reserved.";
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
            new ComponentResourceManager(typeof(AboutForm));
            this.buttonOk = new Button();
            this.Version = new Label();
            this.Copyright = new Label();
            this.LicensedLabel = new Label();
            this.UserName = new Label();
            this.OrgName = new Label();
            base.SuspendLayout();
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.FlatStyle = FlatStyle.System;
            this.buttonOk.Location = new Point(120, 0x100);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(0x58, 0x20);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.Version.FlatStyle = FlatStyle.System;
            this.Version.Location = new Point(0x38, 120);
            this.Version.Name = "Version";
            this.Version.Size = new Size(0xd8, 0x10);
            this.Version.TabIndex = 10;
            this.Version.Text = "Version";
            this.Version.TextAlign = ContentAlignment.MiddleCenter;
            this.Copyright.FlatStyle = FlatStyle.System;
            this.Copyright.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.Copyright.Location = new Point(9, 0xd0);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new Size(0x138, 0x10);
            this.Copyright.TabIndex = 11;
            this.Copyright.Text = "Copyright";
            this.Copyright.TextAlign = ContentAlignment.MiddleCenter;
            this.LicensedLabel.FlatStyle = FlatStyle.System;
            this.LicensedLabel.Location = new Point(0x38, 0x90);
            this.LicensedLabel.Name = "LicensedLabel";
            this.LicensedLabel.Size = new Size(0xd8, 0x10);
            this.LicensedLabel.TabIndex = 14;
            this.LicensedLabel.Text = "This product is licensed to:";
            this.LicensedLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.UserName.FlatStyle = FlatStyle.System;
            this.UserName.Location = new Point(0x38, 0xa1);
            this.UserName.Name = "UserName";
            this.UserName.Size = new Size(0x108, 0x10);
            this.UserName.TabIndex = 15;
            this.UserName.Text = "UserName";
            this.UserName.TextAlign = ContentAlignment.MiddleLeft;
            this.OrgName.FlatStyle = FlatStyle.System;
            this.OrgName.Location = new Point(0x38, 0xb2);
            this.OrgName.Name = "OrgName";
            this.OrgName.Size = new Size(0x108, 0x10);
            this.OrgName.TabIndex = 0x10;
            this.OrgName.Text = "Orgname";
            this.OrgName.TextAlign = ContentAlignment.MiddleLeft;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x146, 0x130);
            base.Controls.Add(this.OrgName);
            base.Controls.Add(this.UserName);
            base.Controls.Add(this.LicensedLabel);
            base.Controls.Add(this.Copyright);
            base.Controls.Add(this.Version);
            base.Controls.Add(this.buttonOk);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.KeyPreview = true;
            base.Location = new Point(0, 0);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "AboutForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "About";
            base.KeyDown += new KeyEventHandler(this.AboutForm_KeyDown);
            base.Load += new EventHandler(this.AboutForm_Load);
            base.ResumeLayout(false);
        }

        private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Process { StartInfo = { FileName = "http://www.dotnetmagic.com" } }.Start();
        }

        private string method_1()
        {
            string productVersion = Application.ProductVersion;
            int length = productVersion.LastIndexOf('.');
            if (length != -1)
            {
                productVersion = productVersion.Substring(0, length);
            }
            return productVersion;
        }
    }
}

