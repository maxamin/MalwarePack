namespace ns0
{
    using System;
    using System.Collections;

    internal class Class899
    {
        private static Class48 class48_0 = new Class48();
        private static Enum11 enum11_0;

        internal static Class445 smethod_0(Class445 A_0, uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            Enum0 enum3 = enum2;
            if (enum3 == Enum0.const_4)
            {
                return smethod_1(A_0, num);
            }
            if (enum3 != Enum0.const_10)
            {
                throw new Exception1();
            }
            return smethod_2(A_0, num);
        }

        private static Class445 smethod_1(Class445 A_0, int A_1)
        {
            Class549.Class530 class2 = Class546.class549_0.arrayList_0[A_1] as Class549.Class530;
            if (class2.enum11_0 != Enum11.const_42)
            {
                throw new Exception1();
            }
            Class561.Class611 class3 = Class546.class561_0.arrayList_0[class2.int_2] as Class561.Class611;
            if (class3.enum11_0 != Enum11.const_36)
            {
                return new Class482((A_0 as Class493).uint_0, new Class445[0]);
            }
            class48_0.Byte_0 = class3.byte_0;
            switch (A_0.Type)
            {
                case Enum17.const_47:
                    return smethod_3(A_0 as Class493);

                case Enum17.const_48:
                    return smethod_4(A_0 as Class494);
            }
            throw new Exception1();
        }

        private static Class445 smethod_2(Class445 A_0, int A_1)
        {
            Class551.Class544 class2 = Class546.class551_0.arrayList_0[A_1] as Class551.Class544;
            if (class2.enum9_0 != Enum9.const_1)
            {
                throw new Exception1();
            }
            Class555.Class600 class3 = Class546.class555_0.arrayList_0[class2.int_0] as Class555.Class600;
            Enum11 enum2 = class3.enum11_0;
            int num = class3.int_2;
            byte[] buffer = null;
            ArrayList list = Class546.class561_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class561.Class611 class4 = list[i] as Class561.Class611;
                if ((class4.enum11_0 == enum2) && (class4.int_0 == num))
                {
                    if (class4.enum11_0 != Enum11.const_36)
                    {
                        return new Class482((A_0 as Class493).uint_0, new Class445[0]);
                    }
                    buffer = class4.byte_0;
                    break;
                }
            }
            if (buffer == null)
            {
                throw new Exception1();
            }
            class48_0.Byte_0 = buffer;
            switch (A_0.Type)
            {
                case Enum17.const_47:
                    return smethod_3(A_0 as Class493);

                case Enum17.const_48:
                    return smethod_4(A_0 as Class494);
            }
            throw new Exception1();
        }

        private static Class445 smethod_3(Class493 A_0)
        {
            enum11_0 = Class519.class604_0.method_4(A_0.uint_0);
            Class447 class2 = A_0.class445_0 as Class447;
            if (class2 == null)
            {
                throw new Exception1();
            }
            int num = class2.int_0;
            Class445[] classArray = new Class445[num];
            for (int i = 0; i < num; i++)
            {
                classArray[i] = smethod_5();
            }
            return new Class482(A_0.uint_0, classArray);
        }

        private static Class445 smethod_4(Class494 A_0)
        {
            enum11_0 = A_0.enum11_0;
            Class447 class2 = A_0.class445_0 as Class447;
            if (class2 == null)
            {
                throw new Exception1();
            }
            int num = class2.int_0;
            Class447 class3 = A_0.class445_1 as Class447;
            if (class3 == null)
            {
                throw new Exception1();
            }
            int num2 = class3.int_0;
            ArrayList list = new ArrayList();
            for (int i = 0; i < num; i++)
            {
                Class445[] classArray = new Class445[num2];
                for (int j = 0; j < num2; j++)
                {
                    classArray[j] = smethod_5();
                }
                list.Add(classArray);
            }
            return new Class483(A_0.enum11_0, A_0.int_0, list);
        }

        private static Class445 smethod_5()
        {
            switch (enum11_0)
            {
                case Enum11.const_16:
                    return new Class451(class48_0.method_5());

                case Enum11.const_17:
                    return new Class471(class48_0.method_6());

                case Enum11.const_18:
                    return new Class447(class48_0.method_7());

                case Enum11.const_19:
                    return new Class447(class48_0.method_8());

                case Enum11.const_20:
                    return new Class447(class48_0.method_9());

                case Enum11.const_21:
                    return new Class447(class48_0.method_10());

                case Enum11.const_22:
                    return new Class447(class48_0.method_11());

                case Enum11.const_23:
                    return new Class448((long) class48_0.method_14());

                case Enum11.const_24:
                    return new Class448(class48_0.method_15());

                case Enum11.const_25:
                    return new Class448((long) class48_0.method_16());

                case Enum11.const_26:
                    return new Class449(class48_0.method_17());

                case Enum11.const_27:
                    return new Class450(class48_0.method_18());

                case Enum11.const_28:
                {
                    string str = class48_0.method_23(class48_0.method_21());
                    return new Class473(Class519.class581_0.method_0(str));
                }
            }
            throw new Exception1();
        }
    }
}

