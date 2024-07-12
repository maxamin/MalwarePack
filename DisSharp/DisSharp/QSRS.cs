namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("9E3AAEB4-D1CD-11D2-BAB9-00C04F8ECEAE")]
    internal interface QSRS
    {
        void CreateStream([MarshalAs(UnmanagedType.LPWStr)] string pszName, uint dwFormat, uint dwFlags, uint dwMaxSize, out UCOMIStream ppStream);
        void IsNameEqual(QSRQ pName);
        void Commit(uint dwFlags);
        void MarkAssemblyVisible(uint dwFlags);
    }
}

