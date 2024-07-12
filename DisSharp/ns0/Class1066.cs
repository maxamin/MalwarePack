namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Resources;
    using System.Text;

    internal class Class1066
    {
        private static ArrayList arrayList_0 = new ArrayList();

        internal static void smethod_0()
        {
            arrayList_0.Clear();
            if (Class546.class579_0.arrayList_0.Count > 1)
            {
                Class619 class2 = Class519.class394_0.class619_0;
                for (int i = 0; i < class2.Int32_0; i++)
                {
                    Class369 class3 = class2[i];
                    string name = class3.Name;
                    if (name == Class537.string_89)
                    {
                        name = "";
                    }
                    else
                    {
                        name = name + Class537.string_857;
                    }
                    for (int j = 0; j < class3.class619_0.Int32_0; j++)
                    {
                        Class369 class4 = class3.class619_0[j];
                        Class1065 class5 = new Class1065();
                        string str2 = class4.Name + Class537.string_8;
                        class5.string_0 = name + str2;
                        class5.string_1 = class3.Name + @"\" + class4.Name + Class537.string_278;
                        arrayList_0.Add(class5);
                    }
                }
            }
        }

        internal static void smethod_1(Class515 A_0, string A_1)
        {
            ArrayList list = Class546.class579_0.arrayList_0;
            if (list.Count > 1)
            {
                string str = null;
                for (int i = 1; i < list.Count; i++)
                {
                    Class579.Class535 class2 = list[i] as Class579.Class535;
                    string str2 = Class519.class581_0[class2.int_0];
                    try
                    {
                        Class1065 class3 = smethod_2(str2);
                        if (class3 != null)
                        {
                            string str3 = A_1 + class3.string_1;
                            if (smethod_4(str3, class2.byte_0))
                            {
                                if (A_0 != null)
                                {
                                    A_0.method_0(str3, Enum64.const_2);
                                }
                            }
                            else
                            {
                                class3 = null;
                            }
                        }
                        if (class3 == null)
                        {
                            if (str == null)
                            {
                                str = Class1014.smethod_2(A_1, Class537.string_268);
                            }
                            string str4 = str + str2;
                            if (A_0 != null)
                            {
                                str4 = A_0.method_0(str4, Enum64.const_2);
                            }
                            smethod_3(str4, class2.byte_0);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private static Class1065 smethod_2(string A_0)
        {
            for (int i = 1; i < arrayList_0.Count; i++)
            {
                Class1065 class2 = arrayList_0[i] as Class1065;
                if (class2.string_0 == A_0)
                {
                    return class2;
                }
            }
            return null;
        }

        private static void smethod_3(string A_0, byte[] A_1)
        {
            try
            {
                using (Stream0 stream = new Stream0(A_0, FileMode.Create, FileAccess.Write, FileShare.None, 0x8fff))
                {
                    using (Class524 class2 = new Class524(stream, Encoding.Default))
                    {
                        class2.Write(A_1);
                    }
                }
            }
            catch
            {
            }
        }

        private static bool smethod_4(string A_0, byte[] A_1)
        {
            bool flag;
            try
            {
                using (MemoryStream stream = new MemoryStream(A_1))
                {
                    using (ResourceReader reader = new ResourceReader(stream))
                    {
                        using (Stream0 stream2 = new Stream0(A_0, FileMode.Create, FileAccess.Write, FileShare.None, 0x8fff))
                        {
                            using (ResXResourceWriter writer = new ResXResourceWriter(stream2))
                            {
                                IDictionaryEnumerator enumerator = reader.GetEnumerator();
                                while (enumerator.MoveNext())
                                {
                                    writer.AddResource((string) enumerator.Key, enumerator.Value);
                                }
                                writer.Generate();
                            }
                            return true;
                        }
                    }
                }
            }
            catch
            {
                flag = false;
            }
            return flag;
        }
    }
}

