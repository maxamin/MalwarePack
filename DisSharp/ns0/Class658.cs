namespace ns0
{
    using System;
    using System.Collections;

    internal class Class658
    {
        internal byte byte_0;
        internal static Class658 class658_0 = new Class658();
        internal static Class658 class658_1;
        internal static Class658 class658_2;
        internal Enum11 enum11_0;
        internal int int_0;
        private const short short_0 = 0x3e8;
        private static Stack stack_0 = new Stack(0x3e8);
        private static Stack stack_1 = new Stack(0x3e8);
        private static Stack stack_2 = new Stack(0x3e8);
        private static Stack stack_3 = new Stack(0x3e8);

        static Class658()
        {
            class658_0.enum11_0 = Enum11.const_16;
            class658_1 = new Class658();
            class658_1.enum11_0 = Enum11.const_22;
            class658_2 = new Class658();
            class658_2.enum11_0 = Enum11.const_29;
        }

        internal static void smethod_0()
        {
            int count = stack_1.Count;
            for (int i = 0; i < count; i++)
            {
                stack_0.Push(stack_1.Pop());
            }
            count = stack_3.Count;
            for (int j = 0; j < count; j++)
            {
                stack_2.Push(stack_3.Pop());
            }
        }

        internal static Class658 smethod_1()
        {
            Class658 class2;
            if (stack_0.Count > 0)
            {
                class2 = stack_0.Pop() as Class658;
            }
            else
            {
                class2 = new Class658();
            }
            stack_1.Push(class2);
            class2.enum11_0 = Enum11.const_0;
            class2.byte_0 = 0;
            return class2;
        }

        internal static Class658 smethod_2(Enum11 A_0, int A_1, byte A_2)
        {
            Class658 class2;
            if (stack_0.Count > 0)
            {
                class2 = stack_0.Pop() as Class658;
            }
            else
            {
                class2 = new Class658();
            }
            stack_1.Push(class2);
            class2.enum11_0 = A_0;
            class2.int_0 = A_1;
            class2.byte_0 = A_2;
            return class2;
        }

        internal static Class957 smethod_3()
        {
            Class957 class2;
            if (stack_2.Count > 0)
            {
                class2 = stack_2.Pop() as Class957;
            }
            else
            {
                class2 = new Class957();
            }
            stack_3.Push(class2);
            class2.bool_0 = false;
            return class2;
        }
    }
}

