using System.Net.Http;

namespace DickinsonBros.DurableRest.Abstractions.Models
{
    public class HttpResponse<T>
    {
        public HttpResponseMessage HttpResponseMessage { get; set; }
        public T Data { get; set; }
    }
}
