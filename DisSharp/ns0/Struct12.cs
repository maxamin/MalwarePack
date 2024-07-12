namespace ns0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct12
    {
        public uint uint_0;
        public uint uint_1;
        public ulong ulong_0;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string string_0;
        public uint uint_2;
    }
}

