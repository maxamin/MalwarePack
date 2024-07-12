namespace ns0
{
    using System;
    using System.IO;
    using System.Text;

    internal class Class1040
    {
        private const byte byte_0 = 1;

        internal static void smethod_0()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (Class524 class2 = new Class524(stream, Encoding.UTF8))
                {
                    class2.Write((byte) 1);
                    new Class651().method_0(class2);
                    new Class653().method_0(class2);
                    new Class652().method_0(class2);
                    new Class654().method_0(class2);
                    new Class655().method_0(class2);
                    byte[] buffer = Class1041.smethod_0(stream);
                    using (Class987 class3 = Class987.Class987_0.method_0(Class537.string_376))
                    {
                        try
                        {
                            class3.method_2(Class537.string_519, buffer);
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        internal static bool smethod_1()
        {
            byte[] buffer;
            Class987 class2 = Class987.Class987_0.method_0(Class537.string_376);
            try
            {
                buffer = (byte[]) class2.method_1(Class537.string_519, new byte[0]);
                if (buffer.Length == 0)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (class2 != null)
                {
                    class2.Dispose();
                }
            }
            using (MemoryStream stream = new MemoryStream(Class1041.smethod_2(buffer)))
            {
                using (Class656 class3 = new Class656(stream, Encoding.UTF8))
                {
                    try
                    {
                        byte num = class3.ReadByte();
                        new Class651().method_1(class3);
                        new Class653().method_1(class3);
                        new Class652().method_1(class3);
                        new Class654().method_1(class3);
                        new Class655().method_1(class3);
                        if (num == 1)
                        {
                            return true;
                        }
                    }
                    catch (Exception2)
                    {
                    }
                    catch
                    {
                    }
                }
            }
            return true;
        }
    }
}

