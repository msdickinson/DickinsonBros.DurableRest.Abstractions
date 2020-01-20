using RestSharp;
using System.Threading.Tasks;

namespace DickinsonBros.DurableRest.Abstractions
{
    public interface IRestClientFactory
    {
        IRestClient Create(string baseURL);
    }
}
