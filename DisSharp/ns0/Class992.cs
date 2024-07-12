namespace ns0
{
    using DisSharp;
    using System;
    using System.Windows.Forms;

    internal class Class992
    {
        internal static void smethod_0()
        {
            OptionsObject obj2 = new OptionsObject();
            Class516.smethod_1(obj2);
            Class863.smethod_3(obj2);
            Class993.optionsForm_0.PropertyGrid.SelectedObject = obj2;
            if (Class993.optionsForm_0.ShowDialog() == DialogResult.OK)
            {
                Class516.smethod_3(obj2);
                Class863.smethod_5(obj2);
                Class516.smethod_4();
                Class705.smethod_1();
                Class645.class704_0.method_16();
                if (Class993.optionsForm_0.bool_0)
                {
                    Class698.class582_0.class701_0.method_1();
                }
            }
        }
    }
}

