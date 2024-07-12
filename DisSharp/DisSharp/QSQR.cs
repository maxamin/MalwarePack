namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("B62B923C-B500-3158-A543-24F307A8B7E1")]
    internal interface QSQR
    {
        uint GetToken();
        uint GetSequencePointCount();
        QSQS GetRootScope();
        QSQS GetScopeFromOffset(uint offset);
        uint Getoffset(QSQU document, uint line, uint column);
        void GetRanges(QSQU document, uint line, uint column, uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] uint[] ranges);
        void GetParameters(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] QSQT[] parms);
        IntPtr GetNamespace();
        bool GetSourceStartEnd([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0, SizeConst=2)] QSQU[] docs, [MarshalAs(UnmanagedType.LPArray)] uint[] lines, [MarshalAs(UnmanagedType.LPArray)] uint[] columns);
        void GetSequencePoints(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] uint[] offsets, [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.IUnknown, SizeParamIndex=0)] IntPtr[] documents, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] uint[] lines, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] uint[] columns, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] uint[] endLines, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] uint[] endColumns);
    }
}

