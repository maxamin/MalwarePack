namespace ns0
{
    using System;
    using System.Management;

    internal class Class1077
    {
        internal string string_0 = "";
        internal string string_1 = "";
        internal string string_10 = "";
        internal string string_11 = "";
        internal string string_2 = "";
        internal string string_3 = "";
        internal string string_4 = "";
        internal string string_5 = "";
        internal string string_6 = "";
        internal string string_7 = "";
        internal string string_8 = "";
        internal string string_9 = "";

        internal bool method_0(Class1077 A_1)
        {
            return (((((this.string_0 == A_1.string_0) && (this.string_2 == A_1.string_2)) && (this.string_5 == A_1.string_5)) && (this.string_6 == A_1.string_6)) && (this.string_7 == A_1.string_7));
        }

        internal void method_1(Class524 A_1)
        {
            A_1.Write(this.string_0);
            A_1.Write(this.string_1);
            A_1.Write(this.string_2);
            A_1.Write(this.string_3);
            A_1.Write(this.string_4);
            A_1.Write(this.string_5);
            A_1.Write(this.string_6);
            A_1.Write(this.string_7);
            A_1.Write(this.string_8);
            A_1.Write(this.string_9);
            A_1.Write(this.string_10);
            A_1.Write(this.string_11);
        }

        internal void method_2(Class656 A_1, byte A_2)
        {
            this.string_0 = A_1.ReadString();
            this.string_1 = A_1.ReadString();
            this.string_2 = A_1.ReadString();
            this.string_3 = A_1.ReadString();
            this.string_4 = A_1.ReadString();
            this.string_5 = A_1.ReadString();
            this.string_6 = A_1.ReadString();
            this.string_7 = A_1.ReadString();
            this.string_8 = A_1.ReadString();
            this.string_9 = A_1.ReadString();
            this.string_10 = A_1.ReadString();
            this.string_11 = A_1.ReadString();
        }

        internal void method_3()
        {
            try
            {
                this.method_5();
                this.method_6();
            }
            catch
            {
            }
        }

        internal void method_4()
        {
            try
            {
                this.method_5();
            }
            catch
            {
            }
        }

        private void method_5()
        {
            this.string_0 = Environment.MachineName;
            this.string_1 = Environment.OSVersion.Version.ToString();
            this.string_2 = Environment.SystemDirectory;
            Class987 class2 = Class987.Class987_1.method_0(Class537.string_170);
            int num = (int) class2.method_1(Class537.string_718, 0L);
            this.string_4 = (num == 0) ? "" : num.ToString();
            this.string_5 = (string) class2.method_1(Class537.string_573, "");
            this.string_6 = (string) class2.method_1(Class537.string_167, "");
            this.string_7 = (string) class2.method_1(Class537.string_767, "");
        }

        private void method_6()
        {
            string str;
            try
            {
                ManagementClass class2 = new ManagementClass(Class537.string_835);
                using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = class2.GetInstances().GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        ManagementObject current = (ManagementObject) enumerator.Current;
                        str = current[Class537.string_393] as string;
                        this.string_3 = (str != null) ? str : "";
                    }
                }
            }
            catch
            {
            }
            Class582.smethod_0();
            try
            {
                ManagementClass class3 = new ManagementClass(Class537.string_472);
                using (ManagementObjectCollection.ManagementObjectEnumerator enumerator2 = class3.GetInstances().GetEnumerator())
                {
                    if (enumerator2.MoveNext())
                    {
                        ManagementObject obj3 = (ManagementObject) enumerator2.Current;
                        str = obj3[Class537.string_416] as string;
                        this.string_8 = (str != null) ? str : "";
                        str = obj3[Class537.string_779] as string;
                        this.string_9 = (str != null) ? str : "";
                    }
                }
            }
            catch
            {
            }
            Class582.smethod_0();
            try
            {
                ManagementClass class4 = new ManagementClass(Class537.string_827);
                using (ManagementObjectCollection.ManagementObjectEnumerator enumerator3 = class4.GetInstances().GetEnumerator())
                {
                    if (enumerator3.MoveNext())
                    {
                        ManagementObject obj4 = (ManagementObject) enumerator3.Current;
                        str = obj4[Class537.string_364] as string;
                        this.string_11 = (str != null) ? str : "";
                    }
                }
            }
            catch
            {
            }
            Class582.smethod_0();
            try
            {
                ManagementClass class5 = new ManagementClass(Class537.string_647);
                using (ManagementObjectCollection.ManagementObjectEnumerator enumerator4 = class5.GetInstances().GetEnumerator())
                {
                    if (enumerator4.MoveNext())
                    {
                        ManagementObject obj5 = (ManagementObject) enumerator4.Current;
                        str = obj5[Class537.string_550] as string;
                        this.string_10 = (str != null) ? str : "";
                    }
                }
            }
            catch
            {
            }
            Class582.smethod_0();
        }
    }
}

