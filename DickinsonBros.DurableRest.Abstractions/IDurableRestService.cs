﻿using RestSharp;
using System.Threading.Tasks;

namespace DickinsonBros.DurableRest.Abstractions
{
    public interface IDurableRestService
    {
        Task<IRestResponse> ExecuteAsync(IRestClient client, IRestRequest restRequest, int retrys);
        Task<IRestResponse<T>> ExecuteAsync<T>(IRestClient client, IRestRequest restRequest, int retrys);
    }
}
