namespace ns0
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

    internal class Class1014
    {
        private static StringBuilder stringBuilder_0 = new StringBuilder(120);

        internal static void smethod_0(string A_0, string A_1)
        {
            DirectoryInfo info = new DirectoryInfo(A_0);
            foreach (FileInfo info2 in info.GetFiles(A_1))
            {
                File.Delete(info2.FullName);
            }
        }

        internal static bool smethod_1(string A_0, string A_1)
        {
            DirectoryInfo info = new DirectoryInfo(A_0);
            foreach (FileInfo info2 in info.GetFiles())
            {
                if (info2.Name == A_1)
                {
                    return true;
                }
            }
            foreach (DirectoryInfo info3 in info.GetDirectories())
            {
                if (info3.Name == A_1)
                {
                    return true;
                }
            }
            return false;
        }

        internal static string smethod_2(string A_0, string A_1)
        {
            new DirectoryInfo(A_0).CreateSubdirectory(A_1);
            stringBuilder_0.Length = 0;
            stringBuilder_0.Append(A_0);
            stringBuilder_0.Append('\\');
            stringBuilder_0.Append(A_1);
            stringBuilder_0.Append('\\');
            return stringBuilder_0.Replace(@"\\", @"\").ToString();
        }

        internal static string String_0
        {
            get
            {
                string location = Assembly.GetEntryAssembly().Location;
                string fileName = Path.GetFileName(location);
                return location.Substring(0, location.Length - fileName.Length);
            }
        }
    }
}

