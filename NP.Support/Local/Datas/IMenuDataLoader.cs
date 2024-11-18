using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface IMenuDataLoader
{
    List<MenuModel> LoadMenuItems();
}
