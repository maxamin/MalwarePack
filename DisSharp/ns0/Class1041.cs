namespace ns0
{
    using System;
    using System.IO;
    using System.Security.Cryptography;

    internal class Class1041
    {
        internal static byte[] smethod_0(MemoryStream A_0)
        {
            byte[] buffer = A_0.ToArray();
            byte[] rgbIV = Class542.Byte_54;
            byte[] rgbKey = Class542.Byte_94;
            ICryptoTransform transform = new RijndaelManaged().CreateEncryptor(rgbKey, rgbIV);
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(buffer, 0, buffer.Length);
            stream2.FlushFinalBlock();
            return stream.ToArray();
        }

        internal static byte[] smethod_1(MemoryStream A_0)
        {
            return smethod_2(A_0.ToArray());
        }

        internal static byte[] smethod_2(byte[] A_0)
        {
            byte[] rgbIV = Class542.Byte_54;
            byte[] rgbKey = Class542.Byte_94;
            ICryptoTransform transform = new RijndaelManaged().CreateDecryptor(rgbKey, rgbIV);
            MemoryStream stream = new MemoryStream(A_0);
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
            byte[] buffer = new byte[A_0.Length];
            stream2.Read(buffer, 0, buffer.Length);
            return buffer;
        }

        internal static HashAlgorithm HashAlgorithm_0
        {
            get
            {
                return new SHA256Managed();
            }
        }
    }
}

