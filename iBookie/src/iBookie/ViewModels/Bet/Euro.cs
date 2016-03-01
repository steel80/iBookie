using System.Collections.Generic;
using iBookie.Features.DataAccess;

namespace iBookie.ViewModels.Bet
{
    public class Euro
    {
        public CompetitionRoot CompetitionRoot { get; set; }

        public IEnumerable<GroupModel> Groups { get; set; }
        public FixturesRoot FixturesRoot { get; set; }
    }
}
