namespace ns0
{
    using Crownwood.DotNetMagic.Controls;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class MainForm : Form0
    {
        private IContainer icontainer_0;
        internal ImageList imageList_0;
        internal MenuStrip menu;
        internal Panel panelLeft;
        internal Panel panelRight;
        internal Splitter splitter;
        internal StatusBarControl statusBar;
        internal ToolStrip toolBar;
        internal ToolStripContainer toolStripContainer;

        internal MainForm()
        {
            this.InitializeComponent();
            this.menu.ImageList = this.imageList_0;
            this.toolBar.ImageList = this.imageList_0;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.icontainer_0 = new Container();
            this.imageList_0 = new ImageList(this.icontainer_0);
            this.statusBar = new StatusBarControl();
            this.toolStripContainer = new ToolStripContainer();
            this.panelRight = new Panel();
            this.splitter = new Splitter();
            this.panelLeft = new Panel();
            this.menu = new MenuStrip();
            this.toolBar = new ToolStrip();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            base.SuspendLayout();
            this.imageList_0.ColorDepth = ColorDepth.Depth8Bit;
            this.imageList_0.ImageSize = new Size(0x10, 0x10);
            this.imageList_0.TransparentColor = Color.White;
            this.statusBar.Location = new Point(0, 0x1f1);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new Size(0x2e6, 0x13);
            this.statusBar.TabIndex = 0;
            this.toolStripContainer.ContentPanel.Controls.Add(this.panelRight);
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitter);
            this.toolStripContainer.ContentPanel.Controls.Add(this.panelLeft);
            this.toolStripContainer.ContentPanel.Size = new Size(0x2e6, 0x1c0);
            this.toolStripContainer.Dock = DockStyle.Fill;
            this.toolStripContainer.Location = new Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new Size(0x2e6, 0x1f1);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menu);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolBar);
            this.panelRight.Dock = DockStyle.Fill;
            this.panelRight.Location = new Point(0xd0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new Size(0x216, 0x1c0);
            this.panelRight.TabIndex = 2;
            this.splitter.Location = new Point(0xcd, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new Size(3, 0x1c0);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            this.panelLeft.Dock = DockStyle.Left;
            this.panelLeft.Location = new Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new Size(0xcd, 0x1c0);
            this.panelLeft.TabIndex = 0;
            this.menu.Dock = DockStyle.None;
            this.menu.Location = new Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new Size(0x2e6, 0x18);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.toolBar.Dock = DockStyle.None;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            this.toolBar.Location = new Point(3, 0x18);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new Size(0x22, 0x19);
            this.toolBar.TabIndex = 1;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x2e6, 0x204);
            base.Controls.Add(this.toolStripContainer);
            base.Controls.Add(this.statusBar);
            base.MainMenuStrip = this.menu;
            base.Name = "MainForm";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dis#";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

