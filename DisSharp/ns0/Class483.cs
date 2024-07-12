namespace ns0
{
    using System;
    using System.Collections;

    internal class Class483 : Class445
    {
        internal ArrayList arrayList_0;
        internal Enum11 enum11_0;
        internal int int_0;

        internal Class483()
        {
        }

        internal Class483(Enum11 A_1, int A_2, ArrayList A_3)
        {
            this.enum11_0 = A_1;
            this.int_0 = A_2;
            this.arrayList_0 = A_3;
        }

        internal override Class445 QQUS()
        {
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum11_0 = (Enum11) data.method_8();
            this.int_0 = data.method_11();
            int num = data.method_10();
            int num2 = data.method_10();
            this.arrayList_0 = new ArrayList();
            for (int i = 0; i < num; i++)
            {
                Class445[] classArray = new Class445[num2];
                for (int j = 0; j < num2; j++)
                {
                    classArray[j] = Class541.smethod_2(data);
                }
                this.arrayList_0.Add(classArray);
            }
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum11_0);
            writer.Write(this.int_0);
            writer.Write((ushort) this.arrayList_0.Count);
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class445[] classArray = this.arrayList_0[i] as Class445[];
                if (i == 0)
                {
                    writer.Write((ushort) classArray.Length);
                }
                for (int j = 0; j < classArray.Length; j++)
                {
                    classArray[j].QQRW(writer);
                }
            }
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_35;
            }
        }
    }
}

