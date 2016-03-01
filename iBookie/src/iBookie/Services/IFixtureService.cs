using System.Collections.Generic;
using iBookie.Features.DataAccess;
using iBookie.ViewModels.Bet;

namespace iBookie.Services
{
    public interface IFixtureService
    {
        FixtureModel InitFixture(Fixture fixture);
        IEnumerable<FixtureModel> InitSeasonFixtures(int id, int matchday);
    }
}
