namespace ns0
{
    using System;

    internal class Class668 : Class667
    {
    	private static string value__ = Class537.value__;
    	
        internal void method_59()
        {
            this.method_60();
            this.method_61();
            this.method_62();
        }

        private void method_60()
        {
            Class619 class2 = base.class394_0.class619_0;
            for (int i = class2.Int32_0 - 1; i >= 0; i--)
            {
                Class369 class3 = class2[i];
                if (class3.class619_0.Int32_0 == 0)
                {
                    class2.method_3(class3);
                }
            }
        }

        private void method_61()
        {
            Class619 class2 = base.class394_0.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                int num2;
                Class369 class5;
                Class369 class3 = class2[i];
                if (class3.Name != "")
                {
                    continue;
                }
                Class619 class4 = class3.class619_0;
                goto Label_0086;
            Label_0036:
                class5 = class4[num2];
                string name = class5.Name;
                if ((name == Class537.string_706) || (name == Class537.string_188))
                {
                    goto Label_0077;
                }
                num2++;
            Label_006B:
                if (num2 < class4.Int32_0)
                {
                    goto Label_0036;
                }
                goto Label_0082;
            Label_0077:
                class4.method_3(class5);
                bool flag = true;
            Label_0082:
                if (!flag)
                {
                    goto Label_008E;
                }
            Label_0086:
                flag = false;
                num2 = 0;
                goto Label_006B;
            Label_008E:
                if (class4.Int32_0 == 0)
                {
                    class2.method_3(class3);
                }
                else
                {
                    class3.Name = Class537.string_89;
                }
            }
        }

        private void method_62()
        {
            this.method_63(base.class394_0, false);
        }

        private void method_63(Class369 A_1, bool A_2)
        {
            Class619 class2 = A_1.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                Class369 class3 = class2[i];
                if (A_2 && (class3.Name == value__))
                {
                    class2.method_3(class3);
                    return;
                }
                this.method_63(class3, class3 is Class373);
            }
        }
    }
}

