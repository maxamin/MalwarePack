namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, Guid("9F60EEBE-2D9A-3F7C-BF58-80BC991C60BB"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface QSQT
    {
        void GetName(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] char[] name);
        uint GetAttributes();
        void GetSignature(uint size, out uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] byte[] name);
        uint GetAddressKind();
        uint GetAddressField1();
        uint GetAddressField2();
        uint GetAddressField3();
        uint GetStartOffset();
        uint GetEndOffset();
    }
}

