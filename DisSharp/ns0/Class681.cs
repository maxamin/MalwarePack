namespace ns0
{
    using System;

    internal class Class681
    {
        internal Class47 class47_0;
        internal Class48 class48_0;
        internal Class682 class682_0;
        internal Class807 class807_0;
        internal Class917 class917_0;
        internal Class954 class954_0;
        internal Class955 class955_0;
        internal Class962 class962_0;
        internal Class970 class970_0;
        internal Class971 class971_0;
        private string string_0;

        internal Class681(string A_1)
        {
            this.string_0 = A_1;
            this.method_1();
        }

        internal void method_0()
        {
            this.class954_0.method_1();
            this.class47_0.method_0();
        }

        private void method_1()
        {
            this.class48_0 = new Class48(this.string_0);
            this.class48_0.method_0();
            this.class48_0.method_3(0);
            byte num = this.class48_0.method_8();
            byte num2 = this.class48_0.method_8();
            if ((num != 0x4d) || (num2 != 90))
            {
                throw new Exception16(this.string_0);
            }
            int num5 = this.class48_0.method_13(60);
            this.class48_0.method_3(num5);
            num = this.class48_0.method_8();
            num2 = this.class48_0.method_8();
            byte num3 = this.class48_0.method_8();
            byte num4 = this.class48_0.method_8();
            if (((num == 80) && (num2 == 0x45)) && ((num3 == 0) && (num4 == 0)))
            {
                try
                {
                    int num6 = num5 + 4;
                    this.class807_0 = new Class807(num6);
                    this.class807_0.method_0(this.class48_0);
                    num6 += 20;
                    this.class971_0 = new Class971(this, num6);
                    this.class971_0.method_0(this.class48_0);
                    num6 += this.class971_0.Int32_0;
                    this.class970_0 = new Class970(this, num6);
                    this.class970_0.method_0(this.class48_0);
                    num6 += this.class970_0.Int32_0;
                    this.class962_0 = new Class962(num6);
                    this.class962_0.method_0(this.class48_0);
                    num6 += 0x80;
                    this.class682_0 = new Class682(num6, this.class807_0.short_1);
                    this.class682_0.method_0(this.class48_0);
                    this.class917_0 = new Class917(this.class682_0.method_1(this.class962_0.int_29));
                    this.class917_0.method_0(this.class48_0);
                    this.class955_0 = new Class955(this.class682_0.method_1(this.class917_0.int_2));
                    this.class955_0.method_1(this.class48_0);
                    if (this.class955_0.int_0 != 0x424a5342)
                    {
                        throw new Exception17(this.string_0);
                    }
                    this.class47_0 = new Class47(this);
                    this.class954_0 = new Class954(this.class955_0.Int32_8, this.class955_0.Int32_9, this);
                    this.class954_0.method_2(this.class48_0);
                    return;
                }
                catch
                {
                    throw new Exception17(this.string_0);
                }
            }
            throw new Exception17(this.string_0);
        }
    }
}

