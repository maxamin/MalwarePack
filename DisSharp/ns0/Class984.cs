namespace ns0
{
    using Microsoft.Win32;
    using System;

    internal class Class984
    {
        private Class582 class582_0;

        internal void method_0(Class582 A_1)
        {
            this.class582_0 = A_1;
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(this.method_2);
        }

        internal void method_1()
        {
            SystemEvents.UserPreferenceChanged -= new UserPreferenceChangedEventHandler(this.method_2);
        }

        private void method_2(object sender, UserPreferenceChangedEventArgs e)
        {
            Class645.class704_0.method_16();
            Class516.smethod_4();
        }
    }
}

