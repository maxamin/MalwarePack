namespace DisSharp
{
    using Crownwood.DotNetMagic.Common;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Design;

    [DefaultProperty("CommentColor")]
    public class OptionsObject
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_10;
        private bool bool_11;
        private bool bool_12;
        private bool bool_13;
        private bool bool_14;
        private bool bool_15;
        private bool bool_16;
        private bool bool_17;
        private bool bool_18;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        private bool bool_7;
        private bool bool_8;
        private bool bool_9;
        private Color color_0;
        private Color color_1;
        private Color color_2;
        private Color color_3;
        private Color color_4;
        private Color color_5;
        private Color color_6;
        private Color color_7;
        private Color color_8;
        private Color color_9;
        private FontObject fontObject_0;
        private FontObject fontObject_1;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private int int_5;
        private int int_6;
        private int int_7;
        private Crownwood.DotNetMagic.Common.VisualStyle visualStyle_0;

        [Category("Save Source"), DisplayName("Assembler"), Description("Indicates whether to save the pseudo assembler code.")]
        public bool Assembler
        {
            get
            {
                return this.bool_13;
            }
            set
            {
                this.bool_13 = value;
            }
        }

        [Category("View"), Description("Forces to decompile method when tree item is selected. Code appears in the same window"), DisplayName("Auto Decompile")]
        public bool AutoDecompile
        {
            get
            {
                return this.bool_15;
            }
            set
            {
                this.bool_15 = value;
            }
        }

        [Category("Application"), Description("Indicates whether the auto load of last projects option is turned on."), DisplayName("Auto Load")]
        public bool AutoLoad
        {
            get
            {
                return this.bool_16;
            }
            set
            {
                this.bool_16 = value;
            }
        }

        [Category("Appearance"), Description("The commentary color of the text."), DisplayName("Commentary Color")]
        public virtual Color CommentColor
        {
            get
            {
                return this.color_6;
            }
            set
            {
                this.color_6 = value;
            }
        }

        [DisplayName("Default Color"), Category("Appearance"), Description("The default color of the text.")]
        public Color DefaultColor
        {
            get
            {
                return this.color_3;
            }
            set
            {
                this.color_3 = value;
            }
        }

        [DisplayName("Editable Elements Color"), Category("Appearance"), Description("The color of the editable elements of the text.")]
        public virtual Color EditableColor
        {
            get
            {
                return this.color_8;
            }
            set
            {
                this.color_8 = value;
            }
        }

        [Category("Code"), Description("Indicates whether empty lines are before and after each type (class, enum, etc)."), DisplayName("Empty Lines")]
        public bool EmptyLines
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                this.bool_4 = value;
            }
        }

        [Description("Indicates whether to save the full names source."), Category("Save Source"), DisplayName("Full Names")]
        public bool Full
        {
            get
            {
                return this.bool_6;
            }
            set
            {
                this.bool_6 = value;
            }
        }

        [Description("Indicates whether to create the code with full qualified names."), Category("Code"), DisplayName("Full Names")]
        public bool FullNames
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        [DisplayName("Hexadecimal Values"), Description("Indicates whether the numeric constants are in hexadecimal form."), Category("Code")]
        public bool HexValues
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        [Description("Indicates whether to save the code public + protected + internal interface."), Category("Save Source"), DisplayName("Interface Internal")]
        public bool InterfacePlusPlusInternal
        {
            get
            {
                return this.bool_11;
            }
            set
            {
                this.bool_11 = value;
            }
        }

        [Category("Save Source"), Description("Indicates whether to save the code public + protected interface."), DisplayName("Interface Protected")]
        public bool InterfacePlusProtected
        {
            get
            {
                return this.bool_10;
            }
            set
            {
                this.bool_10 = value;
            }
        }

        [Category("Save Source"), DisplayName("Interface Public"), Description("Indicates whether to save the code public interface.")]
        public bool InterfacePublic
        {
            get
            {
                return this.bool_9;
            }
            set
            {
                this.bool_9 = value;
            }
        }

        [Category("Appearance"), Description("The keyword color of the text."), DisplayName("Keyword Color")]
        public Color KeywordColor
        {
            get
            {
                return this.color_4;
            }
            set
            {
                this.color_4 = value;
            }
        }

        [Category("Appearance"), DisplayName("Label Color"), Description("The label color of the text.")]
        public virtual Color LabelColor
        {
            get
            {
                return this.color_5;
            }
            set
            {
                this.color_5 = value;
            }
        }

        [Description("Specifies the maximum number of the auto load files."), Category("Application"), DisplayName("Maximum Auto Load")]
        public int MaxAutoLoad
        {
            get
            {
                return this.int_5;
            }
            set
            {
                this.int_5 = value;
            }
        }

        [Description("Specifies the minimum length of the editor textbox in characters."), Category("Editor"), DisplayName("Minimum Editor Length")]
        public int MinEditorLength
        {
            get
            {
                return this.int_4;
            }
            set
            {
                this.int_4 = value;
            }
        }

        [Description("Indicates whether to save the code outline."), Category("Save Source"), DisplayName("Outline")]
        public bool Outline
        {
            get
            {
                return this.bool_12;
            }
            set
            {
                this.bool_12 = value;
            }
        }

        [Description("Indicates whether the auto load of PDB file local names is turned on (if available)."), Category("Project"), DisplayName("PDB Auto Load")]
        public bool PDBAutoLoad
        {
            get
            {
                return this.bool_17;
            }
            set
            {
                this.bool_17 = value;
            }
        }

        [DisplayName("Raw Code"), Description("Indicates whether to save the raw code source."), Category("Save Source")]
        public bool Raw
        {
            get
            {
                return this.bool_8;
            }
            set
            {
                this.bool_8 = value;
            }
        }

        [Category("Menu"), DisplayName("Maximum Recent Files"), Description("Specifies the maximum number of recent files.")]
        public int RecentFiles
        {
            get
            {
                return this.int_6;
            }
            set
            {
                this.int_6 = value;
            }
        }

        [Description("Indicates whether the next text view appears in the same window."), DisplayName("Same Window"), Category("View")]
        public bool SameWindow
        {
            get
            {
                return this.bool_14;
            }
            set
            {
                this.bool_14 = value;
            }
        }

        [Description("Indicates whether to save the short names source."), DisplayName("Short Names"), Category("Save Source")]
        public bool Short
        {
            get
            {
                return this.bool_7;
            }
            set
            {
                this.bool_7 = value;
            }
        }

        [Description("Indicates whether the single statement if/else have braces."), Category("Code"), DisplayName("Single Statement Brace")]
        public bool SingleStatementBrace
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                this.bool_5 = value;
            }
        }

        [Category("Interface"), Description("Specifies the splitter width."), DisplayName("Splitter Width")]
        public virtual int SplitterWidth
        {
            get
            {
                return this.int_7;
            }
            set
            {
                this.int_7 = value;
            }
        }

        [Description("The string color of the text."), Category("Appearance"), DisplayName("String Color")]
        public virtual Color StringColor
        {
            get
            {
                return this.color_7;
            }
            set
            {
                this.color_7 = value;
            }
        }

        [DisplayName("Tab Space Chrome"), Description("Specifies the tab space of the Chrome code."), Category("Code")]
        public int TabSpaceChrome
        {
            get
            {
                return this.int_3;
            }
            set
            {
                this.int_3 = value;
            }
        }

        [Description("Specifies the tab space of the C# code."), DisplayName("Tab Space CS"), Category("Code")]
        public int TabSpaceCSharp
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        [Category("Code"), Description("Specifies the tab space of the Delphi code."), DisplayName("Tab Space Delphi")]
        public int TabSpaceDelphi
        {
            get
            {
                return this.int_2;
            }
            set
            {
                this.int_2 = value;
            }
        }

        [Category("Code"), Description("Specifies the tab space of the Visual Basic code."), DisplayName("Tab Space VB")]
        public int TabSpaceVB
        {
            get
            {
                return this.int_1;
            }
            set
            {
                this.int_1 = value;
            }
        }

        [DisplayName("Text Background Color"), Category("Appearance"), Description("The background color of the text.")]
        public Color TextBackColor
        {
            get
            {
                return this.color_2;
            }
            set
            {
                this.color_2 = value;
            }
        }

        [Editor(typeof(FontObjectEditor), typeof(UITypeEditor)), DisplayName("Text Font"), Description("Indicates the font of the text."), Category("Appearance"), TypeConverter(typeof(FontObjectConverter))]
        public FontObject TextFont
        {
            get
            {
                return this.fontObject_1;
            }
            set
            {
                this.fontObject_1 = value;
            }
        }

        [DisplayName("Selection Color"), Category("Appearance"), Description("The color of the selection of the text.")]
        public virtual Color TextSelectionColor
        {
            get
            {
                return this.color_9;
            }
            set
            {
                this.color_9 = value;
            }
        }

        [DisplayName("Tree Background Color"), Description("The background color of the navigation pane."), Category("Appearance")]
        public Color TreeBackColor
        {
            get
            {
                return this.color_0;
            }
            set
            {
                this.color_0 = value;
            }
        }

        [DisplayName("Tree Font"), Editor(typeof(FontObjectEditor), typeof(UITypeEditor)), Description("Indicates the font of the navigation pane."), TypeConverter(typeof(FontObjectConverter)), Category("Appearance")]
        public FontObject TreeFont
        {
            get
            {
                return this.fontObject_0;
            }
            set
            {
                this.fontObject_0 = value;
            }
        }

        [DisplayName("Tree Foreground Color"), Description("The foreground color of the navigation pane."), Category("Appearance")]
        public Color TreeForeColor
        {
            get
            {
                return this.color_1;
            }
            set
            {
                this.color_1 = value;
            }
        }

        [Category("Code"), DisplayName("Type Details"), Description("Indicates whether the pseudo assembler fields and methods have type details.")]
        public bool TypeDetail
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                this.bool_2 = value;
            }
        }

        [DisplayName("Unicode Chars"), Description("Indicates whether the nonenglish chars appears as unicode numbers."), Category("Code")]
        public bool UnicodeChars
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }

        [Category("Interface"), Description("Specifies the visual style."), DisplayName("Visual Style")]
        public Crownwood.DotNetMagic.Common.VisualStyle VisualStyle
        {
            get
            {
                return this.visualStyle_0;
            }
            set
            {
                this.visualStyle_0 = value;
            }
        }

        [Description("Indicates whether the auto load of Xml Documentation file is turned on (if available)."), Category("Project"), DisplayName("XML Doc Auto Load")]
        public bool XmlDocAutoLoad
        {
            get
            {
                return this.bool_18;
            }
            set
            {
                this.bool_18 = value;
            }
        }
    }
}

