namespace ns0
{
    using System;
    using System.Text;

    internal class Class637
    {
        internal int int_0;
        private string string_0;
        internal ushort ushort_0;
        internal ushort ushort_1;
        internal ushort ushort_2;
        internal ushort ushort_3;

        internal void method_0(Class524 A_1)
        {
            A_1.Write(this.ushort_0);
            A_1.Write(this.ushort_1);
            A_1.Write(this.ushort_2);
            A_1.Write(this.ushort_3);
            A_1.Write(this.int_0);
        }

        internal void method_1(Class656 A_1)
        {
            this.ushort_0 = A_1.ReadUInt16();
            this.ushort_1 = A_1.ReadUInt16();
            this.ushort_2 = A_1.ReadUInt16();
            this.ushort_3 = A_1.ReadUInt16();
            this.int_0 = A_1.ReadInt32();
        }

        internal string method_2()
        {
            if (this.string_0 == null)
            {
                StringBuilder builder = new StringBuilder(20);
                builder.Append(this.ushort_0.ToString());
                builder.Append('.');
                builder.Append(this.ushort_1.ToString());
                builder.Append('.');
                builder.Append(this.ushort_2.ToString());
                builder.Append('.');
                builder.Append(this.ushort_3.ToString());
                this.string_0 = builder.ToString();
            }
            return this.string_0;
        }
    }
}

