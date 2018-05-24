using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using ViaTim.Plugin.Entities.Address;

namespace ViaTim.Plugin.Services
{
    public class AddressService : BaseService
    {
        public AddressService(ViaTimConnectionSettings accessInfo) : base(accessInfo)
        {
        }

        public virtual Address Verify(string postcode, string housenr)
        {
            List<Parameter> parameters = new List<Parameter>
            {
                new Parameter{Name="postcode",Value=postcode,Type=ParameterType.UrlSegment},
                new Parameter{Name="housenr",Value=housenr,Type=ParameterType.UrlSegment}
            };

            var objectReponse = this.MakeRequest<AddressRoot>("postcode/{postcode}/{housenr}", Method.GET, parameters: parameters);

            var result = objectReponse.Address;

            return result;
        }
    }
}
