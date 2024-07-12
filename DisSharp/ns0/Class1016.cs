namespace ns0
{
    using System;
    using System.Collections;
    using System.Windows.Forms;

    internal class Class1016
    {
        private ArrayList arrayList_0 = new ArrayList();
        private const byte byte_0 = 5;
        private const byte byte_1 = 15;
        private Timer timer_0 = new Timer();

        internal Class1016()
        {
            this.timer_0.Interval = 5;
            this.timer_0.Enabled = true;
            this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
        }

        internal void method_0(Class872 A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class872 class2 = this.arrayList_0[i] as Class872;
                if (class2.enum51_0 < A_1.enum51_0)
                {
                    this.arrayList_0.Insert(i, A_1);
                    return;
                }
            }
            this.arrayList_0.Add(A_1);
        }

        internal void method_1(Class872 A_1)
        {
            this.arrayList_0.Remove(A_1);
        }

        internal void method_2()
        {
            this.arrayList_0.Clear();
        }

        private void method_3()
        {
            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < this.arrayList_0.Count; i++)
                {
                    Class872 class2 = this.arrayList_0[i] as Class872;
                    if (class2.QQWQ)
                    {
                        this.arrayList_0.Remove(class2);
                        class2.QQWS();
                        flag = true;
                        break;
                    }
                }
            }
            while (flag);
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.timer_0.Stop();
            try
            {
                Class872 class2;
                this.method_3();
                int num = 0;
                if (this.arrayList_0.Count <= 0)
                {
                    goto Label_0091;
                }
                DateTime expired = DateTime.Now.AddMilliseconds(15.0);
                bool flag = true;
                goto Label_0070;
            Label_003D:
                if (expired < DateTime.Now)
                {
                    flag = false;
                }
                if (num >= (this.arrayList_0.Count - 1))
                {
                    flag = false;
                }
                num++;
                if (flag)
                {
                    goto Label_0070;
                }
                goto Label_0091;
            Label_0067:
                class2.QQSZ(expired);
                goto Label_003D;
            Label_0070:
                class2 = this.arrayList_0[num] as Class872;
                if (class2.QQWR)
                {
                    goto Label_003D;
                }
                goto Label_0067;
            }
            catch
            {
            }
        Label_0091:
            this.timer_0.Start();
        }
    }
}

