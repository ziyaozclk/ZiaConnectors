using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nito.AsyncEx;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using ViaTim.Plugin.Entities;
using ViaTim.Plugin.Entities.Error;

namespace ViaTim.Plugin.Core
{
    public static class RequestEngine
    {
        public static Uri BuildUri(string myApiUrl, bool usingHttps = true)
        {
            var protocolScheme = usingHttps ? "https" : "http";

            var builder = new UriBuilder(myApiUrl)
            {
                Scheme = protocolScheme,
                Port = usingHttps ? 8001 : 80
            };

            return builder.Uri;
        }

        public static IRestClient CreateClient(ViaTimConnectionSettings accessInfo)
        {
            var baseUrl = BuildUri(accessInfo.ApiUrl);

            var client = new RestClient(baseUrl);

            if (!string.IsNullOrEmpty(accessInfo.ApiKey))
            {
                client.AddDefaultParameter("x-auth-token", accessInfo.ApiKey, ParameterType.HttpHeader);
            }

            return client;
        }

        public static IRestRequest CreateRequest(string path, Method method, string rootElement = null)
        {
            return new RestRequest(path, method)
            {
                RootElement = rootElement
            };
        }

        public static TEntity ExecuteRequest<TEntity>(IRestClient baseClient, IRestRequest request)
        {
            var response = baseClient.Execute(request);

            CheckResponseExceptions(response);

            var rootWithoutContent = response.Content;

            if (!string.IsNullOrEmpty(request.RootElement))
            {
                rootWithoutContent = JObject.Parse(response.Content).SelectToken(request.RootElement).ToString();
            }

            var responseData = JsonConvert.DeserializeObject<TEntity>(rootWithoutContent);

            return responseData;
        }

        public static void CheckResponseExceptions(IRestResponse response)
        {
            var statusCode = (int)response.StatusCode;

            if (statusCode < 200 || statusCode >= 300)
            {
                return;
            }

            var error = JsonConvert.DeserializeObject<ErrorBase>(response.Content);

            switch (statusCode)
            {
                case 500:
                    throw new Exception($"{error.Message}");
                case 422:
                    if (error.Message.ToString() == "MultipleUsersFound")
                    {
                        var multipleUsersFound = JsonConvert.DeserializeObject<MultipleUsersFound>(response.Content);

                        throw new Exception(JsonConvert.SerializeObject(multipleUsersFound));
                    }
                    if (error.Message.ToString() == "MissingParams")
                    {
                        var missingParams = JsonConvert.DeserializeObject<MissingParams>(response.Content);

                        throw new Exception(JsonConvert.SerializeObject(missingParams));
                    }
                    break;
            }
        }
    }
}
