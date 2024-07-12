namespace ns0
{
    using System;

    internal class Class859
    {
        private const Enum31 enum31_0 = Enum31.const_0;
        private const Enum31 enum31_1 = Enum31.const_1;

        internal static Class445 smethod_0(Class445 A_0)
        {
            if (A_0.Type == Enum17.const_42)
            {
                return new Class470(new Class451(false), A_0, Enum31.const_0);
            }
            Class658 class2 = Class821.smethod_0(A_0);
            switch (A_0.Type)
            {
                case Enum17.const_4:
                case Enum17.const_5:
                case Enum17.const_7:
                {
                    Enum11 enum3 = class2.enum11_0;
                    switch (enum3)
                    {
                        case Enum11.const_1:
                            return new Class470(new Class451(false), A_0, Enum31.const_0);

                        case Enum11.const_2:
                            return new Class470(new Class471(0), A_0, Enum31.const_0);

                        case Enum11.const_3:
                        case Enum11.const_4:
                        case Enum11.const_5:
                        case Enum11.const_6:
                        case Enum11.const_7:
                        case Enum11.const_8:
                        case Enum11.const_9:
                        case Enum11.const_10:
                            return new Class470(new Class447(0), A_0, Enum31.const_0);
                    }
                    if (enum3 == Enum11.const_41)
                    {
                        switch (Class546.class558_0.method_1(class2.int_0))
                        {
                            case Enum11.const_16:
                                return new Class470(new Class451(false), A_0, Enum31.const_0);

                            case Enum11.const_17:
                                return new Class470(new Class471(0), A_0, Enum31.const_0);

                            case Enum11.const_18:
                            case Enum11.const_19:
                            case Enum11.const_20:
                            case Enum11.const_21:
                            case Enum11.const_22:
                            case Enum11.const_23:
                            case Enum11.const_24:
                            case Enum11.const_25:
                                return new Class470(new Class447(0), A_0, Enum31.const_0);
                        }
                    }
                    break;
                }
            }
            return smethod_1(A_0, class2.enum11_0, class2.int_0, Enum50.const_1);
        }

        internal static Class445 smethod_1(Class445 A_0, Enum11 A_1, int A_2, Enum50 A_3)
        {
            switch (A_3)
            {
                case Enum50.const_0:
                    if (!Class961.smethod_2(A_1, A_2))
                    {
                        if (Class969.smethod_0(A_1))
                        {
                            return new Class470(new Class496(), A_0, Enum31.const_0);
                        }
                        if (Class969.smethod_2(A_1))
                        {
                            return new Class470(new Class447(0), A_0, Enum31.const_0);
                        }
                        if (A_1 == Enum11.const_17)
                        {
                            return new Class470(new Class471(0), A_0, Enum31.const_0);
                        }
                        return A_0;
                    }
                    return new Class470(Class961.class445_0, A_0, Enum31.const_0);

                case Enum50.const_1:
                    if (!Class961.smethod_2(A_1, A_2))
                    {
                        if (Class969.smethod_0(A_1))
                        {
                            return new Class470(new Class496(), A_0, Enum31.const_0);
                        }
                        if (Class969.smethod_2(A_1))
                        {
                            return new Class470(new Class447(0), A_0, Enum31.const_0);
                        }
                        if (A_1 == Enum11.const_17)
                        {
                            return new Class470(new Class471(0), A_0, Enum31.const_0);
                        }
                        if (A_1 == Enum11.const_16)
                        {
                            return new Class470(new Class451(false), A_0, Enum31.const_0);
                        }
                        return A_0;
                    }
                    return new Class470(Class961.class445_0, A_0, Enum31.const_0);

                case Enum50.const_2:
                    if (!Class969.smethod_2(A_1))
                    {
                        return A_0;
                    }
                    return new Class470(new Class447(0), A_0, Enum31.const_0);

                case Enum50.const_3:
                    if (!Class969.smethod_0(A_1))
                    {
                        if (Class969.smethod_2(A_1))
                        {
                            return new Class470(new Class447(0), A_0, Enum31.const_0);
                        }
                        return A_0;
                    }
                    return new Class470(new Class496(), A_0, Enum31.const_0);
            }
            return A_0;
        }

        internal static Class445 smethod_2(Class445 A_0, Class445 A_1)
        {
            switch (Class821.smethod_0(A_1).enum11_0)
            {
                case Enum11.const_3:
                case Enum11.const_4:
                case Enum11.const_5:
                case Enum11.const_6:
                case Enum11.const_7:
                case Enum11.const_8:
                case Enum11.const_9:
                case Enum11.const_10:
                case Enum11.const_11:
                case Enum11.const_12:
                    return new Class470(new Class447(0), A_0, Enum31.const_0);

                case Enum11.const_13:
                case Enum11.const_14:
                case Enum11.const_29:
                case Enum11.const_36:
                case Enum11.const_38:
                    return new Class470(new Class496(), A_0, Enum31.const_0);

                case Enum11.const_37:
                    return A_0;
            }
            return A_0;
        }
    }
}

