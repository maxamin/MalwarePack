namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, Guid("7C23FF90-33AF-11D3-95DA-00A024A85B51"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface QSQY
    {
        void SetContextNameObject(QSRQ pName);
        void GetContextNameObject(out QSRQ ppName);
        void Set([MarshalAs(UnmanagedType.LPWStr)] string szName, int pvValue, uint cbValue, uint dwFlags);
        void Get([MarshalAs(UnmanagedType.LPWStr)] string szName, out int pvValue, ref uint pcbValue, uint dwFlags);
        void GetDynamicDirectory(out int wzDynamicDir, ref uint pdwSize);
    }
}

