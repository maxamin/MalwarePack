namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class SearchForm : Form0
    {
        internal RadioButton Backward;
        private Button buttonCancel;
        private Button buttonOk;
        internal CheckBox CaseSensitive;
        private Container container_0;
        internal GroupBox Direction;
        internal RadioButton EntireScope;
        internal RadioButton Forward;
        internal RadioButton FromCursor;
        internal RadioButton Global;
        private Label label1;
        internal GroupBox Options;
        internal GroupBox Origin;
        internal GroupBox Scope;
        internal RadioButton SelectedText;
        internal ComboBox TextToFind;
        internal CheckBox WholeWordsOnly;

        internal SearchForm()
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
            this.TextToFind = new ComboBox();
            this.Options = new GroupBox();
            this.WholeWordsOnly = new CheckBox();
            this.CaseSensitive = new CheckBox();
            this.Scope = new GroupBox();
            this.SelectedText = new RadioButton();
            this.Global = new RadioButton();
            this.Direction = new GroupBox();
            this.Backward = new RadioButton();
            this.Forward = new RadioButton();
            this.Origin = new GroupBox();
            this.EntireScope = new RadioButton();
            this.FromCursor = new RadioButton();
            this.buttonOk = new Button();
            this.buttonCancel = new Button();
            this.Options.SuspendLayout();
            this.Scope.SuspendLayout();
            this.Direction.SuspendLayout();
            this.Origin.SuspendLayout();
            base.SuspendLayout();
            this.label1.FlatStyle = FlatStyle.System;
            this.label1.Location = new Point(15, 0x13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x40, 0x10);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Text to find:";
            this.TextToFind.Location = new Point(0x58, 0x10);
            this.TextToFind.Name = "TextToFind";
            this.TextToFind.Size = new Size(240, 0x15);
            this.TextToFind.TabIndex = 1;
            this.TextToFind.KeyDown += new KeyEventHandler(this.TextToFind_KeyDown);
            this.Options.Controls.Add(this.WholeWordsOnly);
            this.Options.Controls.Add(this.CaseSensitive);
            this.Options.FlatStyle = FlatStyle.System;
            this.Options.Location = new Point(0x10, 0x38);
            this.Options.Name = "Options";
            this.Options.Size = new Size(0x98, 0x48);
            this.Options.TabIndex = 2;
            this.Options.TabStop = false;
            this.Options.Text = " Options ";
            this.WholeWordsOnly.Checked = true;
            this.WholeWordsOnly.CheckState = CheckState.Checked;
            this.WholeWordsOnly.FlatStyle = FlatStyle.System;
            this.WholeWordsOnly.Location = new Point(8, 40);
            this.WholeWordsOnly.Name = "WholeWordsOnly";
            this.WholeWordsOnly.Size = new Size(0x88, 0x18);
            this.WholeWordsOnly.TabIndex = 1;
            this.WholeWordsOnly.Text = "&Whole words only";
            this.CaseSensitive.Checked = true;
            this.CaseSensitive.CheckState = CheckState.Checked;
            this.CaseSensitive.FlatStyle = FlatStyle.System;
            this.CaseSensitive.Location = new Point(8, 0x10);
            this.CaseSensitive.Name = "CaseSensitive";
            this.CaseSensitive.Size = new Size(0x80, 0x18);
            this.CaseSensitive.TabIndex = 0;
            this.CaseSensitive.Text = "&Case sensitive";
            this.Scope.Controls.Add(this.SelectedText);
            this.Scope.Controls.Add(this.Global);
            this.Scope.FlatStyle = FlatStyle.System;
            this.Scope.Location = new Point(0x10, 0x88);
            this.Scope.Name = "Scope";
            this.Scope.Size = new Size(0x98, 0x48);
            this.Scope.TabIndex = 3;
            this.Scope.TabStop = false;
            this.Scope.Text = " Scope ";
            this.SelectedText.FlatStyle = FlatStyle.System;
            this.SelectedText.Location = new Point(8, 40);
            this.SelectedText.Name = "SelectedText";
            this.SelectedText.Size = new Size(0x88, 0x18);
            this.SelectedText.TabIndex = 1;
            this.SelectedText.Text = "&Selected text";
            this.Global.Checked = true;
            this.Global.FlatStyle = FlatStyle.System;
            this.Global.Location = new Point(8, 0x10);
            this.Global.Name = "Global";
            this.Global.Size = new Size(0x88, 0x18);
            this.Global.TabIndex = 0;
            this.Global.TabStop = true;
            this.Global.Text = "&Global";
            this.Direction.Controls.Add(this.Backward);
            this.Direction.Controls.Add(this.Forward);
            this.Direction.FlatStyle = FlatStyle.System;
            this.Direction.Location = new Point(0xb0, 0x38);
            this.Direction.Name = "Direction";
            this.Direction.Size = new Size(0x98, 0x48);
            this.Direction.TabIndex = 4;
            this.Direction.TabStop = false;
            this.Direction.Text = " Direction ";
            this.Backward.FlatStyle = FlatStyle.System;
            this.Backward.Location = new Point(8, 40);
            this.Backward.Name = "Backward";
            this.Backward.Size = new Size(0x88, 0x18);
            this.Backward.TabIndex = 1;
            this.Backward.Text = "&Backward";
            this.Forward.Checked = true;
            this.Forward.FlatStyle = FlatStyle.System;
            this.Forward.Location = new Point(8, 0x10);
            this.Forward.Name = "Forward";
            this.Forward.Size = new Size(0x88, 0x18);
            this.Forward.TabIndex = 0;
            this.Forward.TabStop = true;
            this.Forward.Text = "Forwar&d";
            this.Origin.Controls.Add(this.EntireScope);
            this.Origin.Controls.Add(this.FromCursor);
            this.Origin.FlatStyle = FlatStyle.System;
            this.Origin.Location = new Point(0xb0, 0x88);
            this.Origin.Name = "Origin";
            this.Origin.Size = new Size(0x98, 0x48);
            this.Origin.TabIndex = 5;
            this.Origin.TabStop = false;
            this.Origin.Text = " Origin ";
            this.EntireScope.Checked = true;
            this.EntireScope.FlatStyle = FlatStyle.System;
            this.EntireScope.Location = new Point(8, 40);
            this.EntireScope.Name = "EntireScope";
            this.EntireScope.Size = new Size(0x88, 0x18);
            this.EntireScope.TabIndex = 1;
            this.EntireScope.TabStop = true;
            this.EntireScope.Text = "&Entire scope";
            this.FromCursor.FlatStyle = FlatStyle.System;
            this.FromCursor.Location = new Point(8, 0x10);
            this.FromCursor.Name = "FromCursor";
            this.FromCursor.Size = new Size(0x88, 0x18);
            this.FromCursor.TabIndex = 0;
            this.FromCursor.Text = "&From cursor";
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.FlatStyle = FlatStyle.System;
            this.buttonOk.Location = new Point(0x30, 0xe0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(0x58, 0x20);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.FlatStyle = FlatStyle.System;
            this.buttonCancel.Location = new Point(0xd0, 0xe0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x58, 0x20);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x15a, 0x110);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOk);
            base.Controls.Add(this.Origin);
            base.Controls.Add(this.Direction);
            base.Controls.Add(this.Scope);
            base.Controls.Add(this.Options);
            base.Controls.Add(this.TextToFind);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SearchForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Find Text";
            base.KeyDown += new KeyEventHandler(this.SearchForm_KeyDown);
            this.Options.ResumeLayout(false);
            this.Scope.ResumeLayout(false);
            this.Direction.ResumeLayout(false);
            this.Origin.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void SearchForm_KeyDown(object sender, KeyEventArgs e)
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

        private void TextToFind_KeyDown(object sender, KeyEventArgs e)
        {
            this.SearchForm_KeyDown(sender, e);
        }
    }
}

