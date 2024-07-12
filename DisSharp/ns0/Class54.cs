namespace ns0
{
    using System;
    using System.Collections;

    internal abstract class Class54 : Class53
    {
        private ArrayList arrayList_7 = new ArrayList();
        internal static bool bool_2 = true;

        protected Class54()
        {
        }

        private void method_30(bool A_1, int A_2)
        {
            bool_2 = false;
            try
            {
                ProgressForm form;
                int num = 0;
                DateTime time = DateTime.Now.AddMilliseconds(500.0);
                bool flag = false;
                int num2 = 0;
                while (num2 < this.arrayList_7.Count)
                {
                    if (time < DateTime.Now)
                    {
                        goto Label_005E;
                    }
                    this.QRYR(this.arrayList_7[num2] as Class547.Class528);
                    num2++;
                }
                goto Label_0062;
            Label_005E:
                flag = true;
                num = num2;
            Label_0062:
                form = null;
                if (flag)
                {
                    if (A_1)
                    {
                        form = new ProgressForm(Class537.string_213);
                        form.method_0(num, A_2);
                        form.Show();
                    }
                    for (int i = num; i < this.arrayList_7.Count; i++)
                    {
                        if (A_1)
                        {
                            if (time < DateTime.Now)
                            {
                                time = DateTime.Now.AddMilliseconds(200.0);
                                form.method_1((A_2 - this.arrayList_7.Count) + i);
                            }
                            Class582.smethod_0();
                            if (form.bool_0)
                            {
                                break;
                            }
                        }
                        this.QRYR(this.arrayList_7[i] as Class547.Class528);
                    }
                    if (A_1)
                    {
                        form.Hide();
                        form = null;
                        Class582.smethod_0();
                    }
                }
            }
            finally
            {
                bool_2 = true;
            }
        }

        internal override void QRYS(Class547.Class528 method)
        {
            if (!method.Boolean_0)
            {
                this.arrayList_7.Add(method);
            }
        }

        internal override void QRYT()
        {
            this.arrayList_7.Clear();
        }

        internal override void QRYU()
        {
            this.QRYT();
            ArrayList list = Class546.class547_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                this.QRYS(list[i] as Class547.Class528);
            }
            this.method_30(true, list.Count);
        }

        internal override void QRYV()
        {
            this.method_30(false, this.arrayList_7.Count);
        }
    }
}

