namespace ns0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class Class936
    {
        private EventHandler eventHandler_0;
        private ImageList imageList_0;
        private MenuStrip menuStrip_0;
        internal ToolStripMenuItem toolStripMenuItem_0;
        internal ToolStripMenuItem toolStripMenuItem_1;
        internal ToolStripMenuItem toolStripMenuItem_2;
        internal ToolStripMenuItem toolStripMenuItem_3;
        internal ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripMenuItem toolStripMenuItem_5;

        internal void method_0(Class582 A_1)
        {
            this.menuStrip_0 = A_1.mainForm_0.menu;
            this.imageList_0 = A_1.mainForm_0.imageList_0;
            this.eventHandler_0 = (EventHandler) Delegate.Combine(this.eventHandler_0, new EventHandler(this.method_1));
            this.method_9();
        }

        private void method_1(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                Class705 tag = item.Tag as Class705;
                if (tag != null)
                {
                    Class925.smethod_0(tag);
                }
            }
        }

        private void method_2(string A_1)
        {
            this.toolStripMenuItem_5 = new ToolStripMenuItem(A_1);
            this.menuStrip_0.Items.Add(this.toolStripMenuItem_5);
        }

        private ToolStripMenuItem method_3(string A_1, int A_2, Shortcut A_3, Class705 A_4)
        {
            Image image = (A_2 < 0) ? null : this.imageList_0.Images[A_2];
            Keys shortcutKeys = Class820.smethod_0(A_3);
            ToolStripMenuItem item = new ToolStripMenuItem(A_1, image, this.eventHandler_0, shortcutKeys) {
                Tag = A_4
            };
            this.toolStripMenuItem_5.DropDownItems.Add(item);
            A_4.toolStripMenuItem_0 = item;
            A_4.QQTR();
            return item;
        }

        private ToolStripMenuItem method_4(string A_1, int A_2, Class705 A_3)
        {
            return this.method_3(A_1, A_2, Shortcut.None, A_3);
        }

        private ToolStripMenuItem method_5(string A_1, Shortcut A_2, Class705 A_3)
        {
            return this.method_3(A_1, -1, A_2, A_3);
        }

        private ToolStripMenuItem method_6(string A_1, Class705 A_2)
        {
            return this.method_3(A_1, -1, Shortcut.None, A_2);
        }

        private ToolStripMenuItem method_7(string A_1)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(A_1);
            this.toolStripMenuItem_5.DropDownItems.Add(item);
            return item;
        }

        private void method_8()
        {
            this.toolStripMenuItem_5.DropDownItems.Add(new ToolStripSeparator());
        }

        private void method_9()
        {
            this.method_2(Class537.string_185);
            this.method_3(Class537.string_2, Class868.int_18, Shortcut.CtrlL, Class705.class705_0);
            this.method_6(Class537.string_605, Class705.class705_1);
            this.toolStripMenuItem_0 = this.method_7(Class537.string_323);
            this.method_3(Class537.string_794, Class868.int_70, Shortcut.CtrlU, Class705.class705_2);
            this.method_4(Class537.string_175, Class868.int_64, Class705.class705_3);
            this.toolStripMenuItem_1 = this.method_7(Class537.string_623);
            this.method_8();
            this.method_3(Class537.string_240, Class868.int_56, Shortcut.CtrlO, Class705.class705_4);
            this.method_3(Class537.string_439, Class868.int_62, Shortcut.CtrlS, Class705.class705_5);
            this.method_4(Class537.string_560, Class868.int_63, Class705.class705_6);
            this.toolStripMenuItem_2 = this.method_7(Class537.string_164);
            this.method_8();
            this.method_5(Class537.string_757, Shortcut.AltF4, Class705.class705_7);
            this.method_2(Class537.string_563);
            this.method_3(Class537.string_254, Class868.int_39, Shortcut.CtrlC, Class705.class705_8);
            this.method_4(Class537.string_617, Class868.int_67, Class705.class705_9);
            this.method_8();
            this.method_5(Class537.string_616, Shortcut.F12, Class705.class705_10);
            this.method_5(Class537.string_428, Shortcut.CtrlN, Class705.class705_11);
            this.method_5(Class537.string_177, Shortcut.CtrlH, Class705.class705_12);
            this.method_6(Class537.string_570, Class705.class705_13);
            this.method_6(Class537.string_229, Class705.class705_14);
            this.method_6(Class537.string_127, Class705.class705_15);
            this.method_6(Class537.string_440, Class705.class705_16);
            this.method_2(Class537.string_875);
            this.method_3(Class537.string_831, Class868.int_41, Shortcut.F4, Class705.class705_19);
            this.method_8();
            this.method_3(Class537.string_945, Class868.int_42, Shortcut.F3, Class705.class705_20);
            this.method_3(Class537.string_117, Class868.int_43, Shortcut.CtrlF3, Class705.class705_21);
            this.method_3(Class537.string_881, Class868.int_44, Shortcut.AltF3, Class705.class705_22);
            this.method_8();
            this.method_3(Class537.string_30, Class868.int_45, Shortcut.F2, Class705.class705_23);
            this.method_3(Class537.string_426, Class868.int_46, Shortcut.CtrlF2, Class705.class705_24);
            this.method_3(Class537.string_15, Class868.int_47, Shortcut.AltF2, Class705.class705_25);
            this.method_8();
            this.method_3(Class537.string_328, Class868.int_72, Shortcut.ShiftF4, Class705.class705_26);
            this.method_2(Class537.string_147);
            this.method_4(Class537.string_538, Class868.int_74, Class705.class705_28);
            this.method_4(Class537.string_899, Class868.int_76, Class705.class705_31);
            this.method_4(Class537.string_474, Class868.int_75, Class705.class705_32);
            this.method_4(Class537.string_437, Class868.int_73, Class705.class705_33);
            this.method_2(Class537.string_648);
            this.method_3(Class537.string_138, Class868.int_68, Shortcut.F11, Class705.class705_34);
            this.method_8();
            this.method_4(Class537.string_693, Class868.int_49, Class705.class705_36);
            this.method_4(Class537.string_247, Class868.int_24, Class705.class705_42);
            this.method_4(Class537.string_453, Class868.int_61, Class705.class705_43);
            this.method_4(Class537.string_135, Class868.int_48, Class705.class705_37);
            this.method_8();
            this.method_6(Class537.string_296, Class705.class705_44);
            this.method_2(Class537.string_891);
            this.toolStripMenuItem_3 = this.method_3(Class537.string_538, Class868.int_1, Shortcut.F5, Class705.class705_45);
            this.method_5(Class537.string_251, Shortcut.CtrlF5, Class705.class705_46);
            this.method_5(Class537.string_404, Shortcut.AltF5, Class705.class705_51);
            this.method_8();
            this.method_5(Class537.string_933, Shortcut.CtrlF8, Class705.class705_47);
            this.method_5(Class537.string_343, Shortcut.AltF8, Class705.class705_48);
            this.method_5(Class537.string_936, Shortcut.ShiftF8, Class705.class705_49);
            this.method_5(Class537.string_861, Shortcut.F8, Class705.class705_50);
            Class950.smethod_0(70);
            this.method_2(Class537.string_180);
            this.toolStripMenuItem_4 = this.method_3(Class537.string_538, Class868.int_15, Shortcut.F6, Class705.class705_52);
            this.method_5(Class537.string_251, Shortcut.CtrlF6, Class705.class705_53);
            this.method_3(Class537.string_404, Class868.int_37, Shortcut.AltF6, Class705.class705_54);
            this.method_8();
            this.method_3(Class537.string_564, Class868.int_38, Shortcut.Ctrl1, Class705.class705_55);
            this.method_2(Class537.string_517);
            this.method_6(Class537.string_385, Class705.class705_56);
            this.method_6(Class537.string_568, Class705.class705_57);
            this.method_6(Class537.string_142, Class705.class705_58);
            this.method_6(Class537.string_471, Class705.class705_59);
            this.method_6(Class537.string_476, Class705.class705_60);
            this.method_6(Class537.string_50, Class705.class705_61);
            this.method_6(Class537.string_732, Class705.class705_62);
            this.method_6(Class537.string_876, Class705.class705_63);
            this.method_8();
            this.method_6(Class537.string_935, Class705.class705_64);
            this.method_6(Class537.string_889, Class705.class705_65);
            this.method_6(Class537.string_859, Class705.class705_66);
            this.method_6(Class537.string_129, Class705.class705_67);
            this.method_6(Class537.string_427, Class705.class705_68);
            this.method_6(Class537.string_455, Class705.class705_69);
            this.method_2(Class537.string_506);
            this.method_4(Class537.string_355, Class868.int_40, Class705.class705_71);
            this.method_4(Class537.string_310, Class868.int_54, Class705.class705_70);
            this.method_6(Class537.string_940, Class705.class705_72);
            this.method_8();
            this.method_4(Class537.string_136, Class868.int_57, Class705.class705_74);
            this.method_2(Class537.string_20);
            this.method_4(Class537.string_20, Class868.int_51, Class705.class705_75);
            this.method_6(Class537.string_600, Class705.class705_77);
            this.method_6(Class537.string_626, Class705.class705_79);
            this.method_8();
            this.method_4(Class537.string_773, Class868.int_53, Class705.class705_76);
            this.method_4(Class537.string_566, Class868.int_55, Class705.class705_78);
            this.method_4(Class537.string_320, Class868.int_59, Class705.class705_80);
            this.method_8();
            this.method_4(Class537.string_499, Class868.int_36, Class705.class705_81);
            this.method_4(Class537.string_405, Class868.int_71, Class705.class705_82);
            this.method_4(Class537.string_769, Class868.int_35, Class705.class705_83);
        }
    }
}

