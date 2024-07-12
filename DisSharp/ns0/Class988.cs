namespace ns0
{
    using System;
    using System.Collections;
    using System.Text;

    internal class Class988
    {
        private static ArrayList arrayList_0 = new ArrayList();
        private static bool bool_0 = false;

        private static void smethod_0()
        {
            Class860.bool_1 = true;
        }

        internal static void smethod_1()
        {  // info: smethod_0(); removed for fixing decompilation
            if (!bool_0)
            {
                StringBuilder builder = new StringBuilder(10);
                builder.Append('\x0014');
                builder.Append('.');
                builder.Append('\x0019');
                builder.Append('\x0019');
                builder.Append('\x0013');
                if (Type.GetType(builder.ToString()) == null)
                {
                    //smethod_0();
                }
                bool_0 = true;
            }
        }

        internal static uint smethod_2(Enum0 A_0, int A_1)
        {
            int num = ((byte) A_0) << 0x18;
            return (uint) (num + A_1);
        }

        internal static uint smethod_3(byte A_0, int A_1)
        {
            int num = A_0 << 0x18;
            return (uint) (num + A_1);
        }

        internal static void smethod_4(ArrayList A_0, int A_1, int A_2)
        {
            for (int i = 0; i < A_2; i++)
            {
                A_0.RemoveAt(A_1);
            }
        }

        internal static void smethod_5(ArrayList A_0, int A_1)
        {
            int num = A_0.Count - A_1;
            for (int i = 0; i < num; i++)
            {
                A_0.RemoveAt(A_1);
            }
        }

        internal static void smethod_6(Class398 A_0, Class398 A_1, Class398 A_2)
        {
            A_1.method_1(A_0);
            A_0.QQSS(A_1, A_2);
            A_2.method_0(A_0);
        }

        internal static void smethod_7(Class398 A_0, Class398 A_1)
        {
            if (A_0.arrayList_0 != null)
            {
                ArrayList list = A_0.arrayList_0;
                arrayList_0.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    Class398 class2 = list[i] as Class398;
                    arrayList_0.Add(class2);
                    class2.QQSS(A_0, A_1);
                    A_1.method_0(class2);
                }
                for (int j = 0; j < arrayList_0.Count; j++)
                {
                    Class398 class3 = arrayList_0[j] as Class398;
                    A_0.method_1(class3);
                }
            }
        }

        internal static bool smethod_8(ArrayList A_0)
        {
            if (A_0 != null)
            {
                for (int i = 0; i < A_0.Count; i++)
                {
                    Class398 class2 = A_0[i] as Class398;
                    if (!class2.QQVR)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

