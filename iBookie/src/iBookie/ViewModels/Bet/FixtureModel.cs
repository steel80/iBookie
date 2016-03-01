using System;

namespace iBookie.ViewModels.Bet
{
    public class FixtureModel
    {
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int MatchDay { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int GoalsHomeTeam { get; set; }
        public int GoalsAwayTeam { get; set; }
    }
}
