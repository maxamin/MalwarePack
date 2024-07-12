namespace ns0
{
    using System;

    internal class Class976
    {
        internal static int smethod_0()
        {
            smethod_1();
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
            int index = Class853.int_1 - 1;
            while (index >= 0)
            {
                if (!Class858.smethod_7(Class853.struct5_0[index].class398_0))
                {
                    break;
                }
                index--;
            }
            Class853.int_1 = index + 1;
        }
    }
}

