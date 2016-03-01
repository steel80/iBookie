using iBookie.ViewModels.Bet;

namespace iBookie.Services
{
    public class GroupService : IGroupService
    { 
        public GroupModel InitGroup(string name, TeamModel[] teams)
        {
            return new GroupModel()
            {
                Name = name,
                Teams = teams
            };
        }
    }
}
