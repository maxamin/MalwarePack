namespace ns0
{
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;

    internal abstract class Class67 : Class66
    {
        private ArrayList arrayList_9;
        private bool bool_4;
        private Class397 class397_3 = new Class397();
        private int int_6 = 100;
        private int int_7;
        private Struct1[] struct1_0 = new Struct1[100];

        internal Class67()
        {
            this.class397_3.method_8();
            this.arrayList_9 = new ArrayList();
        }

        internal void method_143(int A_1, long A_2)
        {
            Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_1] as Class548.Class529;
            this.method_147(class2, A_2);
        }

        internal void method_144(int A_1, long A_2)
        {
            Class553.Class531 class2 = Class546.class553_0.arrayList_0[A_1] as Class553.Class531;
            this.method_148(class2, A_2);
        }

        internal void method_145(Enum0 A_1, int A_2, long A_3, bool A_4)
        {
            this.bool_4 = A_4;
            switch (A_1)
            {
                case Enum0.const_1:
                {
                    Class553.Class531 class4 = Class546.class553_0.arrayList_0[A_2] as Class553.Class531;
                    if (!class4.Boolean_2 || (A_3 >= class4.short_1))
                    {
                        this.method_148(class4, A_3);
                        return;
                    }
                    Class564.Class618 class5 = Class546.class564_0.arrayList_0[class4.int_3 + ((int) A_3)] as Class564.Class618;
                    base.method_53(class4);
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class346(class5));
                    return;
                }
                case Enum0.const_2:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_2] as Class548.Class529;
                    if (((class2.class369_0 as Class370).byte_0 & 1) == 0)
                    {
                        this.method_147(class2, A_3);
                        return;
                    }
                    Class549.Class530 class3 = (class2.class369_0.class619_0[(int) A_3] as Class385).class530_0;
                    base.method_48(class2);
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class358(class3.class369_0));
                    return;
                }
            }
        }

        internal void method_146(Enum0 A_1, int A_2, long A_3, bool A_4, bool A_5)
        {
            this.bool_4 = A_5;
            switch (A_1)
            {
                case Enum0.const_1:
                {
                    Class553.Class531 class5 = Class546.class553_0.arrayList_0[A_2] as Class553.Class531;
                    if (!A_4 || (A_3 >= class5.short_1))
                    {
                        this.method_148(class5, A_3);
                        return;
                    }
                    Class564.Class618 class6 = Class546.class564_0.arrayList_0[class5.int_3 + ((int) A_3)] as Class564.Class618;
                    base.method_53(class5);
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class346(class6));
                    return;
                }
                case Enum0.const_2:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_2] as Class548.Class529;
                    if (!A_4)
                    {
                        this.method_147(class2, A_3);
                        return;
                    }
                    Class619 class3 = class2.class369_0.class619_0;
                    int num = (int) A_3;
                    if (num >= class3.Int32_0)
                    {
                        base.method_9(Class585.smethod_0(num));
                        return;
                    }
                    Class549.Class530 class4 = (class3[num] as Class385).class530_0;
                    if (class4.enum11_0 == Enum11.const_43)
                    {
                        this.method_147(class2, A_3);
                        return;
                    }
                    base.method_48(class2);
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class358(class4.class369_0));
                    return;
                }
            }
        }

        private void method_147(Class548.Class529 A_1, long A_2)
        {
            long num = 0L;
            this.method_149();
            Class619 class2 = A_1.class369_0.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                Class549.Class530 class3 = (class2[i] as Class385).class530_0;
                Class560.Class610 class4 = Class546.class560_0.arrayList_0[class3.int_2] as Class560.Class610;
                switch (class4.enum11_1)
                {
                    case Enum11.const_18:
                    case Enum11.const_19:
                    case Enum11.const_20:
                    case Enum11.const_21:
                    case Enum11.const_22:
                        num = class4.int_1;
                        break;

                    case Enum11.const_23:
                        num = (Class546.class565_0.arrayList_0[class4.int_1] as Class565.Class620).uint_0;
                        break;

                    case Enum11.const_24:
                        num = (Class546.class566_0.arrayList_0[class4.int_1] as Class566.Class621).long_0;
                        break;

                    case Enum11.const_25:
                        num = (long) (Class546.class567_0.arrayList_0[class4.int_1] as Class567.Class622).ulong_0;
                        break;
                }
                if (num == A_2)
                {
                    base.method_48(A_1);
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class358(class3.class369_0));
                    return;
                }
                this.method_153(class3, num);
            }
            if ((A_2 == 0L) && !this.method_150())
            {
                this.QRUW(0);
            }
            else
            {
                this.arrayList_9.Clear();
                long num3 = A_2;
                for (int j = 0; j < this.int_7; j++)
                {
                    long num5 = this.struct1_0[j].long_0;
                    if ((num5 != 0L) && ((num5 & num3) == num5))
                    {
                        num3 -= num5;
                        this.arrayList_9.Add(new Class358(this.struct1_0[j].class530_0.class369_0));
                    }
                }
                if (this.arrayList_9.Count == 0)
                {
                    this.QRUW((int) A_2);
                }
                else
                {
                    this.class397_3.Class367_0.method_5();
                    Class612.smethod_0(this.class397_3, A_1);
                    if (!this.bool_4 && (this.arrayList_9.Count > 1))
                    {
                        base.method_9(Class518.class337_10);
                    }
                    for (int k = 0; k < this.arrayList_9.Count; k++)
                    {
                        if (k > 0)
                        {
                            this.QRUS(Enum1.const_3);
                        }
                        base.method_3(this.class397_3.Class367_0);
                        base.method_9(Class518.class337_13);
                        base.method_9(this.arrayList_9[k] as Class335);
                    }
                    if (!this.bool_4 && (this.arrayList_9.Count > 1))
                    {
                        base.method_9(Class518.class337_12);
                    }
                }
            }
        }

        private void method_148(Class553.Class531 A_1, long A_2)
        {
            long num = 0L;
            this.method_149();
            ArrayList list = Class546.class564_0.arrayList_0;
            int num2 = A_1.int_3;
            for (int i = 0; i < A_1.short_1; i++)
            {
                Class564.Class618 class2 = list[num2 + i] as Class564.Class618;
                switch (class2.enum11_0)
                {
                    case Enum11.const_18:
                    case Enum11.const_19:
                    case Enum11.const_20:
                    case Enum11.const_21:
                    case Enum11.const_22:
                        num = class2.int_1;
                        break;

                    case Enum11.const_23:
                        num = (Class546.class565_0.arrayList_0[class2.int_1] as Class565.Class620).uint_0;
                        break;

                    case Enum11.const_24:
                        num = (Class546.class566_0.arrayList_0[class2.int_1] as Class566.Class621).long_0;
                        break;

                    case Enum11.const_25:
                        num = (long) (Class546.class567_0.arrayList_0[class2.int_1] as Class567.Class622).ulong_0;
                        break;
                }
                if (num == A_2)
                {
                    base.method_53(A_1);
                    base.method_9(Class518.class337_13);
                    base.method_9(new Class346(class2));
                    return;
                }
                this.method_152(class2, num);
            }
            if ((A_2 == 0L) && !this.method_150())
            {
                this.QRUW(0);
            }
            else
            {
                this.arrayList_9.Clear();
                long num4 = A_2;
                for (int j = 0; j < this.int_7; j++)
                {
                    long num6 = this.struct1_0[j].long_0;
                    if ((num6 != 0L) && ((num6 & num4) == num6))
                    {
                        num4 -= num6;
                        this.arrayList_9.Add(new Class346(this.struct1_0[j].class618_0));
                    }
                }
                if (this.arrayList_9.Count == 0)
                {
                    this.QRUW((int) A_2);
                }
                else
                {
                    this.class397_3.Class367_0.method_5();
                    Class612.smethod_5(this.class397_3, A_1);
                    if (!this.bool_4 && (this.arrayList_9.Count > 1))
                    {
                        base.method_9(Class518.class337_10);
                    }
                    for (int k = 0; k < this.arrayList_9.Count; k++)
                    {
                        if (k > 0)
                        {
                            this.QRUS(Enum1.const_3);
                        }
                        base.method_3(this.class397_3.Class367_0);
                        base.method_9(Class518.class337_13);
                        base.method_9(this.arrayList_9[k] as Class335);
                    }
                    if (!this.bool_4 && (this.arrayList_9.Count > 1))
                    {
                        base.method_9(Class518.class337_12);
                    }
                }
            }
        }

        private void method_149()
        {
            this.int_7 = 0;
        }

        private bool method_150()
        {
            for (int i = 0; i < this.int_7; i++)
            {
                if (this.struct1_0[i].long_0 == 0L)
                {
                    return true;
                }
            }
            return false;
        }

        private void method_151()
        {
            if (this.int_7 >= this.int_6)
            {
                this.int_6 *= 2;
                Struct1[] structArray = this.struct1_0;
                this.struct1_0 = new Struct1[this.int_6];
                for (int i = 0; i < (this.int_7 - 1); i++)
                {
                    this.struct1_0[i] = structArray[i];
                }
            }
        }

        private void method_152(Class564.Class618 A_1, long A_2)
        {
            int index = this.int_7;
            this.int_7++;
            this.method_151();
            this.struct1_0[index].class618_0 = A_1;
            this.struct1_0[index].long_0 = A_2;
        }

        private void method_153(Class549.Class530 A_1, long A_2)
        {
            int index = this.int_7;
            this.int_7++;
            this.method_151();
            this.struct1_0[index].class530_0 = A_1;
            this.struct1_0[index].long_0 = A_2;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct1
        {
            internal long long_0;
            internal Class549.Class530 class530_0;
            internal Class564.Class618 class618_0;
        }
    }
}

