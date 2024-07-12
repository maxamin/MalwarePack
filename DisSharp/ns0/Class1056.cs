namespace ns0
{
    using System;
    using System.Collections;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;

    internal class Class1056
    {
        private static string string_0 = Class537.string_57;

        internal static byte[] smethod_0(string A_0)
        {
            Stream manifestResourceStream = Assembly.GetAssembly(System.Type.GetType(string_0)).GetManifestResourceStream(A_0);
            Class656 class2 = new Class656(manifestResourceStream);
            return class2.ReadBytes((int) manifestResourceStream.Length);
        }

        internal static Stream smethod_1(string A_0)
        {
            return Assembly.GetAssembly(System.Type.GetType(string_0)).GetManifestResourceStream(A_0);
        }

        internal static Bitmap smethod_2(string A_0)
        {
            return new Bitmap(Assembly.GetAssembly(System.Type.GetType(string_0)).GetManifestResourceStream(A_0));
        }

        internal static Bitmap[] smethod_3(string A_0, string[] A_1)
        {
            Assembly assembly = Assembly.GetAssembly(System.Type.GetType(string_0));
            Bitmap[] bitmapArray = new Bitmap[A_1.Length];
            for (int i = 0; i < A_1.Length; i++)
            {
                try
                {
                    Stream manifestResourceStream = assembly.GetManifestResourceStream(A_0 + A_1[i]);
                    bitmapArray[i] = new Bitmap(manifestResourceStream);
                }
                catch
                {
                    throw;
                }
            }
            return bitmapArray;
        }

        internal static Bitmap[] smethod_4(string A_0, ArrayList A_1)
        {
            Assembly assembly = Assembly.GetAssembly(System.Type.GetType(string_0));
            Bitmap[] bitmapArray = new Bitmap[A_1.Count];
            for (int i = 0; i < A_1.Count; i++)
            {
                string str = (string) A_1[i];
                try
                {
                    Stream manifestResourceStream = assembly.GetManifestResourceStream(A_0 + str);
                    bitmapArray[i] = new Bitmap(manifestResourceStream);
                }
                catch
                {
                    throw;
                }
            }
            return bitmapArray;
        }

        internal static ImageList smethod_5(byte[] A_0, Size A_1, Point A_2)
        {
            return smethod_6(A_0, A_1, true, A_2);
        }

        internal static ImageList smethod_6(byte[] A_0, Size A_1, bool A_2, Point A_3)
        {
            ImageList list = new ImageList {
                ImageSize = A_1
            };
            Bitmap bitmap = new Bitmap(new MemoryStream(A_0));
            if (A_2)
            {
                Color pixel = bitmap.GetPixel(A_3.X, A_3.Y);
                bitmap.MakeTransparent(pixel);
            }
            list.Images.AddStrip(bitmap);
            return list;
        }
    }
}

