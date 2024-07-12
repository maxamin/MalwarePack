namespace ns0
{
    using System;

    internal class Class1114
    {
        internal int int_0;
        internal int int_1;

        internal Class1114(Class1114 A_1)
        {
            this.int_0 = A_1.int_0;
            this.int_1 = A_1.int_1;
        }

        internal Class1114(int A_1, int A_2)
        {
            this.int_0 = A_1;
            this.int_1 = A_2;
        }

        public override bool Equals(object obj)
        {
            Class1114 class2 = obj as Class1114;
            return (smethod_1(class2, null) && smethod_0(this, class2));
        }

        public override int GetHashCode()
        {
            return ((0xf4240 * this.int_0) + this.int_1);
        }

        public static bool smethod_0(Class1114 A_0, Class1114 A_1)
        {
            return ((A_0.int_0 == A_1.int_0) && (A_0.int_1 == A_1.int_1));
        }

        public static bool smethod_1(Class1114 A_0, Class1114 A_1)
        {
            if (A_0.int_0 == A_1.int_0)
            {
                return (A_0.int_1 != A_1.int_1);
            }
            return true;
        }

        public static bool smethod_2(Class1114 A_0, Class1114 A_1)
        {
            if (A_0.int_1 < A_1.int_1)
            {
                return true;
            }
            if (A_0.int_1 > A_1.int_1)
            {
                return false;
            }
            return (A_0.int_0 < A_1.int_0);
        }

        public static bool smethod_3(Class1114 A_0, Class1114 A_1)
        {
            if (A_0.int_1 > A_1.int_1)
            {
                return true;
            }
            if (A_0.int_1 < A_1.int_1)
            {
                return false;
            }
            return (A_0.int_0 > A_1.int_0);
        }

        internal static void smethod_4(Class1114 A_0, Class1114 A_1)
        {
            int num = A_0.int_0;
            int num2 = A_0.int_1;
            A_0.int_0 = A_1.int_0;
            A_0.int_1 = A_1.int_1;
            A_1.int_0 = num;
            A_1.int_1 = num2;
        }
    }
}

