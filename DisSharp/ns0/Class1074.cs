namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1074
    {
        private static bool bool_0;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1(Class536.arrayList_0, false);
                if (!bool_0)
                {
                    flag = false;
                }
                num++;
                if (!flag || (num >= 250))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0, bool A_1)
        {
            if (!A_1)
            {
                int num = A_0.Count - 1;
                for (int j = 0; j < num; j++)
                {
                    Class398 statement = A_0[j] as Class398;
                    if (statement.Type == Enum26.const_38)
                    {
                        int num3 = j;
                        int num4 = 1;
                        Class407 class3 = new Class407();
                        class3.QQSR(statement);
                        for (int k = num3 + 1; k <= num; k++)
                        {
                            statement = A_0[k] as Class398;
                            if ((statement.Type != Enum26.const_5) && (statement.Type != Enum26.const_11))
                            {
                                break;
                            }
                            class3.QQSR(statement);
                            num4++;
                        }
                        Class689.smethod_2(A_0, num3, num4);
                        A_0.Insert(num3, class3);
                        bool_0 = true;
                        return;
                    }
                }
            }
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class4 = A_0[i] as Class398;
                ArrayList qQSQ = class4.QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ, class4.Type == Enum26.const_39);
                }
            }
        }
    }
}

