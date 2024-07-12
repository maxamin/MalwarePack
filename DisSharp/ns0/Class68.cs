namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class68 : Class67
    {
        protected Class68()
        {
        }

        internal void method_154(Class549.Class530 A_1)
        {
            if (Class516.bool_11)
            {
                base.method_92(A_1.enum11_0, A_1.int_2, A_1.byte_0);
            }
            base.method_57(A_1);
        }

        internal void method_155(Class555.Class600 A_1)
        {
            if (Class516.bool_11)
            {
                base.method_92(A_1.enum11_0, A_1.int_2, A_1.byte_0);
            }
            base.method_60(A_1);
        }

        internal void method_156(Class547.Class528 A_1)
        {
            if (Class516.bool_11 && !A_1.Boolean_18)
            {
                this.method_162(A_1.enum11_0, A_1.int_5, A_1.byte_1);
            }
            base.method_63(A_1);
            if (Class516.bool_11)
            {
                base.method_9(Class518.class337_10);
                int num = A_1.short_2;
                if (num > 0)
                {
                    ArrayList list = Class546.class568_0.arrayList_0;
                    int num2 = A_1.int_6;
                    for (int i = 0; i < num; i++)
                    {
                        Class568.Class623 class2 = list[num2 + i] as Class568.Class623;
                        if (i > 0)
                        {
                            base.method_9(Class518.class337_15);
                        }
                        this.method_163(class2.enum11_0, class2.int_1, class2.byte_4);
                    }
                }
                base.method_9(Class518.class337_12);
            }
        }

        internal void method_157(Class552.Class545 A_1)
        {
            this.method_158(A_1);
            base.method_67(A_1);
            this.method_159(A_1);
        }

        internal void method_158(Class552.Class545 A_1)
        {
            if (Class516.bool_11 && !A_1.Boolean_0)
            {
                this.method_162(A_1.enum11_0, A_1.int_2, A_1.byte_5);
            }
        }

        internal void method_159(Class552.Class545 A_1)
        {
            if (Class516.bool_11)
            {
                base.method_9(Class518.class337_10);
                int num = A_1.short_0;
                if (num > 0)
                {
                    ArrayList list = Class546.class569_0.arrayList_0;
                    int num2 = A_1.int_3;
                    for (int i = 0; i < num; i++)
                    {
                        Class569.Class624 class2 = list[num2 + i] as Class569.Class624;
                        if (i > 0)
                        {
                            base.method_9(Class518.class337_15);
                        }
                        this.method_163(class2.enum11_0, class2.int_0, class2.byte_2);
                    }
                }
                base.method_9(Class518.class337_12);
            }
        }

        internal void method_160(Class547.Class528 A_1, Class548.Class529 A_2)
        {
            base.method_48(A_2);
            base.method_9(Class518.class337_13);
            base.method_9(new Class359(A_1.class369_0));
            if (Class516.bool_11)
            {
                base.method_9(Class518.class337_10);
                int num = A_1.short_2;
                if (num > 0)
                {
                    ArrayList list = Class546.class568_0.arrayList_0;
                    int num2 = A_1.int_6;
                    for (int i = 0; i < num; i++)
                    {
                        Class568.Class623 class2 = list[num2 + i] as Class568.Class623;
                        if (i > 0)
                        {
                            base.method_9(Class518.class337_15);
                        }
                        this.method_163(class2.enum11_0, class2.int_1, class2.byte_4);
                    }
                }
                base.method_9(Class518.class337_12);
            }
        }

        internal void method_161(int A_1)
        {
            Class556.Class601 class2 = Class546.class556_0.arrayList_0[A_1] as Class556.Class601;
            if (Class516.bool_11)
            {
                this.method_162(class2.enum11_0, class2.int_4, class2.byte_4);
            }
            base.method_70(A_1);
            if (Class516.bool_11)
            {
                base.method_9(Class518.class337_10);
                int num = class2.short_0;
                if (num > 0)
                {
                    ArrayList list = Class546.class569_0.arrayList_0;
                    int num2 = class2.int_5;
                    for (int i = 0; i < num; i++)
                    {
                        Class569.Class624 class3 = list[num2 + i] as Class569.Class624;
                        if (i > 0)
                        {
                            base.method_9(Class518.class337_15);
                        }
                        this.method_163(class3.enum11_0, class3.int_0, class3.byte_2);
                    }
                }
                base.method_9(Class518.class337_12);
            }
        }

        private void method_162(Enum11 A_1, int A_2, byte A_3)
        {
            this.method_163(A_1, A_2, A_3);
            base.method_9(Class584.class342_0);
        }

        private void method_163(Enum11 A_1, int A_2, byte A_3)
        {
            switch (A_1)
            {
                case Enum11.const_45:
                case Enum11.const_46:
                    base.method_9(Class518.class337_27);
                    base.method_9(Class585.smethod_0(A_2));
                    return;

                case Enum11.const_47:
                    base.method_9(Class518.class337_28);
                    base.method_9(Class585.smethod_0(A_2));
                    return;
            }
            base.method_93(A_1, A_2, A_3);
        }
    }
}

