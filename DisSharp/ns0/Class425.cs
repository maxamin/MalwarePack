namespace ns0
{
    using System;

    internal class Class425 : Class398
    {
        internal Class398 class398_0;

        internal Class408 method_8()
        {
            Class408 class2 = new Class408 {
                arrayList_0 = base.arrayList_0,
                bool_0 = base.bool_0
            };
            base.method_6(class2);
            this.class398_0.method_1(this);
            return class2;
        }

        internal override void QQSS(Class398 oldtarget, Class398 newtarget)
        {
            this.class398_0 = newtarget;
        }

        internal override void QQST(Class398 target)
        {
            this.class398_0 = target;
        }

        internal override void QQVS(Class48 data)
        {
            ushort num = data.method_10();
            Class398.Class444.arrayList_1.Add(this);
            Class398.Class444.class540_0.method_1(num);
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.class398_0.ushort_1);
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_25;
            }
        }
    }
}

