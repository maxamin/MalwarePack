namespace ns0
{
    using System;

    internal class Class711 : Class706
    {
        private bool bool_3;

        protected override void QQSZ(object obj)
        {
            this.bool_3 = !this.bool_3;
            base.BinarySwitch(this.bool_3);
            if (this.bool_3)
            {
                Class698.class582_0.mainForm_0.panelLeft.Visible = true;
                Class698.class582_0.mainForm_0.splitter.Visible = true;
            }
            else
            {
                Class698.class582_0.mainForm_0.panelLeft.Visible = false;
                Class698.class582_0.mainForm_0.splitter.Visible = false;
            }
        }

        internal override void QQTR()
        {
            this.bool_3 = true;
            base.BinarySwitch(this.bool_3);
        }
    }
}

