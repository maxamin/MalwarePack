namespace ns0
{
    using System;
    using System.Collections;

    internal class Class461 : Class445
    {
        internal ArrayList arrayList_0 = new ArrayList();
        internal Class445 class445_0;

        internal Class461()
        {
        }

        internal void method_1(Class445 A_1)
        {
            this.arrayList_0.Add(A_1);
        }

        internal override Class445 QQUS()
        {
            this.class445_0 = this.class445_0.QQUS();
            Class658 class2 = Class821.smethod_0(this.class445_0);
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                this.arrayList_0[i] = Class860.smethod_0(Class821.smethod_9(this.arrayList_0[i] as Class445), class2).QQUT();
            }
            return this;
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type == Class658.class658_0)
            {
                return Class859.smethod_2(this, this.class445_0);
            }
            return Class860.smethod_0(this, type);
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            int num = data.method_10();
            for (int i = 0; i < num; i++)
            {
                this.arrayList_0.Add(Class541.smethod_2(data));
            }
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write((ushort) this.arrayList_0.Count);
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                (this.arrayList_0[i] as Class445).QQRW(writer);
            }
        }

        internal override bool QQVV
        {
            get
            {
                return true;
            }
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_7;
            }
        }
    }
}

