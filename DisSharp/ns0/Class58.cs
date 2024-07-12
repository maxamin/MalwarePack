namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Xml;

    internal abstract class Class58 : Class57
    {
        protected Class58()
        {
        }

        private void method_35(string A_1, string A_2, byte[] A_3, Class515 A_4)
        {
            Stream input = new MemoryStream(A_3);
            XmlTextReader reader = new XmlTextReader(input);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            XmlNode node2 = document.DocumentElement.ChildNodes[0];
            XmlNode node3 = node2.ChildNodes[0];
            XmlNode node4 = node2.ChildNodes[1];
            this.method_38(node2, Class537.string_256, Class518.class337_3 + Guid.NewGuid().ToString() + Class518.class337_5);
            XmlNode node5 = node3.ChildNodes[0];
            this.method_38(node5, Class537.string_677, A_4.string_1);
            this.method_38(node5, Class537.string_598, Class519.class394_0.Name);
            this.method_38(node5, Class537.string_449, "");
            if (Class519.class394_0.bool_1)
            {
                this.method_38(node5, Class537.string_113, Class537.string_315);
            }
            else
            {
                this.method_38(node5, Class537.string_113, Class537.string_533);
            }
            XmlNode node6 = node3.ChildNodes[1];
            ArrayList list = Class546.class554_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class554.Class532 class2 = list[i] as Class554.Class532;
                XmlNode node7 = document.CreateNode(XmlNodeType.Element, Class537.string_581, Class537.string_0);
                node7.Attributes.Append(document.CreateAttribute(Class537.string_364));
                node7.Attributes.Append(document.CreateAttribute(Class537.string_598));
                this.method_38(node7, Class537.string_364, Class519.class581_0[class2.int_0]);
                this.method_38(node7, Class537.string_598, Class519.class581_0[class2.int_0]);
                node6.AppendChild(node7);
            }
            int length = A_1.Length;
            XmlNode node8 = node4.ChildNodes[0];
            for (int j = 0; j < A_4.stringCollection_1.Count; j++)
            {
                this.method_37(document, node8, Class537.string_134, A_4.stringCollection_1[j].Substring(length));
            }
            for (int k = 0; k < A_4.stringCollection_2.Count; k++)
            {
                this.method_37(document, node8, Class537.string_514, A_4.stringCollection_2[k].Substring(length));
            }
            this.method_37(document, node8, Class537.string_877, A_4.string_0.Substring(length - 1));
            for (int m = 0; m < A_4.stringCollection_0.Count; m++)
            {
                this.method_37(document, node8, Class537.string_877, A_4.stringCollection_0[m].Substring(length));
            }
            document.Save(A_1 + Class519.class394_0.Name + Class537.string_857 + A_2);
        }

        private string method_36()
        {
            if (Class519.class394_0.int_1 != 0)
            {
                Class547.Class528 class2 = Class546.class547_0.arrayList_0[Class519.class394_0.int_1] as Class547.Class528;
                return class2.class369_0.class369_0.Name;
            }
            return Class537.string_0;
        }

        private void method_37(XmlDocument A_1, XmlNode A_2, string A_3, string A_4)
        {
            XmlNode node = A_1.CreateNode(XmlNodeType.Element, Class537.string_510, "");
            node.Attributes.Append(A_1.CreateAttribute(Class537.string_860));
            node.Attributes.Append(A_1.CreateAttribute(Class537.string_118));
            if (A_4.StartsWith(@"\"))
            {
                this.method_38(node, Class537.string_860, A_4.Substring(1));
            }
            else
            {
                this.method_38(node, Class537.string_860, A_4);
            }
            this.method_38(node, Class537.string_118, A_3);
            A_2.AppendChild(node);
        }

        private void method_38(XmlNode A_1, string A_2, string A_3)
        {
            A_1.Attributes.GetNamedItem(A_2).Value = A_3;
        }

        internal override void QRZS(string filepath, Class515 files)
        {
            switch (Class516.enum6_0)
            {
                case Enum6.flag_1:
                    this.method_35(filepath, Class537.string_307, Class542.Byte_21, files);
                    break;

                case Enum6.flag_3:
                    this.method_35(filepath, Class537.string_511, Class542.Byte_25, files);
                    break;
            }
        }
    }
}

