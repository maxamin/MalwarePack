namespace ns0
{
    using System;

    internal class Class1059
    {
        private const byte byte_0 = 1;
        private const byte byte_1 = 2;
        private byte byte_10;
        private byte byte_11;
        private byte byte_12;
        private byte byte_13;
        private byte byte_14;
        private byte byte_15;
        private const byte byte_2 = 4;
        private const byte byte_3 = 8;
        private byte[] byte_4;
        private byte[] byte_5;
        private byte[] byte_6;
        private byte[] byte_7;
        private byte[] byte_8;
        private byte[] byte_9;

        internal void method_0()
        {
            this.Byte_0 = null;
        }

        internal void method_1()
        {
            this.byte_4 = null;
            this.byte_10 = 0;
            this.byte_6 = null;
            this.byte_12 = 0;
            this.byte_7 = null;
            this.byte_13 = 0;
            this.byte_8 = null;
            this.byte_14 = 0;
        }

        internal bool Boolean_0
        {
            get
            {
                return (this.Byte_0 != null);
            }
        }

        internal byte[] Byte_0
        {
            get
            {
                switch (Class516.enum6_0)
                {
                    case Enum6.flag_1:
                        return this.byte_4;

                    case Enum6.flag_2:
                        return this.byte_6;

                    case Enum6.flag_3:
                        return this.byte_7;

                    case Enum6.flag_4:
                        return this.byte_8;

                    case Enum6.flag_5:
                        return this.byte_9;

                    case Enum6.flag_6:
                        return this.byte_5;
                }
                throw new Exception1();
            }
            set
            {
                switch (Class516.enum6_0)
                {
                    case Enum6.flag_1:
                        this.byte_4 = value;
                        return;

                    case Enum6.flag_2:
                        this.byte_6 = value;
                        return;

                    case Enum6.flag_3:
                        this.byte_7 = value;
                        return;

                    case Enum6.flag_4:
                        this.byte_8 = value;
                        return;

                    case Enum6.flag_5:
                        this.byte_9 = value;
                        return;

                    case Enum6.flag_6:
                        this.byte_5 = value;
                        return;
                }
                throw new Exception1();
            }
        }

        internal byte Byte_1
        {
            get
            {
                switch (Class516.enum6_0)
                {
                    case Enum6.flag_1:
                        return this.byte_10;

                    case Enum6.flag_2:
                        return this.byte_12;

                    case Enum6.flag_3:
                        return this.byte_13;

                    case Enum6.flag_4:
                        return this.byte_14;

                    case Enum6.flag_5:
                        return this.byte_15;

                    case Enum6.flag_6:
                        return this.byte_11;
                }
                throw new Exception1();
            }
            set
            {
                switch (Class516.enum6_0)
                {
                    case Enum6.flag_1:
                        this.byte_10 = value;
                        return;

                    case Enum6.flag_2:
                        this.byte_12 = value;
                        return;

                    case Enum6.flag_3:
                        this.byte_13 = value;
                        return;

                    case Enum6.flag_4:
                        this.byte_14 = value;
                        return;

                    case Enum6.flag_5:
                        this.byte_15 = value;
                        return;

                    case Enum6.flag_6:
                        this.byte_11 = value;
                        return;
                }
                throw new Exception1();
            }
        }
    }
}

