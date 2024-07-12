namespace ns0
{
    using DisSharp;
    using System;
    using System.Collections;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    internal class Class1008
    {
        internal static bool bool_0;
        private static char[] char_0 = new char[200];
        private const uint uint_0 = 200;

        internal static void smethod_0()
        {
            string path = Path.ChangeExtension(Class519.class394_0.string_2, Class537.string_473);
            if (!File.Exists(path))
            {
                MessageBox.Show(Class537.string_834 + path + Class537.string_395, Class537.string_941, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (!Class519.class394_0.bool_3 || (MessageBox.Show(Class537.string_709, Class537.string_349, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel))
            {
                try
                {
                    bool_0 = false;
                    QSQQ qsqq = smethod_5();
                    if (qsqq != null)
                    {
                        smethod_2(qsqq);
                    }
                    if (bool_0)
                    {
                        Class519.class394_0.bool_3 = true;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, Class537.string_941, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        internal static void smethod_1()
        {
            if (File.Exists(Path.ChangeExtension(Class519.class394_0.string_2, Class537.string_473)))
            {
                try
                {
                    bool_0 = false;
                    QSQQ qsqq = smethod_5();
                    if (qsqq != null)
                    {
                        smethod_2(qsqq);
                    }
                    if (bool_0)
                    {
                        Class519.class394_0.bool_3 = true;
                    }
                }
                catch
                {
                }
            }
        }

        private static void smethod_2(QSQQ A_0)
        {
            ArrayList list = Class546.class547_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                uint token = Class689.smethod_0(Enum0.const_6, i);
                QSQR method = null;
                A_0.GetMethod(token, ref method);
                if (method != null)
                {
                    Class547.Class528 class2 = list[i] as Class547.Class528;
                    QSQS rootScope = method.GetRootScope();
                    if (rootScope != null)
                    {
                        smethod_3(class2, rootScope);
                    }
                }
            }
        }

        private static void smethod_3(Class547.Class528 A_0, QSQS A_1)
        {
            uint num;
            ArrayList list = Class546.class574_0.arrayList_0;
            int num2 = A_0.int_7;
            uint localCount = A_1.GetLocalCount();
            IntPtr[] locals = new IntPtr[localCount];
            A_1.GetLocals(localCount, out num, locals);
            for (int i = 0; i < localCount; i++)
            {
                QSQT typedObjectForIUnknown = (QSQT) Marshal.GetTypedObjectForIUnknown(locals[i], typeof(QSQT));
                if (typedObjectForIUnknown != null)
                {
                    typedObjectForIUnknown.GetName(200, out num, char_0);
                    if (smethod_4(char_0, num))
                    {
                        int num5 = (int) typedObjectForIUnknown.GetAddressField1();
                        Class574.Class636 class2 = list[num2 + num5] as Class574.Class636;
                        if (class2.int_0 > 0)
                        {
                            Class519.class581_0[class2.int_0] = new string(char_0, 0, ((int) num) - 1);
                        }
                        else
                        {
                            class2.int_0 = Class519.class581_0.method_0(new string(char_0, 0, ((int) num) - 1));
                        }
                        bool_0 = true;
                    }
                    Marshal.ReleaseComObject(typedObjectForIUnknown);
                }
                Marshal.Release(locals[i]);
            }
            A_1.GetChildren(0, out num, null);
            IntPtr[] children = new IntPtr[num];
            A_1.GetChildren(num, out num, children);
            for (int j = 0; j < num; j++)
            {
                QSQS qsqs = (QSQS) Marshal.GetTypedObjectForIUnknown(children[j], typeof(QSQS));
                if (qsqs != null)
                {
                    smethod_3(A_0, qsqs);
                    Marshal.ReleaseComObject(qsqs);
                }
                Marshal.Release(children[j]);
            }
        }

        private static bool smethod_4(char[] A_0, uint A_1)
        {
            if (A_1 <= 1)
            {
                return false;
            }
            char c = A_0[0];
            if (!char.IsLetter(c) && (c != '_'))
            {
                return false;
            }
            for (int i = 1; i < (A_1 - 1); i++)
            {
                c = A_0[i];
                if (!char.IsLetterOrDigit(c) && (c != '_'))
                {
                    return false;
                }
            }
            return true;
        }

        private static QSQQ smethod_5()
        {
            string scope = Class519.class394_0.string_2;
            object import = null;
            QRZX o = new QRZX();
            QSQV qsqv = o as QSQV;
            Guid iid = new Guid("{0x7dac8207, 0xd3ae, 0x4c75, {0x9b, 0x67, 0x92, 0x80, 0x1a, 0x49, 0x7d, 0x44}}");
            qsqv.OpenScope(scope, 0, ref iid, out import);
            if (import == null)
            {
                throw new SystemException(Class537.string_678);
            }
            QSQQ reader = null;
            QRZY qrzy = null;
            QRZZ qrzz = null;
            try
            {
                int num = 0;
                try
                {
                    qrzz = new QRZZ();
                    num = ((QSQX) qrzz).GetReaderForFile(import, scope, null, out reader);
                }
                catch (COMException exception)
                {
                    if (exception.ErrorCode != -2147221231)
                    {
                        throw;
                    }
                    qrzy = new QRZY();
                    num = ((QSQW) qrzy).GetReaderForFile(import, scope, null, out reader);
                }
                int num2 = num;
                if (num2 == -2140340219)
                {
                    return reader;
                }
                if (num2 != -2140340204)
                {
                    if (num2 != 0)
                    {
                        throw new SystemException(Class537.string_443 + num.ToString("X"));
                    }
                    return reader;
                }
                if (File.Exists(Path.ChangeExtension(scope, Class537.string_473)))
                {
                    throw new SystemException(Class537.string_695 + scope + Class537.string_760);
                }
            }
            finally
            {
                if (o != null)
                {
                    Marshal.ReleaseComObject(o);
                }
                if (qrzy != null)
                {
                    Marshal.ReleaseComObject(qrzy);
                }
                if (qrzz != null)
                {
                    Marshal.ReleaseComObject(qrzz);
                }
            }
            return reader;
        }
    }
}

