using iBookie.ViewModels.Bet;

namespace iBookie.Services
{
    public interface IGroupService
    {
        GroupModel InitGroup(string name, TeamModel[] teams);
    }
}
