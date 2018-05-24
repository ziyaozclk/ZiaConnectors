using AutoMapper;
using Newtonsoft.Json;
using Nito.AsyncEx;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using ViaTim.Plugin.Core;
using ViaTim.Plugin.Entities.Error;
using ViaTim.Plugin.Entities.GpsCoord;
using ViaTim.Plugin.Entities.Package;
using ViaTim.Plugin.Entities.Types;
using ViaTim.Plugin.Services;

namespace ViaTim.Plugin
{
    class Program
    {
        public static PropertyInfo GetProperty(Type modelType, string fieldName)
        {
            var property = modelType.GetProperties().FirstOrDefault(a => a.GetCustomAttribute<JsonPropertyAttribute>().PropertyName == fieldName);

            if (property == null)
            {
                throw new ArgumentNullException(fieldName, $"{modelType}");
            }
            return property;
        }
        public static void CreatePackage()
        {
            PackageService service = new PackageService(new ViaTimConnectionSettings { ApiKey = "K4lh2A0spHIspNify0owr7PPpiAiSnoFLOoVUA8fo1LIQbxBTTwPcjTAOX6D5nIL", ApiUrl = "https://api.viatim.nl:8001/api/v1/" });
            service.Create(new Entities.Package.ViaTimPackageInputFields
            {
                Type = PackageTypes.WebShop,
                Recipient = new Entities.Recipient.ViaTimRecipientInputFields
                {
                    Postcode = "3011AB",
                    Housenr = "31",
                    Phone = "5059794136",
                    Initials = "Test",
                    Firstname = "Ken",
                    Lastname = "Kelk",
                    Email = "ken@ffsnxg.com",
                    Type = UserTypes.NonIntegratedUser
                },
                Weight = 10,
                Value = 12.99,
                Photo = false
            });
        }

        public static void DownloadLabel()
        {
            //using (HttpClient client = new HttpClient())
            //using (HttpResponseMessage response = AsyncContext.Run(() => client.GetAsync(valueAsFileDto.Url)))
            //using (Stream stream = AsyncContext.Run(() => response.Content.ReadAsStreamAsync()))
            //{
            //    Console.WriteLine(stream.Length);
            //}
        }
        static void Main(string[] args)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ViaTimPackageDetail, ViaTimPackage>();
            });
            //CreatePackage();
            PackageService service1 = new PackageService(new ViaTimConnectionSettings { ApiKey = "K4lh2A0spHIspNify0owr7PPpiAiSnoFLOoVUA8fo1LIQbxBTTwPcjTAOX6D5nIL", ApiUrl = "https://api.viatim.nl:8001/api/v1/" });

            var res = JsonConvert.DeserializeObject<ErrorBase>("{\"success\":true,\"message\":{\"id\":12842}}");

            Console.WriteLine();
        }
    }
}
