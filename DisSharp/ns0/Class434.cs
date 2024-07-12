namespace ns0
{
    using System;
    using System.Collections;

    internal class Class434 : Class398
    {
        internal ArrayList arrayList_1;
        internal Class433 class433_0;
        internal Enum27 enum27_0;
        internal Enum29 enum29_0;
        internal int[] int_0;
        internal ushort ushort_2;

        internal Class434()
        {
        }

        internal Class434(Class433 A_1, ArrayList A_2, int[] A_3, Enum27 A_4, Enum29 A_5, int A_6)
        {
            this.class433_0 = A_1;
            this.arrayList_1 = A_2;
            this.int_0 = A_3;
            this.enum27_0 = A_4;
            this.enum29_0 = A_5;
            if (A_6 < 0)
            {
                this.ushort_2 = 0;
            }
            else
            {
                this.ushort_2 = (ushort) A_6;
            }
        }

        internal override void QQVS(Class48 data)
        {
            int num = data.method_10();
            this.arrayList_1 = new ArrayList();
            for (int i = 0; i < num; i++)
            {
                Class398 class2 = Class541.smethod_1(data);
                this.arrayList_1.Add(class2);
            }
            num = data.method_10();
            this.int_0 = new int[num];
            for (int j = 0; j < num; j++)
            {
                this.int_0[j] = data.method_11();
            }
            this.enum27_0 = (Enum27) data.method_8();
            this.enum29_0 = (Enum29) data.method_8();
            this.ushort_2 = data.method_10();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((ushort) this.arrayList_1.Count);
            for (int i = 0; i < this.arrayList_1.Count; i++)
            {
                (this.arrayList_1[i] as Class398).method_3(writer);
            }
            writer.Write((ushort) this.int_0.Length);
            for (int j = 0; j < this.int_0.Length; j++)
            {
                writer.Write(this.int_0[j]);
            }
            writer.Write((byte) this.enum27_0);
            writer.Write((byte) this.enum29_0);
            writer.Write(this.ushort_2);
        }

        internal override ArrayList QQSQ
        {
            get
            {
                return this.arrayList_1;
            }
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_35;
            }
        }
    }
}

