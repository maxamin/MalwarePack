namespace ns0
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Security.Cryptography.Xml;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;

    internal class Class1105
    {
        private byte byte_0;
        internal Class1077 class1077_0;
        internal string string_0;
        internal string string_1;

        internal Class1105()
        {
            this.string_0 = "";
            this.string_1 = "";
            this.class1077_0 = new Class1077();
            this.byte_0 = 1;
        }

        internal Class1105(string A_1, string A_2)
        {
            this.string_0 = "";
            this.string_1 = "";
            this.class1077_0 = new Class1077();
            this.byte_0 = 1;
            this.string_0 = A_1;
            this.string_1 = A_2;
        }

        internal bool method_0(Class1105 A_1)
        {
            return this.class1077_0.method_0(A_1.class1077_0);
        }

        internal void method_1(Class524 A_1)
        {
            A_1.Write(this.byte_0);
            A_1.Write(this.string_0);
            A_1.Write(this.string_1);
            this.class1077_0.method_1(A_1);
        }

        internal void method_2(Class656 A_1)
        {
            this.byte_0 = A_1.ReadByte();
            this.string_0 = A_1.ReadString();
            this.string_1 = A_1.ReadString();
            this.class1077_0.method_2(A_1, this.byte_0);
        }

        internal static void smethod_0()
        {
            Class1105 class2 = new Class1105(Class1092.string_0, Class1092.string_1);
            class2.class1077_0.method_3();
            Class703 class3 = new Class703(Enum42.const_4);
            if (class3.method_0(Enum41.const_1) == DialogResult.OK)
            {
                MemoryStream stream = new MemoryStream();
                using (Class524 class4 = new Class524(stream, Encoding.Unicode))
                {
                    class2.method_1(class4);
                }
                byte[] buffer = Class1041.smethod_0(stream);
                using (Stream0 stream2 = new Stream0(class3.String_0, FileMode.Create, FileAccess.Write, FileShare.None, 0x8fff))
                {
                    using (Class524 class5 = new Class524(stream2, Encoding.Default))
                    {
                        class5.Write(buffer);
                    }
                }
            }
        }

        internal static void smethod_1()
        {  // info: edited license information
            try
            {
                Class1102.smethod_1(false);
                Class1102.string_0 = "";
                Class1102.string_1 = "";
            }
            catch
            {
                Class1102.smethod_1(true);
            }
        }

        private static void smethod_2(XmlDocument A_0, int A_1)
        {
            string xmlString = Encoding.UTF8.GetString(Class542.Byte_44);
            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            key.FromXmlString(xmlString);
            SignedXml xml = new SignedXml(A_0);
            XmlNode node = A_0.GetElementsByTagName(Class537.string_569, Class537.string_225)[0];
            xml.LoadXml((XmlElement) node);
            if (xml.CheckSignature(key))
            {
                smethod_3(A_0, A_1);
            }
            else
            {
                Class1102.smethod_1(true);
            }
        }

        private static void smethod_3(XmlDocument A_0, int A_1)
        {
            XmlNode node = A_0.GetElementsByTagName(Class537.string_519)[0];
            byte[] buffer = Convert.FromBase64String(node.InnerText);
            Class1105 class2 = new Class1105();
            Class1105 class3 = new Class1105();
            byte[] buffer2 = buffer;
            if (A_1 < 2)
            {
                buffer2 = Class1041.smethod_2(buffer);
            }
            MemoryStream stream = new MemoryStream(buffer2);
            using (Class656 class4 = new Class656(stream, Encoding.Unicode))
            {
                class2.method_2(class4);
            }
            class3.class1077_0.method_4();
            if (class3.method_0(class2))
            {
                Class1102.smethod_1(false);
                Class1102.string_0 = class2.string_0;
                Class1102.string_1 = class2.string_1;
            }
            else
            {
                Class1102.smethod_1(true);
            }
        }
    }
}

