using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface ISkinsDataLoader
{
    List<Skin> LoadSkins();
    Dictionary<string, List<Skin>> GetSkinsGroupedByName();
}
