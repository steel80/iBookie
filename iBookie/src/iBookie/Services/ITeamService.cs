using iBookie.Features.DataAccess;
using iBookie.ViewModels.Bet;

namespace iBookie.Services
{
    public interface ITeamService
    {
        TeamModel InitTeam(int id, FdTeam team);
    }
}
