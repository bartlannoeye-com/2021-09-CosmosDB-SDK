using System.Threading.Tasks;
using Azure.Cosmos;

namespace CosmosDBv4
{
    public class Program
    {
        private static async Task Main()
        {
            var person = new Person() { PersonId = "P002", FirstName = "Bob", LastName = "The Builder" };

            // use Azure KeyVault + use Managed Identity for production code
            var cosmosClient = new CosmosClient("AccountEndpoint=https://{cosmosresource}.documents.azure.com:443/;AccountKey={key};");
            // v4 CosmosContainer
            CosmosContainer container = cosmosClient.GetContainer("MyDatabase", "Demo");

            await container.UpsertItemAsync(person);
        }
    }
}
