namespace ns0
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    internal class Class868
    {
    	internal static List<Bitmap> list_0 = new List<Bitmap>();
        private static List<byte[]> list_1 = new List<byte[]>();
        
        internal static Bitmap bitmap_0 = new Bitmap(new MemoryStream(Class542.Byte_49));
        internal static Bitmap bitmap_1 = new Bitmap(new MemoryStream(Class542.Byte_89));
        internal static Bitmap bitmap_2 = new Bitmap(new MemoryStream(Class542.Byte_69));
        internal static Bitmap bitmap_3 = new Bitmap(new MemoryStream(Class542.Byte_6));
        internal static Icon icon_0 = Icon.FromHandle(new Bitmap(new MemoryStream(Class542.Byte_33)).GetHicon());
        internal static int int_0 = smethod_0(Class542.Byte_47);
        internal static int int_1 = smethod_0(Class542.Byte_0);
        internal static int int_10 = smethod_0(Class542.Byte_20);
        internal static int int_11 = smethod_0(Class542.Byte_22);
        internal static int int_12 = smethod_0(Class542.Byte_48);
        internal static int int_13 = smethod_0(Class542.Byte_10);
        internal static int int_14 = smethod_0(Class542.Byte_64);
        internal static int int_15 = smethod_0(Class542.Byte_99);
        internal static int int_16 = smethod_0(Class542.Byte_101);
        internal static int int_17 = smethod_0(Class542.Byte_16);
        internal static int int_18 = smethod_0(Class542.Byte_84);
        internal static int int_19 = smethod_0(Class542.Byte_95);
        internal static int int_2 = smethod_0(Class542.Byte_24);
        internal static int int_20 = smethod_0(Class542.Byte_90);
        internal static int int_21 = smethod_0(Class542.Byte_72);
        internal static int int_22 = smethod_0(Class542.Byte_83);
        internal static int int_23 = smethod_0(Class542.Byte_36);
        internal static int int_24 = smethod_0(Class542.Byte_17);
        internal static int int_25 = smethod_0(Class542.Byte_9);
        internal static int int_26 = smethod_0(Class542.Byte_102);
        internal static int int_27 = smethod_0(Class542.Byte_15);
        internal static int int_28 = smethod_0(Class542.Byte_65);
        internal static int int_29 = smethod_0(Class542.Byte_3);
        internal static int int_3 = smethod_0(Class542.Byte_30);
        internal static int int_30 = smethod_0(Class542.Byte_32);
        internal static int int_31 = smethod_0(Class542.Byte_55);
        internal static int int_32 = smethod_0(Class542.Byte_81);
        internal static int int_33 = smethod_0(Class542.Byte_31);
        internal static int int_34 = smethod_0(Class542.Byte_87);
        internal static int int_35 = smethod_0(Class542.Byte_33);
        internal static int int_36 = smethod_0(Class542.Byte_50);
        internal static int int_37 = smethod_0(Class542.Byte_34);
        internal static int int_38 = smethod_0(Class542.Byte_78);
        internal static int int_39 = smethod_0(Class542.Byte_74);
        internal static int int_4 = smethod_0(Class542.Byte_39);
        internal static int int_40 = smethod_0(Class542.Byte_85);
        internal static int int_41 = smethod_0(Class542.Byte_41);
        internal static int int_42 = smethod_0(Class542.Byte_86);
        internal static int int_43 = smethod_0(Class542.Byte_5);
        internal static int int_44 = smethod_0(Class542.Byte_26);
        internal static int int_45 = smethod_0(Class542.Byte_37);
        internal static int int_46 = smethod_0(Class542.Byte_13);
        internal static int int_47 = smethod_0(Class542.Byte_62);
        internal static int int_48 = smethod_0(Class542.Byte_7);
        internal static int int_49 = smethod_0(Class542.Byte_11);
        internal static int int_5 = smethod_0(Class542.Byte_88);
        internal static int int_50 = smethod_0(Class542.Byte_23);
        internal static int int_51 = smethod_0(Class542.Byte_42);
        internal static int int_52 = smethod_0(Class542.Byte_60);
        internal static int int_53 = smethod_0(Class542.Byte_53);
        internal static int int_54 = smethod_0(Class542.Byte_56);
        internal static int int_55 = smethod_0(Class542.Byte_40);
        internal static int int_56 = smethod_0(Class542.Byte_51);
        internal static int int_57 = smethod_0(Class542.Byte_73);
        internal static int int_58 = smethod_0(Class542.Byte_38);
        internal static int int_59 = smethod_0(Class542.Byte_27);
        internal static int int_6 = smethod_0(Class542.Byte_77);
        internal static int int_60 = smethod_0(Class542.Byte_2);
        internal static int int_61 = smethod_0(Class542.Byte_92);
        internal static int int_62 = smethod_0(Class542.Byte_43);
        internal static int int_63 = smethod_0(Class542.Byte_59);
        internal static int int_64 = smethod_0(Class542.Byte_61);
        internal static int int_65 = smethod_0(Class542.Byte_91);
        internal static int int_66 = smethod_0(Class542.Byte_98);
        internal static int int_67 = smethod_0(Class542.Byte_58);
        internal static int int_68 = smethod_0(Class542.Byte_63);
        internal static int int_69 = smethod_0(Class542.Byte_96);
        internal static int int_7 = smethod_0(Class542.Byte_66);
        internal static int int_70 = smethod_0(Class542.Byte_28);
        internal static int int_71 = smethod_0(Class542.Byte_18);
        internal static int int_72 = smethod_0(Class542.Byte_68);
        internal static int int_73 = smethod_0(Class542.Byte_71);
        internal static int int_74 = smethod_0(Class542.Byte_4);
        internal static int int_75 = smethod_0(Class542.Byte_100);
        internal static int int_76 = smethod_0(Class542.Byte_57);
        internal static int int_8 = smethod_0(Class542.Byte_1);
        internal static int int_9 = smethod_0(Class542.Byte_93);

        private static int smethod_0(byte[] A_0)
        {
            list_1.Add(A_0);
            return (list_1.Count - 1);
        }

        internal static void smethod_1(ImageList.ImageCollection A_0)
        {
            for (int i = 0; i < list_1.Count; i++)
            {
                byte[] buffer = list_1[i];
                Bitmap bitmap = new Bitmap(new MemoryStream(buffer));
                A_0.Add(bitmap);
                list_0.Add(bitmap);
            }
            list_1.Clear();
            list_1 = null;
        }
    }
}

