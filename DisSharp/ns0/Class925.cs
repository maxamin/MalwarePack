namespace ns0
{
    using System;

    internal class Class925
    {
        private static bool bool_0;

        internal static void smethod_0(Class705 A_0)
        {
            if (!bool_0 && (A_0 != null))
            {
                try
                {
                    bool_0 = true;
                    A_0.method_0();
                }
                catch (Exception exc)
                {
                }
                finally
                {
                    bool_0 = false;
                }
            }
        }
    }
}

