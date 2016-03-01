using System.Collections.Generic;
using iBookie.Features.DataAccess;
using iBookie.Features.Repository;
using iBookie.ViewModels.Bet;

namespace iBookie.Services
{
    public class ChampionsLeagueService : IChampionsLeagueService
    {
        private readonly IGroupService _groupService;
        private readonly ITeamService _teamService;
        private readonly IFixtureService _fixtureService;
        private readonly IRepository<FdTeam> _repository;
        private readonly IRepository<CompetitionRoot> _championsLeagueRepository;
        private readonly ChampionsLeague _competition;
        private readonly IRepository<FdPlayers> _playersRepository; 

        public ChampionsLeagueService(
            IGroupService groupService, 
            ITeamService teamService,
            IFixtureService fixtureService,
            IRepository<FdTeam> repository, 
            IRepository<CompetitionRoot> championsLeagueRepository, 
            ChampionsLeague competition,
            IRepository<FdPlayers> playersRepository)
        {
            _groupService = groupService;
            _teamService = teamService;
            _fixtureService = fixtureService;
            _repository = repository;
            _championsLeagueRepository = championsLeagueRepository;
            _competition = competition;
            _playersRepository = playersRepository;
        }

        public ChampionsLeague InitCompetition(int id)
        {
            var competition = _championsLeagueRepository.Search($"/soccerseasons/{id}");
            if (competition != null)
            {
                _competition.Name = competition.caption;
                _competition.NumberOfGames = competition.numberOfGames;
                _competition.NumberOfTeams = competition.numberOfTeams;
                _competition.Groups = InitChampionsLeagueGroups();
            }
            //_competition.Fixtures = _fixtureService.InitSeasonFixtures(id);
            return _competition;
        }

        public IEnumerable<FixtureModel> InitFixturesFor(int matchday, int id)
        {
            return _fixtureService.InitSeasonFixtures(id, matchday);
        }

        public TeamModel InitChampionsLeagueTeam(int id)
        {
            var team = _teamService.InitTeam(id, _repository.Search($"/teams/{id}"));
            team.Players = _playersRepository.Search($"/teams/{id}/players")?.players;
            return team;
        }

        public IEnumerable<GroupModel> InitChampionsLeagueGroups()
        {
            return new List<GroupModel>
            {
                _groupService.InitGroup("Group A", new[]
                {
                    _teamService.InitTeam(86, _repository.Search("/teams/86")),
                    _teamService.InitTeam(524, _repository.Search("/teams/524")),
                    _teamService.InitTeam(724, _repository.Search("/teams/724")),
                    _teamService.InitTeam(749, _repository.Search("/teams/749"))
                }),
                _groupService.InitGroup("Group B", new[]
                {
                    _teamService.InitTeam(11, _repository.Search("/teams/11")),
                    _teamService.InitTeam(674, _repository.Search("/teams/674")),
                    _teamService.InitTeam(66, _repository.Search("/teams/66")),
                    _teamService.InitTeam(751, _repository.Search("/teams/751"))
                }),
                _groupService.InitGroup("Group C", new[]
                {
                    _teamService.InitTeam(78, _repository.Search("/teams/78")),
                    _teamService.InitTeam(495, _repository.Search("/teams/495")),
                    _teamService.InitTeam(610, _repository.Search("/teams/610")),
                    _teamService.InitTeam(1056, _repository.Search("/teams/1056"))
                }),
                _groupService.InitGroup("Group D", new[]
                {
                    _teamService.InitTeam(65, _repository.Search("/teams/65")),
                    _teamService.InitTeam(109, _repository.Search("/teams/109")),
                    _teamService.InitTeam(559, _repository.Search("/teams/559")),
                    _teamService.InitTeam(18, _repository.Search("/teams/18"))
                }),
                _groupService.InitGroup("Group E", new[]
                {
                    _teamService.InitTeam(81, _repository.Search("/teams/81")),
                    _teamService.InitTeam(100, _repository.Search("/teams/100")),
                    _teamService.InitTeam(3, _repository.Search("/teams/3")),
                    _teamService.InitTeam(748, _repository.Search("/teams/748"))
                }),
                _groupService.InitGroup("Group F", new[]
                {
                    _teamService.InitTeam(5, _repository.Search("/teams/5")),
                    _teamService.InitTeam(57, _repository.Search("/teams/57")),
                    _teamService.InitTeam(654, _repository.Search("/teams/654")),
                    _teamService.InitTeam(755, _repository.Search("/teams/755"))
                }),
                _groupService.InitGroup("Group G", new[]
                {
                    _teamService.InitTeam(61, _repository.Search("/teams/61")),
                    _teamService.InitTeam(842, _repository.Search("/teams/842")),
                    _teamService.InitTeam(503, _repository.Search("/teams/503")),
                    _teamService.InitTeam(971, _repository.Search("/teams/971"))
                }),
                _groupService.InitGroup("Group H", new[]
                {
                    _teamService.InitTeam(731, _repository.Search("/teams/731")),
                    _teamService.InitTeam(1057, _repository.Search("/teams/1057")),
                    _teamService.InitTeam(95, _repository.Search("/teams/95")),
                    _teamService.InitTeam(523, _repository.Search("/teams/523"))
                })
            };
        }
    }
}
