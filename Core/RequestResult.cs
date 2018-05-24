using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Core
{
    public class RequestResult<TEntity>
    {
        public RequestResult(IRestResponse response, TEntity result)
        {
            Response = response;
            Result = result;
        }

        public IRestResponse Response { get; }
        public TEntity Result { get; }
    }
}
