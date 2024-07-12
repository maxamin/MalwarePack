namespace ns0
{
    using System;

    internal class Class1023
    {
        internal static Class445 smethod_0(Class445 A_0)
        {
            Enum17 type = A_0.Type;
            if (type <= Enum17.const_16)
            {
                switch (type)
                {
                    case Enum17.const_9:
                        return smethod_2(A_0 as Class463);

                    case Enum17.const_10:
                        return A_0;

                    case Enum17.const_11:
                        return smethod_3(A_0 as Class465);
                }
                if (type != Enum17.const_16)
                {
                    return A_0;
                }
                return smethod_1(A_0 as Class470);
            }
            switch (type)
            {
                case Enum17.const_42:
                    return new Class513(A_0, Enum32.const_2);

                case Enum17.const_66:
                {
                    Class513 class2 = A_0 as Class513;
                    if (class2.enum32_0 == Enum32.const_2)
                    {
                        return class2.class445_0;
                    }
                    return A_0;
                }
            }
            return A_0;
        }

        private static Class470 smethod_1(Class470 A_0)
        {
            switch (A_0.enum31_0)
            {
                case Enum31.const_0:
                    A_0.enum31_0 = Enum31.const_1;
                    return A_0;

                case Enum31.const_1:
                    A_0.enum31_0 = Enum31.const_0;
                    return A_0;

                case Enum31.const_2:
                    A_0.enum31_0 = Enum31.const_5;
                    return A_0;

                case Enum31.const_3:
                    A_0.enum31_0 = Enum31.const_4;
                    return A_0;

                case Enum31.const_4:
                    A_0.enum31_0 = Enum31.const_3;
                    return A_0;

                case Enum31.const_5:
                    A_0.enum31_0 = Enum31.const_2;
                    return A_0;
            }
            return A_0;
        }

        private static Class463 smethod_2(Class463 A_0)
        {
            switch (A_0.enum1_0)
            {
                case Enum1.const_1:
                    A_0.enum1_0 = Enum1.const_8;
                    break;

                case Enum1.const_8:
                    A_0.enum1_0 = Enum1.const_1;
                    break;
            }
            A_0.class445_0 = smethod_0(A_0.class445_0);
            A_0.class445_1 = smethod_0(A_0.class445_1);
            return A_0;
        }

        private static Class465 smethod_3(Class465 A_0)
        {
            switch (A_0.enum1_0)
            {
                case Enum1.const_1:
                    A_0.enum1_0 = Enum1.const_8;
                    break;

                case Enum1.const_8:
                    A_0.enum1_0 = Enum1.const_1;
                    break;
            }
            Class445[] classArray = A_0.class445_0;
            for (int i = 0; i < classArray.Length; i++)
            {
                classArray[i] = smethod_0(classArray[i]);
            }
            return A_0;
        }
    }
}

