namespace ns0
{
    using System;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    internal class Class802 : TreeView
    {
        private const byte byte_0 = 2;
        private const int int_0 = 0;
        private const int int_1 = 0x100;

		internal event Delegate0 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.delegate0_0 = (Delegate0)Delegate.Combine(this.delegate0_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.delegate0_0 = (Delegate0)Delegate.Remove(this.delegate0_0, value);
			}
		}

        internal Class802()
        {
            base.MouseUp += new MouseEventHandler(this.Class802_MouseUp);
        }

        private void Class802_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Control control = sender as Control;
                Point point = new Point(e.X, e.Y);
                Class698.class582_0.class1017_0.method_22(this.method_1(point));
                Class698.class582_0.class1017_0.contextMenuStrip_0.Show(control.PointToScreen(point));
            }
        }

        protected override void InitLayout()
        {
            base.InitLayout();
            ShowScrollBar(base.Handle, 0, false);
        }

        private void method_0()
        {
            Rectangle bounds = base.SelectedNode.Bounds;
            Point point = new Point(bounds.Left + 2, bounds.Top + 2);
            Class698.class582_0.class1017_0.method_22(this.method_1(point));
            Class698.class582_0.class1017_0.contextMenuStrip_0.Show(base.PointToScreen(point));
        }

        private bool method_1(Point A_1)
        {
            Class686.Class687 nodeAt = base.GetNodeAt(A_1) as Class686.Class687;
            if (nodeAt == null)
            {
                return false;
            }
            Class519.smethod_1(nodeAt.class369_0);
            return true;
        }
		private Delegate0 delegate0_0;

        public override bool PreProcessMessage(ref Message msg)
        {
            if (msg.Msg == 0x100)
            {
                if (((int) msg.WParam) == 13)
                {
                    this.delegate0_0(this, Keys.Enter);
                    return true;
                }
                if (((int) msg.WParam) == 0x5d)
                {
                    this.method_0();
                    return true;
                }
            }
            return base.PreProcessMessage(ref msg);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keys)
        {
            if (keys == (Keys.Shift | Keys.F10))
            {
                this.method_0();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keys);
        }

        [DllImport("User32.dll")]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
    }
}

