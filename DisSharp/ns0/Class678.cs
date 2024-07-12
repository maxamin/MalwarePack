namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Reflection;
    using System.Text;

    internal class Class678 : Class677
    {
        private Assembly[] assembly_0;
        private Assembly assembly_1;
        private Assembly assembly_2;
        private BindingFlags bindingFlags_0 = (BindingFlags.SetProperty | BindingFlags.GetProperty | BindingFlags.FlattenHierarchy | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
        private CallingConventions callingConventions_0 = CallingConventions.Standard;
        private static Class367 class367_0;
        private static Class397 class397_0 = new Class397();
        private static Class48 class48_2 = new Class48();
        private static Class602 class602_0 = new Class602();
        private static Enum60 enum60_0;
        private static int int_9;
        private static string string_79 = Class537.string_261;
        private static string string_80 = Class537.string_845;
        private static string string_81 = Class537.string_586;
        private string string_82 = (Class537.string_833 + Class518.class337_13 + Class537.string_652);
        private static string string_83 = Class537.string_657;
        private static string string_84 = Class537.string_630;
        private static string string_85 = Class537.string_927;
        private StringBuilder stringBuilder_0 = new StringBuilder();
        private Type[] type_0;
        private Type[] type_1;
        private const ushort ushort_0 = 0x3010;

        static Class678()
        {
            class397_0.method_8();
            class367_0 = class397_0.Class367_1;
        }

        internal void method_116()
        {
            string str = base.class394_0.Name.ToLower();
            if ((str != string_79) && (str != string_80))
            {
                this.type_0 = new Type[base.class684_0.class553_0.arrayList_0.Count];
                this.type_1 = new Type[base.class684_0.class548_0.arrayList_0.Count];
                bool flag = Class516.Boolean_0;
                Class516.Boolean_0 = true;
                this.method_117();
                this.method_118();
                this.method_120();
                this.method_123();
                Class516.Boolean_0 = flag;
                this.assembly_0 = null;
                this.assembly_1 = null;
                this.assembly_2 = null;
                this.type_0 = null;
                this.type_1 = null;
            }
        }

        private void method_117()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = Path.GetDirectoryName(base.class394_0.string_2) + @"\";
            Directory.SetCurrentDirectory(path);
            try
            {
                try
                {
                    this.assembly_1 = Assembly.LoadFrom(base.class394_0.string_2);
                }
                catch
                {
                    this.assembly_1 = null;
                }
                ArrayList list = base.class684_0.class554_0.arrayList_0;
                this.assembly_0 = new Assembly[list.Count];
                int index = 1;
            Label_006D:
                if (index >= list.Count)
                {
                    return;
                }
                Class554.Class532 class2 = list[index] as Class554.Class532;
                string partialName = base.class581_0[class2.int_0];
                try
                {
                    Assembly assembly = null;
                    assembly = Assembly.LoadWithPartialName(partialName);
                    if (assembly == null)
                    {
                        assembly = Assembly.LoadFrom(path + partialName + string_81);
                    }
                    if (assembly != null)
                    {
                        this.assembly_0[index] = assembly;
                        class2.bool_0 = true;
                    }
                    goto Label_0110;
                }
                catch
                {
                    this.assembly_0[index] = null;
                    class2.bool_0 = false;
                    goto Label_0110;
                }
            Label_00EB:
                if (partialName != string_80)
                {
                    goto Label_0107;
                }
            Label_00F9:
                this.assembly_2 = this.assembly_0[index];
            Label_0107:
                index++;
                goto Label_006D;
            Label_0110:
                if (partialName == string_79)
                {
                    goto Label_00F9;
                }
                goto Label_00EB;
            }
            finally
            {
                Directory.SetCurrentDirectory(currentDirectory);
            }
        }

        private void method_118()
        {
            ArrayList list = base.class684_0.class553_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class553.Class531 class2 = list[i] as Class553.Class531;
                Type type = null;
                this.stringBuilder_0.Length = 0;
                try
                {
                    if (class2.enum0_0 == Enum0.const_35)
                    {
                        if (this.assembly_0[class2.int_0] != null)
                        {
                            this.stringBuilder_0.Append(base.class684_0.class562_0[class2.int_2]);
                            this.stringBuilder_0.Append(Class518.class337_13);
                            this.stringBuilder_0.Append(base.class581_0[class2.int_1]);
                            type = this.assembly_0[class2.int_0].GetType(this.stringBuilder_0.ToString());
                        }
                    }
                    else if (class2.enum0_0 == Enum0.const_1)
                    {
                        Class553.Class531 class3 = class2;
                        this.stringBuilder_0.Append(base.class581_0[class3.int_1]);
                        this.stringBuilder_0.Insert(0, Class518.class337_23);
                        for (bool flag = false; class3.enum0_0 == Enum0.const_1; flag = true)
                        {
                            class3 = list[class3.int_0] as Class553.Class531;
                            if (flag)
                            {
                                this.stringBuilder_0.Insert(0, Class518.class337_13);
                            }
                            this.stringBuilder_0.Insert(0, base.class581_0[class3.int_1]);
                        }
                        if (this.assembly_0[class3.int_0] != null)
                        {
                            this.stringBuilder_0.Insert(0, Class518.class337_13);
                            this.stringBuilder_0.Insert(0, base.class684_0.class562_0[class3.int_2]);
                            type = this.assembly_0[class3.int_0].GetType(this.stringBuilder_0.ToString());
                        }
                    }
                }
                catch
                {
                    type = null;
                }
                if (type != null)
                {
                    this.type_0[i] = type;
                    if (type.IsEnum)
                    {
                        class2.byte_3 = (byte) (class2.byte_3 | 1);
                        this.method_119(class2, type);
                    }
                    else
                    {
                        Type baseType = type.BaseType;
                        if ((baseType != null) && (baseType.FullName == this.string_82))
                        {
                            class2.byte_3 = (byte) (class2.byte_3 | 2);
                        }
                    }
                }
            }
        }

        private void method_119(Class553.Class531 A_1, Type A_2)
        {
            Array values = Enum.GetValues(A_2);
            string[] names = Enum.GetNames(A_2);
            Type underlyingType = Enum.GetUnderlyingType(A_2);
            Enum11 enum2 = Enum11.const_22;
            if (underlyingType != typeof(int))
            {
                if (underlyingType == typeof(byte))
                {
                    enum2 = Enum11.const_19;
                }
                else if (underlyingType == typeof(sbyte))
                {
                    enum2 = Enum11.const_18;
                }
                else if (underlyingType == typeof(short))
                {
                    enum2 = Enum11.const_20;
                }
                else if (underlyingType == typeof(ushort))
                {
                    enum2 = Enum11.const_21;
                }
                else if (underlyingType == typeof(uint))
                {
                    enum2 = Enum11.const_23;
                }
                else if (underlyingType == typeof(long))
                {
                    enum2 = Enum11.const_24;
                }
                else if (underlyingType == typeof(ulong))
                {
                    enum2 = Enum11.const_25;
                }
            }
            ArrayList list = base.class684_0.class564_0.arrayList_0;
            A_1.int_3 = list.Count;
            A_1.short_1 = (short) values.Length;
            bool flag = true;
            for (int i = 0; i < values.Length; i++)
            {
                Class564.Class618 class2 = new Class564.Class618 {
                    int_0 = base.class581_0.method_0(names[i]),
                    enum11_0 = enum2
                };
                object obj2 = values.GetValue(i);
                switch (enum2)
                {
                    case Enum11.const_18:
                    {
                        sbyte num2 = (sbyte) obj2;
                        class2.int_1 = num2;
                        if (num2 != i)
                        {
                            flag = false;
                        }
                        break;
                    }
                    case Enum11.const_19:
                    {
                        byte num3 = (byte) obj2;
                        class2.int_1 = num3;
                        if (num3 != i)
                        {
                            flag = false;
                        }
                        break;
                    }
                    case Enum11.const_20:
                    {
                        short num4 = (short) obj2;
                        class2.int_1 = num4;
                        if (num4 != i)
                        {
                            flag = false;
                        }
                        break;
                    }
                    case Enum11.const_21:
                    {
                        ushort num5 = (ushort) obj2;
                        class2.int_1 = num5;
                        if (num5 != i)
                        {
                            flag = false;
                        }
                        break;
                    }
                    case Enum11.const_22:
                    {
                        int num6 = (int) obj2;
                        class2.int_1 = num6;
                        if (num6 != i)
                        {
                            flag = false;
                        }
                        break;
                    }
                    case Enum11.const_23:
                    {
                        Class565.Class620 class3 = new Class565.Class620();
                        uint num7 = (uint) obj2;
                        class3.uint_0 = num7;
                        class2.int_1 = base.class684_0.class565_0.arrayList_0.Count;
                        base.class684_0.class565_0.arrayList_0.Add(class3);
                        if (num7 != i)
                        {
                            flag = false;
                        }
                        break;
                    }
                    case Enum11.const_24:
                    {
                        Class566.Class621 class4 = new Class566.Class621();
                        long num8 = (long) obj2;
                        class4.long_0 = num8;
                        class2.int_1 = base.class684_0.class566_0.arrayList_0.Count;
                        base.class684_0.class566_0.arrayList_0.Add(class4);
                        if (num8 != i)
                        {
                            flag = false;
                        }
                        break;
                    }
                    case Enum11.const_25:
                    {
                        Class567.Class622 class5 = new Class567.Class622();
                        ulong num9 = (ulong) obj2;
                        class5.ulong_0 = num9;
                        class2.int_1 = base.class684_0.class567_0.arrayList_0.Count;
                        base.class684_0.class567_0.arrayList_0.Add(class5);
                        if (num9 != (ulong)((long)i))
                        {
                            flag = false;
                        }
                        break;
                    }
                    default:
                    {
                        int num10 = (int) obj2;
                        class2.int_1 = num10;
                        if (num10 != i)
                        {
                            flag = false;
                        }
                        break;
                    }
                }
                list.Add(class2);
            }
            if (flag)
            {
                A_1.byte_3 = (byte) (A_1.byte_3 | 4);
            }
        }

        private void method_120()
        {
            ArrayList list = base.class684_0.class552_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class552.Class545 class2 = list[i] as Class552.Class545;
                string name = base.class581_0[class2.int_1];
                Type type = this.type_0[class2.int_0];
                if (type != null)
                {
                    Type[] types = this.method_122(class2.int_3, class2.short_0);
                    if (types != null)
                    {
                        MethodInfo info = null;
                        try
                        {
                            info = type.GetMethod(name, this.bindingFlags_0, null, this.callingConventions_0, types, null);
                        }
                        catch
                        {
                        }
                        if ((info != null) && info.IsAbstract)
                        {
                            class2.byte_4 = (byte) (class2.byte_4 | 8);
                        }
                    }
                }
            }
        }

        private bool method_121(Type A_1, string A_2)
        {
            string name = A_1.Name;
            return (((name == "CompressedStack") && (A_2 == "GetCompressedStack")) || ((name == "SecurityManager") && (A_2 == "GetZoneAndOrigin")));
        }

        private Type[] method_122(int A_1, int A_2)
        {
            Type[] typeArray = new Type[A_2];
            ArrayList list = base.class684_0.class569_0.arrayList_0;
            for (int i = 0; i < A_2; i++)
            {
                Type type;
                Class569.Class624 class2 = list[A_1 + i] as Class569.Class624;
                if (class2.Boolean_0)
                {
                    type = this.method_128(class2.enum11_0, class2.int_0);
                }
                else
                {
                    type = this.method_127(class2.enum11_0, class2.int_0);
                }
                if (type == null)
                {
                    return null;
                }
                typeArray[i] = type;
            }
            return typeArray;
        }

        private void method_123()
        {
            Class516.Boolean_0 = true;
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            ArrayList list2 = base.class684_0.class547_0.arrayList_0;
            int index = 1;
        Label_002A:
            if (index >= list.Count)
            {
                Class516.smethod_0();
            }
            else
            {
                Class548.Class529 class2 = list[index] as Class548.Class529;
                if ((class2.ushort_17 & 0x3010) == 0)
                {
                    int num2 = class2.int_8;
                    bool flag = true;
                    Type type = null;
                    for (int i = 0; i < class2.short_5; i++)
                    {
                        Class547.Class528 class3 = list2[num2 + i] as Class547.Class528;
                        if (!class3.Boolean_12 && !class3.Boolean_5)
                        {
                            if (flag)
                            {
                                if (this.type_1[index] != null)
                                {
                                    type = this.type_1[index];
                                }
                                else
                                {
                                    type = this.method_126(class2, index);
                                }
                                flag = false;
                            }
                            else
                            {
                                type = this.type_1[index];
                            }
                            if (type != null)
                            {
                                Type[] types = this.method_125(class3.int_6, class3.short_2);
                                if (types != null)
                                {
                                    MethodInfo info = null;
                                    bool flag2 = false;
                                    if (class3.Boolean_11)
                                    {
                                        try
                                        {
                                            info = type.GetMethod(base.class581_0[class3.int_1], this.bindingFlags_0, null, this.callingConventions_0, types, null);
                                        }
                                        catch
                                        {
                                            info = null;
                                        }
                                        if (info != null)
                                        {
                                            Type declaringType = info.GetBaseDefinition().DeclaringType;
                                            if ((declaringType != null) && (type.FullName != declaringType.FullName))
                                            {
                                                class3.uint_25 |= 0x80;
                                                flag2 = true;
                                            }
                                        }
                                    }
                                    flag2 |= (class3.uint_25 & 0x80) != 0;
                                    if (!class3.Boolean_11 || !flag2)
                                    {
                                        Type baseType = type.BaseType;
                                        if (baseType != null)
                                        {
                                            try
                                            {
                                                info = baseType.GetMethod(base.class581_0[class3.int_1], this.bindingFlags_0, null, this.callingConventions_0, types, null);
                                            }
                                            catch
                                            {
                                                info = null;
                                            }
                                            if ((info != null) && (!info.IsAbstract && this.method_124(info, types)))
                                            {
                                                class3.uint_25 |= 0x1000000;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                index++;
                goto Label_002A;
            }
        }

        private bool method_124(MethodInfo A_1, Type[] A_2)
        {
            ParameterInfo[] parameters = A_1.GetParameters();
            if (parameters.Length != A_2.Length)
            {
                return false;
            }
            for (int i = 0; i < A_2.Length; i++)
            {
                Type parameterType = parameters[i].ParameterType;
                if (!A_2[i].Equals(parameterType))
                {
                    return false;
                }
            }
            return true;
        }

        private Type[] method_125(int A_1, int A_2)
        {
            Type[] typeArray = new Type[A_2];
            ArrayList list = base.class684_0.class568_0.arrayList_0;
            for (int i = 0; i < A_2; i++)
            {
                Type type;
                Class568.Class623 class2 = list[A_1 + i] as Class568.Class623;
                if (class2.Boolean_0)
                {
                    type = this.method_128(class2.enum11_0, class2.int_1);
                }
                else
                {
                    type = this.method_127(class2.enum11_0, class2.int_1);
                }
                if (type == null)
                {
                    return null;
                }
                typeArray[i] = type;
            }
            return typeArray;
        }

        private Type method_126(Class548.Class529 A_1, int A_2)
        {
            Type type = null;
            try
            {
                if (A_1.class369_0.QQQV)
                {
                    type = this.assembly_1.GetType(Class612.smethod_3(A_1));
                }
                else
                {
                    type = this.assembly_1.GetType(Class612.smethod_2(A_1));
                }
            }
            catch
            {
                type = null;
            }
            this.type_1[A_2] = type;
            return type;
        }

        private Type method_127(Enum11 A_1, int A_2)
        {
            switch (A_1)
            {
                case Enum11.const_1:
                    return Class918.type_14;

                case Enum11.const_2:
                    return Class918.type_15;

                case Enum11.const_3:
                    return Class918.type_16;

                case Enum11.const_4:
                    return Class918.type_17;

                case Enum11.const_5:
                    return Class918.type_18;

                case Enum11.const_6:
                    return Class918.type_19;

                case Enum11.const_7:
                    return Class918.type_20;

                case Enum11.const_8:
                    return Class918.type_21;

                case Enum11.const_9:
                    return Class918.type_22;

                case Enum11.const_10:
                    return Class918.type_23;

                case Enum11.const_11:
                    return Class918.type_24;

                case Enum11.const_12:
                    return Class918.type_25;

                case Enum11.const_13:
                    return Class918.type_26;

                case Enum11.const_14:
                    return Class918.type_27;

                case Enum11.const_16:
                    return Class918.type_0;

                case Enum11.const_17:
                    return Class918.type_1;

                case Enum11.const_18:
                    return Class918.type_2;

                case Enum11.const_19:
                    return Class918.type_3;

                case Enum11.const_20:
                    return Class918.type_4;

                case Enum11.const_21:
                    return Class918.type_5;

                case Enum11.const_22:
                    return Class918.type_6;

                case Enum11.const_23:
                    return Class918.type_7;

                case Enum11.const_24:
                    return Class918.type_8;

                case Enum11.const_25:
                    return Class918.type_9;

                case Enum11.const_26:
                    return Class918.type_10;

                case Enum11.const_27:
                    return Class918.type_11;

                case Enum11.const_28:
                    return Class918.type_12;

                case Enum11.const_29:
                    return Class918.type_13;

                case Enum11.const_30:
                    return Class918.type_40;

                case Enum11.const_31:
                    return Class918.type_41;

                case Enum11.const_32:
                    return Class918.type_43;

                case Enum11.const_33:
                    return Class918.type_44;

                case Enum11.const_34:
                    return Class918.type_42;

                case Enum11.const_35:
                    return Class918.type_45;

                case Enum11.const_36:
                    return this.method_130(A_2);

                case Enum11.const_37:
                    return this.method_131(A_2);

                case Enum11.const_38:
                    return this.type_0[A_2];

                case Enum11.const_39:
                    return this.method_132(A_2, false);

                case Enum11.const_41:
                    return this.method_133(A_2);
            }
            return null;
        }

        private Type method_128(Enum11 A_1, int A_2)
        {
            switch (A_1)
            {
                case Enum11.const_16:
                    return Class918.type_28;

                case Enum11.const_17:
                    return Class918.type_29;

                case Enum11.const_18:
                    return Class918.type_30;

                case Enum11.const_19:
                    return Class918.type_31;

                case Enum11.const_20:
                    return Class918.type_32;

                case Enum11.const_21:
                    return Class918.type_33;

                case Enum11.const_22:
                    return Class918.type_34;

                case Enum11.const_23:
                    return Class918.type_35;

                case Enum11.const_24:
                    return Class918.type_36;

                case Enum11.const_25:
                    return Class918.type_37;

                case Enum11.const_26:
                    return Class918.type_38;

                case Enum11.const_27:
                    return Class918.type_39;

                case Enum11.const_30:
                    return Class918.type_46;

                case Enum11.const_31:
                    return Class918.type_47;

                case Enum11.const_34:
                    return Class918.type_48;

                case Enum11.const_36:
                    return this.method_129(A_2);

                case Enum11.const_38:
                    return this.method_132(A_2, true);
            }
            return null;
        }

        private Type method_129(int A_1)
        {
            Class548.Class529 class2 = base.class684_0.class548_0.arrayList_0[A_1] as Class548.Class529;
            try
            {
                if (class2.class369_0.QQQV)
                {
                    return this.assembly_1.GetType(Class612.smethod_3(class2) + string_85);
                }
                return this.assembly_1.GetType(Class612.smethod_2(class2) + string_85);
            }
            catch
            {
                return null;
            }
        }

        private Type method_130(int A_1)
        {
            if (this.type_1[A_1] != null)
            {
                return this.type_1[A_1];
            }
            Class548.Class529 class2 = base.class684_0.class548_0.arrayList_0[A_1] as Class548.Class529;
            Type type = null;
            try
            {
                if (class2.class369_0.QQQV)
                {
                    type = this.assembly_1.GetType(Class612.smethod_3(class2));
                }
                else
                {
                    type = this.assembly_1.GetType(Class612.smethod_2(class2));
                }
            }
            catch
            {
                type = null;
            }
            this.type_1[A_1] = type;
            return type;
        }

        private Type method_131(int A_1)
        {
            Class548.Class529 class2 = base.class684_0.class548_0.arrayList_0[A_1] as Class548.Class529;
            try
            {
                return this.assembly_1.GetType(Class612.smethod_2(class2) + Class603.string_0);
            }
            catch
            {
                return null;
            }
        }

        private Type method_132(int A_1, bool A_2)
        {
            string str;
            ArrayList list = base.class684_0.class553_0.arrayList_0;
            Class553.Class531 class2 = list[A_1] as Class553.Class531;
            if (A_2)
            {
                str = string_85;
            }
            else
            {
                str = Class603.string_0;
            }
            Type type = null;
            this.stringBuilder_0.Length = 0;
            try
            {
                if (class2.enum0_0 == Enum0.const_35)
                {
                    if (this.assembly_0[class2.int_0] != null)
                    {
                        this.stringBuilder_0.Append(base.class684_0.class562_0[class2.int_2]);
                        this.stringBuilder_0.Append(Class518.class337_13);
                        this.stringBuilder_0.Append(base.class581_0[class2.int_1]);
                        type = this.assembly_0[class2.int_0].GetType(this.stringBuilder_0.ToString() + str);
                    }
                    return type;
                }
                if (class2.enum0_0 != Enum0.const_1)
                {
                    return type;
                }
                Class553.Class531 class3 = class2;
                this.stringBuilder_0.Append(base.class581_0[class3.int_1]);
                this.stringBuilder_0.Insert(0, Class518.class337_23);
                for (bool flag = false; class3.enum0_0 == Enum0.const_1; flag = true)
                {
                    class3 = list[class3.int_0] as Class553.Class531;
                    if (flag)
                    {
                        this.stringBuilder_0.Insert(0, Class518.class337_13);
                    }
                    this.stringBuilder_0.Insert(0, base.class581_0[class3.int_1]);
                }
                if (this.assembly_0[class3.int_0] != null)
                {
                    this.stringBuilder_0.Insert(0, Class518.class337_13);
                    this.stringBuilder_0.Insert(0, base.class684_0.class562_0[class3.int_2]);
                    type = this.assembly_0[class3.int_0].GetType(this.stringBuilder_0.ToString() + str);
                }
            }
            catch
            {
                type = null;
            }
            return type;
        }

        private Type method_133(int A_1)
        {
            enum60_0 = Enum60.const_0;
            class367_0.method_5();
            Type type = null;
            try
            {
                ArrayList list;
                Class553.Class531 class2;
                this.method_134(A_1);
                switch (enum60_0)
                {
                    case Enum60.const_0:
                        return this.assembly_2.GetType(class367_0.ToString());

                    case Enum60.const_1:
                        return this.assembly_1.GetType(class367_0.ToString());

                    case Enum60.const_2:
                        list = base.class684_0.class553_0.arrayList_0;
                        class2 = list[int_9] as Class553.Class531;
                        if (class2.enum0_0 != Enum0.const_35)
                        {
                            break;
                        }
                        if (this.assembly_0[class2.int_0] != null)
                        {
                            type = this.assembly_0[class2.int_0].GetType(class367_0.ToString());
                        }
                        return type;

                    default:
                        return type;
                }
                if (class2.enum0_0 != Enum0.const_1)
                {
                    return type;
                }
                Class553.Class531 class3 = class2;
                while (class3.enum0_0 == Enum0.const_1)
                {
                    class3 = list[class3.int_0] as Class553.Class531;
                }
                return this.assembly_0[class3.int_0].GetType(class367_0.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void method_134(int A_1)
        {
            Class558.Class606 class2 = base.class684_0.class558_0.arrayList_0[A_1] as Class558.Class606;
            class48_2.Byte_0 = class2.byte_0;
            class602_0.method_0();
            switch (class48_2.method_8())
            {
                case 20:
                    this.method_136();
                    break;

                case 0x1d:
                    this.method_135();
                    break;
            }
            int num2 = class602_0.Int32_0 - 1;
            class397_0.method_1(class602_0[num2]);
            for (int i = 0; i < num2; i++)
            {
                class397_0.method_1(class602_0[i]);
            }
        }

        private void method_135()
        {
            int num = class602_0.method_1();
            this.method_137();
            class602_0.method_2(num, Class518.class337_7);
            class602_0.method_2(num, Class518.class337_8);
        }

        private void method_136()
        {
            int num = class602_0.method_1();
            this.method_137();
            int num2 = class48_2.method_21();
            int num3 = num2 - 1;
            int num4 = class48_2.method_21();
            for (int i = 0; i < num4; i++)
            {
                class48_2.method_21();
            }
            int num6 = class48_2.method_21();
            for (int j = 0; j < num6; j++)
            {
                class48_2.method_21();
            }
            class602_0.method_2(num, Class518.class337_7);
            for (int k = 0; k < num2; k++)
            {
                if (k < num3)
                {
                    class602_0.method_2(num, Class518.class337_14);
                }
            }
            class602_0.method_2(num, Class518.class337_8);
        }

        private void method_137()
        {
            int num = class602_0.method_1();
            switch (class48_2.method_8())
            {
                case 2:
                    class602_0.method_2(num, Class615.class336_23);
                    return;

                case 3:
                    class602_0.method_2(num, Class615.class336_24);
                    return;

                case 4:
                    class602_0.method_2(num, Class615.class336_25);
                    return;

                case 5:
                    class602_0.method_2(num, Class615.class336_26);
                    return;

                case 6:
                    class602_0.method_2(num, Class615.class336_27);
                    return;

                case 7:
                    class602_0.method_2(num, Class615.class336_28);
                    return;

                case 8:
                    class602_0.method_2(num, Class615.class336_29);
                    return;

                case 9:
                    class602_0.method_2(num, Class615.class336_30);
                    return;

                case 10:
                    class602_0.method_2(num, Class615.class336_31);
                    return;

                case 11:
                    class602_0.method_2(num, Class615.class336_32);
                    return;

                case 12:
                    class602_0.method_2(num, Class615.class336_33);
                    return;

                case 13:
                    class602_0.method_2(num, Class615.class336_34);
                    return;

                case 14:
                    class602_0.method_2(num, Class615.class336_35);
                    return;

                case 15:
                case 0x10:
                case 0x13:
                case 0x15:
                case 0x17:
                case 0x1a:
                case 0x1b:
                    break;

                case 0x11:
                    this.method_138();
                    return;

                case 0x12:
                    this.method_138();
                    return;

                case 20:
                    this.method_136();
                    return;

                case 0x16:
                    this.method_141();
                    return;

                case 0x18:
                    this.method_139();
                    return;

                case 0x19:
                    this.method_140();
                    return;

                case 0x1c:
                    class602_0.method_2(num, Class615.class336_36);
                    return;

                case 0x1d:
                    this.method_135();
                    break;

                default:
                    return;
            }
        }

        private void method_138()
        {
            int num = class602_0.method_1();
            int num2 = class48_2.method_21();
            int num3 = num2 & 3;
            num2 = num2 >> 2;
            switch (num3)
            {
                case 0:
                {
                    Class548.Class529 class2 = base.class684_0.class548_0.arrayList_0[num2] as Class548.Class529;
                    class602_0.method_2(num, new Class336(Class612.smethod_2(class2)));
                    enum60_0 = Enum60.const_1;
                    return;
                }
                case 1:
                {
                    Class553.Class531 class3 = base.class684_0.class553_0.arrayList_0[num2] as Class553.Class531;
                    class602_0.method_2(num, new Class336(Class612.smethod_7(class3)));
                    enum60_0 = Enum60.const_2;
                    int_9 = num2;
                    break;
                }
            }
        }

        private void method_139()
        {
            int num = class602_0.method_1();
            class602_0.method_2(num, Class615.class336_0);
        }

        private void method_140()
        {
            int num = class602_0.method_1();
            class602_0.method_2(num, Class615.class336_2);
        }

        private void method_141()
        {
            int num = class602_0.method_1();
            class602_0.method_2(num, Class615.class336_4);
        }
    }
}

