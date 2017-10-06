using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Prism.MefApplication.Common.Converters
{
    [ContentProperty("Converters")]
    public class ComposedConverter : IValueConverter
    {
        private readonly Collection<IValueConverter> _converters = new Collection<IValueConverter>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Collection<IValueConverter> Converters => _converters;
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            for (int i = 0; i < _converters.Count; i++)
            {
                value = _converters[i].Convert(value, targetType, parameter, culture);
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            for (int i = 0; i < _converters.Count; i++)
            {
                value = _converters[i].ConvertBack(value, targetType, parameter, culture);
            }

            return value;
        }
    }
}
