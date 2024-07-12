namespace ns0
{
    using System;

    internal class Class1028
    {
        internal static void smethod_0()
        {
            Class547.Class528 class2 = Class519.class528_0;
            Class381 class3 = class2.class369_0.class369_0 as Class381;
            if (class3 != null)
            {
                Class547.Class528 class4 = (class3.class619_0[0] as Class391).class528_0;
                if (class2 == class4)
                {
                    if (smethod_1(class2.Boolean_8))
                    {
                        class3.bool_0 = true;
                    }
                    else
                    {
                        class3.bool_0 = false;
                    }
                }
                else
                {
                    Class547.Class528 class5 = (class3.class619_0[1] as Class391).class528_0;
                    if (class2 == class5)
                    {
                        if (smethod_1(class2.Boolean_8))
                        {
                            class3.bool_1 = true;
                        }
                        else
                        {
                            class3.bool_1 = false;
                        }
                    }
                }
            }
        }

        private static bool smethod_1(bool A_0)
        {
            if (Class536.arrayList_0.Count != 2)
            {
                return true;
            }
            Class401 class2 = Class536.arrayList_0[0] as Class401;
            if (class2 == null)
            {
                return true;
            }
            Class456 class3 = class2.class445_1 as Class456;
            if (class3 == null)
            {
                return true;
            }
            if (A_0)
            {
                if (class3.ushort_0 != 0)
                {
                    return true;
                }
                if (!(class2.class445_0 is Class501))
                {
                    return true;
                }
            }
            else
            {
                if (class3.ushort_0 != 1)
                {
                    return true;
                }
                if (!(class2.class445_0 is Class484))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

