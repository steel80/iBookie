using Newtonsoft.Json;

namespace iBookie.Features.DataAccess
{
    [JsonObject(Id = "Rootobject")]
    public class FdTeam
    {
        public _Links _links { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string shortName { get; set; }
        public string squadMarketValue { get; set; }
        public string crestUrl { get; set; }
    }

    public class _Links
    {
        public Self self { get; set; }
        public Fixtures fixtures { get; set; }
        public Players players { get; set; }
    }

    public class Players
    {
        public string href { get; set; }
    }

}
