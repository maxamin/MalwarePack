namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class652 : Class650
    {
        internal override void QQWX(Class524 writer)
        {
            writer.Write(Class516.bool_1);
            if (Class516.bool_1)
            {
                TreeNodeCollection nodes = Class698.class582_0.class686_0.class802_0.Nodes;
                int num = (nodes.Count <= Class516.int_0) ? nodes.Count : Class516.int_0;
                writer.Write((short) num);
                for (int i = 0; i < num; i++)
                {
                    Class394 class2 = (nodes[i] as Class686.Class687).class369_0 as Class394;
                    writer.Write(class2.string_2);
                }
            }
            writer.Write((short) Class516.int_0);
        }

        internal override void QQWY(Class656 reader, byte version)
        {
            Class516.bool_1 = reader.ReadBoolean();
            if (Class516.bool_1)
            {
                int num = reader.ReadInt16();
                for (int i = 0; i < num; i++)
                {
                    Class698.class582_0.class921_0.StringCollection_0.Add(reader.ReadString());
                }
            }
            if (version != 1)
            {
                Class516.int_0 = reader.ReadInt16();
                if (version == 2)
                {
                }
            }
        }

        internal override byte Version
        {
            get
            {
                return 2;
            }
        }
    }
}

