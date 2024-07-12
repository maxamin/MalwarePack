namespace ns0
{
    using Crownwood.DotNetMagic.Controls;
    using System;
    using System.Collections;
    using System.Windows.Forms;

    internal class Class704
    {
        private ArrayList arrayList_0 = new ArrayList();
        private bool bool_0;
        private Control3 control3_0;
        private Crownwood.DotNetMagic.Controls.TabControl tabControl_0;
        private Crownwood.DotNetMagic.Controls.TabPageCollection tabPageCollection_0;

        internal void method_0()
        {
            this.control3_0 = Control3.Control3_0;
            this.tabControl_0 = Class698.class582_0.class891_0.tabControl_0;
            this.tabPageCollection_0 = this.tabControl_0.TabPages;
            this.method_9();
        }

        internal Class845 method_1(Class397 A_1, Class369 A_2, string A_3, Enum54 A_4, Enum43 A_5)
        {
            Class845 class2;
            this.method_10();
            if (Class516.bool_5 && (this.arrayList_0.Count != 0))
            {
                class2 = this.arrayList_0[this.Int32_0] as Class845;
                class2.Controls.Clear();
            }
            else
            {
                class2 = new Class845(A_2, A_4);
                this.method_3(class2);
            }
            Control0 control = new Control0(Class519.class394_0, A_1, A_5);
            class2.Controls.Add(control);
            class2.Title = A_3;
            class2.Selected = true;
            this.tabControl_0.MakePageVisible(class2);
            if (!Class516.bool_6)
            {
                control.Focus();
            }
            Class705.smethod_1();
            return class2;
        }

        private void method_10()
        {
            if (this.bool_0)
            {
                this.tabPageCollection_0.RemoveAt(0);
                this.arrayList_0.RemoveAt(0);
                this.bool_0 = false;
                this.tabControl_0.HideTabsMode = HideTabsModes.ShowAlways;
            }
        }

        internal void method_11()
        {
            if (this.bool_0)
            {
                Control3 control = this.tabPageCollection_0[0].Controls[0] as Control3;
                if (control != null)
                {
                    control.method_1();
                }
            }
        }

        internal void method_12(Class397 A_1)
        {
            this.method_14(A_1, Enum54.const_5, Class537.string_836);
        }

        internal void method_13(Class397 A_1)
        {
            this.method_14(A_1, Enum54.const_6, Class537.string_166);
        }

        private void method_14(Class397 A_1, Enum54 A_2, string A_3)
        {
            this.method_10();
            Class845 class2 = null;
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                Class845 class3 = this.arrayList_0[i] as Class845;
                if (class3.Enum54_0 == A_2)
                {
                    class2 = class3;
                    break;
                }
            }
            if (class2 == null)
            {
                class2 = new Class845(null, A_2);
                this.method_3(class2);
            }
            Control0 control = new Control0(Class519.class394_0, A_1, Enum43.const_1);
            class2.Controls.Add(control);
            class2.Title = A_3;
            class2.Selected = true;
            this.tabControl_0.MakePageVisible(class2);
            control.Focus();
            Class705.smethod_1();
        }

        internal void method_15(Class845 A_1)
        {
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                if (this.arrayList_0[i] == A_1)
                {
                    this.tabControl_0.SelectedIndex = i;
                    return;
                }
            }
            Class705.smethod_1();
            this.method_17();
        }

        internal void method_16()
        {
            this.method_18();
        }

        internal void method_17()
        {
            this.method_18();
            this.method_19();
        }

        private void method_18()
        {
            if (this.Control0_0 != null)
            {
                this.Control0_0.method_5();
            }
        }

        private void method_19()
        {
            if (this.Control0_0 != null)
            {
                this.Control0_0.Focus();
            }
        }

        internal Class845 method_2(Control A_1, Class369 A_2, string A_3, Enum54 A_4)
        {
            Class845 class2;
            this.method_10();
            if (Class516.bool_5 && (this.arrayList_0.Count != 0))
            {
                class2 = this.arrayList_0[this.Int32_0] as Class845;
                class2.Controls.Clear();
            }
            else
            {
                class2 = new Class845(A_2, A_4);
                this.method_3(class2);
            }
            class2.Title = A_3;
            class2.Selected = true;
            class2.Controls.Add(A_1);
            this.tabControl_0.MakePageVisible(class2);
            Class705.smethod_1();
            return class2;
        }

        private void method_3(Class845 A_1)
        {
            if (this.tabPageCollection_0.Count == 0)
            {
                this.tabPageCollection_0.Add(A_1);
                this.arrayList_0.Add(A_1);
            }
            else
            {
                int selectedIndex = this.tabControl_0.SelectedIndex;
                this.tabPageCollection_0.Insert(selectedIndex + 1, A_1);
                this.arrayList_0.Insert(selectedIndex + 1, A_1);
            }
        }

        internal void method_4(int A_1)
        {
            (this.arrayList_0[A_1] as Class845).method_1();
            this.tabPageCollection_0.RemoveAt(A_1);
            this.arrayList_0.RemoveAt(A_1);
            this.method_9();
            Class705.smethod_1();
        }

        internal void method_5(Class845 A_1)
        {
            int index = this.arrayList_0.IndexOf(A_1);
            if (index != -1)
            {
                this.method_4(index);
            }
            Class705.smethod_1();
        }

        internal void method_6()
        {
            if (!this.Boolean_0)
            {
                this.method_4(this.Int32_0);
                this.method_9();
            }
        }

        internal void method_7()
        {
            if (!this.Boolean_0)
            {
                int count = this.tabPageCollection_0.Count;
                for (int i = 0; i < count; i++)
                {
                    this.method_4(0);
                }
                this.method_9();
            }
        }

        internal void method_8()
        {
            if (!this.Boolean_0)
            {
                int num = this.Int32_0;
                for (int i = 0; i < num; i++)
                {
                    this.method_4(0);
                }
                int count = this.tabPageCollection_0.Count;
                for (int j = 1; j < count; j++)
                {
                    this.method_4(1);
                }
            }
        }

        private void method_9()
        {
            if (this.tabPageCollection_0.Count == 0)
            {
                Class845 class2 = new Class845(null, Enum54.const_3) {
                    Selected = true,
                    Controls = { this.control3_0 }
                };
                this.method_3(class2);
                this.tabControl_0.MakePageVisible(class2);
                this.bool_0 = true;
                this.tabControl_0.HideTabsMode = HideTabsModes.HideUsingLogic;
            }
        }

        internal bool Boolean_0
        {
            get
            {
                if (!this.bool_0)
                {
                    return (this.arrayList_0.Count == 0);
                }
                return true;
            }
        }

        internal bool Boolean_1
        {
            get
            {
                if (!this.bool_0 && (this.arrayList_0.Count != 0))
                {
                    return (this.Control0_0 == null);
                }
                return true;
            }
        }

        internal Control0 Control0_0
        {
            get
            {
                if (!this.bool_0 && (this.arrayList_0.Count != 0))
                {
                    Class845 class2 = this.arrayList_0[this.Int32_0] as Class845;
                    return (class2.Controls[0] as Control0);
                }
                return null;
            }
        }

        internal int Int32_0
        {
            get
            {
                return this.tabControl_0.SelectedIndex;
            }
        }

        internal string String_0
        {
            get
            {
                if (!this.bool_0 && (this.arrayList_0.Count != 0))
                {
                    Class845 class2 = this.arrayList_0[this.Int32_0] as Class845;
                    return class2.Title;
                }
                return "";
            }
        }
    }
}

