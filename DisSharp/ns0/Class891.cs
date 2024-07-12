namespace ns0
{
    using Crownwood.DotNetMagic.Controls;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    internal class Class891
    {
        private int int_0;
        private int int_1;
        internal Crownwood.DotNetMagic.Controls.TabControl tabControl_0;
        private Timer timer_0;
        private Timer timer_1;

        internal void method_0(Class582 A_1)
        {
            this.tabControl_0 = new Crownwood.DotNetMagic.Controls.TabControl();
            this.tabControl_0.Appearance = VisualAppearance.MultiDocument;
            this.tabControl_0.HideTabsMode = HideTabsModes.HideUsingLogic;
            this.tabControl_0.ShowClose = true;
            this.tabControl_0.ShowArrows = true;
            this.tabControl_0.ShowDropSelect = true;
            this.tabControl_0.HotTrack = true;
            this.tabControl_0.Dock = DockStyle.Fill;
            this.tabControl_0.Location = new Point(0x113, 0x20);
            this.tabControl_0.Size = new Size(0x195, 0x13d);
            this.tabControl_0.ClosePressed += new EventHandler(this.tabControl_0_ClosePressed);
            this.tabControl_0.SelectionChanging += new SelectTabHandler(this.method_1);
            this.tabControl_0.SelectionChanged += new SelectTabHandler(this.method_2);
            this.tabControl_0.PageGotFocus += new EventHandler(this.tabControl_0_PageGotFocus);
            this.tabControl_0.PageLostFocus += new EventHandler(this.tabControl_0_PageLostFocus);
            this.tabControl_0.DoubleClickTab += new DoubleClickTabHandler(this.method_3);
            this.tabControl_0.MouseDown += new MouseEventHandler(this.tabControl_0_MouseDown);
            this.tabControl_0.ContextMenuStripDisplay += new CancelEventHandler(this.tabControl_0_ContextMenuStripDisplay);
            this.timer_0 = new Timer();
            this.timer_0.Enabled = false;
            this.timer_0.Interval = 10;
            this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
            this.timer_1 = new Timer();
            this.timer_1.Enabled = false;
            this.timer_1.Interval = 10;
            this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
        }

        private void method_1(Crownwood.DotNetMagic.Controls.TabControl A_1, Crownwood.DotNetMagic.Controls.TabPage A_2, Crownwood.DotNetMagic.Controls.TabPage A_3)
        {
        }

        private void method_2(Crownwood.DotNetMagic.Controls.TabControl A_1, Crownwood.DotNetMagic.Controls.TabPage A_2, Crownwood.DotNetMagic.Controls.TabPage A_3)
        {
            this.timer_0.Start();
        }

        private void method_3(Crownwood.DotNetMagic.Controls.TabControl A_1, Crownwood.DotNetMagic.Controls.TabPage A_2)
        {
        }

        private void tabControl_0_ClosePressed(object sender, EventArgs e)
        {
            Class645.class704_0.method_4(this.tabControl_0.SelectedIndex);
        }

        private void tabControl_0_ContextMenuStripDisplay(object sender, CancelEventArgs e)
        {
            e.Cancel = Class645.class704_0.Boolean_0;
        }

        private void tabControl_0_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tabControl_0_PageGotFocus(object sender, EventArgs e)
        {
        }

        private void tabControl_0_PageLostFocus(object sender, EventArgs e)
        {
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.timer_0.Stop();
            Class645.class704_0.method_17();
        }

        private void timer_1_Tick(object sender, EventArgs e)
        {
            this.timer_1.Stop();
        }
    }
}

