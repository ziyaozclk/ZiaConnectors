using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ViaTim.Plugin.Core;
using ViaTim.Plugin.Entities.Package;

namespace ViaTim.Plugin.Services
{
    public class PackageService : BaseService
    {
        public PackageService(ViaTimConnectionSettings accessInfo) : base(accessInfo)
        {
        }

        public virtual ViaTimPackageDetail Create(ViaTimPackageInputFields input)
        {
            var objectReponse = this.MakeRequest<PackageRoot>("packages", Method.POST, payload: input);

            var result = objectReponse.Package;

            return result;
        }

        public virtual List<ViaTimPackageDetail> GetList(int pageSize = 20)
        {
            List<ViaTimPackageDetail> packageList = new List<ViaTimPackageDetail>();

            int pageNumber = 1;
            bool readProductContinue = true;

            while (readProductContinue)
            {
                var pagedList = GetAllPaged(pageNumber, pageSize);

                if (pagedList.Count == 0)
                {
                    readProductContinue = false;
                }

                packageList.AddRange(pagedList);

                pageNumber++;
            }

            return packageList;
        }

        public virtual ViaTimPackageDetail Get(string packageId)
        {
            List<Parameter> parameters = new List<Parameter>
            {
                new Parameter{Name="package_id",Value=packageId,Type=ParameterType.UrlSegment}
            };

            var objectReponse = this.MakeRequest<ViaTimPackageDetail>("packages/{package_id}", Method.GET, parameters: parameters, rootElement: "package");

            var result = objectReponse;

            return result;
        }

        public virtual List<ViaTimPackageDetail> GetAllPaged(int pageNumber, int pageSize)
        {
            List<Parameter> filterParams = new List<Parameter>
            {
                new Parameter{Name="page",Value=pageNumber,Type=ParameterType.QueryString},
                new Parameter{Name="limit",Value=pageSize,Type=ParameterType.QueryString}
            };

            var result = this.MakeRequest<List<ViaTimPackageDetail>>("packages", Method.GET, parameters: filterParams, rootElement: "packages");

            return result;
        }

        public virtual ResponseBase Update(string packageId, ViaTimPackage input)
        {
            List<Parameter> parameters = new List<Parameter>
            {
                new Parameter{Name="package_id",Value=packageId,Type=ParameterType.UrlSegment}
            };

            var objectReponse = this.MakeRequest<ResponseBase>("packages/{package_id}", Method.PATCH, payload: input, parameters: parameters);

            return objectReponse;
        }

        public virtual void Delete(string packageId)
        {
            List<Parameter> parameters = new List<Parameter>
            {
                new Parameter{Name="package_id",Value=packageId,Type=ParameterType.UrlSegment}
            };

            var objectReponse = this.MakeRequest<object>("packages/{package_id}", Method.DELETE, parameters: parameters);
        }
    }
}
