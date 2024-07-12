namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class651 : Class650
    {
        internal override void QQWX(Class524 writer)
        {
            MainForm form = Class698.class582_0.mainForm_0;
            writer.Write((short) form.panelLeft.Width);
            writer.Write((short) form.Left);
            writer.Write((short) form.Top);
            writer.Write((short) form.Width);
            writer.Write((short) form.Height);
            writer.Write(form.WindowState == FormWindowState.Maximized);
            writer.Write((short) form.splitter.Width);
        }

        internal override void QQWY(Class656 reader, byte version)
        {
            MainForm form = Class698.class582_0.mainForm_0;
            form.panelLeft.Width = reader.ReadInt16();
            form.Left = reader.ReadInt16();
            form.Top = reader.ReadInt16();
            form.Width = reader.ReadInt16();
            form.Height = reader.ReadInt16();
            form.WindowState = reader.ReadBoolean() ? FormWindowState.Maximized : form.WindowState;
            if (version != 1)
            {
                form.splitter.Width = reader.ReadInt16();
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

