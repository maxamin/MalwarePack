namespace ns0
{
    using System;

    internal abstract class Class77 : Class76
    {
        private Class397 class397_4 = new Class397();

        internal Class77()
        {
            this.class397_4.method_8();
        }

        internal int method_207(uint A_1)
        {
            Class547.Class528 class9;
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            string name = null;
            Class516.Boolean_0 = false;
            Enum0 enum3 = enum2;
            if (enum3 != Enum0.const_6)
            {
                if (enum3 != Enum0.const_10)
                {
                    throw new Exception1();
                }
                Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class2.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                    Class553.Class531 class4 = Class546.class553_0.arrayList_0[class3.int_0] as Class553.Class531;
                    name = base.method_55(class4);
                }
                else
                {
                    if (class2.enum9_0 == Enum9.const_3)
                    {
                        num = class2.int_0;
                        goto Label_0180;
                    }
                    if (class2.enum9_0 != Enum9.const_4)
                    {
                        throw new Exception1();
                    }
                    Class556.Class601 class5 = Class546.class556_0.arrayList_0[class2.int_0] as Class556.Class601;
                    if (class5.int_2 > 0)
                    {
                        Class547.Class528 class6 = Class546.class547_0.arrayList_0[class5.int_2] as Class547.Class528;
                        Class369 class7 = class6.class369_0.class369_0;
                        if (!(class7 is Class370))
                        {
                            class7 = class7.class369_0;
                        }
                        name = class7.Name;
                    }
                    else
                    {
                        Class397 class8 = base.method_1();
                        this.class397_4.Class367_1.method_5();
                        base.method_0(this.class397_4);
                        this.QRUZ(class5.int_1);
                        base.method_0(class8);
                        name = this.class397_4.Class367_1.ToString();
                    }
                }
                goto Label_01B8;
            }
        Label_0180:
            class9 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            Class370 class10 = class9.class369_0.class369_0 as Class370;
            name = base.method_51(class10.class529_0);
        Label_01B8:
            Class516.smethod_0();
            name = base.method_132(name);
            if (!Class525.smethod_4(name))
            {
                int num2 = 1;
                bool flag = true;
                while (true)
                {
                    string str2 = Class525.smethod_5(name, num2);
                    if (Class525.smethod_4(str2))
                    {
                        flag = false;
                    }
                    num2++;
                    if (!flag)
                    {
                        name = str2;
                        break;
                    }
                }
            }
            return Class519.class581_0.method_0(name);
        }
    }
}

