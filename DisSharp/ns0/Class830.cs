namespace ns0
{
    using System;
    using System.Collections;

    internal class Class830 : Class822
    {
        internal ArrayList arrayList_1 = new ArrayList();
        internal int[] int_1;

        internal Class830(int A_1, int A_2)
        {
            base.int_0 = A_1;
            base.enum45_0 = Enum45.const_70;
            this.int_1 = new int[A_2];
        }

        internal override void QQUX(Class397 lines)
        {
            int num = this.arrayList_1.Count - 1;
            lines.method_10(Class518.class337_10);
            for (int i = 0; i < this.arrayList_1.Count; i++)
            {
                Class822 class2 = (Class822) this.arrayList_1[i];
                lines.method_10(Class584.class340_0);
                lines.method_10(Class585.smethod_1(class2.short_1));
                if (i < num)
                {
                    lines.method_10(Class518.class337_14);
                }
            }
            lines.method_10(Class518.class337_12);
        }

        internal override void QQVZ(Class398 statement)
        {
            for (int i = 0; i < this.arrayList_1.Count; i++)
            {
                Class398 target = Class536.hashtable_1[this.arrayList_1[i] as Class822] as Class398;
                statement.QQST(target);
                target.method_0(statement);
            }
        }
    }
}

