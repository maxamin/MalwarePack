namespace ns0
{
    using System;

    internal class Class977
    {
        internal static void smethod_0()
        {
            Class445[] classArray = new Class445[Class853.int_1];
            for (int i = 0; i < Class853.int_1; i++)
            {
                Class419 class2 = Class853.struct5_0[i].class419_0;
                Class858.smethod_4(class2, true);
                classArray[i] = class2.class445_0;
            }
            Class445 class3 = new Class465(Enum1.const_1, classArray);
            Class855.smethod_0(class3);
        }

        internal static void smethod_1()
        {
            Class445[] classArray = new Class445[Class853.int_1];
            for (int i = 0; i < (Class853.int_1 - 1); i++)
            {
                Class858.smethod_5(Class853.struct5_0[i].class419_0, false, true);
                classArray[i] = Class853.struct5_0[i].class419_0.class445_0;
            }
            Class858.smethod_4(Class853.struct5_0[Class853.int_1 - 1].class419_0, true);
            classArray[Class853.int_1 - 1] = Class853.struct5_0[Class853.int_1 - 1].class419_0.class445_0;
            Class445 class2 = new Class465(Enum1.const_8, classArray);
            Class855.smethod_0(class2);
        }
    }
}

