namespace ns0
{
    using System;

    internal class Class643
    {
        private static string string_0 = Class537.string_583;
        private static string string_1 = Class537.string_634;
        private static string string_2 = Class537.string_856;
        private static string string_3 = Class537.string_844;

        internal static Class369 smethod_0(Class369 A_0)
        {
            Class369 class2 = A_0;
            while (!(class2.class369_0 is Class390))
            {
                class2 = class2.class369_0;
            }
            return class2;
        }

        internal static void smethod_1(Class369 A_0)
        {
            if (A_0.QQQS == Enum10.const_17)
            {
                smethod_7(A_0.class369_0);
            }
            else
            {
                smethod_7(A_0);
            }
        }

        internal static void smethod_2(string A_0, string A_1)
        {
            Class619 class2 = Class519.class394_0.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                Class369 class3 = class2[i];
                if (class3.Name == A_0)
                {
                    class3.class687_0.Text = A_1;
                }
            }
        }

        internal static void smethod_3(Class369 A_0, string A_1)
        {
            string name = A_0.Name;
            Class619 class2 = A_0.class369_0.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                Class369 class3 = class2[i];
                if (class3.QQQS == Enum10.const_22)
                {
                    if (class3.Name == name)
                    {
                        class3.Name = A_1;
                        class3.class687_0.Text = class3.String_0;
                    }
                }
                else if ((class3.QQQS == Enum10.const_21) && (class3.Name == name))
                {
                    Class381 class4 = class3 as Class381;
                    Class519.class581_0[class4.int_0] = A_1;
                    class4.class687_0.Text = class4.String_0;
                    smethod_6(class4.class619_0[0], string_0, A_1);
                    smethod_6(class4.class619_0[1], string_1, A_1);
                }
            }
        }

        internal static void smethod_4(Class384 A_0, string A_1)
        {
            Class519.class581_0[A_0.int_0] = A_1;
            A_0.class687_0.Text = A_0.String_0;
            switch (A_0.enum34_0)
            {
                case Enum34.const_0:
                    smethod_6(A_0.class619_0[0], string_2, A_1);
                    return;

                case Enum34.const_1:
                    smethod_6(A_0.class619_0[0], string_3, A_1);
                    return;

                case Enum34.const_2:
                    smethod_6(A_0.class619_0[0], string_2, A_1);
                    smethod_6(A_0.class619_0[1], string_3, A_1);
                    return;
            }
        }

        internal static void smethod_5(Class382 A_0, string A_1)
        {
            Class519.class581_0[A_0.int_0] = A_1;
            A_0.class687_0.Text = A_0.String_0;
            switch (A_0.enum34_0)
            {
                case Enum34.const_0:
                    smethod_6(A_0.class619_0[0], string_2, A_1);
                    return;

                case Enum34.const_1:
                    smethod_6(A_0.class619_0[0], string_3, A_1);
                    return;

                case Enum34.const_2:
                    smethod_6(A_0.class619_0[0], string_2, A_1);
                    smethod_6(A_0.class619_0[1], string_3, A_1);
                    return;
            }
        }

        private static void smethod_6(Class369 A_0, string A_1, string A_2)
        {
            A_0.Name = A_1 + A_2;
        }

        private static void smethod_7(Class369 A_0)
        {
            try
            {
                A_0.class687_0.Text = A_0.String_0;
                if (A_0.QQQS != Enum10.const_10)
                {
                    if (A_0.QQQS == Enum10.const_17)
                    {
                        A_0.class369_0.class687_0.Text = A_0.class369_0.String_0;
                    }
                    Class619 class2 = A_0.class619_0;
                    for (int i = 0; i < class2.Int32_0; i++)
                    {
                        Class369 class3 = class2[i];
                        if (class3.QQQS == Enum10.const_17)
                        {
                            class3.class687_0.Text = class3.String_0;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

