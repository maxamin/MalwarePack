namespace ns0
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    internal class Class699
    {
        private OpenFileDialog openFileDialog_0 = new OpenFileDialog();

        internal Class699(Enum40 A_1)
        {
            switch (A_1)
            {
                case Enum40.const_0:
                    this.openFileDialog_0.Title = Class537.string_726;
                    this.openFileDialog_0.Filter = Class537.string_948;
                    return;

                case Enum40.const_1:
                    this.openFileDialog_0.Title = Class537.string_832;
                    this.openFileDialog_0.DefaultExt = Class537.string_537;
                    this.openFileDialog_0.Filter = Class537.string_434;
                    return;

                case Enum40.const_2:
                    this.openFileDialog_0.Title = Class537.string_325;
                    this.openFileDialog_0.DefaultExt = Class537.string_810;
                    this.openFileDialog_0.Filter = Class537.string_76;
                    return;
            }
        }

        internal DialogResult method_0(Enum41 A_1)
        {
            this.openFileDialog_0.InitialDirectory = Class923.smethod_0(A_1);
            DialogResult result = this.openFileDialog_0.ShowDialog();
            Class923.smethod_1(A_1, this.String_2);
            return result;
        }

        internal string String_0
        {
            get
            {
                return this.openFileDialog_0.FileName;
            }
        }

        internal string String_1
        {
            get
            {
                return Path.GetFileName(this.openFileDialog_0.FileName);
            }
        }

        internal string String_2
        {
            get
            {
                string fileName = this.openFileDialog_0.FileName;
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
                return Path.GetFileName(this.openFileDialog_0.FileName);
            }
        }

        internal string String_4
        {
            get
            {
                return Path.GetExtension(this.openFileDialog_0.FileName);
            }
        }
    }
}

