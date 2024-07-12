namespace ns0
{
    using System;

    internal abstract class Class75 : Class74
    {
        private Class48 class48_6 = new Class48();
        private Class608 class608_3;

        internal Class75()
        {
            this.class48_6 = new Class48();
            this.class608_3 = new Class608(this.class48_6);
        }

        internal void method_202(uint A_1)
        {
            int num = ((int) A_1) & 0xffffff;
            Class563.Class616 class2 = Class546.class563_0.arrayList_0[num] as Class563.Class616;
            this.class48_6.Byte_0 = class2.byte_0;
            this.class608_3.method_0();
            base.method_93(this.class608_3.enum11_0, this.class608_3.int_0, this.class608_3.byte_0);
            base.method_9(Class518.class337_39);
            int num2 = this.class48_6.method_21();
            for (int i = 0; i < num2; i++)
            {
                if (i > 0)
                {
                    base.method_9(Class518.class337_14);
                }
                this.class608_3.method_0();
                base.method_93(this.class608_3.enum11_0, this.class608_3.int_0, this.class608_3.byte_0);
            }
            base.method_9(Class518.class337_43);
            int num4 = this.class48_6.method_21();
            Class557.Class605 class3 = Class546.class557_0.arrayList_0[num4] as Class557.Class605;
            this.class48_6.Byte_0 = class3.byte_0;
            this.class608_3.method_0();
            base.method_9(new Class336(base.method_131(this.class608_3.enum11_0, this.class608_3.int_0)));
            int num5 = this.class48_6.method_21();
            Class573.Class534 class4 = Class546.class573_0.arrayList_0[num5] as Class573.Class534;
            this.class48_6.Byte_0 = class4.byte_0;
            base.method_9(Class518.class337_39);
            int num6 = this.class48_6.method_21();
            for (int j = 0; j < num6; j++)
            {
                if (j > 0)
                {
                    base.method_9(Class518.class337_14);
                }
                this.class608_3.method_0();
                base.method_93(this.class608_3.enum11_0, this.class608_3.int_0, this.class608_3.byte_0);
            }
            base.method_9(Class518.class337_43);
        }
    }
}

