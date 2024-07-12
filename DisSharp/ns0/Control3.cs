namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Control3 : Control2
    {
        private Class1089 class1089_0;
        private static Control3 control3_0 = new Control3();
        private Control4 control4_0;
        private Label label_0;

        private Control3()
        {
            this.Dock = DockStyle.Fill;
            base.method_0();
            this.control4_0 = new Control4();
            this.label_0 = new Label();
            this.label_0.AutoSize = true;
            this.label_0.Visible = false;
            this.class1089_0 = new Class1089();
            this.class1089_0.Text = Class537.string_150;
            this.class1089_0.Boolean_0 = false;
            this.class1089_0.Cursor = Cursors.Hand;
            this.class1089_0.Visible = false;
            this.class1089_0.Click += new EventHandler(this.class1089_0_Click);
            base.Controls.Add(this.control4_0);
            base.Controls.Add(this.label_0);
            base.Controls.Add(this.class1089_0);
            this.method_2();
        }

        private void class1089_0_Click(object sender, EventArgs e)
        {
            Class950.smethod_0(0x30);
        }

        internal void method_1()
        {
            this.method_2();
            base.Invalidate();
        }

        private void method_2()
        {
            if (Class521.Boolean_0)
            {
                this.label_0.Text = Class537.string_108;
                this.label_0.Visible = true;
                this.class1089_0.Visible = true;
            }
            else
            {
                this.label_0.Visible = false;
                this.class1089_0.Visible = false;
            }
            this.OnResize(new EventArgs());
        }

        protected override void OnResize(EventArgs eventargs)
        {
            int num;
            int a = base.Width - this.control4_0.Width;
            if (a <= 0)
            {
                this.control4_0.Left = 0;
            }
            else
            {
                this.control4_0.Left = Math.DivRem(a, 2, out num);
            }
            int num3 = base.Height - this.control4_0.Height;
            if (num3 <= 0)
            {
                this.control4_0.Top = 0;
            }
            else
            {
                this.control4_0.Top = Math.DivRem(num3, 2, out num);
            }
            a = this.control4_0.Width - this.label_0.Width;
            this.label_0.Left = this.control4_0.Left + Math.DivRem(a, 2, out num);
            this.label_0.Top = this.control4_0.Bottom + 10;
            a = this.control4_0.Width - this.class1089_0.Width;
            this.class1089_0.Left = this.control4_0.Left + Math.DivRem(a, 2, out num);
            this.class1089_0.Top = this.label_0.Bottom + 10;
            base.OnResize(eventargs);
        }

        internal static Control3 Control3_0
        {
            get
            {
                return control3_0;
            }
        }
    }
}

