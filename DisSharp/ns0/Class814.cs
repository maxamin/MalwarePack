namespace ns0
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    internal class Class814
    {
        private Class810 class810_0;
        private Class815 class815_0;
        private Class816 class816_0;
        private Class817 class817_0;
        private Class818 class818_0;
        private Control0 control0_0;
        private Graphics graphics_0;

        internal Class814(Control0 A_1)
        {
            this.control0_0 = A_1;
        }

        internal void method_0()
        {
            this.class810_0 = this.control0_0.class810_0;
            this.class816_0 = this.control0_0.class816_0;
            this.class815_0 = this.control0_0.class815_0;
            this.class818_0 = this.control0_0.class818_0;
            this.class817_0 = this.control0_0.class817_0;
        }

        internal void method_1(PaintEventArgs A_1)
        {
            this.graphics_0 = A_1.Graphics;
            this.graphics_0.SmoothingMode = SmoothingMode.HighSpeed;
            this.graphics_0.PageUnit = GraphicsUnit.Pixel;
            this.class816_0.method_1(this.graphics_0);
            this.method_2();
            this.method_3();
            this.method_4();
            this.method_5();
        }

        private void method_2()
        {
            ControlPaint.DrawBorder3D(this.graphics_0, this.class815_0.rectangle_0, Border3DStyle.Sunken);
        }

        private void method_3()
        {
            using (Brush brush = new SolidBrush(Class863.smethod_1(2)))
            {
                this.graphics_0.FillRectangle(brush, this.class815_0.rectangle_2);
            }
            if (this.class815_0.bool_0)
            {
                using (Brush brush2 = new SolidBrush(SystemColors.Control))
                {
                    this.graphics_0.FillRectangle(brush2, this.class815_0.rectangle_3);
                }
            }
        }

        private void method_4()
        {
            if (this.class817_0.bool_0)
            {
                using (Brush brush = new SolidBrush(Class863.smethod_1(9)))
                {
                    for (int i = 0; i < this.class818_0.int_4; i++)
                    {
                        Struct22 struct2 = this.class817_0.struct22_0[i];
                        if (struct2.bool_0)
                        {
                            this.graphics_0.FillRectangle(brush, this.class815_0.rectangle_7[i]);
                        }
                    }
                }
            }
        }

        private void method_5()
        {
            int y = this.class815_0.rectangle_2.Y;
            for (int i = 0; i < this.class818_0.int_4; i++)
            {
                Class1091 class2 = this.class818_0.method_1(i);
                for (int j = 0; j < class2.int_0; j++)
                {
                    Class1039 class3 = class2[j];
                    using (Brush brush = new SolidBrush(Class863.smethod_1(class3.int_2)))
                    {
                        this.graphics_0.DrawString(class3.string_0, this.control0_0.Font, brush, new RectangleF((float) (class3.int_0 + 5), (float) y, (class3.string_0.Length * this.class815_0.float_0) + 0.5f, (float) this.class815_0.int_0), StringFormat.GenericTypographic);
                    }
                }
                y += this.class815_0.int_0;
            }
        }
    }
}

