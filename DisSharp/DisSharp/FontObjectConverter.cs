namespace DisSharp
{
    using ns0;
    using System;
    using System.ComponentModel;
    using System.Globalization;

    public class FontObjectConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return ((destinationType == typeof(string)) || base.CanConvertTo(context, destinationType));
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if ((destinationType == typeof(string)) && (value is FontObject))
            {
                FontObject obj2 = value as FontObject;
                return (obj2.string_0 + ", " + Class543.smethod_2(obj2.float_0));
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}

