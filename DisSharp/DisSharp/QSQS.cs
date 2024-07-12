namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("68005D0F-B8E0-3B01-84D5-A11A94154942")]
    internal interface QSQS
    {
        QSQR GetMethod();
        QSQS GetParent();
        void GetChildren(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] IntPtr[] children);
        uint GetStartOffset();
        uint GetEndOffset();
        uint GetLocalCount();
        void GetLocals(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] IntPtr[] locals);
        void GetNamespaces(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] IntPtr[] namespaces);
    }
}

