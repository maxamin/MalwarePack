namespace ns0
{
    using Microsoft.Win32;
    using System;

    internal class Class987 : IDisposable
    {
        private RegistryKey registryKey_0;

        internal Class987(RegistryKey A_1)
        {
            this.registryKey_0 = A_1;
        }

        public void Dispose()
        {
        }

        internal Class987 method_0(string A_1)
        {
            return new Class987(this.registryKey_0.CreateSubKey(A_1));
        }

        internal object method_1(string A_1, object A_2)
        {
            return this.registryKey_0.GetValue(A_1, A_2);
        }

        internal void method_2(string A_1, object A_2)
        {
            this.registryKey_0.SetValue(A_1, A_2);
        }

        internal static Class987 Class987_0
        {
            get
            {
                return new Class987(Registry.CurrentUser);
            }
        }

        internal static Class987 Class987_1
        {
            get
            {
                return new Class987(Registry.LocalMachine);
            }
        }
    }
}

