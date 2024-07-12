namespace ns0
{
    using System;

    internal class Class341 : Class335
    {
        private string string_0;

        internal Class341(int A_1)
        {
            int num;
            Enum6 enum2 = Class516.enum6_0;
            if (enum2 <= Enum6.flag_3)
            {
                switch (enum2)
                {
                    case Enum6.flag_1:
                        num = Class516.int_3;
                        goto Label_006F;

                    case (Enum6.flag_1 | Enum6.flag_0):
                        goto Label_0051;

                    case Enum6.flag_2:
                        num = Class516.int_3;
                        goto Label_006F;
                }
                if (enum2 != Enum6.flag_3)
                {
                    goto Label_0051;
                }
                num = Class516.int_6;
                goto Label_006F;
            }
            switch (enum2)
            {
                case Enum6.flag_4:
                    num = Class516.int_7;
                    goto Label_006F;

                case Enum6.flag_5:
                    num = Class516.int_8;
                    goto Label_006F;

                case Enum6.flag_6:
                    num = Class516.int_4;
                    goto Label_006F;
            }
        Label_0051:
            num = Class516.int_3;
        Label_006F:
            this.string_0 = new string(' ', A_1 * num);
        }

        public override string ToString()
        {
            return this.string_0;
        }

        internal override int Length
        {
            get
            {
                return this.string_0.Length;
            }
        }
    }
}

