using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

namespace CosmosDBv3
{
    public class Program
    {
        private static async Task Main()
        {
            var person = new Person() {PersonId = "P001", FirstName = "Bob", LastName = "The Builder"};
            
            // use Azure KeyVault + use Managed Identity for production code
            var cosmosClient = new CosmosClient("AccountEndpoint=https://{cosmosresource}.documents.azure.com:443/;AccountKey={key};");
            // v3 Container
            Container container = cosmosClient.GetContainer("MyDatabase", "Demo");

            await container.UpsertItemAsync(person);
        }
    }
}
