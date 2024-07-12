namespace ns0
{
    using System;
    using System.Collections;
    using System.Reflection;

    internal class Class843
    {
        private Hashtable hashtable_0 = new Hashtable();

        internal bool method_0(Class369 A_1)
        {
            return this.hashtable_0.ContainsKey(A_1);
        }

        internal void method_1(Class369 A_1, Class844 A_2)
        {
            this.hashtable_0.Add(A_1, A_2);
        }

        internal void method_2()
        {
            this.hashtable_0.Clear();
        }

        internal bool method_3(Class369 A_1, bool A_2)
        {
            if (this.method_0(A_1))
            {
                Class844 class2 = this.hashtable_0[A_1] as Class844;
                ArrayList list = class2.ArrayList_0;
                for (int i = 0; i < list.Count; i++)
                {
                    Class646 class3 = list[i] as Class646;
                    if (((class3.class845_0 != null) && (class3.class845_0.Enum54_0 == Enum54.const_1)) && (class3.enum6_0 == Class516.enum6_0))
                    {
                        this.method_4(class3.class845_0, class3.int_0, A_2);
                        return true;
                    }
                }
                for (int j = 0; j < list.Count; j++)
                {
                    Class646 class4 = list[j] as Class646;
                    if (((class4.class845_0 != null) && (class4.class845_0.Enum54_0 == Enum54.const_0)) && (class4.enum6_0 == Class516.enum6_0))
                    {
                        this.method_4(class4.class845_0, 0, A_2);
                        return true;
                    }
                }
            }
            return false;
        }

        private void method_4(Class845 A_1, int A_2, bool A_3)
        {
            Class645.class704_0.method_15(A_1);
            Control0 control = Class645.class704_0.Control0_0;
            if (control != null)
            {
                if (A_3)
                {
                    control.int_2 = A_2;
                }
                else
                {
                    control.method_10(A_2);
                }
            }
        }

        internal Hashtable Hashtable_0
        {
            get
            {
                return this.hashtable_0;
            }
        }

        internal Class844 this[Class369 A_1]
        {
            get
            {
                return (this.hashtable_0[A_1] as Class844);
            }
        }
    }
}

