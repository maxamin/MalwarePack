namespace ns0
{
    using System;
    using System.IO;

    internal class Class953
    {
        internal void method_0(StreamWriter A_1, byte[] A_2)
        {
            for (int i = 0; i < A_2.Length; i++)
            {
                if (A_2[i] != 0)
                {
                    A_1.Write((char) A_2[i]);
                }
            }
            A_1.WriteLine();
        }
    }
}

