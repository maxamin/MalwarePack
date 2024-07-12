namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class AttributeForm : Form0
    {
        private Button button_0;
        private Button cancel;
        private Class369 class369_0;
        private Container container_0;
        private Label label1;
        private Label label2;
        private Label label3;
        internal System.Windows.Forms.TextBox TextBox;

        internal AttributeForm(Enum53 A_1)
        {
            this.InitializeComponent();
            this.TextBox.Text = "";
            switch (A_1)
            {
                case Enum53.const_8:
                    this.Text = "Type Attribute";
                    return;

                case Enum53.const_9:
                    this.Text = "Method Attribute";
                    return;

                case Enum53.const_10:
                    this.Text = "Field Attribute";
                    return;

                case Enum53.const_11:
                    this.Text = "Property Attribute";
                    return;

                case Enum53.const_12:
                    this.Text = "Indexer Attribute";
                    return;

                case Enum53.const_13:
                    this.Text = "Event Attribute";
                    return;
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
            this.label1 = new Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.button_0 = new Button();
            this.cancel = new Button();
            this.label2 = new Label();
            this.label3 = new Label();
            base.SuspendLayout();
            this.label1.FlatStyle = FlatStyle.System;
            this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label1.Location = new Point(0x10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x148, 0x10);
            this.label1.TabIndex = 3;
            this.label1.Text = "- may be short name";
            this.TextBox.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.TextBox.Location = new Point(0x10, 0x48);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new Size(320, 0x18);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "textBox1";
            this.TextBox.KeyDown += new KeyEventHandler(this.TextBox_KeyDown);
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.FlatStyle = FlatStyle.System;
            this.button_0.Location = new Point(40, 0x70);
            this.button_0.Name = "ok";
            this.button_0.Size = new Size(0x70, 0x20);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "OK";
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.cancel.DialogResult = DialogResult.Cancel;
            this.cancel.FlatStyle = FlatStyle.System;
            this.cancel.Location = new Point(200, 0x70);
            this.cancel.Name = "cancel";
            this.cancel.Size = new Size(0x70, 0x20);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new EventHandler(this.cancel_Click);
            this.label2.FlatStyle = FlatStyle.System;
            this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label2.Location = new Point(0x10, 0x18);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x148, 0x10);
            this.label2.TabIndex = 4;
            this.label2.Text = "- may be without \"Attribute\" suffix";
            this.label3.FlatStyle = FlatStyle.System;
            this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label3.Location = new Point(0x10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x148, 0x10);
            this.label3.TabIndex = 5;
            this.label3.Text = "- case sensitive";
            this.AutoScaleBaseSize = new Size(7, 0x11);
            base.ClientSize = new Size(0x162, 160);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.cancel);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.TextBox);
            base.Controls.Add(this.label1);
            this.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "AttributeForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Attribute";
            base.ResumeLayout(false);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
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

