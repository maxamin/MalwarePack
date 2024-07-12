namespace ns0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class Class862 : RichTextBox
    {
        internal Class862()
        {
            base.MouseUp += new MouseEventHandler(this.Class862_MouseUp);
            base.SelectionChanged += new EventHandler(this.Class862_SelectionChanged);
        }

        private void Class862_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Control control = sender as Control;
                Point point = new Point(e.X, e.Y);
                Class698.class582_0.class1017_0.method_8(this.method_0(point));
                Class698.class582_0.class1017_0.contextMenuStrip_1.Show(control.PointToScreen(point));
            }
        }

        private void Class862_SelectionChanged(object sender, EventArgs e)
        {
            Class705.smethod_1();
        }

        private bool method_0(Point A_1)
        {
            if (this.SelectionLength <= 0)
            {
                return false;
            }
            int charIndexFromPosition = this.GetCharIndexFromPosition(A_1);
            return ((charIndexFromPosition >= base.SelectionStart) && (charIndexFromPosition < (base.SelectionStart + this.SelectionLength)));
        }
    }
}

