    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    
namespace ns0
{


    internal class ProgressForm1 : Form0
    {
        internal bool bool_0;
        private Container container_0;
        private Label label;
        private ProgressBar progress;
        private Button StopButton;

        internal ProgressForm1(string A_1) : this(A_1, false)
        {
        }

        internal ProgressForm1(string A_1, bool A_2)
        {
            this.InitializeComponent();
            this.Text = A_1;
            this.StopButton.Enabled = A_2;
            base.ControlBox = false;
            Rectangle bounds = Class698.class582_0.mainForm_0.Bounds;
            int num = (bounds.Width - base.Width) / 2;
            int num2 = (bounds.Height - base.Height) / 2;
            base.Left = bounds.Left + num;
            base.Top = bounds.Top + num2;
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
            System.ComponentModel.ComponentResourceManager manager = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.progress = new ProgressBar();
            this.StopButton = new Button();
            this.label = new Label();
            base.SuspendLayout();
            this.progress.Location = new Point(0x10, 0x48);
            this.progress.Maximum = 1;
            this.progress.Name = "progress";
            this.progress.Size = new Size(0xe0, 0x17);
            this.progress.TabIndex = 2;
            this.StopButton.FlatStyle = FlatStyle.System;
            this.StopButton.Location = new Point(80, 120);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new Size(0x60, 0x20);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.Click += new EventHandler(this.StopButton_Click);
            this.label.FlatStyle = FlatStyle.System;
            this.label.Location = new Point(0x10, 0x18);
            this.label.Name = "label";
            this.label.Size = new Size(0xe0, 0x20);
            this.label.TabIndex = 4;
            this.label.Text = "label1";
            this.label.TextAlign = ContentAlignment.MiddleCenter;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x100, 0xae);
            base.ControlBox = false;
            base.Controls.Add(this.label);
            base.Controls.Add(this.StopButton);
            base.Controls.Add(this.progress);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Location = new Point(0, 0);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ProgressForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Title";
            base.ResumeLayout(false);
        }

        internal void method_0(int A_1, int A_2)
        {
            this.progress.Maximum = A_2;
            this.method_1(A_1);
        }

        internal void method_1(int A_1)
        {
            this.progress.Value = A_1;
            this.label.Text = A_1.ToString() + " from " + this.progress.Maximum.ToString();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }
    }
}

