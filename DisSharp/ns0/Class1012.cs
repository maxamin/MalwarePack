namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    internal class Class1012
    {
        internal static readonly IntPtr intptr_0 = new IntPtr(3);
        internal static readonly IntPtr intptr_1 = new IntPtr(14);
        internal static readonly ulong ulong_0 = 2L;

        [DllImport("Kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        internal static extern int EnumResourceNames(IntPtr hModule, IntPtr pType, Delegate2 enumFunc, IntPtr param);
        [DllImport("Shell32.dll", CharSet=CharSet.Auto)]
        internal static extern IntPtr ExtractIcon(IntPtr hInstance, string strFileName, uint uiIconIndex);
        [DllImport("Kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        internal static extern IntPtr FindResource(IntPtr hModule, IntPtr pName, IntPtr pType);
        [DllImport("Kernel32.dll", SetLastError=true)]
        internal static extern bool FreeLibrary(IntPtr hModule);
        [DllImport("User32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        internal static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr pName);
        [DllImport("Kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        internal static extern IntPtr LoadLibraryEx(string strFileName, IntPtr hFile, ulong ulFlags);
        [DllImport("Kernel32.dll", SetLastError=true)]
        internal static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResource);
        [DllImport("Kernel32.dll")]
        internal static extern IntPtr LockResource(IntPtr hGlobal);
        [DllImport("Kernel32.dll", SetLastError=true)]
        internal static extern uint SizeofResource(IntPtr hModule, IntPtr hResource);
        internal static void smethod_0()
        {
            throw new Win32Exception();
        }

        unsafe internal static bool smethod_1(IntPtr A_0)
        {
            uint num = (uint) A_0.ToPointer();
            return ((num >> 0x10) == 0);
        }
    }
}

