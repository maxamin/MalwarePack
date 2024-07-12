namespace ns0
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class ListForm : Form0
    {
        private Button button_0;
        private Container container_0;
        internal System.Windows.Forms.ListBox ListBox;

        internal ListForm()
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
            this.button_0 = new Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            base.SuspendLayout();
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.FlatStyle = FlatStyle.System;
            this.button_0.Location = new Point(80, 0x88);
            this.button_0.Name = "Ok";
            this.button_0.Size = new Size(0x60, 0x20);
            this.button_0.TabIndex = 3;
            this.button_0.Text = "Ok";
            this.ListBox.ItemHeight = 0x10;
            this.ListBox.Location = new Point(0x18, 0x10);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new Size(0xd0, 100);
            this.ListBox.TabIndex = 4;
            this.AutoScaleBaseSize = new Size(6, 0x10);
            base.ClientSize = new Size(0x100, 0xb8);
            base.Controls.Add(this.ListBox);
            base.Controls.Add(this.button_0);
            this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ListForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Title";
            base.ResumeLayout(false);
        }

        internal void method_0(ArrayList A_1, string A_2)
        {
            this.Text = A_2;
            this.ListBox.Items.Clear();
            for (int i = 0; i < A_1.Count; i++)
            {
                this.ListBox.Items.Add((string) A_1[i]);
            }
            this.ListBox.SelectedIndex = 0;
        }
    }
}

