namespace ns0
{
    using System;
    using System.Text;

    internal class Class1001
    {
        private static Class397 class397_0 = new Class397();
        private string string_0 = Class537.string_857;
        private StringBuilder stringBuilder_0 = new StringBuilder(120);

        static Class1001()
        {
            class397_0.method_8();
        }

        internal void method_0(string A_1)
        {
            if (this.stringBuilder_0.Length > 0)
            {
                this.stringBuilder_0.Insert(0, this.string_0);
            }
            this.stringBuilder_0.Insert(0, A_1);
        }

        internal void method_1()
        {
            this.stringBuilder_0.Length = 0;
        }

        internal static string smethod_0(Enum11 A_0, int A_1, int A_2)
        {
            class397_0.Class367_1.method_5();
            Class968.smethod_0(class397_0, A_0, A_1, A_2);
            return class397_0.Class367_1.ToString();
        }

        public override string ToString()
        {
            return this.stringBuilder_0.ToString();
        }
    }
}

