using System.Collections.Generic;
using iBookie.ViewModels.Bet;

namespace iBookie.Services
{
    public interface IChampionsLeagueService
    {
        IEnumerable<FixtureModel> InitFixturesFor(int matchday, int id = 405);
        ChampionsLeague InitCompetition(int id = 405);
        TeamModel InitChampionsLeagueTeam(int id = 405);
        IEnumerable<GroupModel> InitChampionsLeagueGroups();
    }
}
