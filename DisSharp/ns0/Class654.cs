namespace ns0
{
    using System;
    using System.Drawing;

    internal class Class654 : Class650
    {
        internal override void QQWX(Class524 writer)
        {
            writer.Write((short) 10);
            for (int i = 0; i < 10; i++)
            {
                Color color = Class863.smethod_1(i);
                bool isKnownColor = color.IsKnownColor;
                writer.Write(isKnownColor);
                if (isKnownColor)
                {
                    writer.Write((short) color.ToKnownColor());
                }
                else
                {
                    writer.Write(color.ToArgb());
                }
            }
        }

        internal override void QQWY(Class656 reader, byte version)
        {
            int num = reader.ReadInt16();
            for (int i = 0; i < num; i++)
            {
                if (reader.ReadBoolean())
                {
                    Class863.smethod_2(i, Color.FromKnownColor((KnownColor) reader.ReadInt16()));
                }
                else
                {
                    Class863.smethod_2(i, Color.FromArgb(reader.ReadInt32()));
                }
            }
            if (version == 1)
            {
            }
        }

        internal override byte Version
        {
            get
            {
                return 1;
            }
        }
    }
}

