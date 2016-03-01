using iBookie.Features.DataAccess;
using iBookie.ViewModels.Bet;

namespace iBookie.Services
{
    public class TeamService : ITeamService
    {
        public TeamModel InitTeam(int id, FdTeam team)
        {
            return new TeamModel()
            {
                TeamId = id,
                Name = team?.name,
                CreastUrl = team?.crestUrl,
                MarketValue = team?.squadMarketValue
            };
        }
    }
}
