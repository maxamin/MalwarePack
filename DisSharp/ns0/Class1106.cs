namespace ns0
{
    using System;
    using System.Text;
    using System.Xml;

    internal class Class1106
    {
        internal static XmlDocument smethod_0(byte[] A_0)
        {
            string str = Convert.ToBase64String(A_0);
            XmlDocument document = new XmlDocument();
            document.LoadXml(Class537.string_865);
            XmlNode newChild = document.CreateNode(XmlNodeType.Element, Class537.string_519, "");
            newChild.InnerText = str;
            document.DocumentElement.AppendChild(newChild);
            return document;
        }

        internal static XmlDocument smethod_1(byte[] A_0)
        {
            string xml = Encoding.UTF8.GetString(A_0);
            XmlDocument document = new XmlDocument();
            document.LoadXml(xml);
            return document;
        }
    }
}

