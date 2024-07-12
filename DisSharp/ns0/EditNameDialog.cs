namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class EditNameDialog : Form0
    {
        private Button button_0;
        private Button cancel;
        private Class369 class369_0;
        private Container container_0;
        private Label label1;
        private TextBox textBox;

        internal EditNameDialog(Class369 A_1)
        {
            this.InitializeComponent();
            this.class369_0 = A_1;
            this.textBox.Text = A_1.Name;
            if (A_1.class369_0 != null)
            {
                this.label1.Text = "Parent: " + A_1.class369_0.Name;
            }
            else
            {
                this.label1.Text = "";
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            bool flag;
            if (this.class369_0.QQQS == Enum10.const_0)
            {
                flag = true;
            }
            else if (this.class369_0.QQQS == Enum10.const_1)
            {
                flag = Class805.smethod_1(this.textBox.Text);
            }
            else
            {
                flag = Class805.smethod_0(this.textBox.Text);
            }
            if (flag)
            {
                this.class369_0.Name = this.textBox.Text;
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
            else
            {
                Class805.smethod_2(this.textBox.Text);
                this.cancel.PerformClick();
            }
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
            this.label1 = new Label();
            this.textBox = new TextBox();
            this.button_0 = new Button();
            this.cancel = new Button();
            base.SuspendLayout();
            this.label1.FlatStyle = FlatStyle.System;
            this.label1.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label1.Location = new Point(0x10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x148, 0x18);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.textBox.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.textBox.Location = new Point(0x10, 0x2b);
            this.textBox.Name = "textBox";
            this.textBox.Size = new Size(320, 0x18);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "textBox1";
            this.textBox.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.FlatStyle = FlatStyle.System;
            this.button_0.Location = new Point(40, 0x58);
            this.button_0.Name = "ok";
            this.button_0.Size = new Size(0x70, 0x20);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "OK";
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.cancel.DialogResult = DialogResult.Cancel;
            this.cancel.FlatStyle = FlatStyle.System;
            this.cancel.Location = new Point(200, 0x58);
            this.cancel.Name = "cancel";
            this.cancel.Size = new Size(0x70, 0x20);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new EventHandler(this.cancel_Click);
            this.AutoScaleBaseSize = new Size(7, 0x11);
            base.ClientSize = new Size(0x162, 0x90);
            base.Controls.Add(this.cancel);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.textBox);
            base.Controls.Add(this.label1);
            this.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "EditNameDialog";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edit name";
            base.ResumeLayout(false);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
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
    }
}

