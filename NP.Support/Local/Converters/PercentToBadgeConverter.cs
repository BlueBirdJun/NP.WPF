using System.Globalization;
using System.Windows.Data;
namespace NP.Support.Local.Converters;

public class PercentToBadgeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int percent)
        {
            return percent >= 50
                ? "/NP.Support;component/Images/badge_champion2.png"
                : "/NP.Support;component/Images/badge_champion1.png";
        }
        return "/NP.Support;component/Images/badge_champion1.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
