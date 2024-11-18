using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface IChampStatsDataLoader
{
    List<ChampionStats> LoadChampionStats();
    Dictionary<string, List<ChampionStats>> GetStatsByPosition();
}
