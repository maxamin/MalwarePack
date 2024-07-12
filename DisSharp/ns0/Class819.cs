namespace ns0
{
    using System;

    internal class Class819
    {
        private const byte byte_0 = 10;
        private Class367 class367_0;
        private Class397 class397_0;
        private Class810 class810_0;
        private Class818 class818_0;
        private Control0 control0_0;
        private Enum72 enum72_0;
        private int int_0;
        private int int_1;

        internal Class819(Control0 A_1, Class397 A_2)
        {
            this.control0_0 = A_1;
            this.class397_0 = A_2;
        }

        internal void method_0()
        {
            this.class810_0 = this.control0_0.class810_0;
            this.class818_0 = this.control0_0.class818_0;
        }

        internal void method_1()
        {
            this.int_0 = this.class818_0.int_8;
            this.int_1 = this.class818_0.int_7;
            this.class367_0 = this.class397_0[this.int_0];
            if (!this.method_11())
            {
                while (!this.method_2())
                {
                    if (this.int_0 == 0)
                    {
                        return;
                    }
                    this.int_0--;
                    this.class367_0 = this.class397_0[this.int_0];
                    this.int_1 = this.class367_0.ToString().Length - 1;
                }
            }
            while (!this.method_3())
            {
                if (this.int_0 == 0)
                {
                    return;
                }
                this.int_0--;
                this.class367_0 = this.class397_0[this.int_0];
                this.int_1 = this.class367_0.ToString().Length - 1;
            }
            while (!this.method_4())
            {
                if (this.int_0 == 0)
                {
                    return;
                }
                this.int_0--;
                this.class367_0 = this.class397_0[this.int_0];
                this.int_1 = this.class367_0.ToString().Length - 1;
            }
            this.class818_0.int_7 = this.int_1;
            this.class818_0.int_8 = this.int_0;
            this.method_8();
            this.class810_0.method_4();
            this.control0_0.method_5();
        }

        private void method_10()
        {
            if (this.class818_0.int_7 < this.class818_0.int_1)
            {
                this.class818_0.int_1 = this.class818_0.int_7;
                if (this.class818_0.int_1 < this.class818_0.int_3)
                {
                    this.class818_0.int_1 = 0;
                }
            }
            else if (this.class818_0.int_7 >= (this.class818_0.int_1 + this.class818_0.int_3))
            {
                this.class818_0.int_1 = ((this.class818_0.int_7 - this.class818_0.int_3) + 1) + 10;
            }
        }

        private bool method_11()
        {
            int num = this.class367_0.ToString().Length - 1;
            if (this.int_1 > num)
            {
                this.int_1 = num;
                return true;
            }
            return false;
        }

        private Enum72 method_12(char A_1)
        {
            if (this.method_13(A_1))
            {
                return Enum72.const_0;
            }
            return Enum72.const_1;
        }

        public bool method_13(char A_1)
        {
            return (char.IsLetterOrDigit(A_1) || (A_1 == '_'));
        }

        private bool method_2()
        {
            if (this.int_1 >= 0)
            {
                string str = this.class367_0.ToString();
                for (int i = this.int_1; i >= 0; i--)
                {
                    this.int_1 = i;
                    if (this.method_12(str[this.int_1]) == Enum72.const_1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool method_3()
        {
            if (this.int_1 >= 0)
            {
                string str = this.class367_0.ToString();
                for (int i = this.int_1 - 1; i >= 0; i--)
                {
                    this.int_1 = i;
                    if (this.method_12(str[this.int_1]) == Enum72.const_0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool method_4()
        {
            if (this.int_1 < 0)
            {
                return false;
            }
            string str = this.class367_0.ToString();
            for (int i = this.int_1; i >= 0; i--)
            {
                this.int_1 = i;
                if (this.method_12(str[this.int_1]) != Enum72.const_0)
                {
                    this.int_1++;
                    return true;
                }
            }
            return true;
        }

        internal void method_5()
        {
            this.int_0 = this.class818_0.int_8;
            this.int_1 = this.class818_0.int_7;
            this.class367_0 = this.class397_0[this.int_0];
            this.method_11();
            while (!this.method_6())
            {
                if (this.int_0 == (this.class397_0.Int32_0 - 1))
                {
                    return;
                }
                this.int_0++;
                this.int_1 = 0;
                this.class367_0 = this.class397_0[this.int_0];
                this.method_11();
            }
            while (!this.method_7())
            {
                if (this.int_0 == (this.class397_0.Int32_0 - 1))
                {
                    return;
                }
                this.int_0++;
                this.int_1 = 0;
                this.class367_0 = this.class397_0[this.int_0];
                this.method_11();
            }
            this.class818_0.int_7 = this.int_1;
            this.class818_0.int_8 = this.int_0;
            this.method_9();
            this.class810_0.method_4();
            this.control0_0.method_5();
        }

        private bool method_6()
        {
            if (this.int_1 >= 0)
            {
                string str = this.class367_0.ToString();
                this.enum72_0 = this.method_12(str[this.int_1]);
                for (int i = this.int_1 + 1; i < str.Length; i++)
                {
                    this.int_1 = i;
                    if (this.method_12(str[this.int_1]) != this.enum72_0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool method_7()
        {
            if (this.int_1 >= 0)
            {
                string str = this.class367_0.ToString();
                for (int i = this.int_1; i < str.Length; i++)
                {
                    this.int_1 = i;
                    if (this.method_12(str[this.int_1]) == Enum72.const_0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void method_8()
        {
            if (this.class818_0.int_8 < this.class818_0.int_2)
            {
                this.class818_0.int_2 = this.class818_0.int_8;
            }
            this.method_10();
        }

        private void method_9()
        {
            if (this.class818_0.int_8 >= (this.class818_0.int_2 + this.class818_0.int_4))
            {
                this.class818_0.int_2 = (this.class818_0.int_8 - this.class818_0.int_4) + 1;
            }
            this.method_10();
        }
    }
}

