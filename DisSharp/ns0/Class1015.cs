namespace ns0
{
    using System;
    using System.ComponentModel;

    internal class Class1015
    {
        private Class582 class582_0;
        private Class921 class921_0;

        internal void method_0(Class582 A_1)
        {
            this.class582_0 = A_1;
            MainForm form = A_1.mainForm_0;
            form.Load += new EventHandler(this.method_1);
            form.Closed += new EventHandler(this.method_2);
            form.Closing += new CancelEventHandler(this.method_3);
        }

        private void method_1(object sender, EventArgs e)
        {
            Class1040.smethod_1();
            Class950.smethod_0(5);
            Class516.smethod_4();
            this.class582_0.class701_0.method_4();
            this.class582_0.class921_0.method_0();
        }

        private void method_2(object sender, EventArgs e)
        {
            Class1040.smethod_0();
            this.class582_0.class984_0.method_1();
            this.class582_0.class1016_0.method_2();
        }

        private void method_3(object sender, CancelEventArgs e)
        {
            e.Cancel = Class645.smethod_10();
        }
    }
}

