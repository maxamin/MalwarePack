namespace ns0
{
    using Crownwood.DotNetMagic.Common;
    using DisSharp;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class Class516
    {
        internal static bool bool_0 = true;
        internal static bool bool_1 = true;
        internal static bool bool_10 = false;
        internal static bool bool_11 = true;
        internal static bool bool_12 = false;
        internal static bool bool_13 = false;
        internal static bool bool_14 = true;
        internal static bool bool_15 = true;
        internal static bool bool_16 = false;
        internal static bool bool_17 = false;
        internal static bool bool_18 = false;
        internal static bool bool_19 = false;
        internal static bool bool_2 = true;
        internal static bool bool_20 = false;
        internal static bool bool_21 = false;
        private static bool bool_22 = false;
        private static bool bool_23;
        internal static bool bool_24 = false;
        internal static bool bool_3 = false;
        internal static bool bool_4 = false;
        internal static bool bool_5 = false;
        internal static bool bool_6 = false;
        internal static bool bool_7 = false;
        internal static bool bool_8 = true;
        internal static bool bool_9 = true;
        internal static Enum6 enum6_0 = Enum6.flag_1;
        internal static float float_0 = 8.25f;
        internal static float float_1 = 11f;
        internal static int int_0 = 0x10;
        internal static int int_1 = 9;
        internal static int int_2 = 4;
        internal static int int_3 = 4;
        internal static int int_4 = 4;
        internal static int int_5 = 4;
        internal static int int_6 = 4;
        internal static int int_7 = 2;
        internal static int int_8 = 2;
        internal static int int_9 = 10;
        internal static string string_0 = "Microsoft Sans Serif";
        internal static string string_1 = "Courier New";
        internal static VisualStyle visualStyle_0 = VisualStyle.IDE2005;

        internal static void smethod_0()
        {
            bool_22 = bool_23;
        }

        internal static void smethod_1(OptionsObject A_0)
        {
            try
            {
                A_0.TabSpaceCSharp = int_3;
                A_0.TabSpaceVB = int_6;
                A_0.TabSpaceDelphi = int_7;
                A_0.TabSpaceChrome = int_8;
                A_0.MinEditorLength = int_9;
                A_0.UnicodeChars = bool_8;
                A_0.EmptyLines = bool_9;
                A_0.SingleStatementBrace = bool_10;
                A_0.Full = bool_14;
                A_0.Short = bool_15;
                A_0.Raw = bool_16;
                A_0.Outline = bool_20;
                A_0.Assembler = bool_21;
                A_0.InterfacePublic = bool_17;
                A_0.InterfacePlusProtected = bool_18;
                A_0.InterfacePlusPlusInternal = bool_19;
                A_0.FullNames = Boolean_0;
                A_0.HexValues = bool_4;
                A_0.TypeDetail = bool_11;
                A_0.SameWindow = bool_5;
                A_0.AutoDecompile = bool_6;
                A_0.RecentFiles = int_1;
                A_0.VisualStyle = visualStyle_0;
                A_0.AutoLoad = bool_1;
                A_0.MaxAutoLoad = int_0;
                A_0.PDBAutoLoad = bool_2;
                A_0.XmlDocAutoLoad = bool_3;
                A_0.TreeFont = new FontObject(string_0, float_0, false);
                A_0.TextFont = new FontObject(string_1, float_1, true);
                A_0.SplitterWidth = Class698.class582_0.mainForm_0.splitter.Width;
            }
            catch
            {
            }
        }

        internal static void smethod_2(OptionsObject A_0)
        {
            try
            {
                A_0.TabSpaceCSharp = 4;
                A_0.TabSpaceVB = 4;
                A_0.TabSpaceDelphi = 2;
                A_0.TabSpaceChrome = 2;
                A_0.MinEditorLength = 10;
                A_0.UnicodeChars = true;
                A_0.EmptyLines = true;
                A_0.SingleStatementBrace = false;
                A_0.VisualStyle = VisualStyle.IDE2005;
                A_0.RecentFiles = 9;
                A_0.AutoLoad = true;
                A_0.MaxAutoLoad = 0x10;
                A_0.PDBAutoLoad = true;
                A_0.XmlDocAutoLoad = false;
                A_0.TreeFont = new FontObject("Microsoft Sans Serif", 8.25f, false);
                A_0.TextFont = new FontObject("Courier New", 11f, true);
            }
            catch
            {
            }
        }

        internal static void smethod_3(OptionsObject A_0)
        {
            try
            {
                if ((A_0.TabSpaceCSharp > 0) && (A_0.TabSpaceCSharp < 0x65))
                {
                    int_3 = A_0.TabSpaceCSharp;
                }
                if ((A_0.TabSpaceVB > 0) && (A_0.TabSpaceVB < 0x65))
                {
                    int_6 = A_0.TabSpaceVB;
                }
                if ((A_0.TabSpaceDelphi > 0) && (A_0.TabSpaceDelphi < 0x65))
                {
                    int_7 = A_0.TabSpaceDelphi;
                }
                if ((A_0.TabSpaceChrome > 0) && (A_0.TabSpaceChrome < 0x65))
                {
                    int_8 = A_0.TabSpaceChrome;
                }
                if ((A_0.MinEditorLength > 0) && (A_0.MinEditorLength < 0x29))
                {
                    int_9 = A_0.MinEditorLength;
                }
                bool_8 = A_0.UnicodeChars;
                bool_9 = A_0.EmptyLines;
                bool_10 = A_0.SingleStatementBrace;
                bool_14 = A_0.Full;
                bool_15 = A_0.Short;
                bool_16 = A_0.Raw;
                bool_20 = A_0.Outline;
                bool_21 = A_0.Assembler;
                bool_17 = A_0.InterfacePublic;
                bool_18 = A_0.InterfacePlusProtected;
                bool_19 = A_0.InterfacePlusPlusInternal;
                Boolean_0 = A_0.FullNames;
                bool_4 = A_0.HexValues;
                bool_11 = A_0.TypeDetail;
                bool_5 = A_0.SameWindow;
                bool_6 = A_0.AutoDecompile;
                visualStyle_0 = A_0.VisualStyle;
                if ((A_0.RecentFiles > 0) && (A_0.RecentFiles < 0x65))
                {
                    int_1 = A_0.RecentFiles;
                }
                bool_1 = A_0.AutoLoad;
                int_0 = A_0.MaxAutoLoad;
                bool_2 = A_0.PDBAutoLoad;
                bool_3 = A_0.XmlDocAutoLoad;
                string_0 = A_0.TreeFont.string_0;
                float_0 = A_0.TreeFont.float_0;
                string_1 = A_0.TextFont.string_0;
                float_1 = A_0.TextFont.float_0;
                Class698.class582_0.mainForm_0.splitter.Width = A_0.SplitterWidth;
            }
            catch
            {
            }
        }

        internal static void smethod_4()
        {
            Class582 class2 = Class698.class582_0;
            try
            {
                smethod_5(visualStyle_0);
                Class705.class705_11.QQTR();
                Class705.class705_12.QQTR();
                Class705.class705_13.QQTR();
                Class705.class705_14.QQTR();
                Class705.class705_15.QQTR();
                Class705.class705_16.QQTR();
                class2.class686_0.class802_0.Font = new Font(string_0, float_0);
                class2.class686_0.class802_0.BackColor = Class863.smethod_1(0);
                class2.class686_0.class802_0.ForeColor = Class863.smethod_1(1);
                Class935.smethod_7();
            }
            catch
            {
            }
        }

        private static void smethod_5(VisualStyle A_0)
        {
            switch (A_0)
            {
                case VisualStyle.Plain:
                    ToolStripManager.RenderMode = ToolStripManagerRenderMode.System;
                    break;

                case VisualStyle.Office2003:
                    ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
                    break;

                case VisualStyle.IDE2005:
                {
                    ProfessionalColorTable professionalColorTable = new ProfessionalColorTable {
                        UseSystemColors = true
                    };
                    ToolStripManager.Renderer = new ToolStripProfessionalRenderer(professionalColorTable);
                    break;
                }
            }
            Class698.class582_0.class891_0.tabControl_0.Style = A_0;
            Class698.class582_0.mainForm_0.statusBar.Style = A_0;
        }

        internal static bool Boolean_0
        {
            get
            {
                return bool_22;
            }
            set
            {
                bool_23 = bool_22;
                bool_22 = value;
            }
        }
    }
}

