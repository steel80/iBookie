using System;
using System.Collections.Generic;
using System.Linq;
using iBookie.Features.DataAccess;
using iBookie.Features.Repository;
using iBookie.ViewModels.Bet;

namespace iBookie.Services
{
    public class FixtureService : IFixtureService
    {
        private readonly IRepository<FixturesRoot> _repository;

        public FixtureService(IRepository<FixturesRoot> repository)
        {
            _repository = repository;
        }
        public FixtureModel InitFixture(Fixture fixture)
        {
            return new FixtureModel()
            {
                Date = fixture.date,
                Status = fixture.status,
                MatchDay = fixture.matchday,
                HomeTeam = fixture.homeTeamName,
                AwayTeam = fixture.awayTeamName,
                GoalsHomeTeam = Convert.ToInt32(fixture.result.goalsHomeTeam),
                GoalsAwayTeam = Convert.ToInt32(fixture.result.goalsAwayTeam)
            };
        }

        public IEnumerable<FixtureModel> InitSeasonFixtures(int id, int matchday)
        {
            var root = _repository.Search($"/soccerseasons/{id}/fixtures/?matchday={matchday}");
            return root.fixtures.Select(InitFixture);
        }
    }
}
