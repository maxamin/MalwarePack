namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, Guid("B4CE6286-2A6B-3712-A3B7-1EE1DAD467B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface QSQQ
    {
        QSQU GetDocument(string url, ref Guid language, ref Guid languageVendor, ref Guid documentType);
        void GetDocuments(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] QSQU[] docs);
        uint GetUserEntryPoint();
        [PreserveSig]
        int GetMethod(uint token, ref QSQR method);
        QSQR GetMethodByVersion(uint token, int version);
        void GetVariables(uint parent, uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] QSQT[] vars);
        void GetGlobalVariables(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] QSQT[] vars);
        QSQR GetMethodFromDocumentPosition(QSQU document, uint line, uint column);
        void GetSymAttribute(uint parent, string name, ulong size, ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] byte[] buffer);
        void GetNamespaces(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] IntPtr[] namespaces);
        void Initialize([MarshalAs(UnmanagedType.IUnknown)] object importer, string filename, string searchPath, [MarshalAs(UnmanagedType.IUnknown)] object stream);
        void UpdateSymbolStore(string filename, [MarshalAs(UnmanagedType.IUnknown)] object stream);
        void ReplaceSymbolStore(string filename, [MarshalAs(UnmanagedType.IUnknown)] object stream);
        void GetSymbolStoreFileName(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] char[] name);
        void GetMethodsFromDocumentPosition(QSQU document, uint line, uint column, uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] QSQR[] retval);
        void GetDocumentVersion(QSQU doc, out int version, out bool isLatest);
        void GetMethodVersion(QSQR method, out int version);
    }
}

