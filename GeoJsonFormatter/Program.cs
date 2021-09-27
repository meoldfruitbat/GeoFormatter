using System;
using System.IO;
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

            foreach (string fileName in files)
            {
                string schema = File.ReadAllText(fileName);

                 var myJsonObject = JsonConvert.DeserializeObject<Root>(schema);

                Console.WriteLine(myJsonObject.type);
            }
        }
    }
}
