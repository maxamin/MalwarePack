namespace ns0
{
    using System;
    using System.Collections;

    internal class Class435 : Class398
    {
        internal ArrayList arrayList_1;
        internal Class445 class445_0;

        internal Class435()
        {
            this.arrayList_1 = new ArrayList();
        }

        internal Class435(Class445 A_1)
        {
            this.arrayList_1 = new ArrayList();
            this.class445_0 = A_1;
        }

        internal override void QQSS(Class398 oldtarget, Class398 newtarget)
        {
            int index = this.arrayList_1.IndexOf(oldtarget);
            if (index != -1)
            {
                this.arrayList_1[index] = newtarget;
            }
        }

        internal override void QQST(Class398 target)
        {
            this.arrayList_1.Add(target);
        }

        internal override Class398 QQUS()
        {
            this.class445_0 = this.class445_0.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            int num = data.method_10();
            for (int i = 0; i < num; i++)
            {
                ushort num3 = data.method_10();
                Class398.Class444.arrayList_1.Add(this);
                Class398.Class444.class540_0.method_1(num3);
            }
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write((ushort) this.arrayList_1.Count);
            for (int i = 0; i < this.arrayList_1.Count; i++)
            {
                Class398 class2 = this.arrayList_1[i] as Class398;
                writer.Write(class2.ushort_1);
            }
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_34;
            }
        }
    }
}

