namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, Guid("809c652e-7396-11d2-9771-00A0C9B4D50C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface QSQV
    {
        void DefineScope(ref Guid clsid, uint createFlags, [In] ref Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object retval);
        [PreserveSig]
        int OpenScope(string scope, uint openFlags, [In] ref Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object import);
        void OpenScopeOnMemory(IntPtr data, uint dataSize, uint openFlags, [In] ref Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object retval);
    }
}

