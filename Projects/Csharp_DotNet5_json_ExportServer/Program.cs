using Bright.Serialization;
using System;
using System.IO;
using System.Text.Json;

namespace Csharp_Server_DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var tables = new cfg.Tables(LoadJson);

            Console.WriteLine("== load succ ==");
        }

        private static JsonElement LoadJson(string file)
        {
            return JsonDocument.Parse(System.IO.File.ReadAllBytes("../../../json_server/" + file + ".json")).RootElement;
        }
    }
}
