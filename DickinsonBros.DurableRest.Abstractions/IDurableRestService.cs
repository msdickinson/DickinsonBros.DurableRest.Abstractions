using RestSharp;
using System.Threading.Tasks;

namespace DickinsonBros.DurableRest.Abstractions
{
    public interface IDurableRestService
    {
        Task<IRestResponse> ExecuteAsync(IRestRequest restRequest, string baseURL, int retrys);
        Task<IRestResponse<T>> ExecuteAsync<T>(IRestRequest restRequest, string baseURL, int retrys);
    }
}
