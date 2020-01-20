using RestSharp;
using System.Threading.Tasks;

namespace DickinsonBros.DurableRest.Abstractions
{
    public interface IRestRequestFactory
    {
        IRestRequest Create();
    }
}
