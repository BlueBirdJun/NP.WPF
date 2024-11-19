using System.Windows;
using System.Windows.Controls;

namespace NP.Support.UI.Units;

public class RiotRecentListBox : ListBox
{
    public RiotRecentListBox()
    {
        DefaultStyleKey = typeof(RiotRecentListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotRecentListBoxItem();
    }
}
