using System.Collections.Generic;
using iBookie.Features.DataAccess;

namespace iBookie.ViewModels.Bet
{
    public class TeamModel
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string MarketValue { get; set; }
        public string CreastUrl { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
