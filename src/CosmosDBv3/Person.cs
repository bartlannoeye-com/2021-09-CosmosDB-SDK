// 3rd party Newtonsoft.Json;
using Newtonsoft.Json;

namespace CosmosDBv3
{
    public class Person
    {
        [JsonProperty("id")]
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
