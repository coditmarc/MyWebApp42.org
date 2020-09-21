namespace myWebApp42
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using myWebApp42.Models;

    public interface ICosmosDbService
    {
        Task<IEnumerable<AzureException>> GetAzureExceptionsAsync(string query);
        Task<AzureException> GetAzureExceptionAsync(string id);
        Task AddAzureExceptionAsync(AzureException azureException);
        Task UpdateAzureExceptionAsync(string id, AzureException azureException);
        Task DeleteAzureExceptionAsync(string id);
    }
}
