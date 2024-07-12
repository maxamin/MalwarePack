namespace ns0
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;

    internal class Class1092
    {
        internal static string string_0;
        internal static string string_1;

        internal static void smethod_0()
        {
            AboutForm form = new AboutForm();
            if (Class521.Boolean_0)
            {
                form.UserName.Text = "";
                form.OrgName.Text = "";
            }
            else
            {
                Class993.aboutForm_0 = form;
                Class950.smethod_0(0x48);
                Class993.aboutForm_0 = null;
            }
            form.ShowDialog();
        }

        internal static void smethod_1()
        {
            if (Class993.activationCodeForm_0.ShowDialog() == DialogResult.OK)
            {
                Class582.smethod_0();
                string_0 = Class993.activationCodeForm_0.TextBox1.Text;
                string_1 = Class993.activationCodeForm_0.TextBox2.Text;
                Class950.smethod_0(0x40);
            }
        }

        private static void smethod_10(string A_0)
        {
            new Process { StartInfo = { FileName = A_0 } }.Start();
        }

        internal static void smethod_2()
        {
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string sourceFileName = baseDirectory + Class537.string_199;
                if (baseDirectory.IndexOf('#') != -1)
                {
                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    int length = folderPath.LastIndexOf('\\');
                    if ((length == -1) || (folderPath.Substring(length + 1) != "Application Data"))
                    {
                        return;
                    }
                    string path = folderPath.Substring(0, length) + Class537.string_599 + Class537.string_549 + Class537.string_599 + Class537.string_199;
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    File.Copy(sourceFileName, path);
                    sourceFileName = path;
                }
                try
                {
                    new Process { StartInfo = { FileName = sourceFileName } }.Start();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message + "\n" + sourceFileName, Class537.string_366, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception)
            {
            }
        }

        internal static void smethod_3()
        {
            Class397 class2 = Class543.smethod_9(Class542.Byte_79);
            Class645.class704_0.method_12(class2);
        }

        internal static void smethod_4()
        {
            Class397 class2 = Class543.smethod_9(Class542.Byte_76);
            Class645.class704_0.method_13(class2);
        }

        internal static void smethod_5()
        {
            smethod_10(Class537.string_169);
        }

        internal static void smethod_6()
        {
            smethod_10(Class537.string_531);
        }

        internal static void smethod_7()
        {
            smethod_10(Class924.String_0);
        }

        internal static void smethod_8()
        {
            smethod_10(Class537.string_114);
        }

        internal static void smethod_9()
        {
            smethod_10(Class537.string_90);
        }
    }
}

