namespace ns0
{
    using System;
    using System.Collections;

    internal class Class418 : Class398
    {
        private ArrayList arrayList_1;
        internal bool bool_1;
        internal Class445 class445_0;

        internal Class418()
        {
            this.bool_1 = true;
        }

        internal Class418(Class445 A_1)
        {
            this.bool_1 = true;
            this.class445_0 = A_1;
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
            this.class445_0 = this.class445_0.QQUU(Class658.class658_0);
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_0 = this.class445_0.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.bool_1 = data.method_5();
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
            this.class445_0.QQRW(writer);
            writer.Write(this.bool_1);
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
                return Enum26.const_17;
            }
        }
    }
}

