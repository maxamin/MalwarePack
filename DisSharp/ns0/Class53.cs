namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;

    internal abstract class Class53 : Class52
    {
        private static ArrayList arrayList_2 = new ArrayList();
        private static ArrayList arrayList_3 = new ArrayList();
        private static ArrayList arrayList_4 = new ArrayList();
        private static ArrayList arrayList_5 = new ArrayList();
        private static ArrayList arrayList_6 = new ArrayList();
        private static string string_0 = Class537.string_850;
        private static string string_1 = Class537.string_807;
        private static string string_10 = Class537.string_423;
        private static string string_11 = Class537.string_120;
        private static string string_2 = Class537.string_930;
        private static string string_3 = Class537.string_63;
        private static string string_4 = Class537.string_75;
        private static string string_5 = Class537.string_218;
        private static string string_6 = Class537.string_578;
        private static string string_7 = Class537.string_495;
        private static string string_8 = Class537.string_812;
        private static string string_9 = Class537.string_105;

        protected Class53()
        {
        }

        private void method_24()
        {
            if (this.method_25())
            {
                this.QRYY();
                if (arrayList_2.Count != 0)
                {
                    this.QRYZ(Class543.smethod_10(Class542.Byte_45));
                    this.method_26(arrayList_2, true);
                }
                if (arrayList_3.Count != 0)
                {
                    this.QRYZ(Class543.smethod_10(Class542.Byte_46));
                    this.method_26(arrayList_3, true);
                }
                else
                {
                    this.QRYZ(Class543.smethod_10(Class542.Byte_46));
                    this.QRZQ();
                }
                if (arrayList_4.Count != 0)
                {
                    this.QRYZ(Class543.smethod_10(Class542.Byte_67));
                    this.method_26(arrayList_4, true);
                }
                if (arrayList_5.Count != 0)
                {
                    this.QRYZ(Class537.string_828);
                    this.method_26(arrayList_5, true);
                }
                if (arrayList_6.Count != 0)
                {
                    this.QRYZ(Class537.string_636);
                    this.method_26(arrayList_6, false);
                }
            }
        }

        private bool method_25()
        {
            arrayList_2.Clear();
            arrayList_3.Clear();
            arrayList_4.Clear();
            arrayList_5.Clear();
            arrayList_6.Clear();
            ArrayList list = Class546.class550_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                string str;
                Class551.Class544 class5;
                Class550.Class514 class2 = list[i] as Class550.Class514;
                if (class2.enum8_0 != Enum8.const_0)
                {
                    str = null;
                    switch (class2.enum7_0)
                    {
                        case Enum7.const_0:
                        {
                            Class547.Class528 class3 = Class546.class547_0.arrayList_0[class2.int_0] as Class547.Class528;
                            Class548.Class529 class4 = (class3.class369_0.class369_0 as Class370).class529_0;
                            str = Class519.class581_0[class4.int_1];
                            goto Label_018D;
                        }
                        case Enum7.const_1:
                        {
                            class5 = Class546.class551_0.arrayList_0[class2.int_0] as Class551.Class544;
                            if (class5.enum9_0 != Enum9.const_2)
                            {
                                goto Label_0139;
                            }
                            Class552.Class545 class6 = Class546.class552_0.arrayList_0[class5.int_0] as Class552.Class545;
                            Class553.Class531 class7 = Class546.class553_0.arrayList_0[class6.int_0] as Class553.Class531;
                            str = Class519.class581_0[class7.int_1];
                            goto Label_018D;
                        }
                    }
                }
                continue;
            Label_0139:
                if (class5.enum9_0 != Enum9.const_3)
                {
                    continue;
                }
                Class547.Class528 class8 = Class546.class547_0.arrayList_0[class5.int_0] as Class547.Class528;
                Class548.Class529 class9 = (class8.class369_0.class369_0 as Class370).class529_0;
                str = Class519.class581_0[class9.int_1];
            Label_018D:
                if (str != null)
                {
                    if (class2.enum8_0 == Enum8.const_2)
                    {
                        if (this.method_27(str))
                        {
                            arrayList_2.Add(class2);
                        }
                        else if (this.method_28(str))
                        {
                            arrayList_3.Add(class2);
                        }
                        else if (this.method_29(str))
                        {
                            arrayList_4.Add(class2);
                        }
                        else
                        {
                            arrayList_5.Add(class2);
                        }
                    }
                    else if (class2.enum8_0 == Enum8.const_1)
                    {
                        arrayList_6.Add(class2);
                    }
                }
            }
            if ((((arrayList_2.Count == 0) && (arrayList_3.Count == 0)) && ((arrayList_4.Count == 0) && (arrayList_5.Count == 0))) && (arrayList_6.Count == 0))
            {
                return false;
            }
            return true;
        }

        private void method_26(ArrayList A_1, bool A_2)
        {
            for (int i = 0; i < A_1.Count; i++)
            {
                Class550.Class514 row = A_1[i] as Class550.Class514;
                this.QRZR(row, A_2);
            }
        }

        private bool method_27(string A_1)
        {
            if ((((A_1 != string_0) && (A_1 != string_1)) && ((A_1 != string_2) && (A_1 != string_3))) && (((A_1 != string_4) && (A_1 != string_5)) && ((A_1 != string_6) && (A_1 != string_7))))
            {
                return false;
            }
            return true;
        }

        private bool method_28(string A_1)
        {
            return (A_1 == string_8);
        }

        private bool method_29(string A_1)
        {
            if (((A_1 != string_9) && (A_1 != string_10)) && (A_1 != string_11))
            {
                return false;
            }
            return true;
        }

        internal override void QRYW(string filepath)
        {
            using (Stream0 stream = new Stream0(filepath, FileMode.Create, FileAccess.Write, FileShare.None, 0xfff))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    Class397 lines = new Class397();
                    this.QRYX(lines);
                    lines.method_13(writer);
                }
            }
        }

        internal override void QRYX(Class397 lines)
        {
            base.method_0(lines);
            this.method_24();
        }
    }
}

