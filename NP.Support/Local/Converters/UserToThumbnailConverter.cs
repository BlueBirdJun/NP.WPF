using System.Globalization;
using System.Windows.Data;

namespace NP.Support.Local.Converters;
internal class UserToThumbnailConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return $"/NP.Support;component/Images/thumb-{value}.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
