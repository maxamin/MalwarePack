namespace ns0
{
    using System;
    using System.Collections;

    internal class Class495 : Class445
    {
        internal ArrayList arrayList_0;
        internal Enum11 enum11_0;
        internal int int_0;

        internal Class495()
        {
            this.arrayList_0 = new ArrayList();
        }

        internal Class495(Enum11 A_1, int A_2)
        {
            this.arrayList_0 = new ArrayList();
            this.enum11_0 = A_1;
            this.int_0 = A_2;
        }

        internal void method_1(Class445 A_1)
        {
            this.arrayList_0.Add(A_1);
        }

        internal override Class445 QQUS()
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                this.arrayList_0[i] = Class821.smethod_9(this.arrayList_0[i] as Class445).QQUS();
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum11_0 = (Enum11) data.method_8();
            this.int_0 = data.method_11();
            int num = data.method_10();
            for (int i = 0; i < num; i++)
            {
                this.arrayList_0.Add(Class541.smethod_2(data));
            }
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum11_0);
            writer.Write(this.int_0);
            writer.Write((ushort) this.arrayList_0.Count);
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                (this.arrayList_0[i] as Class445).QQRW(writer);
            }
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_49;
            }
        }
    }
}

