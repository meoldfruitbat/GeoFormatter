using System;
using System.IO;
using GeoJsonFormatter.Entities;
using GeoJsonFormatter.Models;
using Newtonsoft.Json;
using NJsonSchema.CodeGeneration.CSharp;

namespace GeoJsonFormatter
{
    class Program
    {
        public static void Main(string[] args)
        {
            var directory = Directory.GetCurrentDirectory();

            string[] files = Directory.GetFiles("/Users/admin/Projects/GeoJsonFormatter/GeoJsonFormatter/App_Data/", "PoleData.geojson", SearchOption.AllDirectories);

            using (var db = new GGContext())
            {
                foreach (string fileName in files)
                {
                    string schema = File.ReadAllText(fileName);

                    var myJsonObject = JsonConvert.DeserializeObject<Root>(schema);


                    foreach (var item in myJsonObject.features)
                    {
                        var newPole = new VmnetworkExpansionReleaseData
                        {


                        };

                    }

                    Console.WriteLine(myJsonObject.type);
                }
            }
        }
    }
}
