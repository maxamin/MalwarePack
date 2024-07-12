namespace ns0
{
    using System;
    using System.Collections;

    internal class Class663 : Class662
    {
        private bool[] bool_2;
        private static bool bool_3 = false;
        private static bool bool_4 = true;
        private static string string_39 = Class537.string_833;
        private static string string_40 = Class537.string_226;
        private static string string_41 = Class537.string_255;
        private static string string_42 = Class537.string_652;

        internal void method_45()
        {
            this.method_46();
            this.method_47();
            this.method_48();
            this.method_49();
            base.class394_0.class619_0.method_7();
            base.class394_0.class619_0.method_9(true);
        }

        private void method_46()
        {
            ArrayList list = base.class684_0.class562_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class562.Class533 class2 = list[i] as Class562.Class533;
                Class390 class3 = new Class390 {
                    class369_0 = base.class394_0,
                    class533_0 = class2
                };
                
                base.class394_0.class619_0.method_0(class3);
                class2.class369_0 = class3;
            }
        }

        private void method_47()
        {
            ArrayList list = base.class47_0.class5_0.arrayList_0;
            this.bool_2 = new bool[base.class684_0.class548_0.arrayList_0.Count];
            for (int i = 1; i < list.Count; i++)
            {
                Class5.Class692 class2 = list[i] as Class5.Class692;
                this.bool_2[class2.int_0] = true;
            }
        }

        private void method_48()
        {
            if (!bool_3)
            {
                bool_4 = true;
                try
                {
                    Class693.smethod_0();
                }
                catch (Exception)
                {
                    bool_4 = false;
                }
                bool_3 = true;
            }
            if (bool_4)
            {
                ArrayList list = base.class684_0.class548_0.arrayList_0;
                for (int i = 1; i < list.Count; i++)
                {
                    if (!this.bool_2[i])
                    {
                        Class548.Class529 class2 = list[i] as Class548.Class529;
                        Class562.Class533 class3 = base.class684_0.class562_0.arrayList_0[class2.int_2] as Class562.Class533;
                        Class369 class4 = this.method_51(class2, false);
                        this.method_50(class3.class369_0, class4);
                    }
                }
                this.bool_2 = null;
            }
        }

        private void method_49()
        {
            if (bool_4)
            {
                bool flag;
                ArrayList list = base.class47_0.class5_0.arrayList_0;
                ArrayList list2 = base.class684_0.class548_0.arrayList_0;
                bool[] flagArray = new bool[list.Count];
                do
                {
                    flag = false;
                    for (int i = 1; i < list.Count; i++)
                    {
                        if (!flagArray[i])
                        {
                            Class5.Class692 class2 = list[i] as Class5.Class692;
                            Class548.Class529 class3 = list2[class2.int_1] as Class548.Class529;
                            Class369 class4 = class3.class369_0;
                            if (class4 != null)
                            {
                                Class369 class5 = this.method_51(list2[class2.int_0] as Class548.Class529, true);
                                this.method_50(class4, class5);
                                flagArray[i] = true;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                    }
                }
                while (flag);
            }
        }

        private void method_50(Class369 A_1, Class369 A_2)
        {
            A_2.class369_0 = A_1;
            A_1.class619_0.method_0(A_2);
        }

        private Class369 method_51(Class548.Class529 A_1, bool A_2)
        {
            Class370 class2;
            string str;
            string str2;
            Enum38 enum2 = Enum38.const_3;
            Enum0 enum3 = A_1.enum0_0;
            if ((enum3 == Enum0.const_1) && (A_1.int_4 > 0))
            {
                Class553.Class531 class3 = base.class684_0.class553_0.arrayList_0[A_1.int_4] as Class553.Class531;
                str = base.class581_0[class3.int_1];
                str2 = base.class581_0[(base.class684_0.class562_0.arrayList_0[class3.int_2] as Class562.Class533).int_1];
                if (str2 == string_39)
                {
                    if (str == string_40)
                    {
                        enum2 = Enum38.const_0;
                    }
                    if (str == string_41)
                    {
                        enum2 = Enum38.const_1;
                    }
                    if (str == string_42)
                    {
                        enum2 = Enum38.const_2;
                    }
                }
            }
            if ((enum3 == Enum0.const_2) && (A_1.int_4 > 0))
            {
                Class548.Class529 class4 = base.class684_0.class548_0.arrayList_0[A_1.int_4] as Class548.Class529;
                str = base.class581_0[class4.int_1];
                str2 = base.class581_0[(base.class684_0.class562_0.arrayList_0[class4.int_2] as Class562.Class533).int_1];
                if (str2 == string_39)
                {
                    if (str == string_40)
                    {
                        enum2 = Enum38.const_0;
                    }
                    if (str == string_41)
                    {
                        enum2 = Enum38.const_1;
                    }
                    if (str == string_42)
                    {
                        enum2 = Enum38.const_2;
                    }
                }
            }
            if (enum2 == Enum38.const_0)
            {
                if (A_2)
                {
                    class2 = new Class374();
                }
                else
                {
                    class2 = new Class373();
                }
            }
            else if (enum2 == Enum38.const_1)
            {
                if (A_2)
                {
                    class2 = new Class378();
                }
                else
                {
                    class2 = new Class377();
                }
            }
            else if (enum2 == Enum38.const_2)
            {
                if (A_2)
                {
                    class2 = new Class372();
                }
                else
                {
                    class2 = new Class371();
                }
            }
            else if (A_1.Boolean_5)
            {
                if (A_2)
                {
                    class2 = new Class376();
                }
                else
                {
                    class2 = new Class375();
                }
            }
            else if (A_2)
            {
                class2 = new Class380();
            }
            else
            {
                class2 = new Class379();
            }
            class2.class529_0 = A_1;
            A_1.class369_0 = class2;
            return class2;
        }

        private enum Enum38
        {
            const_0,
            const_1,
            const_2,
            const_3
        }
    }
}

