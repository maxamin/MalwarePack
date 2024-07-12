namespace DisSharp
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("21B8916C-F28E-11D2-A473-00C04F8EF448")]
    internal interface QSQZ
    {
        [PreserveSig]
        int GetNextAssembly(out QSQY ppAppCtx, out QSRQ ppName, uint dwFlags);
        [PreserveSig]
        int Reset();
        [PreserveSig]
        int Clone(out QSQZ ppEnum);
    }
}

