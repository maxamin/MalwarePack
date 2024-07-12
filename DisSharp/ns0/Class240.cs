namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Text;
    using System.Xml;

    internal abstract class Class240 : Class239
    {
        protected Class240()
        {
        }

        private void method_891(string A_1, string A_2, byte[] A_3, Class515 A_4)
        {
            XmlNode node;
            string str;
            Stream input = new MemoryStream(A_3);
            XmlTextReader reader = new XmlTextReader(input);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            XmlNode node2 = document.GetElementsByTagName(Class537.string_19)[0];
            ArrayList list = Class546.class554_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class554.Class532 class2 = list[i] as Class554.Class532;
                node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
                node.Attributes.Append(document.CreateAttribute(Class537.string_892));
                node.Attributes.Append(document.CreateAttribute(Class537.string_664));
                node.Attributes.Append(document.CreateAttribute(Class537.string_684));
                node.Attributes.Append(document.CreateAttribute(Class537.string_598));
                node.Attributes.Append(document.CreateAttribute(Class537.string_550));
                node.Attributes.Append(document.CreateAttribute(Class537.string_400));
                this.method_892(node, Class537.string_892, Class519.class581_0[class2.int_0] + Class537.string_586);
                this.method_892(node, Class537.string_664, Class537.string_932);
                this.method_892(node, Class537.string_684, Class519.class581_0[class2.int_0]);
                this.method_892(node, Class537.string_598, Class519.class581_0[class2.int_0]);
                this.method_892(node, Class537.string_550, class2.method_0());
                this.method_892(node, Class537.string_400, Class538.Class539.string_12);
                node2.AppendChild(node);
            }
            int length = A_1.Length;
            for (int j = 0; j < A_4.stringCollection_1.Count; j++)
            {
                node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
                node.Attributes.Append(document.CreateAttribute(Class537.string_892));
                node.Attributes.Append(document.CreateAttribute(Class537.string_664));
                node.Attributes.Append(document.CreateAttribute(Class537.string_684));
                str = A_4.stringCollection_1[j].Substring(length);
                this.method_892(node, Class537.string_892, str);
                this.method_892(node, Class537.string_664, Path.GetExtension(str).Substring(1));
                this.method_892(node, Class537.string_684, Path.GetFileNameWithoutExtension(str));
                node2.AppendChild(node);
            }
            for (int k = 0; k < A_4.stringCollection_2.Count; k++)
            {
                node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
                node.Attributes.Append(document.CreateAttribute(Class537.string_892));
                node.Attributes.Append(document.CreateAttribute(Class537.string_664));
                node.Attributes.Append(document.CreateAttribute(Class537.string_684));
                str = A_4.stringCollection_2[k].Substring(length);
                this.method_892(node, Class537.string_892, str);
                this.method_892(node, Class537.string_664, Path.GetExtension(str).Substring(1));
                this.method_892(node, Class537.string_684, Path.GetFileNameWithoutExtension(str));
                node2.AppendChild(node);
            }
            for (int m = 0; m < A_4.stringCollection_0.Count; m++)
            {
                node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
                node.Attributes.Append(document.CreateAttribute(Class537.string_892));
                node.Attributes.Append(document.CreateAttribute(Class537.string_664));
                node.Attributes.Append(document.CreateAttribute(Class537.string_684));
                str = A_4.stringCollection_0[m].Substring(length);
                this.method_892(node, Class537.string_892, str);
                this.method_892(node, Class537.string_664, Class537.string_0);
                this.method_892(node, Class537.string_684, Path.GetFileNameWithoutExtension(str));
                node2.AppendChild(node);
            }
            node = document.CreateNode(XmlNodeType.Element, Class537.string_510, Class537.string_0);
            node.Attributes.Append(document.CreateAttribute(Class537.string_892));
            node.Attributes.Append(document.CreateAttribute(Class537.string_664));
            node.Attributes.Append(document.CreateAttribute(Class537.string_684));
            str = A_4.string_0.Substring(length);
            this.method_892(node, Class537.string_892, str);
            this.method_892(node, Class537.string_664, Class537.string_0);
            this.method_892(node, Class537.string_684, Path.GetFileNameWithoutExtension(str));
            node2.AppendChild(node);
            XmlNode node3 = document.GetElementsByTagName(Class537.string_674)[0];
            node3 = node3.ChildNodes[0];
            node3.InnerText = Class519.class394_0.Name + Class537.string_224;
            document.Save(A_1 + Class519.class394_0.Name + Class537.string_857 + A_2);
        }

        private void method_892(XmlNode A_1, string A_2, string A_3)
        {
            A_1.Attributes.GetNamedItem(A_2).Value = A_3;
        }

        private void method_893(string A_1, Class515 A_2)
        {
            Class397 class2 = new Class397();
            if (Class519.class394_0.bool_1)
            {
                class2.method_11(Class538.class339_155);
            }
            else
            {
                class2.method_11(Class538.class339_178);
            }
            class2.method_10(new Class336(Class519.class394_0.string_0));
            class2.method_10(Class518.class337_19);
            class2.method_8();
            class2.method_11(Class538.class339_211);
            class2.int_0++;
            int length = A_1.Length;
            for (int i = 0; i < A_2.stringCollection_0.Count; i++)
            {
                string path = A_2.stringCollection_0[i].Substring(length);
                class2.method_11(new Class336(Path.GetFileNameWithoutExtension(path)));
                class2.method_10(Class538.class339_140);
                class2.method_10(Class518.class337_1);
                class2.method_10(new Class336(path));
                class2.method_10(Class518.class337_1);
                if (i < (A_2.stringCollection_0.Count - 1))
                {
                    class2.method_10(Class518.class337_14);
                }
                else
                {
                    class2.method_10(Class518.class337_19);
                }
            }
            class2.int_0--;
            class2.method_8();
            if (!Class519.class394_0.bool_1 && (Class519.class394_0.int_1 != 0))
            {
                class2.int_0++;
                Class547.Class528 class3 = Class546.class547_0.arrayList_0[Class519.class394_0.int_1] as Class547.Class528;
                Class846.smethod_3(class2, class3);
                class2.int_0--;
            }
            class2.method_11(Class538.class339_116);
            class2.method_10(Class518.class337_13);
            using (Stream0 stream = new Stream0(A_1 + Class519.class394_0.Name + Class537.string_224, FileMode.Create, FileAccess.Write, FileShare.None, 0xfff))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.Default))
                {
                    class2.method_13(writer);
                }
            }
        }

        internal override void QRZS(string filepath, Class515 files)
        {
            this.method_891(filepath, Class537.string_901, Class542.Byte_70, files);
            this.method_893(filepath, files);
        }
    }
}

