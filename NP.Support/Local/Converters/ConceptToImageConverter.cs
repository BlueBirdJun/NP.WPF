using System.Globalization;
using System.Windows.Data;
namespace NP.Support.Local.Converters;

public class ConceptToImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string concept)
        {
            return $"/NP.Support;component/Images/Concepts/{concept}.png";
        }
        return "/NP.Support;component/Images/Concepts/warrior.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
