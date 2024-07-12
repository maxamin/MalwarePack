namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1104
    {
        private static ArrayList arrayList_0 = new ArrayList();
        private static ArrayList arrayList_1 = new ArrayList();
        private static bool bool_0;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1(Class536.arrayList_0);
                if (!bool_0)
                {
                    flag = false;
                }
                num++;
                if (!flag || (num >= 0x19))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < (A_0.Count - 1); i++)
            {
                Class398 class2 = A_0[i] as Class398;
                Class399 class3 = class2 as Class399;
                if (class3 != null)
                {
                    Class492 class4 = class3.class445_0 as Class492;
                    if (class4 != null)
                    {
                        smethod_2(class4, class3.class445_1, A_0, i);
                        int count = arrayList_0.Count;
                        if (count > 1)
                        {
                            ushort[] numArray = new ushort[count];
                            Class445[] classArray = new Class445[count];
                            for (int k = 0; k < count; k++)
                            {
                                Class492 class5 = arrayList_0[k] as Class492;
                                numArray[k] = class5.ushort_0;
                                classArray[k] = arrayList_1[k] as Class445;
                            }
                            Class402 class6 = new Class402(class4.enum11_0, class4.int_0, class4.byte_0, numArray, classArray);
                            Class689.smethod_2(A_0, i, count);
                            A_0.Insert(i, class6);
                            bool_0 = true;
                            return;
                        }
                    }
                }
            }
            for (int j = 0; j < A_0.Count; j++)
            {
                ArrayList qQSQ = (A_0[j] as Class398).QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private static void smethod_2(Class492 A_0, Class445 A_1, ArrayList A_2, int A_3)
        {
            arrayList_0.Clear();
            Enum11 enum2 = A_0.enum11_0;
            if (smethod_3(enum2) && smethod_4(A_1))
            {
                arrayList_1.Clear();
                arrayList_0.Add(A_0);
                arrayList_1.Add(A_1);
                int num = A_0.int_0;
                byte num2 = A_0.byte_0;
                for (int i = A_3 + 1; i < A_2.Count; i++)
                {
                    Class399 class2 = A_2[i] as Class399;
                    if (class2 == null)
                    {
                        return;
                    }
                    Class492 class3 = class2.class445_0 as Class492;
                    if (class3 == null)
                    {
                        return;
                    }
                    if (((class3.enum11_0 != enum2) || (class3.int_0 != num)) || (class3.byte_0 != num2))
                    {
                        return;
                    }
                    if (!smethod_4(class2.class445_1))
                    {
                        return;
                    }
                    arrayList_0.Add(class3);
                    arrayList_1.Add(class2.class445_1);
                }
            }
        }

        private static bool smethod_3(Enum11 A_0)
        {
            switch (A_0)
            {
                case Enum11.const_16:
                case Enum11.const_17:
                case Enum11.const_18:
                case Enum11.const_19:
                case Enum11.const_20:
                case Enum11.const_21:
                case Enum11.const_22:
                case Enum11.const_23:
                case Enum11.const_24:
                case Enum11.const_25:
                case Enum11.const_26:
                case Enum11.const_27:
                case Enum11.const_29:
                case Enum11.const_30:
                case Enum11.const_31:
                case Enum11.const_36:
                case Enum11.const_38:
                case Enum11.const_44:
                    return true;
            }
            return false;
        }

        private static bool smethod_4(Class445 A_0)
        {
            switch (A_0.Type)
            {
                case Enum17.const_17:
                case Enum17.const_18:
                case Enum17.const_19:
                case Enum17.const_21:
                case Enum17.const_22:
                case Enum17.const_23:
                case Enum17.const_26:
                case Enum17.const_27:
                case Enum17.const_50:
                    return true;
            }
            return false;
        }
    }
}

