namespace ns0
{
    using System;

    internal abstract class Class650
    {
        protected Class650()
        {
        }

        internal void method_0(Class524 A_1)
        {
            A_1.Write(this.Version);
            this.QQWX(A_1);
        }

        internal void method_1(Class656 A_1)
        {
            byte version = A_1.ReadByte();
            if (version > this.Version)
            {
                throw new Exception2();
            }
            this.QQWY(A_1, version);
        }

        internal abstract void QQWX(Class524 writer);
        internal abstract void QQWY(Class656 reader, byte version);

        internal abstract byte Version { get; }
    }
}

