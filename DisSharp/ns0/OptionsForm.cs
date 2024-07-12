namespace ns0
{
    using DisSharp;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class OptionsForm : Form0
    {
        internal bool bool_0;
        private Button buttonCancel;
        private Button buttonClearRecent;
        private Button buttonDefault;
        private Button buttonOk;
        private Container container_0;
        protected internal System.Windows.Forms.PropertyGrid PropertyGrid;

        internal OptionsForm()
        {
            this.InitializeComponent();
        }

        private void buttonClearRecent_Click(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            OptionsObject selectedObject = this.PropertyGrid.SelectedObject as OptionsObject;
            if (selectedObject != null)
            {
                Class516.smethod_2(selectedObject);
                Class863.smethod_4(selectedObject);
                this.PropertyGrid.SelectedObject = selectedObject;
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
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.buttonDefault = new Button();
            this.buttonClearRecent = new Button();
            base.SuspendLayout();
            this.buttonOk.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.FlatStyle = FlatStyle.System;
            this.buttonOk.Location = new Point(0x138, 0x10);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(0x58, 0x20);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonCancel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.FlatStyle = FlatStyle.System;
            this.buttonCancel.Location = new Point(0x138, 0x48);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x58, 0x20);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.PropertyGrid.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.PropertyGrid.CommandsVisibleIfAvailable = true;
            this.PropertyGrid.LargeButtons = false;
            this.PropertyGrid.LineColor = SystemColors.ScrollBar;
            this.PropertyGrid.Location = new Point(0x10, 0x10);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new Size(0x110, 0x120);
            this.PropertyGrid.TabIndex = 8;
            this.PropertyGrid.Text = "propertyGrid";
            this.PropertyGrid.ToolbarVisible = false;
            this.PropertyGrid.ViewBackColor = SystemColors.Window;
            this.PropertyGrid.ViewForeColor = SystemColors.WindowText;
            this.buttonDefault.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonDefault.FlatStyle = FlatStyle.System;
            this.buttonDefault.Location = new Point(0x138, 0x90);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new Size(0x58, 0x20);
            this.buttonDefault.TabIndex = 9;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.Click += new EventHandler(this.buttonDefault_Click);
            this.buttonClearRecent.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonClearRecent.FlatStyle = FlatStyle.System;
            this.buttonClearRecent.Location = new Point(0x138, 200);
            this.buttonClearRecent.Name = "buttonClearRecent";
            this.buttonClearRecent.Size = new Size(0x58, 0x20);
            this.buttonClearRecent.TabIndex = 10;
            this.buttonClearRecent.Text = "Clear Recent";
            this.buttonClearRecent.Click += new EventHandler(this.buttonClearRecent_Click);
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x1a2, 320);
            base.Controls.Add(this.buttonClearRecent);
            base.Controls.Add(this.buttonDefault);
            base.Controls.Add(this.PropertyGrid);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOk);
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "OptionsForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Options";
            base.KeyDown += new KeyEventHandler(this.OptionsForm_KeyDown);
            base.Enter += new EventHandler(this.OptionsForm_Enter);
            base.ResumeLayout(false);
        }

        private void OptionsForm_Enter(object sender, EventArgs e)
        {
            this.bool_0 = false;
        }

        private void OptionsForm_KeyDown(object sender, KeyEventArgs e)
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

