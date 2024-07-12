namespace ns0
{
    using System;
    using System.Drawing;

    internal class Class816
    {
        private bool bool_0 = true;
        private Class815 class815_0;
        private Class817 class817_0;
        private Class818 class818_0;
        private Control0 control0_0;
        internal Enum44 enum44_0;

        internal Class816(Control0 A_1)
        {
            this.control0_0 = A_1;
        }

        internal void method_0()
        {
            this.class815_0 = this.control0_0.class815_0;
            this.class818_0 = this.control0_0.class818_0;
            this.class817_0 = this.control0_0.class817_0;
        }

        internal void method_1(Graphics A_1)
        {
            if ((this.enum44_0 == Enum44.const_0) || this.bool_0)
            {
                this.method_2(A_1);
                this.method_3(A_1);
                this.bool_0 = false;
            }
            this.enum44_0 = Enum44.const_1;
        }

        internal void method_2(Graphics A_1)
        {
            this.class815_0.float_0 = A_1.MeasureString("W", this.control0_0.Font, 0x7fffffff, StringFormat.GenericTypographic).Width;
            this.class815_0.int_0 = (int) this.control0_0.Font.GetHeight(A_1);
        }

        private void method_3(Graphics A_1)
        {
            this.class815_0.rectangle_0 = new Rectangle(this.control0_0.Left, this.control0_0.Top, this.control0_0.Width, this.control0_0.Height);
            this.class815_0.rectangle_1 = Rectangle.Inflate(this.class815_0.rectangle_0, -2, -2);
            int width = this.class815_0.rectangle_1.Width - 5;
            int height = this.class815_0.rectangle_1.Height;
            int num3 = (int) Math.Floor((double) (((double) width) / ((double) this.class815_0.float_0)));
            if (this.class818_0.int_5 > num3)
            {
                this.class815_0.hscrollBar_0.Visible = true;
                this.class815_0.hscrollBar_0.Value = this.class818_0.int_1;
                this.class815_0.hscrollBar_0.Left = this.class815_0.rectangle_1.Left;
                this.class815_0.hscrollBar_0.Top = this.class815_0.rectangle_1.Bottom - this.class815_0.hscrollBar_0.Height;
                this.class815_0.hscrollBar_0.Width = this.class815_0.rectangle_1.Width;
                height -= this.class815_0.hscrollBar_0.Height;
            }
            else
            {
                this.class815_0.hscrollBar_0.Visible = false;
            }
            num3 = (int) Math.Floor((double) (((double) height) / ((double) this.class815_0.int_0)));
            if (this.class818_0.int_6 > num3)
            {
                this.class815_0.vscrollBar_0.Visible = true;
                this.class815_0.vscrollBar_0.Value = this.class818_0.int_2;
                this.class815_0.vscrollBar_0.Left = this.class815_0.rectangle_1.Right - this.class815_0.vscrollBar_0.Width;
                this.class815_0.vscrollBar_0.Top = this.class815_0.rectangle_1.Top;
                this.class815_0.vscrollBar_0.Height = this.class815_0.rectangle_1.Height;
                width -= this.class815_0.vscrollBar_0.Width;
            }
            else
            {
                this.class815_0.vscrollBar_0.Visible = false;
            }
            if (this.class815_0.hscrollBar_0.Visible && this.class815_0.vscrollBar_0.Visible)
            {
                this.class815_0.bool_0 = true;
                this.class815_0.rectangle_3 = new Rectangle(this.class815_0.vscrollBar_0.Left, this.class815_0.hscrollBar_0.Top, this.class815_0.vscrollBar_0.Width, this.class815_0.hscrollBar_0.Height);
                this.class815_0.hscrollBar_0.Width -= this.class815_0.rectangle_3.Width;
                this.class815_0.vscrollBar_0.Height -= this.class815_0.rectangle_3.Height;
            }
            else
            {
                this.class815_0.bool_0 = false;
            }
            this.class815_0.rectangle_2 = new Rectangle(this.class815_0.rectangle_1.Left, this.class815_0.rectangle_1.Top, width + 5, height);
            this.class818_0.int_3 = (int) Math.Floor((double) (((float) width) / this.class815_0.float_0));
            this.class818_0.int_4 = (int) Math.Floor((double) (height / this.class815_0.int_0));
            this.class815_0.hscrollBar_0.Maximum = this.class818_0.Int32_0;
            this.class815_0.vscrollBar_0.Maximum = this.class818_0.Int32_1;
            this.class815_0.hscrollBar_0.LargeChange = this.class818_0.int_3 - 1;
            this.class815_0.vscrollBar_0.LargeChange = this.class818_0.int_4 - 1;
            this.class815_0.hscrollBar_0.SmallChange = 1;
            this.class815_0.vscrollBar_0.SmallChange = 1;
            int num4 = (int) Math.Ceiling((double) (this.class818_0.int_3 * this.class815_0.float_0));
            int num5 = width - num4;
            if (num5 > 0)
            {
                this.class815_0.bool_1 = true;
                this.class815_0.rectangle_4 = new Rectangle((this.class815_0.rectangle_2.Right - num5) + 1, this.class815_0.rectangle_2.Top, num5, height);
            }
            else
            {
                this.class815_0.bool_1 = false;
            }
            int num6 = height - num4;
            if (num6 > 0)
            {
                this.class815_0.bool_2 = true;
                this.class815_0.rectangle_5 = new Rectangle(this.class815_0.rectangle_2.Left, (this.class815_0.rectangle_2.Top - num6) + 1, width, num6);
                if (this.class815_0.bool_1)
                {
                    this.class815_0.rectangle_5.Width -= this.class815_0.rectangle_4.Width;
                }
            }
            else
            {
                this.class815_0.bool_2 = false;
            }
            if (this.class815_0.rectangle_6.Length != this.class818_0.int_4)
            {
                this.class815_0.rectangle_6 = new Rectangle[this.class818_0.int_4];
            }
            int left = this.class815_0.rectangle_2.Left;
            int top = this.class815_0.rectangle_2.Top;
            for (int i = 0; i < this.class818_0.int_4; i++)
            {
                this.class815_0.rectangle_6[i] = new Rectangle(left, top + (i * this.class815_0.int_0), num4, this.class815_0.int_0);
            }
            this.class817_0.method_12();
            if (this.class817_0.bool_0)
            {
                if (this.class815_0.rectangle_7.Length != this.class818_0.int_4)
                {
                    this.class815_0.rectangle_7 = new Rectangle[this.class818_0.int_4];
                }
                for (int j = 0; j < this.class818_0.int_4; j++)
                {
                    Struct22 struct2 = this.class817_0.struct22_0[j];
                    if (struct2.bool_0)
                    {
                        int x = ((left + ((int) Math.Floor((double) ((struct2.int_0 - this.class818_0.int_1) * this.class815_0.float_0)))) + 5) - 2;
                        int num12 = (int) Math.Ceiling((double) (((struct2.int_1 - struct2.int_0) + 1) * this.class815_0.float_0));
                        this.class815_0.rectangle_7[j] = new Rectangle(x, top + (j * this.class815_0.int_0), num12, this.class815_0.int_0);
                    }
                    else
                    {
                        this.class815_0.rectangle_7[j] = Rectangle.Empty;
                    }
                }
            }
            this.class818_0.method_3();
        }
    }
}

