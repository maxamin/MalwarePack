namespace ns0
{
    using DisSharp;
    using System;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Text;
    using System.Windows.Forms;

    internal class Class1120
    {
        private const uint uint_0 = 0;
        private const uint uint_1 = 1;
        private const uint uint_2 = 2;
        private const uint uint_3 = 0;
        private const uint uint_4 = 0x8007007a;

        [DllImport("Fusion.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
        private static extern int CreateAssemblyCache(out QSRR ppAsmCache, uint dwReserved);
        [DllImport("Fusion.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
        private static extern int CreateAssemblyEnum(out QSQZ ppEnum, QSQY pAppCtx, QSRQ pName, uint dwFlags, int pvReserved);
        [DllImport("Fusion.dll")]
        private static extern int GetCachePath(uint flags, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder wzDir, ref uint pdwSize);
        internal static void smethod_0()
        {
            try
            {
                AssemblyCacheForm form = new AssemblyCacheForm();
                smethod_1(form);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string[] strArray = form.String_0;
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        Class700.smethod_0(strArray[i]);
                    }
                }
            }
            catch
            {
            }
        }

        private static void smethod_1(AssemblyCacheForm A_0)
        {
            QSQY ppAppCtx = null;
            QSQZ ppEnum = null;
            QSRQ ppName = null;
            CreateAssemblyEnum(out ppEnum, null, null, 2, 0);
            while (ppEnum.GetNextAssembly(out ppAppCtx, out ppName, 0) == 0)
            {
                uint pccDisplayName = 0;
                ppName.GetDisplayName(null, ref pccDisplayName, 0);
                StringBuilder szDisplayName = new StringBuilder((int) pccDisplayName);
                ppName.GetDisplayName(szDisplayName, ref pccDisplayName, 0);
                string[] strArray = szDisplayName.ToString().Split(new char[] { ',' });
                string str = strArray[0];
                string str2 = strArray[1].Substring(strArray[1].LastIndexOf('=') + 1);
                string str4 = smethod_2(szDisplayName.ToString());
                if (str4 != string.Empty)
                {
                    A_0.method_0(str, str2, str4);
                }
            }
        }

        internal static string smethod_2(string A_0)
        {
            QSRR ppAsmCache = null;
            try
            {
                CreateAssemblyCache(out ppAsmCache, 0);
                Struct12 assemblyInfo = new Struct12();
                uint num = 0;
                try
                {
                    num = (uint) ppAsmCache.QueryAssemblyInfo(1, A_0, ref assemblyInfo);
                    if ((num != 0) && (num != 0x8007007a))
                    {
                        return string.Empty;
                    }
                    if (assemblyInfo.uint_2 != 0)
                    {
                        assemblyInfo.string_0 = new string(new char[assemblyInfo.uint_2]);
                        if (ppAsmCache.QueryAssemblyInfo(1, A_0, ref assemblyInfo) != 0)
                        {
                            return string.Empty;
                        }
                        return assemblyInfo.string_0;
                    }
                }
                catch
                {
                    return string.Empty;
                }
            }
            catch (SecurityException)
            {
            }
            finally
            {
                if (ppAsmCache != null)
                {
                    Marshal.ReleaseComObject(ppAsmCache);
                }
            }
            return string.Empty;
        }

        private static string smethod_3()
        {
            StringBuilder wzDir = new StringBuilder(260);
            uint pdwSize = 260;
            GetCachePath(8, wzDir, ref pdwSize);
            return wzDir.ToString();
        }
    }
}

