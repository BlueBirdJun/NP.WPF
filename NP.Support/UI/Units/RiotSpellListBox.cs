
using System.Windows;
using System.Windows.Controls;

namespace NP.Support.UI.Units;

public class RiotSpellListBox : ListBox
{
    public RiotSpellListBox()
    {
        DefaultStyleKey = typeof(RiotSpellListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotSpellListBoxItem();
    }
}
