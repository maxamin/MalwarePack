namespace ns0
{
    using Microsoft.Win32;
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    internal class Class1043
    {
        private static string string_0 = Class537.string_491;
        private static string string_1 = Class537.string_786;
        private static string string_10 = Class537.string_294;
        private static string string_11 = Class537.string_86;
        private static string string_12 = Class537.string_954;
        private static string string_13 = Class537.string_753;
        private static string string_14 = Class537.string_107;
        private static string string_15 = Class537.string_94;
        private static string string_16 = Class537.string_653;
        private static string string_17 = Class537.string_408;
        private static string string_18 = Class537.string_590;
        private static string string_19 = Class537.string_571;
        private static string string_2 = Class537.string_635;
        private static string string_20 = Class537.string_644;
        private static string string_3 = Class537.string_950;
        private static string string_4 = Class537.string_356;
        private static string string_5 = Class537.string_159;
        private static string string_6 = Class537.string_858;
        private static string string_7 = Class537.string_244;
        private static string string_8 = Class537.string_853;
        private static string string_9 = Class537.string_322;

        internal Class1043(Form A_1)
        {
            A_1.Load += new EventHandler(this.method_0);
            A_1.Closed += new EventHandler(this.method_1);
            A_1.Closing += new CancelEventHandler(this.method_2);
        }

        private void method_0(object sender, EventArgs e)
        {
            this.method_3();
            Class1042.smethod_2();
        }

        private void method_1(object sender, EventArgs e)
        {
            this.method_5();
        }

        private void method_2(object sender, CancelEventArgs e)
        {
            e.Cancel = Class645.smethod_10();
        }

        private void method_3()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(Class537.string_376);
            try
            {
                Class1042.smethod_0(key);
                Class516.bool_0 = ((int) key.GetValue(string_0, this.method_4(true))) == 1;
                Class516.Boolean_0 = ((int) key.GetValue(string_1, this.method_4(false))) == 1;
                Class516.bool_4 = ((int) key.GetValue(string_2, this.method_4(false))) == 1;
                Class516.bool_11 = ((int) key.GetValue(string_3, this.method_4(true))) == 1;
                Class516.bool_5 = ((int) key.GetValue(string_4, this.method_4(false))) == 1;
                Class516.bool_6 = ((int) key.GetValue(string_5, this.method_4(false))) == 1;
                Class516.bool_14 = ((int) key.GetValue(string_6, this.method_4(true))) == 1;
                Class516.bool_15 = ((int) key.GetValue(string_7, this.method_4(true))) == 1;
                Class516.bool_16 = ((int) key.GetValue(string_8, this.method_4(false))) == 1;
                Class516.bool_20 = ((int) key.GetValue(string_9, this.method_4(false))) == 1;
                Class516.bool_21 = ((int) key.GetValue(string_10, this.method_4(false))) == 1;
                Class516.int_2 = (int) key.GetValue(string_11, 4);
                Class516.int_9 = (int) key.GetValue(string_12, 10);
                Class516.bool_8 = ((int) key.GetValue(string_13, this.method_4(true))) == 1;
                Class516.bool_9 = ((int) key.GetValue(string_14, this.method_4(true))) == 1;
                Class516.bool_10 = ((int) key.GetValue(string_15, this.method_4(false))) == 1;
                Class516.string_0 = (string) key.GetValue(string_17, "Microsoft Sans Serif");
                float num = 8.25f;
                Class516.float_0 = float.Parse((string) key.GetValue(string_18, num.ToString()));
                Class516.string_1 = (string) key.GetValue(string_19, "Courier New");
                float num2 = 11f;
                Class516.float_1 = float.Parse((string) key.GetValue(string_20, num2.ToString()));
            }
            catch
            {
            }
            finally
            {
                if (key != null)
                {
                    ((IDisposable) key).Dispose();
                }
            }
        }

        private int method_4(bool A_1)
        {
            if (!A_1)
            {
                return 0;
            }
            return 1;
        }

        private void method_5()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(Class537.string_376);
            try
            {
                Class1042.smethod_1(key);
                key.SetValue(string_0, Class516.bool_0 ? 1 : 0);
                key.SetValue(string_1, Class516.Boolean_0 ? 1 : 0);
                key.SetValue(string_2, Class516.bool_4 ? 1 : 0);
                key.SetValue(string_3, Class516.bool_11 ? 1 : 0);
                key.SetValue(string_4, Class516.bool_5 ? 1 : 0);
                key.SetValue(string_5, Class516.bool_6 ? 1 : 0);
                key.SetValue(string_6, Class516.bool_14 ? 1 : 0);
                key.SetValue(string_7, Class516.bool_15 ? 1 : 0);
                key.SetValue(string_8, Class516.bool_16 ? 1 : 0);
                key.SetValue(string_9, Class516.bool_20 ? 1 : 0);
                key.SetValue(string_10, Class516.bool_21 ? 1 : 0);
                key.SetValue(string_11, Class516.int_2);
                key.SetValue(string_12, Class516.int_9);
                key.SetValue(string_13, Class516.bool_8 ? 1 : 0);
                key.SetValue(string_14, Class516.bool_9 ? 1 : 0);
                key.SetValue(string_15, Class516.bool_10 ? 1 : 0);
                key.SetValue(string_17, Class516.string_0);
                key.SetValue(string_18, Class516.float_0);
                key.SetValue(string_19, Class516.string_1);
                key.SetValue(string_20, Class516.float_1);
            }
            catch
            {
            }
            finally
            {
                if (key != null)
                {
                    ((IDisposable) key).Dispose();
                }
            }
        }
    }
}

