using System;
using Newtonsoft.Json;

namespace iBookie.Features.DataAccess
{
    [JsonObject(Id = "Rootobject")]
    public class CompetitionRoot
    {
        public CompetitionLinks _links { get; set; }
        public int id { get; set; }
        public string caption { get; set; }
        public string league { get; set; }
        public string year { get; set; }
        public int currentMatchday { get; set; }
        public int numberOfMatchdays { get; set; }
        public int numberOfTeams { get; set; }
        public int numberOfGames { get; set; }
        public DateTime lastUpdated { get; set; }
    }

    [JsonObject(Id = "_Links")]
    public class CompetitionLinks
    {
        public Self self { get; set; }
        public Teams teams { get; set; }
        public Fixtures fixtures { get; set; }
        public Leaguetable leagueTable { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Teams
    {
        public string href { get; set; }
    }

    public class Fixtures
    {
        public string href { get; set; }
    }

    public class Leaguetable
    {
        public string href { get; set; }
    }

    [JsonObject(Id = "Rootobject")]
    public class FixturesRoot
    {
        public FixtureLinks _links { get; set; }
        public int count { get; set; }
        public Fixture[] fixtures { get; set; }
    }

    [JsonObject(Id = "_Links")]
    public class FixtureLinks
    {
        public Self self { get; set; }
        public Soccerseason soccerseason { get; set; }
    }   

    public class Soccerseason
    {
        public string href { get; set; }
    }

    public class Fixture
    {
        public FixtureLinks _links { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
        public int matchday { get; set; }
        public string homeTeamName { get; set; }
        public string awayTeamName { get; set; }
        public Result result { get; set; }
    }

    public class Hometeam
    {
        public string href { get; set; }
    }

    public class Awayteam
    {
        public string href { get; set; }
    }

    public class Result
    {
        public object goalsHomeTeam { get; set; }
        public object goalsAwayTeam { get; set; }
    }

}
