namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Xml;

    internal abstract class Class265 : Class264
    {
        protected Class265()
        {
        }

        private void method_891(string A_1, string A_2, byte[] A_3, Class515 A_4)
        {
            XmlNode node;
            XmlNode node2;
            XmlNode node3;
            Stream input = new MemoryStream(A_3);
            XmlTextReader reader = new XmlTextReader(input);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            XmlNode node4 = document.GetElementsByTagName(Class537.string_768)[0];
            ArrayList list = Class546.class554_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class554.Class532 class2 = list[i] as Class554.Class532;
                node = document.CreateNode(XmlNodeType.Element, Class537.string_581, Class537.string_0);
                node.Attributes.Append(document.CreateAttribute(Class537.string_300));
                node.Attributes.Append(document.CreateAttribute(Class537.string_289));
                node.Attributes.Append(document.CreateAttribute(Class537.string_842));
                node.Attributes.Append(document.CreateAttribute(Class537.string_530));
                node.Attributes.Append(document.CreateAttribute(Class537.string_466));
                this.method_892(node, Class537.string_300, Class519.class581_0[class2.int_0] + Class537.string_586);
                this.method_892(node, Class537.string_289, Class519.class581_0[class2.int_0]);
                this.method_892(node, Class537.string_842, Class538.Class539.string_12);
                this.method_892(node, Class537.string_530, Class538.Class539.string_12);
                this.method_892(node, Class537.string_466, Class538.Class539.string_12);
                node4.AppendChild(node);
            }
            XmlNode node5 = document.GetElementsByTagName(Class537.string_903)[0];
            int length = A_1.Length;
            for (int j = 0; j < A_4.stringCollection_1.Count; j++)
            {
                node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
                node.Attributes.Append(document.CreateAttribute(Class537.string_892));
                this.method_892(node, Class537.string_892, A_4.stringCollection_1[j].Substring(length));
                node2 = document.CreateNode(XmlNodeType.Element, Class537.string_162, Class537.string_0);
                node2.InnerText = Class538.Class539.string_12;
                node.AppendChild(node2);
                node3 = document.CreateNode(XmlNodeType.Element, Class537.string_118, Class537.string_0);
                node3.InnerText = Class537.string_514;
                node.AppendChild(node3);
                node5.AppendChild(node);
            }
            for (int k = 0; k < A_4.stringCollection_2.Count; k++)
            {
                node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
                node.Attributes.Append(document.CreateAttribute(Class537.string_892));
                this.method_892(node, Class537.string_892, A_4.stringCollection_2[k].Substring(length));
                node2 = document.CreateNode(XmlNodeType.Element, Class537.string_162, Class537.string_0);
                node2.InnerText = Class538.Class539.string_12;
                node.AppendChild(node2);
                node3 = document.CreateNode(XmlNodeType.Element, Class537.string_118, Class537.string_0);
                node3.InnerText = Class537.string_514;
                node.AppendChild(node3);
                node5.AppendChild(node);
            }
            for (int m = 0; m < A_4.stringCollection_0.Count; m++)
            {
                node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
                node.Attributes.Append(document.CreateAttribute(Class537.string_892));
                this.method_892(node, Class537.string_892, A_4.stringCollection_0[m].Substring(length));
                node2 = document.CreateNode(XmlNodeType.Element, Class537.string_162, Class537.string_0);
                node2.InnerText = Class538.Class539.string_12;
                node.AppendChild(node2);
                node3 = document.CreateNode(XmlNodeType.Element, Class537.string_118, Class537.string_0);
                node3.InnerText = Class537.string_877;
                node.AppendChild(node3);
                node5.AppendChild(node);
            }
            node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
            node.Attributes.Append(document.CreateAttribute(Class537.string_892));
            this.method_892(node, Class537.string_892, A_4.string_0.Substring(length));
            node2 = document.CreateNode(XmlNodeType.Element, Class537.string_162, Class537.string_0);
            node2.InnerText = Class538.Class539.string_12;
            node.AppendChild(node2);
            node3 = document.CreateNode(XmlNodeType.Element, Class537.string_118, Class537.string_0);
            node3.InnerText = Class537.string_877;
            node.AppendChild(node3);
            node5.AppendChild(node);
            document.Save(A_1 + Class519.class394_0.Name + Class537.string_857 + A_2);
        }

        private void method_892(XmlNode A_1, string A_2, string A_3)
        {
            A_1.Attributes.GetNamedItem(A_2).Value = A_3;
        }

        internal override void QRZS(string filepath, Class515 files)
        {
            this.method_891(filepath, Class537.string_668, Class542.Byte_8, files);
        }
    }
}

