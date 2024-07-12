namespace ns0
{
    using System;
    using System.Collections;

    internal class Class433 : Class398
    {
        private ArrayList arrayList_1;
        internal bool bool_1;
        internal Class445 class445_0;
        internal Enum0 enum0_0;
        internal Enum28 enum28_0;
        internal int int_0;

        internal Class433()
        {
        }

        internal Class433(Class445 A_1, ArrayList A_2)
        {
            this.class445_0 = A_1;
            this.arrayList_1 = A_2;
        }

        internal override Class398 QQUS()
        {
            this.enum28_0 = Enum28.const_0;
            Class658 class2 = Class821.smethod_0(this.class445_0);
            switch (class2.enum11_0)
            {
                case Enum11.const_36:
                    if (!Class961.smethod_0(class2.int_0))
                    {
                        this.enum0_0 = Enum0.const_52;
                    }
                    else
                    {
                        this.enum0_0 = Enum0.const_2;
                        this.int_0 = class2.int_0;
                        this.bool_1 = Class961.bool_0;
                    }
                    break;

                case Enum11.const_38:
                    this.int_0 = class2.int_0;
                    if (Class961.smethod_1(class2.int_0))
                    {
                        this.enum0_0 = Enum0.const_1;
                        this.bool_1 = Class961.bool_0;
                    }
                    else
                    {
                        this.enum0_0 = Enum0.const_51;
                    }
                    break;

                case Enum11.const_28:
                    this.enum28_0 = Enum28.const_1;
                    break;

                case Enum11.const_17:
                    this.enum28_0 = Enum28.const_2;
                    break;

                default:
                    this.enum0_0 = Enum0.const_50;
                    break;
            }
            this.class445_0 = this.class445_0.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            int num = data.method_10();
            this.arrayList_1 = new ArrayList();
            for (int i = 0; i < num; i++)
            {
                Class434 class2 = Class541.smethod_1(data) as Class434;
                class2.class433_0 = this;
                this.arrayList_1.Add(class2);
            }
            this.enum0_0 = (Enum0) data.method_8();
            this.int_0 = data.method_11();
            this.bool_1 = data.method_5();
            this.enum28_0 = (Enum28) data.method_8();
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write((ushort) this.arrayList_1.Count);
            for (int i = 0; i < this.arrayList_1.Count; i++)
            {
                (this.arrayList_1[i] as Class398).method_3(writer);
            }
            writer.Write((byte) this.enum0_0);
            writer.Write(this.int_0);
            writer.Write(this.bool_1);
            writer.Write((byte) this.enum28_0);
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
                return Enum26.const_33;
            }
        }
    }
}

