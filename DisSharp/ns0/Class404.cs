namespace ns0
{
    using System;
    using System.Collections;

    internal class Class404 : Class398
    {
        private ArrayList arrayList_1;
        internal bool bool_1;
        internal uint uint_0;
        internal ushort ushort_2;

        internal Class404()
        {
        }

        internal override void QQSR(Class398 statement)
        {
            if (this.arrayList_1 == null)
            {
                this.arrayList_1 = new ArrayList();
            }
            this.arrayList_1.Add(statement);
        }

        internal override void QQVS(Class48 data)
        {
            this.uint_0 = data.method_14();
            byte num = data.method_8();
            this.bool_1 = num == 1;
            this.ushort_2 = data.method_10();
            if (data.method_8() == 1)
            {
                this.arrayList_1 = new ArrayList();
                int num2 = data.method_10();
                for (int i = 0; i < num2; i++)
                {
                    Class398 class2 = Class541.smethod_1(data);
                    this.arrayList_1.Add(class2);
                }
            }
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.uint_0);
            byte num = this.bool_1 ? ((byte) 1) : ((byte) 0);
            writer.Write(num);
            writer.Write(this.ushort_2);
            if (this.arrayList_1 != null)
            {
                writer.Write((byte) 1);
                writer.Write((ushort) this.arrayList_1.Count);
                for (int i = 0; i < this.arrayList_1.Count; i++)
                {
                    (this.arrayList_1[i] as Class398).method_3(writer);
                }
            }
            else
            {
                writer.Write((byte) 0);
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
                return Enum26.const_5;
            }
        }
    }
}

