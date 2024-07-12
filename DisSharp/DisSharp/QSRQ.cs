namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("CD193BC0-B4BC-11D2-9833-00C04FC31D2E")]
    internal interface QSRQ
    {
        [PreserveSig]
        int SetProperty(uint PropertyId, IntPtr pvProperty, uint cbProperty);
        [PreserveSig]
        int GetProperty(uint PropertyId, IntPtr pvProperty, ref uint pcbProperty);
        [PreserveSig]
        int Finalize();
        [PreserveSig]
        int GetDisplayName([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder szDisplayName, ref uint pccDisplayName, uint dwDisplayFlags);
        [PreserveSig]
        int BindToObject(object refIID, object pAsmBindSink, QSQY pApplicationContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, int pvReserved, uint cbReserved, out int ppv);
        [PreserveSig]
        int GetName(ref uint lpcwBuffer, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwzName);
        [PreserveSig]
        int GetVersion(out uint pdwVersionHi, out uint pdwVersionLow);
        [PreserveSig]
        int IsEqual(QSRQ pName, uint dwCmpFlags);
        [PreserveSig]
        int Clone(out QSRQ pName);
    }
}

