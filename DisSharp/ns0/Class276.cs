namespace ns0
{
    using System;

    internal abstract class Class276 : Class275
    {
        protected Class276()
        {
        }

        private bool method_927(Enum0 A_1, int A_2)
        {
            if (A_1 == Enum0.const_2)
            {
                base.method_9(Class518.class337_10);
                base.method_48(Class546.class548_0.arrayList_0[A_2] as Class548.Class529);
                return true;
            }
            if (A_1 != Enum0.const_1)
            {
                return false;
            }
            if (A_2 == Class519.class604_0.int_1)
            {
                return false;
            }
            base.method_9(Class518.class337_10);
            base.method_53(Class546.class553_0.arrayList_0[A_2] as Class553.Class531);
            return true;
        }

        internal override void QRWT(Class370 node, Class548.Class529 type)
        {
            Class519.class529_1 = type;
            base.method_46(node);
            if (type.short_3 > 0)
            {
                base.method_902(type);
            }
            base.method_7();
            base.method_9(new Class357(node));
            if (type.short_0 > 0)
            {
                base.method_914(type);
            }
            base.method_9(Class518.class337_30);
            if (node is Class380)
            {
                base.method_911(type);
            }
            else
            {
                base.method_910(type);
            }
            base.method_912(type);
            base.method_9(Class634.class339_55);
            bool flag = this.method_927(type.enum0_0, type.int_4);
            if (type.short_2 > 0)
            {
                base.method_919(type, Enum35.const_0, flag);
            }
            if (flag || (type.short_2 > 0))
            {
                base.method_9(Class518.class337_12);
            }
            if (type.short_0 > 0)
            {
                base.method_915(type);
            }
        }
    }
}

