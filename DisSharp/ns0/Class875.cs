namespace ns0
{
    using System;

    internal class Class875 : Class872
    {
        private bool bool_0;

        internal Class875() : base(Enum51.const_4)
        {
            this.bool_0 = false;
        }

        internal override void QQSZ(DateTime expired)
        {
            try
            {
                Class967.smethod_0();
            }
            catch
            {
            }
            this.bool_0 = true;
        }

        internal override bool QQWQ
        {
            get
            {
                return this.bool_0;
            }
        }
    }
}

