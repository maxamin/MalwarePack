namespace ns0
{
    using System;
    using System.Collections;

    internal class Class627
    {
        private bool bool_0;
        private Class394 class394_0;
        private Hashtable hashtable_0 = new Hashtable();
        private Hashtable hashtable_1 = new Hashtable();

        internal Class627(Class394 A_1)
        {
            this.class394_0 = A_1;
        }

        internal void method_0()
        {
            this.hashtable_0.Clear();
            this.hashtable_1.Clear();
            this.bool_0 = false;
        }

        internal bool method_1(string A_1, ref int A_2, ref Class548.Class529 A_3)
        {
            if (!this.bool_0)
            {
                this.method_3();
            }
            if (this.hashtable_0.ContainsKey(A_1))
            {
                Class1070 class2 = (Class1070) this.hashtable_0[A_1];
                A_2 = class2.int_0;
                A_3 = class2.class529_0;
                return true;
            }
            return false;
        }

        internal bool method_2(string A_1, ref int A_2, ref Class553.Class531 A_3)
        {
            if (!this.bool_0)
            {
                this.method_3();
            }
            if (this.hashtable_1.ContainsKey(A_1))
            {
                Class1071 class2 = (Class1071) this.hashtable_1[A_1];
                A_2 = class2.int_0;
                A_3 = class2.class531_0;
                return true;
            }
            return false;
        }

        private void method_3()
        {
            Class516.Boolean_0 = true;
            int num = 0;
            try
            {
                ArrayList list = this.class394_0.class684_0.class548_0.arrayList_0;
                for (num = 1; num < list.Count; num++)
                {
                    Class548.Class529 class2 = list[num] as Class548.Class529;
                    Class1070 class3 = new Class1070 {
                        int_0 = num,
                        class529_0 = class2
                    };
                    this.hashtable_0[Class612.smethod_2(class2)] = class3;
                }
                list = this.class394_0.class684_0.class553_0.arrayList_0;
                for (num = 1; num < list.Count; num++)
                {
                    Class553.Class531 class4 = list[num] as Class553.Class531;
                    Class1071 class5 = new Class1071 {
                        int_0 = num,
                        class531_0 = class4
                    };
                    this.hashtable_1[Class612.smethod_7(class4)] = class5;
                }
            }
            catch
            {
            }
            finally
            {
                Class516.smethod_0();
                this.bool_0 = true;
            }
        }
    }
}

