namespace ns0
{
    using System;

    internal class Class390 : Class369
    {
        internal Class562.Class533 class533_0;

        internal override void Load(Class656 reader)
        {
            int num = reader.ReadInt32();
            if (num > 0)
            {
                this.class533_0 = Class546.class562_0.arrayList_0[num] as Class562.Class533;
                this.class533_0.class369_0 = this;
            }
            else
            {
                this.class533_0 = Class546.class562_0.arrayList_0[Class546.class562_0.arrayList_0.Count - 1] as Class562.Class533;
                this.class533_0.class369_0 = this;
            }
        }

        internal override void Save(Class524 writer)
        {
            writer.Write(this.class533_0.int_0);
        }

        internal override string Name
        {
            get
            {
                return Class519.class581_0[this.class533_0.int_1];
            }
            set
            {
                Class519.class581_0[this.class533_0.int_1] = value;
            }
        }

        internal override int QQQR
        {
            get
            {
                return Class868.int_16;
            }
        }

        internal override Enum10 QQQS
        {
            get
            {
                return Enum10.const_1;
            }
        }

        internal override Enum57 QQTT
        {
            get
            {
                return Enum57.const_2;
            }
        }

        internal override bool QQVW
        {
            get
            {
                return this.class533_0.bool_0;
            }
        }
    }
}

