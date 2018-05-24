using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViaTim.Plugin.Core
{
    public interface ICustomRequest : IRestRequest
    {
        string RootElement { get; set; }
    }
}
