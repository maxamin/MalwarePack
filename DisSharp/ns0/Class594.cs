namespace ns0
{
    using System;
    using System.Text;

    internal class Class594 : Class593
    {
        private StringBuilder stringBuilder_0 = new StringBuilder(120);

        public override string ToString()
        {
            this.stringBuilder_0.Length = 0;
            for (int i = 0; i < base.int_0; i++)
            {
                if (i > 0)
                {
                    this.stringBuilder_0.Append(Class537.string_857);
                }
                this.stringBuilder_0.Append(base.struct10_0[(base.int_0 - 1) - i].string_0);
            }
            return this.stringBuilder_0.ToString();
        }
    }
}

