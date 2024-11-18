using NP.Support.Local.Models;

namespace NP.Support.Local.Datas;

public interface ITeamFightsDataLoader
{
    List<TeamFight> LoadTeamFights();
}
