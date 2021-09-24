// built-in JsonSerializer
using System.Text.Json.Serialization;

namespace CosmosDBv4
{
    public class Person
    {
        [JsonPropertyName("id")]
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
