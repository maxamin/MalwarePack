namespace ns0
{
    using Crownwood.DotNetMagic.Common;
    using System;

    internal class Class653 : Class650
    {
        internal override void QQWX(Class524 writer)
        {
            writer.Write(Class516.bool_0);
            writer.Write(Class516.bool_2);
            writer.Write(Class516.Boolean_0);
            writer.Write(Class516.bool_4);
            writer.Write(Class516.bool_11);
            writer.Write(Class516.bool_5);
            writer.Write(Class516.bool_6);
            writer.Write(Class516.bool_14);
            writer.Write(Class516.bool_15);
            writer.Write(Class516.bool_16);
            writer.Write(Class516.bool_20);
            writer.Write(Class516.bool_21);
            writer.Write((short) Class516.int_2);
            writer.Write((short) Class516.int_9);
            writer.Write(Class516.bool_8);
            writer.Write(Class516.bool_9);
            writer.Write(Class516.bool_10);
            writer.Write(Class516.string_0);
            writer.Write(Class516.float_0);
            writer.Write(Class516.string_1);
            writer.Write(Class516.float_1);
            writer.Write((int) Class516.enum6_0);
            writer.Write(Class516.bool_3);
            writer.Write((short) Class516.int_7);
            writer.Write((short) Class516.int_3);
            writer.Write((short) Class516.int_6);
            writer.Write((short) Class516.int_4);
            writer.Write((short) Class516.int_5);
            writer.Write((short) Class516.int_8);
            writer.Write(Class516.bool_17);
            writer.Write(Class516.bool_18);
            writer.Write(Class516.bool_19);
            writer.Write((byte) Class516.visualStyle_0);
        }

        internal override void QQWY(Class656 reader, byte version)
        {
            Class516.bool_0 = reader.ReadBoolean();
            Class516.bool_2 = reader.ReadBoolean();
            Class516.Boolean_0 = reader.ReadBoolean();
            Class516.bool_4 = reader.ReadBoolean();
            Class516.bool_11 = reader.ReadBoolean();
            Class516.bool_5 = reader.ReadBoolean();
            Class516.bool_6 = reader.ReadBoolean();
            Class516.bool_14 = reader.ReadBoolean();
            Class516.bool_15 = reader.ReadBoolean();
            Class516.bool_16 = reader.ReadBoolean();
            Class516.bool_20 = reader.ReadBoolean();
            Class516.bool_21 = reader.ReadBoolean();
            Class516.int_2 = reader.ReadInt16();
            Class516.int_9 = reader.ReadInt16();
            Class516.bool_8 = reader.ReadBoolean();
            Class516.bool_9 = reader.ReadBoolean();
            Class516.bool_10 = reader.ReadBoolean();
            Class516.string_0 = reader.ReadString();
            Class516.float_0 = reader.ReadSingle();
            Class516.string_1 = reader.ReadString();
            Class516.float_1 = reader.ReadSingle();
            if (version != 1)
            {
                Class516.enum6_0 = (Enum6) reader.ReadInt32();
                if (version != 2)
                {
                    Class516.bool_3 = reader.ReadBoolean();
                    if (version != 3)
                    {
                        Class516.int_7 = reader.ReadInt16();
                        if (version != 4)
                        {
                            Class516.int_3 = reader.ReadInt16();
                            Class516.int_6 = reader.ReadInt16();
                            if (version != 5)
                            {
                                Class516.int_4 = reader.ReadInt16();
                                Class516.int_5 = reader.ReadInt16();
                                Class516.int_8 = reader.ReadInt16();
                                if (version != 6)
                                {
                                    Class516.bool_17 = reader.ReadBoolean();
                                    Class516.bool_18 = reader.ReadBoolean();
                                    Class516.bool_19 = reader.ReadBoolean();
                                    if (version != 7)
                                    {
                                        Class516.visualStyle_0 = (VisualStyle) reader.ReadByte();
                                        if (version == 8)
                                        {
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        internal override byte Version
        {
            get
            {
                return 8;
            }
        }
    }
}

