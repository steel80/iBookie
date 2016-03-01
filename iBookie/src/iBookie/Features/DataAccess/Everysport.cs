using Newtonsoft.Json;

namespace iBookie.Features.DataAccess
{
    [JsonObject(Id = "Rootobject")]
    public class StandingRoot
    {
        public Credit credit { get; set; }
        public Group[] groups { get; set; }
        public bool liveStandings { get; set; }
    }

    public class Credit
    {
        public string message { get; set; }
        public string link { get; set; }
        public string logoUrl { get; set; }
    }

    public class Group
    {
        public Standing[] standings { get; set; }
    }

    public class Standing
    {
        public Team team { get; set; }
        public Positionstatus[] positionStatuses { get; set; }
        public Stat[] stats { get; set; }
        public int position { get; set; }
        public int previousPosition { get; set; }
        public bool live { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string abbreviation { get; set; }
        public string articleName { get; set; }
        public string articleShortName { get; set; }
        public string link { get; set; }
    }

    public class Positionstatus
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stat
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
