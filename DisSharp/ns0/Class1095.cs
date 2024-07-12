namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1095
    {
        private static ArrayList arrayList_0 = new ArrayList();

        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                ArrayList qQSQ = class2.QQSQ;
                if (class2.Type == Enum26.const_40)
                {
                    arrayList_0.Clear();
                    smethod_2(class2, qQSQ);
                    if (arrayList_0.Count > 1)
                    {
                        Class445[] classArray = new Class445[arrayList_0.Count];
                        Class445[] classArray2 = new Class445[arrayList_0.Count];
                        Class439 class3 = null;
                        for (int j = 0; j < arrayList_0.Count; j++)
                        {
                            class3 = arrayList_0[j] as Class439;
                            classArray[j] = class3.class445_0;
                            classArray2[j] = class3.class445_1;
                        }
                        Class440 class4 = new Class440(classArray, classArray2);
                        ArrayList list2 = class3.QQSQ;
                        if (list2 != null)
                        {
                            for (int k = 0; k < list2.Count; k++)
                            {
                                class4.QQSR(list2[k] as Class398);
                            }
                        }
                        Class689.smethod_5(class2, class4);
                        A_0[i] = class4;
                        qQSQ = class4.QQSQ;
                    }
                }
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private static void smethod_2(Class398 A_0, ArrayList A_1)
        {
            arrayList_0.Add(A_0);
            if ((A_1 != null) && (A_1.Count == 1))
            {
                Class398 class2 = A_1[0] as Class398;
                if (class2.Type == Enum26.const_40)
                {
                    smethod_2(class2, class2.QQSQ);
                }
            }
        }
    }
}

