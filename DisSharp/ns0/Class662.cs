namespace ns0
{
    using System;
    using System.Collections;

    internal class Class662 : Class661
    {
        internal void method_42()
        {
            this.method_43();
            this.method_44();
        }

        private void method_43()
        {
            ArrayList list = base.class47_0.class3_0.arrayList_0;
            ArrayList list2 = base.class684_0.class557_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class3.Class690 class2 = list[i] as Class3.Class690;
                base.class48_0.method_3(base.int_2 + class2.int_0);
                int num2 = base.class48_0.method_21();
                Class557.Class605 class3 = new Class557.Class605 {
                    byte_0 = base.class48_0.method_19(num2)
                };
                list2.Add(class3);
            }
        }

        private void method_44()
        {
            ArrayList list = base.class47_0.class4_0.arrayList_0;
            ArrayList list2 = base.class684_0.class573_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class4.Class691 class2 = list[i] as Class4.Class691;
                Class573.Class534 class3 = new Class573.Class534 {
                    enum0_0 = class2.enum0_0,
                    int_0 = class2.int_0
                };
                base.class48_0.method_3(base.int_2 + class2.int_1);
                int num2 = base.class48_0.method_21();
                class3.byte_0 = base.class48_0.method_19(num2);
                list2.Add(class3);
            }
        }
    }
}

