using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface IRecentDataLoader
{
    List<Recent> LoadRecents();
}
