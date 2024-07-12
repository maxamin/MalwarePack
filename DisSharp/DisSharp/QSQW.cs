namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, Guid("AA544D42-28CB-11d3-BD22-0000F80849BD"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface QSQW
    {
        [PreserveSig]
        int GetReaderForFile([MarshalAs(UnmanagedType.IUnknown)] object importer, string filename, string searchPath, out QSQQ reader);
        QSQQ GetReaderForStream([MarshalAs(UnmanagedType.IUnknown)] object importer, [MarshalAs(UnmanagedType.IUnknown)] object stream);
    }
}

