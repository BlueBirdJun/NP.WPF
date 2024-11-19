using Jamesnet.Windows;
using System.Windows;

namespace NP.Support.UI.Units;

public class RiotChampGroupItem : RecursiveControl
{
    public RiotChampGroupItem()
    {
        DefaultStyleKey = typeof(RiotChampGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampItemControl();
    }
}
