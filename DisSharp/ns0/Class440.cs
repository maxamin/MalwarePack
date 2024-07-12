namespace ns0
{
    using System;
    using System.Collections;

    internal class Class440 : Class398
    {
        private ArrayList arrayList_1;
        internal Class445[] class445_0;
        internal Class445[] class445_1;

        internal Class440()
        {
        }

        internal Class440(Class445[] A_1, Class445[] A_2)
        {
            this.class445_0 = A_1;
            this.class445_1 = A_2;
        }

        internal override void QQSR(Class398 statement)
        {
            if (this.arrayList_1 == null)
            {
                this.arrayList_1 = new ArrayList();
            }
            this.arrayList_1.Add(statement);
        }

        internal override Class398 QQUS()
        {
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i] = this.class445_0[i].QQUT();
                this.class445_1[i] = this.class445_1[i].QQUT();
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            int num = data.method_10();
            this.class445_0 = new Class445[num];
            this.class445_1 = new Class445[num];
            for (int i = 0; i < num; i++)
            {
                this.class445_0[i] = Class541.smethod_2(data);
                this.class445_1[i] = Class541.smethod_2(data);
            }
            if (data.method_8() == 1)
            {
                this.arrayList_1 = new ArrayList();
                int num4 = data.method_10();
                for (int j = 0; j < num4; j++)
                {
                    Class398 class2 = Class541.smethod_1(data);
                    this.arrayList_1.Add(class2);
                }
            }
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((ushort) this.class445_0.Length);
            for (int i = 0; i < this.class445_0.Length; i++)
            {
                this.class445_0[i].QQRW(writer);
                this.class445_1[i].QQRW(writer);
            }
            if (this.arrayList_1 != null)
            {
                writer.Write((byte) 1);
                writer.Write((ushort) this.arrayList_1.Count);
                for (int j = 0; j < this.arrayList_1.Count; j++)
                {
                    (this.arrayList_1[j] as Class398).method_3(writer);
                }
            }
            else
            {
                writer.Write((byte) 0);
            }
        }

        internal override bool QQRZ
        {
            get
            {
                return true;
            }
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
                return Enum26.const_41;
            }
        }
    }
}

