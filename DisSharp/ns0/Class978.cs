namespace ns0
{
    using System;

    internal class Class978
    {
        internal static int smethod_0()
        {
            if (Class1044.smethod_0())
            {
                return -1;
            }
            int num = Class853.int_1;
            smethod_1();
            if (Class853.int_1 == num)
            {
                if (!smethod_2())
                {
                    return (Class973.int_0 + Class853.int_1);
                }
                Class854.int_0--;
                if (Class854.int_0 > 2)
                {
                    return (Class973.int_0 + Class853.int_1);
                }
            }
            if (Class853.int_1 == 1)
            {
                Class975.smethod_0();
                return -1;
            }
            switch (Class858.smethod_9())
            {
                case Enum46.const_1:
                    Class977.smethod_0();
                    return -1;

                case Enum46.const_2:
                    Class977.smethod_1();
                    return -1;

                case Enum46.const_3:
                    return Class852.smethod_0();
            }
            throw new Exception1();
        }

        private static void smethod_1()
        {
            Class398 class2 = Class854.struct18_0[Class854.int_0 - 1].class398_0;
            int index = Class853.int_1 - 1;
            while (index >= 0)
            {
                if (Class853.struct5_0[index].class398_0 == class2)
                {
                    break;
                }
                index--;
            }
            Class853.int_1 = index + 1;
        }

        private static bool smethod_2()
        {
            Class398 class2 = Class854.struct18_0[Class854.int_0 - 1].class398_0;
            int num = Class973.int_0 + Class853.int_1;
            for (int i = Class853.int_1 - 2; i >= 0; i--)
            {
                if ((Class853.struct5_0[i].class398_0.ushort_1 > num) && (Class853.struct5_0[i].class398_0 != class2))
                {
                    Class853.int_1 = i + 1;
                    return true;
                }
            }
            return false;
        }
    }
}

