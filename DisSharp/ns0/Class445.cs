namespace ns0
{
    using System;

    internal abstract class Class445
    {
        protected Class445()
        {
        }

        internal bool method_0(Class445 A_1)
        {
            if (this.Type == A_1.Type)
            {
                switch (this.Type)
                {
                    case Enum17.const_36:
                    {
                        Class484 class24 = this as Class484;
                        Class484 class25 = A_1 as Class484;
                        if (!class24.class445_0.method_0(class25.class445_0) || (class24.uint_0 != class25.uint_0))
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_37:
                    {
                        Class485 class26 = this as Class485;
                        Class485 class27 = A_1 as Class485;
                        if (!class26.class445_0.method_0(class27.class445_0) || (class26.uint_0 != class27.uint_0))
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_38:
                    {
                        Class486 class28 = this as Class486;
                        Class486 class29 = A_1 as Class486;
                        if (!class28.class445_0.method_0(class29.class445_0) || (class28.uint_0 != class29.uint_0))
                        {
                            return false;
                        }
                        Class445[] classArray = class28.class445_1;
                        Class445[] classArray2 = class29.class445_1;
                        for (int i = 0; i < classArray.Length; i++)
                        {
                            if (!classArray[i].method_0(classArray2[i]))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    case Enum17.const_41:
                    {
                        Class489 class30 = this as Class489;
                        Class489 class31 = A_1 as Class489;
                        if (!class30.class445_0.method_0(class31.class445_0) || (class30.uint_0 != class31.uint_0))
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_44:
                    {
                        Class452 class32 = this as Class452;
                        Class452 class33 = A_1 as Class452;
                        return (class32.ushort_0 == class33.ushort_0);
                    }
                    case Enum17.const_45:
                    {
                        Class453 class34 = this as Class453;
                        Class453 class35 = A_1 as Class453;
                        return (class34.ushort_0 == class35.ushort_0);
                    }
                    case Enum17.const_47:
                    {
                        Class493 class36 = this as Class493;
                        Class493 class37 = A_1 as Class493;
                        if ((class36.uint_0 != class37.uint_0) || !class36.class445_0.method_0(class37.class445_0))
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_48:
                    {
                        Class494 class38 = this as Class494;
                        Class494 class39 = A_1 as Class494;
                        if (((class38.enum11_0 != class39.enum11_0) || (class38.int_0 != class39.int_0)) || (!class38.class445_0.method_0(class39.class445_0) || !class38.class445_1.method_0(class39.class445_1)))
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_50:
                        return true;

                    case Enum17.const_55:
                    {
                        Class501 class40 = this as Class501;
                        Class501 class41 = A_1 as Class501;
                        return (class40.uint_0 == class41.uint_0);
                    }
                    case Enum17.const_56:
                    {
                        Class502 class42 = this as Class502;
                        Class502 class43 = A_1 as Class502;
                        return (class42.uint_0 == class43.uint_0);
                    }
                    case Enum17.const_57:
                    {
                        Class503 class44 = this as Class503;
                        Class503 class45 = A_1 as Class503;
                        if (class44.uint_0 != class45.uint_0)
                        {
                            return false;
                        }
                        Class445[] classArray3 = class44.class445_0;
                        Class445[] classArray4 = class45.class445_0;
                        for (int j = 0; j < classArray3.Length; j++)
                        {
                            if (!classArray3[j].method_0(classArray4[j]))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    case Enum17.const_60:
                    {
                        Class507 class46 = this as Class507;
                        Class507 class47 = A_1 as Class507;
                        if (class46.uint_0 != class47.uint_0)
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_64:
                    {
                        Class511 class48 = this as Class511;
                        Class511 class49 = A_1 as Class511;
                        if (class48.uint_0 != class49.uint_0)
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_2:
                    {
                        Class456 class2 = this as Class456;
                        Class456 class3 = A_1 as Class456;
                        return (class2.ushort_0 == class3.ushort_0);
                    }
                    case Enum17.const_4:
                    {
                        Class458 class4 = this as Class458;
                        Class458 class5 = A_1 as Class458;
                        if (!class4.class445_0.method_0(class5.class445_0) || !class4.class445_1.method_0(class5.class445_1))
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_5:
                    {
                        Class459 class6 = this as Class459;
                        Class459 class7 = A_1 as Class459;
                        if ((!class6.class445_0.method_0(class7.class445_0) || !class6.class445_1.method_0(class7.class445_1)) || !class6.class445_2.method_0(class7.class445_2))
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_17:
                    {
                        Class451 class8 = this as Class451;
                        Class451 class9 = A_1 as Class451;
                        return (class8.bool_0 == class9.bool_0);
                    }
                    case Enum17.const_18:
                    {
                        Class471 class10 = this as Class471;
                        Class471 class11 = A_1 as Class471;
                        return (class10.int_0 == class11.int_0);
                    }
                    case Enum17.const_19:
                    {
                        Class450 class12 = this as Class450;
                        Class450 class13 = A_1 as Class450;
                        return (class12.double_0 == class13.double_0);
                    }
                    case Enum17.const_20:
                    {
                        Class472 class14 = this as Class472;
                        Class472 class15 = A_1 as Class472;
                        if (((class14.enum0_0 != class15.enum0_0) || (class14.int_0 != class15.int_0)) || (class14.long_0 != class15.long_0))
                        {
                            return false;
                        }
                        return true;
                    }
                    case Enum17.const_21:
                    {
                        Class449 class16 = this as Class449;
                        Class449 class17 = A_1 as Class449;
                        return (class16.float_0 == class17.float_0);
                    }
                    case Enum17.const_22:
                    {
                        Class447 class18 = this as Class447;
                        Class447 class19 = A_1 as Class447;
                        return (class18.int_0 == class19.int_0);
                    }
                    case Enum17.const_23:
                    {
                        Class448 class20 = this as Class448;
                        Class448 class21 = A_1 as Class448;
                        return (class20.long_0 == class21.long_0);
                    }
                    case Enum17.const_25:
                    {
                        Class473 class22 = this as Class473;
                        Class473 class23 = A_1 as Class473;
                        return (class22.int_0 == class23.int_0);
                    }
                }
            }
            return false;
        }

        internal virtual void QQRW(Class524 writer)
        {
            writer.Write((byte) this.Type);
            this.QQVT(writer);
        }

        internal virtual Class445 QQUS()
        {
            return this;
        }

        internal virtual Class445 QQUT()
        {
            return this.QQUS();
        }

        internal virtual Class445 QQUU(Class658 type)
        {
            return this;
        }

        internal virtual Class445 QQUV()
        {
            Class658 type = Class658.smethod_1();
            type.enum11_0 = Class519.class528_0.enum11_0;
            type.int_0 = Class519.class528_0.int_5;
            type.byte_0 = Class519.class528_0.byte_1;
            return this.QQUU(type);
        }

        internal virtual void QQUW()
        {
        }

        internal virtual void QQVS(Class48 data)
        {
        }

        internal virtual void QQVT(Class524 writer)
        {
        }

        internal virtual bool QQVV
        {
            get
            {
                return false;
            }
        }

        internal abstract Enum17 Type { get; }
    }
}

