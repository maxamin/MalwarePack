namespace ns0
{
    using System;

    internal class Class963
    {
        internal int int_0;
        internal string string_0;
        internal string string_1;

        internal Class963(string A_1, int A_2)
        {
            this.string_0 = A_1;
            this.int_0 = A_2;
            this.method_0();
        }

        private void method_0()
        {
            int num = this.string_0.LastIndexOf('.');
            if (num == -1)
            {
                this.string_1 = "";
            }
            else
            {
                this.string_1 = this.string_0.Substring(num + 1);
            }
        }
    }
}

