namespace DisSharp
{
    using ns0;
    using System;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("E707DCDE-D1CD-11D2-BAB9-00C04F8ECEAE")]
    internal interface QSRR
    {
        [PreserveSig]
        int UninstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pvReserved, out uint pulDisposition);
        [PreserveSig]
        int QueryAssemblyInfo(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, ref Struct12 assemblyInfo);
        [PreserveSig]
        int CreateAssemblyCacheItem(uint dwFlags, IntPtr pvReserved, out QSRS ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);
        [PreserveSig]
        int CreateAssemblyScavenger(out object ppAsmScavenger);
        [PreserveSig]
        int InstallAssembly(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, IntPtr pvReserved);
    }
}

