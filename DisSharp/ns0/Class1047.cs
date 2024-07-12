namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1047
    {
        internal static ArrayList arrayList_0 = new ArrayList();
        internal static ArrayList arrayList_1 = new ArrayList();

        static Class1047()
        {
            smethod_1(new Delegate3(Class980.smethod_0));
            smethod_1(new Delegate3(Class1084.smethod_0));
            smethod_1(new Delegate3(Class1108.smethod_0));
            smethod_1(new Delegate3(Class1031.smethod_0));
            smethod_1(new Delegate3(Class1109.smethod_0));
            smethod_1(new Delegate3(Class1073.smethod_0));
            smethod_1(new Delegate3(Class1101.smethod_0));
            smethod_1(new Delegate3(Class1020.smethod_0));
            smethod_1(new Delegate3(Class847.smethod_0));
            smethod_1(new Delegate3(Class1076.smethod_0));
            smethod_1(new Delegate3(Class1103.smethod_0));
            smethod_1(new Delegate3(Class932.smethod_0));
            smethod_1(new Delegate3(Class986.smethod_0));
            smethod_1(new Delegate3(Class1081.smethod_0));
            smethod_1(new Delegate3(Class1018.smethod_0));
            smethod_1(new Delegate3(Class1110.smethod_0));
            smethod_1(new Delegate3(Class991.smethod_0));
            smethod_0(new Delegate3(Class1095.smethod_0), 0x66);
            smethod_0(new Delegate3(Class1083.smethod_0), 0x4e);
            smethod_1(new Delegate3(Class1013.smethod_0));
            smethod_1(new Delegate3(Class1061.smethod_0));
            smethod_1(new Delegate3(Class851.smethod_0));
            smethod_0(new Delegate3(Class930.smethod_0), 70);
            smethod_1(new Delegate3(Class1111.smethod_0));
            smethod_0(new Delegate3(Class1028.smethod_0), 70);
            smethod_1(new Delegate3(Class926.smethod_0));
            smethod_0(new Delegate3(Class994.smethod_0), 8);
            smethod_0(new Delegate3(Class1074.smethod_0), 0x38);
            smethod_1(new Delegate3(Class1053.smethod_0));
            smethod_0(new Delegate3(Class1055.smethod_0), 70);
            smethod_0(new Delegate3(Class1112.smethod_0), 70);
            smethod_0(new Delegate3(Class1104.smethod_0), 70);
            smethod_0(new Delegate3(Class871.smethod_0), 70);
            smethod_0(new Delegate3(Class1072.smethod_0), 70);
            smethod_0(new Delegate3(Class1113.smethod_0), 70);
            smethod_0(new Delegate3(Class1078.smethod_0), 70);
            smethod_1(new Delegate3(Class1002.smethod_0));
            smethod_1(new Delegate3(Class1069.smethod_0));
            int count = arrayList_0.Count;
            smethod_1(new Delegate3(Class997.smethod_0));
            smethod_1(new Delegate3(Class1082.smethod_0));
            smethod_1(new Delegate3(Class982.smethod_0));
            count = arrayList_0.Count - count;
            for (int i = 0; i < count; i++)
            {
                arrayList_1.Add(arrayList_0[(arrayList_0.Count - count) + i]);
            }
        }

        private static void smethod_0(Delegate3 A_0, int A_1)
        {
            Class1046 class2 = new Class1046 {
                delegate3_0 = A_0,
                int_0 = A_1,
                string_0 = A_0.Method.DeclaringType.Name
            };
            arrayList_0.Add(class2);
        }

        private static void smethod_1(Delegate3 A_0)
        {
            smethod_0(A_0, 0xfffffff);
        }
    }
}

