namespace ns0
{
    using System;
    using System.Collections;

    internal class Class442 : Class398
    {
        private ArrayList arrayList_1;

        internal Class442()
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

        internal override bool QQRY
        {
            get
            {
                return true;
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
                return Enum26.const_43;
            }
        }
    }
}

