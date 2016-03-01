using System.Collections.Generic;

namespace iBookie.ViewModels.Bet
{
    public class ChampionsLeague
    {
        public string Name { get; set; }
        public int NumberOfTeams { get; set; }
        public int NumberOfGames { get; set; }

        public IEnumerable<GroupModel> Groups { get; set; }
        public IEnumerable<FixtureModel> Fixtures { get; set; }
    }
}
