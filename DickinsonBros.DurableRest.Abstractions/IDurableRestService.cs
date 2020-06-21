using DickinsonBros.DurableRest.Abstractions.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace DickinsonBros.DurableRest.Abstractions
{
    public interface IDurableRestService
    {
        Task<HttpResponseMessage> ExecuteAsync(HttpClient httpClient, HttpRequestMessage httpRequestMessage, int retrys, double timeoutInSeconds);
        Task<HttpResponse<T>> ExecuteAsync<T>(HttpClient httpClient, HttpRequestMessage httpRequestMessage, int retrys, double timeoutInSeconds);
    }
}
