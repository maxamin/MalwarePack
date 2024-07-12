namespace ns0
{
    using System;
    using System.IO;

    internal class Stream0 : FileStream
    {
        internal Stream0(string A_1, FileMode A_2, FileAccess A_3, FileShare A_4) : base(A_1, A_2, A_3, A_4)
        {
        }

        internal Stream0(string A_1, FileMode A_2, FileAccess A_3, FileShare A_4, int A_5) : base(A_1, A_2, A_3, A_4, A_5)
        {
        }
    }
}

