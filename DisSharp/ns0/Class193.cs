namespace ns0
{
    using System;
    using System.Collections.Specialized;

    internal abstract class Class193 : Class192
    {
        protected Class193()
        {
        }

        internal override void QRYY()
        {
            base.method_10(Class613.class339_137);
            base.method_9(Class615.class336_6);
            base.method_9(Class518.class337_19);
            base.method_10(Class613.class339_137);
            base.method_9(Class615.class336_7);
            base.method_9(Class518.class337_19);
        }

        internal override void QRYZ(StringCollection strings)
        {
            base.method_7();
            for (int i = 0; i < strings.Count; i++)
            {
                base.method_10(this.QRTX());
                base.method_9(new Class338(strings[i]));
            }
            base.method_7();
        }

        internal override void QRYZ(string str)
        {
            base.method_7();
            base.method_10(this.QRTX());
            base.method_9(new Class338(str));
            base.method_7();
        }

        internal override void QRZQ()
        {
            string str = Class519.class394_0.class637_0.method_2();
            if (Class516.Boolean_0)
            {
                base.method_10(new Class336(Class537.string_513 + Class537.string_740 + str + "\")]"));
            }
            else
            {
                base.method_10(new Class336(Class537.string_513 + Class537.string_344 + str + "\")]"));
            }
        }

        internal override void QRZR(Class550.Class514 row, bool assembly)
        {
            base.method_10(Class518.class337_7);
            if (assembly)
            {
                base.method_9(Class584.class336_3);
            }
            else
            {
                base.method_9(Class584.class336_4);
            }
            base.method_9(Class518.class337_17);
            base.method_164(row);
            base.method_9(Class518.class337_8);
        }
    }
}

