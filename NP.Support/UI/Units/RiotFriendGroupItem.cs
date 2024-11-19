using Jamesnet.Windows;
using System.Windows;

namespace NP.Support.UI.Units;

public class RiotFriendGroupItem : RecursiveControl
{
    public RiotFriendGroupItem()
    {
        DefaultStyleKey = typeof(RiotFriendGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendItemControl();
    }
}
