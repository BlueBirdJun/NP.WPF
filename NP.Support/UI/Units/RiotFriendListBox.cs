using System.Windows;
using System.Windows.Controls;

namespace NP.Support.UI.Units;

public class RiotFriendListBox : ListBox
{
    public RiotFriendListBox()
    {
        DefaultStyleKey = typeof(RiotFriendListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendGroupItem();
    }
}
