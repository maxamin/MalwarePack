namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;

    internal abstract class Class52 : Class51
    {
        protected Class52()
        {
        }

        internal void method_13(Class547.Class528 A_1, Enum2 A_2)
        {
            if (!A_1.Boolean_12)
            {
                Class519.smethod_2(A_1);
                this.method_18(A_1);
                Class520.smethod_2(A_1);
                switch (A_2)
                {
                    case Enum2.const_0:
                        if (!Class521.Boolean_0 || !Class519.class528_0.Boolean_22)
                        {
                            this.method_14(A_1);
                            return;
                        }
                        this.QRZV(A_1);
                        return;

                    case Enum2.const_1:
                        if (!Class521.Boolean_0 || !Class519.class528_0.Boolean_22)
                        {
                            this.method_15(A_1);
                            return;
                        }
                        this.QRZV(A_1);
                        return;

                    case Enum2.const_6:
                        this.method_16(A_1);
                        return;
                }
            }
        }

        private void method_14(Class547.Class528 A_1)
        {
            Class522 class2 = null;
            bool flag = Class516.bool_12;
            if (A_1.Boolean_0)
            {
                if (A_1.Boolean_1)
                {
                    this.method_20(A_1.enum5_0);
                    if (Class516.bool_13)
                    {
                        flag = true;
                    }
                }
                else
                {
                    Class48 data = new Class48(A_1.Byte_0);
                    this.QRWQ(data, A_1);
                    this.method_23(data);
                    this.QRWS();
                    this.QRWR();
                    this.method_19(A_1);
                }
                if (flag)
                {
                    class2 = new Class522(A_1);
                }
            }
            else
            {
                class2 = new Class522(A_1);
                if (A_1.Boolean_1)
                {
                    this.method_20(A_1.enum5_0);
                }
                else
                {
                    try
                    {
                        Class525.smethod_0(A_1);
                        Class526.smethod_0(class2, Enum2.const_0);
                        Class525.smethod_3();
                        MemoryStream stream = new MemoryStream();
                        Class524 class4 = new Class524(stream);
                        Class525.smethod_6(class4);
                        this.method_21(class4);
                        A_1.Byte_0 = stream.ToArray();
                        this.QRVZ();
                        this.QRWR();
                        this.method_19(A_1);
                    }
                    catch (Exception)
                    {
                        A_1.method_1(Enum5.const_7);
                        this.method_20(Enum5.const_7);
                        if (Class516.bool_13)
                        {
                            flag = true;
                        }
                    }
                }
            }
        }

        private void method_15(Class547.Class528 A_1)
        {
            Class522 class2 = new Class522(A_1);
            if (A_1.Boolean_1)
            {
                this.method_20(A_1.enum5_0);
            }
            else
            {
                try
                {
                    Class525.smethod_0(A_1);
                    Class526.smethod_0(class2, Enum2.const_1);
                    Class525.smethod_3();
                    this.QRVZ();
                    this.QRWR();
                }
                catch (Exception)
                {
                    this.method_20(Enum5.const_7);
                }
            }
        }

        private void method_16(Class547.Class528 A_1)
        {
            try
            {
                new Class522(A_1).method_0(base.method_1());
            }
            catch
            {
            }
        }

        internal ArrayList method_17(Class547.Class528 A_1)
        {
            Class519.smethod_2(A_1);
            this.method_18(A_1);
            Class520.smethod_2(A_1);
            if (A_1.Boolean_0)
            {
                Class48 data = new Class48(A_1.Byte_0);
                this.QRWQ(data, A_1);
                this.method_23(data);
                return Class536.arrayList_0;
            }
            this.QRYR(A_1);
            if (A_1.Boolean_1)
            {
                return new ArrayList();
            }
            return Class536.arrayList_0;
        }

        private void method_18(Class547.Class528 A_1)
        {
            A_1.class369_0.QQWT();
        }

        private void method_19(Class547.Class528 A_1)
        {
            if (!A_1.Boolean_2)
            {
                base.method_10(this.QRTX());
                base.method_9(new Class338(Class537.string_184));
            }
        }

        internal void method_20(Enum5 A_1)
        {
            string str;
            if (Class516.enum6_0 == Enum6.flag_4)
            {
                base.int_0--;
                base.method_10(Class538.class339_92);
                base.int_0++;
            }
            base.method_10(this.QRTX());
            switch (A_1)
            {
                case Enum5.const_0:
                    str = Class537.string_741;
                    break;

                case Enum5.const_1:
                    str = Class537.string_373;
                    break;

                case Enum5.const_2:
                    str = Class537.string_441;
                    break;

                case Enum5.const_3:
                    str = Class537.string_99;
                    break;

                case Enum5.const_4:
                    str = Class537.string_154;
                    break;

                case Enum5.const_5:
                    str = Class537.string_591;
                    break;

                case Enum5.const_6:
                    str = Class537.string_917;
                    break;

                case Enum5.const_7:
                    str = Class537.string_384;
                    break;

                default:
                    return;
            }
            base.method_9(new Class338(str));
        }

        private void method_21(Class524 A_1)
        {
            Class398.Class444.smethod_0();
            this.method_22(Class536.arrayList_0);
            A_1.Write((ushort) Class536.arrayList_0.Count);
            for (int i = 0; i < Class536.arrayList_0.Count; i++)
            {
                (Class536.arrayList_0[i] as Class398).method_3(A_1);
            }
            Class398.Class444.class540_1.method_2(A_1);
        }

        private void method_22(ArrayList A_1)
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                Class398 class2 = A_1[i] as Class398;
                class2.ushort_1 = Class398.Class444.UInt16_0;
                ArrayList qQSQ = class2.QQSQ;
                if (qQSQ != null)
                {
                    this.method_22(qQSQ);
                }
            }
        }

        private void method_23(Class48 A_1)
        {
            Class536.smethod_0();
            Class398.Class444.smethod_0();
            ushort num = A_1.method_10();
            for (int i = 0; i < num; i++)
            {
                Class398 class2 = Class541.smethod_1(A_1);
                Class536.arrayList_0.Add(class2);
            }
            Class398.Class444.class540_1.method_3(A_1);
            for (int j = 0; j < Class398.Class444.arrayList_1.Count; j++)
            {
                Class398 class3 = Class398.Class444.arrayList_1[j] as Class398;
                Class398 target = Class398.Class444.arrayList_0[Class398.Class444.class540_0[j]] as Class398;
                class3.QQST(target);
            }
            if (Class398.Class444.class540_1.ushort_1 > 0)
            {
                for (int k = 0; k < Class536.arrayList_0.Count; k++)
                {
                    (Class536.arrayList_0[k] as Class398).method_5();
                }
            }
        }

        internal override void QRYR(Class547.Class528 method)
        {
            if (!method.Boolean_0)
            {
                if (!method.Boolean_12 && !method.Boolean_20)
                {
                    if (method.class369_0.class369_0 is Class371)
                    {
                        method.uint_25 |= 0x10000;
                    }
                    Class519.smethod_2(method);
                    this.method_18(method);
                    Class520.smethod_2(method);
                    Class522 class2 = new Class522(method);
                    if (!method.Boolean_1)
                    {
                        try
                        {
                            Class525.smethod_0(method);
                            Class526.smethod_0(class2, Enum2.const_0);
                            Class525.smethod_3();
                            MemoryStream stream = new MemoryStream();
                            Class524 class3 = new Class524(stream);
                            Class525.smethod_6(class3);
                            this.method_21(class3);
                            method.Byte_0 = stream.ToArray();
                        }
                        catch
                        {
                            method.method_1(Enum5.const_7);
                        }
                    }
                }
                else
                {
                    method.uint_25 |= 0x10000;
                }
            }
        }

        internal override void QRZU(Class397 lines, Class547.Class528 method)
        {
            base.method_0(lines);
            this.method_14(method);
        }
    }
}

