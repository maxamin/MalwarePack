namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, Guid("40DE4037-7C81-3E1E-B022-AE1ABFF2CA08"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface QSQU
    {
        void GetURL(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] char[] url);
        void GetDocumentType(out Guid retval);
        void GetLanguage(out Guid retval);
        void GetLanguageVendor(out Guid retval);
        void GetCheckSumAlgorithmId(out Guid retval);
        void GetCheckSum(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] byte[] data);
        uint FindClosestLine(uint line);
        bool HasEmbeddedSource();
        uint GetSourceLength();
        void GetSourceRange(uint startLine, uint startColumn, uint endLine, uint endColumn, uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=4)] byte[] source);
    }
}

