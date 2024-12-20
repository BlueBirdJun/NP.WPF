using System.Windows;
using System.Windows.Controls;

namespace NP.Support.UI.Units;

public class RiotChampSkinListBox : ListBox
{
    public RiotChampSkinListBox()
    {
        DefaultStyleKey = typeof(RiotChampSkinListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampSkinGroupItem();
    }
}
