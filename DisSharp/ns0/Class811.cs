namespace ns0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class Class811
    {
        internal bool bool_0;
        private Class1039 class1039_0;
        private Class394 class394_0;
        private Class810 class810_0;
        private Class815 class815_0;
        private Class818 class818_0;
        private Class999 class999_0;
        private Control0 control0_0;
        private Enum43 enum43_0;
        private Timer timer_0;

        internal Class811(Class394 A_1, Control0 A_2, Enum43 A_3)
        {
            this.class394_0 = A_1;
            this.control0_0 = A_2;
            this.enum43_0 = A_3;
            this.class999_0 = new Class999();
            this.class999_0.Size = new Size(1, 1);
            this.class999_0.Visible = false;
            this.class999_0.BorderStyle = BorderStyle.Fixed3D;
            A_2.Controls.Add(this.class999_0);
            this.class999_0.LostFocus += new EventHandler(this.class999_0_LostFocus);
            this.class999_0.Event_0 += new Delegate0(this.method_3);
            this.class999_0.Event_1 += new Delegate0(this.method_4);
            this.timer_0 = new Timer();
            this.timer_0.Enabled = false;
            this.timer_0.Interval = 10;
            this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
        }

        private void class999_0_LostFocus(object sender, EventArgs e)
        {
            this.method_6();
        }

        internal void method_0()
        {
            this.class818_0 = this.control0_0.class818_0;
            this.class810_0 = this.control0_0.class810_0;
            this.class815_0 = this.control0_0.class815_0;
        }

        internal void method_1(Font A_1)
        {
            this.class999_0.Font = A_1;
        }

        internal void method_2()
        {
            if (this.enum43_0 != Enum43.const_1)
            {
                this.class1039_0 = this.class818_0.method_12();
                if (this.class1039_0.class335_0.QQVW)
                {
                    int num = Math.Max(this.class1039_0.int_1, this.class818_0.int_1);
                    int num2 = Math.Min(Math.Max(this.class1039_0.class335_0.Length + 2, Class516.int_9), (this.class818_0.int_1 + this.class818_0.int_3) - num);
                    if (num2 >= Class516.int_9)
                    {
                        this.class999_0.Text = this.class1039_0.string_0;
                        this.class999_0.Left = (int) Math.Floor((double) ((num - this.class818_0.int_1) * this.class815_0.float_0));
                        this.class999_0.Top = (this.class818_0.int_8 - this.class818_0.int_2) * this.class815_0.int_0;
                        this.class999_0.Width = (int) Math.Ceiling((double) (num2 * this.class815_0.float_0));
                        this.class999_0.Height = this.class815_0.int_0;
                        this.class810_0.method_3();
                        this.timer_0.Start();
                    }
                }
            }
        }

        private void method_3(object A_1, Keys A_2)
        {
            this.method_5();
        }

        private void method_4(object A_1, Keys A_2)
        {
            this.method_6();
        }

        private void method_5()
        {
            this.class1039_0.class335_0.method_0(this.class394_0, this.class999_0.Text);
            this.class818_0.method_2();
            this.method_7();
        }

        private void method_6()
        {
            this.method_7();
        }

        private void method_7()
        {
            this.bool_0 = false;
            this.class999_0.Visible = false;
            this.class810_0.method_1();
            this.control0_0.method_5();
            this.control0_0.bool_0 = true;
            this.control0_0.Focus();
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.timer_0.Stop();
            this.bool_0 = true;
            this.class999_0.Visible = true;
            this.class999_0.Focus();
        }
    }
}

