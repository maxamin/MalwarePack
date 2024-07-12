namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class398
    {
        internal ArrayList arrayList_0;
        internal bool bool_0;
        internal ushort ushort_0;
        internal ushort ushort_1;

        protected Class398()
        {
        }

        internal void method_0(Class398 A_1)
        {
            if (this.arrayList_0 == null)
            {
                this.arrayList_0 = new ArrayList();
            }
            this.arrayList_0.Add(A_1);
        }

        internal void method_1(Class398 A_1)
        {
            if (this.arrayList_0 != null)
            {
                this.arrayList_0.Remove(A_1);
                if (this.arrayList_0.Count == 0)
                {
                    this.arrayList_0 = null;
                }
            }
        }

        internal void method_2(Class397 A_1)
        {
            A_1.method_10(Class584.class340_0);
            A_1.method_10(Class585.smethod_1(this.ushort_0));
        }

        internal void method_3(Class524 A_1)
        {
            if (this.ushort_0 > 0)
            {
                Class444.class540_1.method_1(this.ushort_1);
            }
            A_1.Write((byte) this.Type);
            A_1.Write(this.bool_0);
            this.QQVT(A_1);
        }

        internal void method_4(Class48 A_1)
        {
            this.ushort_1 = Class444.UInt16_0;
            Class444.arrayList_0.Add(this);
            this.bool_0 = A_1.method_5();
            this.QQVS(A_1);
        }

        internal void method_5()
        {
            if ((Class444.ushort_1 < Class444.class540_1.ushort_1) && (Class444.class540_1[Class444.ushort_1] == this.ushort_1))
            {
                this.ushort_0 = (ushort) (Class444.ushort_1 + 1);
                Class444.ushort_1 = (ushort) (Class444.ushort_1 + 1);
            }
            ArrayList qQSQ = this.QQSQ;
            if (qQSQ != null)
            {
                for (int i = 0; i < qQSQ.Count; i++)
                {
                    (qQSQ[i] as Class398).method_5();
                }
            }
        }

        internal void method_6(Class398 A_1)
        {
            if (this.arrayList_0 != null)
            {
                for (int i = 0; i < this.arrayList_0.Count; i++)
                {
                    (this.arrayList_0[i] as Class398).QQSS(this, A_1);
                }
                this.arrayList_0 = null;
            }
        }

        internal Class436 method_7()
        {
            Class436 class2 = new Class436 {
                arrayList_0 = this.arrayList_0,
                bool_0 = this.bool_0
            };
            this.method_6(class2);
            if (this.QQRX != null)
            {
                this.QQRX.method_1(this);
            }
            return class2;
        }

        internal virtual void QQSR(Class398 statement)
        {
        }

        internal virtual void QQSS(Class398 oldtarget, Class398 newtarget)
        {
        }

        internal virtual void QQST(Class398 target)
        {
        }

        internal virtual Class398 QQUS()
        {
            return this;
        }

        internal virtual void QQVS(Class48 data)
        {
        }

        internal virtual void QQVT(Class524 writer)
        {
        }

        internal virtual Class398 QQRX
        {
            get
            {
                return null;
            }
        }

        internal virtual bool QQRY
        {
            get
            {
                return false;
            }
        }

        internal virtual bool QQRZ
        {
            get
            {
                return false;
            }
        }

        internal virtual ArrayList QQSQ
        {
            get
            {
                return null;
            }
        }

        internal virtual bool QQVR
        {
            get
            {
                return (this.bool_0 && (this.arrayList_0 == null));
            }
        }

        internal abstract Enum26 Type { get; }

        internal class Class444
        {
            internal static ArrayList arrayList_0 = new ArrayList();
            internal static ArrayList arrayList_1 = new ArrayList();
            internal static Class540 class540_0 = new Class540();
            internal static Class540 class540_1 = new Class540();
            private static ushort ushort_0;
            internal static ushort ushort_1;

            internal static void smethod_0()
            {
                ushort_0 = 0;
                ushort_1 = 0;
                arrayList_0.Clear();
                arrayList_1.Clear();
                class540_0.method_0();
                class540_1.method_0();
            }

            internal static ushort UInt16_0
            {
                get
                {
                    ushort_0 = (ushort) (ushort_0 + 1);
                    return ushort_0;
                }
                set
                {
                    ushort_0 = value;
                }
            }
        }
    }
}

