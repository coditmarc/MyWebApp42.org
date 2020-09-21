namespace myWebApp42
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using myWebApp42.Models;
    using Microsoft.Azure.Cosmos;
    using Microsoft.Azure.Cosmos.Fluent;
    using Microsoft.Extensions.Configuration;

    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddAzureExceptionAsync(AzureException azureException)
        {
            await this._container.CreateItemAsync<AzureException>(azureException, new PartitionKey(azureException.Id));
        }
         public async Task DeleteAzureExceptionAsync(string id)
        {
            await this._container.DeleteItemAsync<AzureException>(id, new PartitionKey(id));
        }

        public async Task<AzureException> GetAzureExceptionAsync(string id)
        {
            try
            {
                ItemResponse<AzureException> response = await this._container.ReadItemAsync<AzureException>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch(CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            { 
                return null;
            }
        }

        public async Task<IEnumerable<AzureException>> GetAzureExceptionsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<AzureException>(new QueryDefinition(queryString));
            List<AzureException> results = new List<AzureException>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                
                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateAzureExceptionAsync(string id, AzureException azureException)
        {
            await this._container.UpsertItemAsync<AzureException>(azureException, new PartitionKey(id));
        }

    }
}
