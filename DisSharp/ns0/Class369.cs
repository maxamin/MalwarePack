namespace ns0
{
    using System;
    using System.Collections.Specialized;

    internal abstract class Class369
    {
        internal Class369 class369_0;
        internal Class619 class619_0 = new Class619();
        internal Class686.Class687 class687_0;
        internal StringCollection stringCollection_0;
        protected static Class397 TreeLine = new Class397();

        static Class369()
        {
            TreeLine.method_8();
        }

        protected Class369()
        {
        }

        internal virtual void Create(Class50 code, Enum2 codetype, bool single)
        {
        }

        internal virtual void Load(Class656 reader)
        {
        }

        internal void method_0(Class524 A_1)
        {
            A_1.Write((ushort) this.class619_0.Int32_0);
            for (int i = 0; i < this.class619_0.Int32_0; i++)
            {
                Class369 class2 = this.class619_0[i];
                A_1.Write((byte) class2.QQQS);
                if (class2.stringCollection_0 != null)
                {
                    int count = class2.stringCollection_0.Count;
                    A_1.Write((ushort) count);
                    for (int j = 0; j < count; j++)
                    {
                        A_1.Write(class2.stringCollection_0[j]);
                    }
                }
                else
                {
                    A_1.Write((ushort) 0);
                }
                class2.Save(A_1);
                class2.method_0(A_1);
            }
        }

        internal void method_1(Class656 A_1, Class369 A_2, int A_3)
        {
            int num = A_1.ReadUInt16();
            for (int i = 0; i < num; i++)
            {
                Class369 class2 = this.method_2(A_1.ReadByte());
                class2.class369_0 = A_2;
                int num3 = A_1.ReadUInt16();
                if (num3 > 0)
                {
                    class2.stringCollection_0 = new StringCollection();
                    for (int j = 0; j < num3; j++)
                    {
                        class2.stringCollection_0.Add(A_1.ReadString());
                    }
                }
                class2.Load(A_1);
                class2.method_1(A_1, class2, A_3);
                this.class619_0.method_0(class2);
            }
        }

        private Class369 method_2(byte A_1)
        {
            switch (((Enum10) A_1))
            {
                case Enum10.const_1:
                    return new Class390();

                case Enum10.const_2:
                    return new Class379();

                case Enum10.const_3:
                    return new Class380();

                case Enum10.const_4:
                    return new Class375();

                case Enum10.const_5:
                    return new Class376();

                case Enum10.const_6:
                    return new Class377();

                case Enum10.const_7:
                    return new Class378();

                case Enum10.const_8:
                    return new Class373();

                case Enum10.const_9:
                    return new Class374();

                case Enum10.const_10:
                    return new Class371();

                case Enum10.const_11:
                    return new Class372();

                case Enum10.const_12:
                    return new Class385();

                case Enum10.const_13:
                    return new Class386();

                case Enum10.const_14:
                    return new Class387();

                case Enum10.const_15:
                    return new Class388();

                case Enum10.const_16:
                    return new Class391();

                case Enum10.const_17:
                    return new Class392();

                case Enum10.const_18:
                    return new Class384();

                case Enum10.const_19:
                    return new Class382();

                case Enum10.const_20:
                    return new Class396();

                case Enum10.const_21:
                    return new Class381();

                case Enum10.const_22:
                    return new Class389();

                case Enum10.const_23:
                    return new Class383();
            }
            throw new Exception6(1);
        }

        internal void method_3(Class50 A_1, Enum2 A_2)
        {
            this.Create(A_1, A_2, true);
        }

        internal Class642 method_4(Enum2 A_1)
        {
            Class644 class2 = new Class644();
            for (int i = 0; i < this.class619_0.Int32_0; i++)
            {
                switch (A_1)
                {
                    case Enum2.const_0:
                    case Enum2.const_1:
                    case Enum2.const_5:
                    case Enum2.const_6:
                        class2.method_0(this.class619_0[i].method_4(A_1));
                        break;

                    case Enum2.const_2:
                    case Enum2.const_3:
                    case Enum2.const_4:
                    {
                        Class369 class3 = this.class619_0[i];
                        if (class3.QQXR(A_1))
                        {
                            class2.method_0(class3.method_4(A_1));
                        }
                        break;
                    }
                }
            }
            return new Class642(this, class2);
        }

        internal bool method_5(Class547.Class528 A_1, Enum2 A_2)
        {
            return (A_1.Boolean_4 || (((A_2 != Enum2.const_2) && A_1.Boolean_6) || ((A_2 == Enum2.const_4) && A_1.Boolean_7)));
        }

        internal bool method_6(Enum2 A_1)
        {
            int num = this.class619_0.Int32_0;
            if (num == 0)
            {
                return false;
            }
            Class391 class2 = this.class619_0[0] as Class391;
            if (class2 == null)
            {
                return false;
            }
            if (this.method_5(class2.class528_0, A_1))
            {
                return true;
            }
            if (num != 2)
            {
                return false;
            }
            class2 = this.class619_0[1] as Class391;
            if (class2 == null)
            {
                return false;
            }
            return this.method_5(class2.class528_0, A_1);
        }

        internal void method_7(Class896 A_1)
        {
            try
            {
                this.QQWZ(A_1);
            }
            catch
            {
            }
            if (this.QQQT)
            {
                for (int i = 0; i < this.class619_0.Int32_0; i++)
                {
                    this.class619_0[i].method_7(A_1);
                }
            }
        }

        internal virtual bool QQRU()
        {
            return false;
        }

        internal virtual bool QQRV(Class369 node)
        {
            return false;
        }

        internal virtual bool QQTX(Class586 identifier, bool full)
        {
            return false;
        }

        internal virtual bool QQTX(Class593 identifier, bool full)
        {
            return false;
        }

        internal virtual void QQUY(Class50 code, Enum2 codetype)
        {
            this.Create(code, codetype, false);
        }

        internal virtual void QQWT()
        {
            if (this.class369_0 != null)
            {
                this.class369_0.QQWT();
            }
        }

        internal virtual void QQWU()
        {
            if (this.class369_0 != null)
            {
                this.class369_0.QQWU();
            }
        }

        internal virtual string QQWV(int number)
        {
            return "";
        }

        internal virtual void QQWV(Class397 lines, int number)
        {
        }

        internal virtual Class335 QQWW(int number)
        {
            return Class584.class342_0;
        }

        internal virtual void QQWZ(Class896 coll)
        {
        }

        internal virtual bool QQXR(Enum2 codetype)
        {
            return true;
        }

        internal virtual void Save(Class524 writer)
        {
        }

        internal virtual string Name
        {
            get
            {
                return string.Empty;
            }
            set
            {
            }
        }

        internal virtual bool QQQQ
        {
            get
            {
                return false;
            }
        }

        internal virtual int QQQR
        {
            get
            {
                return 0;
            }
        }

        internal virtual Enum10 QQQS
        {
            get
            {
                return Enum10.const_26;
            }
        }

        internal virtual bool QQQT
        {
            get
            {
                return true;
            }
        }

        internal virtual bool QQQU
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQQV
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQQY
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQQZ
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQRQ
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQRR
        {
            get
            {
                return false;
            }
        }

        internal virtual Enum57 QQTT
        {
            get
            {
                return Enum57.const_3;
            }
        }

        internal virtual bool QQTV
        {
            get
            {
                return false;
            }
        }

        internal virtual Class394 QQTW
        {
            get
            {
                return this.class369_0.QQTW;
            }
        }

        internal virtual bool QQTY
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQTZ
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQUQ
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQUR
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQVU
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQVW
        {
            get
            {
                return true;
            }
        }

        internal virtual bool QQXQ
        {
            get
            {
                return false;
            }
        }

        internal string String_0
        {
            get
            {
                Class516.Boolean_0 = false;
                if (this.QQRU())
                {
                    Class367 class2 = TreeLine.Class367_0;
                    string str = class2.ToString();
                    class2.method_5();
                    Class516.smethod_0();
                    return str;
                }
                Class516.smethod_0();
                return this.Name;
            }
        }
    }
}

