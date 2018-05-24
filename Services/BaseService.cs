using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ViaTim.Plugin.Core;

namespace ViaTim.Plugin.Services
{
    public class BaseService
    {
        public BaseService(ViaTimConnectionSettings accessInfo)
        {
            _AccessInfo = accessInfo;
        }
        protected ViaTimConnectionSettings _AccessInfo { get; }

        private static IRestRequest CreateRestRequest(string path, Method method, string rootElement = null, object payload = null, List<Parameter> parameters = null)
        {
            var request = RequestEngine.CreateRequest(path, method, rootElement);

            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new ZiaJsonSerializer(new JsonSerializer());
            request.AddHeader("Content-Type", "application/json");

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    request.AddParameter(param);
                }
            }

            if (payload == null) return request;

            if (method != Method.GET && method != Method.DELETE)
            {
                request.AddBody(payload);
            }
            else
            {
            }

            return request;
        }

        protected virtual TEntity MakeRequest<TEntity>(string path, Method method, string rootElement = null, object payload = null, List<Parameter> parameters = null)
        {
            var request = CreateRestRequest(path, method, rootElement, payload, parameters);

            var client = RequestEngine.CreateClient(_AccessInfo);

            var response = RequestEngine.ExecuteRequest<TEntity>(client, request);

            return response;
        }
    }
}
