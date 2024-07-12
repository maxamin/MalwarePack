namespace ns0
{
    using Microsoft.Win32;
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    internal class Class966
    {
        private static int[] int_0 = null;

        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        private static extern int GetSysColor(int nIndex);
        internal static bool smethod_0(System.Drawing.Color A_0)
        {
            int num = A_0.ToArgb();
            for (int i = 0; i < int_0.Length; i++)
            {
                if (int_0[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        internal static System.Drawing.Color smethod_1(int A_0)
        {
            smethod_3();
            for (int i = 0; i < int_0.Length; i++)
            {
                int num2 = int_0[i];
                if (num2 == A_0)
                {
                    return System.Drawing.Color.FromKnownColor((KnownColor) i);
                }
            }
            return System.Drawing.Color.FromArgb(A_0);
        }

        internal static int smethod_2(KnownColor A_0)
        {
            smethod_3();
            if (A_0 <= KnownColor.YellowGreen)
            {
                return int_0[(int) A_0];
            }
            return 0;
        }

        private static void smethod_3()
        {
            if (int_0 == null)
            {
                smethod_4();
            }
        }

        private static void smethod_4()
        {
            int[] numArray = new int[0xa8];
            SystemEvents.UserPreferenceChanging += new UserPreferenceChangingEventHandler(Class966.smethod_5);
            smethod_6(numArray);
            numArray[0x1b] = 0xffffff;
            numArray[0x1c] = -984833;
            numArray[0x1d] = -332841;
            numArray[30] = -16711681;
            numArray[0x1f] = -8388652;
            numArray[0x20] = -983041;
            numArray[0x21] = -657956;
            numArray[0x22] = -6972;
            numArray[0x23] = -16777216;
            numArray[0x24] = -5171;
            numArray[0x25] = -16776961;
            numArray[0x26] = -7722014;
            numArray[0x27] = -5952982;
            numArray[40] = -2180985;
            numArray[0x29] = -10510688;
            numArray[0x2a] = -8388864;
            numArray[0x2b] = -2987746;
            numArray[0x2c] = -32944;
            numArray[0x2d] = -10185235;
            numArray[0x2e] = -1828;
            numArray[0x2f] = -2354116;
            numArray[0x30] = -16711681;
            numArray[0x31] = -16777077;
            numArray[50] = -16741493;
            numArray[0x33] = -4684277;
            numArray[0x34] = -5658199;
            numArray[0x35] = -16751616;
            numArray[0x36] = -4343957;
            numArray[0x37] = -7667573;
            numArray[0x38] = -11179217;
            numArray[0x39] = -29696;
            numArray[0x3a] = -6737204;
            numArray[0x3b] = -7667712;
            numArray[60] = -1468806;
            numArray[0x3d] = -7357301;
            numArray[0x3e] = -12042869;
            numArray[0x3f] = -13676721;
            numArray[0x40] = -16724271;
            numArray[0x41] = -7077677;
            numArray[0x42] = -60269;
            numArray[0x43] = -16728065;
            numArray[0x44] = -9868951;
            numArray[0x45] = -14774017;
            numArray[70] = -5103070;
            numArray[0x47] = -1296;
            numArray[0x48] = -14513374;
            numArray[0x49] = -65281;
            numArray[0x4a] = -2302756;
            numArray[0x4b] = -460545;
            numArray[0x4c] = -10496;
            numArray[0x4d] = -2448096;
            numArray[0x4e] = -8355712;
            numArray[0x4f] = -16744448;
            numArray[80] = -5374161;
            numArray[0x51] = -983056;
            numArray[0x52] = -38476;
            numArray[0x53] = -3318692;
            numArray[0x54] = -11861886;
            numArray[0x55] = -16;
            numArray[0x56] = -989556;
            numArray[0x57] = -1644806;
            numArray[0x58] = -3851;
            numArray[0x59] = -8586240;
            numArray[90] = -1331;
            numArray[0x5b] = -5383962;
            numArray[0x5c] = -1015680;
            numArray[0x5d] = -2031617;
            numArray[0x5e] = -329006;
            numArray[0x5f] = -2894893;
            numArray[0x60] = -7278960;
            numArray[0x61] = -18751;
            numArray[0x62] = -24454;
            numArray[0x63] = -14634326;
            numArray[100] = -7876870;
            numArray[0x65] = -8943463;
            numArray[0x66] = -5192482;
            numArray[0x67] = -32;
            numArray[0x68] = -16711936;
            numArray[0x69] = -13447886;
            numArray[0x6a] = -331546;
            numArray[0x6b] = -65281;
            numArray[0x6c] = -8388608;
            numArray[0x6d] = -10039894;
            numArray[110] = -16777011;
            numArray[0x6f] = -4565549;
            numArray[0x70] = -7114533;
            numArray[0x71] = -12799119;
            numArray[0x72] = -8689426;
            numArray[0x73] = -16713062;
            numArray[0x74] = -12004916;
            numArray[0x75] = -3730043;
            numArray[0x76] = -15132304;
            numArray[0x77] = -655366;
            numArray[120] = -6943;
            numArray[0x79] = -6987;
            numArray[0x7a] = -8531;
            numArray[0x7b] = -16777088;
            numArray[0x7c] = -133658;
            numArray[0x7d] = -8355840;
            numArray[0x7e] = -9728477;
            numArray[0x7f] = -23296;
            numArray[0x80] = -47872;
            numArray[0x81] = -2461482;
            numArray[130] = -1120086;
            numArray[0x83] = -6751336;
            numArray[0x84] = -5247250;
            numArray[0x85] = -2396013;
            numArray[0x86] = -4139;
            numArray[0x87] = -9543;
            numArray[0x88] = -3308225;
            numArray[0x89] = -16181;
            numArray[0x8a] = -2252579;
            numArray[0x8b] = -5185306;
            numArray[140] = -8388480;
            numArray[0x8d] = -65536;
            numArray[0x8e] = -4419697;
            numArray[0x8f] = -12490271;
            numArray[0x90] = -7650029;
            numArray[0x91] = -360334;
            numArray[0x92] = -744352;
            numArray[0x93] = -13726889;
            numArray[0x94] = -2578;
            numArray[0x95] = -6270419;
            numArray[150] = -4144960;
            numArray[0x97] = -7876885;
            numArray[0x98] = -9807155;
            numArray[0x99] = -9404272;
            numArray[0x9a] = -1286;
            numArray[0x9b] = -16711809;
            numArray[0x9c] = -12156236;
            numArray[0x9d] = -2968436;
            numArray[0x9e] = -16744320;
            numArray[0x9f] = -2572328;
            numArray[160] = -40121;
            numArray[0xa1] = -12525360;
            numArray[0xa2] = -1146130;
            numArray[0xa3] = -663885;
            numArray[0xa4] = -1;
            numArray[0xa5] = -657931;
            numArray[0xa6] = -256;
            numArray[0xa7] = -6632142;
            int_0 = numArray;
        }

        private static void smethod_5(object sender, UserPreferenceChangingEventArgs e)
        {
            if ((e.Category == UserPreferenceCategory.Color) && (int_0 != null))
            {
                smethod_6(int_0);
            }
        }

        private static void smethod_6(int[] A_0)
        {
            A_0[1] = smethod_7(10);
            A_0[2] = smethod_7(2);
            A_0[3] = smethod_7(9);
            A_0[4] = smethod_7(12);
            A_0[5] = smethod_7(15);
            A_0[6] = smethod_7(0x10);
            A_0[7] = smethod_7(0x15);
            A_0[8] = smethod_7(0x16);
            A_0[9] = smethod_7(20);
            A_0[10] = smethod_7(0x12);
            A_0[11] = smethod_7(1);
            A_0[12] = smethod_7(0x11);
            A_0[13] = smethod_7(13);
            A_0[14] = smethod_7(14);
            A_0[15] = smethod_7(0x1a);
            A_0[0x10] = smethod_7(11);
            A_0[0x11] = smethod_7(3);
            A_0[0x12] = smethod_7(0x13);
            A_0[0x13] = smethod_7(0x18);
            A_0[20] = smethod_7(0x17);
            A_0[0x15] = smethod_7(4);
            A_0[0x16] = smethod_7(7);
            A_0[0x17] = smethod_7(0);
            A_0[0x18] = smethod_7(5);
            A_0[0x19] = smethod_7(6);
            A_0[0x1a] = smethod_7(8);
        }

        private static int smethod_7(int A_0)
        {
            return smethod_8(GetSysColor(A_0));
        }

        private static int smethod_8(int A_0)
        {
            return smethod_9(0xff, A_0 & 0xff, (A_0 >> 8) & 0xff, (A_0 >> 0x10) & 0xff);
        }

        private static int smethod_9(int A_0, int A_1, int A_2, int A_3)
        {
            return ((((A_1 << 0x10) | (A_2 << 8)) | A_3) | (A_0 << 0x18));
        }
    }
}

