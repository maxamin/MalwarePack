namespace ns0
{
    using System;
    using System.Drawing;

    internal class Class1011 : IDisposable
    {
        private bool bool_0;
        private IntPtr intptr_0;

        internal Class1011(IntPtr A_1, bool A_2)
        {
            this.intptr_0 = A_1;
            this.bool_0 = A_2;
        }

        internal Class1011(string A_1, ulong A_2)
        {
            try
            {
                this.bool_0 = true;
                this.intptr_0 = Class1012.LoadLibraryEx(A_1, IntPtr.Zero, A_2);
                if (IntPtr.Zero == this.intptr_0)
                {
                    Class1012.smethod_0();
                }
            }
            catch
            {
                this.intptr_0 = IntPtr.Zero;
            }
        }

        public void Dispose()
        {
            this.method_0();
        }

        ~Class1011()
        {
            this.method_0();
        }

        internal void method_0()
        {
            if (this.bool_0 && (IntPtr.Zero != this.intptr_0))
            {
                Class1012.FreeLibrary(this.intptr_0);
            }
            this.intptr_0 = IntPtr.Zero;
        }

        internal int method_1(IntPtr A_1, Delegate2 A_2, IntPtr A_3)
        {
            return Class1012.EnumResourceNames(this.intptr_0, A_1, A_2, A_3);
        }

        internal IntPtr method_2(IntPtr A_1, IntPtr A_2)
        {
            IntPtr ptr = Class1012.FindResource(this.intptr_0, A_1, A_2);
            if (IntPtr.Zero == ptr)
            {
                Class1012.smethod_0();
            }
            return ptr;
        }

        internal IntPtr method_3(IntPtr A_1)
        {
            IntPtr ptr = Class1012.LoadResource(this.intptr_0, A_1);
            if (IntPtr.Zero == ptr)
            {
                Class1012.smethod_0();
            }
            return ptr;
        }

        internal uint method_4(IntPtr A_1)
        {
            uint num = Class1012.SizeofResource(this.intptr_0, A_1);
            if (num == 0)
            {
                Class1012.smethod_0();
            }
            return num;
        }

        internal Icon method_5(IntPtr A_1)
        {
            IntPtr handle = Class1012.LoadIcon(this.intptr_0, A_1);
            if (IntPtr.Zero == handle)
            {
                Class1012.smethod_0();
            }
            return Icon.FromHandle(handle);
        }

        internal static IntPtr smethod_0(IntPtr A_0)
        {
            IntPtr ptr = Class1012.LockResource(A_0);
            if (IntPtr.Zero == ptr)
            {
                Class1012.smethod_0();
            }
            return ptr;
        }

        internal IntPtr IntPtr_0
        {
            get
            {
                return this.intptr_0;
            }
        }
    }
}

