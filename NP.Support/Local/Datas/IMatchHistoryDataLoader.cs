using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface IMatchHistoryDataLoader
{
    List<MatchHistory> LoadMatchHistories();
}
