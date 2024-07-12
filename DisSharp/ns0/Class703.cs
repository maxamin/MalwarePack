namespace ns0
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    internal class Class703
    {
        private SaveFileDialog saveFileDialog_0 = new SaveFileDialog();

        internal Class703(Enum42 A_1)
        {
            switch (A_1)
            {
                case Enum42.const_0:
                    this.saveFileDialog_0.Title = Class537.string_239;
                    this.saveFileDialog_0.FileName = Class519.class394_0.Name + Class537.string_542;
                    this.saveFileDialog_0.DefaultExt = Class537.string_537;
                    this.saveFileDialog_0.Filter = Class537.string_434;
                    return;

                case Enum42.const_1:
                    this.saveFileDialog_0.Title = Class537.string_258;
                    this.saveFileDialog_0.FileName = Class645.class704_0.String_0;
                    this.saveFileDialog_0.DefaultExt = Class537.string_878;
                    this.saveFileDialog_0.Filter = Class537.string_157;
                    return;

                case Enum42.const_2:
                    this.saveFileDialog_0.Title = Class537.string_45;
                    this.saveFileDialog_0.FileName = Class519.class394_0.Name + Class537.string_857 + Class846.String_1.ToUpper() + Class537.string_857;
                    return;

                case Enum42.const_3:
                    this.saveFileDialog_0.Title = Class537.string_561;
                    this.saveFileDialog_0.FileName = Class537.string_809;
                    this.saveFileDialog_0.DefaultExt = Class537.string_792;
                    this.saveFileDialog_0.Filter = Class537.string_314;
                    return;

                case Enum42.const_4:
                    this.saveFileDialog_0.Title = Class537.string_584;
                    this.saveFileDialog_0.FileName = Class537.string_700;
                    this.saveFileDialog_0.DefaultExt = Class537.string_643;
                    this.saveFileDialog_0.Filter = Class537.string_545;
                    return;
            }
        }

        internal DialogResult method_0(Enum41 A_1)
        {
            this.saveFileDialog_0.InitialDirectory = Class923.smethod_0(A_1);
            DialogResult result = this.saveFileDialog_0.ShowDialog();
            Class923.smethod_1(A_1, this.String_2);
            return result;
        }

        internal string String_0
        {
            get
            {
                return this.saveFileDialog_0.FileName;
            }
        }

        internal string String_1
        {
            get
            {
                return Path.GetFileName(this.saveFileDialog_0.FileName);
            }
        }

        internal string String_2
        {
            get
            {
                string fileName = this.saveFileDialog_0.FileName;
                string str2 = Path.GetFileName(fileName);
                if (str2.Length == 0)
                {
                    return fileName;
                }
                return fileName.Substring(0, fileName.Length - str2.Length);
            }
        }

        internal string String_3
        {
            get
            {
                return Path.GetFileName(this.saveFileDialog_0.FileName);
            }
        }

        internal string String_4
        {
            get
            {
                return Path.GetExtension(this.saveFileDialog_0.FileName);
            }
        }
    }
}

