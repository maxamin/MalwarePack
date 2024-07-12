namespace DisSharp
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Design;
    using System.Windows.Forms;
    using System.Windows.Forms.Design;

    public class FontObjectEditor : UITypeEditor
    {
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if ((((context != null) && (context.Instance != null)) && ((provider != null) && (value != null))) && (((IWindowsFormsEditorService) provider.GetService(typeof(IWindowsFormsEditorService))) != null))
            {
                FontObject obj2 = value as FontObject;
                if (obj2 != null)
                {
                    FontDialog dialog = new FontDialog {
                        AllowScriptChange = false,
                        AllowSimulations = false,
                        AllowVerticalFonts = false,
                        FixedPitchOnly = obj2.bool_0,
                        ShowEffects = false,
                        Font = new Font(obj2.string_0, obj2.float_0)
                    };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        obj2.string_0 = dialog.Font.Name;
                        obj2.float_0 = dialog.Font.Size;
                    }
                }
            }
            return base.EditValue(context, provider, value);
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if ((context != null) && (context.Instance != null))
            {
                return UITypeEditorEditStyle.Modal;
            }
            return base.GetEditStyle(context);
        }
    }
}

