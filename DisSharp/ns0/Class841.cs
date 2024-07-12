namespace ns0
{
    using System;
    using System.Collections;
    using System.Windows.Forms;

    internal class Class841
    {
        private static ArrayList arrayList_0 = new ArrayList();
        private Hashtable hashtable_0 = new Hashtable();

        internal Class842 method_0(Class394 A_1)
        {
            if (this.hashtable_0.Contains(A_1))
            {
                return (this.hashtable_0[A_1] as Class842);
            }
            Class842 class2 = new Class842(A_1);
            this.hashtable_0.Add(A_1, class2);
            return class2;
        }

        internal void method_1(Class394 A_1)
        {
            this.method_0(A_1);
            Class705.smethod_1();
        }

        internal void method_2(Class394 A_1)
        {
            Class842 class2 = this.hashtable_0[A_1] as Class842;
            if (class2 != null)
            {
                Class843 class3 = class2.class843_0;
                Hashtable hashtable = class3.Hashtable_0;
                foreach (object obj2 in hashtable.Keys)
                {
                    Class844 class4 = hashtable[obj2] as Class844;
                    ArrayList list = class4.ArrayList_0;
                    for (int j = 0; j < list.Count; j++)
                    {
                        Class646 class5 = list[j] as Class646;
                        if (arrayList_0.IndexOf(class5.class845_0) == -1)
                        {
                            arrayList_0.Add(class5.class845_0);
                        }
                    }
                    list.Clear();
                }
                for (int i = 0; i < arrayList_0.Count; i++)
                {
                    Class845 class6 = arrayList_0[i] as Class845;
                    Class645.class704_0.method_5(class6);
                }
                class3.method_2();
                arrayList_0.Clear();
                this.hashtable_0.Remove(A_1);
                Class705.smethod_1();
            }
        }

        internal bool method_3()
        {
            Class394 class2 = Class519.class394_0;
            try
            {
                for (int i = 0; i < Class698.class582_0.class686_0.class802_0.Nodes.Count; i++)
                {
                    Class686.Class687 class3 = Class698.class582_0.class686_0.class802_0.Nodes[i] as Class686.Class687;
                    Class394 class4 = class3.class369_0 as Class394;
                    if (class4.class803_0.bool_0 && this.method_4(class4))
                    {
                        goto Label_006E;
                    }
                }
                goto Label_0080;
            Label_006E:
                Class519.class394_0 = class2;
                return true;
            }
            finally
            {
                Class519.class394_0 = class2;
            }
        Label_0080:
            return false;
        }

        internal bool method_4(Class394 A_1)
        {
            switch (MessageBox.Show(Class537.string_604 + A_1.Name + Class537.string_424, Class537.string_23, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
            {
                case DialogResult.Yes:
                    Class519.class394_0 = A_1;
                    Class705.class705_5.method_0();
                    return false;

                case DialogResult.No:
                    return false;

                case DialogResult.Cancel:
                    return true;
            }
            return false;
        }
    }
}

