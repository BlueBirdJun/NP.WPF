using NP.Support.Local.Models;

namespace NP.Support.Local.Services;

public interface ISubMenuNavigator
{
    event Action<List<SubMenuItem>> SubMenuItemsUpdated;
    void UpdateSubMenuItems(string mainMenu);
    List<SubMenuItem> GetSubMenuItems(string mainMenu);
    void NavigateToSubMenu(SubMenuItem subMenuItem);
    void NavigateToMainMenu();
}
