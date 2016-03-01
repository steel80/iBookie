using Newtonsoft.Json;

namespace iBookie.Features.DataAccess
{
    [JsonObject(Id = "Rootobject")]
    public class FdPlayers
    {
        public _Links _links { get; set; }
        public int count { get; set; }
        public Player[] players { get; set; }
    }

    public class Player
    {
        public string name { get; set; }
        public string position { get; set; }
        public object jerseyNumber { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
        public string contractUntil { get; set; }
        public string marketValue { get; set; }
    }

}
