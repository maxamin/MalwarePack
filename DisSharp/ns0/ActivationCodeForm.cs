namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class ActivationCodeForm : Form0
    {
        private Button buttonCancel;
        private Button buttonOk;
        private Container container_0;
        private Label label1;
        private Label label2;
        private Label label3;
        internal TextBox TextBox1;
        internal TextBox TextBox2;

        internal ActivationCodeForm()
        {
            this.InitializeComponent();
        }

        private void ActivationCodeForm_KeyDown(object sender, KeyEventArgs e)
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

        private void ActivationCodeForm_Load(object sender, EventArgs e)
        {
            this.Text = Class537.string_335;
            this.label1.Text = Class537.string_806;
            this.label2.Text = Class537.string_283;
            this.label3.Text = Class537.string_409;
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
            this.label2 = new Label();
            this.TextBox1 = new TextBox();
            this.label3 = new Label();
            this.TextBox2 = new TextBox();
            this.label1 = new Label();
            base.SuspendLayout();
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
            this.label2.FlatStyle = FlatStyle.System;
            this.label2.Location = new Point(0x10, 0x4b);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x60, 0x10);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2:";
            this.TextBox1.Location = new Point(0x10, 0x60);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new Size(0x138, 20);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "";
            this.TextBox1.KeyDown += new KeyEventHandler(this.TextBox2_KeyDown);
            this.label3.FlatStyle = FlatStyle.System;
            this.label3.Location = new Point(0x10, 0x88);
            this.label3.Name = "label3";
            this.label3.Size = new Size(160, 0x10);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3:";
            this.TextBox2.Location = new Point(0x10, 0x9c);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new Size(0x138, 20);
            this.TextBox2.TabIndex = 2;
            this.TextBox2.Text = "";
            this.TextBox2.KeyDown += new KeyEventHandler(this.TextBox2_KeyDown);
            this.label1.FlatStyle = FlatStyle.System;
            this.label1.Location = new Point(0x10, 0x13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(320, 0x2d);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1:";
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x15a, 0x100);
            base.Controls.Add(this.TextBox2);
            base.Controls.Add(this.TextBox1);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOk);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ActivationCodeForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Form1";
            base.KeyDown += new KeyEventHandler(this.ActivationCodeForm_KeyDown);
            base.Load += new EventHandler(this.ActivationCodeForm_Load);
            base.ResumeLayout(false);
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            this.ActivationCodeForm_KeyDown(sender, e);
        }
    }
}

