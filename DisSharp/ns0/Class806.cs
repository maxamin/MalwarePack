namespace ns0
{
    using System;
    using System.Collections;
    using System.Text;

    internal class Class806
    {
        private static Hashtable hashtable_0 = new Hashtable();
        private static StringBuilder stringBuilder_0 = new StringBuilder();

        internal static Class336 smethod_0(int A_0)
        {
            return smethod_1((char) A_0);
        }

        internal static Class336 smethod_1(char A_0)
        {
            Class336 class2;
            int num = A_0;
            object key = num;
            if (hashtable_0.ContainsKey(key))
            {
                return (Class336) hashtable_0[key];
            }
            switch (num)
            {
                case 0:
                    class2 = new Class336(@"'\0'");
                    break;

                case 7:
                    class2 = new Class336(@"'\a'");
                    break;

                case 8:
                    class2 = new Class336(@"'\b'");
                    break;

                case 9:
                    class2 = new Class336(@"'\t'");
                    break;

                case 10:
                    class2 = new Class336(@"'\n'");
                    break;

                case 11:
                    class2 = new Class336(@"'\v'");
                    break;

                case 12:
                    class2 = new Class336(@"'\f'");
                    break;

                case 13:
                    class2 = new Class336(@"'\r'");
                    break;

                case 0x22:
                    class2 = new Class336("'\\\"'");
                    break;

                case 0x27:
                    class2 = new Class336(@"'\''");
                    break;

                case 0x5c:
                    class2 = new Class336(@"'\\'");
                    break;

                default:
                    if ((num >= 0x20) && ((num <= 0x7e) || !Class516.bool_8))
                    {
                        stringBuilder_0.Length = 0;
                        stringBuilder_0.Append("'");
                        stringBuilder_0.Append(A_0);
                        stringBuilder_0.Append("'");
                        class2 = new Class336(stringBuilder_0.ToString());
                    }
                    else
                    {
                        stringBuilder_0.Length = 0;
                        stringBuilder_0.Append(@"'\x");
                        stringBuilder_0.Append(num.ToString("X").PadLeft(4, '0'));
                        stringBuilder_0.Append("'");
                        class2 = new Class336(stringBuilder_0.ToString());
                    }
                    break;
            }
            hashtable_0.Add(key, class2);
            return class2;
        }
    }
}

