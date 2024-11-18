using System.Globalization;
using System.Windows.Data;

namespace NP.Support.Local.Converters;

public class BoolToPlayStopConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? "STOP" : "PLAY";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
