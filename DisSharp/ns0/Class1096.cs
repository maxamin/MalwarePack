namespace ns0
{
    using System;
    using System.Security;
    using System.Security.Permissions;
    using System.Windows.Forms;

    internal class Class1096
    {
        internal long[] long_0;

        [STAThread]
        internal static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Class950.smethod_0(0x13);
            if (Class698.class582_0.mainForm_0 != null)
            {
                Application.Run(Class698.class582_0.mainForm_0);
            }
        }

        private static bool smethod_0()
        {
            bool flag;
            try
            {
                new PermissionSet(PermissionState.Unrestricted).Demand();
                return true;
            }
            catch (SecurityException)
            {
                flag = false;
            }
            return flag;
        }
    }
}

