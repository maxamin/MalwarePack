namespace ns0
{
    using System;

    internal abstract class Class335
    {
        protected Class335()
        {
        }

        internal void method_0(Class394 A_1, string A_2)
        {
            if (this.QQVY(A_2))
            {
                this.QQVX(A_2);
                A_1.class803_0.bool_0 = true;
            }
            else
            {
                Class805.smethod_2(A_2);
            }
        }

        protected virtual void QQVX(string string_0)
        {
        }

        protected virtual bool QQVY(string string_0)
        {
            return Class805.smethod_0(string_0);
        }

        public override string ToString()
        {
            return "";
        }

        internal abstract int Length { get; }

        internal virtual int QQSX
        {
            get
            {
                return 3;
            }
        }

        internal virtual bool QQVW
        {
            get
            {
                return false;
            }
        }
    }
}

